using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdvCodeWizard.Forms
{
      public partial class frm_validateCodeGenerator : Form
      {
            string _database = "";

            public frm_validateCodeGenerator(string pdatabase)
            {
                  InitializeComponent();
                  _database = pdatabase;
            }

            private void frm_validateCodeGenerator_Load(object sender, EventArgs e)
            {
                  ComboEdit_option.SelectedIndex = 0;
                  
            }

            private void gridControl1_Click(object sender, EventArgs e)
            {

            }

            private void checkEdit1_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void simpleButton2_Click(object sender, EventArgs e)
            {
                  if (ComboEdit_option.SelectedIndex == 0)
                        generateValidate();
                  else
                        generateCheckCounts();





            }

            private void simpleButton1_Click(object sender, EventArgs e)
            {

                  

                  if (TextEdit_names.EditValue == null)
                        return;
                  else if (TextEdit_names.EditValue.ToString() == "")
                        return;

                  if (TextEdit_prefix.EditValue == null)
                        return;
                  else if (TextEdit_prefix.EditValue.ToString() == "")
                        return;


                  if (ComboEdit_option.SelectedIndex == 0)
                        dATASET_validateCodeGenerator.dt_validateCodeGenerator.Rows.Add(TextEdit_names.Text.ToString());
                  else
                  {
                        dATASET_validateCodeGenerator.dt_validateCodeGenerator.Rows.Add(TextEdit_prefix.Text.ToString(), TextEdit_names.Text.ToString());
                        
                              TextEdit_prefix.Text = "";
                  }
                  TextEdit_names.Text = "";

            }

            private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
            {

            }

            private void xtraTabControl1_Click(object sender, EventArgs e)
            {

            }



            void generateCheckCounts()
            {



                  if (TextEdit_primaryCOlumns.EditValue == null)
                        return;
                  else if (TextEdit_primaryCOlumns.EditValue.ToString() == "")
                        return;


/*
                declare @counts as int = 0
				declare @query as nvarchar(max) = ''

                set @query  =  (select PakAsia_Current.dbo.check_IS_Rows_Count_Greater_Than_Zero('TBL_PACKINGS_DEF', 'PACKING_DEF_unit',@UNIT_ID,@CMP_ID,@BRC_ID))
                EXECUTE sp_executesql @query, N'@cnt int OUTPUT',  @cnt=@counts OUTPUT


				if @counts > 0
				 begin
				 
				     select (select dbo.Errors.value from dbo.Errors where [key] = 'CD') , @UNIT_ID
				     RETURN
				   
				 end

*/




                  string code = "               declare @counts as int = 0 " + Environment.NewLine + 
                                "				declare @query as nvarchar(max) = ''" + Environment.NewLine ;

                  foreach (DataRow dr in dATASET_validateCodeGenerator.dt_validateCodeGenerator.Rows)
                  {

                        string TableName = dr["Name"].ToString();
                        string ColumnName =  dr["Name2"].ToString();

                        string primaryCOlumns = TextEdit_primaryCOlumns.Text;

                        string singleCode = "";


                        singleCode = "                set @query  =  (select " + _database + ".dbo.getQueryCheckingCount('" + TableName + "', '" + ColumnName + "',@" + primaryCOlumns + ",@CMP_ID,@BRC_ID))" +

            Environment.NewLine + "                EXECUTE sp_executesql @query, N'@cnt int OUTPUT',  @cnt=@counts OUTPUT" +
            Environment.NewLine + "				if @counts > 0" +
            Environment.NewLine + "				 begin" +
            Environment.NewLine +
            Environment.NewLine + "				     select (select dbo.Errors.value from dbo.Errors where [key] = 'CD') , @" + primaryCOlumns + 
            Environment.NewLine + "				     RETURN" +
            Environment.NewLine + 
            Environment.NewLine + "				 end" +

                                          
                                          
                                          Environment.NewLine + Environment.NewLine;


                        code += singleCode;



                  }



                  MemoEdit_code.Text = code;
                  //xtraTabControl2.SelectedTabPageIndex =1;

            }

            void generateValidate()
            {

                  string code = "";

                  foreach (DataRow dr in dATASET_validateCodeGenerator.dt_validateCodeGenerator.Rows)
                  {

                        string controlName = TextEdit_prefix.Text + "." + dr["Name"].ToString();

                        string singleCode = "";


                        singleCode = " if (" + controlName + ".EditValue == null)" +
                                        Environment.NewLine + "{" +
                                        Environment.NewLine + @"validateStatus = ""V_P"";" +
                                        Environment.NewLine + "return  validateStatus;" +
                                        Environment.NewLine + "}" +
                                       Environment.NewLine + "else if (" + controlName + @".EditValue.ToString() == """")" +
                                          Environment.NewLine + "{" +
                                        Environment.NewLine + @"validateStatus = ""V_P"";" +
                                        Environment.NewLine + "return  validateStatus;" +
                                        Environment.NewLine + "}" +


                                          Environment.NewLine + Environment.NewLine;


                        code += singleCode;



                  }



                  MemoEdit_code.Text = code;
                  //xtraTabControl2.SelectedTabPageIndex =1;

            }


            private void xtraTabControl2_Click(object sender, EventArgs e)
            {

            }

            private void simpleButton2_Click_1(object sender, EventArgs e)
            {
                  dATASET_validateCodeGenerator.dt_validateCodeGenerator.Rows.Clear();
                  MemoEdit_code.Text = "";
                  TextEdit_names.Text = "";
                  TextEdit_prefix.Text = "";
                  

            }
           

            private void label1_Click(object sender, EventArgs e)
            {

            }
      }
}

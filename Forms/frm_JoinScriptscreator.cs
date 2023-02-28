using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AdvCodeWizard.Forms
{
      public partial class frm_JoinScriptscreator : DevExpress.XtraEditors.XtraForm
      {
            public frm_JoinScriptscreator()
            {
                  InitializeComponent();
            }
            GenericClasses.getComboBoxes obj = new GenericClasses.getComboBoxes();
                
            private void frm_JoinScriptscreator_Load(object sender, EventArgs e)
            {
                  referesh();

            }

            void referesh()
            {
                  try
                  {

                        obj.getTabels(ComboBoxEdit_parentTable);
                        obj.getTabels(ComboBoxEdit_childTable);

                        obj.getColumns(ComboBoxEdit_primaryKey, ComboBoxEdit_parentTable.Text);

                        obj.getColumns(ComboBoxEdit_foreignKey, ComboBoxEdit_childTable.Text);

                        dataSet_JoinScriptGenerator.dt_joinScriptGenerator.Rows.Clear();
                        ComboBoxEdit_parentTable.SelectedIndex =
                              ComboBoxEdit_childTable.SelectedIndex =
                              ComboBoxEdit_primaryKey.SelectedIndex =
                              ComboBoxEdit_foreignKey.SelectedIndex = 0;
                        MemoEdit_code.Text = "";

                  }
                  catch (Exception ex)
                  {

                        MessageBox.Show("Error");

                  }
            }

            private void gridControl1_Click(object sender, EventArgs e)
            {

            }

            private void simpleButton2_Click(object sender, EventArgs e)
            {
                  dataSet_JoinScriptGenerator.dt_joinScriptGenerator.Rows.Add();
            }

            private void simpleButton5_Click(object sender, EventArgs e)
            {
                  dataSet_JoinScriptGenerator.dt_joinScriptGenerator.Rows.Add(
                        
                        ComboBoxEdit_parentTable.Text,
                         ComboBoxEdit_primaryKey.Text,
 ComboBoxEdit_childTable.Text,
 ComboBoxEdit_foreignKey.Text
                       );

                  if (CheckEdit_linkToNext.Checked)
                  {
                        ComboBoxEdit_parentTable.EditValue = ComboBoxEdit_childTable.EditValue;
                        ComboBoxEdit_primaryKey.EditValue = ComboBoxEdit_foreignKey.EditValue;


                  }

            }

            private void simpleButton4_Click(object sender, EventArgs e)
            {
                  referesh();
            }

            private void ComboBoxEdit_parentTable_SelectedIndexChanged(object sender, EventArgs e)
            {

                  obj.getColumns(ComboBoxEdit_primaryKey, ComboBoxEdit_parentTable.Text);

                 
            }

            private void ComboBoxEdit_childTable_SelectedIndexChanged(object sender, EventArgs e)
            {
                  obj.getColumns(ComboBoxEdit_foreignKey, ComboBoxEdit_childTable.Text);
            }

            private void simpleButton3_Click(object sender, EventArgs e)
            {
                  generate();
            }

            void generate()
            {

                  string code = "";
                  bool isFirst = true; 
                  foreach (DataRow dr in dataSet_JoinScriptGenerator.dt_joinScriptGenerator.Rows)
                  {


                        string parentTable = dr["ParentTable"].ToString();
                        string childTable = dr["ChildTable"].ToString();
                        string primaryKey = dr["PrimaryKey"].ToString();
                        string foreignKey = dr["ForeignKey"].ToString();


                       
                        string singleCode = "";

                        if (isFirst)
                        {
                              singleCode = "			" + parentTable +
                                              Environment.NewLine + "			   join";
                        }
                        else
                        {
                              singleCode = Environment.NewLine + "			   join" +
                                    
                                    "			" + parentTable ;


                        }

                        singleCode += Environment.NewLine + "			   " + childTable +
                                        Environment.NewLine + "				on " + parentTable + "." + primaryKey + " = " + childTable + "." + foreignKey;
                                        


                        if(CheckEdit_CMP.Checked)
                              singleCode += Environment.NewLine + " 				   and " + parentTable + ".CMP_ID = " + childTable + ".CMP_ID";
                       if(CheckEdit_BRC.Checked)
                              singleCode += Environment.NewLine + " 				   and " + parentTable + ".BRC_ID = " + childTable + ".BRC_ID";
                       if(CheckEdit_IsDeleted.Checked)
                              singleCode += Environment.NewLine + " 				   and " + parentTable + ".Is_Deleted = " + childTable + ".Is_Deleted";
                                  
                        
                        singleCode+=       Environment.NewLine + Environment.NewLine;


                        code += singleCode;
                        isFirst = false;


                  }



                  MemoEdit_code.Text = code;
                  //xtraTabControl2.SelectedTabPageIndex =1;

            }


      }
}
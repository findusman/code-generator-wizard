using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using AdvCodeWizard.GenericClasses;
namespace AdvCodeWizard.FormWizard
{
    public partial class frm_FORMWIZARD : Form
    {

        frm_FORMWIZARD_P objfrm_FORMWIZARD_P = null;
       
       
           public frm_FORMWIZARD(  )
        {
            InitializeComponent();

          
            objfrm_FORMWIZARD_P = new frm_FORMWIZARD_P(this);
           
            GV_ParentPath = Application.StartupPath;
            
            GV_PathTypes = GV_ParentPath + @"\FD\AvailableControls\Types.txt";
            GV_PathDataTypes = GV_ParentPath + @"\FD\AvailableControls\DataTypes.txt";

            GV_PathTypesP = GV_ParentPath + @"\FD\AvailableControls\TypesP.txt";
         
               GV_PathDefaultTypes = GV_ParentPath + @"\FD\AvailableControls\DefaultTypes.txt";

            GV_PathPostFix = GV_ParentPath + @"\FD\ControlsCode\Postfix.txt";
            GV_PathPreFix = GV_ParentPath + @"\FD\ControlsCode\Prefix.txt";
            GV_PathControl = GV_ParentPath + @"\FD\ControlsCode\";

            GV_PathEventsPostfix = GV_ParentPath + @"\FD\ControlsCode\EventsPostfix.txt";


            GV_PathDesignerClassTemplateMain = GV_ParentPath + @"\FD\FormCode\DesignerClassTemplateMain.txt";
            GV_PathDesignerClassTemplateMainDetail = GV_ParentPath + @"\FD\FormCode\DesignerClassTemplateMainDetail.txt";
             
               GV_PathFormClassTemplateMain = GV_ParentPath + @"\FD\FormCode\FormClassTemplateMain.txt";
               GV_PathFormClassTemplateMainDetail = GV_ParentPath + @"\FD\FormCode\FormClassTemplateMainDetail.txt";
            
               GV_PathPartialFormClassTemplateMain = GV_ParentPath + @"\FD\FormCode\PartialFormClassTemplateMain.txt";
               GV_PathPartialFormClassTemplateMainDetail = GV_ParentPath + @"\FD\FormCode\PartialFormClassTemplateDetail.txt";
               

            GV_PathValuesGettingTemplate = GV_ParentPath + @"\FD\BLLCode\ValuesGettingTemplate.txt";
            GV_PathValuesSettingTemplate = GV_ParentPath + @"\FD\BLLCode\ValuesSettingTemplate.txt";
            GV_PathDefinationFormProperties = GV_ParentPath + @"\FD\Properties\DefinationFormProperties.txt";
            GV_PathTextEditIntIDMaskProperties = GV_ParentPath + @"\FD\Properties\TextEditIntIDMaskProperties.txt";
            GV_PathAddress = GV_ParentPath + @"\FD\Paths\Paths.txt";
            GV_PathDesignerClassTemplateD = GV_ParentPath + @"\FD\FormCode\DesignerClassTemplateD.txt";
            GV_PathFormClassTemplateD = GV_ParentPath + @"\FD\FormCode\FormClassTemplateD.txt";
            GV_PathPartialFormClassTemplateD = GV_ParentPath + @"\FD\FormCode\PartialFormClassTemplateD.txt";
            GV_PathDefinationAllNeeds = GV_ParentPath + @"\FD\FormCode\DefinationAllNeeds.txt";

            string[] arr_controls = File.ReadAllLines(GV_PathAddress);
            GV_PathForDataSetClass = arr_controls[0];

            loadControls();
            loadDatasets();

        }



           void loadDatasets()
           {

               string[] textdatatypes = System.IO.File.ReadAllLines(GV_PathDataTypes);
               RepositoryItemComboBox_DataSet.Items.Clear();

                foreach (string str in textdatatypes)
               {
                  // repositoryItemComboBox_datatypes.Items.Add(str);
               }
               string text = System.IO.File.ReadAllText(GV_PathForDataSetClass);
               string[] temp_splited = System.Text.RegularExpressions.Regex.Split(text, "public DataSet"); // text.Split((?).ToArray<char>,null);
               RepositoryItemComboBox_DataSet.Items.Clear();

               foreach (string str in temp_splited)
               {
                   string tmpstr = str.TrimStart().Substring(0, 2), actual_text = "";

                   if (tmpstr == "f_")
                   {

                       tmpstr = str.Replace("char pSTATUS", "'L'").Replace("property_allocation", "false");
                       String[] tmpstr2 = tmpstr.Split(')');
                       RepositoryItemComboBox_DataSet.Items.Add(tmpstr2[0].ToString() + ");");

                   }

               }

           }

     public string GV_Solutionprefix = "";
      

      public  string GV_C_Columns = "Columns";
      public  string GV_C_Caption = "Caption";
      public  string GV_C_Control = "Control";
      public  string GV_C_Tag = "Tag";
      public  string GV_C_DataType = "DataType";
      public  string GV_C_Prefix = "Prefix";
      public  string GV_C_Status = "Status";
      public string GV_C_Description = "Description";
      public string GV_C_SetValueInfo = "SetValueInfo";
      public string GV_C_GetValueInfo = "GetValueInfo";
      public string GV_C_IsButton = "IsButton";
   
      public string GV_C_IsFixedWidth = "IsFixedWidth";
     


      public string GV_PathSaving = "";

       public  string GV_primary_keyControl = "";

       public static string AGV_DefPath = "";
       public static string GV_primary_key = "primary_key";

       public  string GV_DefaultControl = "";

        public string GV_ParentPath = "";
        public string GV_PathTypes = "";
        public string GV_PathDataTypes = "";
        public string GV_PathTypesP = "";
        public string GV_PathDefaultTypes = "";
        public string GV_PathPostFix = "";
        public string GV_PathPreFix = "";
        public string GV_PathControl = "";
        public string GV_PathControlP = "";
        public string GV_PathEventsPostfix = "";

        public string GV_PathPartialFormClass = "";
       

        public string GV_PathValuesSettingTemplate = "";
        public string GV_PathValuesGettingTemplate = "";

        public string GV_PathDesignerClassTemplateMain = "";
        public string GV_PathDesignerClassTemplateMainDetail = "";
        public string GV_PathDesignerClassTemplateDetail = "";

        public string GV_PathFormClassTemplateMain = "";
        public string GV_PathFormClassTemplateMainDetail = "";
        public string GV_PathFormClassTemplateDetail = "";

        public string GV_PathPartialFormClassTemplateMain = "";
        public string GV_PathPartialFormClassTemplateMainDetail = "";
        public string GV_PathPartialFormClassTemplateDetail = "";

        public string GV_PathDefinationFormProperties = "";
        public string GV_PathTextEditIntIDMaskProperties = "";


        public string GV_PathAddress = "";
        public string GV_PathForDataSetClass = "";

        public string GV_PathDesignerClassTemplateD = "";
        public string GV_PathFormClassTemplateD = "";
        public string GV_PathPartialFormClassTemplateD = "";
        public string GV_PathDefinationAllNeeds = "";

        public string AGV_NameTblDef= "";
  




        void loadControls()
        {
            string[] arr_controls = File.ReadAllLines(GV_PathTypes);
            string[] arr_controlsP = File.ReadAllLines(GV_PathTypesP);
            repositoryItemComboBox1.Items.Clear();
            //repositoryItemComboBox_Repository.Items.Clear();
            foreach (string str in arr_controls)
                repositoryItemComboBox1.Items.Add(str);

            //foreach (string str in arr_controlsP)
               // repositoryItemComboBox_Repository.Items.Add(str);

        }


        void loadDetailColumns()
        {

            dataSet.dt_columnsDEF.Rows.Clear();
           
            string[] arr_defaultcontrol = File.ReadAllLines(GV_PathDefaultTypes);

            foreach (DataRow row in cls_Global.GO_Tables_DetProcessedColumns.Rows)
                dataSet.dt_columnsDEF.Rows.Add(
                                                row[cls_Columns.Column_Names],
                                                row[cls_Columns.Column_Names],
                                                1,
                                                "N|N|N|N",
                                                true,
                                                100
                                                );

           
        }
        void loadMainColumns()
        {

            dataSet.dt_columns.Rows.Clear();
            
            string[] arr_defaultcontrol = File.ReadAllLines(GV_PathDefaultTypes);

            foreach (DataRow row in cls_Global.GO_Tables_MainColumns.Rows)
                dataSet.dt_columns.Rows.Add(
                                            row[cls_Columns.Column_Names],
                                            row[cls_Columns.Column_Names],
                                            row[cls_Columns.DT_Features_defaultControl],
                                            row[cls_Columns.DT_Features_defaultTag],
                                             row[cls_Columns.DT_Features_dotNetGettingLogin],
                                            row[cls_Columns.DT_Features_dotNetSettingLogin],
                                            row[cls_Columns.DT_Features_dotNetWrapperTypes]
                                            );



            //foreach (DataRow row in cls_Global.GO_Tables_DetColumns.Rows)
            //    dataSet.dt_columnsDEF.Rows.Add(row[cls_Columns.Column_Names], row[cls_Columns.Column_Names], arr_defaultcontrol[3], "N|N|N", row[cls_Columns.DT_Features_dotNetTypes], true, "", "", arr_defaultcontrol[1], arr_defaultcontrol[2], true, (row[cls_Columns.Column_Names].ToString() == GV_primary_key ? true : false), true, 75, "", "string"); 

            if (c_print.Checked)
                dataSet.dt_columns.Rows.Add(
                                               "Print",
                                               "Print",
                                               2,
                                               "Print"
                                               );
            if (c_AddChilds.Checked)
                dataSet.dt_columns.Rows.Add(
                                              "Add_Child",
                                              "Add Child",
                                              2,
                                              "Add_Child"
                                              );
            if (c_addSblings.Checked)
                dataSet.dt_columns.Rows.Add(
                                              "Add_Sbling",
                                              "Add Sbling",
                                              2,
                                              "Add_Sbling"
                                              );
            if (c_Preview.Checked)
                dataSet.dt_columns.Rows.Add(
                                              "Preview",
                                              "Preview",
                                              2,
                                              "Preview"
                                              );
            if (c_Export.Checked)
                dataSet.dt_columns.Rows.Add(
                                              "Export",
                                              "Export",
                                              2,
                                              "Export"
                                              );
        }

        void loadColumns()
        {

            if (cls_Global.GV_Is_Main)
                loadMainColumns();
            if (cls_Global.GV_Is_Details)
            {
                loadDetailColumns();
                loadDatasets();
            }
        }


        private void bind()
        {
            RepositoryItemLookUpEdit_Controls.DataSource = cls_Global.GO_Tables_EditorsLookUp;
            RepositoryItemLookUpEdit_Controls.PopulateColumns();
            RepositoryItemLookUpEdit_Controls.ValueMember = cls_Columns.CONTROL_INFO_ID;
            RepositoryItemLookUpEdit_Controls.DisplayMember = cls_Columns.CONTROL_INFO_name;
            RepositoryItemLookUpEdit_Controls.Columns[cls_Columns.CONTROL_INFO_ID].Caption = "IDs";
            RepositoryItemLookUpEdit_Controls.Columns[cls_Columns.CONTROL_INFO_name].Caption = "Names";

            RepositoryItemLookUpEdit_repositoryControls.DataSource = cls_Global.GO_Tables_RepositoryLookUp;
            RepositoryItemLookUpEdit_repositoryControls.PopulateColumns();
            RepositoryItemLookUpEdit_repositoryControls.ValueMember = cls_Columns.CONTROL_INFO_ID;
            RepositoryItemLookUpEdit_repositoryControls.DisplayMember = cls_Columns.CONTROL_INFO_name;
            RepositoryItemLookUpEdit_repositoryControls.Columns[cls_Columns.CONTROL_INFO_ID].Caption = "IDs";
            RepositoryItemLookUpEdit_repositoryControls.Columns[cls_Columns.CONTROL_INFO_name].Caption = "Names";
    
            

        }
     
        private void frm_FORMWIZARD_Load(object sender, EventArgs e)
        {
            GenericClasses.cls_GenericFunctions.loadNameSpaces(ComboBoxEdit_nameSpace);
            t_tableName.Text = cls_Global.GV_Main_Table_Name;

           GridView_mainTableColumns.BestFitColumns();

           if (!cls_Global.GV_Is_Main)
               Tab_Main.PageVisible = false;
           if (!cls_Global.GV_Is_Details)
               Tab_Defination.PageVisible = false;

           if (!cls_Global.GV_Is_Main && cls_Global.GV_Is_Details)
               this.Text = cls_Global.GV_DET_Table_Name;
           else
               if (cls_Global.GV_Is_Main && !cls_Global.GV_Is_Details)
                   this.Text = cls_Global.GV_Main_Table_Name;
               else if (cls_Global.GV_Is_Main && cls_Global.GV_Is_Details)
                   this.Text = cls_Global.GV_Main_Table_Name +"  ,  "+ cls_Global.GV_DET_Table_Name;

           bind();
           loadColumns();

           m_dataset.Text = cls_Global.GV_DataSet;
           m_getMax.Text = cls_Global.GV_GetMAX;
           m_BLL.Text = cls_Global.GV_BLL;
           m_columnsMain.Text = cls_Global.GV_ColumnsNamesMain;
           m_insertionsotreprocedureMain.Text = cls_Global.GV_ProcedureInsertionMain;
           m_selection.Text = cls_Global.GV_Prpcedure_Selection;
           m_updation.Text = cls_Global.GV_ProcedureUpdation;
           m_deletion.Text = cls_Global.GV_ProcedureDeletion;
           t_caption.Text = cls_Global.GV_Main_Table_Name;
           m_insertionDetai.Text = cls_Global.GV_ProcedureInsertionDet;
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
              int x = dataSet.dt_columns.Count;
              if (x > 0)
              {
                  cls_Global.GO_Tables_MainProcessedColumns = dataSet.dt_columns;
                  cls_Global.GO_Tables_DetProcessedColumns = dataSet.dt_columnsDEF;
                  objfrm_FORMWIZARD_P.generat();

              }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            loadColumns();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {


        

        
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == cls_Columns.CONTROL_INFO_ID)
                {

                    DataRow[] drAll = cls_Global.GO_Tables_Editors.Select(cls_Columns.CONTROL_INFO_ID + " = '" + e.Value.ToString() + "'");
                    if (drAll.Length > 0)
                    {
                        DataRow drTmp = drAll[0];
                        
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_name], drTmp[cls_Columns.CONTROL_INFO_name].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_type], drTmp[cls_Columns.CONTROL_INFO_type].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_gettingPrefixOrPostFixCode], drTmp[cls_Columns.CONTROL_INFO_gettingPrefixOrPostFixCode].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_settingPrefixOrPostFixCode], drTmp[cls_Columns.CONTROL_INFO_settingPrefixOrPostFixCode].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_declaringCode], drTmp[cls_Columns.CONTROL_INFO_declaringCode].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_initializingCode], drTmp[cls_Columns.CONTROL_INFO_initializingCode].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_assigningAttributesCode], drTmp[cls_Columns.CONTROL_INFO_assigningAttributesCode].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_event], drTmp[cls_Columns.CONTROL_INFO_event].ToString());
           
                        if (e.Value.ToString() == "2")
                        {
                            string tmpTag = GridView_mainTableColumns.GetRowCellValue(e.RowHandle,GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_columnTag]).ToString();
                            string tmpEvent = drTmp[cls_Columns.CONTROL_INFO_event].ToString();
                            string tmpEventBody = tmpEvent.Replace("Event_Body", "Even_Body_"+tmpTag);
                            GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_event], tmpEventBody);

                        }
                        
                    }
                    else
                        return;


                }

            }
            catch (Exception ex)
            {

            }
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            
            
            //if (index < 0)
            //    return;
            //string ControlID = dataSet.dt_columns.Rows[index][cls_Columns.CONTROL_INFO_ID].ToString();  //gridView1.GetRowCellValue(index, gridView1.Columns[cls_Columns.CONTROL_INFO_ID]).ToString();
            //if (ControlID == "")
            //    return;
            //DataRow[] drAll = cls_Global.GO_Tables_Editors.Select(cls_Columns.CONTROL_INFO_ID + " = '" + ControlID + "'");
            //if (drAll.Length > 0)
            //{
            //    DataRow drTmp = drAll[0];

            //    gridView1.SetRowCellValue(index, gridView1.Columns[cls_Columns.CONTROL_INFO_name], drTmp[cls_Columns.CONTROL_INFO_name].ToString());
            //    gridView1.SetRowCellValue(index, gridView1.Columns[cls_Columns.CONTROL_INFO_type], drTmp[cls_Columns.CONTROL_INFO_type].ToString());
            //    gridView1.SetRowCellValue(index, gridView1.Columns[cls_Columns.CONTROL_INFO_gettingPrefixOrPostFixCode], drTmp[cls_Columns.CONTROL_INFO_gettingPrefixOrPostFixCode].ToString());
            //    gridView1.SetRowCellValue(index, gridView1.Columns[cls_Columns.CONTROL_INFO_settingPrefixOrPostFixCode], drTmp[cls_Columns.CONTROL_INFO_settingPrefixOrPostFixCode].ToString());
            //    gridView1.SetRowCellValue(index, gridView1.Columns[cls_Columns.CONTROL_INFO_declaringCode], drTmp[cls_Columns.CONTROL_INFO_declaringCode].ToString());
            //    gridView1.SetRowCellValue(index, gridView1.Columns[cls_Columns.CONTROL_INFO_initializingCode], drTmp[cls_Columns.CONTROL_INFO_initializingCode].ToString());
            //    gridView1.SetRowCellValue(index, gridView1.Columns[cls_Columns.CONTROL_INFO_assigningAttributesCode], drTmp[cls_Columns.CONTROL_INFO_assigningAttributesCode].ToString());
            //    if (ControlID == "2")
            //    {
            //        string tmpTag = gridView1.GetRowCellValue(index, gridView1.Columns[cls_Columns.CONTROL_INFO_columnTag]).ToString();
            //        string tmpEvent = drTmp[cls_Columns.CONTROL_INFO_event].ToString();
            //        string tmpEventBody = tmpEvent.Replace("Event_Body", "Even_Body_" + tmpTag);
            //        gridView1.SetRowCellValue(index, gridView1.Columns[cls_Columns.CONTROL_INFO_event], tmpEventBody);

            //    }

            //}
            //else
            //    return;
            
        }

     
        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
           

           
            try
            {
                if (e.Column.FieldName == cls_Columns.CONTROL_INFO_ID)
                {
                    string ControlID = GridView_mainTableColumns.GetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_ID]).ToString();
                    if (ControlID == "")
                        return;
                    DataRow[] drAll = cls_Global.GO_Tables_Editors.Select(cls_Columns.CONTROL_INFO_ID + " = '" + ControlID + "'");
                    if (drAll.Length > 0)
                    {
                        DataRow drTmp = drAll[0];
                        
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_name], drTmp[cls_Columns.CONTROL_INFO_name].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_type], drTmp[cls_Columns.CONTROL_INFO_type].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_gettingPrefixOrPostFixCode], drTmp[cls_Columns.CONTROL_INFO_gettingPrefixOrPostFixCode].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_settingPrefixOrPostFixCode], drTmp[cls_Columns.CONTROL_INFO_settingPrefixOrPostFixCode].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_declaringCode], drTmp[cls_Columns.CONTROL_INFO_declaringCode].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_initializingCode], drTmp[cls_Columns.CONTROL_INFO_initializingCode].ToString());
                        GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_assigningAttributesCode], drTmp[cls_Columns.CONTROL_INFO_assigningAttributesCode].ToString());
                        if (ControlID == "2")
                        {
                            string tmpTag = GridView_mainTableColumns.GetRowCellValue(e.RowHandle,GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_columnTag]).ToString();
                            string tmpEvent = drTmp[cls_Columns.CONTROL_INFO_event].ToString();
                            string tmpEventBody = tmpEvent.Replace("Event_Body", "Even_Body_"+tmpTag);
                            GridView_mainTableColumns.SetRowCellValue(e.RowHandle, GridView_mainTableColumns.Columns[cls_Columns.CONTROL_INFO_event], tmpEventBody);

                        }
                        
                    }
                    else
                        return;


                }

            }
            catch (Exception ex)
            {

            }

               
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {

        }

        private void GridControl_gridViewBindings_DoubleClick(object sender, EventArgs e)
        {
           
        
                
                }

        private void button4_Click(object sender, EventArgs e)
        {

            ComboBoxEdit_columns.Properties.Items.Clear();
            foreach (DataRow dr in dataSet.dt_columns.Rows)
                if (dr[cls_Columns.CONTROL_INFO_ID].ToString() == "9")
                    ComboBoxEdit_columns.Properties.Items.Add(dr[cls_Columns.CONTROL_INFO_Column].ToString());
            ComboBoxEdit_columns.SelectedIndex = 0;

            foreach (DataRow dr in cls_Global.GO_Tables_AllTables.Rows)
                  ComboBoxEdit_tables.Properties.Items.Add(dr["Table Names"].ToString());
            ComboBoxEdit_tables.SelectedIndex = 0;
            loadColumnsAgainstNewTable();


        }

            void loadColumnsAgainstNewTable()
            {
                try
                {
                    ComboBoxEdit_displayMember.Properties.Items.Clear();
                    ComboBoxEdit_valueMember.Properties.Items.Clear();
                    BLL.cls_BLLFunctionss obj_cls_BLLFunctionss = new BLL.cls_BLLFunctionss();
                    DataTable dt = obj_cls_BLLFunctionss.loadOnlyColumns(ComboBoxEdit_tables.SelectedItem.ToString());
                    foreach (DataRow dr in dt.Rows)
                    {
                        ComboBoxEdit_displayMember.Properties.Items.Add(dr["Column Names"].ToString());
                        ComboBoxEdit_valueMember.Properties.Items.Add(dr["Column Names"].ToString());
                    }
                    ComboBoxEdit_displayMember.SelectedIndex = 0;
                    ComboBoxEdit_valueMember.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Columns are not ding fetched against table","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
                    
            }

            private void button11_Click(object sender, EventArgs e)
            {
                dataSet.dt_dingingDataSource.Rows.Add(

                       ComboBoxEdit_columns.SelectedItem.ToString(),
                        ComboBoxEdit_tables.SelectedItem.ToString(),
                        ComboBoxEdit_displayMember.SelectedItem.ToString(),
                        ComboBoxEdit_valueMember.SelectedItem.ToString(),
                        ComboBoxEdit_nameSpace.SelectedItem.ToString()
                        );
                cls_GenericFunctions.DT_bindedTable = dataSet.dt_dingingDataSource.Copy();

            }

            private void button12_Click(object sender, EventArgs e)
            {
                dataSet.dt_dingingDataSource.Rows.Clear();
            }

            private void ComboBoxEdit_tables_SelectedIndexChanged(object sender, EventArgs e)
            {
                loadColumnsAgainstNewTable();
            }
        

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using AdvCodeWizard.GenericClasses;

namespace AdvCodeWizard.FormWizard
{
    public class AdditionalClass
    {


        public string GV_BLLClass = "";
        public string GV_TableName = "";


        public string GV_C_Columns = "Columns";
        public string GV_C_Caption = "Caption";
        public string GV_C_Control = "Control";
        public string GV_C_Tag = "Tag";
        public string GV_C_DataType = "DataType";
        public string GV_C_Prefix = "Prefix";
        public string GV_C_Status = "Status";
        public string GV_C_Description = "Description";
        public string GV_C_SetValueInfo = "SetValueInfo";
        public string GV_C_GetValueInfo = "GetValueInfo";
        public string GV_C_IsBLL = "IsBLL";
        public string GV_C_IsPrimaryKey = "IsPrimaryKey";
        public string GV_C_IsFixedWidth = "IsFixedWidth";
        public string GV_C_Width = "Width";
        public string GV_C_DataSets = "DataSets";
        public string GV_C_DataTypesForColumns = "DataTypesForColumns";

        public List<string> GV_L_ColumnsCreation = new List<string>();
        public List<string> GV_L_ColumnsProperties = new List<string>();




        public string getGridCreation(DataTable pdt, string tblname, frm_FORMWIZARD objfm, String temp,String Main,String ParentTable)
        {
            GV_L_ColumnsCreation.Clear();
            GV_L_ColumnsProperties.Clear();
            string MainCode = "";
            
       

            foreach (DataRow row in pdt.Rows)
            {
                GV_L_ColumnsCreation.Add("dt_" + tblname + ".Columns.Add(cls_C" + GV_BLLClass + "." + row[GV_C_Columns] + ", typeof(" + row[GV_C_DataTypesForColumns] + "));");

                //if (row[GV_C_Control].ToString() == "RepositoryItemGridLookUpEdit")
                //{
                //    GV_L_ColumnsProperties.Add("objcls_DataSet." + row[GV_C_DataSets].ToString());

                //    GV_L_ColumnsProperties.Add("String ColumnsForVisibilit_" + row[GV_C_Columns].ToString() + " = \"\"");//ACC_PRESENTATION_LAYER.cls_CTBL_COA.COA_Name + "," + ACC_PRESENTATION_LAYER.cls_CTBL_COA.COA_UID + "," + ACC_PRESENTATION_LAYER.cls_CTBL_COA.COA_UID;

                //    GV_L_ColumnsProperties.Add("pGridView.Columns[cls_C" + GV_BLLClass + "." + row[GV_C_Columns] + "].ColumnEdit = GEN.cls_GridFunctions.getRepositoryGridLookUpEdit(\"DM\", \"VM\", \"CDM\", \"CVM\", \"COA Names\", \"IDs\", " + GV_TableName + ", \"DM\", GEN.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, GEN.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopWidth, GEN.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, ColumnsForVisibilit_" + row[GV_C_Columns].ToString() + ",true,true,true);");

                //}

                //obj_frm_TBL_TEMP_MAIN.GridView_TBL_TEMP_DET.Columns[cls_CTBL_TEMP_MAIN.TEMP_DET_Int].Caption = "Int";

                GV_L_ColumnsProperties.Add("obj_frm_"+cls_Global.GV_Main_Table_Name +".GridView_"+cls_Global.GV_DET_Table_Name+".Columns[cls_C" + cls_Global.GV_Main_Table_Name  + "." + row[GV_C_Columns] + "].Caption = \"" + row[GV_C_Caption] + "\";");
                //GV_L_ColumnsProperties.Add("pGridView.Columns[cls_C" + GV_BLLClass + "." + row[GV_C_Columns] + "].Width = " + row[GV_C_Width] + "\";");

                        
                //GV_L_ColumnsProperties.Add("pGridView.Columns[cls_C" + GV_BLLClass + "." + row[GV_C_Columns] + "].OptionsColumn.FixedWidth = true;");
        
                //if( Convert.ToBoolean(row[GV_C_IsFixedWidth].ToString())  == true)
                //   GV_L_ColumnsProperties.Add("pGridView.Columns[cls_C" + GV_BLLClass + "." + row[GV_C_Columns] + "].OptionsColumn.FixedWidth = true;");
                //else
                //    GV_L_ColumnsProperties.Add("pGridView.Columns[cls_C" + GV_BLLClass + "." + row[GV_C_Columns] + "].MinWidth = " + row[GV_C_Width] + ";");
                //GV_L_ColumnsProperties.Add("pGridView.Columns[cls_C" + GV_BLLClass + "." + row[GV_C_Columns] + "].Tag = \"" + row[GV_C_Tag] + "\";");
                GV_L_ColumnsProperties.Add("");
                GV_L_ColumnsProperties.Add("");
                GV_L_ColumnsProperties.Add("");


                
            }



            //for (int i = 0; i < GV_L_ColumnsCreation.Count; i++)
            //{

            //    MainCode = MainCode + GV_L_ColumnsCreation[i] + Environment.NewLine;
            //}



            
            //temp = temp.Replace("VVVLOAD_TBL_DEF_DATATABLEVVV", MainCode);
            //temp = temp.Replace("VVVTBL_DEFVVV", tblname);

            //temp = temp + Environment.NewLine + Environment.NewLine;

            //String Code2 = "";
            //for (int i = 0; i < GV_L_ColumnsProperties.Count; i++)
            //{

            //    Code2 = Code2 + GV_L_ColumnsProperties[i] + Environment.NewLine;
            //}

            //temp = temp.Replace("VVVLOAD_TBL_DEF_COLUMSVVV", Code2);


            
            //if (objfm.c_is_defination.Checked)
            //{

            //    Main = Main.Replace("//VVVGRIDINFOVVV", temp);
            //}

            //else
            //{

            //    Main = Main.Replace("//VVVGRIDINFOVVV", string.Empty);

            //}

          //  Main = Main.Replace("//VVVDefLoadVVV", frm_FORMWIZARD_P.Between(File.ReadAllText(objfm.GV_PathDefinationAllNeeds), "$$DefLoad$$", "$$DefLoadEnd$$"));
         //   Main = Main.Replace("//VVVValidateStartVVV", frm_FORMWIZARD_P.Between(File.ReadAllText(objfm.GV_PathDefinationAllNeeds), "$$Validate$$", "$$ValidateEnd$$"));
         



         //   Main = Main.Replace("VVVTBL_DEFVVV", tblname);
             ///yMain = Main.Replace("objfrm_VVVFormNameVVV", ParentTable);
            return Main;

        }

    }
}

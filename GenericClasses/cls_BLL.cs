using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace AdvCodeWizard.GenericClasses
{
    class cls_BLL
    {

        



        public cls_BLL()
        {
            cls_Global.GV_ParentPathBLL = Application.StartupPath + @"\FD\BLL";
            cls_Global.GV_PathBLLMain = cls_Global.GV_ParentPathBLL + @"\BLLMain.txt";
            cls_Global.GV_PathBLLMainDetailGrid = cls_Global.GV_ParentPathBLL + @"\BLLMainDetailGrid.txt";
          
              cls_Global.GV_PathColumnNamesMain = cls_Global.GV_ParentPathBLL + @"\ColumnsClassMain.txt";
            cls_Global.GV_PathColumnNamesDetailGrid = cls_Global.GV_ParentPathBLL + @"\ColumnsClassDetailGrid.txt";
            cls_Global.GV_PathColumnNamesDetailTree = cls_Global.GV_ParentPathBLL + @"\ColumnsClassDetailTree.txt";
            

        }

     
     
        string createBLLMain()
        {
            string tmpText = "";

            int count = cls_Global.GO_Tables_MainColumns.Rows.Count;
            int countDetail = cls_Global.GO_Tables_DetColumns.Rows.Count;

            if (cls_Global.GV_Is_Main && cls_Global.GV_Is_Details)
                  tmpText = File.ReadAllText(cls_Global.GV_PathBLLMainDetailGrid);

            else  if (cls_Global.GV_Is_Main)
                tmpText = File.ReadAllText(cls_Global.GV_PathBLLMain);

            string Properties = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_MainColumns, "Properties",true);
            string SQLParameters = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_MainColumns, "SQLParameters",true);

            string PropertiesDetail = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_DetColumns, "Properties",false);
            string SQLParametersDetail = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_DetColumns, "SQLParameters",false);



            tmpText = tmpText.Replace("<<<Database_Name>>>", cls_Global.GV_CurrentModule);
            tmpText = tmpText.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
            tmpText = tmpText.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);
            tmpText = tmpText.Replace("<<<Name_Column>>>", cls_Global.GV_Name_Column);
            tmpText = tmpText.Replace("<<<Det_Table>>>", cls_Global.GV_DET_Table_Name);
            tmpText = tmpText.Replace("<<<Foreign_Key>>>", cls_Global.GV_Foreign_Key);
            tmpText = tmpText.Replace("<<<Max_ID_Column>>>", cls_Global.GV_Max_ID_Column);
            tmpText = tmpText.Replace("<<<Is_Auto_Generated>>>", cls_Global.GV_Is_Auto_Generated);
            tmpText = tmpText.Replace("<<<Parameters_SIze>>>", (count + 6).ToString());
            tmpText = tmpText.Replace("<<<Parameters_SIze-3>>>", (count +3).ToString());
            tmpText = tmpText.Replace("<<<Parameters_SIze-2>>>", (count + 4).ToString());
            tmpText = tmpText.Replace("<<<Parameters_SIze-1>>>", (count + 5).ToString());

            tmpText = tmpText.Replace("<<<Parameters_SIze_Detail>>>", (countDetail + 6).ToString());
            tmpText = tmpText.Replace("<<<Parameters_SIze_Detail-4>>>", (countDetail + 4).ToString());
            tmpText = tmpText.Replace("<<<Parameters_SIze_Detail-5>>>", (countDetail + 5).ToString());
           
            tmpText = tmpText.Replace("<<<Other Properties>>>", Properties);
            tmpText = tmpText.Replace("<<<Other SQL Parameters>>>", SQLParameters);
            tmpText = tmpText.Replace("<<<Other Properties Detail>>>", PropertiesDetail);
            tmpText = tmpText.Replace("<<<Other SQL Parameters Detail>>>", SQLParametersDetail);
            tmpText = tmpText.Replace("<<<Order_Column>>>", cls_Global.GV_Ordering_Columns);



            File.WriteAllText(cls_Global.GV_PathSavingBLl + @"\cls_" + cls_Global.GV_Main_Table_Name + ".cs", tmpText);
            return tmpText;
        }

        string createColumnClass()
        {
            string tmpText = "";

            int count = cls_Global.GO_Tables_MainColumns.Rows.Count;

            if (cls_Global.GV_Is_Main)
            {

                tmpText = File.ReadAllText(cls_Global.GV_PathColumnNamesMain);



                string Column_Names = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_MainColumns, "Columns",false);

                tmpText = tmpText.Replace("<<<Database_Name>>>", cls_Global.GV_CurrentModule);
                tmpText = tmpText.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
                tmpText = tmpText.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);
                tmpText = tmpText.Replace("<<<Max_ID_Column>>>", cls_Global.GV_Max_ID_Column);
                tmpText = tmpText.Replace("<<<Column_Names>>>", Column_Names);



                File.WriteAllText(cls_Global.GV_PathSavingBLl + @"\cls_C" + cls_Global.GV_Main_Table_Name + ".cs", tmpText);
                cls_Global.GV_ColumnsNamesMain = tmpText;

            }
            if (cls_Global.GV_Is_Details)
            {
                if (cls_Global.GV_DetailType == "Grid")
                {
                    tmpText = File.ReadAllText(cls_Global.GV_PathColumnNamesDetailGrid);
                    tmpText = tmpText.Replace("<<<Det_Primary_Key>>>", cls_Global.GV_Deail_Primary_Key);
                    tmpText = tmpText.Replace("<<<Foraign_Columns>>>", cls_Global.GV_Foreign_Key);
                }
                else
                    if (cls_Global.GV_DetailType == "Tree")
                    {
                        tmpText = File.ReadAllText(cls_Global.GV_PathColumnNamesDetailTree);
                        tmpText = tmpText.Replace("<<<Primary_Key>>>", cls_Global.GV_Tree_Primary_Key);
                        tmpText = tmpText.Replace("<<<Parent_Key>>>", cls_Global.GV_Tree_Parent_Key);
                    }


                string Column_Names = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_DetColumns, "Columns", false);

                tmpText = tmpText.Replace("<<<Database_Name>>>", cls_Global.GV_CurrentModule);
                tmpText = tmpText.Replace("<<<Det_Table>>>", cls_Global.GV_DET_Table_Name);
                tmpText = tmpText.Replace("<<<Column_Names>>>", Column_Names);



                File.WriteAllText(cls_Global.GV_PathSavingBLl + @"\cls_C" + cls_Global.GV_DET_Table_Name + ".cs", tmpText);
                cls_Global.GV_ColumnsNamesDetail = tmpText;
            }

            return tmpText;
        }

        public void generate()
        {
          cls_Global.GV_BLL=createBLLMain();
          cls_Global.GV_ColumnsNamesMain = createColumnClass();
        } 
    }
}

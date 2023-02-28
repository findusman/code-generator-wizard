using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace AdvCodeWizard.GenericClasses
{
    class cls_StoreProcedure
    {

        GenericClasses.cls_Global obj_cls_Global = new cls_Global();
        
       


        public cls_StoreProcedure()
        {
            cls_Global.GV_ParentPathProcedure = Application.StartupPath + @"\FD\Procedure";
            cls_Global.GV_PathSelectionMain = cls_Global.GV_ParentPathProcedure + @"\MainSelection.txt";
            cls_Global.GV_PathSelectionMainDetail = cls_Global.GV_ParentPathProcedure + @"\MainDetailSelection.txt";
            cls_Global.GV_PathDeletionMain = cls_Global.GV_ParentPathProcedure + @"\MainDeletion.txt";
            cls_Global.GV_PathDeletionMainDetail = cls_Global.GV_ParentPathProcedure + @"\MainDetailDeletion.txt";
            cls_Global.GV_PathInsertionUnique = cls_Global.GV_ParentPathProcedure + @"\InsertionUnique.txt";
            cls_Global.GV_PathInsertion = cls_Global.GV_ParentPathProcedure + @"\Insertion.txt";
            cls_Global.GV_PathInsertionDetail = cls_Global.GV_ParentPathProcedure + @"\InsertionDetail.txt";
            cls_Global.GV_PathUpdationUnique = cls_Global.GV_ParentPathProcedure + @"\UpdationUnique.txt";
            cls_Global.GV_PathUpdation = cls_Global.GV_ParentPathProcedure + @"\Updation.txt";
            cls_Global.GV_PathDeletionInUpdation = cls_Global.GV_ParentPathProcedure + @"\DeletionInUpdation.txt";
            cls_Global.GV_PathGetmax = cls_Global.GV_ParentPathProcedure + @"\GetMax.txt";
            
            //cls_Global.GV_PathInsertionUnique = cls_Global.GV_ParentPathProcedure + @"\BLL.txt";


        }

        string createSelection()
        {
            string tmpText = "";

            if(cls_Global.GV_Is_Details)
                tmpText = File.ReadAllText(cls_Global.GV_PathSelectionMainDetail);
            else
                tmpText = File.ReadAllText(cls_Global.GV_PathSelectionMain);

            tmpText = tmpText.Replace("<<<Database_Name>>>", cls_Global.GV_ActualDatabase);
            tmpText = tmpText.Replace("<<<Procedure_Mode>>>", cls_Global.GV_ProcedureMode);
            tmpText = tmpText.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
            tmpText = tmpText.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);
            tmpText = tmpText.Replace("<<<Max_ID_Column>>>", cls_Global.GV_Max_ID_Column);
            tmpText = tmpText.Replace("<<<Name_Column>>>", cls_Global.GV_Name_Column);
            tmpText = tmpText.Replace("<<<Det_Table>>>", cls_Global.GV_DET_Table_Name);
            tmpText = tmpText.Replace("<<<Foreign_Key>>>", cls_Global.GV_Foreign_Key);
            tmpText = tmpText.Replace("<<<Order_Column>>>", cls_Global.GV_Ordering_Columns);

                    

           
                File.WriteAllText(cls_Global.GV_PathSavingProcedure + @"\sp_" + cls_Global.GV_Main_Table_Name + "_selection.sql", tmpText);
                return tmpText;
        }

        string createDeletion()
        {
            string tmpText = "";

            if (cls_Global.GV_Is_Details)
                tmpText = File.ReadAllText(cls_Global.GV_PathDeletionMainDetail);
            else
                tmpText = File.ReadAllText(cls_Global.GV_PathDeletionMain);

            tmpText = tmpText.Replace("<<<Database_Name>>>", cls_Global.GV_ActualDatabase);
            tmpText = tmpText.Replace("<<<Procedure_Mode>>>", cls_Global.GV_ProcedureMode);
            tmpText = tmpText.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
            tmpText = tmpText.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);
            tmpText = tmpText.Replace("<<<Name_Column>>>", cls_Global.GV_Name_Column);
            tmpText = tmpText.Replace("<<<Det_Table>>>", cls_Global.GV_DET_Table_Name);
            tmpText = tmpText.Replace("<<<Foreign_Key>>>", cls_Global.GV_Foreign_Key);
            

            File.WriteAllText(cls_Global.GV_PathSavingProcedure + @"\sp_" + cls_Global.GV_Main_Table_Name + "_deletion.sql", tmpText);
            return tmpText;
        }

        string createInsertionMain()
        {
            string tmpText = "";

            if (cls_Global.GV_Is_Unique)
                tmpText = File.ReadAllText(cls_Global.GV_PathInsertionUnique);
            else
                tmpText = File.ReadAllText(cls_Global.GV_PathInsertion);

            string ScalorParametersWithType = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_MainColumns, "ScalorParametersWithTypes", false);
            string ScalorParametersWithoutType = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_MainColumns, "ScalorParametersWithoutTypes", false);

            tmpText = tmpText.Replace("<<<Database_Name>>>", cls_Global.GV_ActualDatabase);
            tmpText = tmpText.Replace("<<<Procedure_Mode>>>", cls_Global.GV_ProcedureMode);
            tmpText = tmpText.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
            tmpText = tmpText.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);
            tmpText = tmpText.Replace("<<<Name_Column>>>", cls_Global.GV_Name_Column);
            tmpText = tmpText.Replace("<<<Det_Table>>>", cls_Global.GV_DET_Table_Name);
            tmpText = tmpText.Replace("<<<Foreign_Key>>>", cls_Global.GV_Foreign_Key);
            tmpText = tmpText.Replace("<<<Max_ID_Column>>>", cls_Global.GV_Max_ID_Column);
            tmpText = tmpText.Replace("<<<Is_Auto_Generated>>>", cls_Global.GV_Is_Auto_Generated);
            tmpText = tmpText.Replace("<<<OthersWithType>>>", ScalorParametersWithType);
            tmpText = tmpText.Replace("<<<OthersWithoutType>>>", ScalorParametersWithoutType);
            tmpText = tmpText.Replace("<<<Order_Column>>>", cls_Global.GV_Ordering_Columns);

            File.WriteAllText(cls_Global.GV_PathSavingProcedure + @"\sp_" + cls_Global.GV_Main_Table_Name + "_insertion.sql", tmpText);
            return tmpText;
        }

        string createInsertionDetail()
        {
            string tmpText = "";

            tmpText = File.ReadAllText(cls_Global.GV_PathInsertionDetail);

            string ScalorParametersWithType = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_DetColumns, "ScalorParametersWithTypes", false);
            string ScalorParametersWithoutType = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_DetColumns, "ScalorParametersWithoutTypes", false);

            tmpText = tmpText.Replace("<<<Database_Name>>>", cls_Global.GV_ActualDatabase);
            tmpText = tmpText.Replace("<<<Procedure_Mode>>>", cls_Global.GV_ProcedureMode);
            tmpText = tmpText.Replace("<<<Primary_Key>>>", cls_Global.GV_Deail_Primary_Key);
            tmpText = tmpText.Replace("<<<Name_Column>>>", cls_Global.GV_Name_Column);
            tmpText = tmpText.Replace("<<<Det_Table>>>", cls_Global.GV_DET_Table_Name);
            tmpText = tmpText.Replace("<<<Foreign_Key>>>", cls_Global.GV_Foreign_Key);
            tmpText = tmpText.Replace("<<<OthersWithType>>>", ScalorParametersWithType);
            tmpText = tmpText.Replace("<<<OthersWithoutType>>>", ScalorParametersWithoutType);
            tmpText = tmpText.Replace("<<<Order_Column>>>", cls_Global.GV_Ordering_Columns);



            File.WriteAllText(cls_Global.GV_PathSavingProcedure + @"\sp_" + cls_Global.GV_DET_Table_Name + "_insertion.sql", tmpText);
            return tmpText;
        }

        string createUpdation()
        {
            string tmpText = "" , tmpTextDeletion = "";

            if (cls_Global.GV_Is_Unique)

                tmpText = File.ReadAllText(cls_Global.GV_PathUpdationUnique);
            else
                tmpText = File.ReadAllText(cls_Global.GV_PathUpdation);

            tmpTextDeletion = File.ReadAllText(cls_Global.GV_PathDeletionInUpdation);
            tmpText = tmpText.Replace("<<<Procedure_Mode>>>", cls_Global.GV_ProcedureMode);
            tmpTextDeletion = tmpTextDeletion.Replace("<<<Det_Table>>>", cls_Global.GV_DET_Table_Name);
            tmpTextDeletion = tmpTextDeletion.Replace("<<<Foreign_Key>>>", cls_Global.GV_Foreign_Key);
            tmpTextDeletion = tmpTextDeletion.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);

            string ScalorParametersWithType = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_MainColumns, "ScalorParametersWithTypes", false);
            string ScalorParametersUpdationWithoutType = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_MainColumns, "ScalorParametersUpdationWithoutTypes", false);

            tmpText = tmpText.Replace("<<<Database_Name>>>", cls_Global.GV_ActualDatabase);
            tmpText = tmpText.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
            tmpText = tmpText.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);
            tmpText = tmpText.Replace("<<<Name_Column>>>", cls_Global.GV_Name_Column);
            tmpText = tmpText.Replace("<<<Det_Table>>>", cls_Global.GV_DET_Table_Name);
            tmpText = tmpText.Replace("<<<Foreign_Key>>>", cls_Global.GV_Foreign_Key);
            tmpText = tmpText.Replace("<<<Max_ID_Column>>>", cls_Global.GV_Max_ID_Column);
            tmpText = tmpText.Replace("<<<Is_Auto_Generated>>>", cls_Global.GV_Is_Auto_Generated);
            tmpText = tmpText.Replace("<<<OthersWithType>>>", ScalorParametersWithType);
            tmpText = tmpText.Replace("<<<OthersWithoutType>>>", ScalorParametersUpdationWithoutType);
            if (cls_Global.GV_Is_Details)
                tmpText = tmpText.Replace("<<<DeailDelation>>>", tmpTextDeletion);
            else
                tmpText = tmpText.Replace("<<<DeailDelation>>>", "");
            


            File.WriteAllText(cls_Global.GV_PathSavingProcedure + @"\sp_" + cls_Global.GV_Main_Table_Name + "_updation.sql", tmpText);
            return tmpText;
        }

        string createGetMax()
        {
            string tmpText = "";

            tmpText = File.ReadAllText(cls_Global.GV_PathGetmax);
            tmpText = tmpText.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
            tmpText = tmpText.Replace("<<<Max_ID_Column>>>", cls_Global.GV_Max_ID_Column);
           


            File.WriteAllText(cls_Global.GV_PathSavingProcedure + @"\sp_" + cls_Global.GV_Main_Table_Name + "_getmax.sql", tmpText);
            return tmpText;
        }

        public void generate()
        {
         cls_Global.GV_Prpcedure_Selection =  createSelection();
         cls_Global.GV_ProcedureDeletion = createDeletion();
         cls_Global.GV_ProcedureInsertionMain = createInsertionMain();
           if (cls_Global.GV_Is_Details)
               cls_Global.GV_ProcedureInsertionDet = createInsertionDetail();
           cls_Global.GV_ProcedureUpdation = createUpdation();
           cls_Global.GV_GetMAX = createGetMax();
        }
    }
}

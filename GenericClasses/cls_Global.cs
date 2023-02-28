using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace AdvCodeWizard.GenericClasses
{
    class cls_Global
    {

        public static String GV_CurrentModule = "";
        public static String GV_ActualDatabase = "";
        public static String GV_ProcedureMode = "";

        public static String GV_PathGridLookUpEditBindings = "";
        public static String GV_PathShowingFormEntity = "";
        public static String GV_PathStartup = "";
        public static String GV_PathNameSpaces = "";
        public static String GV_ParentPathProcedure = "";
        public static String GV_PathSelectionMainDetail = "";
        public static String GV_PathSelectionMain = "";
        public static String GV_PathDeletionMainDetail = "";
        public static String GV_PathDeletionMain = "";
        public static String GV_PathDeletionInUpdation = "";
        
        public static String GV_PathInsertionUnique = "";
        public static String GV_PathInsertion = "";
        public static String GV_PathInsertionDetail = "";
        public static String GV_PathUpdationUnique = "";
        public static String GV_PathUpdation = "";
        public static String GV_ParentPathBLL = "";
        public static String GV_ParentPathPartialClass = "";
        public static String GV_PathPartialClassMain = "";

        public static String GV_PathBLLMain = "";
        public static String GV_PathBLLMainDetailGrid = "";
        public static String GV_PathBLLMainDetailTree = "";
        
          public static String GV_PathColumnNamesMain = "";
        public static String GV_PathColumnNamesDetailGrid = "";
        public static String GV_PathColumnNamesDetailTree = "";

        public static String GV_ParentPathDataSet = "";
        public static String GV_PathDataSet = "";
        
        public static String GV_PathGetmax = "";

        public static String GV_PathSavingProcedure = "";
        public static String GV_PathSavingDataSet = "";
        public static String GV_PathSavingBLl = "";
        public static String GV_PathSavingForm = "";
        public static String GV_PathSavingFormDesignerClass = "";

        public static string GV_CMP_ID = "CMP_ID";
        public static string GV_BRC_ID = "BRC_ID";
        public static string GV_IS_Deleted = "Is_Deleted";
        public static string GV_User_ID = "User_ID";
        public static string GV_Is_Auto_Generated = "Is_Auto_Generated";

        public static string GV_Name_Column = "";
        public static string GV_Max_ID_Column = "";

        public static string GV_Main_Table_Name = "";
        public static string GV_DET_Table_Name = "";
        public static string GV_Main_Table_ID = "";
        public static string GV_DET_Table_ID = "";

        public static string GV_Table_Name_For_Replacement = "";

        public static string GV_Tree_Primary_Key = "";
        public static string GV_Tree_Parent_Key = "";
        public static string GV_Primary_Key = "";
        public static string GV_Deail_Primary_Key = "";
        public static string GV_Foreign_Key = "";
        public static string GV_Ordering_Columns = "";

        public static string GV_UniqueColumn = "";
        public static string GV_Path = "";
        public static bool GV_Is_Details = false;
        public static bool GV_Is_Main = true;
        public static bool GV_Is_Unique = false;
        public static bool GV_is_Fix_Columns = false;
        public static string GV_DetailType = "Grid";

        public static DataTable GO_Tables_AllTables = new DataTable();
       
        public static DataTable GO_Tables_MainColumns = new DataTable();
        public static DataTable GO_Tables_DetColumns = new DataTable();

        public static DataTable GO_Tables_MainProcessedColumns = new DataTable();
        public static DataTable GO_Tables_DetProcessedColumns = new DataTable();

        public static DataTable GO_Tables_Editors = null;
        public static DataTable GO_Tables_EditorsLookUp = null;
        public static DataTable GO_Tables_Repository = null;
        public static DataTable GO_Tables_RepositoryLookUp = null;


        public static string GV_Prpcedure_Selection = "";
        public static string GV_ProcedureInsertionMain = "";
        public static string GV_ProcedureInsertionDet = "";
        public static string GV_ProcedureDeletion = "";
        public static string GV_ProcedureUpdation = "";
        public static string GV_DataSet = "";
        public static string GV_BLL = "";
        public static string GV_PartialCLass = "";
        public static string GV_GetMAX = "";
        public static string GV_ColumnsNamesMain = "";
        public static string GV_ColumnsNamesDetail = "";


    }
}

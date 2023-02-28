using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Data;
namespace AdvCodeWizard.BLL
{
    class cls_BLLFunctionss
    {

        DataSet GO_DataSet = null;
        DataTable GO_DataTable = null;

        DAL.DAL obj_DAL = new DAL.DAL();

        public DataTable loadAllDatabases()
        {
            GO_DataSet = obj_DAL.selectionWithExecuteProcedureTypeWithEmptySQLParameter("sp_Get_All_Databases_selection");
            if (GO_DataSet == null)
                return GO_DataTable;
            return GO_DataSet.Tables[0];
        }
        public DataTable loadTables()
        {
              GO_DataSet = obj_DAL.selectionWithExecuteTextType("select name [Table Names] , object_id [Table ID] from sys.tables "); //where name = 'TBL_TEMP_MAIN' or name = 'TBL_TEMP_DET'/* where name = 'TBL_TEMP_MAIN' or name = 'TBL_TEMP_DETAIL'*/
            if (GO_DataSet == null)
                return GO_DataTable;
            return GO_DataSet.Tables[0];
        }

        public DataTable loadOnlyColumns(string tableName)
        {
            GO_DataSet  = obj_DAL.selectionWithExecuteTextType("select sys.columns.name 'Column Names'  from sys.tables join sys.columns on sys.tables.object_id = sys.columns.object_id where sys.tables.name = '" + tableName + "'");

            if (GO_DataSet == null)
                return GO_DataTable;
            return GO_DataSet.Tables[0];
        }

        public DataTable loadColumns(string tableID)
        {
            GO_DataSet = obj_DAL.selectionWithExecuteTextType("select sys.columns.name [Column Names], sys.columns.max_length [Column Size], AdvCodeWizard.dbo.TBL_DT_Features.* from AdvCodeWizard.dbo.TBL_DT_Features join sys.columns  on AdvCodeWizard.dbo.TBL_DT_Features.DT_Features_ID = sys.columns.system_type_id and sys.columns.object_id = '" + tableID + "' order by sys.columns.column_id");
            if (GO_DataSet == null)
                return GO_DataTable;
            return GO_DataSet.Tables[0];
        }

      
          public DataTable loadAnyTable(string pQuery)
        {
            GO_DataSet = obj_DAL.selectionWithExecuteTextType(pQuery);
            if (GO_DataSet == null)
                return GO_DataTable;
            return GO_DataSet.Tables[0];
        }

    }
}

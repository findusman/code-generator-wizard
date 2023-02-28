using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace AdvCodeWizard.GenericClasses
{
      class getComboBoxes
      {

            DAL.DAL obj_Dal = new DAL.DAL(  );

            BLL.cls_BLLFunctionss obj_cls_BLLFunctionss = new BLL.cls_BLLFunctionss();

            public void getTabels(DevExpress.XtraEditors.ComboBoxEdit control)
            {

                  DataTable dt = obj_cls_BLLFunctionss.loadTables();
                  control.Properties.Items.Clear();


                  foreach (DataRow dr in dt.Rows)
                  {
                        control.Properties.Items.Add(dr[0]);
                  }


            }
            public void getColumns(DevExpress.XtraEditors.ComboBoxEdit control, string tableName)
            {

                  DataTable dt = obj_cls_BLLFunctionss.loadOnlyColumns(tableName);
                  control.Properties.Items.Clear();


                  foreach (DataRow dr in dt.Rows)
                  {
                        control.Properties.Items.Add(dr[0]);
                  }
                  control.SelectedIndex = 0;

            }
      }
}

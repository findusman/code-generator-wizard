using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AdvCodeWizard.UserControls.DataBases
{
      public partial class uc_DataBase_MSSQLServer : DevExpress.XtraEditors.XtraUserControl
      {
            public uc_DataBase_MSSQLServer(MDI pobj_MDI)
            {
                  InitializeComponent();
                  obj_MDI = pobj_MDI;
            }

            MDI obj_MDI;
            

            private void ComboBoxEdit_databases_SelectedIndexChanged(object sender, EventArgs e)
            {
                DAL.DAL.DATABASE = ComboBoxEdit_databases.Text;
                obj_MDI.loadTables();
            }

            private void TextEdit_server_EditValueChanged(object sender, EventArgs e)
            {

            }

            private void uc_DataBase_MSSQLServer_Load(object sender, EventArgs e)
            {

            }
      }
}

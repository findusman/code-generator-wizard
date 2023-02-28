using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress;
using System.Windows.Forms;

using DevExpress.XtraEditors;

namespace AdvCodeWizard.GenericClasses
{
    class cls_MessageBox
    {

        string GV_Caption = "Data MS ..::.. DigiPru Software Technology";
        public void ShowMessageBos(string pText , MessageBoxIcon pMessageBoxIcon )
        { 
        
            XtraMessageBox.Show(pText , GV_Caption , MessageBoxButtons.OK, pMessageBoxIcon);
            
        }
        public bool ShowMessageBosIs(string pText)
        {

            if(XtraMessageBox.Show(pText, GV_Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==  DialogResult.Yes)
            return true;
            else
            return false;
        }
    }
}

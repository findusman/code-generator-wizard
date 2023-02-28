using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace AdvCodeWizard.GenericClasses
{
    class cls_DataSet
    {


        public cls_DataSet()
        {
            cls_Global.GV_ParentPathDataSet = Application.StartupPath + @"\FD\DataSet";
            cls_Global.GV_PathDataSet = cls_Global.GV_ParentPathDataSet + @"\DataSet.txt";
        
        }

        string createMainDataSet()
        {
            string tmpText = "";
            tmpText = File.ReadAllText(cls_Global.GV_PathDataSet);

            tmpText = tmpText.Replace("<<<Database_Name>>>", cls_Global.GV_CurrentModule);
            tmpText = tmpText.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
            tmpText = tmpText.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);
          
           
                File.WriteAllText(cls_Global.GV_PathSavingDataSet + @"\sp_" + cls_Global.GV_Main_Table_Name + "_DataSet.cs", tmpText);
                return tmpText;
        }

      
      
        public void generate()
        {

           cls_Global.GV_DataSet= createMainDataSet();
           //if (cls_Global.GV_Is_Details)
           //    createInsertionDetail();
          
        }
    }
}

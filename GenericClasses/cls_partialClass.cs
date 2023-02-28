using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace AdvCodeWizard.GenericClasses
{
    class cls_partialClass
    {

        



        public cls_partialClass()
        {
            cls_Global.GV_ParentPathPartialClass = Application.StartupPath + @"\FD\FormCode";
           

        }

     
     
        string createPartialClass()
        {
            string tmpText = "";

            int count = cls_Global.GO_Tables_MainColumns.Rows.Count;

            if (cls_Global.GV_Is_Details)
                tmpText = File.ReadAllText(cls_Global.GV_PathInsertionUnique);

            if (cls_Global.GV_Is_Main)
                tmpText = File.ReadAllText(cls_Global.GV_PathPartialClassMain);

           // string Properties = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_MainColumns, "Properties");
           //  string SQLParameters = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_MainColumns, "SQLParameters");

            tmpText = tmpText.Replace("<<<Database_Name>>>", cls_Global.GV_CurrentModule);
            tmpText = tmpText.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
            tmpText = tmpText.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);
            tmpText = tmpText.Replace("<<<Name_Column>>>", cls_Global.GV_Name_Column);
            tmpText = tmpText.Replace("<<<Det_Table>>>", cls_Global.GV_DET_Table_Name);
            tmpText = tmpText.Replace("<<<Foreign_Key>>>", cls_Global.GV_Foreign_Key);
            tmpText = tmpText.Replace("<<<Max_ID_Column>>>", cls_Global.GV_Max_ID_Column);
            tmpText = tmpText.Replace("<<<Is_Auto_Generated>>>", cls_Global.GV_Is_Auto_Generated);
           
            //tmpText = tmpText.Replace("<<<Other Properties>>>", Properties);
            //tmpText = tmpText.Replace("<<<Other SQL Parameters>>>", SQLParameters);

            File.WriteAllText(cls_Global.GV_PathSavingBLl + @"\cls_P" + cls_Global.GV_Main_Table_Name + ".cs", tmpText);
            return tmpText;
        }

     

        public void generate()
        {
            //cls_Global.GV_PartialCLass = createPartialClass();
          
        } 
    }
}

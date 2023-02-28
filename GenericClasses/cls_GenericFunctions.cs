using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Data;
using System.IO;
using System.Windows.Forms;
namespace AdvCodeWizard.GenericClasses
{
    class cls_GenericFunctions
    {
      
        static public DataTable DT_bindedTable = new DataTable();

        public void bindComboBoxEdit(DataTable pDataTable, int pColumnIndex, ComboBoxEdit pComboBoxEdit)
        {
            
            pComboBoxEdit.Properties.Items.Clear();

            foreach (DataRow dr in pDataTable.Rows)
                pComboBoxEdit.Properties.Items.Add(dr[pColumnIndex].ToString());

        
            pComboBoxEdit.SelectedIndex = 0;
  
        }

        public static void loadNameSpaces(ComboBoxEdit objComboxEdit)
        {
            objComboxEdit.Properties.Items.Clear();
            string[] Namespaces = File.ReadAllLines(cls_Global.GV_PathNameSpaces);
            foreach (string tmpStr in Namespaces)
                objComboxEdit.Properties.Items.Add(tmpStr);

            //ComboBoxEdit_nameSpace.SelectedIndex = 0;
            string tmpModule = File.ReadAllText(Application.StartupPath + @"\FD\defaultModule.txt");
            objComboxEdit.SelectedItem = tmpModule;



        }

        public static string generateColumn(DataTable pDataTable, string pStatus, bool pIsMain)
        {
            string Data = "", 
                   tmpType = "",
                   SpaceForScalorParameters = "          ",
                   SpaceForInsertionParameter = "                        ",
                   SpaceForUpdationParameter = "                ",
                   SpaceForParameters   = "        ",
                   SpaceForSQLParameter = "            ",
                   SpaceForColumnNames = "     ";

           

            for(int x = 0 ; x< pDataTable.Rows.Count ; x++)
            {

                if (pStatus == "ScalorParametersWithTypes")
                {
                    tmpType = pDataTable.Rows[x][cls_Columns.DT_Features_isSizeInStoreProcedure].ToString() == "True" ? pDataTable.Rows[x][cls_Columns.DT_Features_SQLTypes].ToString() + "(" + (pDataTable.Rows[x][cls_Columns.Column_Size].ToString() == "-1" ? "max" : pDataTable.Rows[x][cls_Columns.Column_Size].ToString()) + ")" : pDataTable.Rows[x][cls_Columns.DT_Features_SQLTypes].ToString();
                    Data =  Data + Environment.NewLine+ SpaceForScalorParameters + ",@" + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + " " + tmpType ;
                    
                }
                else if (pStatus == "ScalorParametersWithoutTypes")
                {
                    Data =   Data +Environment.NewLine+ SpaceForInsertionParameter+ "@" + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + ", ";

                }

                else if (pStatus == "ScalorParametersUpdationWithoutTypes")
                {
                    if ((x + 1) == pDataTable.Rows.Count)
                         Data =   Data +Environment.NewLine+ SpaceForInsertionParameter+ "" + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + " = @" + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() ;
                    else
                        Data = Data + Environment.NewLine + SpaceForUpdationParameter + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + " = @" + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + ",";
                    
                }
                else if (pStatus == "Properties")
                {

                    Data = Data +Environment.NewLine+ SpaceForParameters+ "private  " + pDataTable.Rows[x][cls_Columns.DT_Features_dotNetTypes].ToString() + "  p" + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + "  = " + pDataTable.Rows[x][cls_Columns.DT_Features_dotNetAssignmentData].ToString() + ";" ;
                    Data = Data + Environment.NewLine + SpaceForParameters + "public  " + pDataTable.Rows[x][cls_Columns.DT_Features_dotNetTypes].ToString() + "  " + pDataTable.Rows[x][cls_Columns.Column_Names].ToString();
                    Data = Data + Environment.NewLine + SpaceForParameters + "{";
                    Data = Data + Environment.NewLine + SpaceForParameters + "      get { return p" + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + "; }";
                    Data = Data + Environment.NewLine + SpaceForParameters + "      set {p" + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + " = value; }";
                    Data = Data + Environment.NewLine + SpaceForParameters + "}" + Environment.NewLine + Environment.NewLine;
                    
                }
                else if (pStatus == "SQLParameters")
                {
                      int startingIndex = pIsMain ? 3 : 4;

                      Data = Data + Environment.NewLine + @"sql_param[" + (x + startingIndex).ToString() + "] = new SqlParameter(\"@" + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + "\", SqlDbType." + pDataTable.Rows[x][cls_Columns.DT_Features_dotNetDBType].ToString() + ");";
                      if (pIsMain)
                            Data = Data + Environment.NewLine + "sql_param[" + (x + startingIndex).ToString() + "].Value = " + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + ";" + Environment.NewLine;
                      else
                            Data = Data + Environment.NewLine + "sql_param[" + (x + startingIndex).ToString() + "].Value = dr[cls_C" + cls_Global.GV_Main_Table_Name + "." + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + "];";//+ pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + ";" + Environment.NewLine;
                  
                }
                else if (pStatus == "Columns")
                {

                    Data = Data + Environment.NewLine + SpaceForColumnNames + @"public static string " + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + " = \"" + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + "\";";
                  
                }

                else if (pStatus == "Columns")
                {

                    Data = Data + Environment.NewLine + SpaceForColumnNames + @"public static string " + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + " = \"" + pDataTable.Rows[x][cls_Columns.Column_Names].ToString() + "\";";

                }
               
                //Getting_Values

            } 

            return Data;
        }
        public static string generateColumn(DataTable pDataTable, string pStatus, string pSpace)
        {
            string Data = "";



            for (int x = 0; x < pDataTable.Rows.Count; x++)
            {

            
                 if (pStatus == "Columns_For_LookUpForm_In_Selection")
                {

                    Data = Data + Environment.NewLine + pSpace + ", Cast(" + pDataTable.Rows[x][cls_Columns.CONTROL_INFO_Column].ToString() + " as nvarchar(max)) as '" + pDataTable.Rows[x][cls_Columns.CONTROL_INFO_columnCaption].ToString() + " '";

                }
                 if (pStatus == "Columns_Length_For_LookUpForm_In_Selection")
                 {
                     if ((x+1) == pDataTable.Rows.Count)
                        Data =Data+ "150";
                     else
                         Data = Data + "150,";

                 }
               

            }

            return Data;
        }


        public static string generadeCode_DeclaringObjects()
        {
            string Data = "", paceForDeclaringObjects = "        ";

            foreach (DataRow drTemp in cls_Global.GO_Tables_MainProcessedColumns.Rows)
            {

                Data = Data + Environment.NewLine + Environment.NewLine + paceForDeclaringObjects + drTemp[cls_Columns.CONTROL_INFO_declaringCode].ToString();
                Data = Data.Replace("<<<Control_Name>>>", drTemp[cls_Columns.CONTROL_INFO_Column].ToString());
            }

            
            return Data;
        }
        public static string generadeCode_initializing()
        {
            string Data = "", space = "            ";

            foreach (DataRow drTemp in cls_Global.GO_Tables_MainProcessedColumns.Rows)
            {

                Data = Data + Environment.NewLine + space + drTemp[cls_Columns.CONTROL_INFO_initializingCode].ToString();
                Data = Data.Replace("<<<Control_Name>>>", drTemp[cls_Columns.CONTROL_INFO_Column].ToString());
            }


            return Data;
        }
        public static string generadeCode_AssigningAttributes()
        {
            string Data = "", space = "            ";
            int tmpHight = 24;
            foreach (DataRow drTemp in cls_Global.GO_Tables_MainProcessedColumns.Rows)
            {

                Data = Data + Environment.NewLine + space + drTemp[cls_Columns.CONTROL_INFO_assigningAttributesCode].ToString();
                Data = Data.Replace("<<<Control_Name>>>", drTemp[cls_Columns.CONTROL_INFO_Column].ToString());
                Data = Data.Replace("<<<Control_XLocation>>>", (tmpHight+30).ToString());
                Data = Data.Replace("<<<Control_Tag>>>", drTemp[cls_Columns.CONTROL_INFO_columnTag].ToString());
                Data = Data.Replace("<<<Control_Caption>>>", drTemp[cls_Columns.CONTROL_INFO_columnCaption].ToString() + " :");
                tmpHight = tmpHight + 30;
            }


            return Data;
        }
        public static string generadeCode_Events()
        {
            string Data = "", Space = "        ";

            foreach (DataRow drTemp in cls_Global.GO_Tables_MainProcessedColumns.Rows)
            {
                if (drTemp[cls_Columns.CONTROL_INFO_ID].ToString() == "9")
                {
                    try
                    {
                        string tmpBindFieldName = drTemp[cls_Columns.CONTROL_INFO_Column].ToString();
                        foreach (DataRow dr in DT_bindedTable.Rows)
                        {
                            if (dr["Columns"].ToString() == tmpBindFieldName)
                            {
                                string tmpBindTable = dr["Tables"].ToString();
                                
                                Data = Data + Environment.NewLine + Environment.NewLine + Space + drTemp[cls_Columns.CONTROL_INFO_event].ToString();
                                Data = Data.Replace("<<<Control_Name>>>", drTemp[cls_Columns.CONTROL_INFO_Column].ToString());
                                Data = Data.Replace("<<<Binded_Table>>>", tmpBindTable);
                                Data = Data.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                    
                    }
                }
            }


            return Data;
        }
        public static string generadeCode_GettingSetting( string Status )
        {
            string Data = "", space = "                ";

            

            foreach (DataRow drTemp in cls_Global.GO_Tables_MainProcessedColumns.Rows)
            {
                if (Status == "Getting_Values")
                {
                    if (drTemp[cls_Columns.CONTROL_INFO_ID].ToString() != "2")
                    {
                        Data = Data + Environment.NewLine + space + "obj_cls_<<<Main_Table>>>." + drTemp[cls_Columns.CONTROL_INFO_Column].ToString() + " = " + drTemp[cls_Columns.DT_Features_dotNetGettingLogin].ToString();
                        Data = Data.Replace("<<<Geting_Control>>>", drTemp[cls_Columns.CONTROL_INFO_gettingPrefixOrPostFixCode].ToString());
                        Data = Data.Replace("<<<Control_Name>>>", drTemp[cls_Columns.CONTROL_INFO_name].ToString() + "_" + drTemp[cls_Columns.CONTROL_INFO_Column].ToString());
                        Data = Data.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
                    }
                  
                }
                if (Status == "Setting_Values")
                {
                    if (drTemp[cls_Columns.CONTROL_INFO_ID].ToString() != "2")
                    {
                        //if (drTemp[cls_Columns.CONTROL_INFO_Column].ToString() == "PRODUCTS_2_Weights")



                        Data = Data + Environment.NewLine + space + drTemp[cls_Columns.DT_Features_dotNetSettingLogin].ToString() + " = dt_Main.Rows[0][BLL.<<<Database_Name>>>_BLL.<<<Main_Table>>>.cls_C<<<Main_Table>>>."+drTemp[cls_Columns.CONTROL_INFO_Column].ToString()+"];";
                        Data = Data.Replace("<<<Geting_Control>>>", drTemp[cls_Columns.CONTROL_INFO_settingPrefixOrPostFixCode].ToString());
                        Data = Data.Replace("<<<Control_Name>>>", drTemp[cls_Columns.CONTROL_INFO_name].ToString() +"_"+ drTemp[cls_Columns.CONTROL_INFO_Column].ToString());
                        Data = Data.Replace("<<<Database_Name>>>", cls_Global.GV_CurrentModule);
                      

                        //Data = Data + Environment.NewLine + space + drTemp[cls_Columns.CONTROL_INFO_settingPrefixOrPostFixCode].ToString() + " = " + drTemp[cls_Columns.DT_Features_dotNetSettingLogin].ToString();
                       

                        //Data = Data + Environment.NewLine + space + drTemp[cls_Columns.CONTROL_INFO_settingPrefixOrPostFixCode].ToString() + " = " + drTemp[cls_Columns.DT_Features_dotNetSettingLogin].ToString();
                       // Data = Data.Replace("<<<Control_Name>>>", drTemp[cls_Columns.CONTROL_INFO_Column].ToString());
                        //Data = Data.Replace("<<<Seting_Property>>>", "obj_cls_<<<Main_Table>>>." + drTemp[cls_Columns.CONTROL_INFO_Column].ToString());
                        Data = Data.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
                    }

                }
            }
              
            return Data;
        }
        public static string generadeCode_detailColumnsAttributes(string Status)
        {
                    string Data = "", space = "                ";



                    foreach (DataRow drTemp in cls_Global.GO_Tables_DetProcessedColumns.Rows)
                    {
                                Data = Data + "// " + drTemp[cls_Columns.CONTROL_INFO_Column] + Environment.NewLine ;
                                Data = Data +Environment.NewLine  + "obj_frm_" + cls_Global.GV_Main_Table_Name + ".GridView_" + cls_Global.GV_DET_Table_Name + ".Columns[cls_C" + cls_Global.GV_Main_Table_Name + "." + drTemp[cls_Columns.CONTROL_INFO_Column] + "].Caption = \"" + drTemp[cls_Columns.CONTROL_INFO_columnCaption] + "\";";
                                string isFixed = Convert.ToBoolean(drTemp[cls_Columns.CONTROL_INFO_IsFixedWidth])  ? "true" : "false";
                                Data = Data + Environment.NewLine + "obj_frm_" + cls_Global.GV_Main_Table_Name + ".GridView_" + cls_Global.GV_DET_Table_Name + ".Columns[cls_C" + cls_Global.GV_Main_Table_Name + "." + drTemp[cls_Columns.CONTROL_INFO_Column] + "].OptionsColumn.FixedWidth = " + isFixed +";";
                                if (drTemp[cls_Columns.CONTROL_INFO_Width].ToString() != "" && drTemp[cls_Columns.CONTROL_INFO_Width].ToString() != "0")
                                Data = Data + Environment.NewLine + "obj_frm_" + cls_Global.GV_Main_Table_Name + ".GridView_" + cls_Global.GV_DET_Table_Name + ".Columns[cls_C" + cls_Global.GV_Main_Table_Name + "." + drTemp[cls_Columns.CONTROL_INFO_Column] + "].Width = " + drTemp[cls_Columns.CONTROL_INFO_Width] + ";";
                                Data = Data + Environment.NewLine + "obj_frm_" + cls_Global.GV_Main_Table_Name + ".GridView_" + cls_Global.GV_DET_Table_Name + ".Columns[cls_C" + cls_Global.GV_Main_Table_Name + "." + drTemp[cls_Columns.CONTROL_INFO_Column] + "].Tag = \"" + drTemp[cls_Columns.CONTROL_INFO_columnTag] + "\";";
                                Data = Data + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                    }

                    return Data;
        }



    }
}

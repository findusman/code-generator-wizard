using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using AdvCodeWizard.GenericClasses;

namespace AdvCodeWizard
{
            public partial class MDI : DevExpress.XtraEditors.XtraForm
            {

                  UserControls.DataBases.uc_DataBase_MSSQLServer obj_uc_DataBase_MSSQLServer= null;

                        public MDI()
                        {
                                    InitializeComponent();
                        }

                        #region Objects Declarations

                        GenericClasses.cls_MessageBox obj_cls_MessageBox = new GenericClasses.cls_MessageBox();
                        GenericClasses.cls_StoreProcedure obj_cls_StoreProcedure = new GenericClasses.cls_StoreProcedure();
                        GenericClasses.cls_GenericFunctions obj_cls_GenericFunctions = new GenericClasses.cls_GenericFunctions();
                        GenericClasses.cls_BLL obj_cls_BLL = new GenericClasses.cls_BLL();
                        GenericClasses.cls_partialClass obj_cls_partialClass = new GenericClasses.cls_partialClass();

                        BLL.cls_BLLFunctionss obj_cls_BLLFunctionss = new BLL.cls_BLLFunctionss();
                        GenericClasses.cls_Columns obj_cls_Columns = new GenericClasses.cls_Columns();
                        GenericClasses.cls_Global obj_cls_Global = new GenericClasses.cls_Global();
                        GenericClasses.cls_DataSet obj_cls_DataSet = new cls_DataSet();



                        #endregion

                        #region Global Variable Declarations


                        public string GV_database = "AdvCodeWizard";



                        #endregion


                        #region Form Events

                        private void XtraForm2_Load(object sender, EventArgs e)
                        {
                                    
                                    loadDatabases();
                                    loadValues();
                                    loadGenerics();
                                    GenericClasses.cls_GenericFunctions.loadNameSpaces(ComboBoxEdit_nameSpace);
                                    loadOtherTables();
                                    CheckEdit_isDetail.Checked = true;

                        }

                        private void txt_server_EditValueChanged(object sender, EventArgs e)
                        {
                                    loadValues();
                        }

                        private void SimpleButton_databases_Click(object sender, EventArgs e)
                        {

                                    loadDatabases();

                        }


                        private void CheckEdit_isUnique_CheckedChanged(object sender, EventArgs e)
                        {
                                    ComboBoxEdit_nameColumn.Enabled = CheckEdit_isUnique.Checked;
                                    loadValues();
                        }

                        private void CheckEdit_isDetail_CheckedChanged(object sender, EventArgs e)
                        {
                                    if (CheckEdit_isDetail.Checked)
                                                RadioGroup_GridOrTree.EditValue = "Grid";
                                    GridLookUpEdit_tablesForDetails.Enabled = ComboBoxEdit_foreignKey.Enabled = ComboBoxEdit_orderingColumns.Enabled = ComboBoxEdit_detailPrimaryKey.Enabled = RadioGroup_GridOrTree.Enabled = CheckEdit_isDetail.Checked;
                                    loadValues();
                        }

                        private void ComboBoxEdit_databases_SelectedIndexChanged(object sender, EventArgs e)
                        {
                              File.WriteAllText(Application.StartupPath + @"\FD\defaultDatabase.txt", obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.Text);

                                    loadTables();
                        }

                        private void simpleButton2_Click(object sender, EventArgs e)
                        {
                                    this.Close();
                        }

                        private void GridLookUpEdit_tablesForDetails_EditValueChanged(object sender, EventArgs e)
                        {

                                    loadDetColumns();
                        }

                        private void GridView_tables_Click(object sender, EventArgs e)
                        {
                                    loadMainColumns();
                        }
                        private void simpleButton1_Click(object sender, EventArgs e)
                        {
                                    folderBrowserDialog1.ShowDialog();
                                    TextEdit_path.Text = folderBrowserDialog1.SelectedPath;
                        }

                        private void ComboBoxEdit_primaryKey_SelectedIndexChanged(object sender, EventArgs e)
                        {
            try
            {
                //File.WriteAllText(Application.StartupPath + @"\FD\defaultModule.txt", ComboBoxEdit_nameSpace.SelectedItem.ToString());
                loadValues();
            }
            catch (Exception ex)
            { 
            
            }
            }
                        private void ComboBoxEdit_uniqueColumn_SelectedIndexChanged(object sender, EventArgs e)
                        {
                                    loadValues();
                        }


                        private void SimpleButton_Next_Click(object sender, EventArgs e)
                        {
                                    if (!check())
                                                return;

                                    loadValues();
                                    initialActions();
                                    generatePath(false);

                                    obj_cls_StoreProcedure.generate();
                                    obj_cls_DataSet.generate();
                                    obj_cls_BLL.generate();
                                    obj_cls_partialClass.generate();


                                    if (true /*obj_cls_MessageBox.ShowMessageBosIs("Procedures are created. Are you want to go in Form Wizard..... ???")*/)
                                    {
                                                generatePath(true);
                                                AdvCodeWizard.FormWizard.frm_FORMWIZARD obj_frm_FORMWIZARD = new FormWizard.frm_FORMWIZARD();
                                                obj_frm_FORMWIZARD.Show();

                                    }



                        }

                        private void simpleButton3_Click(object sender, EventArgs e)
                        {
                                    referesh();

                        }

                        #endregion

                        #region Generic Functions


                        void loadCredentialParameters(string pStr)
                        {
                                    string[] str = pStr.Split('|');
                                    if (str.Length > 0)
                                    {
                                          obj_uc_DataBase_MSSQLServer.TextEdit_server.Text = str[0].Trim();
                                          obj_uc_DataBase_MSSQLServer.TextEdit_userID.Text = str[1].Trim();
                                          obj_uc_DataBase_MSSQLServer.TextEdit_password.Text = str[2].Trim();
                                    }
                        }

                        void loadExistingCredentials()
                        {
                              obj_uc_DataBase_MSSQLServer.ComboBoxEdit_existingCredentials.Properties.Items.Clear();
                                    string[] credentialsArray = File.ReadAllLines(Application.StartupPath + @"\FD\credentialsList.txt");
                                    string defaultCredentials = File.ReadAllText(Application.StartupPath + @"\FD\defaultCredentials.txt");
                                    string tmpDatabase = File.ReadAllText(Application.StartupPath + @"\FD\defaultDatabase.txt");

                                    obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.SelectedItem = tmpDatabase;
                                    loadCredentialParameters(defaultCredentials);
                                    foreach (string str in credentialsArray)
                                          obj_uc_DataBase_MSSQLServer.ComboBoxEdit_existingCredentials.Properties.Items.Add(str);

                        }

               




                        void checkExistence()
                        {


                              string currentCredential = obj_uc_DataBase_MSSQLServer.TextEdit_server.Text + "  |  " + obj_uc_DataBase_MSSQLServer.TextEdit_userID.Text + "  |  " + obj_uc_DataBase_MSSQLServer.TextEdit_password.Text;
                              File.WriteAllText(Application.StartupPath + @"\FD\defaultCredentials.txt", currentCredential);
                              string[] credentialsArray = File.ReadAllLines(Application.StartupPath + @"\FD\credentialsList.txt");
                              List<string> credentialsList = new List<string>(credentialsArray);

                              if (!credentialsList.Contains(currentCredential))
                              {
                                    credentialsList.Add(currentCredential);
                                    credentialsArray = credentialsList.ToArray();
                                    File.WriteAllLines(Application.StartupPath + @"\FD\credentialsList.txt", credentialsArray);

                                    loadExistingCredentials();

                              }
                        }

                        void loadDatabases()
                        {

                              if (RadioGroup_databases.EditValue.ToString() == "MSSQLServer")
                              {

                                    obj_uc_DataBase_MSSQLServer = new UserControls.DataBases.uc_DataBase_MSSQLServer(this);
                                    obj_uc_DataBase_MSSQLServer.Location = new Point(0, 0);
                                    PanelControl_databases.Controls.Add(obj_uc_DataBase_MSSQLServer);
                                    loadExistingCredentials();
                                    loadValues();
                                    loadDatabasesMSSQLServerData();
                                    loadTables();
                                    
                                    
                              }

                        }


                        void loadDatabasesMSSQLServerData()
                        {

                              DAL.DAL.DATABASE = GV_database = "AdvCodeWizard";

                              string defaultDatabase = File.ReadAllText(Application.StartupPath + @"\FD\defaultDatabase.txt");


                              if (obj_uc_DataBase_MSSQLServer.TextEdit_password.Text == "" || obj_uc_DataBase_MSSQLServer.TextEdit_server.Text == "" || obj_uc_DataBase_MSSQLServer.TextEdit_userID.Text == "")
                              {
                                    obj_cls_MessageBox.ShowMessageBos("Connection Information is Missing.", MessageBoxIcon.Error);
                                    return;
                              }
                              DataTable dt_Databases = obj_cls_BLLFunctionss.loadAllDatabases();
                              DAL.DAL.DATABASE = GV_database = obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.Text;
                              if (dt_Databases != null)
                              {

                                    obj_cls_GenericFunctions.bindComboBoxEdit(dt_Databases, 0, obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases);
                                    obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.SelectedItem = defaultDatabase;
                                    checkExistence();

                              }
                              else
                              {
                                    obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.Properties.Items.Clear();
                                    obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.Text = "";
                                    obj_cls_MessageBox.ShowMessageBos("There's a Problem in BLL.", MessageBoxIcon.Error);
                              }
                              loadOtherTables();

                        }


                        void loadMainColumns()
                        {
                                    try
                                    {
                                                DataRow dr = GridView_tables.GetFocusedDataRow();
                                                cls_Global.GV_Main_Table_ID = dr[cls_Columns.Table_ID].ToString();
                                                cls_Global.GV_Main_Table_Name = dr[cls_Columns.Table_Names].ToString();
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                    DAL.DAL.DATABASE = obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.Text;


                                    cls_Global.GO_Tables_MainColumns = obj_cls_BLLFunctionss.loadColumns(cls_Global.GV_Main_Table_ID);
                                    cls_Global.GO_Tables_MainColumns = removeExtraColumns(cls_Global.GO_Tables_MainColumns, true, "");

                                    if (cls_Global.GO_Tables_MainColumns != null)
                                    {
                                                obj_cls_GenericFunctions.bindComboBoxEdit(cls_Global.GO_Tables_MainColumns, 0, ComboBoxEdit_primaryKey);
                                                obj_cls_GenericFunctions.bindComboBoxEdit(cls_Global.GO_Tables_MainColumns, 0, ComboBoxEdit_uniqueColumn);
                                                obj_cls_GenericFunctions.bindComboBoxEdit(cls_Global.GO_Tables_MainColumns, 0, ComboBoxEdit_nameColumn);
                                                obj_cls_GenericFunctions.bindComboBoxEdit(cls_Global.GO_Tables_MainColumns, 0, ComboBoxEdit_maxID);

                                                try
                                                {
                                                            ComboBoxEdit_maxID.SelectedIndex = 1;
                                                }
                                                catch { }

                                    }
                                    else
                                    {
                                                ComboBoxEdit_primaryKey.Properties.Items.Clear();
                                                ComboBoxEdit_uniqueColumn.Properties.Items.Clear();
                                                ComboBoxEdit_nameColumn.Properties.Items.Clear();
                                                ComboBoxEdit_maxID.Properties.Items.Clear();
                                                ComboBoxEdit_primaryKey.Text = ComboBoxEdit_uniqueColumn.Text = ComboBoxEdit_nameColumn.Text = ComboBoxEdit_maxID.Text = "";

                                                obj_cls_MessageBox.ShowMessageBos("There's a Problem in BLL while getting Columns of Main Table.", MessageBoxIcon.Error);
                                    }

                                    DAL.DAL.DATABASE = GV_database;
                        }

                        void loadOtherTables()
                        {
                                    DAL.DAL.DATABASE = GV_database = "AdvCodeWizard";

                                    cls_Global.GO_Tables_Editors = obj_cls_BLLFunctionss.loadAnyTable("select * from TBL_CONTROL_INFO where CONTROL_INFO_type = 'Editors'");
                                    cls_Global.GO_Tables_EditorsLookUp = obj_cls_BLLFunctionss.loadAnyTable("select CONTROL_INFO_ID,CONTROL_INFO_name from TBL_CONTROL_INFO where CONTROL_INFO_type = 'Editors'");
                                    cls_Global.GO_Tables_Repository = obj_cls_BLLFunctionss.loadAnyTable("select * from TBL_CONTROL_INFO where CONTROL_INFO_type = 'Editors'");
                                    cls_Global.GO_Tables_RepositoryLookUp = obj_cls_BLLFunctionss.loadAnyTable("select CONTROL_INFO_ID,CONTROL_INFO_name from TBL_CONTROL_INFO where CONTROL_INFO_type = 'Repository'");
                                    DAL.DAL.DATABASE = GV_database = obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.Text;
                        }
                        void loadDetColumns()
                        {
                                    try
                                    {
                                                // DataRow dr =  GridLookUpEdit_tablesForDetails.EditValue;
                                                cls_Global.GV_DET_Table_ID = GridLookUpEdit_tablesForDetails.EditValue.ToString();
                                                cls_Global.GV_DET_Table_Name = GridLookUpEdit_tablesForDetails.Text;
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                    DAL.DAL.DATABASE = obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.Text;


                                    cls_Global.GO_Tables_DetColumns = obj_cls_BLLFunctionss.loadColumns(cls_Global.GV_DET_Table_ID);

                                    cls_Global.GO_Tables_DetProcessedColumns = removeExtraColumns(cls_Global.GO_Tables_DetColumns, true, "");


                                    if (cls_Global.GO_Tables_DetColumns != null)
                                    {
                                                obj_cls_GenericFunctions.bindComboBoxEdit(cls_Global.GO_Tables_DetColumns, 0, ComboBoxEdit_foreignKey);
                                                obj_cls_GenericFunctions.bindComboBoxEdit(cls_Global.GO_Tables_DetColumns, 0, ComboBoxEdit_detailPrimaryKey);
                                                obj_cls_GenericFunctions.bindComboBoxEdit(cls_Global.GO_Tables_DetColumns, 0, ComboBoxEdit_orderingColumns);

                                                obj_cls_GenericFunctions.bindComboBoxEdit(cls_Global.GO_Tables_DetColumns, 0, ComboBoxEdit_treeprimaryKey);
                                                obj_cls_GenericFunctions.bindComboBoxEdit(cls_Global.GO_Tables_DetColumns, 0, ComboBoxEdit_treeparentKey);

                                                ComboBoxEdit_foreignKey.SelectedIndex = 1;
                                                ComboBoxEdit_orderingColumns.SelectedIndex = 2;

                                    }
                                    else
                                    {
                                                ComboBoxEdit_foreignKey.Properties.Items.Clear();
                                                ComboBoxEdit_foreignKey.Text = "";
                                                ComboBoxEdit_detailPrimaryKey.Properties.Items.Clear();
                                                ComboBoxEdit_detailPrimaryKey.Text = "";
                                                ComboBoxEdit_treeprimaryKey.Properties.Items.Clear();
                                                ComboBoxEdit_treeprimaryKey.Text = "";
                                                ComboBoxEdit_treeparentKey.Properties.Items.Clear();
                                                ComboBoxEdit_treeparentKey.Text = "";


                                                obj_cls_MessageBox.ShowMessageBos("There's a Problem in BLL while getting Columns of Main Table.", MessageBoxIcon.Error);
                                    }

                                    DAL.DAL.DATABASE = GV_database;
                        }

                       public void loadTables()
                        {
                                    try
                                    {
                                          if (obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.Text == "")
                                                {
                                                            obj_cls_MessageBox.ShowMessageBos("Database Name is Missing.", MessageBoxIcon.Error);
                                                            return;
                                                }

                                          DAL.DAL.DATABASE = obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.EditValue.ToString();

                                                cls_Global.GO_Tables_AllTables = obj_cls_BLLFunctionss.loadTables();

                                                if (cls_Global.GO_Tables_AllTables != null)
                                                {
                                                            GridControl_tables.DataSource = cls_Global.GO_Tables_AllTables;
                                                            GridView_tables.PopulateColumns();
                                                            GridView_tables.Columns[cls_Columns.Table_ID].Visible = false;


                                                            GridLookUpEdit_tablesForDetails.Properties.DataSource = cls_Global.GO_Tables_AllTables;
                                                            GridLookUpEdit_tablesForDetails.Properties.ValueMember = cls_Columns.Table_ID;
                                                            GridLookUpEdit_tablesForDetails.Properties.DisplayMember = cls_Columns.Table_Names;
                                                            GridLookUpEdit_tablesForDetails.Properties.PopulateViewColumns();
                                                            GridLookUpEdit_tablesForDetails.Properties.View.Columns[cls_Columns.Table_ID].Visible = false;
                                                            GridLookUpEdit_tablesForDetails.EditValue = cls_Global.GO_Tables_AllTables.Rows[0][cls_Columns.Table_ID].ToString();


                                                }
                                                else
                                                {
                                                            GridControl_tables.DataSource = null;
                                                            GridLookUpEdit_tablesForDetails.Properties.DataSource = null;
                                                            obj_cls_MessageBox.ShowMessageBos("There's a Problem in BLL.", MessageBoxIcon.Error);
                                                }


                                                loadMainColumns();
                                                DAL.DAL.DATABASE = GV_database;
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                        }

                        void loadValues()
                        {
                              DAL.DAL.SERVERNAME = obj_uc_DataBase_MSSQLServer.TextEdit_server.Text;
                              DAL.DAL.PASSWORD = obj_uc_DataBase_MSSQLServer.TextEdit_password.Text;
                              DAL.DAL.USERID = obj_uc_DataBase_MSSQLServer.TextEdit_userID.Text;
                              DAL.DAL.DATABASE = obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.Text;
                                    cls_Global.GV_Path = TextEdit_path.Text;
                                    cls_Global.GV_Is_Unique = CheckEdit_isUnique.Checked;
                                    cls_Global.GV_Is_Details = CheckEdit_isDetail.Checked;
                                    cls_Global.GV_Primary_Key = ComboBoxEdit_primaryKey.Text;
                                    cls_Global.GV_UniqueColumn = ComboBoxEdit_uniqueColumn.Text;
                                    cls_Global.GV_Foreign_Key = ComboBoxEdit_foreignKey.Text;
                                    cls_Global.GV_Name_Column = ComboBoxEdit_nameColumn.Text;
                                    cls_Global.GV_CurrentModule = ComboBoxEdit_nameSpace.Text;
                                    cls_Global.GV_ActualDatabase = obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.Text;
                                    cls_Global.GV_Max_ID_Column = ComboBoxEdit_maxID.Text;
                                    cls_Global.GV_Deail_Primary_Key = ComboBoxEdit_detailPrimaryKey.Text;
                                    cls_Global.GV_Foreign_Key = ComboBoxEdit_foreignKey.Text;
                                    cls_Global.GV_Ordering_Columns = ComboBoxEdit_orderingColumns.Text;

                                    cls_Global.GV_Tree_Parent_Key = ComboBoxEdit_treeparentKey.Text;
                                    cls_Global.GV_Tree_Primary_Key = ComboBoxEdit_treeprimaryKey.Text;
                                    cls_Global.GV_ProcedureMode = RadioGroup_ProdecureMode.EditValue.ToString();

                                    if ((CheckEdit_Main.Checked && CheckEdit_isDetail.Checked) || (CheckEdit_Main.Checked && (!CheckEdit_isDetail.Checked)))
                                                cls_Global.GV_Table_Name_For_Replacement = cls_Global.GV_Main_Table_Name;
                                    else
                                                if ((!CheckEdit_Main.Checked && CheckEdit_isDetail.Checked))
                                                            cls_Global.GV_Table_Name_For_Replacement = cls_Global.GV_DET_Table_Name;

                        }

                        void generatePath(bool pIsAfterNextConfirmed)
                        {

                                    try
                                    {

                                                cls_Global.GV_PathSavingProcedure = cls_Global.GV_Path + @"\Code\Procedure";
                                                cls_Global.GV_PathSavingDataSet = cls_Global.GV_Path + @"\Code\DataSet";
                                                cls_Global.GV_PathSavingBLl = cls_Global.GV_Path + @"\Code\BLL";
                                                cls_Global.GV_PathSavingForm = cls_Global.GV_Path + @"\Code\Form";

                                                Directory.CreateDirectory(cls_Global.GV_PathSavingProcedure);
                                                Directory.CreateDirectory(cls_Global.GV_PathSavingDataSet);
                                                Directory.CreateDirectory(cls_Global.GV_PathSavingBLl);
                                                Directory.CreateDirectory(cls_Global.GV_PathSavingForm);


                                                if (pIsAfterNextConfirmed)
                                                {
                                                            cls_Global.GV_PathSavingForm = cls_Global.GV_Path + @"\Code\Form";
                                                            cls_Global.GV_PathSavingForm = cls_Global.GV_PathSavingForm + @"\Code\frm_" + cls_Global.GV_Table_Name_For_Replacement + ".Designer.cs";

                                                            Directory.CreateDirectory(cls_Global.GV_PathSavingForm);
                                                }



                                    }
                                    catch (Exception ex)
                                    {

                                    }

                        }

                        DataTable removeExtraColumns(DataTable pTable, bool pIs_DefaultColumns, string pTableStatus)
                        {
                                    try
                                    {
                                    restart:
                                                foreach (DataRow dr in pTable.Rows)
                                                {
                                                            if (pIs_DefaultColumns)
                                                            {
                                                                        if (dr[cls_Columns.Column_Names].ToString() == cls_Global.GV_CMP_ID || dr[cls_Columns.Column_Names].ToString() == cls_Global.GV_BRC_ID || dr[cls_Columns.Column_Names].ToString() == cls_Global.GV_User_ID || dr[cls_Columns.Column_Names].ToString() == cls_Global.GV_IS_Deleted || dr[cls_Columns.Column_Names].ToString() == cls_Global.GV_Is_Auto_Generated)
                                                                        {
                                                                                    pTable.Rows.Remove(dr);
                                                                                    goto restart;
                                                                        }
                                                            }
                                                            else
                                                            {
                                                                        if (pTableStatus == "Main")
                                                                        {
                                                                                    if (dr[cls_Columns.Column_Names].ToString() == cls_Global.GV_Primary_Key || dr[cls_Columns.Column_Names].ToString() == cls_Global.GV_Max_ID_Column)
                                                                                    {
                                                                                                pTable.Rows.Remove(dr);
                                                                                                goto restart;
                                                                                    }
                                                                        }
                                                                        else if (pTableStatus == "Detail")
                                                                        {
                                                                              if (dr[cls_Columns.Column_Names].ToString() == cls_Global.GV_Deail_Primary_Key || dr[cls_Columns.Column_Names].ToString() == cls_Global.GV_Foreign_Key || dr[cls_Columns.Column_Names].ToString() == cls_Global.GV_Ordering_Columns)
                                                                                    {
                                                                                                pTable.Rows.Remove(dr);
                                                                                                goto restart;
                                                                                    }
                                                                        }
                                                            }


                                                }
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                    return pTable;
                        }

                        void referesh()
                        {
                                    GenericClasses.cls_GenericFunctions.loadNameSpaces(ComboBoxEdit_nameSpace);
                                    DAL.DAL.SERVERNAME = obj_uc_DataBase_MSSQLServer.TextEdit_server.Text = ".";
                                    DAL.DAL.PASSWORD = obj_uc_DataBase_MSSQLServer.TextEdit_password.Text = "123";
                                    DAL.DAL.USERID = obj_uc_DataBase_MSSQLServer.TextEdit_userID.Text = "sa";
                                    DAL.DAL.DATABASE = GV_database;

                                    cls_Global.GV_Path = TextEdit_path.Text = "C:";
                                    cls_Global.GV_Is_Unique = CheckEdit_isUnique.Checked = false;
                                    cls_Global.GV_Is_Details = CheckEdit_isDetail.Checked = false;
                                    cls_Global.GV_Primary_Key = ComboBoxEdit_primaryKey.Text = "";
                                    cls_Global.GV_UniqueColumn = ComboBoxEdit_uniqueColumn.Text = "";
                                    cls_Global.GV_Foreign_Key = ComboBoxEdit_foreignKey.Text = "";
                                    cls_Global.GV_Name_Column = ComboBoxEdit_nameColumn.Text = "";
                                    cls_Global.GV_CurrentModule = ComboBoxEdit_nameSpace.Text = "";
                                    cls_Global.GV_Max_ID_Column = ComboBoxEdit_maxID.Text = "";
                                    cls_Global.GV_Deail_Primary_Key = ComboBoxEdit_detailPrimaryKey.Text = "";
                                    cls_Global.GV_Tree_Parent_Key = ComboBoxEdit_treeparentKey.Text = "";
                                    cls_Global.GV_Tree_Primary_Key = ComboBoxEdit_treeprimaryKey.Text = "";

                                    //ComboBoxEdit_primaryKey.Properties.Items.Clear();
                                    //ComboBoxEdit_uniqueColumn.Properties.Items.Clear();
                                    //ComboBoxEdit_uniqueColumn.Properties.Items.Clear();
                                    //  ComboBoxEdit_foreignKey.Properties.Items.Clear();
                                    //ComboBoxEdit_databases.Properties.Items.Clear();
                                    //ComboBoxEdit_maxID.Properties.Items.Clear();
                                    //ComboBoxEdit_detailPrimaryKey.Properties.Items.Clear();
                                    cls_Global.GV_DET_Table_ID = cls_Global.GV_DET_Table_Name = cls_Global.GV_Main_Table_ID = cls_Global.GV_Main_Table_Name = "";
                                    cls_Global.GV_ProcedureDeletion = cls_Global.GV_ProcedureInsertionDet = cls_Global.GV_ProcedureInsertionMain = cls_Global.GV_ProcedureUpdation = cls_Global.GV_Prpcedure_Selection = "";

                                    cls_Global.GO_Tables_DetProcessedColumns.Rows.Clear();
                                    cls_Global.GO_Tables_MainProcessedColumns.Rows.Clear();
                                    cls_Global.GO_Tables_DetColumns.Rows.Clear();
                                    cls_Global.GO_Tables_MainColumns.Rows.Clear();
                                    loadDatabases();
                                    loadOtherTables();
                                    cls_Global.GV_Prpcedure_Selection = "";
                                    cls_Global.GV_ProcedureInsertionMain = "";
                                    cls_Global.GV_ProcedureInsertionDet = "";
                                    cls_Global.GV_ProcedureDeletion = "";
                                    cls_Global.GV_ProcedureUpdation = "";
                                    cls_Global.GV_DataSet = "";
                                    cls_Global.GV_BLL = "";
                                    cls_Global.GV_Table_Name_For_Replacement = "";
                                    RadioGroup_GridOrTree.SelectedIndex = 0;
                                    CheckEdit_Main.Checked = cls_Global.GV_Is_Main = true;

                                    cls_Global.GO_Tables_Editors = null;
                                    cls_Global.GO_Tables_EditorsLookUp = null;
                                    cls_Global.GO_Tables_Repository = null;
                                    cls_Global.GO_Tables_RepositoryLookUp = null;


                        }

                        bool check()
                        {
                              if (obj_uc_DataBase_MSSQLServer.TextEdit_server.Text == "" || obj_uc_DataBase_MSSQLServer.TextEdit_password.Text == "" || obj_uc_DataBase_MSSQLServer.TextEdit_userID.Text == "")
                                    {
                                                obj_cls_MessageBox.ShowMessageBos("Connection Information is Missing.", MessageBoxIcon.Error);
                                                return false;

                                    }
                                    else if (!Directory.Exists(TextEdit_path.Text))
                                    {
                                                obj_cls_MessageBox.ShowMessageBos("This Path is not exist.", MessageBoxIcon.Error);
                                                return false;
                                    }
                                    else if ((CheckEdit_isUnique.Checked && (cls_Global.GV_Name_Column == "" || cls_Global.GV_Max_ID_Column == "")) || (CheckEdit_Main.Checked && (cls_Global.GV_Primary_Key == "" || cls_Global.GV_Max_ID_Column == "")) || (CheckEdit_isDetail.Checked && RadioGroup_GridOrTree.EditValue.ToString() == "Grid" && (cls_Global.GV_Deail_Primary_Key == "" || cls_Global.GV_Foreign_Key == "")) || (CheckEdit_isDetail.Checked && RadioGroup_GridOrTree.EditValue.ToString() == "Tree" && (cls_Global.GV_Tree_Parent_Key == "" || cls_Global.GV_Tree_Primary_Key == "")))
                                    {
                                                obj_cls_MessageBox.ShowMessageBos("Kindly provide all columns.", MessageBoxIcon.Error);
                                                return false;
                                    }
                                    else if (!CheckEdit_Main.Checked && !CheckEdit_isDetail.Checked)
                                    {
                                                obj_cls_MessageBox.ShowMessageBos("Select either Main Info to proceed ot Detail.", MessageBoxIcon.Error);
                                                return false;
                                    }
                                    if (cls_Global.GO_Tables_Editors == null ||
                                       cls_Global.GO_Tables_EditorsLookUp == null ||
                                       cls_Global.GO_Tables_Repository == null ||
                                       cls_Global.GO_Tables_RepositoryLookUp == null)
                                    {

                                                obj_cls_MessageBox.ShowMessageBos("First load all possible data from database.", MessageBoxIcon.Error);
                                                return false;
                                    }

                                    //cls_Global.GV_Is_Unique = CheckEdit_isUnique.Checked = false;
                                    //cls_Global.GV_Is_Details = CheckEdit_isDetail.Checked = false;
                                    //cls_Global.GV_Primary_Key = ComboBoxEdit_primaryKey.Text = "";
                                    //cls_Global.GV_UniqueColumn = ComboBoxEdit_uniqueColumn.Text = "";
                                    //cls_Global.GV_Foreign_Key = ComboBoxEdit_foreignKey.Text = "";
                                    //cls_Global.GV_Name_Column = ComboBoxEdit_nameColumn.Text = "";
                                    //cls_Global.GV_CurrentModule = ComboBoxEdit_databases.Text = "";
                                    //cls_Global.GV_Max_ID_Column = ComboBoxEdit_maxID.Text = "";
                                    //cls_Global.GV_Deail_Primary_Key = ComboBoxEdit_detailPrimaryKey.Text = "";
                                    //ComboBoxEdit_primaryKey.Properties.Items.Clear();
                                    //ComboBoxEdit_uniqueColumn.Properties.Items.Clear();
                                    //ComboBoxEdit_uniqueColumn.Properties.Items.Clear();
                                    //ComboBoxEdit_foreignKey.Properties.Items.Clear();
                                    //ComboBoxEdit_databases.Properties.Items.Clear();
                                    //ComboBoxEdit_maxID.Properties.Items.Clear();
                                    //ComboBoxEdit_detailPrimaryKey.Properties.Items.Clear();
                                    //cls_Global.GV_DET_Table_ID = cls_Global.GV_DET_Table_Name = cls_Global.GV_Main_Table_ID = cls_Global.GV_Main_Table_Name = "";
                                    //cls_Global.GO_Tables_DetColumns.Rows.Clear();
                                    //cls_Global.GO_Tables_MainColumns.Rows.Clear();

                                    return true;
                        }

                        void initialActions()
                        {

                                    cls_Global.GO_Tables_MainColumns = removeExtraColumns(cls_Global.GO_Tables_MainColumns, false, "Main");
                                    cls_Global.GO_Tables_DetColumns = removeExtraColumns(cls_Global.GO_Tables_DetColumns, false, "Detail");


                        }

                        void loadGenerics()
                        {
                                    cls_Global.GV_PathStartup = Application.StartupPath;
                                    cls_Global.GV_PathNameSpaces = cls_Global.GV_PathStartup + @"\FD\NameSpaces\NameSpaces.txt";

                        }


                        #endregion

                        private void RadioGroup_GridOrTree_SelectedIndexChanged(object sender, EventArgs e)
                        {
                                    cls_Global.GV_DetailType = RadioGroup_GridOrTree.EditValue.ToString();

                                    if (cls_Global.GV_DetailType == "Grid")
                                    {
                                                ComboBoxEdit_foreignKey.Enabled = ComboBoxEdit_detailPrimaryKey.Enabled = true;
                                                ComboBoxEdit_treeprimaryKey.Enabled = ComboBoxEdit_treeparentKey.Enabled = false;

                                    }
                                    else
                                    {
                                                ComboBoxEdit_foreignKey.Enabled = ComboBoxEdit_detailPrimaryKey.Enabled = false;
                                                ComboBoxEdit_treeprimaryKey.Enabled = ComboBoxEdit_treeparentKey.Enabled = true;
                                    }


                        }

                        private void CheckEdit_Main_CheckedChanged(object sender, EventArgs e)
                        {
                                    ComboBoxEdit_primaryKey.Enabled = ComboBoxEdit_maxID.Enabled = CheckEdit_Main.Checked;
                                    loadValues();
                        }

                        private void label4_Click(object sender, EventArgs e)
                        {

                        }

                        private void label3_Click(object sender, EventArgs e)
                        {

                        }

                        private void label1_Click(object sender, EventArgs e)
                        {

                        }

                        private void label8_Click(object sender, EventArgs e)
                        {

                        }

                        private void label2_Click(object sender, EventArgs e)
                        {

                        }

                        private void label7_Click(object sender, EventArgs e)
                        {

                        }

                        private void label9_Click(object sender, EventArgs e)
                        {

                        }

                        private void label6_Click(object sender, EventArgs e)
                        {

                        }

                        private void label5_Click(object sender, EventArgs e)
                        {

                        }

                        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
                        {
                                    frm_SQlParamAndProperties obj = new frm_SQlParamAndProperties();
                                    obj.Show();
                        }

                        private void ComboBoxEdit_existingCredentials_SelectedIndexChanged(object sender, EventArgs e)
                        {
                              loadCredentialParameters(obj_uc_DataBase_MSSQLServer.ComboBoxEdit_existingCredentials.SelectedItem.ToString());

                        }

                        private void ComboBoxEdit_databases_KeyDown(object sender, KeyEventArgs e)
                        {
                                    if (e.KeyData == Keys.F5)
                                          File.WriteAllText(Application.StartupPath + @"\FD\defaultDatabase.txt", obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.SelectedItem.ToString());
                        }

                        private void RadioGroup_databases_SelectedIndexChanged(object sender, EventArgs e)
                        {
                              loadDatabases();
                        }

                        private void RadioGroup_databases_SelectedIndexChanged_1(object sender, EventArgs e)
                        {
                              loadDatabases();
                        }





                        void loaduserControls()
                        { 
                        


                        }

                        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
                        {
                              Forms.frm_validateCodeGenerator ob = new Forms.frm_validateCodeGenerator(obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.EditValue.ToString());
                              ob.Show();
                        }

                        private void MDI_MouseDown(object sender, MouseEventArgs e)
                        {

                             



                        }

                        private void MDI_KeyDown(object sender, KeyEventArgs e)
                        {
                              if (e.KeyCode == Keys.Alt)
                              {


                                    bar_Main.Visible = !bar_Main.Visible;



                              }
                        }

                        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
                        {
                              DAL.DAL.DATABASE = obj_uc_DataBase_MSSQLServer.ComboBoxEdit_databases.Text;
                              Forms.frm_JoinScriptscreator obj = new Forms.frm_JoinScriptscreator();
                              obj.Show();
                        }












            }
}
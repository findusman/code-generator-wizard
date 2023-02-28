using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using AdvCodeWizard.GenericClasses;
using System.Windows.Forms;
namespace AdvCodeWizard.FormWizard
{
      class frm_FORMWIZARD_P
      {

            frm_FORMWIZARD objfrm_FORMWIZARD = null;

            GenericClasses.cls_MessageBox obj_cls_MessageBox = new GenericClasses.cls_MessageBox();
            GenericClasses.cls_StoreProcedure obj_cls_StoreProcedure = new GenericClasses.cls_StoreProcedure();
            GenericClasses.cls_GenericFunctions obj_cls_GenericFunctions = new GenericClasses.cls_GenericFunctions();

            GenericClasses.cls_Columns obj_cls_Columns = new GenericClasses.cls_Columns();

            String GV_codeCallingFunctiontoBindGridLookUpEdit = "";
            String GV_codeCallingFunctiontoInLoadGridLookUpEdit = "";
            String GV_codeBindGridLookUpEdit = "";


            public frm_FORMWIZARD_P(frm_FORMWIZARD pobjfrm_FORMWIZARD)
            {

                  objfrm_FORMWIZARD = pobjfrm_FORMWIZARD;
                  cls_Global.GV_ParentPathPartialClass = Application.StartupPath + @"\FD\FormCode";
                  cls_Global.GV_PathGridLookUpEditBindings = Application.StartupPath + @"\FD\FormCode\GridLookUpEditBindings.txt";
                  cls_Global.GV_PathShowingFormEntity = Application.StartupPath + @"\FD\FormCode\ShowingFormEntity.txt";



                  //cls_Global.GV_PathPartialClassMain = cls_Global.GV_ParentPathPartialClass + @"\PartialFormClassTemplateMain.txt";

            }

            string generateDesignerClass()
            {
                  string strTemp = "";
                  if (cls_Global.GV_Is_Main && cls_Global.GV_Is_Details)
                        strTemp = File.ReadAllText(objfrm_FORMWIZARD.GV_PathDesignerClassTemplateMainDetail);
                  else if (cls_Global.GV_Is_Main)
                        strTemp = File.ReadAllText(objfrm_FORMWIZARD.GV_PathDesignerClassTemplateMain);

                  strTemp = strTemp.Replace("<<<Main_Table>>>", cls_Global.GV_Table_Name_For_Replacement);
                  strTemp = strTemp.Replace("<<<Database_Name>>>", cls_Global.GV_CurrentModule);
                  strTemp = strTemp.Replace("<<<Form_Text>>>", objfrm_FORMWIZARD.t_caption.Text);

                  string DeclaringObjects = cls_GenericFunctions.generadeCode_DeclaringObjects();
                  string InitializingObjects = cls_GenericFunctions.generadeCode_initializing();
                  string AssigningAtrribute = cls_GenericFunctions.generadeCode_AssigningAttributes();

                  strTemp = strTemp.Replace("<<<AssigningAtrribute>>>", AssigningAtrribute);
                  strTemp = strTemp.Replace("<<<InitializingObjects>>>", InitializingObjects);
                  strTemp = strTemp.Replace("<<<DeclaringObjects>>>", DeclaringObjects);
                  strTemp = strTemp.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);
                  strTemp = strTemp.Replace("<<<DET_Table_Name>>>", cls_Global.GV_DET_Table_Name);

                  return strTemp;
            }
            string generateFormClass()
            {
                  string strTemp = "";


                  if (cls_Global.GV_Is_Main && cls_Global.GV_Is_Details)
                        strTemp = File.ReadAllText(objfrm_FORMWIZARD.GV_PathFormClassTemplateMainDetail);

                  else if (cls_Global.GV_Is_Main)
                        strTemp = File.ReadAllText(objfrm_FORMWIZARD.GV_PathFormClassTemplateMain);


                  strTemp = strTemp.Replace("<<<Main_Table>>>", cls_Global.GV_Table_Name_For_Replacement);
                  strTemp = strTemp.Replace("<<<Det_Table>>> ", cls_Global.GV_DET_Table_Name);
              
                  strTemp = strTemp.Replace("<<<Database_Name>>>", cls_Global.GV_CurrentModule);
                  strTemp = strTemp.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);
                  string Control_Events = cls_GenericFunctions.generadeCode_Events();


                  //Control_Events = Control_Events.Replace("<<<Binded_Table>>>", cls_Global.GV_Main_Table_Name);

                  strTemp = strTemp.Replace("<<<Control_Events>>>", Control_Events);
                  //strTemp = strTemp.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);

                  return strTemp;
            }
            string generatePartialClass()
            {
                  string tmpText = "";

                  if (cls_Global.GV_Is_Main && cls_Global.GV_Is_Details)
                        tmpText = File.ReadAllText(objfrm_FORMWIZARD.GV_PathPartialFormClassTemplateMainDetail);

                  else if (cls_Global.GV_Is_Main)
                        tmpText = File.ReadAllText(objfrm_FORMWIZARD.GV_PathPartialFormClassTemplateMain);



                  generateGridBindingCode();


                  string detailColumnsAttributes = cls_GenericFunctions.generadeCode_detailColumnsAttributes("");
                 
                  int count = cls_Global.GO_Tables_MainColumns.Rows.Count;


                  string Getting_Values = cls_GenericFunctions.generadeCode_GettingSetting("Getting_Values");
                  string Setting_Values = cls_GenericFunctions.generadeCode_GettingSetting("Setting_Values");

                  tmpText = tmpText.Replace("<<<Getting_Values>>>", Getting_Values);
                  tmpText = tmpText.Replace("<<<Setting_Values>>>", Setting_Values);

                  tmpText = tmpText.Replace("<<<Database_Name>>>", cls_Global.GV_CurrentModule);
                  tmpText = tmpText.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
                  tmpText = tmpText.Replace("<<<Primary_Key>>>", cls_Global.GV_Primary_Key);
                  tmpText = tmpText.Replace("<<<Name_Column>>>", cls_Global.GV_Name_Column);
                  tmpText = tmpText.Replace("<<<Det_Table>>>", cls_Global.GV_DET_Table_Name);
                  tmpText = tmpText.Replace("<<<Foreign_Key>>>", cls_Global.GV_Foreign_Key);
                  tmpText = tmpText.Replace("<<<Max_ID_Column>>>", cls_Global.GV_Max_ID_Column);
                  tmpText = tmpText.Replace("<<<Is_Auto_Generated>>>", cls_Global.GV_Is_Auto_Generated);
                  tmpText = tmpText.Replace("<<<IsAutoGenerateOptionVisible>>>", objfrm_FORMWIZARD.CheckEdit_isAutoGenerateOptionVisible.Checked ? "true" : "false");
                  tmpText = tmpText.Replace("<<<loadGridLookUpEdit>>>", GV_codeCallingFunctiontoBindGridLookUpEdit);
                  tmpText = tmpText.Replace("<<<BindingGridLookUpEdit>>>", GV_codeCallingFunctiontoInLoadGridLookUpEdit);
                  tmpText = tmpText.Replace("<<<AssignColumnAttributes>>>", detailColumnsAttributes);





                  File.WriteAllText(cls_Global.GV_PathSavingForm + @"\cls_" + cls_Global.GV_Main_Table_Name + "_P.cs", tmpText);
                  return tmpText;
            }

            void generateGridBindingCode()
            {

                  foreach (DataRow dr in objfrm_FORMWIZARD.dataSet.dt_dingingDataSource.Rows)
                  {

                        string tmpCode = File.ReadAllText(cls_Global.GV_PathGridLookUpEditBindings);
                        string Columns = dr["Columns"].ToString();
                        string table = dr["Tables"].ToString();
                        string displayMember = dr["DisplayMember"].ToString();
                        string valueMember = dr["ValueMember"].ToString();
                        string moduleName = dr["ModuleName"].ToString();


                        tmpCode = tmpCode.Replace("<<<GridLookUpTable_Table>>>", table);
                        tmpCode = tmpCode.Replace("<<<Display_Member>>>", displayMember);
                        tmpCode = tmpCode.Replace("<<<Value_Member>>>", valueMember);
                        tmpCode = tmpCode.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
                        tmpCode = tmpCode.Replace("<<<Module_Name>>>", moduleName);
                        tmpCode = tmpCode.Replace("<<<Control_Name>>>", "GridLookUpEdit_" + Columns);

                        GV_codeBindGridLookUpEdit = GV_codeBindGridLookUpEdit + tmpCode;

                        GV_codeCallingFunctiontoBindGridLookUpEdit = GV_codeCallingFunctiontoBindGridLookUpEdit + Environment.NewLine + @"                loadGridLookUpEdit(""" + table + @""");";
                        GV_codeCallingFunctiontoInLoadGridLookUpEdit = GV_codeCallingFunctiontoInLoadGridLookUpEdit + Environment.NewLine + @"                " + moduleName + "_PRESENTATION_LAYER.cls_bindGridLookUpEdit." + table + "(obj_frm_" + cls_Global.GV_Main_Table_Name + ".GridLookUpEdit_" + Columns + ");";

                        objfrm_FORMWIZARD.m_bindGrid.Text = GV_codeBindGridLookUpEdit;

                  }


            }

            public void generat()
            {

                  objfrm_FORMWIZARD.m_designerClass.Text = generateDesignerClass();
                  objfrm_FORMWIZARD.m_FormClass.Text = generateFormClass();
                  objfrm_FORMWIZARD.m_partialclass.Text = generatePartialClass();
                  generateShowingFormEntity();
                  updateDataCameFromPreviousScreen();

            }

            void generateShowingFormEntity()
            {
                  string tmpCode = File.ReadAllText(cls_Global.GV_PathShowingFormEntity);



                  tmpCode = tmpCode.Replace("<<<Main_Table>>>", cls_Global.GV_Main_Table_Name);
                  tmpCode = tmpCode.Replace("<<<Module_Name>>>", cls_Global.GV_CurrentModule);

                  objfrm_FORMWIZARD.m_showingFormEntity.Text = tmpCode;

            }

            void updateSelectionProcedure()
            {
                  string data = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_MainProcessedColumns, "Columns_For_LookUpForm_In_Selection", "               ");
                  objfrm_FORMWIZARD.m_selection.Text = objfrm_FORMWIZARD.m_selection.Text.Replace("<<<Column_For_Selection_A>>>", data);
                  data = cls_GenericFunctions.generateColumn(cls_Global.GO_Tables_MainProcessedColumns, "Columns_Length_For_LookUpForm_In_Selection", "               ");
                  objfrm_FORMWIZARD.m_partialclass.Text = objfrm_FORMWIZARD.m_partialclass.Text.Replace("<<<Columns_Length_For_LookUpForm_In_Selection>>>", data);

            }

            public void updateDataCameFromPreviousScreen()
            {

                  objfrm_FORMWIZARD.m_designerClass.Text = generateDesignerClass();
                  updateSelectionProcedure();

            }

      }
}

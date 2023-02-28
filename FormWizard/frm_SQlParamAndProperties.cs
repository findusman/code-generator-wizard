using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AdvCodeWizard
{
    public partial class frm_SQlParamAndProperties : DevExpress.XtraEditors.XtraForm
    {
        public frm_SQlParamAndProperties()
        {
            InitializeComponent();
        }

        List<string> GV_list_parametertypeSQL = new List<string>();
        List<string> GV_list_parametertypeDOTNET = new List<string>();
        List<string> GV_list_parametertypeDOTNETNative = new List<string>();
           
        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
        }

        string generateCode()
        {

            String data_SQLParameter = "", tmp_parameterType = "" , tmpline = "", data_Properties = "";
            String[] tempData = MemoEdit_scalerParameter.Text.Trim().Split('@'), tmp1 = null, tmp2 = null,tmp3 = null ;
            List<string> list_parameterName = new List<string>();
            List<string> list_parametertype = new List<string>();
            List<string> list_parameterNetTypes = new List<string>();
           
            int firstspaceindex = 0;
               
            try
            {

                

                foreach (string str_line in tempData)
                {
                    if (str_line != "")
                    {

                        tmp1 = (str_line.Trim()).Split(',');
                        tmpline = tmp1[0];
                        
                        firstspaceindex = tmpline.IndexOf(' ');
                        StringBuilder sb = new StringBuilder(tmpline);
                        sb[firstspaceindex] = '@';
                        tmpline = sb.ToString();

                        tmp2 = tmpline.Split('@');

                        if (tmp2[0].Trim() == "COA_isAddedDirectly")
                        {
                            string str = "";
                        }
                        list_parameterName.Add(tmp2[0].Trim());


                        if (tmp2[1].Contains("("))
                        {

                            tmp3 = tmp2[1].Split('(');
                            tmp_parameterType = tmp3[0].Trim(); 

                        }
                        else
                        {
                            tmp_parameterType = tmp2[1].Trim();
                           
                        }



                        for (int x = 0; x < GV_list_parametertypeSQL.Count; x++)
                        {

                            if (tmp_parameterType.ToLower() == GV_list_parametertypeSQL[x])
                            {
                                list_parametertype.Add(GV_list_parametertypeDOTNET[x]);
                                list_parameterNetTypes.Add(GV_list_parametertypeDOTNETNative[x]);
                                continue;
                            }
                        }

                            
                    }
                }

                string space = "            ";
              
                data_SQLParameter =  space + "SqlParameter[] sql_param = new SqlParameter[" + list_parameterName.Count.ToString() + "];";
                data_SQLParameter = data_SQLParameter + Environment.NewLine;
          
                int xx = list_parameterName.Count;
                int xxx = list_parametertype.Count;
                for (int x = 0; x < list_parameterName.Count; x++)
                {
                    string tmpAssignedValue = "";
                    data_SQLParameter = data_SQLParameter + Environment.NewLine +  space +"sql_param[" + x.ToString() + "] = new SqlParameter(\"@" + list_parameterName[x] + "\", SqlDbType." + list_parametertype[x] + ");";

                    //if (CheckEdit_isRemoveFixedColumns.Checked)
                    //{
                                if (list_parameterName[x] == "CMP_ID" || list_parameterName[x] == "BRC_ID")
                                            tmpAssignedValue = "GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_" + list_parameterName[x];

                                else if (list_parameterName[x] == "User_ID")
                                            tmpAssignedValue = "GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID";

                                else if (list_parameterName[x] == "Is_Deleted")
                                            tmpAssignedValue = "GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted";
                                else
                                            tmpAssignedValue = list_parameterName[x];
                    //}

                    data_SQLParameter = data_SQLParameter + Environment.NewLine + space + "sql_param[" + x.ToString() + "].Value = " + tmpAssignedValue + " ;";
                    data_SQLParameter = data_SQLParameter + Environment.NewLine;

                    if (list_parameterName[x] == "CMP_ID" || list_parameterName[x] == "BRC_ID" || list_parameterName[x] == "USER_ID" || list_parameterName[x] == "Is_Deleted")
                        continue;

                    data_Properties = data_Properties + Environment.NewLine + space + "private  " + list_parameterNetTypes[x] + "  p" + list_parameterName[x] + ";";
                    data_Properties = data_Properties + Environment.NewLine;
                    data_Properties = data_Properties + Environment.NewLine + space + "public  " + list_parameterNetTypes[x] + "  " + list_parameterName[x] ;
                    data_Properties = data_Properties + Environment.NewLine + space + "{  ";
                    data_Properties = data_Properties + Environment.NewLine + space + "   get { return  p" + list_parameterName[x] + "; }  ";
                    data_Properties = data_Properties + Environment.NewLine + space + "   set { p" + list_parameterName[x] + " = value ; }  ";
                    data_Properties = data_Properties + Environment.NewLine + space + "}  ";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            MemoEdit_properties.Text = data_Properties;
            data_SQLParameter.Replace(" CMP_ID ", "GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID");
            data_SQLParameter.Replace("BRC_ID", "GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID");
            data_SQLParameter.Replace("Is_Deleted", "GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted");
            data_SQLParameter.Replace("User_ID", "GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID");
          
            MemoEdit_SQLParameter.Text = data_SQLParameter;
            return data_SQLParameter;
            
        }
        private void MemoEdit_scalerParameter_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void frmBarCodeGenerator_Load(object sender, EventArgs e)
        {
            GV_list_parametertypeSQL.Add("nvarchar");
            GV_list_parametertypeDOTNET.Add("NVarChar");
            GV_list_parametertypeDOTNETNative.Add("String");

            GV_list_parametertypeSQL.Add("varchar");
            GV_list_parametertypeDOTNET.Add("VarChar");
            GV_list_parametertypeDOTNETNative.Add("String");


            GV_list_parametertypeSQL.Add("int");
            GV_list_parametertypeDOTNET.Add("Int");
            GV_list_parametertypeDOTNETNative.Add("int");


            GV_list_parametertypeSQL.Add("bigint");
            GV_list_parametertypeDOTNET.Add("BigInt");
            GV_list_parametertypeDOTNETNative.Add("int");


            GV_list_parametertypeSQL.Add("smallint");
            GV_list_parametertypeDOTNET.Add("SmallInt");
            GV_list_parametertypeDOTNETNative.Add("int");


            GV_list_parametertypeSQL.Add("money");
            GV_list_parametertypeDOTNET.Add("Money");
            GV_list_parametertypeDOTNETNative.Add("double");


            GV_list_parametertypeSQL.Add("datetime");
            GV_list_parametertypeDOTNET.Add("DateTime");
            GV_list_parametertypeDOTNETNative.Add("DateTime");


            GV_list_parametertypeSQL.Add("date");
            GV_list_parametertypeDOTNET.Add("Date");
            GV_list_parametertypeDOTNETNative.Add("DateTime");


            GV_list_parametertypeSQL.Add("float");
            GV_list_parametertypeDOTNET.Add("Float");
            GV_list_parametertypeDOTNETNative.Add("float");


            GV_list_parametertypeSQL.Add("binary");
            GV_list_parametertypeDOTNET.Add("Binary");
            GV_list_parametertypeDOTNETNative.Add("bool");


            GV_list_parametertypeSQL.Add("numeric");
            GV_list_parametertypeDOTNET.Add("Numeric");
            GV_list_parametertypeDOTNETNative.Add("double");


            GV_list_parametertypeSQL.Add("char");
            GV_list_parametertypeDOTNET.Add("Char");
            GV_list_parametertypeDOTNETNative.Add("char");


            GV_list_parametertypeSQL.Add("bit");
            GV_list_parametertypeDOTNET.Add("Bit");
            GV_list_parametertypeDOTNETNative.Add("bool");


            //nvarchar,string,string.Empty,NVarChar,String
            //varchar,string,string.Empty,varchar,String
            //int,int,0,Int,Int32
            //bigint,int32,0,bigint,Int32
            //smallint,int16,0,SmallInt,Int16
            //money,decimal,0,Money,Decimal
            //datetime,DateTime,DateTime.Now,DateTime,DateTime
            //date,DateTime,DateTime.Now,Date,Date
            //float,Double,0,Float,Double
            //binary,Byte[],0,Binary,Byte
            //numeric,double,0,Decimal,Decimal
            //char,char,'C',Char,Char
            //bit,bool,true,Bit,Boolean

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
         
            generateCode();
    
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MemoEdit_scalerParameter.Text.Trim());
        }



    }
}
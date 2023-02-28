namespace AdvCodeWizard.UserControls.DataBases
{
      partial class uc_DataBase_MSSQLServer
      {
            /// <summary> 
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary> 
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                  if (disposing && (components != null))
                  {
                        components.Dispose();
                  }
                  base.Dispose(disposing);
            }

            #region Component Designer generated code

            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.ComboBoxEdit_existingCredentials = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ComboBoxEdit_databases = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TextEdit_password = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_server = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_userID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_existingCredentials.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_databases.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_server.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_userID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxEdit_existingCredentials
            // 
            this.ComboBoxEdit_existingCredentials.EditValue = "Select Credentials";
            this.ComboBoxEdit_existingCredentials.Location = new System.Drawing.Point(9, 10);
            this.ComboBoxEdit_existingCredentials.Name = "ComboBoxEdit_existingCredentials";
            this.ComboBoxEdit_existingCredentials.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ComboBoxEdit_existingCredentials.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.ComboBoxEdit_existingCredentials.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.ComboBoxEdit_existingCredentials.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxEdit_existingCredentials.Properties.DropDownRows = 20;
            this.ComboBoxEdit_existingCredentials.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxEdit_existingCredentials.Size = new System.Drawing.Size(486, 22);
            this.ComboBoxEdit_existingCredentials.TabIndex = 124;
            // 
            // ComboBoxEdit_databases
            // 
            this.ComboBoxEdit_databases.Location = new System.Drawing.Point(9, 66);
            this.ComboBoxEdit_databases.Name = "ComboBoxEdit_databases";
            this.ComboBoxEdit_databases.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ComboBoxEdit_databases.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.ComboBoxEdit_databases.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.ComboBoxEdit_databases.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxEdit_databases.Properties.DropDownRows = 20;
            this.ComboBoxEdit_databases.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxEdit_databases.Size = new System.Drawing.Size(485, 22);
            this.ComboBoxEdit_databases.TabIndex = 123;
            this.ComboBoxEdit_databases.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEdit_databases_SelectedIndexChanged);
            // 
            // TextEdit_password
            // 
            this.TextEdit_password.EditValue = "123";
            this.TextEdit_password.Location = new System.Drawing.Point(399, 38);
            this.TextEdit_password.Name = "TextEdit_password";
            this.TextEdit_password.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TextEdit_password.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.TextEdit_password.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TextEdit_password.Properties.PasswordChar = '*';
            this.TextEdit_password.Size = new System.Drawing.Size(95, 22);
            this.TextEdit_password.TabIndex = 120;
            // 
            // TextEdit_server
            // 
            this.TextEdit_server.EditValue = "USMANRAZA-PC\\SQLEXPRESS";
            this.TextEdit_server.Location = new System.Drawing.Point(9, 38);
            this.TextEdit_server.Name = "TextEdit_server";
            this.TextEdit_server.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TextEdit_server.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.TextEdit_server.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TextEdit_server.Size = new System.Drawing.Size(269, 22);
            this.TextEdit_server.TabIndex = 121;
            this.TextEdit_server.EditValueChanged += new System.EventHandler(this.TextEdit_server_EditValueChanged);
            // 
            // TextEdit_userID
            // 
            this.TextEdit_userID.EditValue = "sa";
            this.TextEdit_userID.Location = new System.Drawing.Point(283, 38);
            this.TextEdit_userID.Name = "TextEdit_userID";
            this.TextEdit_userID.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TextEdit_userID.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.TextEdit_userID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TextEdit_userID.Size = new System.Drawing.Size(111, 22);
            this.TextEdit_userID.TabIndex = 122;
            // 
            // uc_DataBase_MSSQLServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComboBoxEdit_existingCredentials);
            this.Controls.Add(this.ComboBoxEdit_databases);
            this.Controls.Add(this.TextEdit_password);
            this.Controls.Add(this.TextEdit_server);
            this.Controls.Add(this.TextEdit_userID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uc_DataBase_MSSQLServer";
            this.Size = new System.Drawing.Size(504, 94);
            this.Load += new System.EventHandler(this.uc_DataBase_MSSQLServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_existingCredentials.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_databases.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_server.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_userID.Properties)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            public DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit_existingCredentials;
            public DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit_databases;
            public DevExpress.XtraEditors.TextEdit TextEdit_password;
            public DevExpress.XtraEditors.TextEdit TextEdit_server;
            public DevExpress.XtraEditors.TextEdit TextEdit_userID;

      }
}

namespace AdvCodeWizard.Forms
{
      partial class frm_JoinScriptscreator
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

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                  this.components = new System.ComponentModel.Container();
                  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_JoinScriptscreator));
                  this.label2 = new System.Windows.Forms.Label();
                  this.label1 = new System.Windows.Forms.Label();
                  this.label3 = new System.Windows.Forms.Label();
                  this.label4 = new System.Windows.Forms.Label();
                  this.ComboBoxEdit_parentTable = new DevExpress.XtraEditors.ComboBoxEdit();
                  this.ComboBoxEdit_primaryKey = new DevExpress.XtraEditors.ComboBoxEdit();
                  this.ComboBoxEdit_childTable = new DevExpress.XtraEditors.ComboBoxEdit();
                  this.ComboBoxEdit_foreignKey = new DevExpress.XtraEditors.ComboBoxEdit();
                  this.CheckEdit_CMP = new DevExpress.XtraEditors.CheckEdit();
                  this.CheckEdit_IsDeleted = new DevExpress.XtraEditors.CheckEdit();
                  this.CheckEdit_BRC = new DevExpress.XtraEditors.CheckEdit();
                  this.CheckEdit_linkToNext = new DevExpress.XtraEditors.CheckEdit();
                  this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
                  this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
                  this.gridControl1 = new DevExpress.XtraGrid.GridControl();
                  this.dtjoinScriptGeneratorBindingSource = new System.Windows.Forms.BindingSource(this.components);
                  this.dataSet_JoinScriptGenerator = new AdvCodeWizard.Forms.DataSet_JoinScriptGenerator();
                  this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
                  this.colParentTable = new DevExpress.XtraGrid.Columns.GridColumn();
                  this.colPrimaryKey = new DevExpress.XtraGrid.Columns.GridColumn();
                  this.colChildTable = new DevExpress.XtraGrid.Columns.GridColumn();
                  this.colForeignKey = new DevExpress.XtraGrid.Columns.GridColumn();
                  this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
                  this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
                  this.MemoEdit_code = new DevExpress.XtraEditors.MemoEdit();
                  this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
                  this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
                  this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_parentTable.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_primaryKey.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_childTable.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_foreignKey.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_CMP.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_IsDeleted.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_BRC.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_linkToNext.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
                  this.xtraTabControl2.SuspendLayout();
                  this.xtraTabPage2.SuspendLayout();
                  ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.dtjoinScriptGeneratorBindingSource)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.dataSet_JoinScriptGenerator)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
                  this.xtraTabPage1.SuspendLayout();
                  ((System.ComponentModel.ISupportInitialize)(this.MemoEdit_code.Properties)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // label2
                  // 
                  this.label2.AutoSize = true;
                  this.label2.Location = new System.Drawing.Point(13, 19);
                  this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                  this.label2.Name = "label2";
                  this.label2.Size = new System.Drawing.Size(98, 19);
                  this.label2.TabIndex = 129;
                  this.label2.Text = "Parent Table";
                  // 
                  // label1
                  // 
                  this.label1.AutoSize = true;
                  this.label1.Location = new System.Drawing.Point(586, 19);
                  this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                  this.label1.Name = "label1";
                  this.label1.Size = new System.Drawing.Size(94, 19);
                  this.label1.TabIndex = 130;
                  this.label1.Text = "Primary Key";
                  // 
                  // label3
                  // 
                  this.label3.AutoSize = true;
                  this.label3.Location = new System.Drawing.Point(14, 78);
                  this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                  this.label3.Name = "label3";
                  this.label3.Size = new System.Drawing.Size(89, 19);
                  this.label3.TabIndex = 131;
                  this.label3.Text = "Child Table";
                  // 
                  // label4
                  // 
                  this.label4.AutoSize = true;
                  this.label4.Location = new System.Drawing.Point(582, 78);
                  this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                  this.label4.Name = "label4";
                  this.label4.Size = new System.Drawing.Size(92, 19);
                  this.label4.TabIndex = 132;
                  this.label4.Text = "Foreign Key";
                  // 
                  // ComboBoxEdit_parentTable
                  // 
                  this.ComboBoxEdit_parentTable.Location = new System.Drawing.Point(17, 42);
                  this.ComboBoxEdit_parentTable.Margin = new System.Windows.Forms.Padding(4);
                  this.ComboBoxEdit_parentTable.Name = "ComboBoxEdit_parentTable";
                  this.ComboBoxEdit_parentTable.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.ComboBoxEdit_parentTable.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.ComboBoxEdit_parentTable.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.ComboBoxEdit_parentTable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                  this.ComboBoxEdit_parentTable.Properties.DropDownRows = 20;
                  this.ComboBoxEdit_parentTable.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                  this.ComboBoxEdit_parentTable.Size = new System.Drawing.Size(560, 28);
                  this.ComboBoxEdit_parentTable.TabIndex = 133;
                  this.ComboBoxEdit_parentTable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEdit_parentTable_SelectedIndexChanged);
                  // 
                  // ComboBoxEdit_primaryKey
                  // 
                  this.ComboBoxEdit_primaryKey.Location = new System.Drawing.Point(585, 42);
                  this.ComboBoxEdit_primaryKey.Margin = new System.Windows.Forms.Padding(4);
                  this.ComboBoxEdit_primaryKey.Name = "ComboBoxEdit_primaryKey";
                  this.ComboBoxEdit_primaryKey.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.ComboBoxEdit_primaryKey.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.ComboBoxEdit_primaryKey.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.ComboBoxEdit_primaryKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                  this.ComboBoxEdit_primaryKey.Properties.DropDownRows = 20;
                  this.ComboBoxEdit_primaryKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                  this.ComboBoxEdit_primaryKey.Size = new System.Drawing.Size(478, 28);
                  this.ComboBoxEdit_primaryKey.TabIndex = 134;
                  // 
                  // ComboBoxEdit_childTable
                  // 
                  this.ComboBoxEdit_childTable.Location = new System.Drawing.Point(17, 101);
                  this.ComboBoxEdit_childTable.Margin = new System.Windows.Forms.Padding(4);
                  this.ComboBoxEdit_childTable.Name = "ComboBoxEdit_childTable";
                  this.ComboBoxEdit_childTable.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.ComboBoxEdit_childTable.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.ComboBoxEdit_childTable.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.ComboBoxEdit_childTable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                  this.ComboBoxEdit_childTable.Properties.DropDownRows = 20;
                  this.ComboBoxEdit_childTable.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                  this.ComboBoxEdit_childTable.Size = new System.Drawing.Size(560, 28);
                  this.ComboBoxEdit_childTable.TabIndex = 135;
                  this.ComboBoxEdit_childTable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEdit_childTable_SelectedIndexChanged);
                  // 
                  // ComboBoxEdit_foreignKey
                  // 
                  this.ComboBoxEdit_foreignKey.Location = new System.Drawing.Point(585, 101);
                  this.ComboBoxEdit_foreignKey.Margin = new System.Windows.Forms.Padding(4);
                  this.ComboBoxEdit_foreignKey.Name = "ComboBoxEdit_foreignKey";
                  this.ComboBoxEdit_foreignKey.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.ComboBoxEdit_foreignKey.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.ComboBoxEdit_foreignKey.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.ComboBoxEdit_foreignKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                  this.ComboBoxEdit_foreignKey.Properties.DropDownRows = 20;
                  this.ComboBoxEdit_foreignKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                  this.ComboBoxEdit_foreignKey.Size = new System.Drawing.Size(478, 28);
                  this.ComboBoxEdit_foreignKey.TabIndex = 136;
                  // 
                  // CheckEdit_CMP
                  // 
                  this.CheckEdit_CMP.EditValue = true;
                  this.CheckEdit_CMP.Location = new System.Drawing.Point(14, 654);
                  this.CheckEdit_CMP.Margin = new System.Windows.Forms.Padding(4);
                  this.CheckEdit_CMP.Name = "CheckEdit_CMP";
                  this.CheckEdit_CMP.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.CheckEdit_CMP.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.CheckEdit_CMP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.CheckEdit_CMP.Properties.Caption = "CMP";
                  this.CheckEdit_CMP.Size = new System.Drawing.Size(106, 27);
                  this.CheckEdit_CMP.TabIndex = 137;
                  // 
                  // CheckEdit_IsDeleted
                  // 
                  this.CheckEdit_IsDeleted.EditValue = true;
                  this.CheckEdit_IsDeleted.Location = new System.Drawing.Point(242, 654);
                  this.CheckEdit_IsDeleted.Margin = new System.Windows.Forms.Padding(4);
                  this.CheckEdit_IsDeleted.Name = "CheckEdit_IsDeleted";
                  this.CheckEdit_IsDeleted.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.CheckEdit_IsDeleted.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.CheckEdit_IsDeleted.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.CheckEdit_IsDeleted.Properties.Caption = "IsDeleted";
                  this.CheckEdit_IsDeleted.Size = new System.Drawing.Size(106, 27);
                  this.CheckEdit_IsDeleted.TabIndex = 138;
                  // 
                  // CheckEdit_BRC
                  // 
                  this.CheckEdit_BRC.EditValue = true;
                  this.CheckEdit_BRC.Location = new System.Drawing.Point(128, 654);
                  this.CheckEdit_BRC.Margin = new System.Windows.Forms.Padding(4);
                  this.CheckEdit_BRC.Name = "CheckEdit_BRC";
                  this.CheckEdit_BRC.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.CheckEdit_BRC.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.CheckEdit_BRC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.CheckEdit_BRC.Properties.Caption = "BRC";
                  this.CheckEdit_BRC.Size = new System.Drawing.Size(106, 27);
                  this.CheckEdit_BRC.TabIndex = 139;
                  // 
                  // CheckEdit_linkToNext
                  // 
                  this.CheckEdit_linkToNext.EditValue = true;
                  this.CheckEdit_linkToNext.Location = new System.Drawing.Point(356, 654);
                  this.CheckEdit_linkToNext.Margin = new System.Windows.Forms.Padding(4);
                  this.CheckEdit_linkToNext.Name = "CheckEdit_linkToNext";
                  this.CheckEdit_linkToNext.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.CheckEdit_linkToNext.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.CheckEdit_linkToNext.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.CheckEdit_linkToNext.Properties.Caption = "Link TO Next";
                  this.CheckEdit_linkToNext.Size = new System.Drawing.Size(125, 27);
                  this.CheckEdit_linkToNext.TabIndex = 140;
                  // 
                  // xtraTabControl2
                  // 
                  this.xtraTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.xtraTabControl2.Location = new System.Drawing.Point(17, 138);
                  this.xtraTabControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                  this.xtraTabControl2.Name = "xtraTabControl2";
                  this.xtraTabControl2.SelectedTabPage = this.xtraTabPage2;
                  this.xtraTabControl2.Size = new System.Drawing.Size(1307, 507);
                  this.xtraTabControl2.TabIndex = 141;
                  this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage1});
                  // 
                  // xtraTabPage2
                  // 
                  this.xtraTabPage2.Controls.Add(this.gridControl1);
                  this.xtraTabPage2.Name = "xtraTabPage2";
                  this.xtraTabPage2.Size = new System.Drawing.Size(1301, 473);
                  this.xtraTabPage2.Text = "Names";
                  // 
                  // gridControl1
                  // 
                  this.gridControl1.DataSource = this.dtjoinScriptGeneratorBindingSource;
                  this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
                  this.gridControl1.Location = new System.Drawing.Point(0, 0);
                  this.gridControl1.MainView = this.gridView2;
                  this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
                  this.gridControl1.Name = "gridControl1";
                  this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
                  this.gridControl1.Size = new System.Drawing.Size(1301, 473);
                  this.gridControl1.TabIndex = 2;
                  this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
                  // 
                  // dtjoinScriptGeneratorBindingSource
                  // 
                  this.dtjoinScriptGeneratorBindingSource.DataMember = "dt_joinScriptGenerator";
                  this.dtjoinScriptGeneratorBindingSource.DataSource = this.dataSet_JoinScriptGenerator;
                  // 
                  // dataSet_JoinScriptGenerator
                  // 
                  this.dataSet_JoinScriptGenerator.DataSetName = "DataSet_JoinScriptGenerator";
                  this.dataSet_JoinScriptGenerator.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
                  // 
                  // gridView2
                  // 
                  this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
                  this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                  this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                  this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colParentTable,
            this.colPrimaryKey,
            this.colChildTable,
            this.colForeignKey});
                  this.gridView2.GridControl = this.gridControl1;
                  this.gridView2.Name = "gridView2";
                  this.gridView2.OptionsFind.ShowClearButton = false;
                  this.gridView2.OptionsFind.ShowCloseButton = false;
                  this.gridView2.OptionsFind.ShowFindButton = false;
                  this.gridView2.OptionsMenu.ShowGroupSummaryEditorItem = true;
                  this.gridView2.OptionsView.ShowAutoFilterRow = true;
                  this.gridView2.OptionsView.ShowColumnHeaders = false;
                  this.gridView2.OptionsView.ShowGroupPanel = false;
                  this.gridView2.OptionsView.ShowIndicator = false;
                  // 
                  // colParentTable
                  // 
                  this.colParentTable.FieldName = "ParentTable";
                  this.colParentTable.Name = "colParentTable";
                  this.colParentTable.Visible = true;
                  this.colParentTable.VisibleIndex = 0;
                  // 
                  // colPrimaryKey
                  // 
                  this.colPrimaryKey.FieldName = "PrimaryKey";
                  this.colPrimaryKey.Name = "colPrimaryKey";
                  this.colPrimaryKey.Visible = true;
                  this.colPrimaryKey.VisibleIndex = 1;
                  // 
                  // colChildTable
                  // 
                  this.colChildTable.FieldName = "ChildTable";
                  this.colChildTable.Name = "colChildTable";
                  this.colChildTable.Visible = true;
                  this.colChildTable.VisibleIndex = 2;
                  // 
                  // colForeignKey
                  // 
                  this.colForeignKey.FieldName = "ForeignKey";
                  this.colForeignKey.Name = "colForeignKey";
                  this.colForeignKey.Visible = true;
                  this.colForeignKey.VisibleIndex = 3;
                  // 
                  // repositoryItemButtonEdit1
                  // 
                  this.repositoryItemButtonEdit1.AutoHeight = false;
                  this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
                  this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
                  // 
                  // xtraTabPage1
                  // 
                  this.xtraTabPage1.Controls.Add(this.MemoEdit_code);
                  this.xtraTabPage1.Name = "xtraTabPage1";
                  this.xtraTabPage1.Size = new System.Drawing.Size(1301, 473);
                  this.xtraTabPage1.Text = "Code";
                  // 
                  // MemoEdit_code
                  // 
                  this.MemoEdit_code.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.MemoEdit_code.EditValue = ".";
                  this.MemoEdit_code.Location = new System.Drawing.Point(0, 0);
                  this.MemoEdit_code.Margin = new System.Windows.Forms.Padding(4);
                  this.MemoEdit_code.Name = "MemoEdit_code";
                  this.MemoEdit_code.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.MemoEdit_code.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.MemoEdit_code.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.MemoEdit_code.Size = new System.Drawing.Size(1301, 473);
                  this.MemoEdit_code.TabIndex = 123;
                  this.MemoEdit_code.UseOptimizedRendering = true;
                  // 
                  // simpleButton3
                  // 
                  this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
                  this.simpleButton3.Location = new System.Drawing.Point(1158, 46);
                  this.simpleButton3.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton3.Name = "simpleButton3";
                  this.simpleButton3.Size = new System.Drawing.Size(166, 82);
                  this.simpleButton3.TabIndex = 145;
                  this.simpleButton3.Text = "Generate";
                  this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
                  // 
                  // simpleButton4
                  // 
                  this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
                  this.simpleButton4.Location = new System.Drawing.Point(1068, 93);
                  this.simpleButton4.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton4.Name = "simpleButton4";
                  this.simpleButton4.Size = new System.Drawing.Size(82, 35);
                  this.simpleButton4.TabIndex = 144;
                  this.simpleButton4.Text = "Clear";
                  this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
                  // 
                  // simpleButton5
                  // 
                  this.simpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.Image")));
                  this.simpleButton5.Location = new System.Drawing.Point(1068, 46);
                  this.simpleButton5.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton5.Name = "simpleButton5";
                  this.simpleButton5.Size = new System.Drawing.Size(82, 35);
                  this.simpleButton5.TabIndex = 143;
                  this.simpleButton5.Text = "Add";
                  this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
                  // 
                  // frm_JoinScriptscreator
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(1444, 694);
                  this.Controls.Add(this.simpleButton3);
                  this.Controls.Add(this.simpleButton4);
                  this.Controls.Add(this.simpleButton5);
                  this.Controls.Add(this.xtraTabControl2);
                  this.Controls.Add(this.CheckEdit_linkToNext);
                  this.Controls.Add(this.CheckEdit_BRC);
                  this.Controls.Add(this.CheckEdit_IsDeleted);
                  this.Controls.Add(this.ComboBoxEdit_foreignKey);
                  this.Controls.Add(this.ComboBoxEdit_childTable);
                  this.Controls.Add(this.ComboBoxEdit_primaryKey);
                  this.Controls.Add(this.ComboBoxEdit_parentTable);
                  this.Controls.Add(this.label4);
                  this.Controls.Add(this.label3);
                  this.Controls.Add(this.label1);
                  this.Controls.Add(this.label2);
                  this.Controls.Add(this.CheckEdit_CMP);
                  this.Margin = new System.Windows.Forms.Padding(4);
                  this.Name = "frm_JoinScriptscreator";
                  this.Text = "Join Scripts Creator";
                  this.Load += new System.EventHandler(this.frm_JoinScriptscreator_Load);
                  ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_parentTable.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_primaryKey.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_childTable.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_foreignKey.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_CMP.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_IsDeleted.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_BRC.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_linkToNext.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
                  this.xtraTabControl2.ResumeLayout(false);
                  this.xtraTabPage2.ResumeLayout(false);
                  ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.dtjoinScriptGeneratorBindingSource)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.dataSet_JoinScriptGenerator)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
                  this.xtraTabPage1.ResumeLayout(false);
                  ((System.ComponentModel.ISupportInitialize)(this.MemoEdit_code.Properties)).EndInit();
                  this.ResumeLayout(false);
                  this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label4;
            private DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit_parentTable;
            private DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit_primaryKey;
            private DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit_childTable;
            private DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit_foreignKey;
            private DevExpress.XtraEditors.CheckEdit CheckEdit_CMP;
            private DevExpress.XtraEditors.CheckEdit CheckEdit_IsDeleted;
            private DevExpress.XtraEditors.CheckEdit CheckEdit_BRC;
            private DevExpress.XtraEditors.CheckEdit CheckEdit_linkToNext;
            private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
            private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
            private DevExpress.XtraGrid.GridControl gridControl1;
            private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
            private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
            private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
            private DevExpress.XtraEditors.MemoEdit MemoEdit_code;
            private System.Windows.Forms.BindingSource dtjoinScriptGeneratorBindingSource;
            private DataSet_JoinScriptGenerator dataSet_JoinScriptGenerator;
            private DevExpress.XtraGrid.Columns.GridColumn colParentTable;
            private DevExpress.XtraGrid.Columns.GridColumn colPrimaryKey;
            private DevExpress.XtraGrid.Columns.GridColumn colChildTable;
            private DevExpress.XtraGrid.Columns.GridColumn colForeignKey;
            private DevExpress.XtraEditors.SimpleButton simpleButton3;
            private DevExpress.XtraEditors.SimpleButton simpleButton4;
            private DevExpress.XtraEditors.SimpleButton simpleButton5;
      }
}
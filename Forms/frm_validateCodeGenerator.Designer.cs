namespace AdvCodeWizard.Forms
{
      partial class frm_validateCodeGenerator
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
                  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_validateCodeGenerator));
                  this.gridControl1 = new DevExpress.XtraGrid.GridControl();
                  this.dtvalidateCodeGeneratorBindingSource = new System.Windows.Forms.BindingSource(this.components);
                  this.dATASET_validateCodeGenerator = new AdvCodeWizard.Forms.DATASET_validateCodeGenerator();
                  this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
                  this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
                  this.colName2 = new DevExpress.XtraGrid.Columns.GridColumn();
                  this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
                  this.TextEdit_names = new DevExpress.XtraEditors.TextEdit();
                  this.CheckEdit_isGenericoError = new DevExpress.XtraEditors.CheckEdit();
                  this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
                  this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
                  this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
                  this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
                  this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
                  this.MemoEdit_code = new DevExpress.XtraEditors.MemoEdit();
                  this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
                  this.TextEdit_prefix = new DevExpress.XtraEditors.TextEdit();
                  this.label1 = new System.Windows.Forms.Label();
                  this.label2 = new System.Windows.Forms.Label();
                  this.ComboEdit_option = new DevExpress.XtraEditors.ComboBoxEdit();
                  this.TextEdit_primaryCOlumns = new DevExpress.XtraEditors.TextEdit();
                  this.label3 = new System.Windows.Forms.Label();
                  ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.dtvalidateCodeGeneratorBindingSource)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.dATASET_validateCodeGenerator)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_names.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_isGenericoError.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
                  this.xtraTabControl2.SuspendLayout();
                  this.xtraTabPage2.SuspendLayout();
                  this.xtraTabPage1.SuspendLayout();
                  ((System.ComponentModel.ISupportInitialize)(this.MemoEdit_code.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_prefix.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboEdit_option.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_primaryCOlumns.Properties)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // gridControl1
                  // 
                  this.gridControl1.DataSource = this.dtvalidateCodeGeneratorBindingSource;
                  this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
                  this.gridControl1.Location = new System.Drawing.Point(0, 0);
                  this.gridControl1.MainView = this.gridView2;
                  this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
                  this.gridControl1.Name = "gridControl1";
                  this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
                  this.gridControl1.Size = new System.Drawing.Size(1169, 643);
                  this.gridControl1.TabIndex = 2;
                  this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
                  this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
                  // 
                  // dtvalidateCodeGeneratorBindingSource
                  // 
                  this.dtvalidateCodeGeneratorBindingSource.DataMember = "dt_validateCodeGenerator";
                  this.dtvalidateCodeGeneratorBindingSource.DataSource = this.dATASET_validateCodeGenerator;
                  // 
                  // dATASET_validateCodeGenerator
                  // 
                  this.dATASET_validateCodeGenerator.DataSetName = "DATASET_validateCodeGenerator";
                  this.dATASET_validateCodeGenerator.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
                  // 
                  // gridView2
                  // 
                  this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
                  this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                  this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                  this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colName2});
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
                  // colName
                  // 
                  this.colName.FieldName = "Name";
                  this.colName.Name = "colName";
                  this.colName.Visible = true;
                  this.colName.VisibleIndex = 0;
                  // 
                  // colName2
                  // 
                  this.colName2.FieldName = "Name2";
                  this.colName2.Name = "colName2";
                  this.colName2.Visible = true;
                  this.colName2.VisibleIndex = 1;
                  // 
                  // repositoryItemButtonEdit1
                  // 
                  this.repositoryItemButtonEdit1.AutoHeight = false;
                  this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
                  this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
                  // 
                  // TextEdit_names
                  // 
                  this.TextEdit_names.EditValue = "";
                  this.TextEdit_names.Location = new System.Drawing.Point(8, 110);
                  this.TextEdit_names.Margin = new System.Windows.Forms.Padding(4);
                  this.TextEdit_names.Name = "TextEdit_names";
                  this.TextEdit_names.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.TextEdit_names.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.TextEdit_names.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.TextEdit_names.Size = new System.Drawing.Size(371, 28);
                  this.TextEdit_names.TabIndex = 122;
                  // 
                  // CheckEdit_isGenericoError
                  // 
                  this.CheckEdit_isGenericoError.Location = new System.Drawing.Point(1033, 13);
                  this.CheckEdit_isGenericoError.Margin = new System.Windows.Forms.Padding(4);
                  this.CheckEdit_isGenericoError.Name = "CheckEdit_isGenericoError";
                  this.CheckEdit_isGenericoError.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.CheckEdit_isGenericoError.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.CheckEdit_isGenericoError.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.CheckEdit_isGenericoError.Properties.Caption = "Is Generic Error";
                  this.CheckEdit_isGenericoError.Size = new System.Drawing.Size(144, 27);
                  this.CheckEdit_isGenericoError.TabIndex = 124;
                  this.CheckEdit_isGenericoError.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
                  // 
                  // simpleButton1
                  // 
                  this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
                  this.simpleButton1.Location = new System.Drawing.Point(921, 56);
                  this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton1.Name = "simpleButton1";
                  this.simpleButton1.Size = new System.Drawing.Size(82, 35);
                  this.simpleButton1.TabIndex = 125;
                  this.simpleButton1.Text = "Add";
                  this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
                  // 
                  // simpleButton2
                  // 
                  this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
                  this.simpleButton2.Location = new System.Drawing.Point(921, 103);
                  this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton2.Name = "simpleButton2";
                  this.simpleButton2.Size = new System.Drawing.Size(82, 35);
                  this.simpleButton2.TabIndex = 125;
                  this.simpleButton2.Text = "Clear";
                  this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
                  // 
                  // xtraTabControl2
                  // 
                  this.xtraTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.xtraTabControl2.Location = new System.Drawing.Point(8, 147);
                  this.xtraTabControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                  this.xtraTabControl2.Name = "xtraTabControl2";
                  this.xtraTabControl2.SelectedTabPage = this.xtraTabPage2;
                  this.xtraTabControl2.Size = new System.Drawing.Size(1175, 677);
                  this.xtraTabControl2.TabIndex = 126;
                  this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage1});
                  this.xtraTabControl2.Click += new System.EventHandler(this.xtraTabControl2_Click);
                  // 
                  // xtraTabPage2
                  // 
                  this.xtraTabPage2.Controls.Add(this.gridControl1);
                  this.xtraTabPage2.Name = "xtraTabPage2";
                  this.xtraTabPage2.Size = new System.Drawing.Size(1169, 643);
                  this.xtraTabPage2.Text = "Names";
                  this.xtraTabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage2_Paint);
                  // 
                  // xtraTabPage1
                  // 
                  this.xtraTabPage1.Controls.Add(this.MemoEdit_code);
                  this.xtraTabPage1.Name = "xtraTabPage1";
                  this.xtraTabPage1.Size = new System.Drawing.Size(1169, 643);
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
                  this.MemoEdit_code.Size = new System.Drawing.Size(1169, 643);
                  this.MemoEdit_code.TabIndex = 123;
                  this.MemoEdit_code.UseOptimizedRendering = true;
                  // 
                  // simpleButton3
                  // 
                  this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
                  this.simpleButton3.Location = new System.Drawing.Point(1011, 56);
                  this.simpleButton3.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton3.Name = "simpleButton3";
                  this.simpleButton3.Size = new System.Drawing.Size(166, 82);
                  this.simpleButton3.TabIndex = 125;
                  this.simpleButton3.Text = "Generate";
                  this.simpleButton3.Click += new System.EventHandler(this.simpleButton2_Click);
                  // 
                  // TextEdit_prefix
                  // 
                  this.TextEdit_prefix.EditValue = "";
                  this.TextEdit_prefix.Location = new System.Drawing.Point(9, 52);
                  this.TextEdit_prefix.Margin = new System.Windows.Forms.Padding(4);
                  this.TextEdit_prefix.Name = "TextEdit_prefix";
                  this.TextEdit_prefix.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.TextEdit_prefix.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.TextEdit_prefix.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.TextEdit_prefix.Size = new System.Drawing.Size(370, 28);
                  this.TextEdit_prefix.TabIndex = 122;
                  // 
                  // label1
                  // 
                  this.label1.AutoSize = true;
                  this.label1.Location = new System.Drawing.Point(10, 86);
                  this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                  this.label1.Name = "label1";
                  this.label1.Size = new System.Drawing.Size(59, 20);
                  this.label1.TabIndex = 127;
                  this.label1.Text = "Names";
                  this.label1.Click += new System.EventHandler(this.label1_Click);
                  // 
                  // label2
                  // 
                  this.label2.AutoSize = true;
                  this.label2.Location = new System.Drawing.Point(12, 28);
                  this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                  this.label2.Name = "label2";
                  this.label2.Size = new System.Drawing.Size(48, 20);
                  this.label2.TabIndex = 128;
                  this.label2.Text = "Prefix";
                  // 
                  // ComboEdit_option
                  // 
                  this.ComboEdit_option.EditValue = "";
                  this.ComboEdit_option.Location = new System.Drawing.Point(881, 13);
                  this.ComboEdit_option.Margin = new System.Windows.Forms.Padding(4);
                  this.ComboEdit_option.Name = "ComboEdit_option";
                  this.ComboEdit_option.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.ComboEdit_option.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.ComboEdit_option.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.ComboEdit_option.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                  this.ComboEdit_option.Properties.Items.AddRange(new object[] {
            "Validation",
            "Check Count"});
                  this.ComboEdit_option.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                  this.ComboEdit_option.Size = new System.Drawing.Size(144, 28);
                  this.ComboEdit_option.TabIndex = 124;
                  // 
                  // TextEdit_primaryCOlumns
                  // 
                  this.TextEdit_primaryCOlumns.EditValue = "";
                  this.TextEdit_primaryCOlumns.Location = new System.Drawing.Point(387, 52);
                  this.TextEdit_primaryCOlumns.Margin = new System.Windows.Forms.Padding(4);
                  this.TextEdit_primaryCOlumns.Name = "TextEdit_primaryCOlumns";
                  this.TextEdit_primaryCOlumns.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.TextEdit_primaryCOlumns.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.TextEdit_primaryCOlumns.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.TextEdit_primaryCOlumns.Size = new System.Drawing.Size(371, 28);
                  this.TextEdit_primaryCOlumns.TabIndex = 122;
                  // 
                  // label3
                  // 
                  this.label3.AutoSize = true;
                  this.label3.Location = new System.Drawing.Point(389, 28);
                  this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                  this.label3.Name = "label3";
                  this.label3.Size = new System.Drawing.Size(142, 20);
                  this.label3.TabIndex = 127;
                  this.label3.Text = "Primar Key Column";
                  this.label3.Click += new System.EventHandler(this.label1_Click);
                  // 
                  // frm_validateCodeGenerator
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.BackColor = System.Drawing.Color.White;
                  this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                  this.ClientSize = new System.Drawing.Size(1190, 832);
                  this.Controls.Add(this.label2);
                  this.Controls.Add(this.label3);
                  this.Controls.Add(this.label1);
                  this.Controls.Add(this.xtraTabControl2);
                  this.Controls.Add(this.simpleButton3);
                  this.Controls.Add(this.simpleButton2);
                  this.Controls.Add(this.simpleButton1);
                  this.Controls.Add(this.CheckEdit_isGenericoError);
                  this.Controls.Add(this.TextEdit_prefix);
                  this.Controls.Add(this.TextEdit_primaryCOlumns);
                  this.Controls.Add(this.TextEdit_names);
                  this.Controls.Add(this.ComboEdit_option);
                  this.MaximizeBox = false;
                  this.MinimizeBox = false;
                  this.Name = "frm_validateCodeGenerator";
                  this.ShowIcon = false;
                  this.ShowInTaskbar = false;
                  this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
                  this.Text = "Validate Code Generator";
                  this.Load += new System.EventHandler(this.frm_validateCodeGenerator_Load);
                  ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.dtvalidateCodeGeneratorBindingSource)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.dATASET_validateCodeGenerator)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_names.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_isGenericoError.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
                  this.xtraTabControl2.ResumeLayout(false);
                  this.xtraTabPage2.ResumeLayout(false);
                  this.xtraTabPage1.ResumeLayout(false);
                  ((System.ComponentModel.ISupportInitialize)(this.MemoEdit_code.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_prefix.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboEdit_option.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_primaryCOlumns.Properties)).EndInit();
                  this.ResumeLayout(false);
                  this.PerformLayout();

            }

            #endregion

            private DevExpress.XtraGrid.GridControl gridControl1;
            private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
            private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
            public DevExpress.XtraEditors.TextEdit TextEdit_names;
            private DevExpress.XtraEditors.CheckEdit CheckEdit_isGenericoError;
            private DevExpress.XtraEditors.SimpleButton simpleButton1;
            private DevExpress.XtraEditors.SimpleButton simpleButton2;
            private System.Windows.Forms.BindingSource dtvalidateCodeGeneratorBindingSource;
            private DATASET_validateCodeGenerator dATASET_validateCodeGenerator;
            private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
            private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
            private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
            private DevExpress.XtraEditors.MemoEdit MemoEdit_code;
            private DevExpress.XtraEditors.SimpleButton simpleButton3;
            private DevExpress.XtraGrid.Columns.GridColumn colName;
            public DevExpress.XtraEditors.TextEdit TextEdit_prefix;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private DevExpress.XtraEditors.ComboBoxEdit ComboEdit_option;
            private DevExpress.XtraGrid.Columns.GridColumn colName2;
            public DevExpress.XtraEditors.TextEdit TextEdit_primaryCOlumns;
            private System.Windows.Forms.Label label3;
      }
}
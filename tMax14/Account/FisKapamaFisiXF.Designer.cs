namespace tMax14.Account
{
    partial class FisKapamaFisiXF
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.avbKapamaKapaSelGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurYuvarlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avbKapamaKapaSelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKLN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKUL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKUL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.accountQueriesTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AccountQueriesTableAdapter();
            this.avbKapamaKapaSelTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AVB_KAPAMA_KAPA_SELTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avbKapamaKapaSelGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avbKapamaKapaSelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avbKapamaKapaSelGridControl
            // 
            this.avbKapamaKapaSelGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.avbKapamaKapaSelGridControl.DataSource = this.avbKapamaKapaSelBindingSource;
            this.avbKapamaKapaSelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avbKapamaKapaSelGridControl.Location = new System.Drawing.Point(0, 0);
            this.avbKapamaKapaSelGridControl.MainView = this.gridView2;
            this.avbKapamaKapaSelGridControl.Name = "avbKapamaKapaSelGridControl";
            this.avbKapamaKapaSelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.avbKapamaKapaSelGridControl.Size = new System.Drawing.Size(892, 367);
            this.avbKapamaKapaSelGridControl.TabIndex = 4;
            this.avbKapamaKapaSelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapaToolStripMenuItem,
            this.kurYuvarlaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // kapaToolStripMenuItem
            // 
            this.kapaToolStripMenuItem.Name = "kapaToolStripMenuItem";
            this.kapaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.kapaToolStripMenuItem.Text = "Kapa";
            this.kapaToolStripMenuItem.Click += new System.EventHandler(this.kapaToolStripMenuItem_Click);
            // 
            // kurYuvarlaToolStripMenuItem
            // 
            this.kurYuvarlaToolStripMenuItem.Name = "kurYuvarlaToolStripMenuItem";
            this.kurYuvarlaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.kurYuvarlaToolStripMenuItem.Text = "Kur Yuvarla";
            this.kurYuvarlaToolStripMenuItem.Click += new System.EventHandler(this.kurYuvarlaToolStripMenuItem_Click);
            // 
            // avbKapamaKapaSelBindingSource
            // 
            this.avbKapamaKapaSelBindingSource.DataMember = "AVB_KAPAMA_KAPA_SEL";
            this.avbKapamaKapaSelBindingSource.DataSource = this.accountDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVBID,
            this.colAVBID,
            this.colTRH,
            this.colAVDID,
            this.colHSPNO,
            this.colBA,
            this.colDDVZ,
            this.colAKUR,
            this.colDTUT,
            this.colDKLN,
            this.colDKUL,
            this.colREFTO,
            this.colREFID,
            this.colAKUL,
            this.colINFO,
            this.colTUR});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue1.Expression = "[AVBID] Is Null";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gridView2.FormatRules.Add(gridFormatRule1);
            this.gridView2.GridControl = this.avbKapamaKapaSelGridControl;
            this.gridView2.GroupCount = 1;
            this.gridView2.GroupFormat = "{1}";
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DKLN", this.colDKLN, "{0:n}", "DKLN"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DKUL", this.colDKUL, "{0:n}", "DKUL"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AKUL", this.colAKUL, "{0:n}")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDDVZ, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView2.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView2_ShowingEditor);
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            this.gridView2.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView2_ValidatingEditor);
            // 
            // colMAVBID
            // 
            this.colMAVBID.FieldName = "MAVBID";
            this.colMAVBID.Name = "colMAVBID";
            this.colMAVBID.OptionsColumn.AllowEdit = false;
            this.colMAVBID.OptionsColumn.AllowFocus = false;
            // 
            // colAVBID
            // 
            this.colAVBID.FieldName = "AVBID";
            this.colAVBID.Name = "colAVBID";
            this.colAVBID.OptionsColumn.AllowEdit = false;
            this.colAVBID.OptionsColumn.AllowFocus = false;
            // 
            // colTRH
            // 
            this.colTRH.Caption = "Tarih";
            this.colTRH.FieldName = "TRH";
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.AllowEdit = false;
            this.colTRH.OptionsColumn.AllowFocus = false;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 0;
            this.colTRH.Width = 100;
            // 
            // colAVDID
            // 
            this.colAVDID.FieldName = "AVDID";
            this.colAVDID.Name = "colAVDID";
            this.colAVDID.OptionsColumn.AllowEdit = false;
            this.colAVDID.OptionsColumn.AllowFocus = false;
            // 
            // colHSPNO
            // 
            this.colHSPNO.Caption = "HspNo";
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.OptionsColumn.AllowEdit = false;
            this.colHSPNO.OptionsColumn.AllowFocus = false;
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 1;
            this.colHSPNO.Width = 100;
            // 
            // colBA
            // 
            this.colBA.AppearanceCell.Options.UseTextOptions = true;
            this.colBA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBA.AppearanceHeader.Options.UseTextOptions = true;
            this.colBA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBA.FieldName = "BA";
            this.colBA.Name = "colBA";
            this.colBA.OptionsColumn.AllowEdit = false;
            this.colBA.OptionsColumn.AllowFocus = false;
            this.colBA.Visible = true;
            this.colBA.VisibleIndex = 2;
            this.colBA.Width = 31;
            // 
            // colDDVZ
            // 
            this.colDDVZ.Caption = "Dvz";
            this.colDDVZ.FieldName = "DDVZ";
            this.colDDVZ.Name = "colDDVZ";
            this.colDDVZ.OptionsColumn.AllowEdit = false;
            this.colDDVZ.OptionsColumn.AllowFocus = false;
            this.colDDVZ.Visible = true;
            this.colDDVZ.VisibleIndex = 6;
            // 
            // colAKUR
            // 
            this.colAKUR.AppearanceHeader.Options.UseTextOptions = true;
            this.colAKUR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAKUR.Caption = "Dvz Kur";
            this.colAKUR.FieldName = "AKUR";
            this.colAKUR.Name = "colAKUR";
            this.colAKUR.OptionsColumn.AllowEdit = false;
            this.colAKUR.OptionsColumn.AllowFocus = false;
            this.colAKUR.Visible = true;
            this.colAKUR.VisibleIndex = 6;
            this.colAKUR.Width = 76;
            // 
            // colDTUT
            // 
            this.colDTUT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDTUT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDTUT.Caption = "Dvz Tut";
            this.colDTUT.DisplayFormat.FormatString = "n";
            this.colDTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDTUT.FieldName = "DTUT";
            this.colDTUT.Name = "colDTUT";
            this.colDTUT.OptionsColumn.AllowEdit = false;
            this.colDTUT.OptionsColumn.AllowFocus = false;
            this.colDTUT.Visible = true;
            this.colDTUT.VisibleIndex = 3;
            this.colDTUT.Width = 113;
            // 
            // colDKLN
            // 
            this.colDKLN.AppearanceHeader.Options.UseTextOptions = true;
            this.colDKLN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDKLN.Caption = "Dvz Kln";
            this.colDKLN.DisplayFormat.FormatString = "n";
            this.colDKLN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDKLN.FieldName = "DKLN";
            this.colDKLN.Name = "colDKLN";
            this.colDKLN.OptionsColumn.AllowEdit = false;
            this.colDKLN.OptionsColumn.AllowFocus = false;
            this.colDKLN.Visible = true;
            this.colDKLN.VisibleIndex = 4;
            this.colDKLN.Width = 113;
            // 
            // colDKUL
            // 
            this.colDKUL.AppearanceHeader.Options.UseTextOptions = true;
            this.colDKUL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDKUL.Caption = "Dvz Kullan";
            this.colDKUL.DisplayFormat.FormatString = "n";
            this.colDKUL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDKUL.FieldName = "DKUL";
            this.colDKUL.Name = "colDKUL";
            this.colDKUL.Visible = true;
            this.colDKUL.VisibleIndex = 5;
            this.colDKUL.Width = 113;
            // 
            // colREFTO
            // 
            this.colREFTO.FieldName = "REFTO";
            this.colREFTO.Name = "colREFTO";
            this.colREFTO.OptionsColumn.AllowEdit = false;
            this.colREFTO.OptionsColumn.AllowFocus = false;
            // 
            // colREFID
            // 
            this.colREFID.FieldName = "REFID";
            this.colREFID.Name = "colREFID";
            this.colREFID.OptionsColumn.AllowEdit = false;
            this.colREFID.OptionsColumn.AllowFocus = false;
            // 
            // colAKUL
            // 
            this.colAKUL.AppearanceHeader.Options.UseTextOptions = true;
            this.colAKUL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAKUL.Caption = "TL Kullan";
            this.colAKUL.DisplayFormat.FormatString = "n";
            this.colAKUL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAKUL.FieldName = "AKUL";
            this.colAKUL.Name = "colAKUL";
            this.colAKUL.OptionsColumn.AllowEdit = false;
            this.colAKUL.OptionsColumn.AllowFocus = false;
            this.colAKUL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AKUL", "{0:n}")});
            this.colAKUL.Visible = true;
            this.colAKUL.VisibleIndex = 7;
            this.colAKUL.Width = 139;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Info";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 8;
            this.colINFO.Width = 89;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // avbKapamaKapaSelTableAdapter
            // 
            this.avbKapamaKapaSelTableAdapter.ClearBeforeFill = true;
            // 
            // FisKapamaFisiXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 367);
            this.Controls.Add(this.avbKapamaKapaSelGridControl);
            this.Name = "FisKapamaFisiXF";
            this.Text = "KapamaFişi Kapa";
            this.Load += new System.EventHandler(this.FisKapamaFisiXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avbKapamaKapaSelGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avbKapamaKapaSelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private DevExpress.XtraGrid.GridControl avbKapamaKapaSelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVBID;
        private DevExpress.XtraGrid.Columns.GridColumn colAVBID;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colAVDID;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colBA;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colAKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colDTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colDKLN;
        private DevExpress.XtraGrid.Columns.GridColumn colDKUL;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTO;
        private DevExpress.XtraGrid.Columns.GridColumn colREFID;
        private DevExpress.XtraGrid.Columns.GridColumn colAKUL;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurYuvarlaToolStripMenuItem;
        private AccountDataSetTableAdapters.AccountQueriesTableAdapter accountQueriesTableAdapter;
        private System.Windows.Forms.BindingSource avbKapamaKapaSelBindingSource;
        private AccountDataSetTableAdapters.AVB_KAPAMA_KAPA_SELTableAdapter avbKapamaKapaSelTableAdapter;
    }
}
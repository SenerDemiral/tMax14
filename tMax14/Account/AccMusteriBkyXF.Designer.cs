namespace tMax14.Account
{
    partial class AccMusteriBkyXF
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
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.accMusteriBkyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accMusteriBkyTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.ACC_MUSTERI_BKYTableAdapter();
            this.accMusteriBkyGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandLevel2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAVBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBRCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDALCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFFRTAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colREFOPIDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFOPSRVS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRBRCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRALCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEFUTAGS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEFUINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEFUTKPTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.fillSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.YIDimageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMusteriBkyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMusteriBkyGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YIDimageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accMusteriBkyBindingSource
            // 
            this.accMusteriBkyBindingSource.DataMember = "ACC_MUSTERI_BKY";
            this.accMusteriBkyBindingSource.DataSource = this.accountDataSet;
            // 
            // accMusteriBkyTableAdapter
            // 
            this.accMusteriBkyTableAdapter.ClearBeforeFill = true;
            // 
            // accMusteriBkyGridControl
            // 
            this.accMusteriBkyGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.accMusteriBkyGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.accMusteriBkyGridControl.DataSource = this.accMusteriBkyBindingSource;
            this.accMusteriBkyGridControl.Location = new System.Drawing.Point(12, 38);
            this.accMusteriBkyGridControl.MainView = this.gridView1;
            this.accMusteriBkyGridControl.Name = "accMusteriBkyGridControl";
            this.accMusteriBkyGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.accMusteriBkyGridControl.Size = new System.Drawing.Size(1199, 369);
            this.accMusteriBkyGridControl.TabIndex = 0;
            this.accMusteriBkyGridControl.ToolTipController = this.toolTipController1;
            this.accMusteriBkyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takipToolStripMenuItem,
            this.showPreviewToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exportToExcelToolStripMenuItem,
            this.layoutsToolStripMenuItem,
            this.faturaToolStripMenuItem,
            this.expandLevel2ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(176, 158);
            // 
            // takipToolStripMenuItem
            // 
            this.takipToolStripMenuItem.Name = "takipToolStripMenuItem";
            this.takipToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.takipToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.takipToolStripMenuItem.Text = "Takip";
            this.takipToolStripMenuItem.Click += new System.EventHandler(this.takipToolStripMenuItem_Click);
            // 
            // showPreviewToolStripMenuItem
            // 
            this.showPreviewToolStripMenuItem.Name = "showPreviewToolStripMenuItem";
            this.showPreviewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.showPreviewToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.showPreviewToolStripMenuItem.Text = "Show preview";
            this.showPreviewToolStripMenuItem.Click += new System.EventHandler(this.showPreviewToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.faturaToolStripMenuItem.Text = "-> Fatura";
            this.faturaToolStripMenuItem.Click += new System.EventHandler(this.faturaToolStripMenuItem_Click);
            // 
            // expandLevel2ToolStripMenuItem
            // 
            this.expandLevel2ToolStripMenuItem.Name = "expandLevel2ToolStripMenuItem";
            this.expandLevel2ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.expandLevel2ToolStripMenuItem.Text = "Expand Level 2";
            this.expandLevel2ToolStripMenuItem.Click += new System.EventHandler(this.expandLevel2ToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAVBID,
            this.colAVDID,
            this.colTUR,
            this.colHSPNO,
            this.colHSPAD,
            this.colBA,
            this.colDTUT,
            this.colDBKY,
            this.colDDVZ,
            this.colREFTO,
            this.colREFID,
            this.colTRH,
            this.colVDE,
            this.colFTRNO,
            this.colDBRCBKY,
            this.colDALCBKY,
            this.colREFFRTAD,
            this.colREFFRTID,
            this.colYID,
            this.colREFOPIDS,
            this.colREFOPSRVS,
            this.colRBKY,
            this.colRBRCBKY,
            this.colRALCBKY,
            this.colEFUTAGS,
            this.colEFUINFO,
            this.colREFINFO,
            this.colEFUTKPTRH});
            this.gridView1.GridControl = this.accMusteriBkyGridControl;
            this.gridView1.GroupCount = 3;
            this.gridView1.GroupFormat = "{0}: {1}      {2}";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "AVDID", null, "{0:n0} adet"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RBKY", null, "  Bky: {0:n}€"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RBRCBKY", null, "  BrçBky: {0:n}€"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RALCBKY", null, "  AlcBky: {0:n}€"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBKY", null, "    Bky: {0:B ###,###,###.##;A ###,###,###.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBRCBKY", null, "   BrçBky: {0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DALCBKY", null, "   AlcBky: {0:n}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridView1.OptionsView.BestFitMaxRowCount = 100;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colYID, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colHSPAD, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDDVZ, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView1_CustomDrawGroupRow);
            this.gridView1.CustomSummaryExists += new DevExpress.Data.CustomSummaryExistEventHandler(this.gridView1_CustomSummaryExists);
            this.gridView1.CalcPreviewText += new DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(this.gridView1_CalcPreviewText);
            this.gridView1.EndGrouping += new System.EventHandler(this.gridView1_EndGrouping);
            // 
            // colAVBID
            // 
            this.colAVBID.FieldName = "AVBID";
            this.colAVBID.Name = "colAVBID";
            this.colAVBID.OptionsColumn.FixedWidth = true;
            this.colAVBID.Width = 60;
            // 
            // colAVDID
            // 
            this.colAVDID.FieldName = "AVDID";
            this.colAVDID.Name = "colAVDID";
            this.colAVDID.OptionsColumn.FixedWidth = true;
            this.colAVDID.Width = 60;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.FieldName = "REFTURAD";
            this.colTUR.Name = "colTUR";
            this.colTUR.OptionsColumn.FixedWidth = true;
            this.colTUR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 1;
            this.colTUR.Width = 50;
            // 
            // colHSPNO
            // 
            this.colHSPNO.Caption = "HspNo";
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 0;
            this.colHSPNO.Width = 109;
            // 
            // colHSPAD
            // 
            this.colHSPAD.Caption = "HspAd";
            this.colHSPAD.FieldName = "HSPAD";
            this.colHSPAD.Name = "colHSPAD";
            this.colHSPAD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colHSPAD.Visible = true;
            this.colHSPAD.VisibleIndex = 4;
            this.colHSPAD.Width = 64;
            // 
            // colBA
            // 
            this.colBA.AppearanceCell.Options.UseTextOptions = true;
            this.colBA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBA.Caption = "B/A";
            this.colBA.FieldName = "BA";
            this.colBA.Name = "colBA";
            this.colBA.OptionsColumn.FixedWidth = true;
            this.colBA.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colBA.Visible = true;
            this.colBA.VisibleIndex = 2;
            this.colBA.Width = 26;
            // 
            // colDTUT
            // 
            this.colDTUT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDTUT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDTUT.Caption = "Tut Dvz";
            this.colDTUT.DisplayFormat.FormatString = "n";
            this.colDTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDTUT.FieldName = "DTUT";
            this.colDTUT.Name = "colDTUT";
            this.colDTUT.OptionsColumn.FixedWidth = true;
            this.colDTUT.Visible = true;
            this.colDTUT.VisibleIndex = 3;
            this.colDTUT.Width = 80;
            // 
            // colDBKY
            // 
            this.colDBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colDBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDBKY.Caption = "Bky Dvz";
            this.colDBKY.DisplayFormat.FormatString = "n";
            this.colDBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDBKY.FieldName = "DBKY";
            this.colDBKY.Name = "colDBKY";
            this.colDBKY.OptionsColumn.FixedWidth = true;
            this.colDBKY.Visible = true;
            this.colDBKY.VisibleIndex = 4;
            this.colDBKY.Width = 80;
            // 
            // colDDVZ
            // 
            this.colDDVZ.Caption = "Dvz";
            this.colDDVZ.FieldName = "DDVZ";
            this.colDDVZ.Name = "colDDVZ";
            this.colDDVZ.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDDVZ.Visible = true;
            this.colDDVZ.VisibleIndex = 6;
            this.colDDVZ.Width = 26;
            // 
            // colREFTO
            // 
            this.colREFTO.AppearanceCell.Options.UseTextOptions = true;
            this.colREFTO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFTO.Caption = "Ref";
            this.colREFTO.FieldName = "REFTO";
            this.colREFTO.Name = "colREFTO";
            this.colREFTO.OptionsColumn.FixedWidth = true;
            this.colREFTO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colREFTO.Visible = true;
            this.colREFTO.VisibleIndex = 8;
            this.colREFTO.Width = 26;
            // 
            // colREFID
            // 
            this.colREFID.AppearanceHeader.Options.UseTextOptions = true;
            this.colREFID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colREFID.Caption = "RefID";
            this.colREFID.FieldName = "REFID";
            this.colREFID.Name = "colREFID";
            this.colREFID.OptionsColumn.FixedWidth = true;
            this.colREFID.Visible = true;
            this.colREFID.VisibleIndex = 9;
            this.colREFID.Width = 60;
            // 
            // colTRH
            // 
            this.colTRH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRH.Caption = "Trh";
            this.colTRH.DisplayFormat.FormatString = "dd.MM.yy";
            this.colTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRH.FieldName = "REFTRH";
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.FixedWidth = true;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 11;
            this.colTRH.Width = 52;
            // 
            // colVDE
            // 
            this.colVDE.AppearanceHeader.Options.UseTextOptions = true;
            this.colVDE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVDE.Caption = "Vde";
            this.colVDE.DisplayFormat.FormatString = "dd.MM.yy";
            this.colVDE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colVDE.FieldName = "REFVDE";
            this.colVDE.Name = "colVDE";
            this.colVDE.OptionsColumn.FixedWidth = true;
            this.colVDE.Visible = true;
            this.colVDE.VisibleIndex = 12;
            this.colVDE.Width = 52;
            // 
            // colFTRNO
            // 
            this.colFTRNO.Caption = "FtrNo";
            this.colFTRNO.FieldName = "REFFTRNO";
            this.colFTRNO.Name = "colFTRNO";
            this.colFTRNO.OptionsColumn.FixedWidth = true;
            this.colFTRNO.Visible = true;
            this.colFTRNO.VisibleIndex = 13;
            this.colFTRNO.Width = 70;
            // 
            // colDBRCBKY
            // 
            this.colDBRCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colDBRCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDBRCBKY.Caption = "BrçBky Dvz";
            this.colDBRCBKY.DisplayFormat.FormatString = "n";
            this.colDBRCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDBRCBKY.FieldName = "DBRCBKY";
            this.colDBRCBKY.Name = "colDBRCBKY";
            this.colDBRCBKY.Width = 68;
            // 
            // colDALCBKY
            // 
            this.colDALCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colDALCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDALCBKY.Caption = "AlcBky Dvz";
            this.colDALCBKY.DisplayFormat.FormatString = "n";
            this.colDALCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDALCBKY.FieldName = "DALCBKY";
            this.colDALCBKY.Name = "colDALCBKY";
            this.colDALCBKY.Width = 68;
            // 
            // colREFFRTAD
            // 
            this.colREFFRTAD.Caption = "Firma";
            this.colREFFRTAD.FieldName = "REFFRTAD";
            this.colREFFRTAD.Name = "colREFFRTAD";
            this.colREFFRTAD.Width = 37;
            // 
            // colREFFRTID
            // 
            this.colREFFRTID.Caption = "FrtID";
            this.colREFFRTID.FieldName = "REFFRTID";
            this.colREFFRTID.Name = "colREFFRTID";
            this.colREFFRTID.Width = 37;
            // 
            // colYID
            // 
            this.colYID.Caption = "Yurt I/D";
            this.colYID.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colYID.FieldName = "YID";
            this.colYID.Name = "colYID";
            this.colYID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colYID.ToolTip = "Yurt İçi/Dışı";
            this.colYID.Visible = true;
            this.colYID.VisibleIndex = 1;
            this.colYID.Width = 37;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yurtİçi", "I", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("YurtDışı", "D", -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colREFOPIDS
            // 
            this.colREFOPIDS.Caption = "OpIDs";
            this.colREFOPIDS.FieldName = "REFOPIDS";
            this.colREFOPIDS.Name = "colREFOPIDS";
            this.colREFOPIDS.Width = 37;
            // 
            // colREFOPSRVS
            // 
            this.colREFOPSRVS.Caption = "OpSrvS";
            this.colREFOPSRVS.FieldName = "REFOPSRVS";
            this.colREFOPSRVS.Name = "colREFOPSRVS";
            this.colREFOPSRVS.ToolTip = "Ops TOB, ROT, MOT";
            this.colREFOPSRVS.Width = 51;
            // 
            // colRBKY
            // 
            this.colRBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colRBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colRBKY.Caption = "Bky €";
            this.colRBKY.DisplayFormat.FormatString = "n";
            this.colRBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRBKY.FieldName = "RBKY";
            this.colRBKY.Name = "colRBKY";
            this.colRBKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RBKY", "{0:n}")});
            this.colRBKY.Visible = true;
            this.colRBKY.VisibleIndex = 5;
            this.colRBKY.Width = 80;
            // 
            // colRBRCBKY
            // 
            this.colRBRCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colRBRCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colRBRCBKY.Caption = "BrçBky €";
            this.colRBRCBKY.DisplayFormat.FormatString = "n";
            this.colRBRCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRBRCBKY.FieldName = "RBRCBKY";
            this.colRBRCBKY.Name = "colRBRCBKY";
            this.colRBRCBKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RBRCBKY", "{0:n}")});
            this.colRBRCBKY.Visible = true;
            this.colRBRCBKY.VisibleIndex = 6;
            this.colRBRCBKY.Width = 80;
            // 
            // colRALCBKY
            // 
            this.colRALCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colRALCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colRALCBKY.Caption = "AlcBky €";
            this.colRALCBKY.DisplayFormat.FormatString = "n";
            this.colRALCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRALCBKY.FieldName = "RALCBKY";
            this.colRALCBKY.Name = "colRALCBKY";
            this.colRALCBKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RALCBKY", "{0:n}")});
            this.colRALCBKY.Visible = true;
            this.colRALCBKY.VisibleIndex = 7;
            this.colRALCBKY.Width = 80;
            // 
            // colEFUTAGS
            // 
            this.colEFUTAGS.Caption = "Takip TAGs";
            this.colEFUTAGS.FieldName = "EFUTAGS";
            this.colEFUTAGS.Name = "colEFUTAGS";
            this.colEFUTAGS.OptionsColumn.AllowEdit = false;
            this.colEFUTAGS.OptionsColumn.AllowFocus = false;
            this.colEFUTAGS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEFUTAGS.Visible = true;
            this.colEFUTAGS.VisibleIndex = 14;
            // 
            // colEFUINFO
            // 
            this.colEFUINFO.Caption = "Takip";
            this.colEFUINFO.FieldName = "EFUINFO";
            this.colEFUINFO.Name = "colEFUINFO";
            this.colEFUINFO.OptionsColumn.AllowEdit = false;
            this.colEFUINFO.OptionsColumn.AllowFocus = false;
            this.colEFUINFO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEFUINFO.Visible = true;
            this.colEFUINFO.VisibleIndex = 15;
            // 
            // colREFINFO
            // 
            this.colREFINFO.Caption = "RefInfo";
            this.colREFINFO.FieldName = "REFINFO";
            this.colREFINFO.Name = "colREFINFO";
            this.colREFINFO.Visible = true;
            this.colREFINFO.VisibleIndex = 10;
            // 
            // colEFUTKPTRH
            // 
            this.colEFUTKPTRH.Caption = "TakipTrh";
            this.colEFUTKPTRH.DisplayFormat.FormatString = "dd.MM.yy";
            this.colEFUTKPTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEFUTKPTRH.FieldName = "EFUTKPTRH";
            this.colEFUTKPTRH.Name = "colEFUTKPTRH";
            this.colEFUTKPTRH.OptionsColumn.AllowEdit = false;
            this.colEFUTKPTRH.Visible = true;
            this.colEFUTKPTRH.VisibleIndex = 16;
            // 
            // toolTipController1
            // 
            this.toolTipController1.AutoPopDelay = 60000;
            this.toolTipController1.CloseOnClick = DevExpress.Utils.DefaultBoolean.True;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.fillSimpleButton);
            this.layoutControl1.Controls.Add(this.YIDimageComboBoxEdit);
            this.layoutControl1.Controls.Add(this.accMusteriBkyGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1223, 419);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // fillSimpleButton
            // 
            this.fillSimpleButton.Location = new System.Drawing.Point(150, 12);
            this.fillSimpleButton.Name = "fillSimpleButton";
            this.fillSimpleButton.Size = new System.Drawing.Size(1061, 22);
            this.fillSimpleButton.StyleController = this.layoutControl1;
            this.fillSimpleButton.TabIndex = 4;
            this.fillSimpleButton.Text = "FILL";
            this.fillSimpleButton.Click += new System.EventHandler(this.fillSimpleButton_Click);
            // 
            // YIDimageComboBoxEdit
            // 
            this.YIDimageComboBoxEdit.EditValue = "I";
            this.YIDimageComboBoxEdit.Location = new System.Drawing.Point(95, 12);
            this.YIDimageComboBoxEdit.Name = "YIDimageComboBoxEdit";
            this.YIDimageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.YIDimageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yurtİçi", "I", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("YurtDışı", "D", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Hepsi", "-", -1)});
            this.YIDimageComboBoxEdit.Size = new System.Drawing.Size(51, 20);
            this.YIDimageComboBoxEdit.StyleController = this.layoutControl1;
            this.YIDimageComboBoxEdit.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1223, 419);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.accMusteriBkyGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1203, 373);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.YIDimageComboBoxEdit;
            this.layoutControlItem2.CustomizationFormText = "Yurt İç/Dış/Hepsi";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(138, 26);
            this.layoutControlItem2.Text = "Yurt İç/Dış/Hepsi";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.fillSimpleButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(138, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1065, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // AccMusteriBkyXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 419);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AccMusteriBkyXF";
            this.Text = "AccMusteriBkyXF";
            this.Load += new System.EventHandler(this.AccMusteriBkyXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMusteriBkyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMusteriBkyGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YIDimageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource accMusteriBkyBindingSource;
        private AccountDataSetTableAdapters.ACC_MUSTERI_BKYTableAdapter accMusteriBkyTableAdapter;
        private DevExpress.XtraGrid.GridControl accMusteriBkyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAVBID;
        private DevExpress.XtraGrid.Columns.GridColumn colAVDID;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPAD;
        private DevExpress.XtraGrid.Columns.GridColumn colBA;
        private DevExpress.XtraGrid.Columns.GridColumn colDTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colDBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTO;
        private DevExpress.XtraGrid.Columns.GridColumn colREFID;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colVDE;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRNO;
        private DevExpress.XtraGrid.Columns.GridColumn colDBRCBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colDALCBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colREFFRTAD;
        private DevExpress.XtraGrid.Columns.GridColumn colREFFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colYID;
        private DevExpress.XtraGrid.Columns.GridColumn colREFOPIDS;
        private DevExpress.XtraGrid.Columns.GridColumn colREFOPSRVS;
        private DevExpress.XtraGrid.Columns.GridColumn colRBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colRBRCBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colRALCBKY;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colEFUTAGS;
        private DevExpress.XtraGrid.Columns.GridColumn colEFUINFO;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showPreviewToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colREFINFO;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.ToolStripMenuItem takipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandLevel2ToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colEFUTKPTRH;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton fillSimpleButton;
        private DevExpress.XtraEditors.ImageComboBoxEdit YIDimageComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
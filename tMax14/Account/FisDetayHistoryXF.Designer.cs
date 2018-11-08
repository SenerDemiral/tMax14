namespace tMax14.Account
{
    partial class FisDetayHistoryXF
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.avdHstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avdHstTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AVD_HSTTableAdapter();
            this.avdHstGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avdHstGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAVDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SKLrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDALC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colABRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAALC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompArunTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompDrunTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFVDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SKLrepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.dvzKlnGridControl = new DevExpress.XtraGrid.GridControl();
            this.dvzKlnGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDvzKlnDvz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvzKlnTut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dvzKlnDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avdHstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avdHstGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avdHstGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKLrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKLrepositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvzKlnGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvzKlnGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.dvzKlnDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // colBA
            // 
            this.colBA.AppearanceCell.Options.UseTextOptions = true;
            this.colBA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBA.AppearanceHeader.Options.UseTextOptions = true;
            this.colBA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBA.Caption = "B/A";
            this.colBA.FieldName = "BA";
            this.colBA.Name = "colBA";
            this.colBA.OptionsColumn.FixedWidth = true;
            this.colBA.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colBA.Width = 36;
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avdHstBindingSource
            // 
            this.avdHstBindingSource.DataMember = "AVD_HST";
            this.avdHstBindingSource.DataSource = this.accountDataSet;
            this.avdHstBindingSource.Sort = "REFVDE, TRH";
            // 
            // avdHstTableAdapter
            // 
            this.avdHstTableAdapter.ClearBeforeFill = true;
            // 
            // avdHstGridControl
            // 
            this.avdHstGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.avdHstGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.avdHstGridControl.DataSource = this.avdHstBindingSource;
            this.avdHstGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avdHstGridControl.Location = new System.Drawing.Point(19, 0);
            this.avdHstGridControl.MainView = this.avdHstGridView;
            this.avdHstGridControl.Name = "avdHstGridControl";
            this.avdHstGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.SKLrepositoryItemCheckEdit,
            this.SKLrepositoryItemImageComboBox});
            this.avdHstGridControl.Size = new System.Drawing.Size(1107, 393);
            this.avdHstGridControl.TabIndex = 2;
            this.avdHstGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.avdHstGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPreviewToolStripMenuItem,
            this.fisToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(142, 70);
            // 
            // showPreviewToolStripMenuItem
            // 
            this.showPreviewToolStripMenuItem.Name = "showPreviewToolStripMenuItem";
            this.showPreviewToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showPreviewToolStripMenuItem.Text = "Show preview";
            this.showPreviewToolStripMenuItem.Click += new System.EventHandler(this.showPreviewToolStripMenuItem_Click);
            // 
            // fisToolStripMenuItem
            // 
            this.fisToolStripMenuItem.Name = "fisToolStripMenuItem";
            this.fisToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fisToolStripMenuItem.Text = "Fiş";
            this.fisToolStripMenuItem.Click += new System.EventHandler(this.fisToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // avdHstGridView
            // 
            this.avdHstGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAVDID,
            this.colAVBID,
            this.colSKL,
            this.colTUR,
            this.colTRH,
            this.colHSPNO,
            this.colBA,
            this.colDTUT,
            this.colDDVZ,
            this.colDKUR,
            this.colDBRC,
            this.colDALC,
            this.colDBKY,
            this.colBKUR,
            this.colAKUR,
            this.colABRC,
            this.colAALC,
            this.colATUT,
            this.colREFTO,
            this.colREFID,
            this.colCompArunTotal,
            this.colACIKLAMA,
            this.colCompDrunTotal,
            this.colREFTRH,
            this.colREFVDE,
            this.colREFTUT,
            this.colREFDVZ,
            this.colREFKUR});
            this.avdHstGridView.CustomizationFormBounds = new System.Drawing.Rectangle(964, 344, 208, 168);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colBA;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "A";
            this.avdHstGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.avdHstGridView.GridControl = this.avdHstGridControl;
            this.avdHstGridView.GroupCount = 1;
            this.avdHstGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "AVDID", this.colAVDID, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABRC", this.colABRC, "{0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AALC", this.colAALC, "{0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBRC", this.colDBRC, "{0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DALC", this.colDALC, "{0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBKY", this.colDBKY, "{0:n}")});
            this.avdHstGridView.Name = "avdHstGridView";
            this.avdHstGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.avdHstGridView.OptionsBehavior.Editable = false;
            this.avdHstGridView.OptionsFind.SearchInPreview = true;
            this.avdHstGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.avdHstGridView.OptionsView.AutoCalcPreviewLineCount = true;
            this.avdHstGridView.OptionsView.BestFitMaxRowCount = 50;
            this.avdHstGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.avdHstGridView.OptionsView.ShowFooter = true;
            this.avdHstGridView.PreviewFieldName = "ACIKLAMA";
            this.avdHstGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDDVZ, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.avdHstGridView.CustomSummaryExists += new DevExpress.Data.CustomSummaryExistEventHandler(this.avdHstGridView_CustomSummaryExists);
            this.avdHstGridView.EndGrouping += new System.EventHandler(this.avdHstGridView_EndGrouping);
            this.avdHstGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.avdHstGridView_CustomColumnDisplayText);
            // 
            // colAVDID
            // 
            this.colAVDID.AppearanceHeader.Options.UseTextOptions = true;
            this.colAVDID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAVDID.Caption = "AVDid";
            this.colAVDID.DisplayFormat.FormatString = "n0";
            this.colAVDID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAVDID.FieldName = "AVDID";
            this.colAVDID.Name = "colAVDID";
            this.colAVDID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colAVDID.Visible = true;
            this.colAVDID.VisibleIndex = 14;
            this.colAVDID.Width = 74;
            // 
            // colAVBID
            // 
            this.colAVBID.AppearanceHeader.Options.UseTextOptions = true;
            this.colAVBID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAVBID.Caption = "AVBid";
            this.colAVBID.DisplayFormat.FormatString = "N0";
            this.colAVBID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAVBID.FieldName = "AVBID";
            this.colAVBID.Name = "colAVBID";
            this.colAVBID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colAVBID.Visible = true;
            this.colAVBID.VisibleIndex = 13;
            this.colAVBID.Width = 60;
            // 
            // colSKL
            // 
            this.colSKL.AppearanceHeader.Options.UseTextOptions = true;
            this.colSKL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSKL.Caption = "Şkl";
            this.colSKL.ColumnEdit = this.SKLrepositoryItemImageComboBox;
            this.colSKL.FieldName = "SKL";
            this.colSKL.Name = "colSKL";
            this.colSKL.OptionsColumn.FixedWidth = true;
            this.colSKL.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSKL.ToolTip = "Şkl";
            this.colSKL.Visible = true;
            this.colSKL.VisibleIndex = 1;
            this.colSKL.Width = 47;
            // 
            // SKLrepositoryItemImageComboBox
            // 
            this.SKLrepositoryItemImageComboBox.AutoHeight = false;
            this.SKLrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SKLrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Asl", "A", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kpm", "K", -1)});
            this.SKLrepositoryItemImageComboBox.Name = "SKLrepositoryItemImageComboBox";
            // 
            // colTUR
            // 
            this.colTUR.AppearanceHeader.Options.UseTextOptions = true;
            this.colTUR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTUR.Caption = "Tür";
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.OptionsColumn.FixedWidth = true;
            this.colTUR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 2;
            this.colTUR.Width = 50;
            // 
            // colTRH
            // 
            this.colTRH.AppearanceCell.Options.UseTextOptions = true;
            this.colTRH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRH.Caption = "Trh";
            this.colTRH.DisplayFormat.FormatString = "dd.MM.yy";
            this.colTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRH.FieldName = "TRH";
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.FixedWidth = true;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 3;
            this.colTRH.Width = 52;
            // 
            // colHSPNO
            // 
            this.colHSPNO.Caption = "HspNo";
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 0;
            this.colHSPNO.Width = 219;
            // 
            // colDTUT
            // 
            this.colDTUT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDTUT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDTUT.Caption = "Tut Dvz";
            this.colDTUT.DisplayFormat.FormatString = "#,0.00;#,0.00; ";
            this.colDTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDTUT.FieldName = "DTUT";
            this.colDTUT.Name = "colDTUT";
            this.colDTUT.Width = 60;
            // 
            // colDDVZ
            // 
            this.colDDVZ.AppearanceCell.Options.UseTextOptions = true;
            this.colDDVZ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDDVZ.Caption = "Dvz";
            this.colDDVZ.FieldName = "DDVZ";
            this.colDDVZ.Name = "colDDVZ";
            this.colDDVZ.OptionsColumn.FixedWidth = true;
            this.colDDVZ.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDDVZ.Visible = true;
            this.colDDVZ.VisibleIndex = 8;
            this.colDDVZ.Width = 40;
            // 
            // colDKUR
            // 
            this.colDKUR.Caption = "Kur Dvz";
            this.colDKUR.FieldName = "DKUR";
            this.colDKUR.Name = "colDKUR";
            // 
            // colDBRC
            // 
            this.colDBRC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDBRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDBRC.Caption = "Brç Dvz";
            this.colDBRC.DisplayFormat.FormatString = "n";
            this.colDBRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDBRC.FieldName = "DBRC";
            this.colDBRC.Name = "colDBRC";
            this.colDBRC.Visible = true;
            this.colDBRC.VisibleIndex = 5;
            this.colDBRC.Width = 80;
            // 
            // colDALC
            // 
            this.colDALC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDALC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDALC.Caption = "Alc Dvz";
            this.colDALC.DisplayFormat.FormatString = "n";
            this.colDALC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDALC.FieldName = "DALC";
            this.colDALC.Name = "colDALC";
            this.colDALC.Visible = true;
            this.colDALC.VisibleIndex = 6;
            this.colDALC.Width = 80;
            // 
            // colDBKY
            // 
            this.colDBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colDBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDBKY.Caption = "Kln Dvz";
            this.colDBKY.DisplayFormat.FormatString = "n";
            this.colDBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDBKY.FieldName = "DBKY";
            this.colDBKY.Name = "colDBKY";
            this.colDBKY.ToolTip = "Hesap Kapama sonrası Kalan";
            this.colDBKY.Visible = true;
            this.colDBKY.VisibleIndex = 7;
            this.colDBKY.Width = 74;
            // 
            // colBKUR
            // 
            this.colBKUR.Caption = "Kur Dvz";
            this.colBKUR.FieldName = "BKUR";
            this.colBKUR.Name = "colBKUR";
            // 
            // colAKUR
            // 
            this.colAKUR.Caption = "rKur";
            this.colAKUR.FieldName = "AKUR";
            this.colAKUR.Name = "colAKUR";
            // 
            // colABRC
            // 
            this.colABRC.AppearanceHeader.Options.UseTextOptions = true;
            this.colABRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colABRC.Caption = "Brç TL";
            this.colABRC.DisplayFormat.FormatString = "#,0.00;#,0.00; ";
            this.colABRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colABRC.FieldName = "ABRC";
            this.colABRC.Name = "colABRC";
            this.colABRC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABRC", "{0:n2}")});
            this.colABRC.Visible = true;
            this.colABRC.VisibleIndex = 8;
            this.colABRC.Width = 54;
            // 
            // colAALC
            // 
            this.colAALC.AppearanceHeader.Options.UseTextOptions = true;
            this.colAALC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAALC.Caption = "Alc TL";
            this.colAALC.DisplayFormat.FormatString = "#,0.00;#,0.00; ";
            this.colAALC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAALC.FieldName = "AALC";
            this.colAALC.Name = "colAALC";
            this.colAALC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AALC", "{0:n2}")});
            this.colAALC.Visible = true;
            this.colAALC.VisibleIndex = 9;
            this.colAALC.Width = 54;
            // 
            // colATUT
            // 
            this.colATUT.AppearanceHeader.Options.UseTextOptions = true;
            this.colATUT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colATUT.Caption = "Tut TL";
            this.colATUT.FieldName = "ATUT";
            this.colATUT.Name = "colATUT";
            this.colATUT.OptionsColumn.FixedWidth = true;
            this.colATUT.Width = 100;
            // 
            // colREFTO
            // 
            this.colREFTO.FieldName = "REFTO";
            this.colREFTO.Name = "colREFTO";
            // 
            // colREFID
            // 
            this.colREFID.AppearanceHeader.Options.UseTextOptions = true;
            this.colREFID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFID.Caption = "RefID";
            this.colREFID.FieldName = "REFID";
            this.colREFID.Name = "colREFID";
            this.colREFID.OptionsColumn.FixedWidth = true;
            this.colREFID.Visible = true;
            this.colREFID.VisibleIndex = 11;
            this.colREFID.Width = 62;
            // 
            // colCompArunTotal
            // 
            this.colCompArunTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompArunTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompArunTotal.Caption = "CumBky RTL";
            this.colCompArunTotal.FieldName = "aRunTotal";
            this.colCompArunTotal.Name = "colCompArunTotal";
            this.colCompArunTotal.OptionsColumn.AllowEdit = false;
            this.colCompArunTotal.OptionsColumn.AllowFocus = false;
            this.colCompArunTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colCompArunTotal.Visible = true;
            this.colCompArunTotal.VisibleIndex = 10;
            this.colCompArunTotal.Width = 69;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.Caption = "Açıklama";
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 12;
            this.colACIKLAMA.Width = 151;
            // 
            // colCompDrunTotal
            // 
            this.colCompDrunTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompDrunTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompDrunTotal.Caption = "CumBky Dvz";
            this.colCompDrunTotal.FieldName = "dRunTotal";
            this.colCompDrunTotal.Name = "colCompDrunTotal";
            this.colCompDrunTotal.OptionsColumn.AllowEdit = false;
            this.colCompDrunTotal.OptionsColumn.AllowFocus = false;
            this.colCompDrunTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colCompDrunTotal.Width = 68;
            // 
            // colREFTRH
            // 
            this.colREFTRH.Caption = "RefTrh";
            this.colREFTRH.DisplayFormat.FormatString = "dd.MM.yy";
            this.colREFTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colREFTRH.FieldName = "REFTRH";
            this.colREFTRH.Name = "colREFTRH";
            this.colREFTRH.OptionsColumn.FixedWidth = true;
            this.colREFTRH.Width = 52;
            // 
            // colREFVDE
            // 
            this.colREFVDE.AppearanceCell.Options.UseTextOptions = true;
            this.colREFVDE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFVDE.AppearanceHeader.Options.UseTextOptions = true;
            this.colREFVDE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFVDE.Caption = "Vde";
            this.colREFVDE.DisplayFormat.FormatString = "dd.MM.yy";
            this.colREFVDE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colREFVDE.FieldName = "REFVDE";
            this.colREFVDE.Name = "colREFVDE";
            this.colREFVDE.OptionsColumn.FixedWidth = true;
            this.colREFVDE.ToolTip = "RefVde";
            this.colREFVDE.Visible = true;
            this.colREFVDE.VisibleIndex = 4;
            this.colREFVDE.Width = 52;
            // 
            // colREFTUT
            // 
            this.colREFTUT.Caption = "RefTut";
            this.colREFTUT.FieldName = "REFTUT";
            this.colREFTUT.Name = "colREFTUT";
            this.colREFTUT.Width = 45;
            // 
            // colREFDVZ
            // 
            this.colREFDVZ.Caption = "RefDvz";
            this.colREFDVZ.FieldName = "REFDVZ";
            this.colREFDVZ.Name = "colREFDVZ";
            this.colREFDVZ.Width = 45;
            // 
            // colREFKUR
            // 
            this.colREFKUR.Caption = "RefKur";
            this.colREFKUR.FieldName = "REFKUR";
            this.colREFKUR.Name = "colREFKUR";
            this.colREFKUR.Width = 45;
            // 
            // SKLrepositoryItemCheckEdit
            // 
            this.SKLrepositoryItemCheckEdit.AutoHeight = false;
            this.SKLrepositoryItemCheckEdit.Caption = "Check";
            this.SKLrepositoryItemCheckEdit.DisplayValueChecked = "Asıl";
            this.SKLrepositoryItemCheckEdit.DisplayValueGrayed = "Hayır";
            this.SKLrepositoryItemCheckEdit.DisplayValueUnchecked = "Kapama";
            this.SKLrepositoryItemCheckEdit.Name = "SKLrepositoryItemCheckEdit";
            this.SKLrepositoryItemCheckEdit.ValueChecked = "A";
            this.SKLrepositoryItemCheckEdit.ValueUnchecked = "K";
            // 
            // dvzKlnGridControl
            // 
            this.dvzKlnGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvzKlnGridControl.Location = new System.Drawing.Point(0, 0);
            this.dvzKlnGridControl.MainView = this.dvzKlnGridView;
            this.dvzKlnGridControl.Name = "dvzKlnGridControl";
            this.dvzKlnGridControl.Size = new System.Drawing.Size(142, 366);
            this.dvzKlnGridControl.TabIndex = 3;
            this.dvzKlnGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dvzKlnGridView});
            // 
            // dvzKlnGridView
            // 
            this.dvzKlnGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDvzKlnDvz,
            this.colDvzKlnTut});
            this.dvzKlnGridView.GridControl = this.dvzKlnGridControl;
            this.dvzKlnGridView.Name = "dvzKlnGridView";
            this.dvzKlnGridView.OptionsBehavior.Editable = false;
            this.dvzKlnGridView.OptionsView.ShowGroupPanel = false;
            this.dvzKlnGridView.OptionsView.ShowIndicator = false;
            this.dvzKlnGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dvzKlnGridView_CustomColumnDisplayText);
            // 
            // colDvzKlnDvz
            // 
            this.colDvzKlnDvz.AppearanceHeader.Options.UseTextOptions = true;
            this.colDvzKlnDvz.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDvzKlnDvz.Caption = "Dvz";
            this.colDvzKlnDvz.FieldName = "Key";
            this.colDvzKlnDvz.Name = "colDvzKlnDvz";
            this.colDvzKlnDvz.OptionsColumn.FixedWidth = true;
            this.colDvzKlnDvz.Visible = true;
            this.colDvzKlnDvz.VisibleIndex = 0;
            this.colDvzKlnDvz.Width = 40;
            // 
            // colDvzKlnTut
            // 
            this.colDvzKlnTut.AppearanceHeader.Options.UseTextOptions = true;
            this.colDvzKlnTut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDvzKlnTut.Caption = "Tut";
            this.colDvzKlnTut.DisplayFormat.FormatString = "n";
            this.colDvzKlnTut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDvzKlnTut.FieldName = "Value";
            this.colDvzKlnTut.Name = "colDvzKlnTut";
            this.colDvzKlnTut.Visible = true;
            this.colDvzKlnTut.VisibleIndex = 1;
            this.colDvzKlnTut.Width = 161;
            // 
            // dockManager
            // 
            this.dockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.dockManager.Form = this;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.hideContainerLeft.Controls.Add(this.dvzKlnDockPanel);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 393);
            // 
            // dvzKlnDockPanel
            // 
            this.dvzKlnDockPanel.Controls.Add(this.dockPanel1_Container);
            this.dvzKlnDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dvzKlnDockPanel.ID = new System.Guid("acbe9083-5924-4622-82b0-bcd9d123e151");
            this.dvzKlnDockPanel.Location = new System.Drawing.Point(0, 0);
            this.dvzKlnDockPanel.Name = "dvzKlnDockPanel";
            this.dvzKlnDockPanel.OriginalSize = new System.Drawing.Size(150, 200);
            this.dvzKlnDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dvzKlnDockPanel.SavedIndex = 0;
            this.dvzKlnDockPanel.Size = new System.Drawing.Size(150, 393);
            this.dvzKlnDockPanel.Text = "Döviz Kalanları";
            this.dvzKlnDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.dvzKlnGridControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(142, 366);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // FisDetayHistoryXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.avdHstGridControl);
            this.Controls.Add(this.hideContainerLeft);
            this.Name = "FisDetayHistoryXF";
            this.Size = new System.Drawing.Size(1126, 393);
            this.Load += new System.EventHandler(this.FisDetayHistoryXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avdHstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avdHstGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avdHstGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKLrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKLrepositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvzKlnGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvzKlnGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.dvzKlnDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource avdHstBindingSource;
        private AccountDataSetTableAdapters.AVD_HSTTableAdapter avdHstTableAdapter;
        private DevExpress.XtraGrid.GridControl avdHstGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView avdHstGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAVDID;
        private DevExpress.XtraGrid.Columns.GridColumn colAVBID;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colBA;
        private DevExpress.XtraGrid.Columns.GridColumn colDTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colBKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colDBRC;
        private DevExpress.XtraGrid.Columns.GridColumn colDALC;
        private DevExpress.XtraGrid.Columns.GridColumn colAKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colABRC;
        private DevExpress.XtraGrid.Columns.GridColumn colAALC;
        private DevExpress.XtraGrid.Columns.GridColumn colATUT;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTO;
        private DevExpress.XtraGrid.Columns.GridColumn colREFID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompArunTotal;
        private DevExpress.XtraGrid.GridControl dvzKlnGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView dvzKlnGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDvzKlnDvz;
        private DevExpress.XtraGrid.Columns.GridColumn colDvzKlnTut;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dvzKlnDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private System.Windows.Forms.ToolStripMenuItem showPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colCompDrunTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colREFVDE;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colREFDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colREFKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colSKL;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit SKLrepositoryItemCheckEdit;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colDBKY;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox SKLrepositoryItemImageComboBox;
    }
}
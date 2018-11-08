namespace tMax14.Depo
{
    partial class dpgAktifUC
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.dpcGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDPCIDc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDPGIDc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCIKMIKc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCIKTAGc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCIKTRHc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dpgaGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.firmaUrunDetaylariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dpgaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoDataSet = new tMax14.Depo.DepoDataSet();
            this.dpgaGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDPGID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIRTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTANIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIRTAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colGTPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIRMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKLNMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIRSGRDGR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKlnSgrDgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBITTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTBLB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtRepositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colXTTXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.dpgaTableAdapter = new tMax14.Depo.DepoDataSetTableAdapters.DPGATableAdapter();
            this.tableAdapterManager = new tMax14.Depo.DepoDataSetTableAdapters.TableAdapterManager();
            this.dpcTableAdapter = new tMax14.Depo.DepoDataSetTableAdapters.DPCATableAdapter();
            this.depoQueriesTableAdapter = new tMax14.Depo.DepoDataSetTableAdapters.DepoQueriesTableAdapter();
            this.dpcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.xtDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dpcGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpgaGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpgaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpgaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtRepositoryItemMemoExEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.xtDockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpcGridView
            // 
            this.dpcGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDPCIDc,
            this.colDPGIDc,
            this.colCIKMIKc,
            this.colCIKTAGc,
            this.colCIKTRHc});
            this.dpcGridView.GridControl = this.dpgaGridControl;
            this.dpcGridView.Name = "dpcGridView";
            this.dpcGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.dpcGridView.OptionsView.ShowGroupPanel = false;
            this.dpcGridView.ViewCaption = "Çıkışlar";
            this.dpcGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.dpcGridView_InitNewRow);
            this.dpcGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.dpcGridView_RowUpdated);
            // 
            // colDPCIDc
            // 
            this.colDPCIDc.DisplayFormat.FormatString = "n0";
            this.colDPCIDc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDPCIDc.FieldName = "DPCID";
            this.colDPCIDc.Name = "colDPCIDc";
            this.colDPCIDc.OptionsColumn.AllowEdit = false;
            this.colDPCIDc.OptionsColumn.AllowFocus = false;
            this.colDPCIDc.OptionsColumn.FixedWidth = true;
            this.colDPCIDc.Visible = true;
            this.colDPCIDc.VisibleIndex = 0;
            this.colDPCIDc.Width = 60;
            // 
            // colDPGIDc
            // 
            this.colDPGIDc.FieldName = "DPGID";
            this.colDPGIDc.Name = "colDPGIDc";
            this.colDPGIDc.OptionsColumn.AllowEdit = false;
            this.colDPGIDc.OptionsColumn.AllowFocus = false;
            this.colDPGIDc.OptionsColumn.FixedWidth = true;
            this.colDPGIDc.Width = 60;
            // 
            // colCIKMIKc
            // 
            this.colCIKMIKc.Caption = "ÇıkMik";
            this.colCIKMIKc.FieldName = "CIKMIK";
            this.colCIKMIKc.Name = "colCIKMIKc";
            this.colCIKMIKc.OptionsColumn.FixedWidth = true;
            this.colCIKMIKc.Visible = true;
            this.colCIKMIKc.VisibleIndex = 2;
            this.colCIKMIKc.Width = 100;
            // 
            // colCIKTAGc
            // 
            this.colCIKTAGc.Caption = "ÇıkTAG";
            this.colCIKTAGc.FieldName = "CIKTAG";
            this.colCIKTAGc.Name = "colCIKTAGc";
            this.colCIKTAGc.Visible = true;
            this.colCIKTAGc.VisibleIndex = 3;
            this.colCIKTAGc.Width = 528;
            // 
            // colCIKTRHc
            // 
            this.colCIKTRHc.Caption = "ÇıkTrh";
            this.colCIKTRHc.FieldName = "CIKTRH";
            this.colCIKTRHc.Name = "colCIKTRHc";
            this.colCIKTRHc.OptionsColumn.FixedWidth = true;
            this.colCIKTRHc.Visible = true;
            this.colCIKTRHc.VisibleIndex = 1;
            this.colCIKTRHc.Width = 100;
            // 
            // dpgaGridControl
            // 
            this.dpgaGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.dpgaGridControl.DataSource = this.dpgaBindingSource;
            this.dpgaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpgaGridControl.EmbeddedNavigator.Buttons.Append.ImageIndex = 0;
            this.dpgaGridControl.EmbeddedNavigator.Buttons.EndEdit.Hint = "Save";
            this.dpgaGridControl.EmbeddedNavigator.Buttons.EndEdit.ImageIndex = 1;
            this.dpgaGridControl.EmbeddedNavigator.Buttons.EndEdit.Tag = "save";
            this.dpgaGridControl.EmbeddedNavigator.Buttons.Remove.ImageIndex = 3;
            gridLevelNode1.LevelTemplate = this.dpcGridView;
            gridLevelNode1.RelationName = "DPC_DPG";
            this.dpgaGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dpgaGridControl.Location = new System.Drawing.Point(0, 0);
            this.dpgaGridControl.MainView = this.dpgaGridView;
            this.dpgaGridControl.Name = "dpgaGridControl";
            this.dpgaGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.xtRepositoryItemMemoExEdit,
            this.repositoryItemMemoEdit1});
            this.dpgaGridControl.ShowOnlyPredefinedDetails = true;
            this.dpgaGridControl.Size = new System.Drawing.Size(887, 564);
            this.dpgaGridControl.TabIndex = 1;
            this.dpgaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dpgaGridView,
            this.dpcGridView});
            this.dpgaGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridControl_KeyDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaUrunDetaylariToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tableExtensionsToolStripMenuItem,
            this.printToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(172, 92);
            // 
            // firmaUrunDetaylariToolStripMenuItem
            // 
            this.firmaUrunDetaylariToolStripMenuItem.Name = "firmaUrunDetaylariToolStripMenuItem";
            this.firmaUrunDetaylariToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.firmaUrunDetaylariToolStripMenuItem.Text = "Firma Ürün detayları";
            this.firmaUrunDetaylariToolStripMenuItem.Click += new System.EventHandler(this.firmaUrunDetaylariToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.tableExtensions2ToolStripMenuItem_Click);
            // 
            // tableExtensionsToolStripMenuItem
            // 
            this.tableExtensionsToolStripMenuItem.Name = "tableExtensionsToolStripMenuItem";
            this.tableExtensionsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.tableExtensionsToolStripMenuItem.Text = "Table extensions";
            this.tableExtensionsToolStripMenuItem.Click += new System.EventHandler(this.tableExtensionsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // dpgaBindingSource
            // 
            this.dpgaBindingSource.DataMember = "DPGA";
            this.dpgaBindingSource.DataSource = this.depoDataSet;
            // 
            // depoDataSet
            // 
            this.depoDataSet.DataSetName = "DepoDataSet";
            this.depoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dpgaGridView
            // 
            this.dpgaGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDPGID,
            this.colGIRTRH,
            this.colDRM,
            this.colFRTID,
            this.colTANIM,
            this.colGIRTAG,
            this.colGTPID,
            this.colGIRMIK,
            this.colRAF,
            this.colKLNMIK,
            this.colGIRSGRDGR,
            this.colKlnSgrDgr,
            this.colBITTRH,
            this.colXTBLB,
            this.colXTTXT});
            this.dpgaGridView.GridControl = this.dpgaGridControl;
            this.dpgaGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIRMIK", this.colGIRMIK, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KLNMIK", this.colKLNMIK, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIRSGRDGR", this.colGIRSGRDGR, "{0:n2}")});
            this.dpgaGridView.Name = "dpgaGridView";
            this.dpgaGridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.dpgaGridView.OptionsDetail.AllowExpandEmptyDetails = true;
            this.dpgaGridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.dpgaGridView.OptionsNavigation.AutoFocusNewRow = true;
            this.dpgaGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.dpgaGridView.OptionsView.RowAutoHeight = true;
            this.dpgaGridView.OptionsView.ShowFooter = true;
            this.dpgaGridView.OptionsView.ShowViewCaption = true;
            this.dpgaGridView.ViewCaption = "Depo Girişleri";
            this.dpgaGridView.CalcRowHeight += new DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(this.dpgaGridView_CalcRowHeight);
            this.dpgaGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.dpgaGridView_InitNewRow);
            this.dpgaGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dpgaGridView_FocusedRowChanged);
            this.dpgaGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.dpgaGridView_RowUpdated);
            // 
            // colDPGID
            // 
            this.colDPGID.DisplayFormat.FormatString = "n0";
            this.colDPGID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDPGID.FieldName = "DPGID";
            this.colDPGID.Name = "colDPGID";
            this.colDPGID.OptionsColumn.AllowEdit = false;
            this.colDPGID.OptionsColumn.AllowFocus = false;
            this.colDPGID.OptionsColumn.FixedWidth = true;
            this.colDPGID.Visible = true;
            this.colDPGID.VisibleIndex = 0;
            this.colDPGID.Width = 60;
            // 
            // colGIRTRH
            // 
            this.colGIRTRH.Caption = "GirişTrh";
            this.colGIRTRH.FieldName = "GIRTRH";
            this.colGIRTRH.GroupFormat.FormatString = "dd.MM.yy";
            this.colGIRTRH.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colGIRTRH.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText;
            this.colGIRTRH.Name = "colGIRTRH";
            this.colGIRTRH.OptionsColumn.FixedWidth = true;
            this.colGIRTRH.Visible = true;
            this.colGIRTRH.VisibleIndex = 1;
            this.colGIRTRH.Width = 100;
            // 
            // colDRM
            // 
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.OptionsColumn.AllowEdit = false;
            this.colDRM.OptionsColumn.AllowFocus = false;
            this.colDRM.OptionsColumn.FixedWidth = true;
            this.colDRM.Width = 40;
            // 
            // colFRTID
            // 
            this.colFRTID.Caption = "Firma";
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 2;
            this.colFRTID.Width = 27;
            // 
            // colTANIM
            // 
            this.colTANIM.Caption = "Mal Tanımı";
            this.colTANIM.FieldName = "TANIM";
            this.colTANIM.Name = "colTANIM";
            this.colTANIM.Visible = true;
            this.colTANIM.VisibleIndex = 3;
            this.colTANIM.Width = 85;
            // 
            // colGIRTAG
            // 
            this.colGIRTAG.Caption = "GirTAG";
            this.colGIRTAG.ColumnEdit = this.repositoryItemTextEdit1;
            this.colGIRTAG.FieldName = "GIRTAG";
            this.colGIRTAG.Name = "colGIRTAG";
            this.colGIRTAG.Visible = true;
            this.colGIRTAG.VisibleIndex = 8;
            this.colGIRTAG.Width = 20;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "(([A-Z]+:[0-9A-Z]+)+ \\x0D\\x0A)+";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colGTPID
            // 
            this.colGTPID.Caption = "GTP";
            this.colGTPID.FieldName = "GTPID";
            this.colGTPID.Name = "colGTPID";
            this.colGTPID.ToolTip = "Gümrük Tarife Pozisyon No";
            this.colGTPID.Visible = true;
            this.colGTPID.VisibleIndex = 6;
            this.colGTPID.Width = 20;
            // 
            // colGIRMIK
            // 
            this.colGIRMIK.Caption = "GirMik";
            this.colGIRMIK.DisplayFormat.FormatString = "n0";
            this.colGIRMIK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGIRMIK.FieldName = "GIRMIK";
            this.colGIRMIK.Name = "colGIRMIK";
            this.colGIRMIK.OptionsColumn.FixedWidth = true;
            this.colGIRMIK.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIRMIK", "{0:n0}")});
            this.colGIRMIK.Visible = true;
            this.colGIRMIK.VisibleIndex = 4;
            this.colGIRMIK.Width = 60;
            // 
            // colRAF
            // 
            this.colRAF.Caption = "Raf";
            this.colRAF.FieldName = "RAF";
            this.colRAF.MaxWidth = 60;
            this.colRAF.Name = "colRAF";
            this.colRAF.Visible = true;
            this.colRAF.VisibleIndex = 7;
            this.colRAF.Width = 20;
            // 
            // colKLNMIK
            // 
            this.colKLNMIK.Caption = "KlnMik";
            this.colKLNMIK.DisplayFormat.FormatString = "n0";
            this.colKLNMIK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKLNMIK.FieldName = "KLNMIK";
            this.colKLNMIK.Name = "colKLNMIK";
            this.colKLNMIK.OptionsColumn.AllowEdit = false;
            this.colKLNMIK.OptionsColumn.AllowFocus = false;
            this.colKLNMIK.OptionsColumn.FixedWidth = true;
            this.colKLNMIK.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KLNMIK", "{0:n0}")});
            this.colKLNMIK.Visible = true;
            this.colKLNMIK.VisibleIndex = 9;
            this.colKLNMIK.Width = 60;
            // 
            // colGIRSGRDGR
            // 
            this.colGIRSGRDGR.Caption = "SgrDğr";
            this.colGIRSGRDGR.DisplayFormat.FormatString = "n2";
            this.colGIRSGRDGR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGIRSGRDGR.FieldName = "GIRSGRDGR";
            this.colGIRSGRDGR.Name = "colGIRSGRDGR";
            this.colGIRSGRDGR.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIRSGRDGR", "{0:n2}")});
            this.colGIRSGRDGR.Visible = true;
            this.colGIRSGRDGR.VisibleIndex = 5;
            this.colGIRSGRDGR.Width = 20;
            // 
            // colKlnSgrDgr
            // 
            this.colKlnSgrDgr.Caption = "KlnSgrDğr";
            this.colKlnSgrDgr.DisplayFormat.FormatString = "n2";
            this.colKlnSgrDgr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKlnSgrDgr.FieldName = "colKlnSgrDgr";
            this.colKlnSgrDgr.Name = "colKlnSgrDgr";
            this.colKlnSgrDgr.OptionsColumn.AllowEdit = false;
            this.colKlnSgrDgr.OptionsColumn.AllowFocus = false;
            this.colKlnSgrDgr.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colKlnSgrDgr", "{0:n2}")});
            this.colKlnSgrDgr.ToolTip = "Kalan miktarın sigorta değeri (GirSgrDgr/GirMik*KlnMik)";
            this.colKlnSgrDgr.UnboundExpression = "[GIRSGRDGR]/ [GIRMIK]* [KLNMIK]";
            this.colKlnSgrDgr.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colKlnSgrDgr.Visible = true;
            this.colKlnSgrDgr.VisibleIndex = 10;
            this.colKlnSgrDgr.Width = 20;
            // 
            // colBITTRH
            // 
            this.colBITTRH.Caption = "KapanışTrh";
            this.colBITTRH.FieldName = "BITTRH";
            this.colBITTRH.Name = "colBITTRH";
            this.colBITTRH.OptionsColumn.AllowEdit = false;
            this.colBITTRH.OptionsColumn.AllowFocus = false;
            this.colBITTRH.Visible = true;
            this.colBITTRH.VisibleIndex = 11;
            this.colBITTRH.Width = 20;
            // 
            // colXTBLB
            // 
            this.colXTBLB.ColumnEdit = this.xtRepositoryItemMemoExEdit;
            this.colXTBLB.FieldName = "XTBLB";
            this.colXTBLB.Name = "colXTBLB";
            this.colXTBLB.OptionsColumn.ReadOnly = true;
            // 
            // xtRepositoryItemMemoExEdit
            // 
            this.xtRepositoryItemMemoExEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtRepositoryItemMemoExEdit.Appearance.Options.UseFont = true;
            this.xtRepositoryItemMemoExEdit.AppearanceDropDown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtRepositoryItemMemoExEdit.AppearanceDropDown.Options.UseFont = true;
            this.xtRepositoryItemMemoExEdit.AutoHeight = false;
            this.xtRepositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xtRepositoryItemMemoExEdit.Name = "xtRepositoryItemMemoExEdit";
            this.xtRepositoryItemMemoExEdit.WordWrap = false;
            // 
            // colXTTXT
            // 
            this.colXTTXT.AppearanceCell.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colXTTXT.AppearanceCell.Options.UseFont = true;
            this.colXTTXT.AppearanceCell.Options.UseTextOptions = true;
            this.colXTTXT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.colXTTXT.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colXTTXT.FieldName = "XTTXT";
            this.colXTTXT.Name = "colXTTXT";
            this.colXTTXT.Visible = true;
            this.colXTTXT.VisibleIndex = 12;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemMemoEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.ReadOnly = true;
            this.repositoryItemMemoEdit1.WordWrap = false;
            // 
            // dpgaTableAdapter
            // 
            this.dpgaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DPCATableAdapter = this.dpcTableAdapter;
            this.tableAdapterManager.DPCTableAdapter = null;
            this.tableAdapterManager.DPGATableAdapter = this.dpgaTableAdapter;
            this.tableAdapterManager.DPGTableAdapter = null;
            this.tableAdapterManager.GTPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Depo.DepoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dpcTableAdapter
            // 
            this.dpcTableAdapter.ClearBeforeFill = true;
            // 
            // dpcBindingSource
            // 
            this.dpcBindingSource.DataMember = "DPC";
            this.dpcBindingSource.DataSource = this.depoDataSet;
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.xtDockPanel});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            this.dockManager.ClosedPanel += new DevExpress.XtraBars.Docking.DockPanelEventHandler(this.dockManager_ClosedPanel);
            // 
            // xtDockPanel
            // 
            this.xtDockPanel.Controls.Add(this.dockPanel1_Container);
            this.xtDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.xtDockPanel.ID = new System.Guid("b15b2648-b5f9-4541-a2f5-7309fb73290e");
            this.xtDockPanel.Location = new System.Drawing.Point(887, 0);
            this.xtDockPanel.Name = "xtDockPanel";
            this.xtDockPanel.Options.ShowCloseButton = false;
            this.xtDockPanel.OriginalSize = new System.Drawing.Size(322, 200);
            this.xtDockPanel.Size = new System.Drawing.Size(322, 564);
            this.xtDockPanel.Text = "TableExtensions";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(314, 537);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dpgAktifUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dpgaGridControl);
            this.Controls.Add(this.xtDockPanel);
            this.Name = "dpgAktifUC";
            this.Size = new System.Drawing.Size(1209, 564);
            this.Load += new System.EventHandler(this.dpgAktifUserControl_Load);
            this.Enter += new System.EventHandler(this.dpgAktifUC_Enter);
            this.Leave += new System.EventHandler(this.dpgAktifUC_Leave);
            this.Resize += new System.EventHandler(this.dpgAktifUC_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dpcGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpgaGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dpgaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpgaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtRepositoryItemMemoExEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.xtDockPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DepoDataSet depoDataSet;
        private System.Windows.Forms.BindingSource dpgaBindingSource;
        private DepoDataSetTableAdapters.DPGATableAdapter dpgaTableAdapter;
        private DepoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl dpgaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView dpgaGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDPGID;
        private DevExpress.XtraGrid.Columns.GridColumn colGIRTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colTANIM;
        private DevExpress.XtraGrid.Columns.GridColumn colGIRTAG;
        private DevExpress.XtraGrid.Columns.GridColumn colGTPID;
        private DevExpress.XtraGrid.Columns.GridColumn colGIRMIK;
        private DevExpress.XtraGrid.Columns.GridColumn colRAF;
        private DepoDataSetTableAdapters.DepoQueriesTableAdapter depoQueriesTableAdapter;
        private System.Windows.Forms.BindingSource dpcBindingSource;
        private DepoDataSetTableAdapters.DPCATableAdapter dpcTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView dpcGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDPCIDc;
        private DevExpress.XtraGrid.Columns.GridColumn colDPGIDc;
        private DevExpress.XtraGrid.Columns.GridColumn colCIKMIKc;
        private DevExpress.XtraGrid.Columns.GridColumn colCIKTAGc;
        private DevExpress.XtraGrid.Columns.GridColumn colCIKTRHc;
        private DevExpress.XtraGrid.Columns.GridColumn colKLNMIK;
        private DevExpress.XtraGrid.Columns.GridColumn colGIRSGRDGR;
        private DevExpress.XtraGrid.Columns.GridColumn colKlnSgrDgr;
        private DevExpress.XtraGrid.Columns.GridColumn colBITTRH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem firmaUrunDetaylariToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.ToolStripMenuItem tableExtensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private DevExpress.XtraBars.Docking.DockPanel xtDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.Columns.GridColumn colXTBLB;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit xtRepositoryItemMemoExEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colXTTXT;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}

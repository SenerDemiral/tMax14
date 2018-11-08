namespace tMax14.Firma
{
    partial class frtSalesRepXUC
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
            this.firmaDataSet = new tMax14.Firma.FirmaDataSet();
            this.frtSalesRepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frtSalesRepTableAdapter = new tMax14.Firma.FirmaDataSetTableAdapters.FRT_SALESREPTableAdapter();
            this.frtSalesRepGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frtSalesRepGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFRSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIRMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKRLYIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSRCTYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACCNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSREPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSREP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRQPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMVOL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTKLF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colTOPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRAKIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colJURNAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTFLY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUSRSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.qsDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtSalesRepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtSalesRepGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frtSalesRepGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.qsDockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firmaDataSet
            // 
            this.firmaDataSet.DataSetName = "FirmaDataSet";
            this.firmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frtSalesRepBindingSource
            // 
            this.frtSalesRepBindingSource.DataMember = "FRT_SALESREP";
            this.frtSalesRepBindingSource.DataSource = this.firmaDataSet;
            // 
            // frtSalesRepTableAdapter
            // 
            this.frtSalesRepTableAdapter.ClearBeforeFill = true;
            // 
            // frtSalesRepGridControl
            // 
            this.frtSalesRepGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.frtSalesRepGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.frtSalesRepGridControl.DataSource = this.frtSalesRepBindingSource;
            this.frtSalesRepGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frtSalesRepGridControl.Location = new System.Drawing.Point(19, 0);
            this.frtSalesRepGridControl.MainView = this.frtSalesRepGridView;
            this.frtSalesRepGridControl.Name = "frtSalesRepGridControl";
            this.frtSalesRepGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemMemoEdit1});
            this.frtSalesRepGridControl.Size = new System.Drawing.Size(1047, 362);
            this.frtSalesRepGridControl.TabIndex = 2;
            this.frtSalesRepGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.frtSalesRepGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.previewToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(152, 70);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.CheckOnClick = true;
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // frtSalesRepGridView
            // 
            this.frtSalesRepGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frtSalesRepGridView.Appearance.GroupRow.Options.UseFont = true;
            this.frtSalesRepGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFRSID,
            this.colFRTID,
            this.colFIRMA,
            this.colKRLYIL,
            this.colSRCTYP,
            this.colACCID,
            this.colACCNT,
            this.colSREPID,
            this.colSREP,
            this.colROT,
            this.colMOT,
            this.colORG,
            this.colDST,
            this.colFRQPM,
            this.colMVOL,
            this.colDTM,
            this.colTKLF,
            this.colTOPS,
            this.colRAKIP,
            this.colINFO,
            this.colJURNAL,
            this.gridColumn1,
            this.colFRTDRM,
            this.colFRTFLY,
            this.colSUSR,
            this.colSUSRSD});
            this.frtSalesRepGridView.GridControl = this.frtSalesRepGridControl;
            this.frtSalesRepGridView.GroupCount = 2;
            this.frtSalesRepGridView.Name = "frtSalesRepGridView";
            this.frtSalesRepGridView.OptionsPrint.PrintPreview = true;
            this.frtSalesRepGridView.OptionsView.AllowCellMerge = true;
            this.frtSalesRepGridView.OptionsView.AutoCalcPreviewLineCount = true;
            this.frtSalesRepGridView.OptionsView.RowAutoHeight = true;
            this.frtSalesRepGridView.PreviewFieldName = "JURNAL";
            this.frtSalesRepGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSREP, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFIRMA, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colFRSID
            // 
            this.colFRSID.FieldName = "FRSID";
            this.colFRSID.Name = "colFRSID";
            this.colFRSID.Visible = true;
            this.colFRSID.VisibleIndex = 0;
            this.colFRSID.Width = 62;
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            // 
            // colFIRMA
            // 
            this.colFIRMA.Caption = "Firma";
            this.colFIRMA.FieldName = "FIRMA";
            this.colFIRMA.Name = "colFIRMA";
            this.colFIRMA.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colFIRMA.Visible = true;
            this.colFIRMA.VisibleIndex = 2;
            this.colFIRMA.Width = 71;
            // 
            // colKRLYIL
            // 
            this.colKRLYIL.AppearanceCell.Options.UseTextOptions = true;
            this.colKRLYIL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKRLYIL.AppearanceHeader.Options.UseTextOptions = true;
            this.colKRLYIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKRLYIL.Caption = "KurYıl";
            this.colKRLYIL.FieldName = "KRLYIL";
            this.colKRLYIL.Name = "colKRLYIL";
            this.colKRLYIL.ToolTip = "Kuruluş Yılı";
            this.colKRLYIL.Visible = true;
            this.colKRLYIL.VisibleIndex = 1;
            this.colKRLYIL.Width = 33;
            // 
            // colSRCTYP
            // 
            this.colSRCTYP.Caption = "SrcTyp";
            this.colSRCTYP.FieldName = "SRCTYP";
            this.colSRCTYP.Name = "colSRCTYP";
            this.colSRCTYP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSRCTYP.ToolTip = "Source Type";
            this.colSRCTYP.Visible = true;
            this.colSRCTYP.VisibleIndex = 3;
            this.colSRCTYP.Width = 47;
            // 
            // colACCID
            // 
            this.colACCID.FieldName = "ACCID";
            this.colACCID.Name = "colACCID";
            // 
            // colACCNT
            // 
            this.colACCNT.Caption = "Account";
            this.colACCNT.FieldName = "ACCNT";
            this.colACCNT.Name = "colACCNT";
            this.colACCNT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colACCNT.Visible = true;
            this.colACCNT.VisibleIndex = 4;
            this.colACCNT.Width = 60;
            // 
            // colSREPID
            // 
            this.colSREPID.FieldName = "SREPID";
            this.colSREPID.Name = "colSREPID";
            // 
            // colSREP
            // 
            this.colSREP.Caption = "SalesRep";
            this.colSREP.FieldName = "SREP";
            this.colSREP.Name = "colSREP";
            this.colSREP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSREP.Visible = true;
            this.colSREP.VisibleIndex = 5;
            this.colSREP.Width = 57;
            // 
            // colROT
            // 
            this.colROT.AppearanceCell.Options.UseTextOptions = true;
            this.colROT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colROT.AppearanceHeader.Options.UseTextOptions = true;
            this.colROT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 5;
            this.colROT.Width = 24;
            // 
            // colMOT
            // 
            this.colMOT.AppearanceCell.Options.UseTextOptions = true;
            this.colMOT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMOT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMOT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 6;
            this.colMOT.Width = 23;
            // 
            // colORG
            // 
            this.colORG.Caption = "Org";
            this.colORG.FieldName = "ORG";
            this.colORG.Name = "colORG";
            this.colORG.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colORG.Visible = true;
            this.colORG.VisibleIndex = 7;
            this.colORG.Width = 48;
            // 
            // colDST
            // 
            this.colDST.Caption = "Dst";
            this.colDST.FieldName = "DST";
            this.colDST.Name = "colDST";
            this.colDST.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDST.Visible = true;
            this.colDST.VisibleIndex = 8;
            this.colDST.Width = 48;
            // 
            // colFRQPM
            // 
            this.colFRQPM.AppearanceCell.Options.UseTextOptions = true;
            this.colFRQPM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFRQPM.AppearanceHeader.Options.UseTextOptions = true;
            this.colFRQPM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFRQPM.Caption = "Frq/M";
            this.colFRQPM.FieldName = "FRQPM";
            this.colFRQPM.Name = "colFRQPM";
            this.colFRQPM.Visible = true;
            this.colFRQPM.VisibleIndex = 9;
            this.colFRQPM.Width = 30;
            // 
            // colMVOL
            // 
            this.colMVOL.AppearanceCell.Options.UseTextOptions = true;
            this.colMVOL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMVOL.Caption = "MnthVol";
            this.colMVOL.FieldName = "MVOL";
            this.colMVOL.Name = "colMVOL";
            this.colMVOL.Visible = true;
            this.colMVOL.VisibleIndex = 10;
            this.colMVOL.Width = 36;
            // 
            // colDTM
            // 
            this.colDTM.AppearanceCell.Options.UseTextOptions = true;
            this.colDTM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDTM.AppearanceHeader.Options.UseTextOptions = true;
            this.colDTM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDTM.FieldName = "DTM";
            this.colDTM.Name = "colDTM";
            this.colDTM.Visible = true;
            this.colDTM.VisibleIndex = 11;
            this.colDTM.Width = 35;
            // 
            // colTKLF
            // 
            this.colTKLF.Caption = "Teklif";
            this.colTKLF.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colTKLF.FieldName = "TKLF";
            this.colTKLF.Name = "colTKLF";
            this.colTKLF.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTKLF.ToolTip = "Teklif Verildi";
            this.colTKLF.Visible = true;
            this.colTKLF.VisibleIndex = 12;
            this.colTKLF.Width = 26;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = "T";
            this.repositoryItemCheckEdit1.ValueUnchecked = "F";
            // 
            // colTOPS
            // 
            this.colTOPS.Caption = "TOPs";
            this.colTOPS.FieldName = "TOPS";
            this.colTOPS.Name = "colTOPS";
            this.colTOPS.Visible = true;
            this.colTOPS.VisibleIndex = 13;
            this.colTOPS.Width = 35;
            // 
            // colRAKIP
            // 
            this.colRAKIP.Caption = "Rakip";
            this.colRAKIP.FieldName = "RAKIP";
            this.colRAKIP.Name = "colRAKIP";
            this.colRAKIP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRAKIP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colRAKIP.Visible = true;
            this.colRAKIP.VisibleIndex = 14;
            this.colRAKIP.Width = 59;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Info";
            this.colINFO.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 15;
            this.colINFO.Width = 105;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colJURNAL
            // 
            this.colJURNAL.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colJURNAL.FieldName = "JURNAL";
            this.colJURNAL.Name = "colJURNAL";
            this.colJURNAL.Visible = true;
            this.colJURNAL.VisibleIndex = 19;
            this.colJURNAL.Width = 96;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Jrn";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundExpression = "!IsNull([JURNAL])";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 16;
            this.gridColumn1.Width = 57;
            // 
            // colFRTDRM
            // 
            this.colFRTDRM.Caption = "Drm";
            this.colFRTDRM.FieldName = "FRTDRM";
            this.colFRTDRM.Name = "colFRTDRM";
            this.colFRTDRM.Visible = true;
            this.colFRTDRM.VisibleIndex = 2;
            this.colFRTDRM.Width = 27;
            // 
            // colFRTFLY
            // 
            this.colFRTFLY.Caption = "Faaliyet";
            this.colFRTFLY.FieldName = "FRTFLY";
            this.colFRTFLY.Name = "colFRTFLY";
            // 
            // colSUSR
            // 
            this.colSUSR.Caption = "SprtUsr";
            this.colSUSR.FieldName = "SUSR";
            this.colSUSR.Name = "colSUSR";
            this.colSUSR.Visible = true;
            this.colSUSR.VisibleIndex = 17;
            this.colSUSR.Width = 89;
            // 
            // colSUSRSD
            // 
            this.colSUSRSD.Caption = "SprtUsrStart";
            this.colSUSRSD.FieldName = "SUSRSD";
            this.colSUSRSD.Name = "colSUSRSD";
            this.colSUSRSD.Visible = true;
            this.colSUSRSD.VisibleIndex = 18;
            this.colSUSRSD.Width = 89;
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
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.hideContainerLeft.Controls.Add(this.qsDockPanel);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 362);
            // 
            // qsDockPanel
            // 
            this.qsDockPanel.Controls.Add(this.dockPanel1_Container);
            this.qsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.qsDockPanel.ID = new System.Guid("3491e121-2c49-46e5-a0a7-933665f79caf");
            this.qsDockPanel.Location = new System.Drawing.Point(0, 0);
            this.qsDockPanel.Name = "qsDockPanel";
            this.qsDockPanel.Options.ShowCloseButton = false;
            this.qsDockPanel.OriginalSize = new System.Drawing.Size(254, 200);
            this.qsDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.qsDockPanel.SavedIndex = 0;
            this.qsDockPanel.Size = new System.Drawing.Size(254, 362);
            this.qsDockPanel.Text = "Quick Search";
            this.qsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(246, 335);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // frtSalesRepXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frtSalesRepGridControl);
            this.Controls.Add(this.hideContainerLeft);
            this.Name = "frtSalesRepXUC";
            this.Size = new System.Drawing.Size(1066, 362);
            this.Load += new System.EventHandler(this.frtSalesRepXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtSalesRepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtSalesRepGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frtSalesRepGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.qsDockPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FirmaDataSet firmaDataSet;
        private System.Windows.Forms.BindingSource frtSalesRepBindingSource;
        private FirmaDataSetTableAdapters.FRT_SALESREPTableAdapter frtSalesRepTableAdapter;
        private DevExpress.XtraGrid.GridControl frtSalesRepGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView frtSalesRepGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colFRSID;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colFIRMA;
        private DevExpress.XtraGrid.Columns.GridColumn colKRLYIL;
        private DevExpress.XtraGrid.Columns.GridColumn colSRCTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colACCID;
        private DevExpress.XtraGrid.Columns.GridColumn colACCNT;
        private DevExpress.XtraGrid.Columns.GridColumn colSREPID;
        private DevExpress.XtraGrid.Columns.GridColumn colSREP;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colORG;
        private DevExpress.XtraGrid.Columns.GridColumn colDST;
        private DevExpress.XtraGrid.Columns.GridColumn colFRQPM;
        private DevExpress.XtraGrid.Columns.GridColumn colMVOL;
        private DevExpress.XtraGrid.Columns.GridColumn colDTM;
        private DevExpress.XtraGrid.Columns.GridColumn colTKLF;
        private DevExpress.XtraGrid.Columns.GridColumn colTOPS;
        private DevExpress.XtraGrid.Columns.GridColumn colRAKIP;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colJURNAL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraBars.Docking.DockPanel qsDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTFLY;
        private DevExpress.XtraGrid.Columns.GridColumn colSUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colSUSRSD;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}

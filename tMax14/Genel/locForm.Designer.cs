namespace tMax14.Genel
{
    partial class locForm
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
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.qsDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.serachAdRepositoryItemMRUEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit();
            this.genelDataSet = new tMax14.Genel.GenelDataSet();
            this.locBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.LOCTableAdapter();
            this.locGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktifYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLOCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DRMrepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFUNC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNTRY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOORD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLM_USR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLM_TS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOZLDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCITYID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.qsDockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serachAdRepositoryItemMRUEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRMrepositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.DockManager = this.dockManager;
            this.barManager.Form = this;
            this.barManager.MaxItemId = 3;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.serachAdRepositoryItemMRUEdit});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(756, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 454);
            this.barDockControlBottom.Size = new System.Drawing.Size(756, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 454);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(756, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 454);
            // 
            // dockManager
            // 
            this.dockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.dockManager.Form = this;
            this.dockManager.MenuManager = this.barManager;
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
            this.hideContainerLeft.Controls.Add(this.qsDockPanel);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 454);
            // 
            // qsDockPanel
            // 
            this.qsDockPanel.Controls.Add(this.dockPanel1_Container);
            this.qsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.qsDockPanel.ID = new System.Guid("3cb01a5f-be7c-4f38-ba99-a64f48bab947");
            this.qsDockPanel.Location = new System.Drawing.Point(-200, 0);
            this.qsDockPanel.Name = "qsDockPanel";
            this.qsDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.qsDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.qsDockPanel.SavedIndex = 0;
            this.qsDockPanel.Size = new System.Drawing.Size(200, 454);
            this.qsDockPanel.Text = "Quick Search";
            this.qsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 427);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // serachAdRepositoryItemMRUEdit
            // 
            this.serachAdRepositoryItemMRUEdit.Name = "serachAdRepositoryItemMRUEdit";
            // 
            // genelDataSet
            // 
            this.genelDataSet.DataSetName = "GenelDataSet";
            this.genelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locBindingSource
            // 
            this.locBindingSource.DataMember = "LOC";
            this.locBindingSource.DataSource = this.genelDataSet;
            // 
            // locTableAdapter
            // 
            this.locTableAdapter.ClearBeforeFill = true;
            // 
            // locGridControl
            // 
            this.locGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.locGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.locGridControl.DataSource = this.locBindingSource;
            this.locGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locGridControl.Location = new System.Drawing.Point(19, 0);
            this.locGridControl.MainView = this.locGridView;
            this.locGridControl.MenuManager = this.barManager;
            this.locGridControl.Name = "locGridControl";
            this.locGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DRMrepositoryItemCheckEdit});
            this.locGridControl.Size = new System.Drawing.Size(737, 454);
            this.locGridControl.TabIndex = 5;
            this.locGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.locGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapToolStripMenuItem,
            this.aktifYapToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.mapToolStripMenuItem.Text = "Map";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // aktifYapToolStripMenuItem
            // 
            this.aktifYapToolStripMenuItem.Name = "aktifYapToolStripMenuItem";
            this.aktifYapToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aktifYapToolStripMenuItem.Text = "Aktif yap";
            this.aktifYapToolStripMenuItem.Click += new System.EventHandler(this.aktifYapToolStripMenuItem_Click);
            // 
            // locGridView
            // 
            this.locGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLOCID,
            this.colDRM,
            this.colAD,
            this.colIATA,
            this.colFUNC,
            this.colCITYID,
            this.colCNTRY,
            this.colCOORD,
            this.colLM_USR,
            this.colLM_TS,
            this.colOZLDRM});
            this.locGridView.GridControl = this.locGridControl;
            this.locGridView.Name = "locGridView";
            // 
            // colLOCID
            // 
            this.colLOCID.Caption = "LOCid";
            this.colLOCID.FieldName = "LOCID";
            this.colLOCID.Name = "colLOCID";
            this.colLOCID.OptionsColumn.AllowEdit = false;
            this.colLOCID.OptionsColumn.FixedWidth = true;
            this.colLOCID.Visible = true;
            this.colLOCID.VisibleIndex = 0;
            this.colLOCID.Width = 49;
            // 
            // colDRM
            // 
            this.colDRM.Caption = "Aktif";
            this.colDRM.ColumnEdit = this.DRMrepositoryItemCheckEdit;
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.OptionsColumn.FixedWidth = true;
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 1;
            this.colDRM.Width = 39;
            // 
            // DRMrepositoryItemCheckEdit
            // 
            this.DRMrepositoryItemCheckEdit.AutoHeight = false;
            this.DRMrepositoryItemCheckEdit.Caption = "Check";
            this.DRMrepositoryItemCheckEdit.Name = "DRMrepositoryItemCheckEdit";
            this.DRMrepositoryItemCheckEdit.ValueChecked = "A";
            this.DRMrepositoryItemCheckEdit.ValueGrayed = "z";
            this.DRMrepositoryItemCheckEdit.ValueUnchecked = "P";
            // 
            // colAD
            // 
            this.colAD.Caption = "Ad";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.OptionsColumn.AllowEdit = false;
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 2;
            this.colAD.Width = 247;
            // 
            // colIATA
            // 
            this.colIATA.FieldName = "IATA";
            this.colIATA.Name = "colIATA";
            this.colIATA.OptionsColumn.AllowEdit = false;
            this.colIATA.OptionsColumn.FixedWidth = true;
            this.colIATA.Visible = true;
            this.colIATA.VisibleIndex = 5;
            this.colIATA.Width = 50;
            // 
            // colFUNC
            // 
            this.colFUNC.Caption = "Function";
            this.colFUNC.FieldName = "FUNC";
            this.colFUNC.Name = "colFUNC";
            this.colFUNC.OptionsColumn.AllowEdit = false;
            this.colFUNC.OptionsColumn.FixedWidth = true;
            this.colFUNC.ToolTip = "0:Undefined, 1:Port, 2:Rail, 3:Road, 4:Airport, 5:PostalOffice, 6:Reserved, 7:Res" +
    "erved, B:Border";
            this.colFUNC.Visible = true;
            this.colFUNC.VisibleIndex = 6;
            this.colFUNC.Width = 80;
            // 
            // colCNTRY
            // 
            this.colCNTRY.Caption = "Country";
            this.colCNTRY.FieldName = "CNTRY";
            this.colCNTRY.Name = "colCNTRY";
            this.colCNTRY.OptionsColumn.AllowEdit = false;
            this.colCNTRY.Visible = true;
            this.colCNTRY.VisibleIndex = 4;
            this.colCNTRY.Width = 120;
            // 
            // colCOORD
            // 
            this.colCOORD.Caption = "Coord";
            this.colCOORD.FieldName = "COORD";
            this.colCOORD.Name = "colCOORD";
            this.colCOORD.OptionsColumn.AllowEdit = false;
            this.colCOORD.OptionsColumn.FixedWidth = true;
            this.colCOORD.Visible = true;
            this.colCOORD.VisibleIndex = 7;
            this.colCOORD.Width = 120;
            // 
            // colLM_USR
            // 
            this.colLM_USR.FieldName = "LM_USR";
            this.colLM_USR.Name = "colLM_USR";
            // 
            // colLM_TS
            // 
            this.colLM_TS.FieldName = "LM_TS";
            this.colLM_TS.Name = "colLM_TS";
            // 
            // colOZLDRM
            // 
            this.colOZLDRM.Caption = "ÖzelDurum";
            this.colOZLDRM.FieldName = "OZLDRM";
            this.colOZLDRM.Name = "colOZLDRM";
            this.colOZLDRM.Visible = true;
            this.colOZLDRM.VisibleIndex = 8;
            // 
            // colCITYID
            // 
            this.colCITYID.Caption = "City";
            this.colCITYID.FieldName = "CITYID";
            this.colCITYID.Name = "colCITYID";
            this.colCITYID.Visible = true;
            this.colCITYID.VisibleIndex = 3;
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // locForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this.locGridControl);
            this.Controls.Add(this.hideContainerLeft);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "locForm";
            this.Text = "locForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.locForm_FormClosing);
            this.Load += new System.EventHandler(this.locForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.qsDockPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serachAdRepositoryItemMRUEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRMrepositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit serachAdRepositoryItemMRUEdit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource locBindingSource;
        private GenelDataSet genelDataSet;
        private GenelDataSetTableAdapters.LOCTableAdapter locTableAdapter;
        private DevExpress.XtraGrid.GridControl locGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView locGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colLOCID;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colIATA;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNC;
        private DevExpress.XtraGrid.Columns.GridColumn colCNTRY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOORD;
        private DevExpress.XtraGrid.Columns.GridColumn colLM_USR;
        private DevExpress.XtraGrid.Columns.GridColumn colLM_TS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktifYapToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel qsDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit DRMrepositoryItemCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colOZLDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colCITYID;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
    }
}
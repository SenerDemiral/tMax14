namespace tMax14.Genel
{
    partial class rphXF
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
            this.genelDataSet = new tMax14.Genel.GenelDataSet();
            this.rphBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rphTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.RPHTableAdapter();
            this.rphGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rphGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRPHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRPTKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRSPW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TFrepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colRSPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.qsDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rphBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rphGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rphGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFrepositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.qsDockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // genelDataSet
            // 
            this.genelDataSet.DataSetName = "GenelDataSet";
            this.genelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rphBindingSource
            // 
            this.rphBindingSource.DataMember = "RPH";
            this.rphBindingSource.DataSource = this.genelDataSet;
            // 
            // rphTableAdapter
            // 
            this.rphTableAdapter.ClearBeforeFill = true;
            // 
            // rphGridControl
            // 
            this.rphGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.rphGridControl.DataSource = this.rphBindingSource;
            this.rphGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rphGridControl.Location = new System.Drawing.Point(19, 0);
            this.rphGridControl.MainView = this.rphGridView;
            this.rphGridControl.Name = "rphGridControl";
            this.rphGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TFrepositoryItemCheckEdit});
            this.rphGridControl.Size = new System.Drawing.Size(764, 304);
            this.rphGridControl.TabIndex = 2;
            this.rphGridControl.Tag = "RPH";
            this.rphGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rphGridView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // rphGridView
            // 
            this.rphGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRPHID,
            this.colRPTKOD,
            this.colEXD,
            this.colREFTO,
            this.colREFID,
            this.colFRTID,
            this.colUSR,
            this.colRSPW,
            this.colRSPD,
            this.colINFO,
            this.colUUSR});
            this.rphGridView.GridControl = this.rphGridControl;
            this.rphGridView.Name = "rphGridView";
            this.rphGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEXD, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colRPHID
            // 
            this.colRPHID.FieldName = "RPHID";
            this.colRPHID.Name = "colRPHID";
            this.colRPHID.OptionsColumn.FixedWidth = true;
            this.colRPHID.OptionsColumn.ReadOnly = true;
            this.colRPHID.Visible = true;
            this.colRPHID.VisibleIndex = 0;
            this.colRPHID.Width = 60;
            // 
            // colRPTKOD
            // 
            this.colRPTKOD.Caption = "Rapor";
            this.colRPTKOD.FieldName = "RPTKOD";
            this.colRPTKOD.Name = "colRPTKOD";
            this.colRPTKOD.OptionsColumn.FixedWidth = true;
            this.colRPTKOD.OptionsColumn.ReadOnly = true;
            this.colRPTKOD.Visible = true;
            this.colRPTKOD.VisibleIndex = 1;
            this.colRPTKOD.Width = 105;
            // 
            // colEXD
            // 
            this.colEXD.DisplayFormat.FormatString = "dd.MM.yy HH:mm";
            this.colEXD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEXD.FieldName = "EXD";
            this.colEXD.Name = "colEXD";
            this.colEXD.OptionsColumn.FixedWidth = true;
            this.colEXD.OptionsColumn.ReadOnly = true;
            this.colEXD.Visible = true;
            this.colEXD.VisibleIndex = 2;
            this.colEXD.Width = 82;
            // 
            // colREFTO
            // 
            this.colREFTO.Caption = "RefTO";
            this.colREFTO.FieldName = "REFTO";
            this.colREFTO.Name = "colREFTO";
            this.colREFTO.OptionsColumn.FixedWidth = true;
            this.colREFTO.OptionsColumn.ReadOnly = true;
            this.colREFTO.Visible = true;
            this.colREFTO.VisibleIndex = 3;
            this.colREFTO.Width = 60;
            // 
            // colREFID
            // 
            this.colREFID.Caption = "RefID";
            this.colREFID.FieldName = "REFID";
            this.colREFID.Name = "colREFID";
            this.colREFID.OptionsColumn.FixedWidth = true;
            this.colREFID.OptionsColumn.ReadOnly = true;
            this.colREFID.Visible = true;
            this.colREFID.VisibleIndex = 4;
            this.colREFID.Width = 60;
            // 
            // colFRTID
            // 
            this.colFRTID.Caption = "Firma";
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.OptionsColumn.ReadOnly = true;
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 5;
            this.colFRTID.Width = 68;
            // 
            // colUSR
            // 
            this.colUSR.Caption = "Usr";
            this.colUSR.FieldName = "USR";
            this.colUSR.Name = "colUSR";
            this.colUSR.OptionsColumn.FixedWidth = true;
            this.colUSR.OptionsColumn.ReadOnly = true;
            this.colUSR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colUSR.Visible = true;
            this.colUSR.VisibleIndex = 6;
            this.colUSR.Width = 45;
            // 
            // colRSPW
            // 
            this.colRSPW.Caption = "RspW";
            this.colRSPW.ColumnEdit = this.TFrepositoryItemCheckEdit;
            this.colRSPW.FieldName = "RSPW";
            this.colRSPW.Name = "colRSPW";
            this.colRSPW.OptionsColumn.FixedWidth = true;
            this.colRSPW.ToolTip = "Response Waiting";
            this.colRSPW.Visible = true;
            this.colRSPW.VisibleIndex = 7;
            this.colRSPW.Width = 42;
            // 
            // TFrepositoryItemCheckEdit
            // 
            this.TFrepositoryItemCheckEdit.AutoHeight = false;
            this.TFrepositoryItemCheckEdit.Caption = "Check";
            this.TFrepositoryItemCheckEdit.Name = "TFrepositoryItemCheckEdit";
            this.TFrepositoryItemCheckEdit.ValueChecked = "T";
            this.TFrepositoryItemCheckEdit.ValueUnchecked = "F";
            // 
            // colRSPD
            // 
            this.colRSPD.Caption = "RspD";
            this.colRSPD.DisplayFormat.FormatString = "dd.MM.yy";
            this.colRSPD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRSPD.FieldName = "RSPD";
            this.colRSPD.Name = "colRSPD";
            this.colRSPD.OptionsColumn.FixedWidth = true;
            this.colRSPD.ToolTip = "Response Date";
            this.colRSPD.Visible = true;
            this.colRSPD.VisibleIndex = 8;
            this.colRSPD.Width = 54;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Info";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 9;
            this.colINFO.Width = 170;
            // 
            // colUUSR
            // 
            this.colUUSR.Caption = "uUsr";
            this.colUUSR.FieldName = "UUSR";
            this.colUUSR.Name = "colUUSR";
            this.colUUSR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colUUSR.Visible = true;
            this.colUUSR.VisibleIndex = 10;
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
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 304);
            // 
            // qsDockPanel
            // 
            this.qsDockPanel.Controls.Add(this.dockPanel1_Container);
            this.qsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.qsDockPanel.ID = new System.Guid("53b73635-ee1a-4b4c-a904-f6c6162ab494");
            this.qsDockPanel.Location = new System.Drawing.Point(0, 0);
            this.qsDockPanel.Name = "qsDockPanel";
            this.qsDockPanel.OriginalSize = new System.Drawing.Size(294, 200);
            this.qsDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.qsDockPanel.SavedIndex = 0;
            this.qsDockPanel.Size = new System.Drawing.Size(294, 304);
            this.qsDockPanel.Text = "Quick Search";
            this.qsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(286, 277);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // rphXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 304);
            this.Controls.Add(this.rphGridControl);
            this.Controls.Add(this.hideContainerLeft);
            this.Name = "rphXF";
            this.Text = "Report History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rphXF_FormClosing);
            this.Load += new System.EventHandler(this.rphXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rphBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rphGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rphGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFrepositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.qsDockPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GenelDataSet genelDataSet;
        private System.Windows.Forms.BindingSource rphBindingSource;
        private GenelDataSetTableAdapters.RPHTableAdapter rphTableAdapter;
        private DevExpress.XtraGrid.GridControl rphGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView rphGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colRPHID;
        private DevExpress.XtraGrid.Columns.GridColumn colRPTKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colEXD;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTO;
        private DevExpress.XtraGrid.Columns.GridColumn colREFID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colRSPW;
        private DevExpress.XtraGrid.Columns.GridColumn colRSPD;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit TFrepositoryItemCheckEdit;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel qsDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colUUSR;
    }
}
namespace tMax14.Ops
{
    partial class obsdXF
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
            this.opsDataSet = new tMax14.Ops.OpsDataSet();
            this.oBSDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oBSDTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.OBSDTableAdapter();
            this.tableAdapterManager = new tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager();
            this.obsdGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.houseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obsdGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOBSDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSTLABID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTKNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.opsQueriesTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.OpsQueriesTableAdapter();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.colGRSTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stokGirisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBSDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsdGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obsdGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.SuspendLayout();
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oBSDBindingSource
            // 
            this.oBSDBindingSource.DataMember = "OBSD";
            this.oBSDBindingSource.DataSource = this.opsDataSet;
            // 
            // oBSDTableAdapter
            // 
            this.oBSDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AFDO_SELTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OBSDTableAdapter = this.oBSDTableAdapter;
            this.tableAdapterManager.OBSTableAdapter = null;
            this.tableAdapterManager.OPCCTableAdapter = null;
            this.tableAdapterManager.OPCTableAdapter = null;
            this.tableAdapterManager.OPH_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPH_SELTableAdapter = null;
            this.tableAdapterManager.OPHTableAdapter = null;
            this.tableAdapterManager.OPM_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPM_CNTR_LOADTableAdapter = null;
            this.tableAdapterManager.OPM_SELTableAdapter = null;
            this.tableAdapterManager.OPM2TableAdapter = null;
            this.tableAdapterManager.OPMATableAdapter = null;
            this.tableAdapterManager.OPMCTableAdapter = null;
            this.tableAdapterManager.OPMITableAdapter = null;
            this.tableAdapterManager.OPMTableAdapter = null;
            this.tableAdapterManager.OPOSTableAdapter = null;
            this.tableAdapterManager.OPOTableAdapter = null;
            this.tableAdapterManager.OPP_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPPTableAdapter = null;
            this.tableAdapterManager.OPRH_SEL_DISTableAdapter = null;
            this.tableAdapterManager.PRFTableAdapter = null;
            this.tableAdapterManager.PRSTableAdapter = null;
            this.tableAdapterManager.PRTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZMSLTableAdapter = null;
            // 
            // obsdGridControl
            // 
            this.obsdGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.obsdGridControl.DataSource = this.oBSDBindingSource;
            this.obsdGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obsdGridControl.Location = new System.Drawing.Point(0, 0);
            this.obsdGridControl.MainView = this.obsdGridView;
            this.obsdGridControl.Name = "obsdGridControl";
            this.obsdGridControl.Size = new System.Drawing.Size(597, 332);
            this.obsdGridControl.TabIndex = 2;
            this.obsdGridControl.Tag = "OBSD";
            this.obsdGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.obsdGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createHouseToolStripMenuItem,
            this.houseToolStripMenuItem,
            this.stokGirisToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(146, 92);
            // 
            // createHouseToolStripMenuItem
            // 
            this.createHouseToolStripMenuItem.Name = "createHouseToolStripMenuItem";
            this.createHouseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createHouseToolStripMenuItem.Text = "Create House";
            this.createHouseToolStripMenuItem.Click += new System.EventHandler(this.createHouseToolStripMenuItem_Click);
            // 
            // houseToolStripMenuItem
            // 
            this.houseToolStripMenuItem.Name = "houseToolStripMenuItem";
            this.houseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.houseToolStripMenuItem.Text = "House";
            this.houseToolStripMenuItem.Click += new System.EventHandler(this.houseToolStripMenuItem_Click);
            // 
            // obsdGridView
            // 
            this.obsdGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOBSDID,
            this.colPRTNO,
            this.colSITENO,
            this.colDSTLABID,
            this.colGRSTRH,
            this.colSTKNO,
            this.colOPHID});
            this.obsdGridView.GridControl = this.obsdGridControl;
            this.obsdGridView.Name = "obsdGridView";
            this.obsdGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSTKNO, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.obsdGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.obsdGridView_ShowingEditor);
            this.obsdGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.obsdGridView_InitNewRow);
            // 
            // colOBSDID
            // 
            this.colOBSDID.FieldName = "OBSDID";
            this.colOBSDID.Name = "colOBSDID";
            this.colOBSDID.OptionsColumn.AllowEdit = false;
            this.colOBSDID.OptionsColumn.AllowFocus = false;
            this.colOBSDID.Visible = true;
            this.colOBSDID.VisibleIndex = 0;
            // 
            // colPRTNO
            // 
            this.colPRTNO.Caption = "PrtNo";
            this.colPRTNO.FieldName = "PRTNO";
            this.colPRTNO.Name = "colPRTNO";
            this.colPRTNO.OptionsColumn.AllowEdit = false;
            this.colPRTNO.OptionsColumn.AllowFocus = false;
            this.colPRTNO.Visible = true;
            this.colPRTNO.VisibleIndex = 1;
            // 
            // colSITENO
            // 
            this.colSITENO.Caption = "SiteNo";
            this.colSITENO.FieldName = "SITENO";
            this.colSITENO.Name = "colSITENO";
            this.colSITENO.OptionsColumn.AllowEdit = false;
            this.colSITENO.OptionsColumn.AllowFocus = false;
            this.colSITENO.Visible = true;
            this.colSITENO.VisibleIndex = 2;
            // 
            // colDSTLABID
            // 
            this.colDSTLABID.Caption = "DstLab";
            this.colDSTLABID.FieldName = "DSTLABID";
            this.colDSTLABID.Name = "colDSTLABID";
            this.colDSTLABID.OptionsColumn.AllowEdit = false;
            this.colDSTLABID.OptionsColumn.AllowFocus = false;
            this.colDSTLABID.Visible = true;
            this.colDSTLABID.VisibleIndex = 3;
            // 
            // colSTKNO
            // 
            this.colSTKNO.Caption = "StokNo";
            this.colSTKNO.FieldName = "STKNO";
            this.colSTKNO.Name = "colSTKNO";
            this.colSTKNO.OptionsColumn.AllowEdit = false;
            this.colSTKNO.Visible = true;
            this.colSTKNO.VisibleIndex = 5;
            // 
            // colOPHID
            // 
            this.colOPHID.Caption = "HouseID";
            this.colOPHID.FieldName = "OPHID";
            this.colOPHID.Name = "colOPHID";
            this.colOPHID.OptionsColumn.AllowEdit = false;
            this.colOPHID.Visible = true;
            this.colOPHID.VisibleIndex = 6;
            // 
            // dockManager
            // 
            this.dockManager.DockingOptions.HideImmediatelyOnAutoHide = true;
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
            // colGRSTRH
            // 
            this.colGRSTRH.Caption = "GrsTrh";
            this.colGRSTRH.FieldName = "GRSTRH";
            this.colGRSTRH.Name = "colGRSTRH";
            this.colGRSTRH.OptionsColumn.AllowEdit = false;
            this.colGRSTRH.Visible = true;
            this.colGRSTRH.VisibleIndex = 4;
            // 
            // stokGirisToolStripMenuItem
            // 
            this.stokGirisToolStripMenuItem.Name = "stokGirisToolStripMenuItem";
            this.stokGirisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stokGirisToolStripMenuItem.Text = "Stok Giris";
            this.stokGirisToolStripMenuItem.Click += new System.EventHandler(this.stokGirisToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // obsdXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 332);
            this.Controls.Add(this.obsdGridControl);
            this.Name = "obsdXF";
            this.Tag = "";
            this.Text = "Study Stok";
            this.Load += new System.EventHandler(this.obsdXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBSDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsdGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.obsdGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpsDataSet opsDataSet;
        private System.Windows.Forms.BindingSource oBSDBindingSource;
        private OpsDataSetTableAdapters.OBSDTableAdapter oBSDTableAdapter;
        private OpsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl obsdGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView obsdGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colOBSDID;
        private DevExpress.XtraGrid.Columns.GridColumn colPRTNO;
        private DevExpress.XtraGrid.Columns.GridColumn colSITENO;
        private DevExpress.XtraGrid.Columns.GridColumn colDSTLABID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTKNO;
        private DevExpress.XtraGrid.Columns.GridColumn colOPHID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem createHouseToolStripMenuItem;
        private OpsDataSetTableAdapters.OpsQueriesTableAdapter opsQueriesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem houseToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private System.Windows.Forms.ToolStripMenuItem stokGirisToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colGRSTRH;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}
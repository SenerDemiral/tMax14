namespace Agn
{
    partial class ophXF
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
            this.agnDataSet = new Agn.AgnDataSet();
            this.ophSelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ophSelTableAdapter = new Agn.AgnDataSetTableAdapters.WAN_AGN_OPH_SELTableAdapter();
            this.ophSelGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.attachmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ophSelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOPHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSTUTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPSTUTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.packagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.agnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophSelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophSelGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ophSelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.SuspendLayout();
            // 
            // agnDataSet
            // 
            this.agnDataSet.DataSetName = "AgnDataSet";
            this.agnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ophSelBindingSource
            // 
            this.ophSelBindingSource.DataMember = "WAN_AGN_OPH_SEL";
            this.ophSelBindingSource.DataSource = this.agnDataSet;
            // 
            // ophSelTableAdapter
            // 
            this.ophSelTableAdapter.ClearBeforeFill = true;
            // 
            // ophSelGridControl
            // 
            this.ophSelGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.ophSelGridControl.DataSource = this.ophSelBindingSource;
            this.ophSelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ophSelGridControl.Location = new System.Drawing.Point(0, 0);
            this.ophSelGridControl.MainView = this.ophSelGridView;
            this.ophSelGridControl.Name = "ophSelGridControl";
            this.ophSelGridControl.Size = new System.Drawing.Size(898, 288);
            this.ophSelGridControl.TabIndex = 2;
            this.ophSelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ophSelGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attachmentsToolStripMenuItem,
            this.packagesToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 70);
            // 
            // attachmentsToolStripMenuItem
            // 
            this.attachmentsToolStripMenuItem.Name = "attachmentsToolStripMenuItem";
            this.attachmentsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.attachmentsToolStripMenuItem.Text = "Attachments";
            this.attachmentsToolStripMenuItem.Click += new System.EventHandler(this.attachmentsToolStripMenuItem_Click);
            // 
            // ophSelGridView
            // 
            this.ophSelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOPHID,
            this.colOPMID,
            this.colROT,
            this.colMOT,
            this.colORG,
            this.colDST,
            this.colREFNO,
            this.colNSTU,
            this.colNSTUTS,
            this.colPSTU,
            this.colPSTUTS});
            this.ophSelGridView.GridControl = this.ophSelGridControl;
            this.ophSelGridView.Name = "ophSelGridView";
            this.ophSelGridView.OptionsBehavior.Editable = false;
            // 
            // colOPHID
            // 
            this.colOPHID.FieldName = "OPHID";
            this.colOPHID.Name = "colOPHID";
            this.colOPHID.OptionsColumn.FixedWidth = true;
            this.colOPHID.Visible = true;
            this.colOPHID.VisibleIndex = 0;
            // 
            // colOPMID
            // 
            this.colOPMID.FieldName = "OPMID";
            this.colOPMID.Name = "colOPMID";
            this.colOPMID.OptionsColumn.FixedWidth = true;
            this.colOPMID.Visible = true;
            this.colOPMID.VisibleIndex = 1;
            // 
            // colROT
            // 
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.OptionsColumn.FixedWidth = true;
            this.colROT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 2;
            this.colROT.Width = 36;
            // 
            // colMOT
            // 
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.OptionsColumn.FixedWidth = true;
            this.colMOT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 3;
            this.colMOT.Width = 34;
            // 
            // colORG
            // 
            this.colORG.FieldName = "ORG";
            this.colORG.Name = "colORG";
            this.colORG.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colORG.Visible = true;
            this.colORG.VisibleIndex = 4;
            this.colORG.Width = 92;
            // 
            // colDST
            // 
            this.colDST.FieldName = "DST";
            this.colDST.Name = "colDST";
            this.colDST.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDST.Visible = true;
            this.colDST.VisibleIndex = 5;
            this.colDST.Width = 92;
            // 
            // colREFNO
            // 
            this.colREFNO.FieldName = "REFNO";
            this.colREFNO.Name = "colREFNO";
            this.colREFNO.Visible = true;
            this.colREFNO.VisibleIndex = 6;
            this.colREFNO.Width = 92;
            // 
            // colNSTU
            // 
            this.colNSTU.FieldName = "NSTU";
            this.colNSTU.Name = "colNSTU";
            this.colNSTU.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colNSTU.Visible = true;
            this.colNSTU.VisibleIndex = 7;
            this.colNSTU.Width = 92;
            // 
            // colNSTUTS
            // 
            this.colNSTUTS.FieldName = "NSTUTS";
            this.colNSTUTS.Name = "colNSTUTS";
            this.colNSTUTS.Visible = true;
            this.colNSTUTS.VisibleIndex = 8;
            this.colNSTUTS.Width = 92;
            // 
            // colPSTU
            // 
            this.colPSTU.FieldName = "PSTU";
            this.colPSTU.Name = "colPSTU";
            this.colPSTU.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPSTU.Visible = true;
            this.colPSTU.VisibleIndex = 9;
            this.colPSTU.Width = 92;
            // 
            // colPSTUTS
            // 
            this.colPSTUTS.FieldName = "PSTUTS";
            this.colPSTUTS.Name = "colPSTUTS";
            this.colPSTUTS.Visible = true;
            this.colPSTUTS.VisibleIndex = 10;
            this.colPSTUTS.Width = 108;
            // 
            // packagesToolStripMenuItem
            // 
            this.packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            this.packagesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.packagesToolStripMenuItem.Text = "Packages";
            this.packagesToolStripMenuItem.Click += new System.EventHandler(this.packagesToolStripMenuItem_Click);
            // 
            // dockManager
            // 
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
            // ophXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 288);
            this.Controls.Add(this.ophSelGridControl);
            this.Name = "ophXF";
            this.Text = "ophXF";
            this.Load += new System.EventHandler(this.ophXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophSelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophSelGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ophSelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AgnDataSet agnDataSet;
        private System.Windows.Forms.BindingSource ophSelBindingSource;
        private AgnDataSetTableAdapters.WAN_AGN_OPH_SELTableAdapter ophSelTableAdapter;
        private DevExpress.XtraGrid.GridControl ophSelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ophSelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colOPHID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPMID;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colORG;
        private DevExpress.XtraGrid.Columns.GridColumn colDST;
        private DevExpress.XtraGrid.Columns.GridColumn colREFNO;
        private DevExpress.XtraGrid.Columns.GridColumn colNSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colNSTUTS;
        private DevExpress.XtraGrid.Columns.GridColumn colPSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colPSTUTS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem attachmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packagesToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
    }
}
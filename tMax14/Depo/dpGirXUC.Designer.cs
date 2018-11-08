namespace tMax14.Depo
{
    partial class dpGirXUC
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
            this.depoDataSet = new tMax14.Depo.DepoDataSet();
            this.dpgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dpgTableAdapter = new tMax14.Depo.DepoDataSetTableAdapters.DPGTableAdapter();
            this.tableAdapterManager = new tMax14.Depo.DepoDataSetTableAdapters.TableAdapterManager();
            this.dpgGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dpgGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDPGID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRSTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPHM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTBLB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTTXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpgGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpgGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.SuspendLayout();
            // 
            // depoDataSet
            // 
            this.depoDataSet.DataSetName = "DepoDataSet";
            this.depoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dpgBindingSource
            // 
            this.dpgBindingSource.DataMember = "DPG";
            this.dpgBindingSource.DataSource = this.depoDataSet;
            // 
            // dpgTableAdapter
            // 
            this.dpgTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DPCATableAdapter = null;
            this.tableAdapterManager.DPCTableAdapter = null;
            this.tableAdapterManager.DPGATableAdapter = null;
            this.tableAdapterManager.DPGTableAdapter = this.dpgTableAdapter;
            this.tableAdapterManager.GTPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Depo.DepoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dpgGridControl
            // 
            this.dpgGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.dpgGridControl.DataMember = "DPG";
            this.dpgGridControl.DataSource = this.depoDataSet;
            this.dpgGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpgGridControl.Location = new System.Drawing.Point(0, 0);
            this.dpgGridControl.MainView = this.dpgGridView;
            this.dpgGridControl.Name = "dpgGridControl";
            this.dpgGridControl.Size = new System.Drawing.Size(491, 290);
            this.dpgGridControl.TabIndex = 1;
            this.dpgGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dpgGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableExtensionsToolStripMenuItem,
            this.attachmentsToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(156, 48);
            // 
            // tableExtensionsToolStripMenuItem
            // 
            this.tableExtensionsToolStripMenuItem.Name = "tableExtensionsToolStripMenuItem";
            this.tableExtensionsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.tableExtensionsToolStripMenuItem.Text = "Table extensions";
            this.tableExtensionsToolStripMenuItem.Click += new System.EventHandler(this.tableExtensionsToolStripMenuItem_Click);
            // 
            // attachmentsToolStripMenuItem
            // 
            this.attachmentsToolStripMenuItem.Name = "attachmentsToolStripMenuItem";
            this.attachmentsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.attachmentsToolStripMenuItem.Text = "Attachments";
            this.attachmentsToolStripMenuItem.Click += new System.EventHandler(this.attachmentsToolStripMenuItem_Click);
            // 
            // dpgGridView
            // 
            this.dpgGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDPGID,
            this.colGRSTRH,
            this.colRAF,
            this.colOPHM,
            this.colOPID,
            this.colXTBLB,
            this.colXTTXT});
            this.dpgGridView.GridControl = this.dpgGridControl;
            this.dpgGridView.Name = "dpgGridView";
            this.dpgGridView.Tag = "DPG";
            this.dpgGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.dpgGridView_InitNewRow);
            this.dpgGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dpgGridView_FocusedRowChanged);
            this.dpgGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.dpgGridView_ValidateRow);
            // 
            // colDPGID
            // 
            this.colDPGID.Caption = "DPGid";
            this.colDPGID.FieldName = "DPGID";
            this.colDPGID.Name = "colDPGID";
            this.colDPGID.Visible = true;
            this.colDPGID.VisibleIndex = 0;
            this.colDPGID.Width = 67;
            // 
            // colGRSTRH
            // 
            this.colGRSTRH.Caption = "GrşTrh";
            this.colGRSTRH.FieldName = "GRSTRH";
            this.colGRSTRH.Name = "colGRSTRH";
            this.colGRSTRH.Visible = true;
            this.colGRSTRH.VisibleIndex = 1;
            this.colGRSTRH.Width = 80;
            // 
            // colRAF
            // 
            this.colRAF.Caption = "Raf";
            this.colRAF.FieldName = "RAF";
            this.colRAF.Name = "colRAF";
            this.colRAF.Visible = true;
            this.colRAF.VisibleIndex = 2;
            this.colRAF.Width = 64;
            // 
            // colOPHM
            // 
            this.colOPHM.FieldName = "OPHM";
            this.colOPHM.Name = "colOPHM";
            this.colOPHM.Visible = true;
            this.colOPHM.VisibleIndex = 3;
            this.colOPHM.Width = 64;
            // 
            // colOPID
            // 
            this.colOPID.Caption = "HMid";
            this.colOPID.FieldName = "OPID";
            this.colOPID.Name = "colOPID";
            this.colOPID.Visible = true;
            this.colOPID.VisibleIndex = 4;
            this.colOPID.Width = 64;
            // 
            // colXTBLB
            // 
            this.colXTBLB.Caption = "xtBlb";
            this.colXTBLB.FieldName = "XTBLB";
            this.colXTBLB.Name = "colXTBLB";
            this.colXTBLB.OptionsColumn.AllowEdit = false;
            this.colXTBLB.Visible = true;
            this.colXTBLB.VisibleIndex = 5;
            this.colXTBLB.Width = 64;
            // 
            // colXTTXT
            // 
            this.colXTTXT.Caption = "xtTxt";
            this.colXTTXT.FieldName = "XTTXT";
            this.colXTTXT.Name = "colXTTXT";
            this.colXTTXT.OptionsColumn.AllowEdit = false;
            this.colXTTXT.Visible = true;
            this.colXTTXT.VisibleIndex = 6;
            this.colXTTXT.Width = 70;
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
            this.dockManager.ClosedPanel += new DevExpress.XtraBars.Docking.DockPanelEventHandler(this.dockManager_ClosedPanel);
            // 
            // dpGirXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dpgGridControl);
            this.Name = "dpGirXUC";
            this.Size = new System.Drawing.Size(491, 290);
            this.Load += new System.EventHandler(this.dpGirXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpgGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dpgGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DepoDataSet depoDataSet;
        private System.Windows.Forms.BindingSource dpgBindingSource;
        private DepoDataSetTableAdapters.DPGTableAdapter dpgTableAdapter;
        private DepoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl dpgGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView dpgGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDPGID;
        private DevExpress.XtraGrid.Columns.GridColumn colGRSTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colRAF;
        private DevExpress.XtraGrid.Columns.GridColumn colOPHM;
        private DevExpress.XtraGrid.Columns.GridColumn colOPID;
        private DevExpress.XtraGrid.Columns.GridColumn colXTBLB;
        private DevExpress.XtraGrid.Columns.GridColumn colXTTXT;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tableExtensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachmentsToolStripMenuItem;
    }
}

namespace tMax14.Depo
{
    partial class dpCikXUC
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
            this.dpcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dpcTableAdapter = new tMax14.Depo.DepoDataSetTableAdapters.DPCTableAdapter();
            this.tableAdapterManager = new tMax14.Depo.DepoDataSetTableAdapters.TableAdapterManager();
            this.dpcGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dpcGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDPCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCKSTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPHM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTBLB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTTXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpcGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpcGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.SuspendLayout();
            // 
            // depoDataSet
            // 
            this.depoDataSet.DataSetName = "DepoDataSet";
            this.depoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dpcBindingSource
            // 
            this.dpcBindingSource.DataMember = "DPC";
            this.dpcBindingSource.DataSource = this.depoDataSet;
            // 
            // dpcTableAdapter
            // 
            this.dpcTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DPCATableAdapter = null;
            this.tableAdapterManager.DPCTableAdapter = this.dpcTableAdapter;
            this.tableAdapterManager.DPGATableAdapter = null;
            this.tableAdapterManager.DPGTableAdapter = null;
            this.tableAdapterManager.GTPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Depo.DepoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dpcGridControl
            // 
            this.dpcGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.dpcGridControl.DataSource = this.dpcBindingSource;
            this.dpcGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpcGridControl.Location = new System.Drawing.Point(0, 0);
            this.dpcGridControl.MainView = this.dpcGridView;
            this.dpcGridControl.Name = "dpcGridControl";
            this.dpcGridControl.Size = new System.Drawing.Size(388, 308);
            this.dpcGridControl.TabIndex = 1;
            this.dpcGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dpcGridView});
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
            // dpcGridView
            // 
            this.dpcGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDPCID,
            this.colCKSTRH,
            this.colOPHM,
            this.colOPID,
            this.colXTBLB,
            this.colXTTXT});
            this.dpcGridView.GridControl = this.dpcGridControl;
            this.dpcGridView.Name = "dpcGridView";
            this.dpcGridView.Tag = "DPC";
            this.dpcGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.dpcGridView_InitNewRow);
            this.dpcGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dpcGridView_FocusedRowChanged);
            // 
            // colDPCID
            // 
            this.colDPCID.Caption = "DPCid";
            this.colDPCID.FieldName = "DPCID";
            this.colDPCID.Name = "colDPCID";
            this.colDPCID.Visible = true;
            this.colDPCID.VisibleIndex = 0;
            this.colDPCID.Width = 92;
            // 
            // colCKSTRH
            // 
            this.colCKSTRH.Caption = "ÇksTrh";
            this.colCKSTRH.FieldName = "CKSTRH";
            this.colCKSTRH.Name = "colCKSTRH";
            this.colCKSTRH.Visible = true;
            this.colCKSTRH.VisibleIndex = 1;
            this.colCKSTRH.Width = 92;
            // 
            // colOPHM
            // 
            this.colOPHM.FieldName = "OPHM";
            this.colOPHM.Name = "colOPHM";
            this.colOPHM.Visible = true;
            this.colOPHM.VisibleIndex = 2;
            // 
            // colOPID
            // 
            this.colOPID.Caption = "HMid";
            this.colOPID.FieldName = "OPID";
            this.colOPID.Name = "colOPID";
            this.colOPID.Visible = true;
            this.colOPID.VisibleIndex = 3;
            this.colOPID.Width = 145;
            // 
            // colXTBLB
            // 
            this.colXTBLB.Caption = "xtBlb";
            this.colXTBLB.FieldName = "XTBLB";
            this.colXTBLB.Name = "colXTBLB";
            this.colXTBLB.OptionsColumn.AllowEdit = false;
            this.colXTBLB.Visible = true;
            this.colXTBLB.VisibleIndex = 4;
            // 
            // colXTTXT
            // 
            this.colXTTXT.Caption = "xtTxt";
            this.colXTTXT.FieldName = "XTTXT";
            this.colXTTXT.Name = "colXTTXT";
            this.colXTTXT.OptionsColumn.AllowEdit = false;
            this.colXTTXT.Visible = true;
            this.colXTTXT.VisibleIndex = 5;
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
            // dpCikXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dpcGridControl);
            this.Name = "dpCikXUC";
            this.Size = new System.Drawing.Size(388, 308);
            this.Load += new System.EventHandler(this.dpCikXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpcGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dpcGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DepoDataSet depoDataSet;
        private System.Windows.Forms.BindingSource dpcBindingSource;
        private DepoDataSetTableAdapters.DPCTableAdapter dpcTableAdapter;
        private DepoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl dpcGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView dpcGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDPCID;
        private DevExpress.XtraGrid.Columns.GridColumn colCKSTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colOPHM;
        private DevExpress.XtraGrid.Columns.GridColumn colOPID;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tableExtensionsToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colXTBLB;
        private DevExpress.XtraGrid.Columns.GridColumn colXTTXT;
        private System.Windows.Forms.ToolStripMenuItem attachmentsToolStripMenuItem;
    }
}

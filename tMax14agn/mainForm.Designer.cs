namespace tMax14agn
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.menuDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ophSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.opmSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.mainPersistentRepository = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.OPSTNrepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.oPSTNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new tMax14agn.DataSet();
            this.OPSTPrepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.oPSTPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPSTNTableAdapter = new tMax14agn.DataSetTableAdapters.OPSTNTableAdapter();
            this.oPSTPTableAdapter = new tMax14agn.DataSetTableAdapters.OPSTPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.menuDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OPSTNrepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPSTNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPSTPrepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPSTPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager
            // 
            this.documentManager.MdiParent = this;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
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
            this.hideContainerLeft.Controls.Add(this.menuDockPanel);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 603);
            // 
            // menuDockPanel
            // 
            this.menuDockPanel.Controls.Add(this.dockPanel1_Container);
            this.menuDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.menuDockPanel.ID = new System.Guid("8d7f192c-c0c8-4d50-80fe-a05d3c14ad4f");
            this.menuDockPanel.Location = new System.Drawing.Point(0, 0);
            this.menuDockPanel.Name = "menuDockPanel";
            this.menuDockPanel.Options.ShowCloseButton = false;
            this.menuDockPanel.Options.ShowMaximizeButton = false;
            this.menuDockPanel.OriginalSize = new System.Drawing.Size(103, 200);
            this.menuDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.menuDockPanel.SavedIndex = 0;
            this.menuDockPanel.Size = new System.Drawing.Size(103, 603);
            this.menuDockPanel.Text = "Menu";
            this.menuDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.ophSimpleButton);
            this.dockPanel1_Container.Controls.Add(this.opmSimpleButton);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(95, 576);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // ophSimpleButton
            // 
            this.ophSimpleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ophSimpleButton.Location = new System.Drawing.Point(0, 23);
            this.ophSimpleButton.Name = "ophSimpleButton";
            this.ophSimpleButton.Size = new System.Drawing.Size(95, 23);
            this.ophSimpleButton.TabIndex = 3;
            this.ophSimpleButton.Text = "Houses";
            this.ophSimpleButton.Click += new System.EventHandler(this.ophSimpleButton_Click);
            // 
            // opmSimpleButton
            // 
            this.opmSimpleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.opmSimpleButton.Location = new System.Drawing.Point(0, 0);
            this.opmSimpleButton.Name = "opmSimpleButton";
            this.opmSimpleButton.Size = new System.Drawing.Size(95, 23);
            this.opmSimpleButton.TabIndex = 2;
            this.opmSimpleButton.Text = "Masters";
            this.opmSimpleButton.Click += new System.EventHandler(this.opmSimpleButton_Click);
            // 
            // mainPersistentRepository
            // 
            this.mainPersistentRepository.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.OPSTNrepositoryItemLookUpEdit,
            this.OPSTPrepositoryItemLookUpEdit});
            // 
            // OPSTNrepositoryItemLookUpEdit
            // 
            this.OPSTNrepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OPSTNrepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STU", "STU", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AD", "Statu", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.OPSTNrepositoryItemLookUpEdit.DataSource = this.oPSTNBindingSource;
            this.OPSTNrepositoryItemLookUpEdit.DisplayMember = "AD";
            this.OPSTNrepositoryItemLookUpEdit.Name = "OPSTNrepositoryItemLookUpEdit";
            this.OPSTNrepositoryItemLookUpEdit.NullText = "";
            this.OPSTNrepositoryItemLookUpEdit.ValueMember = "STU";
            // 
            // oPSTNBindingSource
            // 
            this.oPSTNBindingSource.DataMember = "OPSTN";
            this.oPSTNBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OPSTPrepositoryItemLookUpEdit
            // 
            this.OPSTPrepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OPSTPrepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STU", "STU", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AD", "Problem", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.OPSTPrepositoryItemLookUpEdit.DataSource = this.oPSTPBindingSource;
            this.OPSTPrepositoryItemLookUpEdit.DisplayMember = "AD";
            this.OPSTPrepositoryItemLookUpEdit.Name = "OPSTPrepositoryItemLookUpEdit";
            this.OPSTPrepositoryItemLookUpEdit.NullText = "";
            this.OPSTPrepositoryItemLookUpEdit.ValueMember = "STU";
            // 
            // oPSTPBindingSource
            // 
            this.oPSTPBindingSource.DataMember = "OPSTP";
            this.oPSTPBindingSource.DataSource = this.dataSet;
            // 
            // oPSTNTableAdapter
            // 
            this.oPSTNTableAdapter.ClearBeforeFill = true;
            // 
            // oPSTPTableAdapter
            // 
            this.oPSTPTableAdapter.ClearBeforeFill = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 603);
            this.Controls.Add(this.hideContainerLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.Text = "tMax14 Agents";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.menuDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OPSTNrepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPSTNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPSTPrepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPSTPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Docking.DockPanel menuDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraEditors.SimpleButton opmSimpleButton;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource oPSTNBindingSource;
        private DataSetTableAdapters.OPSTNTableAdapter oPSTNTableAdapter;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit OPSTNrepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource oPSTPBindingSource;
        private DataSetTableAdapters.OPSTPTableAdapter oPSTPTableAdapter;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit OPSTPrepositoryItemLookUpEdit;
        public DevExpress.XtraEditors.Repository.PersistentRepository mainPersistentRepository;
        private DevExpress.XtraEditors.SimpleButton ophSimpleButton;

    }
}
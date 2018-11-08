namespace tMax14mnf
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.persistentRepository = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.FRTrepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.frtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new tMax14mnf.DataSet();
            this.TOSrepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xGTTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PAGrepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xGTPAGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new tMax14mnf.DataSet();
            this.PORrepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xGTPORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MOTrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.TOPrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.frtTableAdapter = new tMax14mnf.DataSetTableAdapters.FRTTableAdapter();
            this.xGTTOSTableAdapter = new tMax14mnf.DataSetTableAdapters.XGTTOSTableAdapter();
            this.xGTPAGTableAdapter = new tMax14mnf.DataSetTableAdapters.XGTPAGTableAdapter();
            this.xGTPORTableAdapter = new tMax14mnf.DataSetTableAdapters.XGTPORTableAdapter();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.menuDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ophoSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.queriesTableAdapter = new tMax14mnf.DataSetTableAdapters.QueriesTableAdapter();
            this.PAGrepositoryItemCheckedComboBoxEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.FRTrepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOSrepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xGTTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAGrepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xGTPAGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PORrepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xGTPORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MOTrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOPrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.menuDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAGrepositoryItemCheckedComboBoxEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // persistentRepository
            // 
            this.persistentRepository.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.FRTrepositoryItemLookUpEdit,
            this.TOSrepositoryItemLookUpEdit,
            this.PAGrepositoryItemLookUpEdit,
            this.PORrepositoryItemLookUpEdit,
            this.MOTrepositoryItemImageComboBox,
            this.TOPrepositoryItemImageComboBox,
            this.PAGrepositoryItemCheckedComboBoxEdit});
            // 
            // FRTrepositoryItemLookUpEdit
            // 
            this.FRTrepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FRTrepositoryItemLookUpEdit.DataSource = this.frtBindingSource;
            this.FRTrepositoryItemLookUpEdit.DisplayMember = "ADN";
            this.FRTrepositoryItemLookUpEdit.Name = "FRTrepositoryItemLookUpEdit";
            this.FRTrepositoryItemLookUpEdit.NullText = "?";
            this.FRTrepositoryItemLookUpEdit.ValueMember = "FRTID";
            // 
            // frtBindingSource
            // 
            this.frtBindingSource.DataMember = "FRT";
            this.frtBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TOSrepositoryItemLookUpEdit
            // 
            this.TOSrepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TOSrepositoryItemLookUpEdit.DataSource = this.xGTTOSBindingSource;
            this.TOSrepositoryItemLookUpEdit.DisplayMember = "VAL";
            this.TOSrepositoryItemLookUpEdit.Name = "TOSrepositoryItemLookUpEdit";
            this.TOSrepositoryItemLookUpEdit.NullText = "?";
            this.TOSrepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // xGTTOSBindingSource
            // 
            this.xGTTOSBindingSource.DataMember = "XGTTOS";
            this.xGTTOSBindingSource.DataSource = this.dataSet;
            // 
            // PAGrepositoryItemLookUpEdit
            // 
            this.PAGrepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PAGrepositoryItemLookUpEdit.DataSource = this.xGTPAGBindingSource;
            this.PAGrepositoryItemLookUpEdit.DisplayMember = "VAL";
            this.PAGrepositoryItemLookUpEdit.Name = "PAGrepositoryItemLookUpEdit";
            this.PAGrepositoryItemLookUpEdit.NullText = "?";
            this.PAGrepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // xGTPAGBindingSource
            // 
            this.xGTPAGBindingSource.DataMember = "XGTPAG";
            this.xGTPAGBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PORrepositoryItemLookUpEdit
            // 
            this.PORrepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PORrepositoryItemLookUpEdit.DataSource = this.xGTPORBindingSource;
            this.PORrepositoryItemLookUpEdit.DisplayMember = "VAL";
            this.PORrepositoryItemLookUpEdit.Name = "PORrepositoryItemLookUpEdit";
            this.PORrepositoryItemLookUpEdit.NullText = "?";
            this.PORrepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // xGTPORBindingSource
            // 
            this.xGTPORBindingSource.DataMember = "XGTPOR";
            this.xGTPORBindingSource.DataSource = this.dataSet;
            // 
            // MOTrepositoryItemImageComboBox
            // 
            this.MOTrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MOTrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Air", "A", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "T", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sea", "S", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Rail", "R", -1)});
            this.MOTrepositoryItemImageComboBox.Name = "MOTrepositoryItemImageComboBox";
            // 
            // TOPrepositoryItemImageComboBox
            // 
            this.TOPrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TOPrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Koli", "BOX", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("GOH1", "GOH1", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("GOH2", "GOH2", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("GOH3", "GOH3", -1)});
            this.TOPrepositoryItemImageComboBox.Name = "TOPrepositoryItemImageComboBox";
            // 
            // frtTableAdapter
            // 
            this.frtTableAdapter.ClearBeforeFill = true;
            // 
            // xGTTOSTableAdapter
            // 
            this.xGTTOSTableAdapter.ClearBeforeFill = true;
            // 
            // xGTPAGTableAdapter
            // 
            this.xGTPAGTableAdapter.ClearBeforeFill = true;
            // 
            // xGTPORTableAdapter
            // 
            this.xGTPORTableAdapter.ClearBeforeFill = true;
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.menuDockPanel});
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
            // menuDockPanel
            // 
            this.menuDockPanel.Controls.Add(this.dockPanel1_Container);
            this.menuDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.menuDockPanel.ID = new System.Guid("eea7b0d7-9487-47ec-93fa-da2900c1bf91");
            this.menuDockPanel.Location = new System.Drawing.Point(0, 0);
            this.menuDockPanel.Name = "menuDockPanel";
            this.menuDockPanel.Options.ShowCloseButton = false;
            this.menuDockPanel.OriginalSize = new System.Drawing.Size(87, 200);
            this.menuDockPanel.Size = new System.Drawing.Size(87, 273);
            this.menuDockPanel.Text = "Menu";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.ophoSimpleButton);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(79, 246);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // ophoSimpleButton
            // 
            this.ophoSimpleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ophoSimpleButton.Location = new System.Drawing.Point(0, 0);
            this.ophoSimpleButton.Name = "ophoSimpleButton";
            this.ophoSimpleButton.Size = new System.Drawing.Size(79, 23);
            this.ophoSimpleButton.TabIndex = 0;
            this.ophoSimpleButton.Text = "Orders";
            this.ophoSimpleButton.Click += new System.EventHandler(this.ophoSimpleButton_Click);
            // 
            // documentManager
            // 
            this.documentManager.MdiParent = this;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // PAGrepositoryItemCheckedComboBoxEdit
            // 
            this.PAGrepositoryItemCheckedComboBoxEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PAGrepositoryItemCheckedComboBoxEdit.DataSource = this.xGTPAGBindingSource;
            this.PAGrepositoryItemCheckedComboBoxEdit.DisplayMember = "VAL";
            this.PAGrepositoryItemCheckedComboBoxEdit.Name = "PAGrepositoryItemCheckedComboBoxEdit";
            this.PAGrepositoryItemCheckedComboBoxEdit.ValueMember = "ID";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 273);
            this.Controls.Add(this.menuDockPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Manufacturer Order Entry";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FRTrepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOSrepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xGTTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAGrepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xGTPAGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PORrepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xGTPORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MOTrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOPrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.menuDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAGrepositoryItemCheckedComboBoxEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource frtBindingSource;
        private DataSetTableAdapters.FRTTableAdapter frtTableAdapter;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit FRTrepositoryItemLookUpEdit;
        public DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository;
        private System.Windows.Forms.BindingSource xGTTOSBindingSource;
        private DataSetTableAdapters.XGTTOSTableAdapter xGTTOSTableAdapter;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit TOSrepositoryItemLookUpEdit;
        private DataSet dataSet1;
        private System.Windows.Forms.BindingSource xGTPAGBindingSource;
        private DataSetTableAdapters.XGTPAGTableAdapter xGTPAGTableAdapter;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit PAGrepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource xGTPORBindingSource;
        private DataSetTableAdapters.XGTPORTableAdapter xGTPORTableAdapter;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit PORrepositoryItemLookUpEdit;
        public DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox MOTrepositoryItemImageComboBox;
        public DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TOPrepositoryItemImageComboBox;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel menuDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.SimpleButton ophoSimpleButton;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        public DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit PAGrepositoryItemCheckedComboBoxEdit;
    }
}
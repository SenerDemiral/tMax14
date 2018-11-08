namespace tMax14dron
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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.BJlistBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BJupdTStextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BJselAktifGridControl = new DevExpress.XtraGrid.GridControl();
            this.BJselAktifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new tMax14dron.DataSet();
            this.BJselAktifGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colREFTBL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBJDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBJDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIPAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENDTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKIMLERE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.BAlistBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.BJlayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.BAlayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.BAbackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.BJbackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.queriesTableAdapter = new tMax14dron.DataSetTableAdapters.QueriesTableAdapter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BJselAktifTableAdapter = new tMax14dron.DataSetTableAdapters.BJ_SEL_AKTIFTableAdapter();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BJlistBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BJupdTStextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BJselAktifGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BJselAktifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BJselAktifGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAlistBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BJlayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAlayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "tMax14dron";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.denemeToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(114, 92);
            // 
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.denemeToolStripMenuItem.Text = "Deneme";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BJlistBoxControl);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.BJupdTStextEdit);
            this.layoutControl1.Controls.Add(this.BJselAktifGridControl);
            this.layoutControl1.Controls.Add(this.BAsimpleButton);
            this.layoutControl1.Controls.Add(this.BAlistBoxControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(849, 164, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1071, 606);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BJlistBoxControl
            // 
            this.BJlistBoxControl.Location = new System.Drawing.Point(24, 373);
            this.BJlistBoxControl.Name = "BJlistBoxControl";
            this.BJlistBoxControl.Size = new System.Drawing.Size(1023, 209);
            this.BJlistBoxControl.StyleController = this.layoutControl1;
            this.BJlistBoxControl.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(509, 46);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(538, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BJupdTStextEdit
            // 
            this.BJupdTStextEdit.Location = new System.Drawing.Point(120, 46);
            this.BJupdTStextEdit.Name = "BJupdTStextEdit";
            this.BJupdTStextEdit.Size = new System.Drawing.Size(385, 20);
            this.BJupdTStextEdit.StyleController = this.layoutControl1;
            this.BJupdTStextEdit.TabIndex = 7;
            // 
            // BJselAktifGridControl
            // 
            this.BJselAktifGridControl.DataSource = this.BJselAktifBindingSource;
            this.BJselAktifGridControl.Location = new System.Drawing.Point(24, 72);
            this.BJselAktifGridControl.MainView = this.BJselAktifGridView;
            this.BJselAktifGridControl.Name = "BJselAktifGridControl";
            this.BJselAktifGridControl.Size = new System.Drawing.Size(1023, 281);
            this.BJselAktifGridControl.TabIndex = 6;
            this.BJselAktifGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BJselAktifGridView});
            // 
            // BJselAktifBindingSource
            // 
            this.BJselAktifBindingSource.DataMember = "BJ_SEL_AKTIF";
            this.BJselAktifBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BJselAktifGridView
            // 
            this.BJselAktifGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colREFTBL,
            this.colREFID,
            this.colBJDID,
            this.colBJDAD,
            this.colBIPID,
            this.colBIPAD,
            this.colINSTS,
            this.colENDTS,
            this.colVIA,
            this.colUSR,
            this.colKIMLERE});
            this.BJselAktifGridView.GridControl = this.BJselAktifGridControl;
            this.BJselAktifGridView.Name = "BJselAktifGridView";
            // 
            // colREFTBL
            // 
            this.colREFTBL.FieldName = "REFTBL";
            this.colREFTBL.Name = "colREFTBL";
            this.colREFTBL.Visible = true;
            this.colREFTBL.VisibleIndex = 0;
            // 
            // colREFID
            // 
            this.colREFID.FieldName = "REFID";
            this.colREFID.Name = "colREFID";
            this.colREFID.Visible = true;
            this.colREFID.VisibleIndex = 1;
            // 
            // colBJDID
            // 
            this.colBJDID.FieldName = "BJDID";
            this.colBJDID.Name = "colBJDID";
            this.colBJDID.Visible = true;
            this.colBJDID.VisibleIndex = 2;
            // 
            // colBJDAD
            // 
            this.colBJDAD.FieldName = "BJDAD";
            this.colBJDAD.Name = "colBJDAD";
            this.colBJDAD.Visible = true;
            this.colBJDAD.VisibleIndex = 3;
            // 
            // colBIPID
            // 
            this.colBIPID.FieldName = "BIPID";
            this.colBIPID.Name = "colBIPID";
            this.colBIPID.Visible = true;
            this.colBIPID.VisibleIndex = 4;
            // 
            // colBIPAD
            // 
            this.colBIPAD.FieldName = "BIPAD";
            this.colBIPAD.Name = "colBIPAD";
            this.colBIPAD.Visible = true;
            this.colBIPAD.VisibleIndex = 5;
            // 
            // colINSTS
            // 
            this.colINSTS.FieldName = "INSTS";
            this.colINSTS.Name = "colINSTS";
            this.colINSTS.Visible = true;
            this.colINSTS.VisibleIndex = 6;
            // 
            // colENDTS
            // 
            this.colENDTS.FieldName = "ENDTS";
            this.colENDTS.Name = "colENDTS";
            this.colENDTS.Visible = true;
            this.colENDTS.VisibleIndex = 7;
            // 
            // colVIA
            // 
            this.colVIA.FieldName = "VIA";
            this.colVIA.Name = "colVIA";
            this.colVIA.Visible = true;
            this.colVIA.VisibleIndex = 8;
            // 
            // colUSR
            // 
            this.colUSR.FieldName = "USR";
            this.colUSR.Name = "colUSR";
            this.colUSR.Visible = true;
            this.colUSR.VisibleIndex = 9;
            // 
            // colKIMLERE
            // 
            this.colKIMLERE.FieldName = "KIMLERE";
            this.colKIMLERE.Name = "colKIMLERE";
            this.colKIMLERE.Visible = true;
            this.colKIMLERE.VisibleIndex = 10;
            // 
            // BAsimpleButton
            // 
            this.BAsimpleButton.Location = new System.Drawing.Point(24, 46);
            this.BAsimpleButton.Name = "BAsimpleButton";
            this.BAsimpleButton.Size = new System.Drawing.Size(1023, 22);
            this.BAsimpleButton.StyleController = this.layoutControl1;
            this.BAsimpleButton.TabIndex = 5;
            this.BAsimpleButton.Text = "BA";
            this.BAsimpleButton.Click += new System.EventHandler(this.BAsimpleButton_Click);
            // 
            // BAlistBoxControl
            // 
            this.BAlistBoxControl.Location = new System.Drawing.Point(24, 72);
            this.BAlistBoxControl.Name = "BAlistBoxControl";
            this.BAlistBoxControl.Size = new System.Drawing.Size(1023, 510);
            this.BAlistBoxControl.StyleController = this.layoutControl1;
            this.BAlistBoxControl.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1071, 606);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1";
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.BAlayoutControlGroup;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(1051, 586);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.BAlayoutControlGroup,
            this.BJlayoutControlGroup});
            this.tabbedControlGroup1.Text = "tabbedControlGroup1";
            // 
            // BJlayoutControlGroup
            // 
            this.BJlayoutControlGroup.CustomizationFormText = "JobDron";
            this.BJlayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.BJlayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.BJlayoutControlGroup.Name = "BJlayoutControlGroup";
            this.BJlayoutControlGroup.Size = new System.Drawing.Size(1027, 540);
            this.BJlayoutControlGroup.Text = "JobDron";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.BJselAktifGridControl;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1027, 285);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.BJupdTStextEdit;
            this.layoutControlItem4.CustomizationFormText = "Last Updated";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(485, 26);
            this.layoutControlItem4.Text = "Last Updated";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton1;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(485, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(542, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.BJlistBoxControl;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 311);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1027, 229);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(93, 13);
            // 
            // BAlayoutControlGroup
            // 
            this.BAlayoutControlGroup.CustomizationFormText = "ActivityDron";
            this.BAlayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.BAlayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.BAlayoutControlGroup.Name = "BAlayoutControlGroup";
            this.BAlayoutControlGroup.Size = new System.Drawing.Size(1027, 540);
            this.BAlayoutControlGroup.Text = "ActivityDron";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BAlistBoxControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1027, 514);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.BAsimpleButton;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1027, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // BAbackgroundWorker
            // 
            this.BAbackgroundWorker.WorkerReportsProgress = true;
            this.BAbackgroundWorker.WorkerSupportsCancellation = true;
            this.BAbackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BAbackgroundWorker_DoWork);
            this.BAbackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BAbackgroundWorker_RunWorkerCompleted);
            // 
            // BJbackgroundWorker
            // 
            this.BJbackgroundWorker.WorkerReportsProgress = true;
            this.BJbackgroundWorker.WorkerSupportsCancellation = true;
            this.BJbackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BJbackgroundWorker_DoWork);
            this.BJbackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BJbackgroundWorker_ProgressChanged);
            this.BJbackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BJbackgroundWorker_RunWorkerCompleted);
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            // 
            // BJselAktifTableAdapter
            // 
            this.BJselAktifTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 606);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MainForm";
            this.Text = "tMax14dron";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BJlistBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BJupdTStextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BJselAktifGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BJselAktifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BJselAktifGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAlistBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BJlayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAlayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.ListBoxControl BAlistBoxControl;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup BAlayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup BJlayoutControlGroup;
        private DevExpress.XtraEditors.SimpleButton BAsimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.ComponentModel.BackgroundWorker BAbackgroundWorker;
        private System.ComponentModel.BackgroundWorker BJbackgroundWorker;
        private DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.Timer timer;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource BJselAktifBindingSource;
        private DataSetTableAdapters.BJ_SEL_AKTIFTableAdapter BJselAktifTableAdapter;
        private DevExpress.XtraGrid.GridControl BJselAktifGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView BJselAktifGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTBL;
        private DevExpress.XtraGrid.Columns.GridColumn colREFID;
        private DevExpress.XtraGrid.Columns.GridColumn colBJDID;
        private DevExpress.XtraGrid.Columns.GridColumn colBJDAD;
        private DevExpress.XtraGrid.Columns.GridColumn colBIPID;
        private DevExpress.XtraGrid.Columns.GridColumn colBIPAD;
        private DevExpress.XtraGrid.Columns.GridColumn colINSTS;
        private DevExpress.XtraGrid.Columns.GridColumn colENDTS;
        private DevExpress.XtraGrid.Columns.GridColumn colVIA;
        private DevExpress.XtraGrid.Columns.GridColumn colUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colKIMLERE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit BJupdTStextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ListBoxControl BJlistBoxControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}


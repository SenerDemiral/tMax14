namespace tMax14.Genel
{
    partial class uytXUC
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
            this.mainDataSet = new tMax14.MainDataSet();
            this.uytBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uytTableAdapter = new tMax14.MainDataSetTableAdapters.UYTTableAdapter();
            this.uytGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uytGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSRS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uuyTableAdapter = new tMax14.MainDataSetTableAdapters.UUYTableAdapter();
            this.uuyGridControl = new DevExpress.XtraGrid.GridControl();
            this.uuyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSRu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYTKu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFCNu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFPNu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainQueriesTableAdapter = new tMax14.MainDataSetTableAdapters.MainQueriesTableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uytBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uytGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uytGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uuyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uuyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uuyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uytBindingSource
            // 
            this.uytBindingSource.DataMember = "UYT";
            this.uytBindingSource.DataSource = this.mainDataSet;
            // 
            // uytTableAdapter
            // 
            this.uytTableAdapter.ClearBeforeFill = true;
            // 
            // uytGridControl
            // 
            this.uytGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.uytGridControl.DataSource = this.uytBindingSource;
            this.uytGridControl.Location = new System.Drawing.Point(12, 28);
            this.uytGridControl.MainView = this.uytGridView;
            this.uytGridControl.Name = "uytGridControl";
            this.uytGridControl.Size = new System.Drawing.Size(614, 246);
            this.uytGridControl.TabIndex = 1;
            this.uytGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.uytGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.userToolStripMenuItem,
            this.yetkiCheckToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(127, 92);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.checkToolStripMenuItem.Text = "Check";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.checkToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // yetkiCheckToolStripMenuItem
            // 
            this.yetkiCheckToolStripMenuItem.Name = "yetkiCheckToolStripMenuItem";
            this.yetkiCheckToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.yetkiCheckToolStripMenuItem.Text = "YetkiCheck";
            this.yetkiCheckToolStripMenuItem.Click += new System.EventHandler(this.yetkiCheckToolStripMenuItem_Click);
            // 
            // uytGridView
            // 
            this.uytGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYTK,
            this.colAD,
            this.colCN,
            this.colUSRS,
            this.colFCN,
            this.colPN,
            this.colFPN});
            this.uytGridView.GridControl = this.uytGridControl;
            this.uytGridView.Name = "uytGridView";
            this.uytGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.uytGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colYTK
            // 
            this.colYTK.Caption = "Yetki";
            this.colYTK.FieldName = "YTK";
            this.colYTK.Name = "colYTK";
            this.colYTK.OptionsColumn.FixedWidth = true;
            this.colYTK.Visible = true;
            this.colYTK.VisibleIndex = 0;
            this.colYTK.Width = 60;
            // 
            // colAD
            // 
            this.colAD.Caption = "Ad";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 1;
            this.colAD.Width = 66;
            // 
            // colCN
            // 
            this.colCN.Caption = "Childs";
            this.colCN.FieldName = "CN";
            this.colCN.Name = "colCN";
            this.colCN.Visible = true;
            this.colCN.VisibleIndex = 2;
            this.colCN.Width = 114;
            // 
            // colUSRS
            // 
            this.colUSRS.Caption = "Users";
            this.colUSRS.FieldName = "USRS";
            this.colUSRS.Name = "colUSRS";
            this.colUSRS.Visible = true;
            this.colUSRS.VisibleIndex = 3;
            this.colUSRS.Width = 121;
            // 
            // colFCN
            // 
            this.colFCN.Caption = "FullChilds";
            this.colFCN.FieldName = "FCN";
            this.colFCN.Name = "colFCN";
            this.colFCN.OptionsColumn.AllowEdit = false;
            this.colFCN.OptionsColumn.AllowFocus = false;
            this.colFCN.Visible = true;
            this.colFCN.VisibleIndex = 4;
            this.colFCN.Width = 114;
            // 
            // colPN
            // 
            this.colPN.Caption = "Parents";
            this.colPN.FieldName = "PN";
            this.colPN.Name = "colPN";
            this.colPN.OptionsColumn.AllowEdit = false;
            this.colPN.OptionsColumn.AllowFocus = false;
            this.colPN.Visible = true;
            this.colPN.VisibleIndex = 5;
            this.colPN.Width = 114;
            // 
            // colFPN
            // 
            this.colFPN.Caption = "FullParents";
            this.colFPN.FieldName = "FPN";
            this.colFPN.Name = "colFPN";
            this.colFPN.OptionsColumn.AllowEdit = false;
            this.colFPN.OptionsColumn.AllowFocus = false;
            this.colFPN.Visible = true;
            this.colFPN.VisibleIndex = 6;
            this.colFPN.Width = 122;
            // 
            // uuyBindingSource
            // 
            this.uuyBindingSource.DataMember = "UUY";
            this.uuyBindingSource.DataSource = this.mainDataSet;
            // 
            // uuyTableAdapter
            // 
            this.uuyTableAdapter.ClearBeforeFill = true;
            // 
            // uuyGridControl
            // 
            this.uuyGridControl.DataSource = this.uuyBindingSource;
            this.uuyGridControl.Location = new System.Drawing.Point(12, 299);
            this.uuyGridControl.MainView = this.uuyGridView;
            this.uuyGridControl.Name = "uuyGridControl";
            this.uuyGridControl.Size = new System.Drawing.Size(614, 233);
            this.uuyGridControl.TabIndex = 2;
            this.uuyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.uuyGridView});
            // 
            // uuyGridView
            // 
            this.uuyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSRu,
            this.colYTKu,
            this.colFCNu,
            this.colFPNu});
            this.uuyGridView.GridControl = this.uuyGridControl;
            this.uuyGridView.Name = "uuyGridView";
            // 
            // colUSRu
            // 
            this.colUSRu.FieldName = "USR";
            this.colUSRu.Name = "colUSRu";
            this.colUSRu.Visible = true;
            this.colUSRu.VisibleIndex = 0;
            this.colUSRu.Width = 111;
            // 
            // colYTKu
            // 
            this.colYTKu.FieldName = "YTK";
            this.colYTKu.Name = "colYTKu";
            this.colYTKu.Visible = true;
            this.colYTKu.VisibleIndex = 1;
            this.colYTKu.Width = 184;
            // 
            // colFCNu
            // 
            this.colFCNu.FieldName = "FCN";
            this.colFCNu.Name = "colFCNu";
            this.colFCNu.Visible = true;
            this.colFCNu.VisibleIndex = 2;
            this.colFCNu.Width = 184;
            // 
            // colFPNu
            // 
            this.colFPNu.FieldName = "FPN";
            this.colFPNu.Name = "colFPNu";
            this.colFPNu.Visible = true;
            this.colFPNu.VisibleIndex = 3;
            this.colFPNu.Width = 186;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.uuyGridControl);
            this.layoutControl1.Controls.Add(this.uytGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(814, 132, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(638, 544);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(638, 544);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.uytGridControl;
            this.layoutControlItem1.CustomizationFormText = "Yetki Tanımları";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(618, 266);
            this.layoutControlItem1.Text = "Yetki Tanımları";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.uuyGridControl;
            this.layoutControlItem2.CustomizationFormText = "Kullanıcı Yetkileri";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 271);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(618, 253);
            this.layoutControlItem2.Text = "Kullanıcı Yetkileri";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(0, 266);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(618, 5);
            // 
            // uytXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "uytXUC";
            this.Size = new System.Drawing.Size(638, 544);
            this.Load += new System.EventHandler(this.uytXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uytBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uytGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uytGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uuyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uuyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uuyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource uytBindingSource;
        private MainDataSetTableAdapters.UYTTableAdapter uytTableAdapter;
        private DevExpress.XtraGrid.GridControl uytGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView uytGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colYTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCN;
        private DevExpress.XtraGrid.Columns.GridColumn colFCN;
        private DevExpress.XtraGrid.Columns.GridColumn colPN;
        private DevExpress.XtraGrid.Columns.GridColumn colFPN;
        private DevExpress.XtraGrid.Columns.GridColumn colUSRS;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.BindingSource uuyBindingSource;
        private MainDataSetTableAdapters.UUYTableAdapter uuyTableAdapter;
        private DevExpress.XtraGrid.GridControl uuyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView uuyGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colUSRu;
        private DevExpress.XtraGrid.Columns.GridColumn colYTKu;
        private DevExpress.XtraGrid.Columns.GridColumn colFCNu;
        private DevExpress.XtraGrid.Columns.GridColumn colFPNu;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private MainDataSetTableAdapters.MainQueriesTableAdapter mainQueriesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem yetkiCheckToolStripMenuItem;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}

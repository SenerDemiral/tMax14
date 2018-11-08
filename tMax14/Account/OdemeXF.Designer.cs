namespace tMax14.Account
{
    partial class OdemeXF
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.aobGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detaylarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.aobGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAOBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.accountQueriesTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AccountQueriesTableAdapter();
            this.aobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aobTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AOBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aobGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aobGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.aobGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(593, 545);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // aobGridControl
            // 
            this.aobGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.aobGridControl.DataSource = this.aobBindingSource;
            this.aobGridControl.Location = new System.Drawing.Point(12, 28);
            this.aobGridControl.MainView = this.aobGridView;
            this.aobGridControl.Name = "aobGridControl";
            this.aobGridControl.ShowOnlyPredefinedDetails = true;
            this.aobGridControl.Size = new System.Drawing.Size(569, 505);
            this.aobGridControl.TabIndex = 4;
            this.aobGridControl.Tag = "OdemeXF";
            this.aobGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.aobGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaylarToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(116, 26);
            // 
            // detaylarToolStripMenuItem
            // 
            this.detaylarToolStripMenuItem.Name = "detaylarToolStripMenuItem";
            this.detaylarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.detaylarToolStripMenuItem.Text = "Detaylar";
            this.detaylarToolStripMenuItem.Click += new System.EventHandler(this.detaylarToolStripMenuItem_Click);
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aobGridView
            // 
            this.aobGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAOBID,
            this.colFRTID,
            this.colDRM,
            this.colTUR,
            this.colTRH,
            this.colACIKLAMA,
            this.colDVZ,
            this.colKUR});
            this.aobGridView.GridControl = this.aobGridControl;
            this.aobGridView.Name = "aobGridView";
            this.aobGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.aobGridView_InitNewRow);
            // 
            // colAOBID
            // 
            this.colAOBID.DisplayFormat.FormatString = "n0";
            this.colAOBID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAOBID.FieldName = "AOBID";
            this.colAOBID.Name = "colAOBID";
            this.colAOBID.OptionsColumn.AllowEdit = false;
            this.colAOBID.OptionsColumn.AllowFocus = false;
            this.colAOBID.OptionsColumn.FixedWidth = true;
            this.colAOBID.Visible = true;
            this.colAOBID.VisibleIndex = 0;
            this.colAOBID.Width = 60;
            // 
            // colFRTID
            // 
            this.colFRTID.Caption = "Firma";
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 1;
            this.colFRTID.Width = 92;
            // 
            // colDRM
            // 
            this.colDRM.Caption = "Drm";
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.OptionsColumn.FixedWidth = true;
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 2;
            this.colDRM.Width = 60;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.OptionsColumn.FixedWidth = true;
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 3;
            this.colTUR.Width = 60;
            // 
            // colTRH
            // 
            this.colTRH.Caption = "Trh";
            this.colTRH.FieldName = "TRH";
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.FixedWidth = true;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 4;
            this.colTRH.Width = 72;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.Caption = "Açıklama";
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 5;
            this.colACIKLAMA.Width = 83;
            // 
            // colDVZ
            // 
            this.colDVZ.Caption = "Dvz";
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.OptionsColumn.FixedWidth = true;
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 6;
            this.colDVZ.Width = 48;
            // 
            // colKUR
            // 
            this.colKUR.AppearanceHeader.Options.UseTextOptions = true;
            this.colKUR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colKUR.Caption = "Kur";
            this.colKUR.FieldName = "KUR";
            this.colKUR.MaxWidth = 100;
            this.colKUR.Name = "colKUR";
            this.colKUR.Visible = true;
            this.colKUR.VisibleIndex = 7;
            this.colKUR.Width = 99;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(593, 545);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.aobGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(573, 525);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // aobBindingSource
            // 
            this.aobBindingSource.DataMember = "AOB";
            this.aobBindingSource.DataSource = this.accountDataSet;
            // 
            // aobTableAdapter
            // 
            this.aobTableAdapter.ClearBeforeFill = true;
            // 
            // OdemeXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 545);
            this.Controls.Add(this.layoutControl1);
            this.Name = "OdemeXF";
            this.Text = "OdemeXF";
            this.Load += new System.EventHandler(this.OdemeXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aobGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aobGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aobBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private AccountDataSet accountDataSet;
        private DevExpress.XtraGrid.GridControl aobGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView aobGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAOBID;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem detaylarToolStripMenuItem;
        private AccountDataSetTableAdapters.AccountQueriesTableAdapter accountQueriesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private System.Windows.Forms.BindingSource aobBindingSource;
        private AccountDataSetTableAdapters.AOBTableAdapter aobTableAdapter;
    }
}
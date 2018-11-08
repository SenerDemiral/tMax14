namespace tMax14.Account
{
    partial class HesapBkyXF
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
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.aCC_BKY_ALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCC_BKY_ALLTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.ACC_BKY_ALLTableAdapter();
            this.hspBkyGridControl = new DevExpress.XtraGrid.GridControl();
            this.hspBkyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBRCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDALCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRBRCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRALCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hesapHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_BKY_ALLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hspBkyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hspBkyGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCC_BKY_ALLBindingSource
            // 
            this.aCC_BKY_ALLBindingSource.DataMember = "ACC_BKY_ALL";
            this.aCC_BKY_ALLBindingSource.DataSource = this.accountDataSet;
            // 
            // aCC_BKY_ALLTableAdapter
            // 
            this.aCC_BKY_ALLTableAdapter.ClearBeforeFill = true;
            // 
            // hspBkyGridControl
            // 
            this.hspBkyGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.hspBkyGridControl.DataSource = this.aCC_BKY_ALLBindingSource;
            this.hspBkyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hspBkyGridControl.Location = new System.Drawing.Point(0, 0);
            this.hspBkyGridControl.MainView = this.hspBkyGridView;
            this.hspBkyGridControl.Name = "hspBkyGridControl";
            this.hspBkyGridControl.Size = new System.Drawing.Size(717, 310);
            this.hspBkyGridControl.TabIndex = 1;
            this.hspBkyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.hspBkyGridView});
            // 
            // hspBkyGridView
            // 
            this.hspBkyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHSPNO,
            this.colHSPAD,
            this.colDDVZ,
            this.colDBRCBKY,
            this.colDALCBKY,
            this.colRBRCBKY,
            this.colRALCBKY});
            this.hspBkyGridView.GridControl = this.hspBkyGridControl;
            this.hspBkyGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBRCBKY", null, "BrçBky: {0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DALCBKY", null, "AlcBky: {0:n}")});
            this.hspBkyGridView.Name = "hspBkyGridView";
            this.hspBkyGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.hspBkyGridView.OptionsBehavior.Editable = false;
            this.hspBkyGridView.OptionsView.AllowCellMerge = true;
            this.hspBkyGridView.OptionsView.ShowFooter = true;
            this.hspBkyGridView.CustomSummaryExists += new DevExpress.Data.CustomSummaryExistEventHandler(this.hspBkyGridView_CustomSummaryExists);
            // 
            // colHSPNO
            // 
            this.colHSPNO.Caption = "HspNo";
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.OptionsColumn.FixedWidth = true;
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 1;
            this.colHSPNO.Width = 80;
            // 
            // colHSPAD
            // 
            this.colHSPAD.Caption = "HesapAd";
            this.colHSPAD.FieldName = "HSPAD";
            this.colHSPAD.Name = "colHSPAD";
            this.colHSPAD.Visible = true;
            this.colHSPAD.VisibleIndex = 0;
            this.colHSPAD.Width = 219;
            // 
            // colDDVZ
            // 
            this.colDDVZ.Caption = "Dvz";
            this.colDDVZ.FieldName = "DDVZ";
            this.colDDVZ.Name = "colDDVZ";
            this.colDDVZ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDDVZ.OptionsColumn.FixedWidth = true;
            this.colDDVZ.Visible = true;
            this.colDDVZ.VisibleIndex = 2;
            this.colDDVZ.Width = 40;
            // 
            // colDBRCBKY
            // 
            this.colDBRCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colDBRCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDBRCBKY.Caption = "BrçBky Dvz";
            this.colDBRCBKY.DisplayFormat.FormatString = "n";
            this.colDBRCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDBRCBKY.FieldName = "DBRCBKY";
            this.colDBRCBKY.Name = "colDBRCBKY";
            this.colDBRCBKY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDBRCBKY.OptionsColumn.FixedWidth = true;
            this.colDBRCBKY.Visible = true;
            this.colDBRCBKY.VisibleIndex = 3;
            this.colDBRCBKY.Width = 80;
            // 
            // colDALCBKY
            // 
            this.colDALCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colDALCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDALCBKY.Caption = "AlcBky Dvz";
            this.colDALCBKY.DisplayFormat.FormatString = "n";
            this.colDALCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDALCBKY.FieldName = "DALCBKY";
            this.colDALCBKY.Name = "colDALCBKY";
            this.colDALCBKY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDALCBKY.OptionsColumn.FixedWidth = true;
            this.colDALCBKY.Visible = true;
            this.colDALCBKY.VisibleIndex = 4;
            this.colDALCBKY.Width = 80;
            // 
            // colRBRCBKY
            // 
            this.colRBRCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colRBRCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRBRCBKY.Caption = "BrçBky Rpr";
            this.colRBRCBKY.DisplayFormat.FormatString = "n";
            this.colRBRCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRBRCBKY.FieldName = "RBRCBKY";
            this.colRBRCBKY.Name = "colRBRCBKY";
            this.colRBRCBKY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRBRCBKY.OptionsColumn.FixedWidth = true;
            this.colRBRCBKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RBRCBKY", "{0:n}")});
            this.colRBRCBKY.Visible = true;
            this.colRBRCBKY.VisibleIndex = 5;
            this.colRBRCBKY.Width = 80;
            // 
            // colRALCBKY
            // 
            this.colRALCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colRALCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRALCBKY.Caption = "AlcBky Rpr";
            this.colRALCBKY.DisplayFormat.FormatString = "n";
            this.colRALCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRALCBKY.FieldName = "RALCBKY";
            this.colRALCBKY.Name = "colRALCBKY";
            this.colRALCBKY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRALCBKY.OptionsColumn.FixedWidth = true;
            this.colRALCBKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RALCBKY", "{0:n}")});
            this.colRALCBKY.Visible = true;
            this.colRALCBKY.VisibleIndex = 6;
            this.colRALCBKY.Width = 80;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapHareketleriToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(159, 26);
            // 
            // hesapHareketleriToolStripMenuItem
            // 
            this.hesapHareketleriToolStripMenuItem.Name = "hesapHareketleriToolStripMenuItem";
            this.hesapHareketleriToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.hesapHareketleriToolStripMenuItem.Text = "Hesap hareketleri";
            this.hesapHareketleriToolStripMenuItem.Click += new System.EventHandler(this.hesapHareketleriToolStripMenuItem_Click);
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
            // HesapBkyXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 310);
            this.Controls.Add(this.hspBkyGridControl);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "HesapBkyXF";
            this.Text = "Hesap Bakiyeleri";
            this.Load += new System.EventHandler(this.HesapBkyXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_BKY_ALLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hspBkyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hspBkyGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource aCC_BKY_ALLBindingSource;
        private AccountDataSetTableAdapters.ACC_BKY_ALLTableAdapter aCC_BKY_ALLTableAdapter;
        private DevExpress.XtraGrid.GridControl hspBkyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView hspBkyGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPAD;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDBRCBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colDALCBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colRBRCBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colRALCBKY;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem hesapHareketleriToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
    }
}
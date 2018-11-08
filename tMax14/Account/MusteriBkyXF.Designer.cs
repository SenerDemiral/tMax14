namespace tMax14.Account
{
    partial class MusteriBkyXF
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
            this.aCC_BKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCC_BKYTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.ACC_BKYTableAdapter();
            this.accBkyGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hesapHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accBkyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPNOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBRCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDALCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRBRCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRALCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEKSIKKPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_BKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accBkyGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accBkyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCC_BKYBindingSource
            // 
            this.aCC_BKYBindingSource.DataMember = "ACC_BKY";
            this.aCC_BKYBindingSource.DataSource = this.accountDataSet;
            // 
            // aCC_BKYTableAdapter
            // 
            this.aCC_BKYTableAdapter.ClearBeforeFill = true;
            // 
            // accBkyGridControl
            // 
            this.accBkyGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.accBkyGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.accBkyGridControl.DataSource = this.aCC_BKYBindingSource;
            this.accBkyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accBkyGridControl.Location = new System.Drawing.Point(0, 0);
            this.accBkyGridControl.MainView = this.accBkyGridView;
            this.accBkyGridControl.Name = "accBkyGridControl";
            this.accBkyGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.accBkyGridControl.Size = new System.Drawing.Size(704, 286);
            this.accBkyGridControl.TabIndex = 1;
            this.accBkyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.accBkyGridView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapHareketleriToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 26);
            // 
            // hesapHareketleriToolStripMenuItem
            // 
            this.hesapHareketleriToolStripMenuItem.Name = "hesapHareketleriToolStripMenuItem";
            this.hesapHareketleriToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.hesapHareketleriToolStripMenuItem.Text = "Hesap hareketleri";
            this.hesapHareketleriToolStripMenuItem.Click += new System.EventHandler(this.hesapHareketleriToolStripMenuItem_Click);
            // 
            // accBkyGridView
            // 
            this.accBkyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYID,
            this.colHSPAD,
            this.colHSPNOS,
            this.colDDVZ,
            this.colDBRCBKY,
            this.colDALCBKY,
            this.colRBRCBKY,
            this.colRALCBKY,
            this.colEKSIKKPM});
            this.accBkyGridView.GridControl = this.accBkyGridControl;
            this.accBkyGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBRCBKY", null, "BrçBky: {0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DALCBKY", null, "AlcBky: {0:n}")});
            this.accBkyGridView.Name = "accBkyGridView";
            this.accBkyGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.accBkyGridView.OptionsBehavior.Editable = false;
            this.accBkyGridView.OptionsView.AllowCellMerge = true;
            this.accBkyGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.accBkyGridView.OptionsView.ShowFooter = true;
            this.accBkyGridView.CustomSummaryExists += new DevExpress.Data.CustomSummaryExistEventHandler(this.accBkyGridView_CustomSummaryExists);
            // 
            // colYID
            // 
            this.colYID.AppearanceCell.Options.UseTextOptions = true;
            this.colYID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYID.AppearanceHeader.Options.UseTextOptions = true;
            this.colYID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYID.Caption = "İ/D";
            this.colYID.FieldName = "YID";
            this.colYID.Name = "colYID";
            this.colYID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colYID.Visible = true;
            this.colYID.VisibleIndex = 0;
            this.colYID.Width = 27;
            // 
            // colHSPAD
            // 
            this.colHSPAD.Caption = "HesapAd";
            this.colHSPAD.FieldName = "HSPAD";
            this.colHSPAD.Name = "colHSPAD";
            this.colHSPAD.Visible = true;
            this.colHSPAD.VisibleIndex = 1;
            this.colHSPAD.Width = 153;
            // 
            // colHSPNOS
            // 
            this.colHSPNOS.Caption = "HspNo";
            this.colHSPNOS.FieldName = "HSPNOS";
            this.colHSPNOS.Name = "colHSPNOS";
            this.colHSPNOS.Visible = true;
            this.colHSPNOS.VisibleIndex = 2;
            this.colHSPNOS.Width = 71;
            // 
            // colDDVZ
            // 
            this.colDDVZ.Caption = "Dvz";
            this.colDDVZ.FieldName = "DDVZ";
            this.colDDVZ.Name = "colDDVZ";
            this.colDDVZ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDDVZ.OptionsColumn.FixedWidth = true;
            this.colDDVZ.Visible = true;
            this.colDDVZ.VisibleIndex = 3;
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
            this.colDBRCBKY.VisibleIndex = 4;
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
            this.colDALCBKY.VisibleIndex = 5;
            this.colDALCBKY.Width = 80;
            // 
            // colRBRCBKY
            // 
            this.colRBRCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colRBRCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRBRCBKY.Caption = "BrçBky EUR";
            this.colRBRCBKY.DisplayFormat.FormatString = "n";
            this.colRBRCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRBRCBKY.FieldName = "RBRCBKY";
            this.colRBRCBKY.Name = "colRBRCBKY";
            this.colRBRCBKY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRBRCBKY.OptionsColumn.FixedWidth = true;
            this.colRBRCBKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RBRCBKY", "{0:n}")});
            this.colRBRCBKY.Visible = true;
            this.colRBRCBKY.VisibleIndex = 6;
            this.colRBRCBKY.Width = 80;
            // 
            // colRALCBKY
            // 
            this.colRALCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colRALCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRALCBKY.Caption = "AlcBky EUR";
            this.colRALCBKY.DisplayFormat.FormatString = "n";
            this.colRALCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRALCBKY.FieldName = "RALCBKY";
            this.colRALCBKY.Name = "colRALCBKY";
            this.colRALCBKY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRALCBKY.OptionsColumn.FixedWidth = true;
            this.colRALCBKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RALCBKY", "{0:n}")});
            this.colRALCBKY.Visible = true;
            this.colRALCBKY.VisibleIndex = 7;
            this.colRALCBKY.Width = 80;
            // 
            // colEKSIKKPM
            // 
            this.colEKSIKKPM.Caption = "EksikKpm";
            this.colEKSIKKPM.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colEKSIKKPM.FieldName = "EKSIKKPM";
            this.colEKSIKKPM.Name = "colEKSIKKPM";
            this.colEKSIKKPM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEKSIKKPM.OptionsColumn.FixedWidth = true;
            this.colEKSIKKPM.ToolTip = "Kapatılmamış Fatura var";
            this.colEKSIKKPM.Visible = true;
            this.colEKSIKKPM.VisibleIndex = 8;
            this.colEKSIKKPM.Width = 60;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = "T";
            this.repositoryItemCheckEdit1.ValueUnchecked = "F";
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
            // MusteriBkyXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 286);
            this.Controls.Add(this.accBkyGridControl);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MusteriBkyXF";
            this.Text = "Musteri Bakiyeleri (120/320)";
            this.Load += new System.EventHandler(this.MusteriBkyXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_BKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accBkyGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accBkyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource aCC_BKYBindingSource;
        private AccountDataSetTableAdapters.ACC_BKYTableAdapter aCC_BKYTableAdapter;
        private DevExpress.XtraGrid.GridControl accBkyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView accBkyGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNOS;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPAD;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDBRCBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colDALCBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colRBRCBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colRALCBKY;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesapHareketleriToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraGrid.Columns.GridColumn colYID;
        private DevExpress.XtraGrid.Columns.GridColumn colEKSIKKPM;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}
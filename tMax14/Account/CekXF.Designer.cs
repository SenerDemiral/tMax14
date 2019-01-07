namespace tMax14.Account
{
    partial class CekXF
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
            this.acsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acsTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.ACSTableAdapter();
            this.acsGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.muhasebeFisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhasebeFisDetayiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cekAcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cekKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colACSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TURrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colEDITABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DRMrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colCEKHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUSHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRSTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVDETRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLGNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYYTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountQueriesTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AccountQueriesTableAdapter();
            this.kuR_AVBTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.KUR_AVBTableAdapter();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acsGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TURrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRMrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acsBindingSource
            // 
            this.acsBindingSource.DataMember = "ACS";
            this.acsBindingSource.DataSource = this.accountDataSet;
            // 
            // acsTableAdapter
            // 
            this.acsTableAdapter.ClearBeforeFill = true;
            // 
            // acsGridControl
            // 
            this.acsGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.acsGridControl.DataSource = this.acsBindingSource;
            this.acsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.acsGridControl.Location = new System.Drawing.Point(0, 0);
            this.acsGridControl.MainView = this.acsGridView;
            this.acsGridControl.Name = "acsGridControl";
            this.acsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TURrepositoryItemImageComboBox,
            this.DRMrepositoryItemImageComboBox});
            this.acsGridControl.Size = new System.Drawing.Size(1227, 281);
            this.acsGridControl.TabIndex = 2;
            this.acsGridControl.Tag = "ACS";
            this.acsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.acsGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muhasebeFisiToolStripMenuItem,
            this.muhasebeFisDetayiToolStripMenuItem,
            this.hareketleriToolStripMenuItem,
            this.cekAcToolStripMenuItem,
            this.cekKapatToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(182, 136);
            // 
            // muhasebeFisiToolStripMenuItem
            // 
            this.muhasebeFisiToolStripMenuItem.Name = "muhasebeFisiToolStripMenuItem";
            this.muhasebeFisiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.muhasebeFisiToolStripMenuItem.Text = "Muhasebe fisi";
            this.muhasebeFisiToolStripMenuItem.Click += new System.EventHandler(this.muhasebeFisiToolStripMenuItem_Click);
            // 
            // muhasebeFisDetayiToolStripMenuItem
            // 
            this.muhasebeFisDetayiToolStripMenuItem.Name = "muhasebeFisDetayiToolStripMenuItem";
            this.muhasebeFisDetayiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.muhasebeFisDetayiToolStripMenuItem.Text = "Muhasebe Fiş detayı";
            this.muhasebeFisDetayiToolStripMenuItem.Click += new System.EventHandler(this.muhasebeFisDetayiToolStripMenuItem_Click);
            // 
            // hareketleriToolStripMenuItem
            // 
            this.hareketleriToolStripMenuItem.Name = "hareketleriToolStripMenuItem";
            this.hareketleriToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.hareketleriToolStripMenuItem.Text = "Hareketleri";
            this.hareketleriToolStripMenuItem.Click += new System.EventHandler(this.hareketleriToolStripMenuItem_Click);
            // 
            // cekAcToolStripMenuItem
            // 
            this.cekAcToolStripMenuItem.Name = "cekAcToolStripMenuItem";
            this.cekAcToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cekAcToolStripMenuItem.Text = "Aç";
            this.cekAcToolStripMenuItem.Click += new System.EventHandler(this.cekAcToolStripMenuItem_Click);
            // 
            // cekKapatToolStripMenuItem
            // 
            this.cekKapatToolStripMenuItem.Name = "cekKapatToolStripMenuItem";
            this.cekKapatToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cekKapatToolStripMenuItem.Text = "Kapat";
            this.cekKapatToolStripMenuItem.Click += new System.EventHandler(this.cekKapatToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // acsGridView
            // 
            this.acsGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.acsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colACSID,
            this.colTUR,
            this.colEDITABLE,
            this.colDRM,
            this.colCEKHSPNO,
            this.colMUSHSPNO,
            this.colTUT,
            this.colDVZ,
            this.colKUR,
            this.colAKUR,
            this.colGRSTRH,
            this.colVDETRH,
            this.colBLGNO,
            this.colINFO,
            this.colONYYTK,
            this.colONYUSR,
            this.colONYTRH});
            this.acsGridView.GridControl = this.acsGridControl;
            this.acsGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUT", this.colTUT, "{0:n2}")});
            this.acsGridView.Name = "acsGridView";
            this.acsGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.acsGridView_ShowingEditor);
            this.acsGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.acsGridView_InitNewRow);
            // 
            // colACSID
            // 
            this.colACSID.DisplayFormat.FormatString = "n0";
            this.colACSID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colACSID.FieldName = "ACSID";
            this.colACSID.Name = "colACSID";
            this.colACSID.OptionsColumn.AllowEdit = false;
            this.colACSID.OptionsColumn.AllowFocus = false;
            this.colACSID.OptionsColumn.FixedWidth = true;
            this.colACSID.Visible = true;
            this.colACSID.VisibleIndex = 0;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.ColumnEdit = this.TURrepositoryItemImageComboBox;
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.OptionsColumn.FixedWidth = true;
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 2;
            this.colTUR.Width = 50;
            // 
            // TURrepositoryItemImageComboBox
            // 
            this.TURrepositoryItemImageComboBox.AutoHeight = false;
            this.TURrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TURrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Alınan", "A", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Verilen", "V", -1)});
            this.TURrepositoryItemImageComboBox.Name = "TURrepositoryItemImageComboBox";
            // 
            // colEDITABLE
            // 
            this.colEDITABLE.Caption = "E";
            this.colEDITABLE.FieldName = "EDITABLE";
            this.colEDITABLE.Name = "colEDITABLE";
            this.colEDITABLE.OptionsColumn.AllowEdit = false;
            this.colEDITABLE.OptionsColumn.AllowFocus = false;
            this.colEDITABLE.OptionsColumn.FixedWidth = true;
            this.colEDITABLE.Visible = true;
            this.colEDITABLE.VisibleIndex = 1;
            this.colEDITABLE.Width = 22;
            // 
            // colDRM
            // 
            this.colDRM.Caption = "Durum";
            this.colDRM.ColumnEdit = this.DRMrepositoryItemImageComboBox;
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.OptionsColumn.FixedWidth = true;
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 3;
            this.colDRM.Width = 50;
            // 
            // DRMrepositoryItemImageComboBox
            // 
            this.DRMrepositoryItemImageComboBox.AutoHeight = false;
            this.DRMrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DRMrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Açık", "A", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kapalı", "K", -1)});
            this.DRMrepositoryItemImageComboBox.Name = "DRMrepositoryItemImageComboBox";
            // 
            // colCEKHSPNO
            // 
            this.colCEKHSPNO.Caption = "ÇekHspNo";
            this.colCEKHSPNO.FieldName = "CEKHSPNO";
            this.colCEKHSPNO.Name = "colCEKHSPNO";
            this.colCEKHSPNO.OptionsColumn.AllowEdit = false;
            this.colCEKHSPNO.OptionsColumn.AllowFocus = false;
            this.colCEKHSPNO.Visible = true;
            this.colCEKHSPNO.VisibleIndex = 4;
            this.colCEKHSPNO.Width = 210;
            // 
            // colMUSHSPNO
            // 
            this.colMUSHSPNO.Caption = "MüşHspNo";
            this.colMUSHSPNO.FieldName = "MUSHSPNO";
            this.colMUSHSPNO.Name = "colMUSHSPNO";
            this.colMUSHSPNO.Visible = true;
            this.colMUSHSPNO.VisibleIndex = 5;
            this.colMUSHSPNO.Width = 198;
            // 
            // colTUT
            // 
            this.colTUT.Caption = "Tutar";
            this.colTUT.DisplayFormat.FormatString = "n2";
            this.colTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTUT.FieldName = "TUT";
            this.colTUT.Name = "colTUT";
            this.colTUT.OptionsColumn.FixedWidth = true;
            this.colTUT.Visible = true;
            this.colTUT.VisibleIndex = 6;
            // 
            // colDVZ
            // 
            this.colDVZ.Caption = "Dvz";
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.OptionsColumn.FixedWidth = true;
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 7;
            this.colDVZ.Width = 50;
            // 
            // colKUR
            // 
            this.colKUR.Caption = "Kur";
            this.colKUR.FieldName = "KUR";
            this.colKUR.Name = "colKUR";
            this.colKUR.OptionsColumn.FixedWidth = true;
            this.colKUR.Visible = true;
            this.colKUR.VisibleIndex = 8;
            this.colKUR.Width = 50;
            // 
            // colAKUR
            // 
            this.colAKUR.Caption = "RsmKur";
            this.colAKUR.FieldName = "AKUR";
            this.colAKUR.Name = "colAKUR";
            this.colAKUR.OptionsColumn.FixedWidth = true;
            this.colAKUR.ToolTip = "Resmi Kur";
            this.colAKUR.Visible = true;
            this.colAKUR.VisibleIndex = 9;
            this.colAKUR.Width = 50;
            // 
            // colGRSTRH
            // 
            this.colGRSTRH.Caption = "GrşTrh";
            this.colGRSTRH.FieldName = "GRSTRH";
            this.colGRSTRH.Name = "colGRSTRH";
            this.colGRSTRH.OptionsColumn.FixedWidth = true;
            this.colGRSTRH.Visible = true;
            this.colGRSTRH.VisibleIndex = 10;
            this.colGRSTRH.Width = 68;
            // 
            // colVDETRH
            // 
            this.colVDETRH.Caption = "VdeTrh";
            this.colVDETRH.FieldName = "VDETRH";
            this.colVDETRH.Name = "colVDETRH";
            this.colVDETRH.OptionsColumn.FixedWidth = true;
            this.colVDETRH.Visible = true;
            this.colVDETRH.VisibleIndex = 11;
            this.colVDETRH.Width = 68;
            // 
            // colBLGNO
            // 
            this.colBLGNO.Caption = "BlgNo";
            this.colBLGNO.FieldName = "BLGNO";
            this.colBLGNO.Name = "colBLGNO";
            this.colBLGNO.Visible = true;
            this.colBLGNO.VisibleIndex = 12;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Açıklama";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.OptionsColumn.FixedWidth = true;
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 13;
            // 
            // colONYYTK
            // 
            this.colONYYTK.Caption = "OnyYtk";
            this.colONYYTK.FieldName = "ONYYTK";
            this.colONYYTK.Name = "colONYYTK";
            this.colONYYTK.OptionsColumn.AllowEdit = false;
            this.colONYYTK.OptionsColumn.AllowFocus = false;
            this.colONYYTK.OptionsColumn.FixedWidth = true;
            this.colONYYTK.Visible = true;
            this.colONYYTK.VisibleIndex = 14;
            this.colONYYTK.Width = 50;
            // 
            // colONYUSR
            // 
            this.colONYUSR.Caption = "OnyUsr";
            this.colONYUSR.FieldName = "ONYUSR";
            this.colONYUSR.Name = "colONYUSR";
            this.colONYUSR.OptionsColumn.AllowEdit = false;
            this.colONYUSR.OptionsColumn.AllowFocus = false;
            this.colONYUSR.OptionsColumn.FixedWidth = true;
            this.colONYUSR.Visible = true;
            this.colONYUSR.VisibleIndex = 15;
            this.colONYUSR.Width = 50;
            // 
            // colONYTRH
            // 
            this.colONYTRH.Caption = "OnyTrh";
            this.colONYTRH.FieldName = "ONYTRH";
            this.colONYTRH.Name = "colONYTRH";
            this.colONYTRH.OptionsColumn.AllowEdit = false;
            this.colONYTRH.OptionsColumn.AllowFocus = false;
            this.colONYTRH.OptionsColumn.FixedWidth = true;
            this.colONYTRH.Visible = true;
            this.colONYTRH.VisibleIndex = 16;
            this.colONYTRH.Width = 68;
            // 
            // kuR_AVBTableAdapter
            // 
            this.kuR_AVBTableAdapter.ClearBeforeFill = true;
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
            // CekXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 281);
            this.Controls.Add(this.acsGridControl);
            this.Name = "CekXF";
            this.Text = "CekXF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CekXF_FormClosing);
            this.Load += new System.EventHandler(this.CekXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acsGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TURrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRMrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource acsBindingSource;
        private AccountDataSetTableAdapters.ACSTableAdapter acsTableAdapter;
        private DevExpress.XtraGrid.GridControl acsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView acsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colACSID;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colMUSHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colAKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colGRSTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colVDETRH;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colONYYTK;
        private DevExpress.XtraGrid.Columns.GridColumn colONYUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colONYTRH;
        private AccountDataSetTableAdapters.AccountQueriesTableAdapter accountQueriesTableAdapter;
        private AccountDataSetTableAdapters.KUR_AVBTableAdapter kuR_AVBTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCEKHSPNO;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TURrepositoryItemImageComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox DRMrepositoryItemImageComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem muhasebeFisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hareketleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhasebeFisDetayiToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraGrid.Columns.GridColumn colEDITABLE;
        private System.Windows.Forms.ToolStripMenuItem cekAcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cekKapatToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colBLGNO;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}
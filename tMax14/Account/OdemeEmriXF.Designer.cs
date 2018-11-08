namespace tMax14.Account
{
    partial class OdemeEmriXF
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
            this.avbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avbeTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AVBETableAdapter();
            this.avbeGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hazirlandiOnayiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilkOnayiniVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonOnayiniVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.odemeFisineGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhasebeFisDetayiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.jurnalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avbeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAVBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DRMrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONY1YTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONY1USR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONY1TRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONY2YTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONY2USR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONY2TRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONY3YTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONY3USR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONY3TRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVBALC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVBBRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVBDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountQueriesTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AccountQueriesTableAdapter();
            this.colEDITABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avbeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avbeGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avbeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRMrepositoryItemImageComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avbeBindingSource
            // 
            this.avbeBindingSource.DataMember = "AVBE";
            this.avbeBindingSource.DataSource = this.accountDataSet;
            // 
            // avbeTableAdapter
            // 
            this.avbeTableAdapter.ClearBeforeFill = true;
            // 
            // avbeGridControl
            // 
            this.avbeGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.avbeGridControl.DataSource = this.avbeBindingSource;
            this.avbeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avbeGridControl.Location = new System.Drawing.Point(0, 0);
            this.avbeGridControl.MainView = this.avbeGridView;
            this.avbeGridControl.Name = "avbeGridControl";
            this.avbeGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DRMrepositoryItemImageComboBox});
            this.avbeGridControl.Size = new System.Drawing.Size(1069, 291);
            this.avbeGridControl.TabIndex = 2;
            this.avbeGridControl.Tag = "AVBE";
            this.avbeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.avbeGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hazirlandiOnayiToolStripMenuItem,
            this.ilkOnayiniVerToolStripMenuItem,
            this.sonOnayiniVerToolStripMenuItem,
            this.revizeToolStripMenuItem,
            this.toolStripSeparator2,
            this.odemeFisineGitToolStripMenuItem,
            this.muhasebeFisDetayiToolStripMenuItem,
            this.toolStripSeparator1,
            this.jurnalToolStripMenuItem,
            this.toolStripSeparator3,
            this.kapatToolStripMenuItem,
            this.acToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(173, 242);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // hazirlandiOnayiToolStripMenuItem
            // 
            this.hazirlandiOnayiToolStripMenuItem.Name = "hazirlandiOnayiToolStripMenuItem";
            this.hazirlandiOnayiToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.hazirlandiOnayiToolStripMenuItem.Text = "Hazirlandi Onayi";
            this.hazirlandiOnayiToolStripMenuItem.Click += new System.EventHandler(this.hazirlandiOnayiToolStripMenuItem_Click);
            // 
            // ilkOnayiniVerToolStripMenuItem
            // 
            this.ilkOnayiniVerToolStripMenuItem.Name = "ilkOnayiniVerToolStripMenuItem";
            this.ilkOnayiniVerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ilkOnayiniVerToolStripMenuItem.Text = "Ilk Onayini ver";
            this.ilkOnayiniVerToolStripMenuItem.Click += new System.EventHandler(this.ilkOnayiniVerToolStripMenuItem_Click);
            // 
            // sonOnayiniVerToolStripMenuItem
            // 
            this.sonOnayiniVerToolStripMenuItem.Name = "sonOnayiniVerToolStripMenuItem";
            this.sonOnayiniVerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sonOnayiniVerToolStripMenuItem.Text = "Son Onayini ver";
            this.sonOnayiniVerToolStripMenuItem.Click += new System.EventHandler(this.sonOnayiniVerToolStripMenuItem_Click);
            // 
            // revizeToolStripMenuItem
            // 
            this.revizeToolStripMenuItem.Name = "revizeToolStripMenuItem";
            this.revizeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.revizeToolStripMenuItem.Text = "Revize";
            this.revizeToolStripMenuItem.ToolTipText = "Revıze edileceği için Onaylar kaldırılır, baştan başlanır.";
            this.revizeToolStripMenuItem.Click += new System.EventHandler(this.revizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // odemeFisineGitToolStripMenuItem
            // 
            this.odemeFisineGitToolStripMenuItem.Name = "odemeFisineGitToolStripMenuItem";
            this.odemeFisineGitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.odemeFisineGitToolStripMenuItem.Text = "Muhasebe Fişi";
            this.odemeFisineGitToolStripMenuItem.Click += new System.EventHandler(this.odemeFisineGitToolStripMenuItem_Click);
            // 
            // muhasebeFisDetayiToolStripMenuItem
            // 
            this.muhasebeFisDetayiToolStripMenuItem.Name = "muhasebeFisDetayiToolStripMenuItem";
            this.muhasebeFisDetayiToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.muhasebeFisDetayiToolStripMenuItem.Text = "Muhasebe Fiş detayı";
            this.muhasebeFisDetayiToolStripMenuItem.Click += new System.EventHandler(this.muhasebeFisDetayiToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // jurnalToolStripMenuItem
            // 
            this.jurnalToolStripMenuItem.Name = "jurnalToolStripMenuItem";
            this.jurnalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.jurnalToolStripMenuItem.Text = "Jurnal";
            this.jurnalToolStripMenuItem.Click += new System.EventHandler(this.jurnalToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.acToolStripMenuItem.Text = "Aç";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // avbeGridView
            // 
            this.avbeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAVBID,
            this.colHSPNO,
            this.colDRM,
            this.colACIKLAMA,
            this.colONY1YTK,
            this.colONY1USR,
            this.colONY1TRH,
            this.colONY2YTK,
            this.colONY2USR,
            this.colONY2TRH,
            this.colONY3YTK,
            this.colONY3USR,
            this.colONY3TRH,
            this.colAVBALC,
            this.colAVBBRC,
            this.colAVBDVZ,
            this.colEDITABLE});
            this.avbeGridView.GridControl = this.avbeGridControl;
            this.avbeGridView.Name = "avbeGridView";
            this.avbeGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.avbeGridView_ShowingEditor);
            this.avbeGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.avbeGridView_InitNewRow);
            // 
            // colAVBID
            // 
            this.colAVBID.DisplayFormat.FormatString = "0";
            this.colAVBID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAVBID.FieldName = "AVBID";
            this.colAVBID.Name = "colAVBID";
            this.colAVBID.OptionsColumn.AllowEdit = false;
            this.colAVBID.OptionsColumn.AllowFocus = false;
            this.colAVBID.OptionsColumn.FixedWidth = true;
            this.colAVBID.Visible = true;
            this.colAVBID.VisibleIndex = 0;
            this.colAVBID.Width = 60;
            // 
            // colHSPNO
            // 
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 2;
            this.colHSPNO.Width = 139;
            // 
            // colDRM
            // 
            this.colDRM.ColumnEdit = this.DRMrepositoryItemImageComboBox;
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.OptionsColumn.AllowEdit = false;
            this.colDRM.OptionsColumn.AllowFocus = false;
            this.colDRM.OptionsColumn.FixedWidth = true;
            this.colDRM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 3;
            this.colDRM.Width = 100;
            // 
            // DRMrepositoryItemImageComboBox
            // 
            this.DRMrepositoryItemImageComboBox.AutoHeight = false;
            this.DRMrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DRMrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Hazırlanıyor", "H", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("İlkOnayBekleniyor", "I", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("SonOnyBekleniyor", "S", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Onaylandı", "O", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Revize", "R", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kapalı", "K", -1)});
            this.DRMrepositoryItemImageComboBox.Name = "DRMrepositoryItemImageComboBox";
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 4;
            this.colACIKLAMA.Width = 166;
            // 
            // colONY1YTK
            // 
            this.colONY1YTK.FieldName = "ONY1YTK";
            this.colONY1YTK.Name = "colONY1YTK";
            this.colONY1YTK.OptionsColumn.AllowEdit = false;
            this.colONY1YTK.OptionsColumn.AllowFocus = false;
            this.colONY1YTK.OptionsColumn.FixedWidth = true;
            this.colONY1YTK.Width = 50;
            // 
            // colONY1USR
            // 
            this.colONY1USR.Caption = "Ony1";
            this.colONY1USR.FieldName = "ONY1USR";
            this.colONY1USR.Name = "colONY1USR";
            this.colONY1USR.OptionsColumn.AllowEdit = false;
            this.colONY1USR.OptionsColumn.AllowFocus = false;
            this.colONY1USR.OptionsColumn.FixedWidth = true;
            this.colONY1USR.ToolTip = "Hazırlayan";
            this.colONY1USR.Visible = true;
            this.colONY1USR.VisibleIndex = 5;
            this.colONY1USR.Width = 50;
            // 
            // colONY1TRH
            // 
            this.colONY1TRH.FieldName = "ONY1TRH";
            this.colONY1TRH.Name = "colONY1TRH";
            this.colONY1TRH.OptionsColumn.AllowEdit = false;
            this.colONY1TRH.OptionsColumn.AllowFocus = false;
            this.colONY1TRH.OptionsColumn.FixedWidth = true;
            this.colONY1TRH.Visible = true;
            this.colONY1TRH.VisibleIndex = 6;
            // 
            // colONY2YTK
            // 
            this.colONY2YTK.FieldName = "ONY2YTK";
            this.colONY2YTK.Name = "colONY2YTK";
            this.colONY2YTK.OptionsColumn.AllowEdit = false;
            this.colONY2YTK.OptionsColumn.AllowFocus = false;
            this.colONY2YTK.OptionsColumn.FixedWidth = true;
            this.colONY2YTK.Width = 50;
            // 
            // colONY2USR
            // 
            this.colONY2USR.FieldName = "ONY2USR";
            this.colONY2USR.Name = "colONY2USR";
            this.colONY2USR.OptionsColumn.AllowEdit = false;
            this.colONY2USR.OptionsColumn.AllowFocus = false;
            this.colONY2USR.OptionsColumn.FixedWidth = true;
            this.colONY2USR.ToolTip = "İlk Onayı veren";
            this.colONY2USR.Visible = true;
            this.colONY2USR.VisibleIndex = 7;
            this.colONY2USR.Width = 50;
            // 
            // colONY2TRH
            // 
            this.colONY2TRH.FieldName = "ONY2TRH";
            this.colONY2TRH.Name = "colONY2TRH";
            this.colONY2TRH.OptionsColumn.AllowEdit = false;
            this.colONY2TRH.OptionsColumn.AllowFocus = false;
            this.colONY2TRH.OptionsColumn.FixedWidth = true;
            this.colONY2TRH.Visible = true;
            this.colONY2TRH.VisibleIndex = 8;
            // 
            // colONY3YTK
            // 
            this.colONY3YTK.FieldName = "ONY3YTK";
            this.colONY3YTK.Name = "colONY3YTK";
            this.colONY3YTK.OptionsColumn.AllowEdit = false;
            this.colONY3YTK.OptionsColumn.AllowFocus = false;
            this.colONY3YTK.OptionsColumn.FixedWidth = true;
            this.colONY3YTK.Width = 50;
            // 
            // colONY3USR
            // 
            this.colONY3USR.FieldName = "ONY3USR";
            this.colONY3USR.Name = "colONY3USR";
            this.colONY3USR.OptionsColumn.AllowEdit = false;
            this.colONY3USR.OptionsColumn.AllowFocus = false;
            this.colONY3USR.OptionsColumn.FixedWidth = true;
            this.colONY3USR.ToolTip = "Son Onayı veren";
            this.colONY3USR.Visible = true;
            this.colONY3USR.VisibleIndex = 9;
            this.colONY3USR.Width = 50;
            // 
            // colONY3TRH
            // 
            this.colONY3TRH.FieldName = "ONY3TRH";
            this.colONY3TRH.Name = "colONY3TRH";
            this.colONY3TRH.OptionsColumn.AllowEdit = false;
            this.colONY3TRH.OptionsColumn.AllowFocus = false;
            this.colONY3TRH.OptionsColumn.FixedWidth = true;
            this.colONY3TRH.Visible = true;
            this.colONY3TRH.VisibleIndex = 10;
            // 
            // colAVBALC
            // 
            this.colAVBALC.AppearanceHeader.Options.UseTextOptions = true;
            this.colAVBALC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAVBALC.Caption = "FişAlc";
            this.colAVBALC.DisplayFormat.FormatString = "n2";
            this.colAVBALC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAVBALC.FieldName = "AVBALC";
            this.colAVBALC.Name = "colAVBALC";
            this.colAVBALC.OptionsColumn.AllowEdit = false;
            this.colAVBALC.OptionsColumn.AllowFocus = false;
            this.colAVBALC.OptionsColumn.FixedWidth = true;
            this.colAVBALC.Visible = true;
            this.colAVBALC.VisibleIndex = 11;
            // 
            // colAVBBRC
            // 
            this.colAVBBRC.AppearanceHeader.Options.UseTextOptions = true;
            this.colAVBBRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAVBBRC.Caption = "FişBrç";
            this.colAVBBRC.DisplayFormat.FormatString = "n2";
            this.colAVBBRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAVBBRC.FieldName = "AVBBRC";
            this.colAVBBRC.Name = "colAVBBRC";
            this.colAVBBRC.OptionsColumn.AllowEdit = false;
            this.colAVBBRC.OptionsColumn.AllowFocus = false;
            this.colAVBBRC.OptionsColumn.FixedWidth = true;
            this.colAVBBRC.Visible = true;
            this.colAVBBRC.VisibleIndex = 12;
            // 
            // colAVBDVZ
            // 
            this.colAVBDVZ.Caption = "FişDvz";
            this.colAVBDVZ.FieldName = "AVBDVZ";
            this.colAVBDVZ.Name = "colAVBDVZ";
            this.colAVBDVZ.OptionsColumn.AllowEdit = false;
            this.colAVBDVZ.OptionsColumn.AllowFocus = false;
            this.colAVBDVZ.OptionsColumn.FixedWidth = true;
            this.colAVBDVZ.Visible = true;
            this.colAVBDVZ.VisibleIndex = 13;
            this.colAVBDVZ.Width = 40;
            // 
            // colEDITABLE
            // 
            this.colEDITABLE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDITABLE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDITABLE.Caption = "E";
            this.colEDITABLE.FieldName = "EDITABLE";
            this.colEDITABLE.Name = "colEDITABLE";
            this.colEDITABLE.OptionsColumn.AllowEdit = false;
            this.colEDITABLE.OptionsColumn.AllowFocus = false;
            this.colEDITABLE.OptionsColumn.FixedWidth = true;
            this.colEDITABLE.Visible = true;
            this.colEDITABLE.VisibleIndex = 1;
            this.colEDITABLE.Width = 21;
            // 
            // OdemeEmriXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 291);
            this.Controls.Add(this.avbeGridControl);
            this.Name = "OdemeEmriXF";
            this.Text = "Ödeme Emirleri/Onayları";
            this.Load += new System.EventHandler(this.OdemeEmriXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avbeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avbeGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avbeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRMrepositoryItemImageComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource avbeBindingSource;
        private AccountDataSetTableAdapters.AVBETableAdapter avbeTableAdapter;
        private DevExpress.XtraGrid.GridControl avbeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView avbeGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem hazirlandiOnayiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilkOnayiniVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonOnayiniVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revizeToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colAVBID;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colONY1YTK;
        private DevExpress.XtraGrid.Columns.GridColumn colONY1USR;
        private DevExpress.XtraGrid.Columns.GridColumn colONY1TRH;
        private DevExpress.XtraGrid.Columns.GridColumn colONY2YTK;
        private DevExpress.XtraGrid.Columns.GridColumn colONY2USR;
        private DevExpress.XtraGrid.Columns.GridColumn colONY2TRH;
        private DevExpress.XtraGrid.Columns.GridColumn colONY3YTK;
        private DevExpress.XtraGrid.Columns.GridColumn colONY3USR;
        private DevExpress.XtraGrid.Columns.GridColumn colONY3TRH;
        private AccountDataSetTableAdapters.AccountQueriesTableAdapter accountQueriesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem odemeFisineGitToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colAVBALC;
        private DevExpress.XtraGrid.Columns.GridColumn colAVBBRC;
        private DevExpress.XtraGrid.Columns.GridColumn colAVBDVZ;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox DRMrepositoryItemImageComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem jurnalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem muhasebeFisDetayiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colEDITABLE;
    }
}
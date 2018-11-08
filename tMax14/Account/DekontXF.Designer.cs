namespace tMax14.Account
{
    partial class DekontXF
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.arbDtyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colARDIDd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colARBIDd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHTIDd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKURd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.arbGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.arbGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colARBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDITABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLGNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRCFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRCDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRCKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALCFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALCDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALCKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPHM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYYTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountQueriesTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AccountQueriesTableAdapter();
            this.arbTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.ARBTableAdapter();
            this.ardTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.ARDTableAdapter();
            this.muhasebeFisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.arbDtyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // arbDtyGridView
            // 
            this.arbDtyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colARDIDd,
            this.colARBIDd,
            this.colAHTIDd,
            this.colTUTd,
            this.colDVZd,
            this.colKURd});
            this.arbDtyGridView.GridControl = this.arbGridControl;
            this.arbDtyGridView.Name = "arbDtyGridView";
            this.arbDtyGridView.OptionsView.ColumnAutoWidth = false;
            this.arbDtyGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.arbDtyGridView.OptionsView.ShowGroupPanel = false;
            this.arbDtyGridView.ViewCaption = "Charges";
            this.arbDtyGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.arbDtyGridView_InitNewRow);
            this.arbDtyGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.arbDtyGridView_ValidateRow);
            // 
            // colARDIDd
            // 
            this.colARDIDd.FieldName = "ARDID";
            this.colARDIDd.Name = "colARDIDd";
            this.colARDIDd.OptionsColumn.AllowEdit = false;
            this.colARDIDd.OptionsColumn.AllowFocus = false;
            this.colARDIDd.Visible = true;
            this.colARDIDd.VisibleIndex = 0;
            // 
            // colARBIDd
            // 
            this.colARBIDd.FieldName = "ARBID";
            this.colARBIDd.Name = "colARBIDd";
            this.colARBIDd.OptionsColumn.AllowEdit = false;
            this.colARBIDd.OptionsColumn.AllowFocus = false;
            // 
            // colAHTIDd
            // 
            this.colAHTIDd.Caption = "Charge";
            this.colAHTIDd.FieldName = "AHTID";
            this.colAHTIDd.Name = "colAHTIDd";
            this.colAHTIDd.Visible = true;
            this.colAHTIDd.VisibleIndex = 1;
            this.colAHTIDd.Width = 179;
            // 
            // colTUTd
            // 
            this.colTUTd.AppearanceHeader.Options.UseTextOptions = true;
            this.colTUTd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTUTd.Caption = "Tutar";
            this.colTUTd.DisplayFormat.FormatString = "n";
            this.colTUTd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTUTd.FieldName = "TUT";
            this.colTUTd.Name = "colTUTd";
            this.colTUTd.Visible = true;
            this.colTUTd.VisibleIndex = 2;
            // 
            // colDVZd
            // 
            this.colDVZd.AppearanceHeader.Options.UseTextOptions = true;
            this.colDVZd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVZd.Caption = "Dvz";
            this.colDVZd.FieldName = "DVZ";
            this.colDVZd.Name = "colDVZd";
            this.colDVZd.Visible = true;
            this.colDVZd.VisibleIndex = 3;
            this.colDVZd.Width = 44;
            // 
            // colKURd
            // 
            this.colKURd.AppearanceHeader.Options.UseTextOptions = true;
            this.colKURd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKURd.Caption = "Kur";
            this.colKURd.FieldName = "KUR";
            this.colKURd.Name = "colKURd";
            this.colKURd.OptionsColumn.AllowEdit = false;
            this.colKURd.OptionsColumn.AllowFocus = false;
            this.colKURd.Visible = true;
            this.colKURd.VisibleIndex = 4;
            this.colKURd.Width = 59;
            // 
            // arbGridControl
            // 
            this.arbGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.arbGridControl.DataSource = this.arbBindingSource;
            this.arbGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.arbDtyGridView;
            gridLevelNode1.RelationName = "ARB_ARD";
            this.arbGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.arbGridControl.Location = new System.Drawing.Point(0, 0);
            this.arbGridControl.MainView = this.arbGridView;
            this.arbGridControl.Name = "arbGridControl";
            this.arbGridControl.Size = new System.Drawing.Size(847, 302);
            this.arbGridControl.TabIndex = 4;
            this.arbGridControl.Tag = "ARB";
            this.arbGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.arbGridView,
            this.arbDtyGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem,
            this.acToolStripMenuItem,
            this.muhasebeFisiToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.dekontKapatToolStripMenuItem_Click);
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acToolStripMenuItem.Text = "Aç";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.dekontAcToolStripMenuItem_Click);
            // 
            // arbBindingSource
            // 
            this.arbBindingSource.DataMember = "ARB";
            this.arbBindingSource.DataSource = this.accountDataSet;
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arbGridView
            // 
            this.arbGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colARBID,
            this.colEDITABLE,
            this.colDRM,
            this.colTRH,
            this.colVDE,
            this.colBLGNO,
            this.colBRCFRTID,
            this.colBRCDVZ,
            this.colBRCKUR,
            this.colALCFRTID,
            this.colALCDVZ,
            this.colALCKUR,
            this.colOPID,
            this.colOPHM,
            this.colINFO,
            this.colONYUSR,
            this.colONYYTK,
            this.colONYTRH,
            this.colTUTTL});
            this.arbGridView.GridControl = this.arbGridControl;
            this.arbGridView.Name = "arbGridView";
            this.arbGridView.OptionsDetail.AllowExpandEmptyDetails = true;
            this.arbGridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.arbGridView.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.arbGridView_MasterRowGetChildList);
            this.arbGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.adbGridView_ShowingEditor);
            this.arbGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.adbGridView_InitNewRow);
            // 
            // colARBID
            // 
            this.colARBID.FieldName = "ARBID";
            this.colARBID.Name = "colARBID";
            this.colARBID.OptionsColumn.AllowEdit = false;
            this.colARBID.OptionsColumn.AllowFocus = false;
            this.colARBID.OptionsColumn.FixedWidth = true;
            this.colARBID.Visible = true;
            this.colARBID.VisibleIndex = 0;
            this.colARBID.Width = 60;
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
            this.colEDITABLE.Width = 20;
            // 
            // colDRM
            // 
            this.colDRM.Caption = "Drm";
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.OptionsColumn.AllowEdit = false;
            this.colDRM.OptionsColumn.AllowFocus = false;
            this.colDRM.OptionsColumn.FixedWidth = true;
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 2;
            this.colDRM.Width = 28;
            // 
            // colTRH
            // 
            this.colTRH.Caption = "Trh";
            this.colTRH.DisplayFormat.FormatString = "dd.MM.yy";
            this.colTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRH.FieldName = "TRH";
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.FixedWidth = true;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 3;
            this.colTRH.Width = 60;
            // 
            // colVDE
            // 
            this.colVDE.Caption = "Vde";
            this.colVDE.DisplayFormat.FormatString = "dd.MM.yy";
            this.colVDE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colVDE.FieldName = "VDE";
            this.colVDE.Name = "colVDE";
            this.colVDE.OptionsColumn.AllowEdit = false;
            this.colVDE.OptionsColumn.AllowFocus = false;
            this.colVDE.Visible = true;
            this.colVDE.VisibleIndex = 4;
            // 
            // colBLGNO
            // 
            this.colBLGNO.Caption = "BlgNo";
            this.colBLGNO.FieldName = "BLGNO";
            this.colBLGNO.Name = "colBLGNO";
            this.colBLGNO.Visible = true;
            this.colBLGNO.VisibleIndex = 5;
            // 
            // colBRCFRTID
            // 
            this.colBRCFRTID.Caption = "BrçFirma";
            this.colBRCFRTID.FieldName = "BRCFRTID";
            this.colBRCFRTID.Name = "colBRCFRTID";
            this.colBRCFRTID.Visible = true;
            this.colBRCFRTID.VisibleIndex = 6;
            this.colBRCFRTID.Width = 112;
            // 
            // colBRCDVZ
            // 
            this.colBRCDVZ.Caption = "BrçDvz";
            this.colBRCDVZ.FieldName = "BRCDVZ";
            this.colBRCDVZ.Name = "colBRCDVZ";
            this.colBRCDVZ.OptionsColumn.FixedWidth = true;
            this.colBRCDVZ.Visible = true;
            this.colBRCDVZ.VisibleIndex = 7;
            this.colBRCDVZ.Width = 44;
            // 
            // colBRCKUR
            // 
            this.colBRCKUR.Caption = "BrçKur";
            this.colBRCKUR.FieldName = "BRCKUR";
            this.colBRCKUR.MaxWidth = 60;
            this.colBRCKUR.Name = "colBRCKUR";
            this.colBRCKUR.OptionsColumn.AllowEdit = false;
            this.colBRCKUR.OptionsColumn.AllowFocus = false;
            this.colBRCKUR.Visible = true;
            this.colBRCKUR.VisibleIndex = 8;
            this.colBRCKUR.Width = 60;
            // 
            // colALCFRTID
            // 
            this.colALCFRTID.Caption = "AlcFirma";
            this.colALCFRTID.FieldName = "ALCFRTID";
            this.colALCFRTID.Name = "colALCFRTID";
            this.colALCFRTID.Visible = true;
            this.colALCFRTID.VisibleIndex = 9;
            this.colALCFRTID.Width = 175;
            // 
            // colALCDVZ
            // 
            this.colALCDVZ.Caption = "AlcDvz";
            this.colALCDVZ.FieldName = "ALCDVZ";
            this.colALCDVZ.Name = "colALCDVZ";
            this.colALCDVZ.OptionsColumn.FixedWidth = true;
            this.colALCDVZ.Visible = true;
            this.colALCDVZ.VisibleIndex = 10;
            this.colALCDVZ.Width = 44;
            // 
            // colALCKUR
            // 
            this.colALCKUR.Caption = "AlcKur";
            this.colALCKUR.FieldName = "ALCKUR";
            this.colALCKUR.MaxWidth = 60;
            this.colALCKUR.Name = "colALCKUR";
            this.colALCKUR.OptionsColumn.AllowEdit = false;
            this.colALCKUR.OptionsColumn.AllowFocus = false;
            this.colALCKUR.Visible = true;
            this.colALCKUR.VisibleIndex = 11;
            this.colALCKUR.Width = 57;
            // 
            // colOPID
            // 
            this.colOPID.Caption = "OpID";
            this.colOPID.FieldName = "OPID";
            this.colOPID.Name = "colOPID";
            this.colOPID.OptionsColumn.AllowEdit = false;
            this.colOPID.OptionsColumn.AllowFocus = false;
            this.colOPID.OptionsColumn.FixedWidth = true;
            this.colOPID.Visible = true;
            this.colOPID.VisibleIndex = 13;
            this.colOPID.Width = 60;
            // 
            // colOPHM
            // 
            this.colOPHM.Caption = "OpHM";
            this.colOPHM.FieldName = "OPHM";
            this.colOPHM.Name = "colOPHM";
            this.colOPHM.OptionsColumn.AllowEdit = false;
            this.colOPHM.OptionsColumn.AllowFocus = false;
            this.colOPHM.OptionsColumn.FixedWidth = true;
            this.colOPHM.Visible = true;
            this.colOPHM.VisibleIndex = 14;
            this.colOPHM.Width = 40;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Info";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 12;
            this.colINFO.Width = 102;
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
            // colONYYTK
            // 
            this.colONYYTK.Caption = "OnyYtk";
            this.colONYYTK.FieldName = "ONYYTK";
            this.colONYYTK.Name = "colONYYTK";
            this.colONYYTK.OptionsColumn.AllowEdit = false;
            this.colONYYTK.OptionsColumn.AllowFocus = false;
            this.colONYYTK.OptionsColumn.FixedWidth = true;
            this.colONYYTK.Visible = true;
            this.colONYYTK.VisibleIndex = 16;
            this.colONYYTK.Width = 50;
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
            this.colONYTRH.VisibleIndex = 17;
            this.colONYTRH.Width = 60;
            // 
            // colTUTTL
            // 
            this.colTUTTL.Caption = "Tut TL";
            this.colTUTTL.DisplayFormat.FormatString = "n";
            this.colTUTTL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTUTTL.FieldName = "TUTTL";
            this.colTUTTL.Name = "colTUTTL";
            this.colTUTTL.OptionsColumn.AllowEdit = false;
            this.colTUTTL.OptionsColumn.AllowFocus = false;
            this.colTUTTL.Visible = true;
            this.colTUTTL.VisibleIndex = 18;
            // 
            // arbTableAdapter
            // 
            this.arbTableAdapter.ClearBeforeFill = true;
            // 
            // ardTableAdapter
            // 
            this.ardTableAdapter.ClearBeforeFill = true;
            // 
            // muhasebeFisiToolStripMenuItem
            // 
            this.muhasebeFisiToolStripMenuItem.Name = "muhasebeFisiToolStripMenuItem";
            this.muhasebeFisiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.muhasebeFisiToolStripMenuItem.Text = "Muhasebe Fişi";
            this.muhasebeFisiToolStripMenuItem.Click += new System.EventHandler(this.muhasebeFisiToolStripMenuItem_Click);
            // 
            // DekontXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 302);
            this.Controls.Add(this.arbGridControl);
            this.Name = "DekontXF";
            this.Text = "DekontXF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DekontXF_FormClosing);
            this.Load += new System.EventHandler(this.DekontXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arbDtyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.arbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSetTableAdapters.AccountQueriesTableAdapter accountQueriesTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource arbBindingSource;
        private DevExpress.XtraGrid.GridControl arbGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView arbGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colARBID;
        private DevExpress.XtraGrid.Columns.GridColumn colEDITABLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colBRCFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colBRCDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colBRCKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colALCFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colALCDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colALCKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colOPID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPHM;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colONYUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colONYYTK;
        private DevExpress.XtraGrid.Columns.GridColumn colONYTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colBLGNO;
        private AccountDataSetTableAdapters.ARBTableAdapter arbTableAdapter;
        private AccountDataSetTableAdapters.ARDTableAdapter ardTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView arbDtyGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colARDIDd;
        private DevExpress.XtraGrid.Columns.GridColumn colARBIDd;
        private DevExpress.XtraGrid.Columns.GridColumn colAHTIDd;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTd;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZd;
        private DevExpress.XtraGrid.Columns.GridColumn colKURd;
        private DevExpress.XtraGrid.Columns.GridColumn colVDE;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTTL;
        private System.Windows.Forms.ToolStripMenuItem muhasebeFisiToolStripMenuItem;
    }
}
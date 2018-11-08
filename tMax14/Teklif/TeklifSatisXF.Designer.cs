namespace tMax14.Teklif
{
    partial class TeklifSatisXF
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
            this.teklifDataSet = new tMax14.Teklif.TeklifDataSet();
            this.tsbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsbTableAdapter = new tMax14.Teklif.TeklifDataSetTableAdapters.TSBTableAdapter();
            this.tsbGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTSBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDITABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STUrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colTYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TYPrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colTOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGCRTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORGS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFNLDST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.INFOrepositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colCRRIDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMDTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DFrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colDR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DRrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colDTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONVOL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYYTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTLOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAGS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBKMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tafQueriesTableAdapter = new tMax14.Teklif.TeklifDataSetTableAdapters.TeklifQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teklifDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TYPrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INFOrepositoryItemMemoExEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DFrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRrepositoryItemImageComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // teklifDataSet
            // 
            this.teklifDataSet.DataSetName = "TeklifDataSet";
            this.teklifDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tsbBindingSource
            // 
            this.tsbBindingSource.DataMember = "TSB";
            this.tsbBindingSource.DataSource = this.teklifDataSet;
            // 
            // tsbTableAdapter
            // 
            this.tsbTableAdapter.ClearBeforeFill = true;
            // 
            // tsbGridControl
            // 
            this.tsbGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.tsbGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tsbGridControl.DataSource = this.tsbBindingSource;
            this.tsbGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsbGridControl.Location = new System.Drawing.Point(0, 0);
            this.tsbGridControl.MainView = this.tsbGridView;
            this.tsbGridControl.Name = "tsbGridControl";
            this.tsbGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TYPrepositoryItemImageComboBox,
            this.DFrepositoryItemImageComboBox,
            this.DRrepositoryItemImageComboBox,
            this.STUrepositoryItemImageComboBox,
            this.INFOrepositoryItemMemoExEdit});
            this.tsbGridControl.Size = new System.Drawing.Size(1319, 345);
            this.tsbGridControl.TabIndex = 1;
            this.tsbGridControl.Tag = "Teklif.TeklifSatisXF";
            this.tsbGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tsbGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutsToolStripMenuItem,
            this.onaylaToolStripMenuItem,
            this.attachmentToolStripMenuItem,
            this.bookmarkeToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.denemeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(166, 136);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // onaylaToolStripMenuItem
            // 
            this.onaylaToolStripMenuItem.Name = "onaylaToolStripMenuItem";
            this.onaylaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.onaylaToolStripMenuItem.Text = "Onayla";
            this.onaylaToolStripMenuItem.Click += new System.EventHandler(this.onaylaToolStripMenuItem_Click);
            // 
            // attachmentToolStripMenuItem
            // 
            this.attachmentToolStripMenuItem.Name = "attachmentToolStripMenuItem";
            this.attachmentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.attachmentToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.attachmentToolStripMenuItem.Text = "Attachment";
            this.attachmentToolStripMenuItem.Click += new System.EventHandler(this.attachmentToolStripMenuItem_Click);
            // 
            // bookmarkeToolStripMenuItem
            // 
            this.bookmarkeToolStripMenuItem.Name = "bookmarkeToolStripMenuItem";
            this.bookmarkeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.bookmarkeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.bookmarkeToolStripMenuItem.Text = "Bookmark";
            this.bookmarkeToolStripMenuItem.Click += new System.EventHandler(this.bookmarkeToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.denemeToolStripMenuItem.Text = "deneme";
            this.denemeToolStripMenuItem.Click += new System.EventHandler(this.denemeToolStripMenuItem_Click);
            // 
            // tsbGridView
            // 
            this.tsbGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTSBID,
            this.colEDITABLE,
            this.colFRTID,
            this.colSTU,
            this.colTYP,
            this.colTOB,
            this.colGCRTRH,
            this.colDVZ,
            this.colTOP,
            this.colROT,
            this.colMOT,
            this.colORGS,
            this.colDSTS,
            this.colFNLDST,
            this.colPTM,
            this.colINFO,
            this.colCRRIDS,
            this.colCMDTY,
            this.colEXD,
            this.colDF,
            this.colDR,
            this.colDTM,
            this.colMONVOL,
            this.colONYTRH,
            this.colONYUSR,
            this.colONYYTK,
            this.colFRTDRM,
            this.colFRTLOC,
            this.colTAGS,
            this.colBKMS});
            this.tsbGridView.GridControl = this.tsbGridControl;
            this.tsbGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TSBID", null, "{0:n0} adet")});
            this.tsbGridView.Name = "tsbGridView";
            this.tsbGridView.OptionsView.ColumnAutoWidth = false;
            this.tsbGridView.OptionsView.ShowFooter = true;
            this.tsbGridView.CustomDrawRowFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.tsbGridView_CustomDrawRowFooterCell);
            this.tsbGridView.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.tsbGridView_CustomDrawGroupRow);
            this.tsbGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.tsbGridView_InitNewRow);
            // 
            // colTSBID
            // 
            this.colTSBID.FieldName = "TSBID";
            this.colTSBID.Name = "colTSBID";
            this.colTSBID.OptionsColumn.AllowEdit = false;
            this.colTSBID.OptionsColumn.AllowFocus = false;
            this.colTSBID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TSBID", "{0}")});
            this.colTSBID.Visible = true;
            this.colTSBID.VisibleIndex = 0;
            // 
            // colEDITABLE
            // 
            this.colEDITABLE.Caption = "E";
            this.colEDITABLE.FieldName = "EDITABLE";
            this.colEDITABLE.Name = "colEDITABLE";
            this.colEDITABLE.OptionsColumn.AllowEdit = false;
            this.colEDITABLE.OptionsColumn.AllowFocus = false;
            this.colEDITABLE.Visible = true;
            this.colEDITABLE.VisibleIndex = 1;
            this.colEDITABLE.Width = 22;
            // 
            // colFRTID
            // 
            this.colFRTID.Caption = "Firma";
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 4;
            // 
            // colSTU
            // 
            this.colSTU.Caption = "Stu";
            this.colSTU.ColumnEdit = this.STUrepositoryItemImageComboBox;
            this.colSTU.FieldName = "STU";
            this.colSTU.Name = "colSTU";
            this.colSTU.Visible = true;
            this.colSTU.VisibleIndex = 3;
            // 
            // STUrepositoryItemImageComboBox
            // 
            this.STUrepositoryItemImageComboBox.AutoHeight = false;
            this.STUrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.STUrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Accepted", "A", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Overtime", "O", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pending", "P", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Refused", "R", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cancelled", "C", -1)});
            this.STUrepositoryItemImageComboBox.Name = "STUrepositoryItemImageComboBox";
            // 
            // colTYP
            // 
            this.colTYP.Caption = "Type";
            this.colTYP.ColumnEdit = this.TYPrepositoryItemImageComboBox;
            this.colTYP.FieldName = "TYP";
            this.colTYP.Name = "colTYP";
            this.colTYP.Visible = true;
            this.colTYP.VisibleIndex = 7;
            this.colTYP.Width = 40;
            // 
            // TYPrepositoryItemImageComboBox
            // 
            this.TYPrepositoryItemImageComboBox.AutoHeight = false;
            this.TYPrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TYPrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Genel", "G", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Spot", "S", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tarife", "T", -1)});
            this.TYPrepositoryItemImageComboBox.Name = "TYPrepositoryItemImageComboBox";
            // 
            // colTOB
            // 
            this.colTOB.FieldName = "TOB";
            this.colTOB.Name = "colTOB";
            this.colTOB.Visible = true;
            this.colTOB.VisibleIndex = 8;
            this.colTOB.Width = 48;
            // 
            // colGCRTRH
            // 
            this.colGCRTRH.Caption = "GçrTrh";
            this.colGCRTRH.FieldName = "GCRTRH";
            this.colGCRTRH.Name = "colGCRTRH";
            this.colGCRTRH.Visible = true;
            this.colGCRTRH.VisibleIndex = 9;
            this.colGCRTRH.Width = 67;
            // 
            // colDVZ
            // 
            this.colDVZ.Caption = "Dvz";
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 10;
            this.colDVZ.Width = 39;
            // 
            // colTOP
            // 
            this.colTOP.FieldName = "TOP";
            this.colTOP.Name = "colTOP";
            this.colTOP.Visible = true;
            this.colTOP.VisibleIndex = 11;
            this.colTOP.Width = 78;
            // 
            // colROT
            // 
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 14;
            this.colROT.Width = 31;
            // 
            // colMOT
            // 
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 15;
            this.colMOT.Width = 33;
            // 
            // colORGS
            // 
            this.colORGS.Caption = "Org(s)";
            this.colORGS.FieldName = "ORGS";
            this.colORGS.Name = "colORGS";
            this.colORGS.Visible = true;
            this.colORGS.VisibleIndex = 16;
            // 
            // colDSTS
            // 
            this.colDSTS.Caption = "Dst(s)";
            this.colDSTS.FieldName = "DSTS";
            this.colDSTS.Name = "colDSTS";
            this.colDSTS.Visible = true;
            this.colDSTS.VisibleIndex = 17;
            // 
            // colFNLDST
            // 
            this.colFNLDST.Caption = "FnlDst";
            this.colFNLDST.FieldName = "FNLDST";
            this.colFNLDST.Name = "colFNLDST";
            this.colFNLDST.Visible = true;
            this.colFNLDST.VisibleIndex = 18;
            // 
            // colPTM
            // 
            this.colPTM.FieldName = "PTM";
            this.colPTM.Name = "colPTM";
            this.colPTM.Visible = true;
            this.colPTM.VisibleIndex = 13;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Info";
            this.colINFO.ColumnEdit = this.INFOrepositoryItemMemoExEdit;
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 25;
            this.colINFO.Width = 78;
            // 
            // INFOrepositoryItemMemoExEdit
            // 
            this.INFOrepositoryItemMemoExEdit.AutoHeight = false;
            this.INFOrepositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.INFOrepositoryItemMemoExEdit.Name = "INFOrepositoryItemMemoExEdit";
            // 
            // colCRRIDS
            // 
            this.colCRRIDS.Caption = "Carriers";
            this.colCRRIDS.FieldName = "CRRIDS";
            this.colCRRIDS.Name = "colCRRIDS";
            this.colCRRIDS.ToolTip = "Prefered Carriers";
            this.colCRRIDS.Visible = true;
            this.colCRRIDS.VisibleIndex = 22;
            this.colCRRIDS.Width = 78;
            // 
            // colCMDTY
            // 
            this.colCMDTY.FieldName = "CMDTY";
            this.colCMDTY.Name = "colCMDTY";
            this.colCMDTY.ToolTip = "Commodity";
            this.colCMDTY.Visible = true;
            this.colCMDTY.VisibleIndex = 23;
            this.colCMDTY.Width = 87;
            // 
            // colEXD
            // 
            this.colEXD.FieldName = "EXD";
            this.colEXD.Name = "colEXD";
            this.colEXD.OptionsColumn.AllowEdit = false;
            this.colEXD.OptionsColumn.AllowFocus = false;
            this.colEXD.Visible = true;
            this.colEXD.VisibleIndex = 2;
            // 
            // colDF
            // 
            this.colDF.ColumnEdit = this.DFrepositoryItemImageComboBox;
            this.colDF.FieldName = "DF";
            this.colDF.Name = "colDF";
            this.colDF.Visible = true;
            this.colDF.VisibleIndex = 19;
            this.colDF.Width = 49;
            // 
            // DFrepositoryItemImageComboBox
            // 
            this.DFrepositoryItemImageComboBox.AutoHeight = false;
            this.DFrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DFrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Direct", "D", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Forwarder", "F", -1)});
            this.DFrepositoryItemImageComboBox.Name = "DFrepositoryItemImageComboBox";
            // 
            // colDR
            // 
            this.colDR.ColumnEdit = this.DRrepositoryItemImageComboBox;
            this.colDR.FieldName = "DR";
            this.colDR.Name = "colDR";
            this.colDR.Visible = true;
            this.colDR.VisibleIndex = 20;
            this.colDR.Width = 51;
            // 
            // DRrepositoryItemImageComboBox
            // 
            this.DRrepositoryItemImageComboBox.AutoHeight = false;
            this.DRrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DRrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("NorthBound", "N", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("SouthBound", "S", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("RoundTrip", "R", -1)});
            this.DRrepositoryItemImageComboBox.Name = "DRrepositoryItemImageComboBox";
            // 
            // colDTM
            // 
            this.colDTM.FieldName = "DTM";
            this.colDTM.Name = "colDTM";
            this.colDTM.Visible = true;
            this.colDTM.VisibleIndex = 12;
            // 
            // colMONVOL
            // 
            this.colMONVOL.Caption = "Vol/Month";
            this.colMONVOL.FieldName = "MONVOL";
            this.colMONVOL.Name = "colMONVOL";
            this.colMONVOL.Visible = true;
            this.colMONVOL.VisibleIndex = 21;
            // 
            // colONYTRH
            // 
            this.colONYTRH.Caption = "OnyTrh";
            this.colONYTRH.FieldName = "ONYTRH";
            this.colONYTRH.Name = "colONYTRH";
            this.colONYTRH.OptionsColumn.AllowEdit = false;
            this.colONYTRH.OptionsColumn.AllowFocus = false;
            this.colONYTRH.Visible = true;
            this.colONYTRH.VisibleIndex = 28;
            // 
            // colONYUSR
            // 
            this.colONYUSR.Caption = "OnyUsr";
            this.colONYUSR.FieldName = "ONYUSR";
            this.colONYUSR.Name = "colONYUSR";
            this.colONYUSR.OptionsColumn.AllowEdit = false;
            this.colONYUSR.OptionsColumn.AllowFocus = false;
            this.colONYUSR.Visible = true;
            this.colONYUSR.VisibleIndex = 27;
            this.colONYUSR.Width = 53;
            // 
            // colONYYTK
            // 
            this.colONYYTK.Caption = "OnyYtk";
            this.colONYYTK.FieldName = "ONYYTK";
            this.colONYYTK.Name = "colONYYTK";
            this.colONYYTK.OptionsColumn.AllowEdit = false;
            this.colONYYTK.OptionsColumn.AllowFocus = false;
            this.colONYYTK.Visible = true;
            this.colONYYTK.VisibleIndex = 26;
            this.colONYYTK.Width = 53;
            // 
            // colFRTDRM
            // 
            this.colFRTDRM.Caption = "FrmDrm";
            this.colFRTDRM.FieldName = "FRTDRM";
            this.colFRTDRM.Name = "colFRTDRM";
            this.colFRTDRM.OptionsColumn.AllowEdit = false;
            this.colFRTDRM.OptionsColumn.AllowFocus = false;
            this.colFRTDRM.Visible = true;
            this.colFRTDRM.VisibleIndex = 5;
            // 
            // colFRTLOC
            // 
            this.colFRTLOC.Caption = "FrmLoc";
            this.colFRTLOC.FieldName = "FRTLOC";
            this.colFRTLOC.Name = "colFRTLOC";
            this.colFRTLOC.OptionsColumn.AllowEdit = false;
            this.colFRTLOC.OptionsColumn.AllowFocus = false;
            this.colFRTLOC.Visible = true;
            this.colFRTLOC.VisibleIndex = 6;
            // 
            // colTAGS
            // 
            this.colTAGS.Caption = "TAGs";
            this.colTAGS.FieldName = "TAGS";
            this.colTAGS.Name = "colTAGS";
            this.colTAGS.Visible = true;
            this.colTAGS.VisibleIndex = 24;
            // 
            // colBKMS
            // 
            this.colBKMS.FieldName = "BKMS";
            this.colBKMS.Name = "colBKMS";
            this.colBKMS.OptionsColumn.AllowEdit = false;
            this.colBKMS.OptionsColumn.AllowFocus = false;
            // 
            // TeklifSatisXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 345);
            this.Controls.Add(this.tsbGridControl);
            this.Name = "TeklifSatisXF";
            this.Text = "TeklifSatisXF";
            this.Load += new System.EventHandler(this.TeklifSatisXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teklifDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tsbGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TYPrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INFOrepositoryItemMemoExEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DFrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRrepositoryItemImageComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TeklifDataSet teklifDataSet;
        private System.Windows.Forms.BindingSource tsbBindingSource;
        private TeklifDataSetTableAdapters.TSBTableAdapter tsbTableAdapter;
        private DevExpress.XtraGrid.GridControl tsbGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView tsbGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTSBID;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colGCRTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colTOP;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colCRRIDS;
        private DevExpress.XtraGrid.Columns.GridColumn colCMDTY;
        private TeklifDataSetTableAdapters.TeklifQueriesTableAdapter tafQueriesTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TYPrepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colEXD;
        private DevExpress.XtraGrid.Columns.GridColumn colDF;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox DFrepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colDR;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox DRrepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colDSTS;
        private DevExpress.XtraGrid.Columns.GridColumn colDTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMONVOL;
        private DevExpress.XtraGrid.Columns.GridColumn colONYTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colONYUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colONYYTK;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTLOC;
        private System.Windows.Forms.ToolStripMenuItem onaylaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarkeToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTAGS;
        private DevExpress.XtraGrid.Columns.GridColumn colBKMS;
        private DevExpress.XtraGrid.Columns.GridColumn colORGS;
        private DevExpress.XtraGrid.Columns.GridColumn colSTU;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox STUrepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colPTM;
        private DevExpress.XtraGrid.Columns.GridColumn colEDITABLE;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit INFOrepositoryItemMemoExEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colFNLDST;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTOB;
    }
}
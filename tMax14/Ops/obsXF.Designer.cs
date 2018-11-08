namespace tMax14.Ops
{
    partial class obsXF
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
            this.opsDataSet = new tMax14.Ops.OpsDataSet();
            this.obsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obsTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.OBSTableAdapter();
            this.tableAdapterManager = new tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager();
            this.obsGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stoklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jurnalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOBSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDITABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STUrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colACCAGNID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPNSRID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACCNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCROID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVESTIGATOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTACT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITELOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITEDPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSTLABID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAIRPORTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWRKDAYS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WRKDAYSrepositoryItemCheckedComboBoxEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.colWRKTIMES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WRKTIMESrepositoryItemCheckedComboBoxEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.colPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PBrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colSMPTYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SMPTYPrepositoryItemCheckedComboBoxEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.colDRYICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DRYICErepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colBOXTYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BOXTYPrepositoryItemCheckedComboBoxEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.colSTARTDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENDDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYYTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITELOCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.onaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WRKDAYSrepositoryItemCheckedComboBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WRKTIMESrepositoryItemCheckedComboBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMPTYPrepositoryItemCheckedComboBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRYICErepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOXTYPrepositoryItemCheckedComboBoxEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obsBindingSource
            // 
            this.obsBindingSource.DataMember = "OBS";
            this.obsBindingSource.DataSource = this.opsDataSet;
            // 
            // obsTableAdapter
            // 
            this.obsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AFDO_SELTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OBSDTableAdapter = null;
            this.tableAdapterManager.OBSTableAdapter = this.obsTableAdapter;
            this.tableAdapterManager.OPCCTableAdapter = null;
            this.tableAdapterManager.OPCTableAdapter = null;
            this.tableAdapterManager.OPH_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPH_SELTableAdapter = null;
            this.tableAdapterManager.OPHTableAdapter = null;
            this.tableAdapterManager.OPM_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPM_CNTR_LOADTableAdapter = null;
            this.tableAdapterManager.OPM_SELTableAdapter = null;
            this.tableAdapterManager.OPM2TableAdapter = null;
            this.tableAdapterManager.OPMATableAdapter = null;
            this.tableAdapterManager.OPMCTableAdapter = null;
            this.tableAdapterManager.OPMITableAdapter = null;
            this.tableAdapterManager.OPMTableAdapter = null;
            this.tableAdapterManager.OPOSTableAdapter = null;
            this.tableAdapterManager.OPOTableAdapter = null;
            this.tableAdapterManager.OPP_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPPTableAdapter = null;
            this.tableAdapterManager.OPRH_SEL_DISTableAdapter = null;
            this.tableAdapterManager.PRFTableAdapter = null;
            this.tableAdapterManager.PRSTableAdapter = null;
            this.tableAdapterManager.PRTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZMSLTableAdapter = null;
            // 
            // obsGridControl
            // 
            this.obsGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.obsGridControl.DataSource = this.obsBindingSource;
            this.obsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obsGridControl.Location = new System.Drawing.Point(0, 0);
            this.obsGridControl.MainView = this.obsGridView;
            this.obsGridControl.Name = "obsGridControl";
            this.obsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.STUrepositoryItemImageComboBox,
            this.WRKDAYSrepositoryItemCheckedComboBoxEdit,
            this.WRKTIMESrepositoryItemCheckedComboBoxEdit,
            this.SMPTYPrepositoryItemCheckedComboBoxEdit,
            this.BOXTYPrepositoryItemCheckedComboBoxEdit,
            this.PBrepositoryItemImageComboBox,
            this.DRYICErepositoryItemImageComboBox});
            this.obsGridControl.Size = new System.Drawing.Size(1212, 321);
            this.obsGridControl.TabIndex = 1;
            this.obsGridControl.Tag = "OBS";
            this.obsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.obsGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stoklarToolStripMenuItem,
            this.attachmentsToolStripMenuItem,
            this.jurnalToolStripMenuItem,
            this.onaylaToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 114);
            // 
            // stoklarToolStripMenuItem
            // 
            this.stoklarToolStripMenuItem.Name = "stoklarToolStripMenuItem";
            this.stoklarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stoklarToolStripMenuItem.Text = "Stoklar";
            this.stoklarToolStripMenuItem.Click += new System.EventHandler(this.stoklarToolStripMenuItem_Click);
            // 
            // attachmentsToolStripMenuItem
            // 
            this.attachmentsToolStripMenuItem.Name = "attachmentsToolStripMenuItem";
            this.attachmentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.attachmentsToolStripMenuItem.Text = "Attachments";
            this.attachmentsToolStripMenuItem.Click += new System.EventHandler(this.attachmentsToolStripMenuItem_Click);
            // 
            // jurnalToolStripMenuItem
            // 
            this.jurnalToolStripMenuItem.Name = "jurnalToolStripMenuItem";
            this.jurnalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jurnalToolStripMenuItem.Text = "Jurnal";
            this.jurnalToolStripMenuItem.Click += new System.EventHandler(this.jurnalToolStripMenuItem_Click);
            // 
            // obsGridView
            // 
            this.obsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOBSID,
            this.colEDITABLE,
            this.colSTU,
            this.colACCAGNID,
            this.colSPNSRID,
            this.colPRTNO,
            this.colACCNO,
            this.colSITENO,
            this.colCROID,
            this.colINVESTIGATOR,
            this.colCONTACT,
            this.colSITEID,
            this.colSITELOC,
            this.colSITEDPT,
            this.colDSTLABID,
            this.colAIRPORTID,
            this.colWRKDAYS,
            this.colWRKTIMES,
            this.colPB,
            this.colSMPTYP,
            this.colDRYICE,
            this.colBOXTYP,
            this.colSTARTDATE,
            this.colENDDATE,
            this.colINFO,
            this.colONYUSR,
            this.colONYYTK,
            this.colONYTRH,
            this.colSITELOCID});
            this.obsGridView.GridControl = this.obsGridControl;
            this.obsGridView.Name = "obsGridView";
            this.obsGridView.OptionsView.ColumnAutoWidth = false;
            this.obsGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // colOBSID
            // 
            this.colOBSID.FieldName = "OBSID";
            this.colOBSID.Name = "colOBSID";
            this.colOBSID.OptionsColumn.AllowEdit = false;
            this.colOBSID.OptionsColumn.AllowFocus = false;
            this.colOBSID.Visible = true;
            this.colOBSID.VisibleIndex = 0;
            this.colOBSID.Width = 53;
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
            // colSTU
            // 
            this.colSTU.Caption = "Statu";
            this.colSTU.ColumnEdit = this.STUrepositoryItemImageComboBox;
            this.colSTU.FieldName = "STU";
            this.colSTU.Name = "colSTU";
            this.colSTU.Visible = true;
            this.colSTU.VisibleIndex = 2;
            this.colSTU.Width = 39;
            // 
            // STUrepositoryItemImageComboBox
            // 
            this.STUrepositoryItemImageComboBox.AutoHeight = false;
            this.STUrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.STUrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("New", "N", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Ongoing", "O", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cancelled", "C", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Aborted", "A", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Finished", "F", -1)});
            this.STUrepositoryItemImageComboBox.Name = "STUrepositoryItemImageComboBox";
            // 
            // colACCAGNID
            // 
            this.colACCAGNID.Caption = "AccAgnt";
            this.colACCAGNID.FieldName = "ACCAGNID";
            this.colACCAGNID.Name = "colACCAGNID";
            this.colACCAGNID.ToolTip = "Account Agent";
            this.colACCAGNID.Visible = true;
            this.colACCAGNID.VisibleIndex = 3;
            this.colACCAGNID.Width = 60;
            // 
            // colSPNSRID
            // 
            this.colSPNSRID.Caption = "Sponsor";
            this.colSPNSRID.FieldName = "SPNSRID";
            this.colSPNSRID.Name = "colSPNSRID";
            this.colSPNSRID.Visible = true;
            this.colSPNSRID.VisibleIndex = 4;
            this.colSPNSRID.Width = 59;
            // 
            // colPRTNO
            // 
            this.colPRTNO.Caption = "PrtNo";
            this.colPRTNO.FieldName = "PRTNO";
            this.colPRTNO.Name = "colPRTNO";
            this.colPRTNO.Visible = true;
            this.colPRTNO.VisibleIndex = 5;
            this.colPRTNO.Width = 47;
            // 
            // colACCNO
            // 
            this.colACCNO.Caption = "AccNo";
            this.colACCNO.FieldName = "ACCNO";
            this.colACCNO.Name = "colACCNO";
            this.colACCNO.ToolTip = "Account No";
            this.colACCNO.Visible = true;
            this.colACCNO.VisibleIndex = 6;
            this.colACCNO.Width = 50;
            // 
            // colSITENO
            // 
            this.colSITENO.Caption = "SiteNo";
            this.colSITENO.FieldName = "SITENO";
            this.colSITENO.Name = "colSITENO";
            this.colSITENO.Visible = true;
            this.colSITENO.VisibleIndex = 7;
            this.colSITENO.Width = 51;
            // 
            // colCROID
            // 
            this.colCROID.Caption = "CRO";
            this.colCROID.FieldName = "CROID";
            this.colCROID.Name = "colCROID";
            this.colCROID.Visible = true;
            this.colCROID.VisibleIndex = 8;
            // 
            // colINVESTIGATOR
            // 
            this.colINVESTIGATOR.Caption = "Investigator";
            this.colINVESTIGATOR.FieldName = "INVESTIGATOR";
            this.colINVESTIGATOR.Name = "colINVESTIGATOR";
            this.colINVESTIGATOR.Visible = true;
            this.colINVESTIGATOR.VisibleIndex = 9;
            this.colINVESTIGATOR.Width = 79;
            // 
            // colCONTACT
            // 
            this.colCONTACT.Caption = "Contact";
            this.colCONTACT.FieldName = "CONTACT";
            this.colCONTACT.Name = "colCONTACT";
            this.colCONTACT.Visible = true;
            this.colCONTACT.VisibleIndex = 11;
            // 
            // colSITEID
            // 
            this.colSITEID.Caption = "Site";
            this.colSITEID.FieldName = "SITEID";
            this.colSITEID.Name = "colSITEID";
            this.colSITEID.Visible = true;
            this.colSITEID.VisibleIndex = 10;
            // 
            // colSITELOC
            // 
            this.colSITELOC.Caption = "SiteLoc";
            this.colSITELOC.FieldName = "SITELOC";
            this.colSITELOC.Name = "colSITELOC";
            this.colSITELOC.OptionsColumn.AllowEdit = false;
            this.colSITELOC.OptionsColumn.AllowFocus = false;
            this.colSITELOC.Visible = true;
            this.colSITELOC.VisibleIndex = 12;
            // 
            // colSITEDPT
            // 
            this.colSITEDPT.Caption = "SiteDpt";
            this.colSITEDPT.FieldName = "SITEDPT";
            this.colSITEDPT.Name = "colSITEDPT";
            this.colSITEDPT.ToolTip = "Site Department";
            this.colSITEDPT.Visible = true;
            this.colSITEDPT.VisibleIndex = 13;
            // 
            // colDSTLABID
            // 
            this.colDSTLABID.Caption = "DstLab";
            this.colDSTLABID.FieldName = "DSTLABID";
            this.colDSTLABID.Name = "colDSTLABID";
            this.colDSTLABID.ToolTip = "Destination Lab";
            this.colDSTLABID.Visible = true;
            this.colDSTLABID.VisibleIndex = 14;
            // 
            // colAIRPORTID
            // 
            this.colAIRPORTID.Caption = "Airport";
            this.colAIRPORTID.FieldName = "AIRPORTID";
            this.colAIRPORTID.Name = "colAIRPORTID";
            this.colAIRPORTID.Visible = true;
            this.colAIRPORTID.VisibleIndex = 15;
            // 
            // colWRKDAYS
            // 
            this.colWRKDAYS.Caption = "WokDays";
            this.colWRKDAYS.ColumnEdit = this.WRKDAYSrepositoryItemCheckedComboBoxEdit;
            this.colWRKDAYS.FieldName = "WRKDAYS";
            this.colWRKDAYS.Name = "colWRKDAYS";
            this.colWRKDAYS.Visible = true;
            this.colWRKDAYS.VisibleIndex = 16;
            // 
            // WRKDAYSrepositoryItemCheckedComboBoxEdit
            // 
            this.WRKDAYSrepositoryItemCheckedComboBoxEdit.AutoHeight = false;
            this.WRKDAYSrepositoryItemCheckedComboBoxEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WRKDAYSrepositoryItemCheckedComboBoxEdit.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("WD", "WeekDays"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("WE", "WeekEnds"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("HD", "Holidays"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("AD", "All Days")});
            this.WRKDAYSrepositoryItemCheckedComboBoxEdit.Name = "WRKDAYSrepositoryItemCheckedComboBoxEdit";
            // 
            // colWRKTIMES
            // 
            this.colWRKTIMES.Caption = "WorkTimes";
            this.colWRKTIMES.ColumnEdit = this.WRKTIMESrepositoryItemCheckedComboBoxEdit;
            this.colWRKTIMES.FieldName = "WRKTIMES";
            this.colWRKTIMES.Name = "colWRKTIMES";
            this.colWRKTIMES.Visible = true;
            this.colWRKTIMES.VisibleIndex = 17;
            // 
            // WRKTIMESrepositoryItemCheckedComboBoxEdit
            // 
            this.WRKTIMESrepositoryItemCheckedComboBoxEdit.AutoHeight = false;
            this.WRKTIMESrepositoryItemCheckedComboBoxEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WRKTIMESrepositoryItemCheckedComboBoxEdit.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("WT", "WorkingTimes"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("OH", "OutOfHours"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("AT", "AllTimes")});
            this.WRKTIMESrepositoryItemCheckedComboBoxEdit.Name = "WRKTIMESrepositoryItemCheckedComboBoxEdit";
            // 
            // colPB
            // 
            this.colPB.Caption = "P/B";
            this.colPB.ColumnEdit = this.PBrepositoryItemImageComboBox;
            this.colPB.FieldName = "PB";
            this.colPB.Name = "colPB";
            this.colPB.Visible = true;
            this.colPB.VisibleIndex = 18;
            // 
            // PBrepositoryItemImageComboBox
            // 
            this.PBrepositoryItemImageComboBox.AutoHeight = false;
            this.PBrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PBrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Primary", "P", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Backup", "B", -1)});
            this.PBrepositoryItemImageComboBox.Name = "PBrepositoryItemImageComboBox";
            // 
            // colSMPTYP
            // 
            this.colSMPTYP.Caption = "Sample";
            this.colSMPTYP.ColumnEdit = this.SMPTYPrepositoryItemCheckedComboBoxEdit;
            this.colSMPTYP.FieldName = "SMPTYP";
            this.colSMPTYP.Name = "colSMPTYP";
            this.colSMPTYP.Visible = true;
            this.colSMPTYP.VisibleIndex = 19;
            // 
            // SMPTYPrepositoryItemCheckedComboBoxEdit
            // 
            this.SMPTYPrepositoryItemCheckedComboBoxEdit.AutoHeight = false;
            this.SMPTYPrepositoryItemCheckedComboBoxEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SMPTYPrepositoryItemCheckedComboBoxEdit.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("A", "Ambient"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("F", "Frozen"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("C", "Cooled"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("R", "Refeer")});
            this.SMPTYPrepositoryItemCheckedComboBoxEdit.Name = "SMPTYPrepositoryItemCheckedComboBoxEdit";
            // 
            // colDRYICE
            // 
            this.colDRYICE.Caption = "DryIce";
            this.colDRYICE.ColumnEdit = this.DRYICErepositoryItemImageComboBox;
            this.colDRYICE.FieldName = "DRYICE";
            this.colDRYICE.Name = "colDRYICE";
            this.colDRYICE.Visible = true;
            this.colDRYICE.VisibleIndex = 20;
            // 
            // DRYICErepositoryItemImageComboBox
            // 
            this.DRYICErepositoryItemImageComboBox.AutoHeight = false;
            this.DRYICErepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DRYICErepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yes", "Y", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("No", "N", -1)});
            this.DRYICErepositoryItemImageComboBox.Name = "DRYICErepositoryItemImageComboBox";
            // 
            // colBOXTYP
            // 
            this.colBOXTYP.Caption = "BoxTyp";
            this.colBOXTYP.ColumnEdit = this.BOXTYPrepositoryItemCheckedComboBoxEdit;
            this.colBOXTYP.FieldName = "BOXTYP";
            this.colBOXTYP.Name = "colBOXTYP";
            this.colBOXTYP.Visible = true;
            this.colBOXTYP.VisibleIndex = 22;
            // 
            // BOXTYPrepositoryItemCheckedComboBoxEdit
            // 
            this.BOXTYPrepositoryItemCheckedComboBoxEdit.AutoHeight = false;
            this.BOXTYPrepositoryItemCheckedComboBoxEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BOXTYPrepositoryItemCheckedComboBoxEdit.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("A", "Ambient"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("F", "Frozen"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("C", "Cooled"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("R", "Refeer"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("N", "No")});
            this.BOXTYPrepositoryItemCheckedComboBoxEdit.Name = "BOXTYPrepositoryItemCheckedComboBoxEdit";
            // 
            // colSTARTDATE
            // 
            this.colSTARTDATE.Caption = "Start";
            this.colSTARTDATE.FieldName = "STARTDATE";
            this.colSTARTDATE.Name = "colSTARTDATE";
            this.colSTARTDATE.Visible = true;
            this.colSTARTDATE.VisibleIndex = 21;
            // 
            // colENDDATE
            // 
            this.colENDDATE.Caption = "End";
            this.colENDDATE.FieldName = "ENDDATE";
            this.colENDDATE.Name = "colENDDATE";
            this.colENDDATE.Visible = true;
            this.colENDDATE.VisibleIndex = 23;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Info";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 24;
            // 
            // colONYUSR
            // 
            this.colONYUSR.Caption = "OnyUsr";
            this.colONYUSR.FieldName = "ONYUSR";
            this.colONYUSR.Name = "colONYUSR";
            this.colONYUSR.OptionsColumn.AllowEdit = false;
            this.colONYUSR.OptionsColumn.AllowFocus = false;
            this.colONYUSR.Visible = true;
            this.colONYUSR.VisibleIndex = 25;
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
            // 
            // colONYTRH
            // 
            this.colONYTRH.Caption = "OnyTrh";
            this.colONYTRH.FieldName = "ONYTRH";
            this.colONYTRH.Name = "colONYTRH";
            this.colONYTRH.OptionsColumn.AllowEdit = false;
            this.colONYTRH.OptionsColumn.AllowFocus = false;
            this.colONYTRH.Visible = true;
            this.colONYTRH.VisibleIndex = 27;
            // 
            // colSITELOCID
            // 
            this.colSITELOCID.FieldName = "SITELOCID";
            this.colSITELOCID.Name = "colSITELOCID";
            this.colSITELOCID.OptionsColumn.AllowEdit = false;
            this.colSITELOCID.OptionsColumn.AllowFocus = false;
            // 
            // onaylaToolStripMenuItem
            // 
            this.onaylaToolStripMenuItem.Name = "onaylaToolStripMenuItem";
            this.onaylaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.onaylaToolStripMenuItem.Text = "Onayla";
            this.onaylaToolStripMenuItem.Click += new System.EventHandler(this.onaylaToolStripMenuItem_Click);
            // 
            // obsXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 321);
            this.Controls.Add(this.obsGridControl);
            this.Name = "obsXF";
            this.Text = "obsXF";
            this.Load += new System.EventHandler(this.obsXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.obsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WRKDAYSrepositoryItemCheckedComboBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WRKTIMESrepositoryItemCheckedComboBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMPTYPrepositoryItemCheckedComboBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRYICErepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOXTYPrepositoryItemCheckedComboBoxEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpsDataSet opsDataSet;
        private System.Windows.Forms.BindingSource obsBindingSource;
        private OpsDataSetTableAdapters.OBSTableAdapter obsTableAdapter;
        private OpsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl obsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView obsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colOBSID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colACCAGNID;
        private DevExpress.XtraGrid.Columns.GridColumn colSPNSRID;
        private DevExpress.XtraGrid.Columns.GridColumn colPRTNO;
        private DevExpress.XtraGrid.Columns.GridColumn colACCNO;
        private DevExpress.XtraGrid.Columns.GridColumn colSITENO;
        private DevExpress.XtraGrid.Columns.GridColumn colCROID;
        private DevExpress.XtraGrid.Columns.GridColumn colSITEID;
        private DevExpress.XtraGrid.Columns.GridColumn colSITEDPT;
        private DevExpress.XtraGrid.Columns.GridColumn colDSTLABID;
        private DevExpress.XtraGrid.Columns.GridColumn colAIRPORTID;
        private DevExpress.XtraGrid.Columns.GridColumn colWRKDAYS;
        private DevExpress.XtraGrid.Columns.GridColumn colWRKTIMES;
        private DevExpress.XtraGrid.Columns.GridColumn colPB;
        private DevExpress.XtraGrid.Columns.GridColumn colSMPTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colDRYICE;
        private DevExpress.XtraGrid.Columns.GridColumn colBOXTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colSTARTDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colENDDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colONYUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colONYYTK;
        private DevExpress.XtraGrid.Columns.GridColumn colONYTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colSITELOCID;
        private DevExpress.XtraGrid.Columns.GridColumn colSITELOC;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox STUrepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colINVESTIGATOR;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit WRKDAYSrepositoryItemCheckedComboBoxEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit WRKTIMESrepositoryItemCheckedComboBoxEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox PBrepositoryItemImageComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit SMPTYPrepositoryItemCheckedComboBoxEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox DRYICErepositoryItemImageComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit BOXTYPrepositoryItemCheckedComboBoxEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem stoklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jurnalToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colEDITABLE;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTACT;
        private System.Windows.Forms.ToolStripMenuItem onaylaToolStripMenuItem;
    }
}
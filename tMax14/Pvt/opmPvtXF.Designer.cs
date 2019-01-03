namespace tMax14.Pvt
{
    partial class opmPvtXF
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldOPMID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTOB1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTOC1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldROT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMOT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldORG1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDST1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSHP1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNE1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCRR1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldATD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGLRTUT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGDRTUT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldKARTUT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHCNT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHNOP1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHPCS1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHGRW1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHCHW1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHVM31 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNOC1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTOL1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldACCYTK1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMCNT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldATDy = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldATDq = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldATDm = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldACC = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHTOPS = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldINF = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPOL = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPOU = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pvtOpmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pvtDataSet = new tMax14.Pvt.PvtDataSet();
            this.pvtOpmTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.PVT_OPMTableAdapter();
            this.fieldTAGS = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pvtOpmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.pivotGridControl1.DataSource = this.pvtOpmBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOPMID1,
            this.fieldTOB1,
            this.fieldTOC1,
            this.fieldROT1,
            this.fieldMOT1,
            this.fieldORG1,
            this.fieldDST1,
            this.fieldSHP1,
            this.fieldCNE1,
            this.fieldCRR1,
            this.fieldATD1,
            this.fieldGLRTUT1,
            this.fieldGDRTUT1,
            this.fieldKARTUT1,
            this.fieldHCNT1,
            this.fieldHNOP1,
            this.fieldHPCS1,
            this.fieldHGRW1,
            this.fieldHCHW1,
            this.fieldHVM31,
            this.fieldNOC1,
            this.fieldTOL1,
            this.fieldACCYTK1,
            this.fieldMCNT,
            this.fieldATDy,
            this.fieldATDq,
            this.fieldATDm,
            this.fieldACC,
            this.fieldHTOPS,
            this.fieldINF,
            this.fieldPOL,
            this.fieldPOU,
            this.fieldTAGS});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsDataField.RowHeaderWidth = 179;
            this.pivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.Size = new System.Drawing.Size(1000, 273);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.layoutsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 48);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // fieldOPMID1
            // 
            this.fieldOPMID1.AreaIndex = 0;
            this.fieldOPMID1.Caption = "OPMID";
            this.fieldOPMID1.FieldName = "OPMID";
            this.fieldOPMID1.Name = "fieldOPMID1";
            // 
            // fieldTOB1
            // 
            this.fieldTOB1.AreaIndex = 1;
            this.fieldTOB1.Caption = "TOB";
            this.fieldTOB1.FieldName = "TOB";
            this.fieldTOB1.Name = "fieldTOB1";
            // 
            // fieldTOC1
            // 
            this.fieldTOC1.AreaIndex = 2;
            this.fieldTOC1.Caption = "TOC";
            this.fieldTOC1.FieldName = "TOC";
            this.fieldTOC1.Name = "fieldTOC1";
            // 
            // fieldROT1
            // 
            this.fieldROT1.AreaIndex = 3;
            this.fieldROT1.Caption = "ROT";
            this.fieldROT1.FieldName = "ROT";
            this.fieldROT1.Name = "fieldROT1";
            // 
            // fieldMOT1
            // 
            this.fieldMOT1.AreaIndex = 4;
            this.fieldMOT1.Caption = "MOT";
            this.fieldMOT1.FieldName = "MOT";
            this.fieldMOT1.Name = "fieldMOT1";
            // 
            // fieldORG1
            // 
            this.fieldORG1.AreaIndex = 5;
            this.fieldORG1.Caption = "OrgC";
            this.fieldORG1.FieldName = "ORG";
            this.fieldORG1.Name = "fieldORG1";
            // 
            // fieldDST1
            // 
            this.fieldDST1.AreaIndex = 6;
            this.fieldDST1.Caption = "DstC";
            this.fieldDST1.FieldName = "DST";
            this.fieldDST1.Name = "fieldDST1";
            // 
            // fieldSHP1
            // 
            this.fieldSHP1.AreaIndex = 7;
            this.fieldSHP1.Caption = "Shipper";
            this.fieldSHP1.FieldName = "SHP";
            this.fieldSHP1.Name = "fieldSHP1";
            // 
            // fieldCNE1
            // 
            this.fieldCNE1.AreaIndex = 8;
            this.fieldCNE1.Caption = "Consignee";
            this.fieldCNE1.FieldName = "CNE";
            this.fieldCNE1.Name = "fieldCNE1";
            // 
            // fieldCRR1
            // 
            this.fieldCRR1.AreaIndex = 9;
            this.fieldCRR1.Caption = "Carrier";
            this.fieldCRR1.FieldName = "CRR";
            this.fieldCRR1.Name = "fieldCRR1";
            // 
            // fieldATD1
            // 
            this.fieldATD1.AreaIndex = 11;
            this.fieldATD1.Caption = "ATD";
            this.fieldATD1.FieldName = "ATD";
            this.fieldATD1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldATD1.Name = "fieldATD1";
            this.fieldATD1.UnboundFieldName = "fieldATD1";
            // 
            // fieldGLRTUT1
            // 
            this.fieldGLRTUT1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldGLRTUT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldGLRTUT1.AreaIndex = 0;
            this.fieldGLRTUT1.Caption = "Gelir";
            this.fieldGLRTUT1.CellFormat.FormatString = "n";
            this.fieldGLRTUT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldGLRTUT1.FieldName = "GLRTUT";
            this.fieldGLRTUT1.Name = "fieldGLRTUT1";
            this.fieldGLRTUT1.Width = 80;
            // 
            // fieldGDRTUT1
            // 
            this.fieldGDRTUT1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldGDRTUT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldGDRTUT1.AreaIndex = 1;
            this.fieldGDRTUT1.Caption = "Gider";
            this.fieldGDRTUT1.CellFormat.FormatString = "n";
            this.fieldGDRTUT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldGDRTUT1.FieldName = "GDRTUT";
            this.fieldGDRTUT1.Name = "fieldGDRTUT1";
            this.fieldGDRTUT1.Width = 80;
            // 
            // fieldKARTUT1
            // 
            this.fieldKARTUT1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldKARTUT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldKARTUT1.AreaIndex = 2;
            this.fieldKARTUT1.Caption = "Kar";
            this.fieldKARTUT1.CellFormat.FormatString = "n";
            this.fieldKARTUT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldKARTUT1.FieldName = "KARTUT";
            this.fieldKARTUT1.Name = "fieldKARTUT1";
            this.fieldKARTUT1.Width = 80;
            // 
            // fieldHCNT1
            // 
            this.fieldHCNT1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldHCNT1.AreaIndex = 15;
            this.fieldHCNT1.Caption = "hCount";
            this.fieldHCNT1.FieldName = "HCNT";
            this.fieldHCNT1.Name = "fieldHCNT1";
            // 
            // fieldHNOP1
            // 
            this.fieldHNOP1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldHNOP1.AreaIndex = 16;
            this.fieldHNOP1.Caption = "hNOP";
            this.fieldHNOP1.FieldName = "HNOP";
            this.fieldHNOP1.Name = "fieldHNOP1";
            // 
            // fieldHPCS1
            // 
            this.fieldHPCS1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldHPCS1.AreaIndex = 17;
            this.fieldHPCS1.Caption = "hPcs";
            this.fieldHPCS1.CellFormat.FormatString = "n0";
            this.fieldHPCS1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldHPCS1.FieldName = "HPCS";
            this.fieldHPCS1.Name = "fieldHPCS1";
            // 
            // fieldHGRW1
            // 
            this.fieldHGRW1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldHGRW1.AreaIndex = 18;
            this.fieldHGRW1.Caption = "hGrW";
            this.fieldHGRW1.CellFormat.FormatString = "n0";
            this.fieldHGRW1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldHGRW1.FieldName = "HGRW";
            this.fieldHGRW1.Name = "fieldHGRW1";
            // 
            // fieldHCHW1
            // 
            this.fieldHCHW1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldHCHW1.AreaIndex = 19;
            this.fieldHCHW1.Caption = "hChW";
            this.fieldHCHW1.CellFormat.FormatString = "n0";
            this.fieldHCHW1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldHCHW1.FieldName = "HCHW";
            this.fieldHCHW1.Name = "fieldHCHW1";
            // 
            // fieldHVM31
            // 
            this.fieldHVM31.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldHVM31.AreaIndex = 20;
            this.fieldHVM31.Caption = "hVM3";
            this.fieldHVM31.CellFormat.FormatString = "n";
            this.fieldHVM31.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldHVM31.FieldName = "HVM3";
            this.fieldHVM31.Name = "fieldHVM31";
            // 
            // fieldNOC1
            // 
            this.fieldNOC1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldNOC1.AreaIndex = 21;
            this.fieldNOC1.Caption = "NOC";
            this.fieldNOC1.FieldName = "NOC";
            this.fieldNOC1.Name = "fieldNOC1";
            // 
            // fieldTOL1
            // 
            this.fieldTOL1.AreaIndex = 22;
            this.fieldTOL1.Caption = "TOL";
            this.fieldTOL1.FieldName = "TOL";
            this.fieldTOL1.Name = "fieldTOL1";
            // 
            // fieldACCYTK1
            // 
            this.fieldACCYTK1.AreaIndex = 23;
            this.fieldACCYTK1.Caption = "AccYtk";
            this.fieldACCYTK1.FieldName = "ACCYTK";
            this.fieldACCYTK1.Name = "fieldACCYTK1";
            // 
            // fieldMCNT
            // 
            this.fieldMCNT.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldMCNT.AreaIndex = 24;
            this.fieldMCNT.Caption = "mCount";
            this.fieldMCNT.FieldName = "MCNT";
            this.fieldMCNT.Name = "fieldMCNT";
            // 
            // fieldATDy
            // 
            this.fieldATDy.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldATDy.AreaIndex = 12;
            this.fieldATDy.Caption = "ATDy";
            this.fieldATDy.FieldName = "ATD";
            this.fieldATDy.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldATDy.Name = "fieldATDy";
            this.fieldATDy.UnboundFieldName = "fieldATDy";
            // 
            // fieldATDq
            // 
            this.fieldATDq.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldATDq.AreaIndex = 13;
            this.fieldATDq.Caption = "ATDq";
            this.fieldATDq.FieldName = "ATD";
            this.fieldATDq.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldATDq.Name = "fieldATDq";
            this.fieldATDq.UnboundFieldName = "fieldATDq";
            // 
            // fieldATDm
            // 
            this.fieldATDm.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldATDm.AreaIndex = 14;
            this.fieldATDm.Caption = "ATDm";
            this.fieldATDm.FieldName = "ATD";
            this.fieldATDm.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldATDm.Name = "fieldATDm";
            this.fieldATDm.UnboundFieldName = "fieldATDm";
            // 
            // fieldACC
            // 
            this.fieldACC.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldACC.AreaIndex = 10;
            this.fieldACC.Caption = "Account";
            this.fieldACC.FieldName = "ACC";
            this.fieldACC.Name = "fieldACC";
            // 
            // fieldHTOPS
            // 
            this.fieldHTOPS.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldHTOPS.AreaIndex = 25;
            this.fieldHTOPS.Caption = "hTOPs";
            this.fieldHTOPS.FieldName = "HTOPS";
            this.fieldHTOPS.Name = "fieldHTOPS";
            // 
            // fieldINF
            // 
            this.fieldINF.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldINF.AreaIndex = 26;
            this.fieldINF.Caption = "Info";
            this.fieldINF.FieldName = "INF";
            this.fieldINF.Name = "fieldINF";
            // 
            // fieldPOL
            // 
            this.fieldPOL.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldPOL.AreaIndex = 27;
            this.fieldPOL.FieldName = "POL";
            this.fieldPOL.Name = "fieldPOL";
            // 
            // fieldPOU
            // 
            this.fieldPOU.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldPOU.AreaIndex = 28;
            this.fieldPOU.FieldName = "POU";
            this.fieldPOU.Name = "fieldPOU";
            // 
            // pvtOpmBindingSource
            // 
            this.pvtOpmBindingSource.DataMember = "PVT_OPM";
            this.pvtOpmBindingSource.DataSource = this.pvtDataSet;
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pvtOpmTableAdapter
            // 
            this.pvtOpmTableAdapter.ClearBeforeFill = true;
            // 
            // fieldTAGS
            // 
            this.fieldTAGS.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTAGS.AreaIndex = 29;
            this.fieldTAGS.Caption = "TAGs";
            this.fieldTAGS.FieldName = "TAGS";
            this.fieldTAGS.Name = "fieldTAGS";
            // 
            // opmPvtXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 273);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "opmPvtXF";
            this.Text = "Master Pivot [opmPvtXF]";
            this.Load += new System.EventHandler(this.opmPvtXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pvtOpmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource pvtOpmBindingSource;
        private PvtDataSet pvtDataSet;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOPMID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTOB1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTOC1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldROT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMOT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldORG1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDST1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSHP1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNE1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCRR1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldATD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGLRTUT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGDRTUT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldKARTUT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHCNT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHNOP1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHPCS1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHGRW1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHCHW1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHVM31;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNOC1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTOL1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldACCYTK1;
        private PvtDataSetTableAdapters.PVT_OPMTableAdapter pvtOpmTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMCNT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
        private DevExpress.XtraPivotGrid.PivotGridField fieldATDy;
        private DevExpress.XtraPivotGrid.PivotGridField fieldATDq;
        private DevExpress.XtraPivotGrid.PivotGridField fieldATDm;
        private DevExpress.XtraPivotGrid.PivotGridField fieldACC;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHTOPS;
        private DevExpress.XtraPivotGrid.PivotGridField fieldINF;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPOL;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPOU;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTAGS;
    }
}
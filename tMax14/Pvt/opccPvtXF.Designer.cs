namespace tMax14.Pvt
{
    partial class opccPvtXF
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
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldOPCCID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOPCID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNTNO1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOWNID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOWNAD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldR2ID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldR2AD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldR4ID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldR4AD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFRTID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFRTAD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAHTID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAHTAD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTRH1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTUR1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMIK1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDVZ1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGLRR1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGDRR1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRSD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRFD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.opccPvtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pvtDataSet = new tMax14.Pvt.PvtDataSet();
            this.opccPvtTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.OPCC_PVTTableAdapter();
            this.fieldCNT = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opccPvtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.ContextMenuStrip = this.contextMenuStrip;
            this.pivotGridControl1.DataSource = this.opccPvtBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOPCCID1,
            this.fieldOPCID1,
            this.fieldCNTNO1,
            this.fieldOWNID1,
            this.fieldOWNAD1,
            this.fieldR2ID1,
            this.fieldR2AD1,
            this.fieldR4ID1,
            this.fieldR4AD1,
            this.fieldFRTID1,
            this.fieldFRTAD1,
            this.fieldAHTID1,
            this.fieldAHTAD1,
            this.fieldTRH1,
            this.fieldTUR1,
            this.fieldMIK1,
            this.fieldDVZ1,
            this.fieldGLRR1,
            this.fieldGDRR1,
            this.fieldRSD,
            this.fieldRFD,
            this.fieldCNT});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsDataField.RowHeaderWidth = 127;
            this.pivotGridControl1.Prefilter.CriteriaString = "[fieldRSD] >= #2016-01-01#";
            this.pivotGridControl1.Prefilter.Enabled = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(988, 410);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // fieldOPCCID1
            // 
            this.fieldOPCCID1.AreaIndex = 0;
            this.fieldOPCCID1.Caption = "OPCCID";
            this.fieldOPCCID1.FieldName = "OPCCID";
            this.fieldOPCCID1.Name = "fieldOPCCID1";
            // 
            // fieldOPCID1
            // 
            this.fieldOPCID1.AreaIndex = 1;
            this.fieldOPCID1.Caption = "OPCID";
            this.fieldOPCID1.FieldName = "OPCID";
            this.fieldOPCID1.Name = "fieldOPCID1";
            // 
            // fieldCNTNO1
            // 
            this.fieldCNTNO1.AreaIndex = 2;
            this.fieldCNTNO1.Caption = "CntNo";
            this.fieldCNTNO1.FieldName = "CNTNO";
            this.fieldCNTNO1.Name = "fieldCNTNO1";
            // 
            // fieldOWNID1
            // 
            this.fieldOWNID1.AreaIndex = 3;
            this.fieldOWNID1.Caption = "OWNID";
            this.fieldOWNID1.FieldName = "OWNID";
            this.fieldOWNID1.Name = "fieldOWNID1";
            this.fieldOWNID1.Visible = false;
            // 
            // fieldOWNAD1
            // 
            this.fieldOWNAD1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOWNAD1.AreaIndex = 0;
            this.fieldOWNAD1.Caption = "Owner";
            this.fieldOWNAD1.FieldName = "OWNAD";
            this.fieldOWNAD1.Name = "fieldOWNAD1";
            this.fieldOWNAD1.Width = 154;
            // 
            // fieldR2ID1
            // 
            this.fieldR2ID1.AreaIndex = 5;
            this.fieldR2ID1.Caption = "R2ID";
            this.fieldR2ID1.FieldName = "R2ID";
            this.fieldR2ID1.Name = "fieldR2ID1";
            this.fieldR2ID1.Visible = false;
            // 
            // fieldR2AD1
            // 
            this.fieldR2AD1.AreaIndex = 3;
            this.fieldR2AD1.Caption = "ReleasedTo";
            this.fieldR2AD1.FieldName = "R2AD";
            this.fieldR2AD1.Name = "fieldR2AD1";
            // 
            // fieldR4ID1
            // 
            this.fieldR4ID1.AreaIndex = 7;
            this.fieldR4ID1.Caption = "R4ID";
            this.fieldR4ID1.FieldName = "R4ID";
            this.fieldR4ID1.Name = "fieldR4ID1";
            this.fieldR4ID1.Visible = false;
            // 
            // fieldR4AD1
            // 
            this.fieldR4AD1.AreaIndex = 4;
            this.fieldR4AD1.Caption = "ReceivedFrom";
            this.fieldR4AD1.FieldName = "R4AD";
            this.fieldR4AD1.Name = "fieldR4AD1";
            // 
            // fieldFRTID1
            // 
            this.fieldFRTID1.AreaIndex = 9;
            this.fieldFRTID1.Caption = "FRTID";
            this.fieldFRTID1.FieldName = "FRTID";
            this.fieldFRTID1.Name = "fieldFRTID1";
            this.fieldFRTID1.Visible = false;
            // 
            // fieldFRTAD1
            // 
            this.fieldFRTAD1.AreaIndex = 5;
            this.fieldFRTAD1.Caption = "Müşteri";
            this.fieldFRTAD1.FieldName = "FRTAD";
            this.fieldFRTAD1.Name = "fieldFRTAD1";
            // 
            // fieldAHTID1
            // 
            this.fieldAHTID1.AreaIndex = 11;
            this.fieldAHTID1.Caption = "AHTID";
            this.fieldAHTID1.FieldName = "AHTID";
            this.fieldAHTID1.Name = "fieldAHTID1";
            this.fieldAHTID1.Visible = false;
            // 
            // fieldAHTAD1
            // 
            this.fieldAHTAD1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldAHTAD1.AreaIndex = 0;
            this.fieldAHTAD1.Caption = "Charge";
            this.fieldAHTAD1.FieldName = "AHTAD";
            this.fieldAHTAD1.Name = "fieldAHTAD1";
            // 
            // fieldTRH1
            // 
            this.fieldTRH1.AreaIndex = 7;
            this.fieldTRH1.Caption = "Trh";
            this.fieldTRH1.FieldName = "TRH";
            this.fieldTRH1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldTRH1.Name = "fieldTRH1";
            this.fieldTRH1.UnboundFieldName = "fieldTRH1";
            // 
            // fieldTUR1
            // 
            this.fieldTUR1.AreaIndex = 8;
            this.fieldTUR1.Caption = "Tür";
            this.fieldTUR1.FieldName = "TUR";
            this.fieldTUR1.Name = "fieldTUR1";
            // 
            // fieldMIK1
            // 
            this.fieldMIK1.AreaIndex = 9;
            this.fieldMIK1.Caption = "Mik";
            this.fieldMIK1.FieldName = "MIK";
            this.fieldMIK1.Name = "fieldMIK1";
            // 
            // fieldDVZ1
            // 
            this.fieldDVZ1.AreaIndex = 10;
            this.fieldDVZ1.Caption = "Dvz";
            this.fieldDVZ1.FieldName = "DVZ";
            this.fieldDVZ1.Name = "fieldDVZ1";
            // 
            // fieldGLRR1
            // 
            this.fieldGLRR1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldGLRR1.AreaIndex = 13;
            this.fieldGLRR1.Caption = "GlrR";
            this.fieldGLRR1.CellFormat.FormatString = "n";
            this.fieldGLRR1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldGLRR1.FieldName = "GLRR";
            this.fieldGLRR1.Name = "fieldGLRR1";
            // 
            // fieldGDRR1
            // 
            this.fieldGDRR1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldGDRR1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldGDRR1.AreaIndex = 0;
            this.fieldGDRR1.Caption = "GdrR";
            this.fieldGDRR1.CellFormat.FormatString = "n";
            this.fieldGDRR1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldGDRR1.FieldName = "GDRR";
            this.fieldGDRR1.Name = "fieldGDRR1";
            this.fieldGDRR1.Width = 63;
            // 
            // fieldRSD
            // 
            this.fieldRSD.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldRSD.AreaIndex = 11;
            this.fieldRSD.Caption = "RentStrt";
            this.fieldRSD.FieldName = "RSD";
            this.fieldRSD.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldRSD.Name = "fieldRSD";
            this.fieldRSD.UnboundFieldName = "fieldRSD";
            // 
            // fieldRFD
            // 
            this.fieldRFD.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldRFD.AreaIndex = 12;
            this.fieldRFD.Caption = "RentEnd";
            this.fieldRFD.FieldName = "RFD";
            this.fieldRFD.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldRFD.Name = "fieldRFD";
            this.fieldRFD.UnboundFieldName = "fieldRFD";
            // 
            // opccPvtBindingSource
            // 
            this.opccPvtBindingSource.DataMember = "OPCC_PVT";
            this.opccPvtBindingSource.DataSource = this.pvtDataSet;
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opccPvtTableAdapter
            // 
            this.opccPvtTableAdapter.ClearBeforeFill = true;
            // 
            // fieldCNT
            // 
            this.fieldCNT.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldCNT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNT.AreaIndex = 1;
            this.fieldCNT.Caption = "Count";
            this.fieldCNT.FieldName = "CNT";
            this.fieldCNT.Name = "fieldCNT";
            this.fieldCNT.Width = 63;
            // 
            // opccPvtXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 410);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "opccPvtXF";
            this.Text = "45\" Container Charges";
            this.Load += new System.EventHandler(this.opccPvtXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.opccPvtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PvtDataSet pvtDataSet;
        private System.Windows.Forms.BindingSource opccPvtBindingSource;
        private PvtDataSetTableAdapters.OPCC_PVTTableAdapter opccPvtTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOPCCID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOPCID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNTNO1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOWNID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOWNAD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldR2ID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldR2AD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldR4ID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldR4AD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFRTID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFRTAD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAHTID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAHTAD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTRH1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTUR1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMIK1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDVZ1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGLRR1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGDRR1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRSD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRFD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNT;
    }
}
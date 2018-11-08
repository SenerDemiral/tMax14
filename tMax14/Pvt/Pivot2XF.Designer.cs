namespace tMax14.Pvt
{
    partial class Pivot2XF
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
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pVT2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pvtDataSet = new tMax14.Pvt.PvtDataSet();
            this.fieldOPMID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOPHID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTOB1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldROT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMOT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNSTU1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAHTAD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFRTAD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTUR1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGLRTUT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGDRTUT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCHRDRM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pVT_2TableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.PVT_2TableAdapter();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pVT2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.ContextMenuStrip = this.contextMenuStrip;
            this.pivotGridControl1.DataSource = this.pVT2BindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOPMID1,
            this.fieldOPHID1,
            this.fieldHM1,
            this.fieldTOB1,
            this.fieldROT1,
            this.fieldMOT1,
            this.fieldNSTU1,
            this.fieldAHTAD1,
            this.fieldFRTAD1,
            this.fieldTUR1,
            this.fieldGLRTUT1,
            this.fieldGDRTUT1,
            this.fieldCHRDRM1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsDataField.RowHeaderWidth = 131;
            this.pivotGridControl1.Size = new System.Drawing.Size(747, 438);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutsToolStripMenuItem,
            this.printToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 70);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // pVT2BindingSource
            // 
            this.pVT2BindingSource.DataMember = "PVT_2";
            this.pVT2BindingSource.DataSource = this.pvtDataSet;
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldOPMID1
            // 
            this.fieldOPMID1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldOPMID1.AreaIndex = 0;
            this.fieldOPMID1.Caption = "OPMID";
            this.fieldOPMID1.FieldName = "OPMID";
            this.fieldOPMID1.Name = "fieldOPMID1";
            // 
            // fieldOPHID1
            // 
            this.fieldOPHID1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldOPHID1.AreaIndex = 1;
            this.fieldOPHID1.Caption = "OPHID";
            this.fieldOPHID1.FieldName = "OPHID";
            this.fieldOPHID1.Name = "fieldOPHID1";
            // 
            // fieldHM1
            // 
            this.fieldHM1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldHM1.AreaIndex = 2;
            this.fieldHM1.Caption = "HM";
            this.fieldHM1.FieldName = "HM";
            this.fieldHM1.Name = "fieldHM1";
            // 
            // fieldTOB1
            // 
            this.fieldTOB1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTOB1.AreaIndex = 3;
            this.fieldTOB1.Caption = "TOB";
            this.fieldTOB1.FieldName = "TOB";
            this.fieldTOB1.Name = "fieldTOB1";
            // 
            // fieldROT1
            // 
            this.fieldROT1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldROT1.AreaIndex = 4;
            this.fieldROT1.Caption = "ROT";
            this.fieldROT1.FieldName = "ROT";
            this.fieldROT1.Name = "fieldROT1";
            // 
            // fieldMOT1
            // 
            this.fieldMOT1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldMOT1.AreaIndex = 5;
            this.fieldMOT1.Caption = "MOT";
            this.fieldMOT1.FieldName = "MOT";
            this.fieldMOT1.Name = "fieldMOT1";
            // 
            // fieldNSTU1
            // 
            this.fieldNSTU1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldNSTU1.AreaIndex = 6;
            this.fieldNSTU1.Caption = "OpDrm";
            this.fieldNSTU1.FieldName = "NSTU";
            this.fieldNSTU1.Name = "fieldNSTU1";
            // 
            // fieldAHTAD1
            // 
            this.fieldAHTAD1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldAHTAD1.AreaIndex = 7;
            this.fieldAHTAD1.Caption = "Charge";
            this.fieldAHTAD1.FieldName = "AHTAD";
            this.fieldAHTAD1.Name = "fieldAHTAD1";
            // 
            // fieldFRTAD1
            // 
            this.fieldFRTAD1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldFRTAD1.AreaIndex = 9;
            this.fieldFRTAD1.Caption = "Firma";
            this.fieldFRTAD1.FieldName = "FRTAD";
            this.fieldFRTAD1.Name = "fieldFRTAD1";
            // 
            // fieldTUR1
            // 
            this.fieldTUR1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTUR1.AreaIndex = 10;
            this.fieldTUR1.Caption = "FtrTür";
            this.fieldTUR1.FieldName = "TUR";
            this.fieldTUR1.Name = "fieldTUR1";
            // 
            // fieldGLRTUT1
            // 
            this.fieldGLRTUT1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldGLRTUT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldGLRTUT1.AreaIndex = 0;
            this.fieldGLRTUT1.Caption = "Gelir";
            this.fieldGLRTUT1.CellFormat.FormatString = "n0";
            this.fieldGLRTUT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldGLRTUT1.FieldName = "GLRTUT";
            this.fieldGLRTUT1.Name = "fieldGLRTUT1";
            // 
            // fieldGDRTUT1
            // 
            this.fieldGDRTUT1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldGDRTUT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldGDRTUT1.AreaIndex = 1;
            this.fieldGDRTUT1.Caption = "Gider";
            this.fieldGDRTUT1.CellFormat.FormatString = "n0";
            this.fieldGDRTUT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldGDRTUT1.FieldName = "GDRTUT";
            this.fieldGDRTUT1.Name = "fieldGDRTUT1";
            // 
            // fieldCHRDRM1
            // 
            this.fieldCHRDRM1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldCHRDRM1.AreaIndex = 8;
            this.fieldCHRDRM1.Caption = "ChrDrm";
            this.fieldCHRDRM1.FieldName = "CHRDRM";
            this.fieldCHRDRM1.Name = "fieldCHRDRM1";
            // 
            // pVT_2TableAdapter
            // 
            this.pVT_2TableAdapter.ClearBeforeFill = true;
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // Pivot2XF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 438);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Pivot2XF";
            this.Text = "Pivot2XF";
            this.Load += new System.EventHandler(this.Pivot2XF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pVT2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private PvtDataSet pvtDataSet;
        private System.Windows.Forms.BindingSource pVT2BindingSource;
        private PvtDataSetTableAdapters.PVT_2TableAdapter pVT_2TableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOPMID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOPHID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTOB1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldROT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMOT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNSTU1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAHTAD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFRTAD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTUR1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGLRTUT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGDRTUT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCHRDRM1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}
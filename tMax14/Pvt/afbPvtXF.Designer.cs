namespace tMax14.Pvt
{
    partial class afbPvtXF
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
            this.pvtDataSet = new tMax14.Pvt.PvtDataSet();
            this.afbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afbTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.PVT_AFBTableAdapter();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldFRTID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFRTAD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAFBID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDRM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTUR1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTUR31 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTRH1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldVDE1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBA1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRTUT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRKLN1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldVDEy = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldVDEq = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldVDEm = new DevExpress.XtraPivotGrid.PivotGridField();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // afbBindingSource
            // 
            this.afbBindingSource.DataMember = "PVT_AFB";
            this.afbBindingSource.DataSource = this.pvtDataSet;
            // 
            // afbTableAdapter
            // 
            this.afbTableAdapter.ClearBeforeFill = true;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.ContextMenuStrip = this.contextMenuStrip;
            this.pivotGridControl1.DataSource = this.afbBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldFRTID1,
            this.fieldFRTAD1,
            this.fieldAFBID1,
            this.fieldDRM1,
            this.fieldTUR1,
            this.fieldTUR31,
            this.fieldTRH1,
            this.fieldVDE1,
            this.fieldBA1,
            this.fieldRTUT1,
            this.fieldRKLN1,
            this.fieldVDEy,
            this.fieldVDEq,
            this.fieldVDEm});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(692, 289);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fieldFRTID1
            // 
            this.fieldFRTID1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldFRTID1.AreaIndex = 0;
            this.fieldFRTID1.Caption = "FRTID";
            this.fieldFRTID1.FieldName = "FRTID";
            this.fieldFRTID1.Name = "fieldFRTID1";
            // 
            // fieldFRTAD1
            // 
            this.fieldFRTAD1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldFRTAD1.AreaIndex = 2;
            this.fieldFRTAD1.Caption = "Firma";
            this.fieldFRTAD1.FieldName = "FRTAD";
            this.fieldFRTAD1.Name = "fieldFRTAD1";
            // 
            // fieldAFBID1
            // 
            this.fieldAFBID1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldAFBID1.AreaIndex = 1;
            this.fieldAFBID1.Caption = "AFBID";
            this.fieldAFBID1.FieldName = "AFBID";
            this.fieldAFBID1.Name = "fieldAFBID1";
            // 
            // fieldDRM1
            // 
            this.fieldDRM1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldDRM1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDRM1.AreaIndex = 0;
            this.fieldDRM1.Caption = "Durum";
            this.fieldDRM1.FieldName = "DRM";
            this.fieldDRM1.Name = "fieldDRM1";
            this.fieldDRM1.Width = 163;
            // 
            // fieldTUR1
            // 
            this.fieldTUR1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTUR1.AreaIndex = 3;
            this.fieldTUR1.Caption = "Tür";
            this.fieldTUR1.FieldName = "TUR";
            this.fieldTUR1.Name = "fieldTUR1";
            // 
            // fieldTUR31
            // 
            this.fieldTUR31.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTUR31.AreaIndex = 4;
            this.fieldTUR31.Caption = "Tür3";
            this.fieldTUR31.FieldName = "TUR3";
            this.fieldTUR31.Name = "fieldTUR31";
            // 
            // fieldTRH1
            // 
            this.fieldTRH1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTRH1.AreaIndex = 5;
            this.fieldTRH1.Caption = "Trh";
            this.fieldTRH1.FieldName = "TRH";
            this.fieldTRH1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldTRH1.Name = "fieldTRH1";
            this.fieldTRH1.UnboundFieldName = "fieldTRH1";
            // 
            // fieldVDE1
            // 
            this.fieldVDE1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldVDE1.AreaIndex = 6;
            this.fieldVDE1.Caption = "Vde";
            this.fieldVDE1.FieldName = "VDE";
            this.fieldVDE1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldVDE1.Name = "fieldVDE1";
            this.fieldVDE1.UnboundFieldName = "fieldVDE1";
            // 
            // fieldBA1
            // 
            this.fieldBA1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldBA1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldBA1.AreaIndex = 0;
            this.fieldBA1.Caption = "BA";
            this.fieldBA1.FieldName = "BA";
            this.fieldBA1.Name = "fieldBA1";
            // 
            // fieldRTUT1
            // 
            this.fieldRTUT1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldRTUT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRTUT1.AreaIndex = 0;
            this.fieldRTUT1.Caption = "Tut EUR";
            this.fieldRTUT1.CellFormat.FormatString = "n";
            this.fieldRTUT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRTUT1.FieldName = "RTUT";
            this.fieldRTUT1.Name = "fieldRTUT1";
            // 
            // fieldRKLN1
            // 
            this.fieldRKLN1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldRKLN1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRKLN1.AreaIndex = 1;
            this.fieldRKLN1.Caption = "Kln EUR";
            this.fieldRKLN1.CellFormat.FormatString = "n";
            this.fieldRKLN1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRKLN1.FieldName = "RKLN";
            this.fieldRKLN1.Name = "fieldRKLN1";
            // 
            // fieldVDEy
            // 
            this.fieldVDEy.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldVDEy.AreaIndex = 7;
            this.fieldVDEy.Caption = "VdeY";
            this.fieldVDEy.FieldName = "VDE";
            this.fieldVDEy.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldVDEy.Name = "fieldVDEy";
            this.fieldVDEy.UnboundFieldName = "fieldVDEy";
            // 
            // fieldVDEq
            // 
            this.fieldVDEq.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldVDEq.AreaIndex = 8;
            this.fieldVDEq.Caption = "VdeQ";
            this.fieldVDEq.FieldName = "VDE";
            this.fieldVDEq.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldVDEq.Name = "fieldVDEq";
            this.fieldVDEq.UnboundFieldName = "fieldVDEq";
            // 
            // fieldVDEm
            // 
            this.fieldVDEm.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldVDEm.AreaIndex = 9;
            this.fieldVDEm.Caption = "VdeM";
            this.fieldVDEm.FieldName = "VDE";
            this.fieldVDEm.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldVDEm.Name = "fieldVDEm";
            this.fieldVDEm.UnboundFieldName = "fieldVDEm";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // afbPvtXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 289);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "afbPvtXF";
            this.Text = "afbPvt";
            this.Load += new System.EventHandler(this.afbPvt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PvtDataSet pvtDataSet;
        private System.Windows.Forms.BindingSource afbBindingSource;
        private PvtDataSetTableAdapters.PVT_AFBTableAdapter afbTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFRTID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFRTAD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAFBID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDRM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTUR1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTUR31;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTRH1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldVDE1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBA1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRTUT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRKLN1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldVDEy;
        private DevExpress.XtraPivotGrid.PivotGridField fieldVDEq;
        private DevExpress.XtraPivotGrid.PivotGridField fieldVDEm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}
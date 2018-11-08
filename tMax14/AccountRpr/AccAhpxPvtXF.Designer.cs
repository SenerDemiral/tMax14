namespace tMax14.AccountRpr
{
    partial class AccAhpxPvtXF
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
            this.aCC_AHPX_PVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountRprDataSet = new tMax14.AccountRpr.AccountRprDataSet();
            this.fieldAVBID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTUR1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAVDID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSKL = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTRH1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHSPNO1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldABRC1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAALC1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDDVZ1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRBRC1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRALC1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldXH1AD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldXH2AD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldXHSPAD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTRHq = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTRH2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTRHy = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAKLN = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRKLN = new DevExpress.XtraPivotGrid.PivotGridField();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.fillSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.aCC_AHPX_PVTTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.ACC_AHPX_PVTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_AHPX_PVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.pivotGridControl1.DataSource = this.aCC_AHPX_PVTBindingSource;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldAVBID1,
            this.fieldTUR1,
            this.fieldAVDID1,
            this.fieldSKL,
            this.fieldTRH1,
            this.fieldHSPNO1,
            this.fieldABRC1,
            this.fieldAALC1,
            this.fieldDDVZ1,
            this.fieldRBRC1,
            this.fieldRALC1,
            this.fieldXH1AD1,
            this.fieldXH2AD1,
            this.fieldXHSPAD1,
            this.fieldTRHq,
            this.fieldTRH2,
            this.fieldTRHy,
            this.fieldAKLN,
            this.fieldRKLN});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 38);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsDataField.RowHeaderWidth = 127;
            this.pivotGridControl1.Size = new System.Drawing.Size(858, 623);
            this.pivotGridControl1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // aCC_AHPX_PVTBindingSource
            // 
            this.aCC_AHPX_PVTBindingSource.DataMember = "ACC_AHPX_PVT";
            this.aCC_AHPX_PVTBindingSource.DataSource = this.accountRprDataSet;
            // 
            // accountRprDataSet
            // 
            this.accountRprDataSet.DataSetName = "AccountRprDataSet";
            this.accountRprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldAVBID1
            // 
            this.fieldAVBID1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldAVBID1.AreaIndex = 0;
            this.fieldAVBID1.FieldName = "AVBID";
            this.fieldAVBID1.Name = "fieldAVBID1";
            // 
            // fieldTUR1
            // 
            this.fieldTUR1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTUR1.AreaIndex = 1;
            this.fieldTUR1.Caption = "Tür";
            this.fieldTUR1.FieldName = "TUR";
            this.fieldTUR1.Name = "fieldTUR1";
            // 
            // fieldAVDID1
            // 
            this.fieldAVDID1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldAVDID1.AreaIndex = 2;
            this.fieldAVDID1.FieldName = "AVDID";
            this.fieldAVDID1.Name = "fieldAVDID1";
            // 
            // fieldSKL
            // 
            this.fieldSKL.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldSKL.AreaIndex = 3;
            this.fieldSKL.Caption = "Şkl";
            this.fieldSKL.FieldName = "SKL";
            this.fieldSKL.Name = "fieldSKL";
            // 
            // fieldTRH1
            // 
            this.fieldTRH1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTRH1.AreaIndex = 4;
            this.fieldTRH1.Caption = "Trh";
            this.fieldTRH1.FieldName = "TRH";
            this.fieldTRH1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldTRH1.Name = "fieldTRH1";
            this.fieldTRH1.UnboundFieldName = "fieldTRH1";
            // 
            // fieldHSPNO1
            // 
            this.fieldHSPNO1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldHSPNO1.AreaIndex = 8;
            this.fieldHSPNO1.Caption = "Hsp";
            this.fieldHSPNO1.FieldName = "HSPNO";
            this.fieldHSPNO1.Name = "fieldHSPNO1";
            // 
            // fieldABRC1
            // 
            this.fieldABRC1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldABRC1.AreaIndex = 12;
            this.fieldABRC1.Caption = "BrçTRL";
            this.fieldABRC1.CellFormat.FormatString = "n";
            this.fieldABRC1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldABRC1.FieldName = "ABRC";
            this.fieldABRC1.Name = "fieldABRC1";
            // 
            // fieldAALC1
            // 
            this.fieldAALC1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldAALC1.AreaIndex = 13;
            this.fieldAALC1.Caption = "AlcTRL";
            this.fieldAALC1.CellFormat.FormatString = "n";
            this.fieldAALC1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldAALC1.FieldName = "AALC";
            this.fieldAALC1.Name = "fieldAALC1";
            // 
            // fieldDDVZ1
            // 
            this.fieldDDVZ1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldDDVZ1.AreaIndex = 9;
            this.fieldDDVZ1.Caption = "Dvz";
            this.fieldDDVZ1.FieldName = "DDVZ";
            this.fieldDDVZ1.Name = "fieldDDVZ1";
            // 
            // fieldRBRC1
            // 
            this.fieldRBRC1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldRBRC1.AreaIndex = 11;
            this.fieldRBRC1.Caption = "BrçEUR";
            this.fieldRBRC1.CellFormat.FormatString = "n";
            this.fieldRBRC1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRBRC1.FieldName = "RBRC";
            this.fieldRBRC1.Name = "fieldRBRC1";
            // 
            // fieldRALC1
            // 
            this.fieldRALC1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldRALC1.AreaIndex = 14;
            this.fieldRALC1.Caption = "AlcEUR";
            this.fieldRALC1.CellFormat.FormatString = "n";
            this.fieldRALC1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRALC1.FieldName = "RALC";
            this.fieldRALC1.Name = "fieldRALC1";
            // 
            // fieldXH1AD1
            // 
            this.fieldXH1AD1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldXH1AD1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldXH1AD1.AreaIndex = 0;
            this.fieldXH1AD1.Caption = "xHsp1";
            this.fieldXH1AD1.FieldName = "XH1AD";
            this.fieldXH1AD1.Name = "fieldXH1AD1";
            // 
            // fieldXH2AD1
            // 
            this.fieldXH2AD1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldXH2AD1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldXH2AD1.AreaIndex = 1;
            this.fieldXH2AD1.Caption = "xHsp2";
            this.fieldXH2AD1.FieldName = "XH2AD";
            this.fieldXH2AD1.Name = "fieldXH2AD1";
            // 
            // fieldXHSPAD1
            // 
            this.fieldXHSPAD1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldXHSPAD1.AreaIndex = 10;
            this.fieldXHSPAD1.Caption = "xHsp";
            this.fieldXHSPAD1.FieldName = "XHSPAD";
            this.fieldXHSPAD1.Name = "fieldXHSPAD1";
            // 
            // fieldTRHq
            // 
            this.fieldTRHq.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTRHq.AreaIndex = 6;
            this.fieldTRHq.Caption = "TrhQ";
            this.fieldTRHq.FieldName = "TRH";
            this.fieldTRHq.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldTRHq.Name = "fieldTRHq";
            this.fieldTRHq.UnboundFieldName = "fieldTRHq";
            // 
            // fieldTRH2
            // 
            this.fieldTRH2.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTRH2.AreaIndex = 7;
            this.fieldTRH2.Caption = "TrhM";
            this.fieldTRH2.FieldName = "TRH";
            this.fieldTRH2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldTRH2.Name = "fieldTRH2";
            this.fieldTRH2.UnboundFieldName = "fieldTRHm";
            // 
            // fieldTRHy
            // 
            this.fieldTRHy.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTRHy.AreaIndex = 5;
            this.fieldTRHy.Caption = "TrhY";
            this.fieldTRHy.FieldName = "TRH";
            this.fieldTRHy.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldTRHy.Name = "fieldTRHy";
            this.fieldTRHy.UnboundFieldName = "fieldTRHy";
            // 
            // fieldAKLN
            // 
            this.fieldAKLN.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldAKLN.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldAKLN.AreaIndex = 0;
            this.fieldAKLN.Caption = "KlnTRL";
            this.fieldAKLN.CellFormat.FormatString = "n";
            this.fieldAKLN.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldAKLN.FieldName = "AKLN";
            this.fieldAKLN.Name = "fieldAKLN";
            // 
            // fieldRKLN
            // 
            this.fieldRKLN.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldRKLN.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRKLN.AreaIndex = 1;
            this.fieldRKLN.Caption = "KlnEUR";
            this.fieldRKLN.CellFormat.FormatString = "n";
            this.fieldRKLN.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRKLN.FieldName = "RKLN";
            this.fieldRKLN.Name = "fieldRKLN";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.fillSimpleButton);
            this.layoutControl1.Controls.Add(this.pivotGridControl1);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(882, 673);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // fillSimpleButton
            // 
            this.fillSimpleButton.Location = new System.Drawing.Point(214, 12);
            this.fillSimpleButton.Name = "fillSimpleButton";
            this.fillSimpleButton.Size = new System.Drawing.Size(656, 22);
            this.fillSimpleButton.StyleController = this.layoutControl1;
            this.fillSimpleButton.TabIndex = 6;
            this.fillSimpleButton.Text = "FILL";
            this.fillSimpleButton.Click += new System.EventHandler(this.fillSimpleButton_Click);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(58, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(152, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(882, 673);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(202, 26);
            this.layoutControlItem1.Text = "Tarih >=";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.pivotGridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(862, 627);
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.fillSimpleButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(202, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(660, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // aCC_AHPX_PVTTableAdapter
            // 
            this.aCC_AHPX_PVTTableAdapter.ClearBeforeFill = true;
            // 
            // AccAhpxPvtXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 673);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AccAhpxPvtXF";
            this.Text = "AccAhpxPvtXF";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aCC_AHPX_PVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountRprDataSet accountRprDataSet;
        private System.Windows.Forms.BindingSource aCC_AHPX_PVTBindingSource;
        private AccountRprDataSetTableAdapters.ACC_AHPX_PVTTableAdapter aCC_AHPX_PVTTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAVBID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTUR1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAVDID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTRH1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHSPNO1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldABRC1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAALC1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDDVZ1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRBRC1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRALC1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldXH1AD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldXH2AD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldXHSPAD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTRHq;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTRH2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTRHy;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton fillSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSKL;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAKLN;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRKLN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}
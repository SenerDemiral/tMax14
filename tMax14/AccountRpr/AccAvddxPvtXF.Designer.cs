namespace tMax14.AccountRpr
{
    partial class AccAvddxPvtXF
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ATDcheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCC_AVDDX_PVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountRprDataSet = new tMax14.AccountRpr.AccountRprDataSet();
            this.fieldAVBID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTUR = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAVDID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHSPAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldXHSPAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldXH1AD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldXH2AD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAKMAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTUT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDVZ = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRTUT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTRH = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTRHq = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTRHm = new DevExpress.XtraPivotGrid.PivotGridField();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.aCC_AVDDX_PVTTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.ACC_AVDDX_PVTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATDcheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_AVDDX_PVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ATDcheckEdit);
            this.layoutControl1.Controls.Add(this.pivotGridControl1);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.dateEdit2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(950, 285, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1108, 674);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ATDcheckEdit
            // 
            this.ATDcheckEdit.Location = new System.Drawing.Point(336, 12);
            this.ATDcheckEdit.Name = "ATDcheckEdit";
            this.ATDcheckEdit.Properties.Caption = "ATD";
            this.ATDcheckEdit.Size = new System.Drawing.Size(73, 19);
            this.ATDcheckEdit.StyleController = this.layoutControl1;
            this.ATDcheckEdit.TabIndex = 9;
            this.ATDcheckEdit.Visible = false;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.pivotGridControl1.DataSource = this.aCC_AVDDX_PVTBindingSource;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldAVBID,
            this.fieldTUR,
            this.fieldAVDID,
            this.fieldHSPAD,
            this.fieldXHSPAD,
            this.fieldXH1AD,
            this.fieldXH2AD,
            this.fieldAKMAD,
            this.fieldBA,
            this.fieldTUT,
            this.fieldDVZ,
            this.fieldRTUT,
            this.fieldTRH,
            this.fieldTRHq,
            this.fieldTRHm});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 38);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(1084, 624);
            this.pivotGridControl1.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // aCC_AVDDX_PVTBindingSource
            // 
            this.aCC_AVDDX_PVTBindingSource.DataMember = "ACC_AVDDX_PVT";
            this.aCC_AVDDX_PVTBindingSource.DataSource = this.accountRprDataSet;
            // 
            // accountRprDataSet
            // 
            this.accountRprDataSet.DataSetName = "AccountRprDataSet";
            this.accountRprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldAVBID
            // 
            this.fieldAVBID.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldAVBID.AreaIndex = 0;
            this.fieldAVBID.FieldName = "AVBID";
            this.fieldAVBID.Name = "fieldAVBID";
            // 
            // fieldTUR
            // 
            this.fieldTUR.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTUR.AreaIndex = 4;
            this.fieldTUR.Caption = "Tür";
            this.fieldTUR.FieldName = "TUR";
            this.fieldTUR.Name = "fieldTUR";
            // 
            // fieldAVDID
            // 
            this.fieldAVDID.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldAVDID.AreaIndex = 5;
            this.fieldAVDID.FieldName = "AVDID";
            this.fieldAVDID.Name = "fieldAVDID";
            // 
            // fieldHSPAD
            // 
            this.fieldHSPAD.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldHSPAD.AreaIndex = 6;
            this.fieldHSPAD.Caption = "Hesap";
            this.fieldHSPAD.FieldName = "HSPAD";
            this.fieldHSPAD.Name = "fieldHSPAD";
            // 
            // fieldXHSPAD
            // 
            this.fieldXHSPAD.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldXHSPAD.AreaIndex = 7;
            this.fieldXHSPAD.Caption = "xHesap";
            this.fieldXHSPAD.FieldName = "XHSPAD";
            this.fieldXHSPAD.Name = "fieldXHSPAD";
            // 
            // fieldXH1AD
            // 
            this.fieldXH1AD.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldXH1AD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldXH1AD.AreaIndex = 0;
            this.fieldXH1AD.Caption = "x1";
            this.fieldXH1AD.FieldName = "XH1AD";
            this.fieldXH1AD.Name = "fieldXH1AD";
            // 
            // fieldXH2AD
            // 
            this.fieldXH2AD.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldXH2AD.AreaIndex = 8;
            this.fieldXH2AD.Caption = "x2";
            this.fieldXH2AD.FieldName = "XH2AD";
            this.fieldXH2AD.Name = "fieldXH2AD";
            // 
            // fieldAKMAD
            // 
            this.fieldAKMAD.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldAKMAD.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldAKMAD.AreaIndex = 0;
            this.fieldAKMAD.Caption = "Merkez";
            this.fieldAKMAD.FieldName = "AKMAD";
            this.fieldAKMAD.Name = "fieldAKMAD";
            // 
            // fieldBA
            // 
            this.fieldBA.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldBA.AreaIndex = 9;
            this.fieldBA.FieldName = "BA";
            this.fieldBA.Name = "fieldBA";
            // 
            // fieldTUT
            // 
            this.fieldTUT.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTUT.AreaIndex = 10;
            this.fieldTUT.Caption = "Tut";
            this.fieldTUT.CellFormat.FormatString = "n";
            this.fieldTUT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldTUT.FieldName = "TUT";
            this.fieldTUT.Name = "fieldTUT";
            // 
            // fieldDVZ
            // 
            this.fieldDVZ.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldDVZ.AreaIndex = 11;
            this.fieldDVZ.Caption = "Dvz";
            this.fieldDVZ.FieldName = "DVZ";
            this.fieldDVZ.Name = "fieldDVZ";
            // 
            // fieldRTUT
            // 
            this.fieldRTUT.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldRTUT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRTUT.AreaIndex = 0;
            this.fieldRTUT.Caption = "TutEUR";
            this.fieldRTUT.CellFormat.FormatString = "n";
            this.fieldRTUT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRTUT.FieldName = "RTUT";
            this.fieldRTUT.Name = "fieldRTUT";
            // 
            // fieldTRH
            // 
            this.fieldTRH.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTRH.AreaIndex = 1;
            this.fieldTRH.Caption = "Trh";
            this.fieldTRH.FieldName = "TRH";
            this.fieldTRH.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldTRH.Name = "fieldTRH";
            this.fieldTRH.UnboundFieldName = "fieldTRH";
            // 
            // fieldTRHq
            // 
            this.fieldTRHq.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTRHq.AreaIndex = 2;
            this.fieldTRHq.Caption = "TrhQ";
            this.fieldTRHq.FieldName = "TRH";
            this.fieldTRHq.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldTRHq.Name = "fieldTRHq";
            this.fieldTRHq.UnboundFieldName = "fieldTRHq";
            // 
            // fieldTRHm
            // 
            this.fieldTRHm.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTRHm.AreaIndex = 3;
            this.fieldTRHm.Caption = "TrhM";
            this.fieldTRHm.FieldName = "TRH";
            this.fieldTRHm.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldTRHm.Name = "fieldTRHm";
            this.fieldTRHm.UnboundFieldName = "fieldTRHm";
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
            this.dateEdit1.Size = new System.Drawing.Size(112, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(413, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(683, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "FILL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(220, 12);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(112, 20);
            this.dateEdit2.StyleController = this.layoutControl1;
            this.dateEdit2.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1108, 674);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEdit1;
            this.layoutControlItem1.CustomizationFormText = "Tarih >=";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(162, 26);
            this.layoutControlItem1.Text = "Tarih >=";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.pivotGridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1088, 628);
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(401, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(687, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dateEdit2;
            this.layoutControlItem4.CustomizationFormText = "Tarih <";
            this.layoutControlItem4.Location = new System.Drawing.Point(162, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(162, 26);
            this.layoutControlItem4.Text = "Tarih <";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ATDcheckEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(324, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(77, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // aCC_AVDDX_PVTTableAdapter
            // 
            this.aCC_AVDDX_PVTTableAdapter.ClearBeforeFill = true;
            // 
            // AccAvddxPvtXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 674);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AccAvddxPvtXF";
            this.Text = "Muhasebe Fis Masraf Pivot [AccAvddxPvtXF]";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ATDcheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aCC_AVDDX_PVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private AccountRprDataSet accountRprDataSet;
        private System.Windows.Forms.BindingSource aCC_AVDDX_PVTBindingSource;
        private AccountRprDataSetTableAdapters.ACC_AVDDX_PVTTableAdapter aCC_AVDDX_PVTTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAVBID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTRH;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTUR;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAVDID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHSPAD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldXHSPAD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldXH1AD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldXH2AD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAKMAD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBA;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTUT;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDVZ;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRTUT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTRHq;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTRHm;
        private DevExpress.XtraEditors.CheckEdit ATDcheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
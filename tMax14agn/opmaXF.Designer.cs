namespace tMax14agn
{
    partial class opmaXF
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataSet = new tMax14agn.DataSet();
            this.aMETABindingSource = new System.Windows.Forms.BindingSource();
            this.aMETATableAdapter = new tMax14agn.DataSetTableAdapters.AMETATableAdapter();
            this.ametaGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAgnPendingFinsihedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ametaGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHARGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colR4TO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colE4TO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colR4XX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colE4XX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPMAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ASTUrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.aMETAPROFITCALCBindingSource = new System.Windows.Forms.BindingSource();
            this.category = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowR4TO = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowE4TO = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBTO = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.category1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowR4XX = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowE4XX = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBXX = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.category2 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowPS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowVTO = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowVMSJ = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.aMETA_PROFIT_CALCTableAdapter = new tMax14agn.DataSetTableAdapters.AMETA_PROFIT_CALCTableAdapter();
            this.queriesTableAdapter = new tMax14agn.DataSetTableAdapters.QueriesTableAdapter();
            this.colCNTINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ametaGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ametaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASTUrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMETAPROFITCALCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aMETABindingSource
            // 
            this.aMETABindingSource.DataMember = "AMETA";
            this.aMETABindingSource.DataSource = this.dataSet;
            // 
            // aMETATableAdapter
            // 
            this.aMETATableAdapter.ClearBeforeFill = true;
            // 
            // ametaGridControl
            // 
            this.ametaGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.ametaGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ametaGridControl.DataSource = this.aMETABindingSource;
            this.ametaGridControl.Location = new System.Drawing.Point(4, 4);
            this.ametaGridControl.MainView = this.ametaGridView;
            this.ametaGridControl.Name = "ametaGridControl";
            this.ametaGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ASTUrepositoryItemImageComboBox});
            this.ametaGridControl.Size = new System.Drawing.Size(1057, 377);
            this.ametaGridControl.TabIndex = 2;
            this.ametaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ametaGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.setAgnPendingFinsihedToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(145, 48);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // setAgnPendingFinsihedToolStripMenuItem
            // 
            this.setAgnPendingFinsihedToolStripMenuItem.Name = "setAgnPendingFinsihedToolStripMenuItem";
            this.setAgnPendingFinsihedToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.setAgnPendingFinsihedToolStripMenuItem.Text = "Set AgnClosed";
            this.setAgnPendingFinsihedToolStripMenuItem.Click += new System.EventHandler(this.setAgnPendingFinsihedToolStripMenuItem_Click);
            // 
            // ametaGridView
            // 
            this.ametaGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHM,
            this.colOPID,
            this.colCHARGE,
            this.colDVZ,
            this.colR4TO,
            this.colE4TO,
            this.colR4XX,
            this.colE4XX,
            this.colINFO,
            this.colOPMAID,
            this.colCNTINFO});
            this.ametaGridView.GridControl = this.ametaGridControl;
            this.ametaGridView.Name = "ametaGridView";
            this.ametaGridView.OptionsView.ShowFooter = true;
            this.ametaGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colHM
            // 
            this.colHM.FieldName = "HM";
            this.colHM.Name = "colHM";
            this.colHM.OptionsColumn.AllowEdit = false;
            this.colHM.OptionsColumn.AllowFocus = false;
            this.colHM.OptionsColumn.FixedWidth = true;
            this.colHM.Visible = true;
            this.colHM.VisibleIndex = 0;
            this.colHM.Width = 32;
            // 
            // colOPID
            // 
            this.colOPID.FieldName = "OPID";
            this.colOPID.Name = "colOPID";
            this.colOPID.OptionsColumn.AllowEdit = false;
            this.colOPID.OptionsColumn.AllowFocus = false;
            this.colOPID.OptionsColumn.FixedWidth = true;
            this.colOPID.Visible = true;
            this.colOPID.VisibleIndex = 1;
            // 
            // colCHARGE
            // 
            this.colCHARGE.Caption = "Charge";
            this.colCHARGE.FieldName = "CHARGE";
            this.colCHARGE.Name = "colCHARGE";
            this.colCHARGE.OptionsColumn.AllowEdit = false;
            this.colCHARGE.OptionsColumn.AllowFocus = false;
            this.colCHARGE.Visible = true;
            this.colCHARGE.VisibleIndex = 2;
            this.colCHARGE.Width = 190;
            // 
            // colDVZ
            // 
            this.colDVZ.Caption = "Cur";
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.OptionsColumn.AllowEdit = false;
            this.colDVZ.OptionsColumn.AllowFocus = false;
            this.colDVZ.OptionsColumn.FixedWidth = true;
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 3;
            this.colDVZ.Width = 39;
            // 
            // colR4TO
            // 
            this.colR4TO.Caption = "Rvn4TO";
            this.colR4TO.DisplayFormat.FormatString = "n";
            this.colR4TO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colR4TO.FieldName = "R4TO";
            this.colR4TO.Name = "colR4TO";
            this.colR4TO.OptionsColumn.AllowEdit = false;
            this.colR4TO.OptionsColumn.AllowFocus = false;
            this.colR4TO.OptionsColumn.FixedWidth = true;
            this.colR4TO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "R4TO", "{0:n}")});
            this.colR4TO.Visible = true;
            this.colR4TO.VisibleIndex = 4;
            // 
            // colE4TO
            // 
            this.colE4TO.Caption = "Exp4TO";
            this.colE4TO.DisplayFormat.FormatString = "n";
            this.colE4TO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colE4TO.FieldName = "E4TO";
            this.colE4TO.Name = "colE4TO";
            this.colE4TO.OptionsColumn.AllowEdit = false;
            this.colE4TO.OptionsColumn.AllowFocus = false;
            this.colE4TO.OptionsColumn.FixedWidth = true;
            this.colE4TO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "E4TO", "{0:n}")});
            this.colE4TO.Visible = true;
            this.colE4TO.VisibleIndex = 5;
            // 
            // colR4XX
            // 
            this.colR4XX.Caption = "Rvn4Agn";
            this.colR4XX.DisplayFormat.FormatString = "n";
            this.colR4XX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colR4XX.FieldName = "R4XX";
            this.colR4XX.Name = "colR4XX";
            this.colR4XX.OptionsColumn.FixedWidth = true;
            this.colR4XX.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "R4XX", "{0:n}")});
            this.colR4XX.Visible = true;
            this.colR4XX.VisibleIndex = 6;
            // 
            // colE4XX
            // 
            this.colE4XX.Caption = "Exp4Agn";
            this.colE4XX.DisplayFormat.FormatString = "n";
            this.colE4XX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colE4XX.FieldName = "E4XX";
            this.colE4XX.Name = "colE4XX";
            this.colE4XX.OptionsColumn.FixedWidth = true;
            this.colE4XX.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "E4XX", "{0:n}")});
            this.colE4XX.Visible = true;
            this.colE4XX.VisibleIndex = 7;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "OpInfo";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.OptionsColumn.AllowEdit = false;
            this.colINFO.OptionsColumn.AllowFocus = false;
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 8;
            this.colINFO.Width = 202;
            // 
            // colOPMAID
            // 
            this.colOPMAID.FieldName = "OPMAID";
            this.colOPMAID.Name = "colOPMAID";
            this.colOPMAID.OptionsColumn.AllowEdit = false;
            this.colOPMAID.OptionsColumn.AllowFocus = false;
            // 
            // ASTUrepositoryItemImageComboBox
            // 
            this.ASTUrepositoryItemImageComboBox.AutoHeight = false;
            this.ASTUrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ASTUrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pending", "1", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Opn2Agn", "2", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("CmpByAgn", "3", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Closed", "4", -1)});
            this.ASTUrepositoryItemImageComboBox.Name = "ASTUrepositoryItemImageComboBox";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.vGridControl1);
            this.layoutControl1.Controls.Add(this.ametaGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(626, 154, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1294, 385);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // vGridControl1
            // 
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.vGridControl1.DataSource = this.aMETAPROFITCALCBindingSource;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(1070, 4);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 109;
            this.vGridControl1.RowHeaderWidth = 91;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.category,
            this.category1,
            this.category2,
            this.rowPS,
            this.rowVTO,
            this.rowVMSJ});
            this.vGridControl1.Size = new System.Drawing.Size(220, 377);
            this.vGridControl1.TabIndex = 4;
            // 
            // aMETAPROFITCALCBindingSource
            // 
            this.aMETAPROFITCALCBindingSource.DataMember = "AMETA_PROFIT_CALC";
            this.aMETAPROFITCALCBindingSource.DataSource = this.dataSet;
            // 
            // category
            // 
            this.category.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowR4TO,
            this.rowE4TO,
            this.rowBTO});
            this.category.Name = "category";
            this.category.Properties.Caption = "Transorient";
            // 
            // rowR4TO
            // 
            this.rowR4TO.Name = "rowR4TO";
            this.rowR4TO.Properties.Caption = "Revenue";
            this.rowR4TO.Properties.FieldName = "R4TO";
            // 
            // rowE4TO
            // 
            this.rowE4TO.Name = "rowE4TO";
            this.rowE4TO.Properties.Caption = "Expense";
            this.rowE4TO.Properties.FieldName = "E4TO";
            // 
            // rowBTO
            // 
            this.rowBTO.Name = "rowBTO";
            this.rowBTO.Properties.Caption = "Balance";
            this.rowBTO.Properties.FieldName = "BTO";
            // 
            // category1
            // 
            this.category1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowR4XX,
            this.rowE4XX,
            this.rowBXX});
            this.category1.Name = "category1";
            this.category1.Properties.Caption = "Agent";
            // 
            // rowR4XX
            // 
            this.rowR4XX.Name = "rowR4XX";
            this.rowR4XX.Properties.Caption = "Revenue";
            this.rowR4XX.Properties.FieldName = "R4XX";
            // 
            // rowE4XX
            // 
            this.rowE4XX.Name = "rowE4XX";
            this.rowE4XX.Properties.Caption = "Expense";
            this.rowE4XX.Properties.FieldName = "E4XX";
            // 
            // rowBXX
            // 
            this.rowBXX.Name = "rowBXX";
            this.rowBXX.Properties.Caption = "Balance";
            this.rowBXX.Properties.FieldName = "BXX";
            // 
            // category2
            // 
            this.category2.Name = "category2";
            // 
            // rowPS
            // 
            this.rowPS.Name = "rowPS";
            this.rowPS.Properties.Caption = "ProfitShare";
            this.rowPS.Properties.FieldName = "PS";
            // 
            // rowVTO
            // 
            this.rowVTO.Name = "rowVTO";
            this.rowVTO.Properties.Caption = "Bill";
            this.rowVTO.Properties.FieldName = "VTO";
            // 
            // rowVMSJ
            // 
            this.rowVMSJ.Name = "rowVMSJ";
            this.rowVMSJ.Properties.Caption = ".";
            this.rowVMSJ.Properties.FieldName = "VMSJ";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1294, 385);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ametaGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1061, 381);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.vGridControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(1066, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(224, 381);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(1061, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 381);
            // 
            // aMETA_PROFIT_CALCTableAdapter
            // 
            this.aMETA_PROFIT_CALCTableAdapter.ClearBeforeFill = true;
            // 
            // colCNTINFO
            // 
            this.colCNTINFO.Caption = "CntInfo";
            this.colCNTINFO.FieldName = "CNTINFO";
            this.colCNTINFO.Name = "colCNTINFO";
            this.colCNTINFO.OptionsColumn.AllowEdit = false;
            this.colCNTINFO.OptionsColumn.AllowFocus = false;
            this.colCNTINFO.Visible = true;
            this.colCNTINFO.VisibleIndex = 9;
            this.colCNTINFO.Width = 201;
            // 
            // opmaXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "opmaXF";
            this.Size = new System.Drawing.Size(1294, 385);
            this.Load += new System.EventHandler(this.opmaXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMETABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ametaGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ametaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASTUrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMETAPROFITCALCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource aMETABindingSource;
        private DataSetTableAdapters.AMETATableAdapter aMETATableAdapter;
        private DevExpress.XtraGrid.GridControl ametaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ametaGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colHM;
        private DevExpress.XtraGrid.Columns.GridColumn colOPID;
        private DevExpress.XtraGrid.Columns.GridColumn colCHARGE;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colR4TO;
        private DevExpress.XtraGrid.Columns.GridColumn colE4TO;
        private DevExpress.XtraGrid.Columns.GridColumn colR4XX;
        private DevExpress.XtraGrid.Columns.GridColumn colE4XX;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private System.Windows.Forms.BindingSource aMETAPROFITCALCBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DataSetTableAdapters.AMETA_PROFIT_CALCTableAdapter aMETA_PROFIT_CALCTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowR4TO;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowE4TO;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBTO;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowR4XX;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowE4XX;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBXX;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowVTO;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowVMSJ;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox ASTUrepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colOPMAID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAgnPendingFinsihedToolStripMenuItem;
        private DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCNTINFO;
    }
}

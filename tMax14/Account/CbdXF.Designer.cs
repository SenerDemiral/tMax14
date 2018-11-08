namespace tMax14.Account
{
    partial class CbdXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CbdXF));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DrmRepositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.cBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBDTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.CBDTableAdapter();
            this.cBDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cBDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cBDGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.muhasebeFisiOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCBDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCBBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCORRIBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCORRHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCORRHSPNOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCORRTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CorrTurRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountQueriesTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AccountQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DrmRepositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBDBindingNavigator)).BeginInit();
            this.cBDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBDGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrTurRepositoryItemImageComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colDRM
            // 
            this.colDRM.Caption = "Drm";
            this.colDRM.ColumnEdit = this.DrmRepositoryItemImageComboBox1;
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.OptionsColumn.FixedWidth = true;
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 1;
            this.colDRM.Width = 41;
            // 
            // DrmRepositoryItemImageComboBox1
            // 
            this.DrmRepositoryItemImageComboBox1.AutoHeight = false;
            this.DrmRepositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DrmRepositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Doğru", "D", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Hatalı", "H", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("İptal", "I", -1)});
            this.DrmRepositoryItemImageComboBox1.Name = "DrmRepositoryItemImageComboBox1";
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cBDBindingSource
            // 
            this.cBDBindingSource.DataMember = "CBD";
            this.cBDBindingSource.DataSource = this.accountDataSet;
            // 
            // cBDTableAdapter
            // 
            this.cBDTableAdapter.ClearBeforeFill = true;
            // 
            // cBDBindingNavigator
            // 
            this.cBDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cBDBindingNavigator.BindingSource = this.cBDBindingSource;
            this.cBDBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cBDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cBDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cBDBindingNavigatorSaveItem});
            this.cBDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cBDBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cBDBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cBDBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cBDBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cBDBindingNavigator.Name = "cBDBindingNavigator";
            this.cBDBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cBDBindingNavigator.Size = new System.Drawing.Size(927, 25);
            this.cBDBindingNavigator.TabIndex = 0;
            this.cBDBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            this.bindingNavigatorCountItem.Visible = false;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Visible = false;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Visible = false;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator.Visible = false;
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Visible = false;
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator1.Visible = false;
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Visible = false;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Visible = false;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator2.Visible = false;
            // 
            // cBDBindingNavigatorSaveItem
            // 
            this.cBDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cBDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cBDBindingNavigatorSaveItem.Image")));
            this.cBDBindingNavigatorSaveItem.Name = "cBDBindingNavigatorSaveItem";
            this.cBDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cBDBindingNavigatorSaveItem.Text = "Save Data";
            this.cBDBindingNavigatorSaveItem.Click += new System.EventHandler(this.cBDBindingNavigatorSaveItem_Click);
            // 
            // cBDGridControl
            // 
            this.cBDGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.cBDGridControl.DataSource = this.cBDBindingSource;
            this.cBDGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBDGridControl.Location = new System.Drawing.Point(0, 25);
            this.cBDGridControl.MainView = this.gridView1;
            this.cBDGridControl.Name = "cBDGridControl";
            this.cBDGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DrmRepositoryItemImageComboBox1,
            this.CorrTurRepositoryItemImageComboBox});
            this.cBDGridControl.Size = new System.Drawing.Size(927, 288);
            this.cBDGridControl.TabIndex = 2;
            this.cBDGridControl.Tag = "CBD";
            this.cBDGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.toolStripSeparator1,
            this.muhasebeFisiOlusturToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(190, 76);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // muhasebeFisiOlusturToolStripMenuItem
            // 
            this.muhasebeFisiOlusturToolStripMenuItem.Name = "muhasebeFisiOlusturToolStripMenuItem";
            this.muhasebeFisiOlusturToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.muhasebeFisiOlusturToolStripMenuItem.Text = "Muhasebe Fişi oluştur";
            this.muhasebeFisiOlusturToolStripMenuItem.Click += new System.EventHandler(this.muhasebeFisiOlusturToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCBDID,
            this.colCBBID,
            this.colDRM,
            this.colIBAN,
            this.colHSPNO,
            this.colCORRIBAN,
            this.colCORRHSPNO,
            this.colCORRHSPNOS,
            this.colCORRTUR,
            this.colDVZ,
            this.colTUT,
            this.colINFO});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colDRM;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Bisque;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = "H";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.colDRM;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = "I";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.GridControl = this.cBDGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colCBDID
            // 
            this.colCBDID.DisplayFormat.FormatString = "n0";
            this.colCBDID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCBDID.FieldName = "CBDID";
            this.colCBDID.Name = "colCBDID";
            this.colCBDID.OptionsColumn.AllowFocus = false;
            this.colCBDID.OptionsColumn.FixedWidth = true;
            this.colCBDID.OptionsColumn.ReadOnly = true;
            this.colCBDID.Visible = true;
            this.colCBDID.VisibleIndex = 0;
            // 
            // colCBBID
            // 
            this.colCBBID.FieldName = "CBBID";
            this.colCBBID.Name = "colCBBID";
            this.colCBBID.OptionsColumn.FixedWidth = true;
            this.colCBBID.OptionsColumn.ReadOnly = true;
            // 
            // colIBAN
            // 
            this.colIBAN.FieldName = "IBAN";
            this.colIBAN.Name = "colIBAN";
            this.colIBAN.OptionsColumn.AllowFocus = false;
            this.colIBAN.OptionsColumn.ReadOnly = true;
            this.colIBAN.Visible = true;
            this.colIBAN.VisibleIndex = 2;
            this.colIBAN.Width = 88;
            // 
            // colHSPNO
            // 
            this.colHSPNO.Caption = "HspNo";
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.OptionsColumn.AllowFocus = false;
            this.colHSPNO.OptionsColumn.ReadOnly = true;
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 3;
            this.colHSPNO.Width = 88;
            // 
            // colCORRIBAN
            // 
            this.colCORRIBAN.Caption = "CorrIBAN";
            this.colCORRIBAN.FieldName = "CORRIBAN";
            this.colCORRIBAN.Name = "colCORRIBAN";
            this.colCORRIBAN.OptionsColumn.ReadOnly = true;
            this.colCORRIBAN.Visible = true;
            this.colCORRIBAN.VisibleIndex = 4;
            this.colCORRIBAN.Width = 88;
            // 
            // colCORRHSPNO
            // 
            this.colCORRHSPNO.Caption = "CorrHspNo";
            this.colCORRHSPNO.FieldName = "CORRHSPNO";
            this.colCORRHSPNO.Name = "colCORRHSPNO";
            this.colCORRHSPNO.Visible = true;
            this.colCORRHSPNO.VisibleIndex = 5;
            this.colCORRHSPNO.Width = 88;
            // 
            // colCORRHSPNOS
            // 
            this.colCORRHSPNOS.Caption = "CorrHspNoS";
            this.colCORRHSPNOS.FieldName = "CORRHSPNOS";
            this.colCORRHSPNOS.Name = "colCORRHSPNOS";
            this.colCORRHSPNOS.OptionsColumn.ReadOnly = true;
            this.colCORRHSPNOS.Visible = true;
            this.colCORRHSPNOS.VisibleIndex = 6;
            this.colCORRHSPNOS.Width = 76;
            // 
            // colCORRTUR
            // 
            this.colCORRTUR.Caption = "CorrTur";
            this.colCORRTUR.ColumnEdit = this.CorrTurRepositoryItemImageComboBox;
            this.colCORRTUR.FieldName = "CORRTUR";
            this.colCORRTUR.Name = "colCORRTUR";
            this.colCORRTUR.OptionsColumn.FixedWidth = true;
            this.colCORRTUR.Visible = true;
            this.colCORRTUR.VisibleIndex = 7;
            this.colCORRTUR.Width = 49;
            // 
            // CorrTurRepositoryItemImageComboBox
            // 
            this.CorrTurRepositoryItemImageComboBox.AutoHeight = false;
            this.CorrTurRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CorrTurRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Müşteri", "M", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Biz", "B", -1)});
            this.CorrTurRepositoryItemImageComboBox.Name = "CorrTurRepositoryItemImageComboBox";
            // 
            // colDVZ
            // 
            this.colDVZ.Caption = "Dvz";
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.OptionsColumn.AllowFocus = false;
            this.colDVZ.OptionsColumn.FixedWidth = true;
            this.colDVZ.OptionsColumn.ReadOnly = true;
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 9;
            this.colDVZ.Width = 40;
            // 
            // colTUT
            // 
            this.colTUT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTUT.AppearanceCell.Options.UseFont = true;
            this.colTUT.AppearanceHeader.Options.UseTextOptions = true;
            this.colTUT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTUT.Caption = "Tutar";
            this.colTUT.DisplayFormat.FormatString = "n";
            this.colTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTUT.FieldName = "TUT";
            this.colTUT.Name = "colTUT";
            this.colTUT.OptionsColumn.AllowFocus = false;
            this.colTUT.OptionsColumn.FixedWidth = true;
            this.colTUT.OptionsColumn.ReadOnly = true;
            this.colTUT.Visible = true;
            this.colTUT.VisibleIndex = 8;
            this.colTUT.Width = 90;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Açıklama";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.OptionsColumn.ReadOnly = true;
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 10;
            this.colINFO.Width = 186;
            // 
            // CbdXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 313);
            this.Controls.Add(this.cBDGridControl);
            this.Controls.Add(this.cBDBindingNavigator);
            this.Name = "CbdXF";
            this.Text = "CbdXF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CbdXF_FormClosing);
            this.Load += new System.EventHandler(this.CbdXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrmRepositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBDBindingNavigator)).EndInit();
            this.cBDBindingNavigator.ResumeLayout(false);
            this.cBDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBDGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrTurRepositoryItemImageComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource cBDBindingSource;
        private AccountDataSetTableAdapters.CBDTableAdapter cBDTableAdapter;
        private System.Windows.Forms.BindingNavigator cBDBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cBDBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl cBDGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCBDID;
        private DevExpress.XtraGrid.Columns.GridColumn colCBBID;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colIBAN;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colCORRIBAN;
        private DevExpress.XtraGrid.Columns.GridColumn colCORRHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colCORRHSPNOS;
        private DevExpress.XtraGrid.Columns.GridColumn colCORRTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox DrmRepositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox CorrTurRepositoryItemImageComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhasebeFisiOlusturToolStripMenuItem;
        private AccountDataSetTableAdapters.AccountQueriesTableAdapter accountQueriesTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}
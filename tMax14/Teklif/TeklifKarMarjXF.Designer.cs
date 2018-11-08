namespace tMax14.Teklif
{
    partial class TeklifKarMarjXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeklifKarMarjXF));
            this.teklifDataSet = new tMax14.Teklif.TeklifDataSet();
            this.tkmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tkmTableAdapter = new tMax14.Teklif.TeklifDataSetTableAdapters.TKMTableAdapter();
            this.tkmGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tkmGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAHTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TYPrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKMG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKM2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKM3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKM4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKM5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKM6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKM7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKM8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KMGrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tKMBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tKMBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.colTKMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teklifQueriesTableAdapter = new tMax14.Teklif.TeklifDataSetTableAdapters.TeklifQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teklifDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkmGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkmGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TYPrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMGrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKMBindingNavigator)).BeginInit();
            this.tKMBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // teklifDataSet
            // 
            this.teklifDataSet.DataSetName = "TeklifDataSet";
            this.teklifDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tkmBindingSource
            // 
            this.tkmBindingSource.DataMember = "TKM";
            this.tkmBindingSource.DataSource = this.teklifDataSet;
            // 
            // tkmTableAdapter
            // 
            this.tkmTableAdapter.ClearBeforeFill = true;
            // 
            // tkmGridControl
            // 
            this.tkmGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.tkmGridControl.DataSource = this.tkmBindingSource;
            this.tkmGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tkmGridControl.Location = new System.Drawing.Point(0, 25);
            this.tkmGridControl.MainView = this.tkmGridView;
            this.tkmGridControl.Name = "tkmGridControl";
            this.tkmGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TYPrepositoryItemImageComboBox,
            this.KMGrepositoryItemImageComboBox});
            this.tkmGridControl.Size = new System.Drawing.Size(846, 268);
            this.tkmGridControl.TabIndex = 1;
            this.tkmGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tkmGridView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.duplicateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 70);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // tkmGridView
            // 
            this.tkmGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTKMID,
            this.colAHTID,
            this.colTYP,
            this.colROT,
            this.colMOT,
            this.colKMG,
            this.colDVZ,
            this.colKM,
            this.colKM1,
            this.colKM2,
            this.colKM3,
            this.colKM4,
            this.colKM5,
            this.colKM6,
            this.colKM7,
            this.colKM8,
            this.colTOP});
            this.tkmGridView.GridControl = this.tkmGridControl;
            this.tkmGridView.Name = "tkmGridView";
            this.tkmGridView.OptionsNavigation.AutoFocusNewRow = true;
            this.tkmGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.tkmGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.tkmGridView_InitNewRow);
            this.tkmGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.tkmGridView_ValidateRow);
            // 
            // colAHTID
            // 
            this.colAHTID.FieldName = "AHTID";
            this.colAHTID.Name = "colAHTID";
            this.colAHTID.Visible = true;
            this.colAHTID.VisibleIndex = 3;
            this.colAHTID.Width = 54;
            // 
            // colTYP
            // 
            this.colTYP.Caption = "Typ";
            this.colTYP.ColumnEdit = this.TYPrepositoryItemImageComboBox;
            this.colTYP.FieldName = "TYP";
            this.colTYP.Name = "colTYP";
            this.colTYP.Visible = true;
            this.colTYP.VisibleIndex = 4;
            this.colTYP.Width = 54;
            // 
            // TYPrepositoryItemImageComboBox
            // 
            this.TYPrepositoryItemImageComboBox.AutoHeight = false;
            this.TYPrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TYPrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Freight", "F", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("CarrierExtra", "C", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Genel", "G", -1)});
            this.TYPrepositoryItemImageComboBox.Name = "TYPrepositoryItemImageComboBox";
            // 
            // colROT
            // 
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 1;
            this.colROT.Width = 54;
            // 
            // colMOT
            // 
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 2;
            this.colMOT.Width = 54;
            // 
            // colKMG
            // 
            this.colKMG.FieldName = "KMG";
            this.colKMG.Name = "colKMG";
            this.colKMG.Visible = true;
            this.colKMG.VisibleIndex = 5;
            this.colKMG.Width = 35;
            // 
            // colDVZ
            // 
            this.colDVZ.Caption = "Dvz";
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 7;
            this.colDVZ.Width = 47;
            // 
            // colKM
            // 
            this.colKM.Caption = "KM (Fyt)";
            this.colKM.FieldName = "KM";
            this.colKM.Name = "colKM";
            this.colKM.Visible = true;
            this.colKM.VisibleIndex = 8;
            this.colKM.Width = 57;
            // 
            // colKM1
            // 
            this.colKM1.Caption = "KM1 (Min)";
            this.colKM1.FieldName = "KM1";
            this.colKM1.Name = "colKM1";
            this.colKM1.Visible = true;
            this.colKM1.VisibleIndex = 9;
            this.colKM1.Width = 57;
            // 
            // colKM2
            // 
            this.colKM2.FieldName = "KM2";
            this.colKM2.Name = "colKM2";
            this.colKM2.Visible = true;
            this.colKM2.VisibleIndex = 10;
            this.colKM2.Width = 57;
            // 
            // colKM3
            // 
            this.colKM3.FieldName = "KM3";
            this.colKM3.Name = "colKM3";
            this.colKM3.Visible = true;
            this.colKM3.VisibleIndex = 11;
            this.colKM3.Width = 57;
            // 
            // colKM4
            // 
            this.colKM4.FieldName = "KM4";
            this.colKM4.Name = "colKM4";
            this.colKM4.Visible = true;
            this.colKM4.VisibleIndex = 12;
            this.colKM4.Width = 57;
            // 
            // colKM5
            // 
            this.colKM5.FieldName = "KM5";
            this.colKM5.Name = "colKM5";
            this.colKM5.Visible = true;
            this.colKM5.VisibleIndex = 13;
            this.colKM5.Width = 57;
            // 
            // colKM6
            // 
            this.colKM6.FieldName = "KM6";
            this.colKM6.Name = "colKM6";
            this.colKM6.Visible = true;
            this.colKM6.VisibleIndex = 14;
            this.colKM6.Width = 57;
            // 
            // colKM7
            // 
            this.colKM7.FieldName = "KM7";
            this.colKM7.Name = "colKM7";
            this.colKM7.Visible = true;
            this.colKM7.VisibleIndex = 15;
            this.colKM7.Width = 57;
            // 
            // colKM8
            // 
            this.colKM8.FieldName = "KM8";
            this.colKM8.Name = "colKM8";
            this.colKM8.Visible = true;
            this.colKM8.VisibleIndex = 16;
            this.colKM8.Width = 74;
            // 
            // colTOP
            // 
            this.colTOP.Caption = "TOP(s)";
            this.colTOP.FieldName = "TOP";
            this.colTOP.Name = "colTOP";
            this.colTOP.Visible = true;
            this.colTOP.VisibleIndex = 6;
            // 
            // KMGrepositoryItemImageComboBox
            // 
            this.KMGrepositoryItemImageComboBox.AutoHeight = false;
            this.KMGrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.KMGrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("A", "A", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("B", "B", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("C", "C", -1)});
            this.KMGrepositoryItemImageComboBox.Name = "KMGrepositoryItemImageComboBox";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tKMBindingNavigatorSaveItem
            // 
            this.tKMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tKMBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tKMBindingNavigatorSaveItem.Image")));
            this.tKMBindingNavigatorSaveItem.Name = "tKMBindingNavigatorSaveItem";
            this.tKMBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tKMBindingNavigatorSaveItem.Text = "Save Data";
            this.tKMBindingNavigatorSaveItem.Click += new System.EventHandler(this.tKMBindingNavigatorSaveItem_Click);
            // 
            // tKMBindingNavigator
            // 
            this.tKMBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tKMBindingNavigator.BindingSource = this.tkmBindingSource;
            this.tKMBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tKMBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tKMBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tKMBindingNavigatorSaveItem});
            this.tKMBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tKMBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tKMBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tKMBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tKMBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tKMBindingNavigator.Name = "tKMBindingNavigator";
            this.tKMBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tKMBindingNavigator.Size = new System.Drawing.Size(846, 25);
            this.tKMBindingNavigator.TabIndex = 0;
            this.tKMBindingNavigator.Text = "bindingNavigator1";
            // 
            // colTKMID
            // 
            this.colTKMID.FieldName = "TKMID";
            this.colTKMID.Name = "colTKMID";
            this.colTKMID.OptionsColumn.AllowEdit = false;
            this.colTKMID.OptionsColumn.AllowFocus = false;
            this.colTKMID.Visible = true;
            this.colTKMID.VisibleIndex = 0;
            // 
            // TeklifKarMarjXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 293);
            this.Controls.Add(this.tkmGridControl);
            this.Controls.Add(this.tKMBindingNavigator);
            this.Name = "TeklifKarMarjXF";
            this.Text = "TeklifKarMarjXF";
            this.Load += new System.EventHandler(this.TeklifKarMarjXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teklifDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkmGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tkmGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TYPrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMGrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKMBindingNavigator)).EndInit();
            this.tKMBindingNavigator.ResumeLayout(false);
            this.tKMBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TeklifDataSet teklifDataSet;
        private System.Windows.Forms.BindingSource tkmBindingSource;
        private TeklifDataSetTableAdapters.TKMTableAdapter tkmTableAdapter;
        private DevExpress.XtraGrid.GridControl tkmGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView tkmGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAHTID;
        private DevExpress.XtraGrid.Columns.GridColumn colTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colKMG;
        private DevExpress.XtraGrid.Columns.GridColumn colKM;
        private DevExpress.XtraGrid.Columns.GridColumn colKM1;
        private DevExpress.XtraGrid.Columns.GridColumn colKM2;
        private DevExpress.XtraGrid.Columns.GridColumn colKM3;
        private DevExpress.XtraGrid.Columns.GridColumn colKM4;
        private DevExpress.XtraGrid.Columns.GridColumn colKM5;
        private DevExpress.XtraGrid.Columns.GridColumn colKM6;
        private DevExpress.XtraGrid.Columns.GridColumn colKM7;
        private DevExpress.XtraGrid.Columns.GridColumn colKM8;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton tKMBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator tKMBindingNavigator;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TYPrepositoryItemImageComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox KMGrepositoryItemImageComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colTOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTKMID;
        private TeklifDataSetTableAdapters.TeklifQueriesTableAdapter teklifQueriesTableAdapter;
    }
}
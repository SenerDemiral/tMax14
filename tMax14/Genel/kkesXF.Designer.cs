namespace tMax14.Genel
{
    partial class kkesXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kkesXF));
            this.mainDataSet = new tMax14.MainDataSet();
            this.kkesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kkesTableAdapter = new tMax14.MainDataSetTableAdapters.KKESTableAdapter();
            this.kkesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.kKESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kkesGridControl = new DevExpress.XtraGrid.GridControl();
            this.kkesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKKESID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTBL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TBLrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colSUBJECT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBODY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BODYrepositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colUSRFNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USRFNSrepositoryItemCheckedComboBoxEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.USRFNSrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.mainQueriesTableAdapter = new tMax14.MainDataSetTableAdapters.MainQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkesBindingNavigator)).BeginInit();
            this.kkesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kkesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BODYrepositoryItemMemoExEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USRFNSrepositoryItemCheckedComboBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USRFNSrepositoryItemImageComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kkesBindingSource
            // 
            this.kkesBindingSource.DataMember = "KKES";
            this.kkesBindingSource.DataSource = this.mainDataSet;
            // 
            // kkesTableAdapter
            // 
            this.kkesTableAdapter.ClearBeforeFill = true;
            // 
            // kkesBindingNavigator
            // 
            this.kkesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kkesBindingNavigator.BindingSource = this.kkesBindingSource;
            this.kkesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kkesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kkesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kKESBindingNavigatorSaveItem});
            this.kkesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kkesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kkesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kkesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kkesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kkesBindingNavigator.Name = "kkesBindingNavigator";
            this.kkesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kkesBindingNavigator.Size = new System.Drawing.Size(493, 25);
            this.kkesBindingNavigator.TabIndex = 0;
            this.kkesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            // kKESBindingNavigatorSaveItem
            // 
            this.kKESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kKESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kKESBindingNavigatorSaveItem.Image")));
            this.kKESBindingNavigatorSaveItem.Name = "kKESBindingNavigatorSaveItem";
            this.kKESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kKESBindingNavigatorSaveItem.Text = "Save Data";
            this.kKESBindingNavigatorSaveItem.Click += new System.EventHandler(this.kKESBindingNavigatorSaveItem_Click);
            // 
            // kkesGridControl
            // 
            this.kkesGridControl.DataSource = this.kkesBindingSource;
            this.kkesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kkesGridControl.Location = new System.Drawing.Point(0, 25);
            this.kkesGridControl.MainView = this.kkesGridView;
            this.kkesGridControl.Name = "kkesGridControl";
            this.kkesGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TBLrepositoryItemImageComboBox,
            this.USRFNSrepositoryItemImageComboBox,
            this.USRFNSrepositoryItemCheckedComboBoxEdit,
            this.BODYrepositoryItemMemoExEdit});
            this.kkesGridControl.Size = new System.Drawing.Size(493, 287);
            this.kkesGridControl.TabIndex = 1;
            this.kkesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.kkesGridView});
            // 
            // kkesGridView
            // 
            this.kkesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKKESID,
            this.colTBL,
            this.colSUBJECT,
            this.colBODY,
            this.colUSRFNS});
            this.kkesGridView.GridControl = this.kkesGridControl;
            this.kkesGridView.Name = "kkesGridView";
            this.kkesGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.kkesGridView_InitNewRow);
            // 
            // colKKESID
            // 
            this.colKKESID.FieldName = "KKESID";
            this.colKKESID.Name = "colKKESID";
            this.colKKESID.OptionsColumn.AllowEdit = false;
            this.colKKESID.OptionsColumn.AllowFocus = false;
            this.colKKESID.OptionsColumn.FixedWidth = true;
            this.colKKESID.Visible = true;
            this.colKKESID.VisibleIndex = 0;
            this.colKKESID.Width = 66;
            // 
            // colTBL
            // 
            this.colTBL.ColumnEdit = this.TBLrepositoryItemImageComboBox;
            this.colTBL.FieldName = "TBL";
            this.colTBL.Name = "colTBL";
            this.colTBL.OptionsColumn.FixedWidth = true;
            this.colTBL.Visible = true;
            this.colTBL.VisibleIndex = 1;
            this.colTBL.Width = 68;
            // 
            // TBLrepositoryItemImageComboBox
            // 
            this.TBLrepositoryItemImageComboBox.AutoHeight = false;
            this.TBLrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TBLrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Olay", "O", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Muhatap", "M", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Faaliyet", "F", -1)});
            this.TBLrepositoryItemImageComboBox.Name = "TBLrepositoryItemImageComboBox";
            // 
            // colSUBJECT
            // 
            this.colSUBJECT.FieldName = "SUBJECT";
            this.colSUBJECT.Name = "colSUBJECT";
            this.colSUBJECT.Visible = true;
            this.colSUBJECT.VisibleIndex = 2;
            this.colSUBJECT.Width = 113;
            // 
            // colBODY
            // 
            this.colBODY.ColumnEdit = this.BODYrepositoryItemMemoExEdit;
            this.colBODY.FieldName = "BODY";
            this.colBODY.Name = "colBODY";
            this.colBODY.Visible = true;
            this.colBODY.VisibleIndex = 3;
            this.colBODY.Width = 113;
            // 
            // BODYrepositoryItemMemoExEdit
            // 
            this.BODYrepositoryItemMemoExEdit.AutoHeight = false;
            this.BODYrepositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BODYrepositoryItemMemoExEdit.Name = "BODYrepositoryItemMemoExEdit";
            // 
            // colUSRFNS
            // 
            this.colUSRFNS.ColumnEdit = this.USRFNSrepositoryItemCheckedComboBoxEdit;
            this.colUSRFNS.FieldName = "USRFNS";
            this.colUSRFNS.Name = "colUSRFNS";
            this.colUSRFNS.Visible = true;
            this.colUSRFNS.VisibleIndex = 4;
            this.colUSRFNS.Width = 115;
            // 
            // USRFNSrepositoryItemCheckedComboBoxEdit
            // 
            this.USRFNSrepositoryItemCheckedComboBoxEdit.AutoHeight = false;
            this.USRFNSrepositoryItemCheckedComboBoxEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.USRFNSrepositoryItemCheckedComboBoxEdit.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("<oFrUsr>", "O.FrUsr"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("<oToUsr>", "O.ToUsr"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("<oIlgUsrS>", "O.IlgUsrS"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("<oFrFrcID>", "O.FrmPrs"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("<fYtkUsr>", "F.YtkUsr"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("<fAmrUsr>", "F.AmrUsr"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("<fMhtUsr>", "F.MhtUsr"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("<fTnmUsr>", "F.TnmUsr"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("<fDgrUsr>", "F.DgrUsr"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("<mMhtUsr>", "M.MhtUsr"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("<mTytUsr>", "M.TytUsr")});
            this.USRFNSrepositoryItemCheckedComboBoxEdit.Name = "USRFNSrepositoryItemCheckedComboBoxEdit";
            // 
            // USRFNSrepositoryItemImageComboBox
            // 
            this.USRFNSrepositoryItemImageComboBox.AutoHeight = false;
            this.USRFNSrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.USRFNSrepositoryItemImageComboBox.Name = "USRFNSrepositoryItemImageComboBox";
            // 
            // kkesXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 312);
            this.Controls.Add(this.kkesGridControl);
            this.Controls.Add(this.kkesBindingNavigator);
            this.Name = "kkesXF";
            this.Text = "kkesXF";
            this.Load += new System.EventHandler(this.kkesXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkesBindingNavigator)).EndInit();
            this.kkesBindingNavigator.ResumeLayout(false);
            this.kkesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kkesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BODYrepositoryItemMemoExEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USRFNSrepositoryItemCheckedComboBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USRFNSrepositoryItemImageComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource kkesBindingSource;
        private MainDataSetTableAdapters.KKESTableAdapter kkesTableAdapter;
        private System.Windows.Forms.BindingNavigator kkesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kKESBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl kkesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView kkesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colKKESID;
        private DevExpress.XtraGrid.Columns.GridColumn colTBL;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TBLrepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT;
        private DevExpress.XtraGrid.Columns.GridColumn colBODY;
        private DevExpress.XtraGrid.Columns.GridColumn colUSRFNS;
        private MainDataSetTableAdapters.MainQueriesTableAdapter mainQueriesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit USRFNSrepositoryItemCheckedComboBoxEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox USRFNSrepositoryItemImageComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit BODYrepositoryItemMemoExEdit;
    }
}
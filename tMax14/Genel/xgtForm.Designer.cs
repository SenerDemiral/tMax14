namespace tMax14.Genel
{
    partial class xgtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xgtForm));
            this.genelDataSet = new tMax14.Genel.GenelDataSet();
            this.xgtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xgtTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.XGTTableAdapter();
            this.xgtBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.xGTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.xgtGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kayitEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xgtGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGRP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colVAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSYS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xgtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xgtBindingNavigator)).BeginInit();
            this.xgtBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xgtGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xgtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // genelDataSet
            // 
            this.genelDataSet.DataSetName = "GenelDataSet";
            this.genelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xgtBindingSource
            // 
            this.xgtBindingSource.DataMember = "XGT";
            this.xgtBindingSource.DataSource = this.genelDataSet;
            // 
            // xgtTableAdapter
            // 
            this.xgtTableAdapter.ClearBeforeFill = true;
            // 
            // xgtBindingNavigator
            // 
            this.xgtBindingNavigator.AddNewItem = null;
            this.xgtBindingNavigator.BindingSource = this.xgtBindingSource;
            this.xgtBindingNavigator.CountItem = null;
            this.xgtBindingNavigator.DeleteItem = null;
            this.xgtBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xGTBindingNavigatorSaveItem});
            this.xgtBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.xgtBindingNavigator.MoveFirstItem = null;
            this.xgtBindingNavigator.MoveLastItem = null;
            this.xgtBindingNavigator.MoveNextItem = null;
            this.xgtBindingNavigator.MovePreviousItem = null;
            this.xgtBindingNavigator.Name = "xgtBindingNavigator";
            this.xgtBindingNavigator.PositionItem = null;
            this.xgtBindingNavigator.Size = new System.Drawing.Size(421, 25);
            this.xgtBindingNavigator.TabIndex = 0;
            this.xgtBindingNavigator.Text = "bindingNavigator1";
            // 
            // xGTBindingNavigatorSaveItem
            // 
            this.xGTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.xGTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("xGTBindingNavigatorSaveItem.Image")));
            this.xGTBindingNavigatorSaveItem.Name = "xGTBindingNavigatorSaveItem";
            this.xGTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.xGTBindingNavigatorSaveItem.Text = "Save Data";
            this.xGTBindingNavigatorSaveItem.Click += new System.EventHandler(this.xGTBindingNavigatorSaveItem_Click);
            // 
            // xgtGridControl
            // 
            this.xgtGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.xgtGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.xgtGridControl.DataSource = this.xgtBindingSource;
            this.xgtGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xgtGridControl.Location = new System.Drawing.Point(0, 25);
            this.xgtGridControl.MainView = this.xgtGridView;
            this.xgtGridControl.Name = "xgtGridControl";
            this.xgtGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtRepositoryItemTextEdit,
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoExEdit1});
            this.xgtGridControl.Size = new System.Drawing.Size(421, 261);
            this.xgtGridControl.TabIndex = 1;
            this.xgtGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xgtGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayitEkleToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(168, 26);
            // 
            // kayitEkleToolStripMenuItem
            // 
            this.kayitEkleToolStripMenuItem.Name = "kayitEkleToolStripMenuItem";
            this.kayitEkleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.kayitEkleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kayitEkleToolStripMenuItem.Text = "Kayit ekle";
            this.kayitEkleToolStripMenuItem.Click += new System.EventHandler(this.kayitEkleToolStripMenuItem_Click);
            // 
            // xgtGridView
            // 
            this.xgtGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGRP,
            this.colID,
            this.colVAL,
            this.colSYS,
            this.colIDL,
            this.colTXT});
            this.xgtGridView.GridControl = this.xgtGridControl;
            this.xgtGridView.GroupCount = 1;
            this.xgtGridView.Name = "xgtGridView";
            this.xgtGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.xgtGridView.OptionsCustomization.AllowFilter = false;
            this.xgtGridView.OptionsCustomization.AllowGroup = false;
            this.xgtGridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.xgtGridView.OptionsFilter.AllowFilterEditor = false;
            this.xgtGridView.OptionsMenu.EnableColumnMenu = false;
            this.xgtGridView.OptionsMenu.EnableGroupPanelMenu = false;
            this.xgtGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.xgtGridView.OptionsView.ShowGroupPanel = false;
            this.xgtGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGRP, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.xgtGridView.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.xgtGridView_CustomDrawGroupRow);
            this.xgtGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.xgtGridView_ShowingEditor);
            // 
            // colGRP
            // 
            this.colGRP.FieldName = "GRP";
            this.colGRP.Name = "colGRP";
            this.colGRP.OptionsColumn.AllowEdit = false;
            this.colGRP.OptionsColumn.AllowFocus = false;
            this.colGRP.Visible = true;
            this.colGRP.VisibleIndex = 0;
            // 
            // colID
            // 
            this.colID.ColumnEdit = this.txtRepositoryItemTextEdit;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 95;
            // 
            // txtRepositoryItemTextEdit
            // 
            this.txtRepositoryItemTextEdit.AutoHeight = false;
            this.txtRepositoryItemTextEdit.Name = "txtRepositoryItemTextEdit";
            // 
            // colVAL
            // 
            this.colVAL.Caption = "Value";
            this.colVAL.ColumnEdit = this.txtRepositoryItemTextEdit;
            this.colVAL.FieldName = "VAL";
            this.colVAL.Name = "colVAL";
            this.colVAL.Visible = true;
            this.colVAL.VisibleIndex = 1;
            this.colVAL.Width = 208;
            // 
            // colSYS
            // 
            this.colSYS.FieldName = "SYS";
            this.colSYS.Name = "colSYS";
            this.colSYS.OptionsColumn.AllowEdit = false;
            this.colSYS.OptionsColumn.AllowFocus = false;
            this.colSYS.OptionsColumn.FixedWidth = true;
            this.colSYS.Visible = true;
            this.colSYS.VisibleIndex = 2;
            this.colSYS.Width = 50;
            // 
            // colIDL
            // 
            this.colIDL.FieldName = "IDL";
            this.colIDL.Name = "colIDL";
            this.colIDL.OptionsColumn.AllowEdit = false;
            this.colIDL.OptionsColumn.AllowFocus = false;
            this.colIDL.OptionsColumn.FixedWidth = true;
            this.colIDL.Visible = true;
            this.colIDL.VisibleIndex = 3;
            this.colIDL.Width = 50;
            // 
            // colTXT
            // 
            this.colTXT.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colTXT.FieldName = "TXT";
            this.colTXT.Name = "colTXT";
            this.colTXT.Visible = true;
            this.colTXT.VisibleIndex = 4;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // xgtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 286);
            this.Controls.Add(this.xgtGridControl);
            this.Controls.Add(this.xgtBindingNavigator);
            this.Name = "xgtForm";
            this.Text = "xgtForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xgtForm_FormClosing);
            this.Load += new System.EventHandler(this.xgtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xgtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xgtBindingNavigator)).EndInit();
            this.xgtBindingNavigator.ResumeLayout(false);
            this.xgtBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xgtGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xgtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GenelDataSet genelDataSet;
        private System.Windows.Forms.BindingSource xgtBindingSource;
        private GenelDataSetTableAdapters.XGTTableAdapter xgtTableAdapter;
        private System.Windows.Forms.BindingNavigator xgtBindingNavigator;
        private System.Windows.Forms.ToolStripButton xGTBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl xgtGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView xgtGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colGRP;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colVAL;
        private DevExpress.XtraGrid.Columns.GridColumn colSYS;
        private DevExpress.XtraGrid.Columns.GridColumn colIDL;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtRepositoryItemTextEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem kayitEkleToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTXT;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}
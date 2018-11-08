namespace tMax14.Genel
{
    partial class xglFX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xglFX));
            this.xglGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xglSelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genelDataSet = new tMax14.Genel.GenelDataSet();
            this.xglGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAYOUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xglSelTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.XGL_SELTableAdapter();
            this.xglSelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.xGL_SELBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.xglGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xglSelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xglGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xglSelBindingNavigator)).BeginInit();
            this.xglSelBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // xglGridControl
            // 
            this.xglGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.xglGridControl.DataSource = this.xglSelBindingSource;
            this.xglGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xglGridControl.Location = new System.Drawing.Point(0, 0);
            this.xglGridControl.MainView = this.xglGridView;
            this.xglGridControl.Name = "xglGridControl";
            this.xglGridControl.Size = new System.Drawing.Size(349, 234);
            this.xglGridControl.TabIndex = 4;
            this.xglGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xglGridView});
            this.xglGridControl.DoubleClick += new System.EventHandler(this.getToolStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getToolStripMenuItem,
            this.setToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(92, 48);
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.getToolStripMenuItem.Text = "Get";
            this.getToolStripMenuItem.Click += new System.EventHandler(this.getToolStripMenuItem_Click);
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.setToolStripMenuItem.Text = "Set";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // xglSelBindingSource
            // 
            this.xglSelBindingSource.DataMember = "XGL_SEL";
            this.xglSelBindingSource.DataSource = this.genelDataSet;
            // 
            // genelDataSet
            // 
            this.genelDataSet.DataSetName = "GenelDataSet";
            this.genelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xglGridView
            // 
            this.xglGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSR,
            this.colID,
            this.colIDX,
            this.colAD,
            this.colLAYOUT});
            this.xglGridView.GridControl = this.xglGridControl;
            this.xglGridView.Name = "xglGridView";
            this.xglGridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.xglGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.xglGridView_InitNewRow);
            // 
            // colUSR
            // 
            this.colUSR.FieldName = "USR";
            this.colUSR.Name = "colUSR";
            this.colUSR.OptionsColumn.AllowEdit = false;
            this.colUSR.OptionsColumn.AllowFocus = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            // 
            // colIDX
            // 
            this.colIDX.FieldName = "IDX";
            this.colIDX.Name = "colIDX";
            this.colIDX.OptionsColumn.AllowEdit = false;
            this.colIDX.OptionsColumn.AllowFocus = false;
            this.colIDX.OptionsColumn.FixedWidth = true;
            this.colIDX.Visible = true;
            this.colIDX.VisibleIndex = 0;
            this.colIDX.Width = 52;
            // 
            // colAD
            // 
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 1;
            this.colAD.Width = 360;
            // 
            // colLAYOUT
            // 
            this.colLAYOUT.FieldName = "LAYOUT";
            this.colLAYOUT.Name = "colLAYOUT";
            this.colLAYOUT.OptionsColumn.AllowEdit = false;
            this.colLAYOUT.OptionsColumn.AllowFocus = false;
            // 
            // xglSelTableAdapter
            // 
            this.xglSelTableAdapter.ClearBeforeFill = true;
            // 
            // xglSelBindingNavigator
            // 
            this.xglSelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.xglSelBindingNavigator.BindingSource = this.xglSelBindingSource;
            this.xglSelBindingNavigator.CountItem = null;
            this.xglSelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.xglSelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.xGL_SELBindingNavigatorSaveItem});
            this.xglSelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.xglSelBindingNavigator.MoveFirstItem = null;
            this.xglSelBindingNavigator.MoveLastItem = null;
            this.xglSelBindingNavigator.MoveNextItem = null;
            this.xglSelBindingNavigator.MovePreviousItem = null;
            this.xglSelBindingNavigator.Name = "xglSelBindingNavigator";
            this.xglSelBindingNavigator.PositionItem = null;
            this.xglSelBindingNavigator.Size = new System.Drawing.Size(349, 25);
            this.xglSelBindingNavigator.TabIndex = 1;
            this.xglSelBindingNavigator.Text = "bindingNavigator1";
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
            // xGL_SELBindingNavigatorSaveItem
            // 
            this.xGL_SELBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.xGL_SELBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("xGL_SELBindingNavigatorSaveItem.Image")));
            this.xGL_SELBindingNavigatorSaveItem.Name = "xGL_SELBindingNavigatorSaveItem";
            this.xGL_SELBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.xGL_SELBindingNavigatorSaveItem.Text = "Save Data";
            this.xGL_SELBindingNavigatorSaveItem.Click += new System.EventHandler(this.xGL_SELBindingNavigatorSaveItem_Click);
            // 
            // xglFX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 234);
            this.Controls.Add(this.xglSelBindingNavigator);
            this.Controls.Add(this.xglGridControl);
            this.Name = "xglFX";
            this.Text = "Layouts";
            this.Load += new System.EventHandler(this.xglFX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xglGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xglSelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xglGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xglSelBindingNavigator)).EndInit();
            this.xglSelBindingNavigator.ResumeLayout(false);
            this.xglSelBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GenelDataSet genelDataSet;
        private System.Windows.Forms.BindingSource xglSelBindingSource;
        private GenelDataSetTableAdapters.XGL_SELTableAdapter xglSelTableAdapter;
        private System.Windows.Forms.BindingNavigator xglSelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton xGL_SELBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl xglGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView xglGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDX;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colLAYOUT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
    }
}
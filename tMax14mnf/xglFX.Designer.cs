namespace tMax14mnf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xglFX));
            this.dataSet = new tMax14mnf.DataSet();
            this.xglBindingSource = new System.Windows.Forms.BindingSource();
            this.xglTableAdapter = new tMax14mnf.DataSetTableAdapters.XGL_SELTableAdapter();
            this.xglBindingNavigator = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.xGL_SELBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.xglGridControl = new DevExpress.XtraGrid.GridControl();
            this.xglGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAYOUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xglBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xglBindingNavigator)).BeginInit();
            this.xglBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xglGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xglGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xglBindingSource
            // 
            this.xglBindingSource.DataMember = "XGL_SEL";
            this.xglBindingSource.DataSource = this.dataSet;
            // 
            // xglTableAdapter
            // 
            this.xglTableAdapter.ClearBeforeFill = true;
            // 
            // xglBindingNavigator
            // 
            this.xglBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.xglBindingNavigator.BindingSource = this.xglBindingSource;
            this.xglBindingNavigator.CountItem = null;
            this.xglBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.xglBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.xGL_SELBindingNavigatorSaveItem});
            this.xglBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.xglBindingNavigator.MoveFirstItem = null;
            this.xglBindingNavigator.MoveLastItem = null;
            this.xglBindingNavigator.MoveNextItem = null;
            this.xglBindingNavigator.MovePreviousItem = null;
            this.xglBindingNavigator.Name = "xglBindingNavigator";
            this.xglBindingNavigator.PositionItem = null;
            this.xglBindingNavigator.Size = new System.Drawing.Size(349, 25);
            this.xglBindingNavigator.TabIndex = 0;
            this.xglBindingNavigator.Text = "bindingNavigator1";
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
            // xglGridControl
            // 
            this.xglGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.xglGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.xglGridControl.DataSource = this.xglBindingSource;
            this.xglGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xglGridControl.Location = new System.Drawing.Point(0, 25);
            this.xglGridControl.MainView = this.xglGridView;
            this.xglGridControl.Name = "xglGridControl";
            this.xglGridControl.Size = new System.Drawing.Size(349, 278);
            this.xglGridControl.TabIndex = 2;
            this.xglGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xglGridView});
            // 
            // xglGridView
            // 
            this.xglGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDX,
            this.colAD,
            this.colUSR,
            this.colID,
            this.colLAYOUT});
            this.xglGridView.GridControl = this.xglGridControl;
            this.xglGridView.Name = "xglGridView";
            this.xglGridView.OptionsView.ShowGroupPanel = false;
            this.xglGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.xglGridView_InitNewRow);
            // 
            // colIDX
            // 
            this.colIDX.FieldName = "IDX";
            this.colIDX.Name = "colIDX";
            this.colIDX.Visible = true;
            this.colIDX.VisibleIndex = 0;
            this.colIDX.Width = 51;
            // 
            // colAD
            // 
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 1;
            this.colAD.Width = 280;
            // 
            // colUSR
            // 
            this.colUSR.FieldName = "USR";
            this.colUSR.Name = "colUSR";
            this.colUSR.OptionsColumn.AllowEdit = false;
            this.colUSR.OptionsColumn.AllowFocus = false;
            this.colUSR.OptionsColumn.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colLAYOUT
            // 
            this.colLAYOUT.FieldName = "LAYOUT";
            this.colLAYOUT.Name = "colLAYOUT";
            this.colLAYOUT.OptionsColumn.AllowEdit = false;
            this.colLAYOUT.OptionsColumn.AllowFocus = false;
            this.colLAYOUT.OptionsColumn.ReadOnly = true;
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
            // xglFX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 303);
            this.Controls.Add(this.xglGridControl);
            this.Controls.Add(this.xglBindingNavigator);
            this.Name = "xglFX";
            this.Text = "xglFX";
            this.Load += new System.EventHandler(this.xglFX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xglBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xglBindingNavigator)).EndInit();
            this.xglBindingNavigator.ResumeLayout(false);
            this.xglBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xglGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xglGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource xglBindingSource;
        private DataSetTableAdapters.XGL_SELTableAdapter xglTableAdapter;
        private System.Windows.Forms.BindingNavigator xglBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton xGL_SELBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl xglGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView xglGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colIDX;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colLAYOUT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
    }
}
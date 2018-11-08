namespace tMax14.Misc
{
    partial class KampanyaXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KampanyaXF));
            this.miscDataSet = new tMax14.Misc.MiscDataSet();
            this.mKTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mKTTableAdapter = new tMax14.Misc.MiscDataSetTableAdapters.MKTTableAdapter();
            this.mKTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mKTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mktGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mktGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMKTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKONU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBODY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTIDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.miscQueriesTableAdapter = new tMax14.Misc.MiscDataSetTableAdapters.MiscQueriesTableAdapter();
            this.frtEmailsTableAdapter = new tMax14.Misc.MiscDataSetTableAdapters.FRT_EMAILSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.miscDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKTBindingNavigator)).BeginInit();
            this.mKTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mktGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mktGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // miscDataSet
            // 
            this.miscDataSet.DataSetName = "MiscDataSet";
            this.miscDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mKTBindingSource
            // 
            this.mKTBindingSource.DataMember = "MKT";
            this.mKTBindingSource.DataSource = this.miscDataSet;
            // 
            // mKTTableAdapter
            // 
            this.mKTTableAdapter.ClearBeforeFill = true;
            // 
            // mKTBindingNavigator
            // 
            this.mKTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mKTBindingNavigator.BindingSource = this.mKTBindingSource;
            this.mKTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mKTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mKTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mKTBindingNavigatorSaveItem});
            this.mKTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mKTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mKTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mKTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mKTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mKTBindingNavigator.Name = "mKTBindingNavigator";
            this.mKTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mKTBindingNavigator.Size = new System.Drawing.Size(878, 25);
            this.mKTBindingNavigator.TabIndex = 0;
            this.mKTBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
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
            // mKTBindingNavigatorSaveItem
            // 
            this.mKTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mKTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mKTBindingNavigatorSaveItem.Image")));
            this.mKTBindingNavigatorSaveItem.Name = "mKTBindingNavigatorSaveItem";
            this.mKTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mKTBindingNavigatorSaveItem.Text = "Save Data";
            this.mKTBindingNavigatorSaveItem.Click += new System.EventHandler(this.mKTBindingNavigatorSaveItem_Click);
            // 
            // mktGridControl
            // 
            this.mktGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.mktGridControl.DataSource = this.mKTBindingSource;
            this.mktGridControl.Location = new System.Drawing.Point(24, 46);
            this.mktGridControl.MainView = this.mktGridView;
            this.mktGridControl.Name = "mktGridControl";
            this.mktGridControl.Size = new System.Drawing.Size(830, 414);
            this.mktGridControl.TabIndex = 0;
            this.mktGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mktGridView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // eMailToolStripMenuItem
            // 
            this.eMailToolStripMenuItem.Name = "eMailToolStripMenuItem";
            this.eMailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eMailToolStripMenuItem.Text = "eMail";
            this.eMailToolStripMenuItem.Click += new System.EventHandler(this.eMailToolStripMenuItem_Click);
            // 
            // mktGridView
            // 
            this.mktGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMKTID,
            this.colKONU,
            this.colBODY,
            this.colFRTIDS,
            this.colEXD});
            this.mktGridView.GridControl = this.mktGridControl;
            this.mktGridView.Name = "mktGridView";
            this.mktGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.mktGridView_InitNewRow);
            // 
            // colMKTID
            // 
            this.colMKTID.FieldName = "MKTID";
            this.colMKTID.Name = "colMKTID";
            this.colMKTID.OptionsColumn.AllowEdit = false;
            this.colMKTID.OptionsColumn.AllowFocus = false;
            this.colMKTID.OptionsColumn.FixedWidth = true;
            this.colMKTID.Visible = true;
            this.colMKTID.VisibleIndex = 0;
            // 
            // colKONU
            // 
            this.colKONU.Caption = "Konu";
            this.colKONU.FieldName = "KONU";
            this.colKONU.Name = "colKONU";
            this.colKONU.Visible = true;
            this.colKONU.VisibleIndex = 1;
            // 
            // colBODY
            // 
            this.colBODY.FieldName = "BODY";
            this.colBODY.Name = "colBODY";
            this.colBODY.OptionsColumn.AllowEdit = false;
            this.colBODY.OptionsColumn.AllowFocus = false;
            // 
            // colFRTIDS
            // 
            this.colFRTIDS.Caption = "Firmalar";
            this.colFRTIDS.FieldName = "FRTIDS";
            this.colFRTIDS.Name = "colFRTIDS";
            this.colFRTIDS.Visible = true;
            this.colFRTIDS.VisibleIndex = 2;
            // 
            // colEXD
            // 
            this.colEXD.FieldName = "EXD";
            this.colEXD.Name = "colEXD";
            this.colEXD.OptionsColumn.AllowEdit = false;
            this.colEXD.OptionsColumn.AllowFocus = false;
            this.colEXD.OptionsColumn.FixedWidth = true;
            this.colEXD.Visible = true;
            this.colEXD.VisibleIndex = 3;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.richEditControl1);
            this.layoutControl1.Controls.Add(this.mktGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 25);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(878, 484);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // richEditControl1
            // 
            this.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mKTBindingSource, "BODY", true));
            this.richEditControl1.Location = new System.Drawing.Point(24, 46);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(830, 414);
            this.richEditControl1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(878, 484);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1";
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup3;
            this.tabbedControlGroup1.SelectedTabPageIndex = 1;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(858, 464);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Kampanyalar";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(834, 418);
            this.layoutControlGroup2.Text = "Kampanyalar";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mktGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(834, 418);
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "eMail Body";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(834, 418);
            this.layoutControlGroup3.Text = "eMail Body";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.richEditControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(834, 418);
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frtEmailsTableAdapter
            // 
            this.frtEmailsTableAdapter.ClearBeforeFill = true;
            // 
            // KampanyaXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 509);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mKTBindingNavigator);
            this.Name = "KampanyaXF";
            this.Text = "KampanyaXF";
            this.Load += new System.EventHandler(this.KampanyaXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miscDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKTBindingNavigator)).EndInit();
            this.mKTBindingNavigator.ResumeLayout(false);
            this.mKTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mktGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mktGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MiscDataSet miscDataSet;
        private System.Windows.Forms.BindingSource mKTBindingSource;
        private MiscDataSetTableAdapters.MKTTableAdapter mKTTableAdapter;
        private System.Windows.Forms.BindingNavigator mKTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mKTBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl mktGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView mktGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMKTID;
        private DevExpress.XtraGrid.Columns.GridColumn colKONU;
        private DevExpress.XtraGrid.Columns.GridColumn colBODY;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTIDS;
        private DevExpress.XtraGrid.Columns.GridColumn colEXD;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private MiscDataSetTableAdapters.MiscQueriesTableAdapter miscQueriesTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eMailToolStripMenuItem;
        private MiscDataSetTableAdapters.FRT_EMAILSTableAdapter frtEmailsTableAdapter;
    }
}
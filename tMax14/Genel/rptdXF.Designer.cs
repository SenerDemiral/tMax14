namespace tMax14.Genel
{
    partial class rptdXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptdXF));
            this.genelDataSet = new tMax14.Genel.GenelDataSet();
            this.rptdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpdtTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.RPTDTableAdapter();
            this.rptdBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rPTDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rptdGridControl = new DevExpress.XtraGrid.GridControl();
            this.rptdGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRPTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKEY2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVAL2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptdBindingNavigator)).BeginInit();
            this.rptdBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rptdGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptdGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // genelDataSet
            // 
            this.genelDataSet.DataSetName = "GenelDataSet";
            this.genelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptdBindingSource
            // 
            this.rptdBindingSource.DataMember = "RPTD";
            this.rptdBindingSource.DataSource = this.genelDataSet;
            // 
            // rpdtTableAdapter
            // 
            this.rpdtTableAdapter.ClearBeforeFill = true;
            // 
            // rptdBindingNavigator
            // 
            this.rptdBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rptdBindingNavigator.BindingSource = this.rptdBindingSource;
            this.rptdBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rptdBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rptdBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rPTDBindingNavigatorSaveItem});
            this.rptdBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rptdBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rptdBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rptdBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rptdBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rptdBindingNavigator.Name = "rptdBindingNavigator";
            this.rptdBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rptdBindingNavigator.Size = new System.Drawing.Size(772, 25);
            this.rptdBindingNavigator.TabIndex = 0;
            this.rptdBindingNavigator.Text = "bindingNavigator1";
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
            // rPTDBindingNavigatorSaveItem
            // 
            this.rPTDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rPTDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rPTDBindingNavigatorSaveItem.Image")));
            this.rPTDBindingNavigatorSaveItem.Name = "rPTDBindingNavigatorSaveItem";
            this.rPTDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rPTDBindingNavigatorSaveItem.Text = "Save Data";
            this.rPTDBindingNavigatorSaveItem.Click += new System.EventHandler(this.rPTDBindingNavigatorSaveItem_Click);
            // 
            // rptdGridControl
            // 
            this.rptdGridControl.DataSource = this.rptdBindingSource;
            this.rptdGridControl.Location = new System.Drawing.Point(12, 12);
            this.rptdGridControl.MainView = this.rptdGridView;
            this.rptdGridControl.Name = "rptdGridControl";
            this.rptdGridControl.Size = new System.Drawing.Size(247, 254);
            this.rptdGridControl.TabIndex = 0;
            this.rptdGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rptdGridView});
            // 
            // rptdGridView
            // 
            this.rptdGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRPTID,
            this.colDKEY,
            this.colDVAL,
            this.colDKEY2,
            this.colDVAL2});
            this.rptdGridView.GridControl = this.rptdGridControl;
            this.rptdGridView.Name = "rptdGridView";
            this.rptdGridView.OptionsView.ShowGroupPanel = false;
            this.rptdGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.rptdGridView_InitNewRow);
            // 
            // colRPTID
            // 
            this.colRPTID.FieldName = "RPTID";
            this.colRPTID.Name = "colRPTID";
            this.colRPTID.OptionsColumn.AllowEdit = false;
            this.colRPTID.OptionsColumn.AllowFocus = false;
            this.colRPTID.OptionsColumn.FixedWidth = true;
            // 
            // colDKEY
            // 
            this.colDKEY.Caption = "Key";
            this.colDKEY.FieldName = "DKEY";
            this.colDKEY.Name = "colDKEY";
            this.colDKEY.OptionsColumn.FixedWidth = true;
            this.colDKEY.Visible = true;
            this.colDKEY.VisibleIndex = 0;
            // 
            // colDVAL
            // 
            this.colDVAL.Caption = "Val";
            this.colDVAL.FieldName = "DVAL";
            this.colDVAL.Name = "colDVAL";
            this.colDVAL.OptionsColumn.FixedWidth = true;
            this.colDVAL.Visible = true;
            this.colDVAL.VisibleIndex = 1;
            // 
            // colDKEY2
            // 
            this.colDKEY2.Caption = "Key2";
            this.colDKEY2.FieldName = "DKEY2";
            this.colDKEY2.Name = "colDKEY2";
            this.colDKEY2.OptionsColumn.FixedWidth = true;
            this.colDKEY2.Visible = true;
            this.colDKEY2.VisibleIndex = 2;
            // 
            // colDVAL2
            // 
            this.colDVAL2.Caption = "Val2";
            this.colDVAL2.FieldName = "DVAL2";
            this.colDVAL2.Name = "colDVAL2";
            this.colDVAL2.OptionsColumn.FixedWidth = true;
            this.colDVAL2.Visible = true;
            this.colDVAL2.VisibleIndex = 3;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.richEditControl1);
            this.layoutControl1.Controls.Add(this.rptdGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 25);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(995, 153, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(772, 278);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // richEditControl1
            // 
            this.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl1.DataBindings.Add(new System.Windows.Forms.Binding("RtfText", this.rptdBindingSource, "DTYNOT", true));
            this.richEditControl1.EnableToolTips = true;
            this.richEditControl1.Location = new System.Drawing.Point(268, 12);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Options.Bookmarks.AllowNameResolution = false;
            this.richEditControl1.Size = new System.Drawing.Size(492, 254);
            this.richEditControl1.TabIndex = 4;
            this.richEditControl1.DocumentLoaded += new System.EventHandler(this.richEditControl1_DocumentLoaded);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(772, 278);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rptdGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(251, 258);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.richEditControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(256, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(496, 258);
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(251, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 258);
            // 
            // rptdXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 303);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.rptdBindingNavigator);
            this.Name = "rptdXF";
            this.Text = "rptdXF";
            this.Load += new System.EventHandler(this.rptdXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptdBindingNavigator)).EndInit();
            this.rptdBindingNavigator.ResumeLayout(false);
            this.rptdBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rptdGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptdGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GenelDataSet genelDataSet;
        private System.Windows.Forms.BindingSource rptdBindingSource;
        private GenelDataSetTableAdapters.RPTDTableAdapter rpdtTableAdapter;
        private System.Windows.Forms.BindingNavigator rptdBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rPTDBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl rptdGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView rptdGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colRPTID;
        private DevExpress.XtraGrid.Columns.GridColumn colDKEY;
        private DevExpress.XtraGrid.Columns.GridColumn colDVAL;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colDKEY2;
        private DevExpress.XtraGrid.Columns.GridColumn colDVAL2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}
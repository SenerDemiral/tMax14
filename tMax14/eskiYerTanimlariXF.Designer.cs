namespace tMax14
{
    partial class eskiYerTanimlariXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eskiYerTanimlariXF));
            this.mainDataSet = new tMax14.MainDataSet();
            this.ytBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ytTableAdapter = new tMax14.MainDataSetTableAdapters.YTTableAdapter();
            this.ytBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.yTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ytGridControl = new DevExpress.XtraGrid.GridControl();
            this.ytGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYTRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOCAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNEWLOCID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytBindingNavigator)).BeginInit();
            this.ytBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ytGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ytBindingSource
            // 
            this.ytBindingSource.DataMember = "YT";
            this.ytBindingSource.DataSource = this.mainDataSet;
            // 
            // ytTableAdapter
            // 
            this.ytTableAdapter.ClearBeforeFill = true;
            // 
            // ytBindingNavigator
            // 
            this.ytBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ytBindingNavigator.BindingSource = this.ytBindingSource;
            this.ytBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ytBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ytBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.yTBindingNavigatorSaveItem});
            this.ytBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ytBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ytBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ytBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ytBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ytBindingNavigator.Name = "ytBindingNavigator";
            this.ytBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ytBindingNavigator.Size = new System.Drawing.Size(770, 25);
            this.ytBindingNavigator.TabIndex = 0;
            this.ytBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
            // yTBindingNavigatorSaveItem
            // 
            this.yTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("yTBindingNavigatorSaveItem.Image")));
            this.yTBindingNavigatorSaveItem.Name = "yTBindingNavigatorSaveItem";
            this.yTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.yTBindingNavigatorSaveItem.Text = "Save Data";
            this.yTBindingNavigatorSaveItem.Click += new System.EventHandler(this.yTBindingNavigatorSaveItem_Click);
            // 
            // ytGridControl
            // 
            this.ytGridControl.DataSource = this.ytBindingSource;
            this.ytGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ytGridControl.Location = new System.Drawing.Point(0, 25);
            this.ytGridControl.MainView = this.ytGridView;
            this.ytGridControl.Name = "ytGridControl";
            this.ytGridControl.Size = new System.Drawing.Size(770, 349);
            this.ytGridControl.TabIndex = 1;
            this.ytGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ytGridView});
            // 
            // ytGridView
            // 
            this.ytGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYTRF,
            this.colYTID,
            this.colKD,
            this.colAD,
            this.colLOCID,
            this.colLOCAD,
            this.colIATA,
            this.colNEWLOCID});
            this.ytGridView.GridControl = this.ytGridControl;
            this.ytGridView.Name = "ytGridView";
            // 
            // colYTRF
            // 
            this.colYTRF.FieldName = "YTRF";
            this.colYTRF.Name = "colYTRF";
            this.colYTRF.OptionsColumn.AllowEdit = false;
            this.colYTRF.OptionsColumn.AllowFocus = false;
            this.colYTRF.Visible = true;
            this.colYTRF.VisibleIndex = 0;
            this.colYTRF.Width = 94;
            // 
            // colYTID
            // 
            this.colYTID.FieldName = "YTID";
            this.colYTID.Name = "colYTID";
            this.colYTID.OptionsColumn.AllowEdit = false;
            this.colYTID.OptionsColumn.AllowFocus = false;
            this.colYTID.Visible = true;
            this.colYTID.VisibleIndex = 1;
            this.colYTID.Width = 48;
            // 
            // colKD
            // 
            this.colKD.FieldName = "KD";
            this.colKD.Name = "colKD";
            this.colKD.OptionsColumn.AllowEdit = false;
            this.colKD.OptionsColumn.AllowFocus = false;
            this.colKD.Visible = true;
            this.colKD.VisibleIndex = 2;
            this.colKD.Width = 118;
            // 
            // colAD
            // 
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.OptionsColumn.AllowEdit = false;
            this.colAD.OptionsColumn.AllowFocus = false;
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 3;
            this.colAD.Width = 145;
            // 
            // colLOCID
            // 
            this.colLOCID.FieldName = "LOCID";
            this.colLOCID.Name = "colLOCID";
            this.colLOCID.OptionsColumn.AllowEdit = false;
            this.colLOCID.OptionsColumn.AllowFocus = false;
            this.colLOCID.Visible = true;
            this.colLOCID.VisibleIndex = 4;
            this.colLOCID.Width = 56;
            // 
            // colLOCAD
            // 
            this.colLOCAD.FieldName = "LOCAD";
            this.colLOCAD.Name = "colLOCAD";
            this.colLOCAD.OptionsColumn.AllowEdit = false;
            this.colLOCAD.OptionsColumn.AllowFocus = false;
            this.colLOCAD.Visible = true;
            this.colLOCAD.VisibleIndex = 5;
            this.colLOCAD.Width = 140;
            // 
            // colIATA
            // 
            this.colIATA.FieldName = "IATA";
            this.colIATA.Name = "colIATA";
            this.colIATA.OptionsColumn.AllowEdit = false;
            this.colIATA.OptionsColumn.AllowFocus = false;
            this.colIATA.Visible = true;
            this.colIATA.VisibleIndex = 6;
            this.colIATA.Width = 36;
            // 
            // colNEWLOCID
            // 
            this.colNEWLOCID.Caption = "NewLocID";
            this.colNEWLOCID.FieldName = "NEWLOCID";
            this.colNEWLOCID.Name = "colNEWLOCID";
            this.colNEWLOCID.Visible = true;
            this.colNEWLOCID.VisibleIndex = 7;
            this.colNEWLOCID.Width = 115;
            // 
            // eskiYerTanimlariXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 374);
            this.Controls.Add(this.ytGridControl);
            this.Controls.Add(this.ytBindingNavigator);
            this.Name = "eskiYerTanimlariXF";
            this.Text = "eskiYerTanimlariXF";
            this.Load += new System.EventHandler(this.eskiYerTanimlariXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytBindingNavigator)).EndInit();
            this.ytBindingNavigator.ResumeLayout(false);
            this.ytBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ytGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource ytBindingSource;
        private MainDataSetTableAdapters.YTTableAdapter ytTableAdapter;
        private System.Windows.Forms.BindingNavigator ytBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton yTBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl ytGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ytGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colYTRF;
        private DevExpress.XtraGrid.Columns.GridColumn colYTID;
        private DevExpress.XtraGrid.Columns.GridColumn colKD;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colLOCID;
        private DevExpress.XtraGrid.Columns.GridColumn colLOCAD;
        private DevExpress.XtraGrid.Columns.GridColumn colIATA;
        private DevExpress.XtraGrid.Columns.GridColumn colNEWLOCID;
    }
}
namespace tMax14.Firma
{
    partial class frcmXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frcmXF));
            this.firmaDataSet = new tMax14.Firma.FirmaDataSet();
            this.fRCMBindingSource = new System.Windows.Forms.BindingSource();
            this.fRCMTableAdapter = new tMax14.Firma.FirmaDataSetTableAdapters.FRCMTableAdapter();
            this.fRCMBindingNavigator = new System.Windows.Forms.BindingNavigator();
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
            this.fRCMBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.frcmGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPRTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRCMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRCMBindingNavigator)).BeginInit();
            this.fRCMBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frcmGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // firmaDataSet
            // 
            this.firmaDataSet.DataSetName = "FirmaDataSet";
            this.firmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fRCMBindingSource
            // 
            this.fRCMBindingSource.DataMember = "FRCM";
            this.fRCMBindingSource.DataSource = this.firmaDataSet;
            // 
            // fRCMTableAdapter
            // 
            this.fRCMTableAdapter.ClearBeforeFill = true;
            // 
            // fRCMBindingNavigator
            // 
            this.fRCMBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fRCMBindingNavigator.BindingSource = this.fRCMBindingSource;
            this.fRCMBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fRCMBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fRCMBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fRCMBindingNavigatorSaveItem});
            this.fRCMBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fRCMBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fRCMBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fRCMBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fRCMBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fRCMBindingNavigator.Name = "fRCMBindingNavigator";
            this.fRCMBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fRCMBindingNavigator.Size = new System.Drawing.Size(626, 25);
            this.fRCMBindingNavigator.TabIndex = 0;
            this.fRCMBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
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
            // fRCMBindingNavigatorSaveItem
            // 
            this.fRCMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fRCMBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fRCMBindingNavigatorSaveItem.Image")));
            this.fRCMBindingNavigatorSaveItem.Name = "fRCMBindingNavigatorSaveItem";
            this.fRCMBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fRCMBindingNavigatorSaveItem.Text = "Save Data";
            this.fRCMBindingNavigatorSaveItem.Click += new System.EventHandler(this.fRCMBindingNavigatorSaveItem_Click);
            // 
            // frcmGridControl
            // 
            this.frcmGridControl.DataSource = this.fRCMBindingSource;
            this.frcmGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frcmGridControl.Location = new System.Drawing.Point(0, 25);
            this.frcmGridControl.MainView = this.gridView1;
            this.frcmGridControl.Name = "frcmGridControl";
            this.frcmGridControl.Size = new System.Drawing.Size(626, 266);
            this.frcmGridControl.TabIndex = 1;
            this.frcmGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPRTNO,
            this.colSHPID,
            this.colCNEID,
            this.colEMAIL,
            this.colAD});
            this.gridView1.GridControl = this.frcmGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colPRTNO
            // 
            this.colPRTNO.Caption = "ProtokolNo";
            this.colPRTNO.FieldName = "PRTNO";
            this.colPRTNO.Name = "colPRTNO";
            this.colPRTNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPRTNO.Visible = true;
            this.colPRTNO.VisibleIndex = 0;
            this.colPRTNO.Width = 119;
            // 
            // colSHPID
            // 
            this.colSHPID.Caption = "Shipper";
            this.colSHPID.FieldName = "SHPID";
            this.colSHPID.Name = "colSHPID";
            this.colSHPID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSHPID.Visible = true;
            this.colSHPID.VisibleIndex = 1;
            this.colSHPID.Width = 121;
            // 
            // colCNEID
            // 
            this.colCNEID.Caption = "Consignee";
            this.colCNEID.FieldName = "CNEID";
            this.colCNEID.Name = "colCNEID";
            this.colCNEID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCNEID.Visible = true;
            this.colCNEID.VisibleIndex = 2;
            this.colCNEID.Width = 121;
            // 
            // colEMAIL
            // 
            this.colEMAIL.Caption = "eMail";
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 3;
            this.colEMAIL.Width = 121;
            // 
            // colAD
            // 
            this.colAD.Caption = "Contact";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 4;
            this.colAD.Width = 126;
            // 
            // frcmXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 291);
            this.Controls.Add(this.frcmGridControl);
            this.Controls.Add(this.fRCMBindingNavigator);
            this.Name = "frcmXF";
            this.Text = "Marken AWB Alert Contacts";
            this.Load += new System.EventHandler(this.frcmXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRCMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRCMBindingNavigator)).EndInit();
            this.fRCMBindingNavigator.ResumeLayout(false);
            this.fRCMBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frcmGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirmaDataSet firmaDataSet;
        private System.Windows.Forms.BindingSource fRCMBindingSource;
        private FirmaDataSetTableAdapters.FRCMTableAdapter fRCMTableAdapter;
        private System.Windows.Forms.BindingNavigator fRCMBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fRCMBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl frcmGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPRTNO;
        private DevExpress.XtraGrid.Columns.GridColumn colSHPID;
        private DevExpress.XtraGrid.Columns.GridColumn colCNEID;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
    }
}
namespace tMax14.AccountAk
{
    partial class AkdyXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AkdyXF));
            this.accountAkDataSet = new tMax14.AccountAk.AccountAkDataSet();
            this.aKDYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aKDYTableAdapter = new tMax14.AccountAk.AccountAkDataSetTableAdapters.AKDYTableAdapter();
            this.aKDYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aKDYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.akdyGridControl = new DevExpress.XtraGrid.GridControl();
            this.akdyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKAKMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.accountAkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKDYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKDYBindingNavigator)).BeginInit();
            this.aKDYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akdyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akdyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountAkDataSet
            // 
            this.accountAkDataSet.DataSetName = "AccountAkDataSet";
            this.accountAkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aKDYBindingSource
            // 
            this.aKDYBindingSource.DataMember = "AKDY";
            this.aKDYBindingSource.DataSource = this.accountAkDataSet;
            // 
            // aKDYTableAdapter
            // 
            this.aKDYTableAdapter.ClearBeforeFill = true;
            // 
            // aKDYBindingNavigator
            // 
            this.aKDYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aKDYBindingNavigator.BindingSource = this.aKDYBindingSource;
            this.aKDYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aKDYBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aKDYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aKDYBindingNavigatorSaveItem});
            this.aKDYBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aKDYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aKDYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aKDYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aKDYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aKDYBindingNavigator.Name = "aKDYBindingNavigator";
            this.aKDYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aKDYBindingNavigator.Size = new System.Drawing.Size(323, 25);
            this.aKDYBindingNavigator.TabIndex = 0;
            this.aKDYBindingNavigator.Text = "bindingNavigator1";
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
            // aKDYBindingNavigatorSaveItem
            // 
            this.aKDYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aKDYBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aKDYBindingNavigatorSaveItem.Image")));
            this.aKDYBindingNavigatorSaveItem.Name = "aKDYBindingNavigatorSaveItem";
            this.aKDYBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aKDYBindingNavigatorSaveItem.Text = "Save Data";
            this.aKDYBindingNavigatorSaveItem.Click += new System.EventHandler(this.aKDYBindingNavigatorSaveItem_Click);
            // 
            // akdyGridControl
            // 
            this.akdyGridControl.DataSource = this.aKDYBindingSource;
            this.akdyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.akdyGridControl.Location = new System.Drawing.Point(0, 25);
            this.akdyGridControl.MainView = this.akdyGridView;
            this.akdyGridControl.Name = "akdyGridControl";
            this.akdyGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.akdyGridControl.Size = new System.Drawing.Size(323, 363);
            this.akdyGridControl.TabIndex = 1;
            this.akdyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.akdyGridView});
            // 
            // akdyGridView
            // 
            this.akdyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKAKMID,
            this.colMAKMID,
            this.colCRP});
            this.akdyGridView.GridControl = this.akdyGridControl;
            this.akdyGridView.GroupCount = 1;
            this.akdyGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CRP", this.colCRP, "{0:p}")});
            this.akdyGridView.Name = "akdyGridView";
            this.akdyGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMAKMID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colKAKMID
            // 
            this.colKAKMID.Caption = "KarMrkz";
            this.colKAKMID.FieldName = "KAKMID";
            this.colKAKMID.Name = "colKAKMID";
            this.colKAKMID.Visible = true;
            this.colKAKMID.VisibleIndex = 0;
            // 
            // colMAKMID
            // 
            this.colMAKMID.Caption = "MsrfMrkz";
            this.colMAKMID.FieldName = "MAKMID";
            this.colMAKMID.Name = "colMAKMID";
            this.colMAKMID.Visible = true;
            this.colMAKMID.VisibleIndex = 1;
            // 
            // colCRP
            // 
            this.colCRP.AppearanceCell.Options.UseTextOptions = true;
            this.colCRP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCRP.AppearanceHeader.Options.UseTextOptions = true;
            this.colCRP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCRP.Caption = "Çarpan";
            this.colCRP.DisplayFormat.FormatString = "0.00;[0.00];-";
            this.colCRP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCRP.FieldName = "CRP";
            this.colCRP.Name = "colCRP";
            this.colCRP.Visible = true;
            this.colCRP.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "P";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // AkdyXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 388);
            this.Controls.Add(this.akdyGridControl);
            this.Controls.Add(this.aKDYBindingNavigator);
            this.Name = "AkdyXF";
            this.Text = "AkdyXF";
            this.Load += new System.EventHandler(this.AkdyXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountAkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKDYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKDYBindingNavigator)).EndInit();
            this.aKDYBindingNavigator.ResumeLayout(false);
            this.aKDYBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akdyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akdyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccountAkDataSet accountAkDataSet;
        private System.Windows.Forms.BindingSource aKDYBindingSource;
        private AccountAkDataSetTableAdapters.AKDYTableAdapter aKDYTableAdapter;
        private System.Windows.Forms.BindingNavigator aKDYBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aKDYBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl akdyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView akdyGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colKAKMID;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKMID;
        private DevExpress.XtraGrid.Columns.GridColumn colCRP;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
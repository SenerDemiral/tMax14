namespace tMax14.Account
{
    partial class DagitimAnahtarXF
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DagitimAnahtarXF));
            this.adaGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colADAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adatGridControl = new DevExpress.XtraGrid.GridControl();
            this.adatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.adatGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colADAIDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTURt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adaTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.ADATableAdapter();
            this.aDABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.aDABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.adatTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.ADATTableAdapter();
            this.TURrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.adaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDABindingNavigator)).BeginInit();
            this.aDABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TURrepositoryItemImageComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // adaGridView
            // 
            this.adaGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colADAID,
            this.colAKMID,
            this.colMIK});
            this.adaGridView.GridControl = this.adatGridControl;
            this.adaGridView.Name = "adaGridView";
            this.adaGridView.OptionsView.ColumnAutoWidth = false;
            this.adaGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.adaGridView.OptionsView.ShowFooter = true;
            this.adaGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colADAID
            // 
            this.colADAID.FieldName = "ADAID";
            this.colADAID.Name = "colADAID";
            this.colADAID.OptionsColumn.AllowEdit = false;
            this.colADAID.OptionsColumn.AllowFocus = false;
            // 
            // colAKMID
            // 
            this.colAKMID.FieldName = "AKMID";
            this.colAKMID.Name = "colAKMID";
            this.colAKMID.Visible = true;
            this.colAKMID.VisibleIndex = 0;
            this.colAKMID.Width = 183;
            // 
            // colMIK
            // 
            this.colMIK.AppearanceCell.Options.UseTextOptions = true;
            this.colMIK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMIK.AppearanceHeader.Options.UseTextOptions = true;
            this.colMIK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMIK.Caption = "%";
            this.colMIK.FieldName = "MIK";
            this.colMIK.Name = "colMIK";
            this.colMIK.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colMIK.Visible = true;
            this.colMIK.VisibleIndex = 1;
            this.colMIK.Width = 54;
            // 
            // adatGridControl
            // 
            this.adatGridControl.DataSource = this.adatBindingSource;
            this.adatGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.adaGridView;
            gridLevelNode1.RelationName = "ADAT_ADA";
            this.adatGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.adatGridControl.Location = new System.Drawing.Point(0, 25);
            this.adatGridControl.MainView = this.adatGridView;
            this.adatGridControl.Name = "adatGridControl";
            this.adatGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TURrepositoryItemImageComboBox});
            this.adatGridControl.Size = new System.Drawing.Size(768, 406);
            this.adatGridControl.TabIndex = 2;
            this.adatGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.adatGridView,
            this.adaGridView});
            this.adatGridControl.Click += new System.EventHandler(this.adatGridControl_Click);
            // 
            // adatBindingSource
            // 
            this.adatBindingSource.DataMember = "ADAT";
            this.adatBindingSource.DataSource = this.accountDataSet;
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adatGridView
            // 
            this.adatGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colADAIDt,
            this.colADt,
            this.colTURt});
            this.adatGridView.GridControl = this.adatGridControl;
            this.adatGridView.Name = "adatGridView";
            this.adatGridView.OptionsDetail.AllowExpandEmptyDetails = true;
            this.adatGridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.adatGridView.OptionsDetail.ShowDetailTabs = false;
            this.adatGridView.OptionsView.ColumnAutoWidth = false;
            this.adatGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.adatGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colADAIDt
            // 
            this.colADAIDt.FieldName = "ADAID";
            this.colADAIDt.Name = "colADAIDt";
            this.colADAIDt.Visible = true;
            this.colADAIDt.VisibleIndex = 0;
            // 
            // colADt
            // 
            this.colADt.FieldName = "AD";
            this.colADt.Name = "colADt";
            this.colADt.Visible = true;
            this.colADt.VisibleIndex = 1;
            this.colADt.Width = 229;
            // 
            // colTURt
            // 
            this.colTURt.Caption = "Tür";
            this.colTURt.ColumnEdit = this.TURrepositoryItemImageComboBox;
            this.colTURt.FieldName = "TUR";
            this.colTURt.Name = "colTURt";
            this.colTURt.Visible = true;
            this.colTURt.VisibleIndex = 2;
            // 
            // adaBindingSource
            // 
            this.adaBindingSource.DataMember = "ADAT_ADA";
            this.adaBindingSource.DataSource = this.adatBindingSource;
            // 
            // adaTableAdapter
            // 
            this.adaTableAdapter.ClearBeforeFill = true;
            // 
            // aDABindingNavigator
            // 
            this.aDABindingNavigator.AddNewItem = null;
            this.aDABindingNavigator.BindingSource = this.adaBindingSource;
            this.aDABindingNavigator.CountItem = null;
            this.aDABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aDABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.aDABindingNavigatorSaveItem});
            this.aDABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aDABindingNavigator.MoveFirstItem = null;
            this.aDABindingNavigator.MoveLastItem = null;
            this.aDABindingNavigator.MoveNextItem = null;
            this.aDABindingNavigator.MovePreviousItem = null;
            this.aDABindingNavigator.Name = "aDABindingNavigator";
            this.aDABindingNavigator.PositionItem = null;
            this.aDABindingNavigator.Size = new System.Drawing.Size(768, 25);
            this.aDABindingNavigator.TabIndex = 0;
            this.aDABindingNavigator.Text = "bindingNavigator1";
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
            // aDABindingNavigatorSaveItem
            // 
            this.aDABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aDABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aDABindingNavigatorSaveItem.Image")));
            this.aDABindingNavigatorSaveItem.Name = "aDABindingNavigatorSaveItem";
            this.aDABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aDABindingNavigatorSaveItem.Text = "Save Data";
            this.aDABindingNavigatorSaveItem.Click += new System.EventHandler(this.aDABindingNavigatorSaveItem_Click);
            // 
            // adatTableAdapter
            // 
            this.adatTableAdapter.ClearBeforeFill = true;
            // 
            // TURrepositoryItemImageComboBox
            // 
            this.TURrepositoryItemImageComboBox.AutoHeight = false;
            this.TURrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TURrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yüzde", "Y", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("OpsSayı", "O", -1)});
            this.TURrepositoryItemImageComboBox.Name = "TURrepositoryItemImageComboBox";
            // 
            // DagitimAnahtarXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 431);
            this.Controls.Add(this.adatGridControl);
            this.Controls.Add(this.aDABindingNavigator);
            this.Name = "DagitimAnahtarXF";
            this.Text = "DagitimAnahtarXF";
            this.Load += new System.EventHandler(this.DagitimAnahtarXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDABindingNavigator)).EndInit();
            this.aDABindingNavigator.ResumeLayout(false);
            this.aDABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TURrepositoryItemImageComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource adaBindingSource;
        private AccountDataSetTableAdapters.ADATableAdapter adaTableAdapter;
        private System.Windows.Forms.BindingNavigator aDABindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton aDABindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource adatBindingSource;
        private AccountDataSetTableAdapters.ADATTableAdapter adatTableAdapter;
        private DevExpress.XtraGrid.GridControl adatGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView adatGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colADAIDt;
        private DevExpress.XtraGrid.Columns.GridColumn colADt;
        private DevExpress.XtraGrid.Columns.GridColumn colTURt;
        private DevExpress.XtraGrid.Views.Grid.GridView adaGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colADAID;
        private DevExpress.XtraGrid.Columns.GridColumn colAKMID;
        private DevExpress.XtraGrid.Columns.GridColumn colMIK;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TURrepositoryItemImageComboBox;
    }
}
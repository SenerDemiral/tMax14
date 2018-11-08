namespace tMax14.Qry
{
    partial class qsOphoXUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.qryMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.qsOPHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryDataSet = new tMax14.Qry.QryDataSet();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.ophoTableAdapter = new tMax14.Order.OrderDataSetTableAdapters.OPHOTableAdapter();
            this.qsvGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rowSearchName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowOrderIDs = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowUpdated = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMnfIDs = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowShpIDs = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCneIDs = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDataColumn1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDataColumn2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDataColumn3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDataColumn4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDataColumn5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDataColumn6 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDataColumn7 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qsOPHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.qryMemoEdit;
            this.layoutControlItem4.CustomizationFormText = "Query Text";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 419);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(110, 20);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(350, 142);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Query Text";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
            // 
            // qryMemoEdit
            // 
            this.qryMemoEdit.Location = new System.Drawing.Point(6, 441);
            this.qryMemoEdit.Name = "qryMemoEdit";
            this.qryMemoEdit.Size = new System.Drawing.Size(346, 122);
            this.qryMemoEdit.StyleController = this.layoutControl1;
            this.qryMemoEdit.TabIndex = 5;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.qsvGridControl);
            this.layoutControl1.Controls.Add(this.qryMemoEdit);
            this.layoutControl1.Controls.Add(this.searchButton);
            this.layoutControl1.Controls.Add(this.dataNavigator1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(477, 266, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(358, 595);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // qsOPHOBindingSource
            // 
            this.qsOPHOBindingSource.DataMember = "qsOPHO";
            this.qsOPHOBindingSource.DataSource = this.qryDataSet;
            // 
            // qryDataSet
            // 
            this.qryDataSet.DataSetName = "QryDataSet";
            this.qryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 567);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(346, 22);
            this.searchButton.StyleController = this.layoutControl1;
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.NextPage.Visible = false;
            this.dataNavigator1.Buttons.PrevPage.Visible = false;
            this.dataNavigator1.DataSource = this.qsOPHOBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(6, 6);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(346, 19);
            this.dataNavigator1.StyleController = this.layoutControl1;
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.dataNavigator1.TextStringFormat = "{0}/{1}";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.splitterItem1,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup1.Size = new System.Drawing.Size(358, 595);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dataNavigator1;
            this.layoutControlItem2.CustomizationFormText = "navigation";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 23);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(145, 23);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(350, 23);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "navigation";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 561);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(350, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(0, 414);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(350, 5);
            // 
            // ophoTableAdapter
            // 
            this.ophoTableAdapter.ClearBeforeFill = true;
            // 
            // qsvGridControl
            // 
            this.qsvGridControl.DataSource = this.qsOPHOBindingSource;
            this.qsvGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.qsvGridControl.Location = new System.Drawing.Point(6, 29);
            this.qsvGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.qsvGridControl.Name = "qsvGridControl";
            this.qsvGridControl.OptionsView.FixRowHeaderPanelWidth = true;
            this.qsvGridControl.RecordWidth = 117;
            this.qsvGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.qsvGridControl.RowHeaderWidth = 83;
            this.qsvGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowSearchName,
            this.rowOrderIDs,
            this.rowUpdated,
            this.rowMnfIDs,
            this.rowShpIDs,
            this.rowCneIDs,
            this.rowDataColumn1,
            this.rowDataColumn2,
            this.rowDataColumn3,
            this.rowDataColumn4,
            this.rowDataColumn5,
            this.rowDataColumn6,
            this.rowDataColumn7});
            this.qsvGridControl.Size = new System.Drawing.Size(346, 387);
            this.qsvGridControl.TabIndex = 8;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.qsvGridControl;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(350, 391);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // rowSearchName
            // 
            this.rowSearchName.Name = "rowSearchName";
            this.rowSearchName.Properties.Caption = "Search Name";
            this.rowSearchName.Properties.FieldName = "SearchName";
            // 
            // rowOrderIDs
            // 
            this.rowOrderIDs.Name = "rowOrderIDs";
            this.rowOrderIDs.Properties.Caption = "Order IDs";
            this.rowOrderIDs.Properties.FieldName = "OrderIDs";
            // 
            // rowUpdated
            // 
            this.rowUpdated.Name = "rowUpdated";
            this.rowUpdated.Properties.Caption = "Updated";
            this.rowUpdated.Properties.FieldName = "Updated";
            // 
            // rowMnfIDs
            // 
            this.rowMnfIDs.Name = "rowMnfIDs";
            this.rowMnfIDs.Properties.Caption = "Mnf IDs";
            this.rowMnfIDs.Properties.FieldName = "MnfIDs";
            // 
            // rowShpIDs
            // 
            this.rowShpIDs.Name = "rowShpIDs";
            this.rowShpIDs.Properties.Caption = "Shp IDs";
            this.rowShpIDs.Properties.FieldName = "ShpIDs";
            // 
            // rowCneIDs
            // 
            this.rowCneIDs.Name = "rowCneIDs";
            this.rowCneIDs.Properties.Caption = "Cne IDs";
            this.rowCneIDs.Properties.FieldName = "CneIDs";
            // 
            // rowDataColumn1
            // 
            this.rowDataColumn1.Name = "rowDataColumn1";
            this.rowDataColumn1.Properties.Caption = "Data Column1";
            this.rowDataColumn1.Properties.FieldName = "DataColumn1";
            // 
            // rowDataColumn2
            // 
            this.rowDataColumn2.Name = "rowDataColumn2";
            this.rowDataColumn2.Properties.Caption = "Data Column2";
            this.rowDataColumn2.Properties.FieldName = "DataColumn2";
            // 
            // rowDataColumn3
            // 
            this.rowDataColumn3.Name = "rowDataColumn3";
            this.rowDataColumn3.Properties.Caption = "Data Column3";
            this.rowDataColumn3.Properties.FieldName = "DataColumn3";
            // 
            // rowDataColumn4
            // 
            this.rowDataColumn4.Name = "rowDataColumn4";
            this.rowDataColumn4.Properties.Caption = "Data Column4";
            this.rowDataColumn4.Properties.FieldName = "DataColumn4";
            // 
            // rowDataColumn5
            // 
            this.rowDataColumn5.Name = "rowDataColumn5";
            this.rowDataColumn5.Properties.Caption = "Data Column5";
            this.rowDataColumn5.Properties.FieldName = "DataColumn5";
            // 
            // rowDataColumn6
            // 
            this.rowDataColumn6.Name = "rowDataColumn6";
            this.rowDataColumn6.Properties.Caption = "Data Column6";
            this.rowDataColumn6.Properties.FieldName = "DataColumn6";
            // 
            // rowDataColumn7
            // 
            this.rowDataColumn7.Name = "rowDataColumn7";
            this.rowDataColumn7.Properties.Caption = "Data Column7";
            this.rowDataColumn7.Properties.FieldName = "DataColumn7";
            // 
            // qsOphoXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "qsOphoXUC";
            this.Size = new System.Drawing.Size(358, 595);
            this.Load += new System.EventHandler(this.qsOphoXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qsOPHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.MemoEdit qryMemoEdit;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource qsOPHOBindingSource;
        private QryDataSet qryDataSet;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private Order.OrderDataSetTableAdapters.OPHOTableAdapter ophoTableAdapter;
        private DevExpress.XtraVerticalGrid.VGridControl qsvGridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSearchName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowOrderIDs;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowUpdated;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMnfIDs;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowShpIDs;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCneIDs;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDataColumn1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDataColumn2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDataColumn3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDataColumn4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDataColumn5;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDataColumn6;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDataColumn7;
    }
}

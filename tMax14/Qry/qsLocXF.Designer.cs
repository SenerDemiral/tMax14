namespace tMax14.Qry
{
    partial class qsLocXF
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.qsGridControl = new DevExpress.XtraGrid.GridControl();
            this.qsLOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryDataSet = new tMax14.Qry.QryDataSet();
            this.qsLayoutView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colLOCid = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colLOCid = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colAd = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colAd = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCntry = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCntry = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colDrm = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colDrm = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colQRY = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.QRYrepositoryItemMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutViewField_colQRY = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFunc = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.FUNCrepositoryItemCheckedComboBoxEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.layoutViewField_colFunc = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.locTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.LOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsLOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsLayoutView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLOCid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDrm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRYrepositoryItemMemoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colQRY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FUNCrepositoryItemCheckedComboBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchSimpleButton);
            this.layoutControl1.Controls.Add(this.qsGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(700, 137, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(267, 462);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchSimpleButton
            // 
            this.searchSimpleButton.Location = new System.Drawing.Point(4, 436);
            this.searchSimpleButton.Name = "searchSimpleButton";
            this.searchSimpleButton.Size = new System.Drawing.Size(259, 22);
            this.searchSimpleButton.StyleController = this.layoutControl1;
            this.searchSimpleButton.TabIndex = 5;
            this.searchSimpleButton.Text = "Search";
            this.searchSimpleButton.Click += new System.EventHandler(this.searchSimpleButton_Click);
            // 
            // qsGridControl
            // 
            this.qsGridControl.DataSource = this.qsLOCBindingSource;
            this.qsGridControl.Location = new System.Drawing.Point(4, 4);
            this.qsGridControl.MainView = this.qsLayoutView;
            this.qsGridControl.Name = "qsGridControl";
            this.qsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.FUNCrepositoryItemCheckedComboBoxEdit,
            this.QRYrepositoryItemMemoEdit});
            this.qsGridControl.Size = new System.Drawing.Size(259, 428);
            this.qsGridControl.TabIndex = 4;
            this.qsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.qsLayoutView});
            // 
            // qsLOCBindingSource
            // 
            this.qsLOCBindingSource.DataMember = "qsLOC";
            this.qsLOCBindingSource.DataSource = this.qryDataSet;
            // 
            // qryDataSet
            // 
            this.qryDataSet.DataSetName = "QryDataSet";
            this.qryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qsLayoutView
            // 
            this.qsLayoutView.Appearance.FieldCaption.Options.UseTextOptions = true;
            this.qsLayoutView.Appearance.FieldCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.qsLayoutView.Appearance.FieldValue.BackColor = System.Drawing.Color.SeaShell;
            this.qsLayoutView.Appearance.FieldValue.Options.UseBackColor = true;
            this.qsLayoutView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colLOCid,
            this.colAd,
            this.colCntry,
            this.colDrm,
            this.colQRY,
            this.colFunc});
            this.qsLayoutView.GridControl = this.qsGridControl;
            this.qsLayoutView.Name = "qsLayoutView";
            this.qsLayoutView.TemplateCard = this.layoutViewCard1;
            this.qsLayoutView.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.qsLayoutView_FocusedColumnChanged);
            this.qsLayoutView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qsLayoutView_KeyDown);
            this.qsLayoutView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.qsLayoutView_ValidatingEditor);
            // 
            // colLOCid
            // 
            this.colLOCid.Caption = "LocID";
            this.colLOCid.FieldName = "LOCid";
            this.colLOCid.LayoutViewField = this.layoutViewField_colLOCid;
            this.colLOCid.Name = "colLOCid";
            // 
            // layoutViewField_colLOCid
            // 
            this.layoutViewField_colLOCid.EditorPreferredWidth = 154;
            this.layoutViewField_colLOCid.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colLOCid.Name = "layoutViewField_colLOCid";
            this.layoutViewField_colLOCid.Size = new System.Drawing.Size(222, 24);
            this.layoutViewField_colLOCid.TextSize = new System.Drawing.Size(59, 13);
            this.layoutViewField_colLOCid.TextToControlDistance = 5;
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.LayoutViewField = this.layoutViewField_colAd;
            this.colAd.Name = "colAd";
            // 
            // layoutViewField_colAd
            // 
            this.layoutViewField_colAd.EditorPreferredWidth = 154;
            this.layoutViewField_colAd.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colAd.Name = "layoutViewField_colAd";
            this.layoutViewField_colAd.Size = new System.Drawing.Size(222, 24);
            this.layoutViewField_colAd.TextSize = new System.Drawing.Size(59, 13);
            this.layoutViewField_colAd.TextToControlDistance = 5;
            // 
            // colCntry
            // 
            this.colCntry.FieldName = "Cntry";
            this.colCntry.LayoutViewField = this.layoutViewField_colCntry;
            this.colCntry.Name = "colCntry";
            // 
            // layoutViewField_colCntry
            // 
            this.layoutViewField_colCntry.EditorPreferredWidth = 154;
            this.layoutViewField_colCntry.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colCntry.Name = "layoutViewField_colCntry";
            this.layoutViewField_colCntry.Size = new System.Drawing.Size(222, 24);
            this.layoutViewField_colCntry.TextSize = new System.Drawing.Size(59, 13);
            this.layoutViewField_colCntry.TextToControlDistance = 5;
            // 
            // colDrm
            // 
            this.colDrm.FieldName = "Drm";
            this.colDrm.LayoutViewField = this.layoutViewField_colDrm;
            this.colDrm.Name = "colDrm";
            // 
            // layoutViewField_colDrm
            // 
            this.layoutViewField_colDrm.EditorPreferredWidth = 154;
            this.layoutViewField_colDrm.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colDrm.Name = "layoutViewField_colDrm";
            this.layoutViewField_colDrm.Size = new System.Drawing.Size(222, 24);
            this.layoutViewField_colDrm.TextSize = new System.Drawing.Size(59, 13);
            this.layoutViewField_colDrm.TextToControlDistance = 5;
            // 
            // colQRY
            // 
            this.colQRY.AppearanceCell.Options.UseTextOptions = true;
            this.colQRY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colQRY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQRY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQRY.ColumnEdit = this.QRYrepositoryItemMemoEdit;
            this.colQRY.FieldName = "QRY";
            this.colQRY.LayoutViewField = this.layoutViewField_colQRY;
            this.colQRY.Name = "colQRY";
            // 
            // QRYrepositoryItemMemoEdit
            // 
            this.QRYrepositoryItemMemoEdit.Name = "QRYrepositoryItemMemoEdit";
            // 
            // layoutViewField_colQRY
            // 
            this.layoutViewField_colQRY.EditorPreferredWidth = 190;
            this.layoutViewField_colQRY.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_colQRY.Name = "layoutViewField_colQRY";
            this.layoutViewField_colQRY.Size = new System.Drawing.Size(222, 38);
            this.layoutViewField_colQRY.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colQRY.TextSize = new System.Drawing.Size(59, 13);
            this.layoutViewField_colQRY.TextToControlDistance = 5;
            // 
            // colFunc
            // 
            this.colFunc.ColumnEdit = this.FUNCrepositoryItemCheckedComboBoxEdit;
            this.colFunc.FieldName = "Func";
            this.colFunc.LayoutViewField = this.layoutViewField_colFunc;
            this.colFunc.Name = "colFunc";
            // 
            // FUNCrepositoryItemCheckedComboBoxEdit
            // 
            this.FUNCrepositoryItemCheckedComboBoxEdit.AutoHeight = false;
            this.FUNCrepositoryItemCheckedComboBoxEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FUNCrepositoryItemCheckedComboBoxEdit.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("0", "Undefined"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("1", "Port"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("2", "Rail"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("3", "Road"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("4", "Airport"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("5", "PostalOffice"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("6", "Reserved"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("7", "Reserved"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("B", "Border")});
            this.FUNCrepositoryItemCheckedComboBoxEdit.Name = "FUNCrepositoryItemCheckedComboBoxEdit";
            // 
            // layoutViewField_colFunc
            // 
            this.layoutViewField_colFunc.EditorPreferredWidth = 154;
            this.layoutViewField_colFunc.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_colFunc.Name = "layoutViewField_colFunc";
            this.layoutViewField_colFunc.Size = new System.Drawing.Size(222, 24);
            this.layoutViewField_colFunc.TextSize = new System.Drawing.Size(59, 13);
            this.layoutViewField_colFunc.TextToControlDistance = 5;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colLOCid,
            this.layoutViewField_colAd,
            this.layoutViewField_colCntry,
            this.layoutViewField_colQRY,
            this.layoutViewField_colFunc,
            this.layoutViewField_colDrm});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(267, 462);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.qsGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(263, 432);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.searchSimpleButton;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 432);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(263, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // locTableAdapter
            // 
            this.locTableAdapter.ClearBeforeFill = true;
            // 
            // qsLocXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "qsLocXF";
            this.Size = new System.Drawing.Size(267, 462);
            this.Load += new System.EventHandler(this.qsLocXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsLOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsLayoutView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLOCid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDrm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRYrepositoryItemMemoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colQRY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FUNCrepositoryItemCheckedComboBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl qsGridControl;
        private System.Windows.Forms.BindingSource qsLOCBindingSource;
        private QryDataSet qryDataSet;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton searchSimpleButton;
        private DevExpress.XtraGrid.Views.Layout.LayoutView qsLayoutView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colLOCid;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colAd;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCntry;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDrm;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colQRY;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Genel.GenelDataSetTableAdapters.LOCTableAdapter locTableAdapter;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colFunc;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit FUNCrepositoryItemCheckedComboBoxEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit QRYrepositoryItemMemoEdit;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colLOCid;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colAd;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCntry;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDrm;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colQRY;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colFunc;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;

    }
}

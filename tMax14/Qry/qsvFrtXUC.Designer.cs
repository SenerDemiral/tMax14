namespace tMax14.Qry
{
    partial class qsvFrtXUC
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
            this.qsvGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.qsFRTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryDataSet = new tMax14.Qry.QryDataSet();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.rowSearchName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFRTID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowADN = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowOfcNo = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowAD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTUR = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFLY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowGRP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCntry = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowVdeGun = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTAGS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBKMD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBKMS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowQRY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowSREPID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowAQRY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDRM = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.qryMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.frtTableAdapter = new tMax14.Firma.FirmaDataSetTableAdapters.FRT_REC_SELTableAdapter();
            this.rowSrvUlk = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsFRTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // qsvGridControl
            // 
            this.qsvGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.qsvGridControl.DataSource = this.qsFRTBindingSource;
            this.qsvGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.qsvGridControl.Location = new System.Drawing.Point(6, 29);
            this.qsvGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.qsvGridControl.Name = "qsvGridControl";
            this.qsvGridControl.OptionsView.FixRowHeaderPanelWidth = true;
            this.qsvGridControl.RecordWidth = 96;
            this.qsvGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.qsvGridControl.RowHeaderWidth = 104;
            this.qsvGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowSearchName,
            this.rowFRTID,
            this.rowADN,
            this.rowOfcNo,
            this.rowAD,
            this.rowTUR,
            this.rowFLY,
            this.rowGRP,
            this.rowCntry,
            this.rowVdeGun,
            this.rowTAGS,
            this.rowBKMD,
            this.rowBKMS,
            this.rowQRY,
            this.rowSREPID,
            this.rowAQRY,
            this.rowDRM,
            this.rowSrvUlk});
            this.qsvGridControl.Size = new System.Drawing.Size(225, 282);
            this.qsvGridControl.TabIndex = 0;
            this.qsvGridControl.CellValueChanging += new DevExpress.XtraVerticalGrid.Events.CellValueChangedEventHandler(this.qsvGridControl_CellValueChanging);
            this.qsvGridControl.HiddenEditor += new System.EventHandler(this.qsvGridControl_HiddenEditor);
            this.qsvGridControl.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.qsvGridControl_EditorKeyDown);
            this.qsvGridControl.VisibleChanged += new System.EventHandler(this.qsvGridControl_VisibleChanged);
            // 
            // qsFRTBindingSource
            // 
            this.qsFRTBindingSource.DataMember = "qsFRT";
            this.qsFRTBindingSource.DataSource = this.qryDataSet;
            // 
            // qryDataSet
            // 
            this.qryDataSet.DataSetName = "QryDataSet";
            this.qryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // rowSearchName
            // 
            this.rowSearchName.Name = "rowSearchName";
            this.rowSearchName.Properties.Caption = "Search Name";
            this.rowSearchName.Properties.FieldName = "SearchName";
            // 
            // rowFRTID
            // 
            this.rowFRTID.Name = "rowFRTID";
            this.rowFRTID.Properties.Caption = "FRTID";
            this.rowFRTID.Properties.FieldName = "FRTID";
            // 
            // rowADN
            // 
            this.rowADN.Name = "rowADN";
            this.rowADN.Properties.Caption = "Nick Name";
            this.rowADN.Properties.FieldName = "ADN";
            // 
            // rowOfcNo
            // 
            this.rowOfcNo.Name = "rowOfcNo";
            this.rowOfcNo.Properties.Caption = "OfficeNo";
            this.rowOfcNo.Properties.FieldName = "OfcNo";
            // 
            // rowAD
            // 
            this.rowAD.Name = "rowAD";
            this.rowAD.Properties.Caption = "Ad";
            this.rowAD.Properties.FieldName = "AD";
            // 
            // rowTUR
            // 
            this.rowTUR.Name = "rowTUR";
            this.rowTUR.Properties.Caption = "Tür";
            this.rowTUR.Properties.FieldName = "TUR";
            // 
            // rowFLY
            // 
            this.rowFLY.Name = "rowFLY";
            this.rowFLY.Properties.Caption = "Faliyet";
            this.rowFLY.Properties.FieldName = "FLY";
            // 
            // rowGRP
            // 
            this.rowGRP.Name = "rowGRP";
            this.rowGRP.Properties.Caption = "Grp";
            this.rowGRP.Properties.FieldName = "GRP";
            // 
            // rowCntry
            // 
            this.rowCntry.Name = "rowCntry";
            this.rowCntry.Properties.Caption = "Cntry";
            this.rowCntry.Properties.FieldName = "Cntry";
            // 
            // rowVdeGun
            // 
            this.rowVdeGun.Name = "rowVdeGun";
            this.rowVdeGun.Properties.Caption = "VdeGün";
            this.rowVdeGun.Properties.FieldName = "VdeGun";
            // 
            // rowTAGS
            // 
            this.rowTAGS.Name = "rowTAGS";
            this.rowTAGS.Properties.Caption = "TAGs";
            this.rowTAGS.Properties.FieldName = "TAGS";
            // 
            // rowBKMD
            // 
            this.rowBKMD.Name = "rowBKMD";
            this.rowBKMD.Properties.Caption = "Bookmarked";
            this.rowBKMD.Properties.FieldName = "BKMD";
            // 
            // rowBKMS
            // 
            this.rowBKMS.Name = "rowBKMS";
            this.rowBKMS.Properties.Caption = "BKMs";
            this.rowBKMS.Properties.FieldName = "BKMS";
            // 
            // rowQRY
            // 
            this.rowQRY.Height = 73;
            this.rowQRY.Name = "rowQRY";
            this.rowQRY.Properties.Caption = "Query";
            this.rowQRY.Properties.FieldName = "QRY";
            this.rowQRY.Properties.RowEdit = this.repositoryItemMemoEdit1;
            this.rowQRY.Visible = false;
            // 
            // rowSREPID
            // 
            this.rowSREPID.Name = "rowSREPID";
            this.rowSREPID.Properties.Caption = "SalesRep";
            this.rowSREPID.Properties.FieldName = "SRepID";
            // 
            // rowAQRY
            // 
            this.rowAQRY.Name = "rowAQRY";
            this.rowAQRY.Properties.Caption = "Anonim";
            this.rowAQRY.Properties.FieldName = "aQry";
            // 
            // rowDRM
            // 
            this.rowDRM.Name = "rowDRM";
            this.rowDRM.Properties.Caption = "Drm";
            this.rowDRM.Properties.FieldName = "DRM";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.NextPage.Visible = false;
            this.dataNavigator1.Buttons.PrevPage.Visible = false;
            this.dataNavigator1.DataSource = this.qsFRTBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(6, 6);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(225, 19);
            this.dataNavigator1.StyleController = this.layoutControl1;
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.dataNavigator1.TextStringFormat = "{0}/{1}";
            this.dataNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dataNavigator1_ButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.qryMemoEdit);
            this.layoutControl1.Controls.Add(this.searchButton);
            this.layoutControl1.Controls.Add(this.dataNavigator1);
            this.layoutControl1.Controls.Add(this.qsvGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(477, 266, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(237, 497);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // qryMemoEdit
            // 
            this.qryMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qsFRTBindingSource, "QRY", true));
            this.qryMemoEdit.Location = new System.Drawing.Point(6, 331);
            this.qryMemoEdit.Name = "qryMemoEdit";
            this.qryMemoEdit.Size = new System.Drawing.Size(225, 134);
            this.qryMemoEdit.StyleController = this.layoutControl1;
            this.qryMemoEdit.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 469);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(225, 22);
            this.searchButton.StyleController = this.layoutControl1;
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup1.Size = new System.Drawing.Size(237, 497);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.qsvGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(229, 286);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dataNavigator1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 23);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(145, 23);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(229, 23);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 463);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(229, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.qryMemoEdit;
            this.layoutControlItem4.CustomizationFormText = "Query Text";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 309);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(229, 154);
            this.layoutControlItem4.Text = "Query Text";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
            // 
            // frtTableAdapter
            // 
            this.frtTableAdapter.ClearBeforeFill = true;
            // 
            // rowSrvUlk
            // 
            this.rowSrvUlk.Name = "rowSrvUlk";
            this.rowSrvUlk.Properties.Caption = "SrvCntry";
            this.rowSrvUlk.Properties.FieldName = "SrvUlk";
            // 
            // qsvFrtXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "qsvFrtXUC";
            this.Size = new System.Drawing.Size(237, 497);
            this.Load += new System.EventHandler(this.qsvFrtXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsFRTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl qsvGridControl;
        private System.Windows.Forms.BindingSource qsFRTBindingSource;
        private QryDataSet qryDataSet;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSearchName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFRTID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowADN;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTUR;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFLY;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCntry;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTAGS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBKMD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBKMS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowQRY;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit qryMemoEdit;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Firma.FirmaDataSetTableAdapters.FRT_REC_SELTableAdapter frtTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAQRY;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSREPID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowGRP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowOfcNo;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowVdeGun;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDRM;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSrvUlk;
    }
}

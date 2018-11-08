namespace tMax14.Qry
{
    partial class qsvTafXUC
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
            this.qsTAFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryDataSet = new tMax14.Qry.QryDataSet();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.rowSearchName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTAFID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCarrier = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCharge = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowStu = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTyp = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowOwn = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTOP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowROT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMOT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowOrgCntry = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDstCntry = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowQRY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTAGS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBKMS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowAQRY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowGcrTrh = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.qryMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.frtTableAdapter = new tMax14.Firma.FirmaDataSetTableAdapters.FRT_REC_SELTableAdapter();
            this.tafTableAdapter = new tMax14.Teklif.TeklifDataSetTableAdapters.TAFTableAdapter();
            this.qsFRTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsTAFBindingSource)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsFRTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qsvGridControl
            // 
            this.qsvGridControl.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.qsvGridControl.DataSource = this.qsTAFBindingSource;
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
            this.rowTAFID,
            this.rowCarrier,
            this.rowCharge,
            this.rowStu,
            this.rowTyp,
            this.rowOwn,
            this.rowTOP,
            this.rowROT,
            this.rowMOT,
            this.rowOrgCntry,
            this.rowDstCntry,
            this.rowQRY,
            this.rowTAGS,
            this.rowBKMS,
            this.rowAQRY,
            this.rowGcrTrh});
            this.qsvGridControl.Size = new System.Drawing.Size(225, 280);
            this.qsvGridControl.TabIndex = 0;
            this.qsvGridControl.CellValueChanging += new DevExpress.XtraVerticalGrid.Events.CellValueChangedEventHandler(this.qsvGridControl_CellValueChanging);
            this.qsvGridControl.HiddenEditor += new System.EventHandler(this.qsvGridControl_HiddenEditor);
            this.qsvGridControl.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.qsvGridControl_EditorKeyDown);
            this.qsvGridControl.VisibleChanged += new System.EventHandler(this.qsvGridControl_VisibleChanged);
            // 
            // qsTAFBindingSource
            // 
            this.qsTAFBindingSource.DataMember = "qsTAF";
            this.qsTAFBindingSource.DataSource = this.qryDataSet;
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
            this.rowSearchName.Properties.Caption = "SearchNme";
            this.rowSearchName.Properties.FieldName = "SearchName";
            // 
            // rowTAFID
            // 
            this.rowTAFID.Name = "rowTAFID";
            this.rowTAFID.Properties.Caption = "TAFID";
            this.rowTAFID.Properties.FieldName = "TAFID";
            // 
            // rowCarrier
            // 
            this.rowCarrier.Name = "rowCarrier";
            this.rowCarrier.Properties.Caption = "Carrier";
            this.rowCarrier.Properties.FieldName = "Carrier";
            // 
            // rowCharge
            // 
            this.rowCharge.Name = "rowCharge";
            this.rowCharge.Properties.Caption = "Charge";
            this.rowCharge.Properties.FieldName = "Charge";
            // 
            // rowStu
            // 
            this.rowStu.Name = "rowStu";
            this.rowStu.Properties.Caption = "Stu";
            this.rowStu.Properties.FieldName = "Stu";
            // 
            // rowTyp
            // 
            this.rowTyp.Name = "rowTyp";
            this.rowTyp.Properties.Caption = "Typ";
            this.rowTyp.Properties.FieldName = "Typ";
            // 
            // rowOwn
            // 
            this.rowOwn.Name = "rowOwn";
            this.rowOwn.Properties.Caption = "Own";
            this.rowOwn.Properties.FieldName = "Own";
            // 
            // rowTOP
            // 
            this.rowTOP.Name = "rowTOP";
            this.rowTOP.Properties.Caption = "TOP";
            this.rowTOP.Properties.FieldName = "TOP";
            // 
            // rowROT
            // 
            this.rowROT.Name = "rowROT";
            this.rowROT.Properties.Caption = "ROT";
            this.rowROT.Properties.FieldName = "ROT";
            // 
            // rowMOT
            // 
            this.rowMOT.Name = "rowMOT";
            this.rowMOT.Properties.Caption = "MOT";
            this.rowMOT.Properties.FieldName = "MOT";
            // 
            // rowOrgCntry
            // 
            this.rowOrgCntry.Name = "rowOrgCntry";
            this.rowOrgCntry.Properties.Caption = "Org Cntry";
            this.rowOrgCntry.Properties.FieldName = "OrgCntry";
            // 
            // rowDstCntry
            // 
            this.rowDstCntry.Name = "rowDstCntry";
            this.rowDstCntry.Properties.Caption = "Dst Cntry";
            this.rowDstCntry.Properties.FieldName = "DstCntry";
            // 
            // rowQRY
            // 
            this.rowQRY.Name = "rowQRY";
            this.rowQRY.Properties.Caption = "QRY";
            this.rowQRY.Properties.FieldName = "QRY";
            this.rowQRY.Visible = false;
            // 
            // rowTAGS
            // 
            this.rowTAGS.Height = 16;
            this.rowTAGS.Name = "rowTAGS";
            this.rowTAGS.Properties.Caption = "TAGs";
            this.rowTAGS.Properties.FieldName = "TAGS";
            // 
            // rowBKMS
            // 
            this.rowBKMS.Name = "rowBKMS";
            this.rowBKMS.Properties.Caption = "BKMs";
            this.rowBKMS.Properties.FieldName = "BKMS";
            // 
            // rowAQRY
            // 
            this.rowAQRY.Name = "rowAQRY";
            this.rowAQRY.Properties.Caption = "Anonim";
            this.rowAQRY.Properties.FieldName = "aQry";
            // 
            // rowGcrTrh
            // 
            this.rowGcrTrh.Name = "rowGcrTrh";
            this.rowGcrTrh.Properties.Caption = "GçrTrh >=";
            this.rowGcrTrh.Properties.FieldName = "GcrTrh";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.NextPage.Visible = false;
            this.dataNavigator1.Buttons.PrevPage.Visible = false;
            this.dataNavigator1.DataSource = this.qsTAFBindingSource;
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
            this.layoutControl1.Size = new System.Drawing.Size(237, 527);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // qryMemoEdit
            // 
            this.qryMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qsTAFBindingSource, "QRY", true));
            this.qryMemoEdit.Location = new System.Drawing.Point(6, 334);
            this.qryMemoEdit.Name = "qryMemoEdit";
            this.qryMemoEdit.Size = new System.Drawing.Size(225, 161);
            this.qryMemoEdit.StyleController = this.layoutControl1;
            this.qryMemoEdit.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 499);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(225, 22);
            this.searchButton.StyleController = this.layoutControl1;
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.splitterItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup1.Size = new System.Drawing.Size(237, 527);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.qsvGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(229, 284);
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
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 493);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(229, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.qryMemoEdit;
            this.layoutControlItem4.CustomizationFormText = "Query Text";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 312);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(59, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(229, 181);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Query Text";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(0, 307);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(229, 5);
            // 
            // frtTableAdapter
            // 
            this.frtTableAdapter.ClearBeforeFill = true;
            // 
            // tafTableAdapter
            // 
            this.tafTableAdapter.ClearBeforeFill = true;
            // 
            // qsFRTBindingSource
            // 
            this.qsFRTBindingSource.DataMember = "qsFRT";
            this.qsFRTBindingSource.DataSource = this.qryDataSet;
            // 
            // qsvTafXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "qsvTafXUC";
            this.Size = new System.Drawing.Size(237, 527);
            this.Load += new System.EventHandler(this.qsvFrtXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsTAFBindingSource)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsFRTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl qsvGridControl;
        private System.Windows.Forms.BindingSource qsFRTBindingSource;
        private QryDataSet qryDataSet;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit qryMemoEdit;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Firma.FirmaDataSetTableAdapters.FRT_REC_SELTableAdapter frtTableAdapter;
        private System.Windows.Forms.BindingSource qsTAFBindingSource;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTAFID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCarrier;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCharge;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowStu;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTyp;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowOwn;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTOP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowROT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMOT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowOrgCntry;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDstCntry;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowQRY;
        private Teklif.TeklifDataSetTableAdapters.TAFTableAdapter tafTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTAGS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBKMS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSearchName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAQRY;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowGcrTrh;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}

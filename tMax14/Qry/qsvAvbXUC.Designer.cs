namespace tMax14.Qry
{
    partial class qsvAvbXUC
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
            this.qryMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.qsAVBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryDataSet = new tMax14.Qry.QryDataSet();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.qsvGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.rowSearchName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowAVBID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTur = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDrm = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowAciklama = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowQRY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowHspNoS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTrh1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTrh2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTAGS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBKMD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBKMS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.avbTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AVBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsAVBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
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
            this.layoutControl1.Size = new System.Drawing.Size(372, 575);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // qryMemoEdit
            // 
            this.qryMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qsAVBBindingSource, "QRY", true));
            this.qryMemoEdit.Location = new System.Drawing.Point(6, 342);
            this.qryMemoEdit.Name = "qryMemoEdit";
            this.qryMemoEdit.Size = new System.Drawing.Size(360, 201);
            this.qryMemoEdit.StyleController = this.layoutControl1;
            this.qryMemoEdit.TabIndex = 5;
            // 
            // qsAVBBindingSource
            // 
            this.qsAVBBindingSource.DataMember = "qsAVB";
            this.qsAVBBindingSource.DataSource = this.qryDataSet;
            // 
            // qryDataSet
            // 
            this.qryDataSet.DataSetName = "QryDataSet";
            this.qryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 547);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(360, 22);
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
            this.dataNavigator1.DataSource = this.qsAVBBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(6, 6);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(360, 19);
            this.dataNavigator1.StyleController = this.layoutControl1;
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.dataNavigator1.TextStringFormat = "{0}/{1}";
            // 
            // qsvGridControl
            // 
            this.qsvGridControl.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.qsvGridControl.DataSource = this.qsAVBBindingSource;
            this.qsvGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.qsvGridControl.Location = new System.Drawing.Point(6, 29);
            this.qsvGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.qsvGridControl.Name = "qsvGridControl";
            this.qsvGridControl.OptionsView.FixRowHeaderPanelWidth = true;
            this.qsvGridControl.RecordWidth = 108;
            this.qsvGridControl.RowHeaderWidth = 92;
            this.qsvGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowSearchName,
            this.rowAVBID,
            this.rowTur,
            this.rowDrm,
            this.rowAciklama,
            this.rowQRY,
            this.rowHspNoS,
            this.rowTrh1,
            this.rowTrh2,
            this.rowTAGS,
            this.rowBKMD,
            this.rowBKMS});
            this.qsvGridControl.Size = new System.Drawing.Size(360, 293);
            this.qsvGridControl.TabIndex = 0;
            this.qsvGridControl.CellValueChanged += new DevExpress.XtraVerticalGrid.Events.CellValueChangedEventHandler(this.qsvGridControl_CellValueChanged);
            this.qsvGridControl.HiddenEditor += new System.EventHandler(this.qsvGridControl_HiddenEditor);
            this.qsvGridControl.EditorKeyUp += new System.Windows.Forms.KeyEventHandler(this.qsvGridControl_EditorKeyUp);
            this.qsvGridControl.VisibleChanged += new System.EventHandler(this.qsvGridControl_VisibleChanged);
            // 
            // rowSearchName
            // 
            this.rowSearchName.Name = "rowSearchName";
            this.rowSearchName.Properties.Caption = "Search Name";
            this.rowSearchName.Properties.FieldName = "SearchName";
            // 
            // rowAVBID
            // 
            this.rowAVBID.Name = "rowAVBID";
            this.rowAVBID.Properties.Caption = "AVBID";
            this.rowAVBID.Properties.FieldName = "AVBID";
            // 
            // rowTur
            // 
            this.rowTur.Name = "rowTur";
            this.rowTur.Properties.Caption = "Tür";
            this.rowTur.Properties.FieldName = "Tur";
            // 
            // rowDrm
            // 
            this.rowDrm.Name = "rowDrm";
            this.rowDrm.Properties.Caption = "Drm";
            this.rowDrm.Properties.FieldName = "Drm";
            // 
            // rowAciklama
            // 
            this.rowAciklama.Name = "rowAciklama";
            this.rowAciklama.Properties.Caption = "Açıklama";
            this.rowAciklama.Properties.FieldName = "Aciklama";
            // 
            // rowQRY
            // 
            this.rowQRY.Name = "rowQRY";
            this.rowQRY.Properties.Caption = "QRY";
            this.rowQRY.Properties.FieldName = "QRY";
            this.rowQRY.Visible = false;
            // 
            // rowHspNoS
            // 
            this.rowHspNoS.Name = "rowHspNoS";
            this.rowHspNoS.Properties.Caption = "HspNo";
            this.rowHspNoS.Properties.FieldName = "HspNoS";
            // 
            // rowTrh1
            // 
            this.rowTrh1.Name = "rowTrh1";
            this.rowTrh1.Properties.Caption = "Trh >=";
            this.rowTrh1.Properties.FieldName = "Trh1";
            // 
            // rowTrh2
            // 
            this.rowTrh2.Name = "rowTrh2";
            this.rowTrh2.Properties.Caption = "Trh <";
            this.rowTrh2.Properties.FieldName = "Trh2";
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
            this.rowBKMS.Properties.Caption = "Bookmarks";
            this.rowBKMS.Properties.FieldName = "BKMS";
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(372, 575);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.qsvGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(364, 297);
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
            this.layoutControlItem2.Size = new System.Drawing.Size(364, 23);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 541);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(364, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.qryMemoEdit;
            this.layoutControlItem4.CustomizationFormText = "Query Text";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 320);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(59, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(364, 221);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Query Text";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
            // 
            // avbTableAdapter
            // 
            this.avbTableAdapter.ClearBeforeFill = true;
            // 
            // qsvAvbXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "qsvAvbXUC";
            this.Size = new System.Drawing.Size(372, 575);
            this.Load += new System.EventHandler(this.qsvAvbXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsAVBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit qryMemoEdit;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraVerticalGrid.VGridControl qsvGridControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private QryDataSet qryDataSet;
        private System.Windows.Forms.BindingSource qsAVBBindingSource;
        private Account.AccountDataSetTableAdapters.AVBTableAdapter avbTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAVBID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTur;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDrm;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAciklama;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowQRY;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowHspNoS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTrh1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTrh2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTAGS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBKMD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBKMS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSearchName;
    }
}

namespace tMax14.Qry
{
    partial class qsvJrnXUC
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
            this.qsJRNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryDataSet = new tMax14.Qry.QryDataSet();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.qsvGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.rowSearchName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowJRNID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowSTU = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPRVT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBKMS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBKMD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTAGS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMBRS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowUPDTS1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowUPDTS2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowREFTBL = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowREFID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowQRY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTKPTRH = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTXT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowInsUsr = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowUpdUsr = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.jrnTableAdapter = new tMax14.Jurnal.JurnalDataSetTableAdapters.JRNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsJRNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
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
            this.layoutControl1.Size = new System.Drawing.Size(296, 540);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // qryMemoEdit
            // 
            this.qryMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qsJRNBindingSource, "QRY", true));
            this.qryMemoEdit.Location = new System.Drawing.Point(6, 337);
            this.qryMemoEdit.Name = "qryMemoEdit";
            this.qryMemoEdit.Size = new System.Drawing.Size(284, 171);
            this.qryMemoEdit.StyleController = this.layoutControl1;
            this.qryMemoEdit.TabIndex = 5;
            this.qryMemoEdit.UseOptimizedRendering = true;
            // 
            // qsJRNBindingSource
            // 
            this.qsJRNBindingSource.DataMember = "qsJRN";
            this.qsJRNBindingSource.DataSource = this.qryDataSet;
            // 
            // qryDataSet
            // 
            this.qryDataSet.DataSetName = "QryDataSet";
            this.qryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 512);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(284, 22);
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
            this.dataNavigator1.DataSource = this.qsJRNBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(6, 6);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(284, 19);
            this.dataNavigator1.StyleController = this.layoutControl1;
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.dataNavigator1.TextStringFormat = "{0}/{1}";
            this.dataNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dataNavigator1_ButtonClick);
            // 
            // qsvGridControl
            // 
            this.qsvGridControl.DataSource = this.qsJRNBindingSource;
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
            this.rowJRNID,
            this.rowSTU,
            this.rowPRVT,
            this.rowBKMS,
            this.rowBKMD,
            this.rowTAGS,
            this.rowMBRS,
            this.rowUPDTS1,
            this.rowUPDTS2,
            this.rowREFTBL,
            this.rowREFID,
            this.rowQRY,
            this.rowTKPTRH,
            this.rowTXT,
            this.rowInsUsr,
            this.rowUpdUsr});
            this.qsvGridControl.Size = new System.Drawing.Size(284, 288);
            this.qsvGridControl.TabIndex = 0;
            this.qsvGridControl.CellValueChanging += new DevExpress.XtraVerticalGrid.Events.CellValueChangedEventHandler(this.qsvGridControl_CellValueChanging);
            this.qsvGridControl.HiddenEditor += new System.EventHandler(this.qsvGridControl_HiddenEditor);
            this.qsvGridControl.InitNewRecord += new DevExpress.XtraVerticalGrid.Events.RecordIndexEventHandler(this.qsvGridControl_InitNewRecord);
            this.qsvGridControl.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.qsvGridControl_EditorKeyDown);
            this.qsvGridControl.VisibleChanged += new System.EventHandler(this.qsvGridControl_VisibleChanged);
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
            // rowJRNID
            // 
            this.rowJRNID.Name = "rowJRNID";
            this.rowJRNID.Properties.Caption = "JurnalID";
            this.rowJRNID.Properties.FieldName = "JRNID";
            // 
            // rowSTU
            // 
            this.rowSTU.Name = "rowSTU";
            this.rowSTU.Properties.Caption = "Statu";
            this.rowSTU.Properties.FieldName = "STU";
            // 
            // rowPRVT
            // 
            this.rowPRVT.Name = "rowPRVT";
            this.rowPRVT.Properties.Caption = "Private";
            this.rowPRVT.Properties.FieldName = "PRVT";
            // 
            // rowBKMS
            // 
            this.rowBKMS.Name = "rowBKMS";
            this.rowBKMS.Properties.Caption = "Bookmarks";
            this.rowBKMS.Properties.FieldName = "BKMS";
            // 
            // rowBKMD
            // 
            this.rowBKMD.Name = "rowBKMD";
            this.rowBKMD.Properties.Caption = "Bookmarked";
            this.rowBKMD.Properties.FieldName = "BKMD";
            // 
            // rowTAGS
            // 
            this.rowTAGS.Name = "rowTAGS";
            this.rowTAGS.Properties.Caption = "TAGs";
            this.rowTAGS.Properties.FieldName = "TAGS";
            // 
            // rowMBRS
            // 
            this.rowMBRS.Name = "rowMBRS";
            this.rowMBRS.Properties.Caption = "Members";
            this.rowMBRS.Properties.FieldName = "MBRS";
            // 
            // rowUPDTS1
            // 
            this.rowUPDTS1.Name = "rowUPDTS1";
            this.rowUPDTS1.Properties.Caption = "EXD >=";
            this.rowUPDTS1.Properties.FieldName = "UPDTS1";
            // 
            // rowUPDTS2
            // 
            this.rowUPDTS2.Name = "rowUPDTS2";
            this.rowUPDTS2.Properties.Caption = "EXD <";
            this.rowUPDTS2.Properties.FieldName = "UPDTS2";
            // 
            // rowREFTBL
            // 
            this.rowREFTBL.Name = "rowREFTBL";
            this.rowREFTBL.Properties.Caption = "RefTBL";
            this.rowREFTBL.Properties.FieldName = "REFTBL";
            // 
            // rowREFID
            // 
            this.rowREFID.Name = "rowREFID";
            this.rowREFID.Properties.Caption = "RefID";
            this.rowREFID.Properties.FieldName = "REFID";
            // 
            // rowQRY
            // 
            this.rowQRY.Name = "rowQRY";
            this.rowQRY.Properties.Caption = "QueryTxt";
            this.rowQRY.Properties.FieldName = "QRY";
            this.rowQRY.Visible = false;
            // 
            // rowTKPTRH
            // 
            this.rowTKPTRH.Name = "rowTKPTRH";
            this.rowTKPTRH.Properties.Caption = "TakipTrh";
            this.rowTKPTRH.Properties.FieldName = "TKPTRH";
            // 
            // rowTXT
            // 
            this.rowTXT.Name = "rowTXT";
            this.rowTXT.Properties.Caption = "Sbj+Bdy Search";
            this.rowTXT.Properties.FieldName = "TXT";
            // 
            // rowInsUsr
            // 
            this.rowInsUsr.Name = "rowInsUsr";
            this.rowInsUsr.Properties.Caption = "OpenedBy";
            this.rowInsUsr.Properties.FieldName = "InsUsr";
            // 
            // rowUpdUsr
            // 
            this.rowUpdUsr.Name = "rowUpdUsr";
            this.rowUpdUsr.Properties.Caption = "ModifiedBy";
            this.rowUpdUsr.Properties.FieldName = "UpdUsr";
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(296, 540);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.qsvGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(288, 292);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
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
            this.layoutControlItem2.Size = new System.Drawing.Size(288, 23);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 506);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(288, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.qryMemoEdit;
            this.layoutControlItem4.CustomizationFormText = "Query Text";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 315);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(59, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(288, 191);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Query Text";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
            // 
            // jrnTableAdapter
            // 
            this.jrnTableAdapter.ClearBeforeFill = true;
            // 
            // qsvJrnXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "qsvJrnXUC";
            this.Size = new System.Drawing.Size(296, 540);
            this.Load += new System.EventHandler(this.qsvJrnXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsJRNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private QryDataSet qryDataSet;
        private System.Windows.Forms.BindingSource qsJRNBindingSource;
        private Jurnal.JurnalDataSetTableAdapters.JRNTableAdapter jrnTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSearchName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowJRNID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSTU;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPRVT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBKMS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBKMD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTAGS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMBRS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowUPDTS1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowUPDTS2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowREFTBL;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowREFID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowQRY;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTKPTRH;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTXT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowInsUsr;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowUpdUsr;
    }
}

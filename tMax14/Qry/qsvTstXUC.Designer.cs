namespace tMax14.Qry
{
    partial class qsvTstXUC
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
            this.tstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryDataSet = new tMax14.Qry.QryDataSet();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.qsvGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.rowSearchName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTSTID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFirma = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFrtTur = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFrtUlk = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowROT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMOT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowQRY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowAHTIDS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTYP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowSTU = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowOnyUsr = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowSlsUsr = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBKMS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTklfTrhGE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTklfTrhLT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmOrgUlkS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmDstUlkS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.tstTableAdapter = new tMax14.Teklif.TeklifDataSetTableAdapters.TSTTableAdapter();
            this.tsfTableAdapter = new tMax14.Teklif.TeklifDataSetTableAdapters.TSFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
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
            this.layoutControl1.Size = new System.Drawing.Size(361, 565);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // qryMemoEdit
            // 
            this.qryMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tstBindingSource, "QRY", true));
            this.qryMemoEdit.Location = new System.Drawing.Point(6, 356);
            this.qryMemoEdit.Name = "qryMemoEdit";
            this.qryMemoEdit.Size = new System.Drawing.Size(349, 177);
            this.qryMemoEdit.StyleController = this.layoutControl1;
            this.qryMemoEdit.TabIndex = 5;
            // 
            // tstBindingSource
            // 
            this.tstBindingSource.DataMember = "qsTST";
            this.tstBindingSource.DataSource = this.qryDataSet;
            // 
            // qryDataSet
            // 
            this.qryDataSet.DataSetName = "QryDataSet";
            this.qryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 537);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(349, 22);
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
            this.dataNavigator1.DataSource = this.tstBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(6, 6);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(349, 19);
            this.dataNavigator1.StyleController = this.layoutControl1;
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.dataNavigator1.TextStringFormat = "{0}/{1}";
            this.dataNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dataNavigator1_ButtonClick);
            // 
            // qsvGridControl
            // 
            this.qsvGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.qsvGridControl.DataSource = this.tstBindingSource;
            this.qsvGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.qsvGridControl.Location = new System.Drawing.Point(6, 29);
            this.qsvGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.qsvGridControl.Name = "qsvGridControl";
            this.qsvGridControl.OptionsView.FixRowHeaderPanelWidth = true;
            this.qsvGridControl.RecordWidth = 114;
            this.qsvGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.qsvGridControl.RowHeaderWidth = 86;
            this.qsvGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowSearchName,
            this.rowTSTID,
            this.rowFirma,
            this.rowFrtTur,
            this.rowFrtUlk,
            this.rowROT,
            this.rowMOT,
            this.rowQRY,
            this.rowAHTIDS,
            this.rowTYP,
            this.rowSTU,
            this.rowOnyUsr,
            this.rowSlsUsr,
            this.rowBKMS,
            this.rowTklfTrhGE,
            this.rowTklfTrhLT,
            this.rowmOrgUlkS,
            this.rowmDstUlkS});
            this.qsvGridControl.Size = new System.Drawing.Size(349, 302);
            this.qsvGridControl.TabIndex = 0;
            this.qsvGridControl.HiddenEditor += new System.EventHandler(this.qsvGridControl_HiddenEditor);
            this.qsvGridControl.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.qsvGridControl_EditorKeyDown);
            this.qsvGridControl.VisibleChanged += new System.EventHandler(this.qsvGridControl_VisibleChanged);
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // rowSearchName
            // 
            this.rowSearchName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rowSearchName.Appearance.Options.UseFont = true;
            this.rowSearchName.Name = "rowSearchName";
            this.rowSearchName.Properties.Caption = "Search Name";
            this.rowSearchName.Properties.FieldName = "SearchName";
            // 
            // rowTSTID
            // 
            this.rowTSTID.Name = "rowTSTID";
            this.rowTSTID.Properties.Caption = "TSTID";
            this.rowTSTID.Properties.FieldName = "TSTID";
            // 
            // rowFirma
            // 
            this.rowFirma.Name = "rowFirma";
            this.rowFirma.Properties.Caption = "Firma";
            this.rowFirma.Properties.FieldName = "Firma";
            // 
            // rowFrtTur
            // 
            this.rowFrtTur.Name = "rowFrtTur";
            this.rowFrtTur.Properties.Caption = "FirmaTür";
            this.rowFrtTur.Properties.FieldName = "FrtTur";
            // 
            // rowFrtUlk
            // 
            this.rowFrtUlk.Name = "rowFrtUlk";
            this.rowFrtUlk.Properties.Caption = "FirmaÜlk";
            this.rowFrtUlk.Properties.FieldName = "FrtUlk";
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
            // rowQRY
            // 
            this.rowQRY.Name = "rowQRY";
            this.rowQRY.Properties.Caption = "QRY";
            this.rowQRY.Properties.FieldName = "QRY";
            this.rowQRY.Visible = false;
            // 
            // rowAHTIDS
            // 
            this.rowAHTIDS.Name = "rowAHTIDS";
            this.rowAHTIDS.Properties.Caption = "Charges";
            this.rowAHTIDS.Properties.FieldName = "AHTIDS";
            // 
            // rowTYP
            // 
            this.rowTYP.Name = "rowTYP";
            this.rowTYP.Properties.Caption = "Typ";
            this.rowTYP.Properties.FieldName = "TYP";
            // 
            // rowSTU
            // 
            this.rowSTU.Name = "rowSTU";
            this.rowSTU.Properties.Caption = "Statu";
            this.rowSTU.Properties.FieldName = "STU";
            // 
            // rowOnyUsr
            // 
            this.rowOnyUsr.Name = "rowOnyUsr";
            this.rowOnyUsr.Properties.Caption = "OnyUsr";
            this.rowOnyUsr.Properties.FieldName = "OnyUsr";
            // 
            // rowSlsUsr
            // 
            this.rowSlsUsr.Name = "rowSlsUsr";
            this.rowSlsUsr.Properties.Caption = "SlsUsr";
            this.rowSlsUsr.Properties.FieldName = "SlsUsr";
            // 
            // rowBKMS
            // 
            this.rowBKMS.Name = "rowBKMS";
            this.rowBKMS.Properties.Caption = "Bokmark";
            this.rowBKMS.Properties.FieldName = "BKMS";
            // 
            // rowTklfTrhGE
            // 
            this.rowTklfTrhGE.Name = "rowTklfTrhGE";
            this.rowTklfTrhGE.Properties.Caption = "TklfTrh >=";
            this.rowTklfTrhGE.Properties.FieldName = "TklfTrhGE";
            // 
            // rowTklfTrhLT
            // 
            this.rowTklfTrhLT.Name = "rowTklfTrhLT";
            this.rowTklfTrhLT.Properties.Caption = "TklfTrh <";
            this.rowTklfTrhLT.Properties.FieldName = "TklfTrhLT";
            // 
            // rowmOrgUlkS
            // 
            this.rowmOrgUlkS.Height = 16;
            this.rowmOrgUlkS.Name = "rowmOrgUlkS";
            this.rowmOrgUlkS.Properties.Caption = "mOrgÜlk";
            this.rowmOrgUlkS.Properties.FieldName = "mOrgUlkS";
            // 
            // rowmDstUlkS
            // 
            this.rowmDstUlkS.Name = "rowmDstUlkS";
            this.rowmDstUlkS.Properties.Caption = "mDstÜlk";
            this.rowmDstUlkS.Properties.FieldName = "mDstUlkS";
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(361, 565);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.qsvGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(353, 306);
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
            this.layoutControlItem2.Size = new System.Drawing.Size(353, 23);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 531);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(353, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.qryMemoEdit;
            this.layoutControlItem4.CustomizationFormText = "Query Text";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 334);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(59, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(353, 197);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Query Text";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(0, 329);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(353, 5);
            // 
            // tstTableAdapter
            // 
            this.tstTableAdapter.ClearBeforeFill = true;
            // 
            // tsfTableAdapter
            // 
            this.tsfTableAdapter.ClearBeforeFill = true;
            // 
            // qsvTstXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "qsvTstXUC";
            this.Size = new System.Drawing.Size(361, 565);
            this.Load += new System.EventHandler(this.qsvTstXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
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
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private QryDataSet qryDataSet;
        private Teklif.TeklifDataSetTableAdapters.TSTTableAdapter tstTableAdapter;
        private System.Windows.Forms.BindingSource tstBindingSource;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSearchName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTSTID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFirma;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowROT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMOT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowQRY;
        private Teklif.TeklifDataSetTableAdapters.TSFTableAdapter tsfTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAHTIDS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTYP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBKMS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSTU;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowOnyUsr;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTklfTrhGE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTklfTrhLT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSlsUsr;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFrtTur;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFrtUlk;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowmOrgUlkS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowmDstUlkS;
    }
}

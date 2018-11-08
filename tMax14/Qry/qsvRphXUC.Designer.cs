namespace tMax14.Qry
{
    partial class qsvRphXUC
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.qryMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.qsRphBindingSource = new System.Windows.Forms.BindingSource();
            this.qryDataSet = new tMax14.Qry.QryDataSet();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.qsvGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.rowSearchName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRptKod = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowExdGE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowExdLT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRefTO = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRefID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFirma = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowUsr = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRspW = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRspDGE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRspDLT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowInfo = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowQRY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rphTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.RPHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsRphBindingSource)).BeginInit();
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
            this.layoutControl1.Size = new System.Drawing.Size(305, 532);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // qryMemoEdit
            // 
            this.qryMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qsRphBindingSource, "QRY", true));
            this.qryMemoEdit.Location = new System.Drawing.Point(6, 314);
            this.qryMemoEdit.Name = "qryMemoEdit";
            this.qryMemoEdit.Size = new System.Drawing.Size(293, 186);
            this.qryMemoEdit.StyleController = this.layoutControl1;
            this.qryMemoEdit.TabIndex = 5;
            // 
            // qsRphBindingSource
            // 
            this.qsRphBindingSource.DataMember = "qsRPH";
            this.qsRphBindingSource.DataSource = this.qryDataSet;
            // 
            // qryDataSet
            // 
            this.qryDataSet.DataSetName = "QryDataSet";
            this.qryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 504);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(293, 22);
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
            this.dataNavigator1.DataSource = this.qsRphBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(6, 6);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(293, 19);
            this.dataNavigator1.StyleController = this.layoutControl1;
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.dataNavigator1.TextStringFormat = "{0}/{1}";
            // 
            // qsvGridControl
            // 
            this.qsvGridControl.DataSource = this.qsRphBindingSource;
            this.qsvGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.qsvGridControl.Location = new System.Drawing.Point(6, 29);
            this.qsvGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.qsvGridControl.Name = "qsvGridControl";
            this.qsvGridControl.OptionsView.FixRowHeaderPanelWidth = true;
            this.qsvGridControl.RecordWidth = 118;
            this.qsvGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.qsvGridControl.RowHeaderWidth = 82;
            this.qsvGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowSearchName,
            this.rowRptKod,
            this.rowExdGE,
            this.rowExdLT,
            this.rowRefTO,
            this.rowRefID,
            this.rowFirma,
            this.rowUsr,
            this.rowRspW,
            this.rowRspDGE,
            this.rowRspDLT,
            this.rowInfo,
            this.rowQRY});
            this.qsvGridControl.Size = new System.Drawing.Size(293, 265);
            this.qsvGridControl.TabIndex = 0;
            this.qsvGridControl.HiddenEditor += new System.EventHandler(this.qsvGridControl_HiddenEditor);
            this.qsvGridControl.EditorKeyUp += new System.Windows.Forms.KeyEventHandler(this.qsvGridControl_EditorKeyUp);
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
            // rowRptKod
            // 
            this.rowRptKod.Name = "rowRptKod";
            this.rowRptKod.Properties.Caption = "Rpt Kod";
            this.rowRptKod.Properties.FieldName = "RptKod";
            // 
            // rowExdGE
            // 
            this.rowExdGE.Name = "rowExdGE";
            this.rowExdGE.Properties.Caption = "EXD >=";
            this.rowExdGE.Properties.FieldName = "ExdGE";
            // 
            // rowExdLT
            // 
            this.rowExdLT.Name = "rowExdLT";
            this.rowExdLT.Properties.Caption = "EXD <";
            this.rowExdLT.Properties.FieldName = "ExdLT";
            // 
            // rowRefTO
            // 
            this.rowRefTO.Height = 16;
            this.rowRefTO.Name = "rowRefTO";
            this.rowRefTO.Properties.Caption = "Ref TO";
            this.rowRefTO.Properties.FieldName = "RefTO";
            // 
            // rowRefID
            // 
            this.rowRefID.Name = "rowRefID";
            this.rowRefID.Properties.Caption = "Ref ID";
            this.rowRefID.Properties.FieldName = "RefID";
            // 
            // rowFirma
            // 
            this.rowFirma.Name = "rowFirma";
            this.rowFirma.Properties.Caption = "Firma";
            this.rowFirma.Properties.FieldName = "Firma";
            // 
            // rowUsr
            // 
            this.rowUsr.Name = "rowUsr";
            this.rowUsr.Properties.Caption = "Usr";
            this.rowUsr.Properties.FieldName = "Usr";
            // 
            // rowRspW
            // 
            this.rowRspW.Name = "rowRspW";
            this.rowRspW.Properties.Caption = "RspWating";
            this.rowRspW.Properties.FieldName = "RspW";
            // 
            // rowRspDGE
            // 
            this.rowRspDGE.Name = "rowRspDGE";
            this.rowRspDGE.Properties.Caption = "RspDate >=";
            this.rowRspDGE.Properties.FieldName = "RspDGE";
            // 
            // rowRspDLT
            // 
            this.rowRspDLT.Name = "rowRspDLT";
            this.rowRspDLT.Properties.Caption = "RspDate <";
            this.rowRspDLT.Properties.FieldName = "RspDLT";
            // 
            // rowInfo
            // 
            this.rowInfo.Name = "rowInfo";
            this.rowInfo.Properties.Caption = "Info";
            this.rowInfo.Properties.FieldName = "Info";
            // 
            // rowQRY
            // 
            this.rowQRY.Name = "rowQRY";
            this.rowQRY.Properties.Caption = "QRY";
            this.rowQRY.Properties.FieldName = "QRY";
            this.rowQRY.Visible = false;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(305, 532);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.qsvGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(297, 269);
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
            this.layoutControlItem2.Size = new System.Drawing.Size(297, 23);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 498);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(297, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.qryMemoEdit;
            this.layoutControlItem4.CustomizationFormText = "Query Text";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 292);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(297, 206);
            this.layoutControlItem4.Text = "Query Text";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
            // 
            // rphTableAdapter
            // 
            this.rphTableAdapter.ClearBeforeFill = true;
            // 
            // qsvRphXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "qsvRphXUC";
            this.Size = new System.Drawing.Size(305, 532);
            this.Load += new System.EventHandler(this.qsvRphXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsRphBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource qsRphBindingSource;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSearchName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRptKod;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowExdGE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowExdLT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRefTO;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRefID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowUsr;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRspW;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRspDGE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRspDLT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowInfo;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowQRY;
        private Genel.GenelDataSetTableAdapters.RPHTableAdapter rphTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFirma;
    }
}

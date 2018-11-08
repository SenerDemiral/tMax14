namespace tMax14.Qry
{
    partial class qsvFrtSalesRepXUC
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
            this.qryJrnMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.qsFrtSalesRepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryDataSet = new tMax14.Qry.QryDataSet();
            this.qryFrtMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.qsvGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.rowSearchName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFirmaFaliyet = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowJurnalTAG = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowJurnalUpdGE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowJurnalUpdLT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.frtSalesRepTableAdapter = new tMax14.Firma.FirmaDataSetTableAdapters.FRT_SALESREPTableAdapter();
            this.rowfQry = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowjQry = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryJrnMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsFrtSalesRepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryFrtMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.qryJrnMemoEdit);
            this.layoutControl1.Controls.Add(this.qryFrtMemoEdit);
            this.layoutControl1.Controls.Add(this.searchButton);
            this.layoutControl1.Controls.Add(this.dataNavigator1);
            this.layoutControl1.Controls.Add(this.qsvGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(477, 266, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(413, 373);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // qryJrnMemoEdit
            // 
            this.qryJrnMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qsFrtSalesRepBindingSource, "jQry", true));
            this.qryJrnMemoEdit.Location = new System.Drawing.Point(6, 263);
            this.qryJrnMemoEdit.Name = "qryJrnMemoEdit";
            this.qryJrnMemoEdit.Size = new System.Drawing.Size(401, 78);
            this.qryJrnMemoEdit.StyleController = this.layoutControl1;
            this.qryJrnMemoEdit.TabIndex = 6;
            // 
            // qsFrtSalesRepBindingSource
            // 
            this.qsFrtSalesRepBindingSource.DataMember = "qsFrtSalesRep";
            this.qsFrtSalesRepBindingSource.DataSource = this.qryDataSet;
            // 
            // qryDataSet
            // 
            this.qryDataSet.DataSetName = "QryDataSet";
            this.qryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qryFrtMemoEdit
            // 
            this.qryFrtMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qsFrtSalesRepBindingSource, "fQry", true));
            this.qryFrtMemoEdit.Location = new System.Drawing.Point(6, 169);
            this.qryFrtMemoEdit.Name = "qryFrtMemoEdit";
            this.qryFrtMemoEdit.Size = new System.Drawing.Size(401, 74);
            this.qryFrtMemoEdit.StyleController = this.layoutControl1;
            this.qryFrtMemoEdit.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 345);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(401, 22);
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
            this.dataNavigator1.Location = new System.Drawing.Point(6, 6);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(401, 19);
            this.dataNavigator1.StyleController = this.layoutControl1;
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.dataNavigator1.TextStringFormat = "{0}/{1}";
            // 
            // qsvGridControl
            // 
            this.qsvGridControl.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.qsvGridControl.DataSource = this.qsFrtSalesRepBindingSource;
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
            this.rowFirmaFaliyet,
            this.rowJurnalTAG,
            this.rowJurnalUpdGE,
            this.rowJurnalUpdLT,
            this.rowfQry,
            this.rowjQry});
            this.qsvGridControl.Size = new System.Drawing.Size(401, 120);
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
            this.rowSearchName.Name = "rowSearchName";
            this.rowSearchName.Properties.Caption = "Search Name";
            this.rowSearchName.Properties.FieldName = "SearchName";
            // 
            // rowFirmaFaliyet
            // 
            this.rowFirmaFaliyet.Name = "rowFirmaFaliyet";
            this.rowFirmaFaliyet.Properties.Caption = "Firma Faliyet";
            this.rowFirmaFaliyet.Properties.FieldName = "FirmaFaliyet";
            // 
            // rowJurnalTAG
            // 
            this.rowJurnalTAG.Name = "rowJurnalTAG";
            this.rowJurnalTAG.Properties.Caption = "Jurnal TAG";
            this.rowJurnalTAG.Properties.FieldName = "JurnalTAG";
            // 
            // rowJurnalUpdGE
            // 
            this.rowJurnalUpdGE.Name = "rowJurnalUpdGE";
            this.rowJurnalUpdGE.Properties.Caption = "Jurnal Upd GE";
            this.rowJurnalUpdGE.Properties.FieldName = "JurnalUpdGE";
            // 
            // rowJurnalUpdLT
            // 
            this.rowJurnalUpdLT.Name = "rowJurnalUpdLT";
            this.rowJurnalUpdLT.Properties.Caption = "Jurnal Upd LT";
            this.rowJurnalUpdLT.Properties.FieldName = "JurnalUpdLT";
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
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup1.Size = new System.Drawing.Size(413, 373);
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
            this.layoutControlItem1.Size = new System.Drawing.Size(405, 124);
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
            this.layoutControlItem2.Size = new System.Drawing.Size(405, 23);
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
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 339);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(405, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.qryFrtMemoEdit;
            this.layoutControlItem4.CustomizationFormText = "Query Text";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 147);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(405, 94);
            this.layoutControlItem4.Text = "Firma Query Text";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.qryJrnMemoEdit;
            this.layoutControlItem5.CustomizationFormText = "Jurnal Query Text";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 241);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(405, 98);
            this.layoutControlItem5.Text = "Jurnal Query Text";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(87, 13);
            // 
            // frtSalesRepTableAdapter
            // 
            this.frtSalesRepTableAdapter.ClearBeforeFill = true;
            // 
            // rowfQry
            // 
            this.rowfQry.Name = "rowfQry";
            this.rowfQry.Properties.FieldName = "fQry";
            this.rowfQry.Visible = false;
            // 
            // rowjQry
            // 
            this.rowjQry.Name = "rowjQry";
            this.rowjQry.Properties.FieldName = "jQry";
            this.rowjQry.Visible = false;
            // 
            // qsvFrtSalesRepXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "qsvFrtSalesRepXUC";
            this.Size = new System.Drawing.Size(413, 373);
            this.Load += new System.EventHandler(this.qsvFrtSalesRepXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryJrnMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsFrtSalesRepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryFrtMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit qryFrtMemoEdit;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraVerticalGrid.VGridControl qsvGridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource qsFrtSalesRepBindingSource;
        private QryDataSet qryDataSet;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSearchName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFirmaFaliyet;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowJurnalTAG;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowJurnalUpdGE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowJurnalUpdLT;
        private Firma.FirmaDataSetTableAdapters.FRT_SALESREPTableAdapter frtSalesRepTableAdapter;
        private DevExpress.XtraEditors.MemoEdit qryJrnMemoEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowfQry;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowjQry;
    }
}

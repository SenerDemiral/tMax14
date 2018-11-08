namespace tMax14.AccountETA
{
    partial class EtaFisXF
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.exportSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.fillSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.etaFisGridControl = new DevExpress.XtraGrid.GridControl();
            this.etaFisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acccountEtaDataSet = new tMax14.AccountETA.AcccountEtaDataSet();
            this.etaFisGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAVBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXML = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.etaFisTableAdapter = new tMax14.AccountETA.AcccountEtaDataSetTableAdapters.ETA_FISTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etaFisGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etaFisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acccountEtaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etaFisGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.exportSimpleButton);
            this.layoutControl1.Controls.Add(this.webBrowser1);
            this.layoutControl1.Controls.Add(this.fillSimpleButton);
            this.layoutControl1.Controls.Add(this.dateEdit2);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Controls.Add(this.etaFisGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(807, 460);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // exportSimpleButton
            // 
            this.exportSimpleButton.Location = new System.Drawing.Point(12, 426);
            this.exportSimpleButton.Name = "exportSimpleButton";
            this.exportSimpleButton.Size = new System.Drawing.Size(783, 22);
            this.exportSimpleButton.StyleController = this.layoutControl1;
            this.exportSimpleButton.TabIndex = 9;
            this.exportSimpleButton.Text = "Export ETA";
            this.exportSimpleButton.Click += new System.EventHandler(this.exportSimpleButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(24, 72);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(759, 338);
            this.webBrowser1.TabIndex = 8;
            // 
            // fillSimpleButton
            // 
            this.fillSimpleButton.Location = new System.Drawing.Point(274, 12);
            this.fillSimpleButton.Name = "fillSimpleButton";
            this.fillSimpleButton.Size = new System.Drawing.Size(521, 22);
            this.fillSimpleButton.StyleController = this.layoutControl1;
            this.fillSimpleButton.TabIndex = 7;
            this.fillSimpleButton.Text = "FILL";
            this.fillSimpleButton.Click += new System.EventHandler(this.fillSimpleButton_Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = new System.DateTime(2014, 12, 10, 10, 1, 56, 0);
            this.dateEdit2.Location = new System.Drawing.Point(186, 12);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(84, 20);
            this.dateEdit2.StyleController = this.layoutControl1;
            this.dateEdit2.TabIndex = 6;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(2014, 12, 1, 0, 0, 0, 0);
            this.dateEdit1.Location = new System.Drawing.Point(60, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(82, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 5;
            // 
            // etaFisGridControl
            // 
            this.etaFisGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.etaFisGridControl.DataSource = this.etaFisBindingSource;
            this.etaFisGridControl.Location = new System.Drawing.Point(24, 72);
            this.etaFisGridControl.MainView = this.etaFisGridView;
            this.etaFisGridControl.Name = "etaFisGridControl";
            this.etaFisGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.etaFisGridControl.Size = new System.Drawing.Size(759, 338);
            this.etaFisGridControl.TabIndex = 4;
            this.etaFisGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.etaFisGridView});
            // 
            // etaFisBindingSource
            // 
            this.etaFisBindingSource.DataMember = "ETA_FIS";
            this.etaFisBindingSource.DataSource = this.acccountEtaDataSet;
            // 
            // acccountEtaDataSet
            // 
            this.acccountEtaDataSet.DataSetName = "AcccountEtaDataSet";
            this.acccountEtaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etaFisGridView
            // 
            this.etaFisGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAVBID,
            this.colAVDID,
            this.colTRH,
            this.colXML,
            this.colOK});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[OK] == \'F\'  And [AVDID] == 0";
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "[OK] == \'F\'  And [AVDID] != 0";
            this.etaFisGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.etaFisGridView.GridControl = this.etaFisGridControl;
            this.etaFisGridView.Name = "etaFisGridView";
            this.etaFisGridView.OptionsBehavior.Editable = false;
            this.etaFisGridView.OptionsCustomization.AllowGroup = false;
            this.etaFisGridView.OptionsCustomization.AllowSort = false;
            this.etaFisGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.etaFisGridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.etaFisGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colAVBID
            // 
            this.colAVBID.FieldName = "AVBID";
            this.colAVBID.Name = "colAVBID";
            this.colAVBID.OptionsColumn.FixedWidth = true;
            this.colAVBID.Visible = true;
            this.colAVBID.VisibleIndex = 0;
            this.colAVBID.Width = 60;
            // 
            // colAVDID
            // 
            this.colAVDID.FieldName = "AVDID";
            this.colAVDID.Name = "colAVDID";
            this.colAVDID.OptionsColumn.FixedWidth = true;
            this.colAVDID.Visible = true;
            this.colAVDID.VisibleIndex = 1;
            this.colAVDID.Width = 60;
            // 
            // colTRH
            // 
            this.colTRH.FieldName = "TRH";
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.FixedWidth = true;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 2;
            this.colTRH.Width = 67;
            // 
            // colXML
            // 
            this.colXML.FieldName = "XML";
            this.colXML.Name = "colXML";
            this.colXML.Visible = true;
            this.colXML.VisibleIndex = 3;
            this.colXML.Width = 514;
            // 
            // colOK
            // 
            this.colOK.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colOK.FieldName = "OK";
            this.colOK.Name = "colOK";
            this.colOK.OptionsColumn.FixedWidth = true;
            this.colOK.Visible = true;
            this.colOK.VisibleIndex = 4;
            this.colOK.Width = 30;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = "T";
            this.repositoryItemCheckEdit1.ValueUnchecked = "F";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.tabbedControlGroup1,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(807, 460);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEdit1;
            this.layoutControlItem2.CustomizationFormText = "Tarih >=";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(134, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(134, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(134, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Tarih >=";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(43, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateEdit2;
            this.layoutControlItem3.CustomizationFormText = "Tarih <";
            this.layoutControlItem3.Location = new System.Drawing.Point(134, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(128, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(128, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(128, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Tarih <";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(35, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.fillSimpleButton;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(262, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(525, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1";
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 26);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(787, 388);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(763, 342);
            this.layoutControlGroup2.Text = "Grid";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.etaFisGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(763, 342);
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(763, 342);
            this.layoutControlGroup3.Text = "XML";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.webBrowser1;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(763, 342);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.exportSimpleButton;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 414);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(787, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // etaFisTableAdapter
            // 
            this.etaFisTableAdapter.ClearBeforeFill = true;
            // 
            // EtaFisXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 460);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EtaFisXF";
            this.Text = "EtaFisXF";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etaFisGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etaFisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acccountEtaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etaFisGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private AcccountEtaDataSet acccountEtaDataSet;
        private System.Windows.Forms.BindingSource etaFisBindingSource;
        private AcccountEtaDataSetTableAdapters.ETA_FISTableAdapter etaFisTableAdapter;
        private DevExpress.XtraGrid.GridControl etaFisGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView etaFisGridView;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton fillSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colAVBID;
        private DevExpress.XtraGrid.Columns.GridColumn colAVDID;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colXML;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colOK;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton exportSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
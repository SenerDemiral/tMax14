namespace tMax14ReportClassLibrary
{
    partial class TopluFaturaXF
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
            this.reportDataSet = new tMax14ReportClassLibrary.ReportDataSet();
            this.rprTopluFaturaBindingSource = new System.Windows.Forms.BindingSource();
            this.rprTopluFaturaTableAdapter = new tMax14ReportClassLibrary.ReportDataSetTableAdapters.RPR_TOPLUFATURATableAdapter();
            this.tableAdapterManager = new tMax14ReportClassLibrary.ReportDataSetTableAdapters.TableAdapterManager();
            this.rtfGridControl = new DevExpress.XtraGrid.GridControl();
            this.rtfGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTAFBIDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAILS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ftrSklImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.eMailBodyRichEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.eMailSubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.stuLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.sendSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rptGetTableAdapter = new tMax14ReportClassLibrary.ReportDataSetTableAdapters.RPT_GETTableAdapter();
            this.reportQueriesTableAdapter = new tMax14ReportClassLibrary.ReportDataSetTableAdapters.ReportQueriesTableAdapter();
            this.docSelDetTableAdapter = new tMax14ReportClassLibrary.ReportDataSetTableAdapters.DOC_SEL_DETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rprTopluFaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtfGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtfGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftrSklImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMailSubjectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rprTopluFaturaBindingSource
            // 
            this.rprTopluFaturaBindingSource.DataMember = "RPR_TOPLUFATURA";
            this.rprTopluFaturaBindingSource.DataSource = this.reportDataSet;
            // 
            // rprTopluFaturaTableAdapter
            // 
            this.rprTopluFaturaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = tMax14ReportClassLibrary.ReportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rtfGridControl
            // 
            this.rtfGridControl.DataSource = this.rprTopluFaturaBindingSource;
            this.rtfGridControl.Location = new System.Drawing.Point(12, 12);
            this.rtfGridControl.MainView = this.rtfGridView;
            this.rtfGridControl.Name = "rtfGridControl";
            this.rtfGridControl.Size = new System.Drawing.Size(745, 193);
            this.rtfGridControl.TabIndex = 2;
            this.rtfGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rtfGridView});
            // 
            // rtfGridView
            // 
            this.rtfGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFRTID,
            this.colFRTAD,
            this.colFRTAFBIDS,
            this.colEMAILS});
            this.rtfGridView.GridControl = this.rtfGridControl;
            this.rtfGridView.Name = "rtfGridView";
            this.rtfGridView.OptionsBehavior.Editable = false;
            this.rtfGridView.OptionsCustomization.AllowFilter = false;
            this.rtfGridView.OptionsCustomization.AllowGroup = false;
            this.rtfGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.OptionsColumn.FixedWidth = true;
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 0;
            // 
            // colFRTAD
            // 
            this.colFRTAD.Caption = "Firma";
            this.colFRTAD.FieldName = "FRTAD";
            this.colFRTAD.Name = "colFRTAD";
            this.colFRTAD.OptionsColumn.FixedWidth = true;
            this.colFRTAD.Visible = true;
            this.colFRTAD.VisibleIndex = 1;
            this.colFRTAD.Width = 153;
            // 
            // colFRTAFBIDS
            // 
            this.colFRTAFBIDS.Caption = "Faturalar";
            this.colFRTAFBIDS.FieldName = "FRTAFBIDS";
            this.colFRTAFBIDS.Name = "colFRTAFBIDS";
            this.colFRTAFBIDS.Visible = true;
            this.colFRTAFBIDS.VisibleIndex = 2;
            this.colFRTAFBIDS.Width = 273;
            // 
            // colEMAILS
            // 
            this.colEMAILS.Caption = "eMail";
            this.colEMAILS.FieldName = "EMAILS";
            this.colEMAILS.Name = "colEMAILS";
            this.colEMAILS.Visible = true;
            this.colEMAILS.VisibleIndex = 3;
            this.colEMAILS.Width = 273;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ftrSklImageComboBoxEdit);
            this.layoutControl1.Controls.Add(this.eMailBodyRichEditControl);
            this.layoutControl1.Controls.Add(this.eMailSubjectTextEdit);
            this.layoutControl1.Controls.Add(this.stuLabelControl);
            this.layoutControl1.Controls.Add(this.sendSimpleButton);
            this.layoutControl1.Controls.Add(this.rtfGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(919, 317, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(769, 569);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ftrSklImageComboBoxEdit
            // 
            this.ftrSklImageComboBoxEdit.EditValue = "2";
            this.ftrSklImageComboBoxEdit.Location = new System.Drawing.Point(71, 209);
            this.ftrSklImageComboBoxEdit.Name = "ftrSklImageComboBoxEdit";
            this.ftrSklImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ftrSklImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Ticari Fatura", "1", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("YurtDışı Draft", "2", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Marken", "3", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Ticari Fatura 2", "4", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Marken Fatura", "5", -1)});
            this.ftrSklImageComboBoxEdit.Size = new System.Drawing.Size(686, 20);
            this.ftrSklImageComboBoxEdit.StyleController = this.layoutControl1;
            this.ftrSklImageComboBoxEdit.TabIndex = 16;
            // 
            // eMailBodyRichEditControl
            // 
            this.eMailBodyRichEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.eMailBodyRichEditControl.EnableToolTips = true;
            this.eMailBodyRichEditControl.Location = new System.Drawing.Point(12, 273);
            this.eMailBodyRichEditControl.Name = "eMailBodyRichEditControl";
            this.eMailBodyRichEditControl.Options.Bookmarks.AllowNameResolution = false;
            this.eMailBodyRichEditControl.Size = new System.Drawing.Size(745, 238);
            this.eMailBodyRichEditControl.TabIndex = 14;
            this.eMailBodyRichEditControl.Text = "richEditControl1";
            // 
            // eMailSubjectTextEdit
            // 
            this.eMailSubjectTextEdit.Location = new System.Drawing.Point(71, 233);
            this.eMailSubjectTextEdit.Name = "eMailSubjectTextEdit";
            this.eMailSubjectTextEdit.Size = new System.Drawing.Size(686, 20);
            this.eMailSubjectTextEdit.StyleController = this.layoutControl1;
            this.eMailSubjectTextEdit.TabIndex = 13;
            // 
            // stuLabelControl
            // 
            this.stuLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stuLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.stuLabelControl.Location = new System.Drawing.Point(12, 541);
            this.stuLabelControl.Name = "stuLabelControl";
            this.stuLabelControl.Size = new System.Drawing.Size(745, 16);
            this.stuLabelControl.StyleController = this.layoutControl1;
            this.stuLabelControl.TabIndex = 12;
            // 
            // sendSimpleButton
            // 
            this.sendSimpleButton.Location = new System.Drawing.Point(12, 515);
            this.sendSimpleButton.Name = "sendSimpleButton";
            this.sendSimpleButton.Size = new System.Drawing.Size(745, 22);
            this.sendSimpleButton.StyleController = this.layoutControl1;
            this.sendSimpleButton.TabIndex = 4;
            this.sendSimpleButton.Text = "Send eMail";
            this.sendSimpleButton.Click += new System.EventHandler(this.sendSimpleButton_Click);
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
            this.layoutControlItem5,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(769, 569);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rtfGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(749, 197);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sendSimpleButton;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 503);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(749, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.stuLabelControl;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 529);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(749, 20);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.eMailSubjectTextEdit;
            this.layoutControlItem4.CustomizationFormText = "Subject";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 221);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(749, 24);
            this.layoutControlItem4.Text = "Subject";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.eMailBodyRichEditControl;
            this.layoutControlItem5.CustomizationFormText = "Body";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 245);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(749, 258);
            this.layoutControlItem5.Text = "Body";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.ftrSklImageComboBoxEdit;
            this.layoutControlItem7.CustomizationFormText = "Fatura Şekli";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 197);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(749, 24);
            this.layoutControlItem7.Text = "Fatura Şekli";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(56, 13);
            // 
            // rptGetTableAdapter
            // 
            this.rptGetTableAdapter.ClearBeforeFill = true;
            // 
            // docSelDetTableAdapter
            // 
            this.docSelDetTableAdapter.ClearBeforeFill = true;
            // 
            // TopluFaturaXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 569);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TopluFaturaXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopluFaturaXF";
            this.Load += new System.EventHandler(this.TopluFaturaXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rprTopluFaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtfGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtfGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ftrSklImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMailSubjectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource rprTopluFaturaBindingSource;
        private ReportDataSetTableAdapters.RPR_TOPLUFATURATableAdapter rprTopluFaturaTableAdapter;
        private ReportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl rtfGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView rtfGridView;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTAD;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTAFBIDS;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAILS;
        private DevExpress.XtraEditors.SimpleButton sendSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private ReportDataSetTableAdapters.RPT_GETTableAdapter rptGetTableAdapter;
        private DevExpress.XtraEditors.LabelControl stuLabelControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private ReportDataSetTableAdapters.ReportQueriesTableAdapter reportQueriesTableAdapter;
        private DevExpress.XtraRichEdit.RichEditControl eMailBodyRichEditControl;
        private DevExpress.XtraEditors.TextEdit eMailSubjectTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ImageComboBoxEdit ftrSklImageComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private ReportDataSetTableAdapters.DOC_SEL_DETTableAdapter docSelDetTableAdapter;
    }
}
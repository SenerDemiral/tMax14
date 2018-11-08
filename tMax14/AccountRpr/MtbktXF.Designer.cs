namespace tMax14.AccountRpr
{
    partial class MtbktXF
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.colSendStatu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.accountRprDataSet = new tMax14.AccountRpr.AccountRprDataSet();
            this.mtbktGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printTekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMailTekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eMailHepsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaMutabakatHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accMtbktListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtbktGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAILS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendMsj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accMtbktListTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.ACC_MTBKT_LISTTableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.turRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.eMailSubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.eMailBodyRichEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.fillSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Tür = new DevExpress.XtraLayout.LayoutControlItem();
            this.rptGetTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.RPT_GETTableAdapter();
            this.accountRprQueriesTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.AccountRprQueriesTableAdapter();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtbktGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accMtbktListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtbktGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMailSubjectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tür)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // colSendStatu
            // 
            this.colSendStatu.Caption = "Send Statu";
            this.colSendStatu.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colSendStatu.FieldName = "SendStatu";
            this.colSendStatu.Name = "colSendStatu";
            this.colSendStatu.OptionsColumn.AllowEdit = false;
            this.colSendStatu.Visible = true;
            this.colSendStatu.VisibleIndex = 5;
            this.colSendStatu.Width = 95;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Göderilecek", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Gönderildi", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Gönderilemez", 2, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Gönderilemedi", 3, -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // accountRprDataSet
            // 
            this.accountRprDataSet.DataSetName = "AccountRprDataSet";
            this.accountRprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mtbktGridControl
            // 
            this.mtbktGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.mtbktGridControl.DataSource = this.accMtbktListBindingSource;
            this.mtbktGridControl.Location = new System.Drawing.Point(12, 41);
            this.mtbktGridControl.MainView = this.mtbktGridView;
            this.mtbktGridControl.Name = "mtbktGridControl";
            this.mtbktGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.mtbktGridControl.Size = new System.Drawing.Size(1161, 385);
            this.mtbktGridControl.TabIndex = 1;
            this.mtbktGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mtbktGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printTekToolStripMenuItem,
            this.eMailTekToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.eMailHepsiToolStripMenuItem,
            this.firmaMutabakatHistoryToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(206, 120);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // printTekToolStripMenuItem
            // 
            this.printTekToolStripMenuItem.Name = "printTekToolStripMenuItem";
            this.printTekToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.printTekToolStripMenuItem.Text = "Print (Tek)";
            this.printTekToolStripMenuItem.Click += new System.EventHandler(this.printTekToolStripMenuItem_Click);
            // 
            // eMailTekToolStripMenuItem
            // 
            this.eMailTekToolStripMenuItem.Name = "eMailTekToolStripMenuItem";
            this.eMailTekToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.eMailTekToolStripMenuItem.Text = "eMail (Tek)";
            this.eMailTekToolStripMenuItem.Click += new System.EventHandler(this.eMailTekToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // eMailHepsiToolStripMenuItem
            // 
            this.eMailHepsiToolStripMenuItem.Name = "eMailHepsiToolStripMenuItem";
            this.eMailHepsiToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.eMailHepsiToolStripMenuItem.Text = "eMail (Seçilenlere)";
            this.eMailHepsiToolStripMenuItem.Click += new System.EventHandler(this.eMailHepsiToolStripMenuItem_Click);
            // 
            // firmaMutabakatHistoryToolStripMenuItem
            // 
            this.firmaMutabakatHistoryToolStripMenuItem.Name = "firmaMutabakatHistoryToolStripMenuItem";
            this.firmaMutabakatHistoryToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.firmaMutabakatHistoryToolStripMenuItem.Text = "Firma Mutabakat History";
            this.firmaMutabakatHistoryToolStripMenuItem.Click += new System.EventHandler(this.firmaMutabakatHistoryToolStripMenuItem_Click);
            // 
            // accMtbktListBindingSource
            // 
            this.accMtbktListBindingSource.DataMember = "ACC_MTBKT_LIST";
            this.accMtbktListBindingSource.DataSource = this.accountRprDataSet;
            // 
            // mtbktGridView
            // 
            this.mtbktGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFRTID,
            this.colFRTAD,
            this.colTUTS,
            this.colEMAILS,
            this.colSendMail,
            this.colSendStatu,
            this.colSendMsj});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colSendStatu;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.PredefinedName = "Red Fill";
            formatConditionRuleValue1.Value1 = 3;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.colSendStatu;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.PredefinedName = "Red Text";
            formatConditionRuleValue2.Value1 = 2;
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.mtbktGridView.FormatRules.Add(gridFormatRule1);
            this.mtbktGridView.FormatRules.Add(gridFormatRule2);
            this.mtbktGridView.GridControl = this.mtbktGridControl;
            this.mtbktGridView.Name = "mtbktGridView";
            this.mtbktGridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.mtbktGridView.OptionsView.ShowGroupPanel = false;
            this.mtbktGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.mtbktGridView_ShowingEditor);
            this.mtbktGridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.mtbktGridView_CellValueChanging);
            this.mtbktGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.mtbktGridView_ValidateRow);
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.OptionsColumn.AllowEdit = false;
            this.colFRTID.OptionsColumn.FixedWidth = true;
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 0;
            this.colFRTID.Width = 60;
            // 
            // colFRTAD
            // 
            this.colFRTAD.Caption = "Firma";
            this.colFRTAD.FieldName = "FRTAD";
            this.colFRTAD.Name = "colFRTAD";
            this.colFRTAD.OptionsColumn.AllowEdit = false;
            this.colFRTAD.OptionsColumn.FixedWidth = true;
            this.colFRTAD.Visible = true;
            this.colFRTAD.VisibleIndex = 1;
            this.colFRTAD.Width = 120;
            // 
            // colTUTS
            // 
            this.colTUTS.Caption = "Tutar";
            this.colTUTS.FieldName = "TUTS";
            this.colTUTS.Name = "colTUTS";
            this.colTUTS.OptionsColumn.AllowEdit = false;
            this.colTUTS.Visible = true;
            this.colTUTS.VisibleIndex = 2;
            this.colTUTS.Width = 297;
            // 
            // colEMAILS
            // 
            this.colEMAILS.Caption = "eMail";
            this.colEMAILS.FieldName = "EMAILS";
            this.colEMAILS.Name = "colEMAILS";
            this.colEMAILS.OptionsColumn.AllowEdit = false;
            this.colEMAILS.Visible = true;
            this.colEMAILS.VisibleIndex = 3;
            this.colEMAILS.Width = 300;
            // 
            // colSendMail
            // 
            this.colSendMail.FieldName = "SendMail";
            this.colSendMail.Name = "colSendMail";
            this.colSendMail.Visible = true;
            this.colSendMail.VisibleIndex = 4;
            this.colSendMail.Width = 69;
            // 
            // colSendMsj
            // 
            this.colSendMsj.Caption = "Send Error";
            this.colSendMsj.FieldName = "SendMsj";
            this.colSendMsj.Name = "colSendMsj";
            this.colSendMsj.OptionsColumn.AllowEdit = false;
            this.colSendMsj.Visible = true;
            this.colSendMsj.VisibleIndex = 6;
            this.colSendMsj.Width = 202;
            // 
            // accMtbktListTableAdapter
            // 
            this.accMtbktListTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dateEdit2);
            this.layoutControl1.Controls.Add(this.turRadioGroup);
            this.layoutControl1.Controls.Add(this.eMailSubjectTextEdit);
            this.layoutControl1.Controls.Add(this.eMailBodyRichEditControl);
            this.layoutControl1.Controls.Add(this.fillSimpleButton);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Controls.Add(this.mtbktGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1185, 589);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // turRadioGroup
            // 
            this.turRadioGroup.EditValue = "1";
            this.turRadioGroup.Location = new System.Drawing.Point(386, 12);
            this.turRadioGroup.Name = "turRadioGroup";
            this.turRadioGroup.Properties.Columns = 2;
            this.turRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Mutabakat"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Mutabakat+BaBs")});
            this.turRadioGroup.Size = new System.Drawing.Size(259, 25);
            this.turRadioGroup.StyleController = this.layoutControl1;
            this.turRadioGroup.TabIndex = 16;
            // 
            // eMailSubjectTextEdit
            // 
            this.eMailSubjectTextEdit.Location = new System.Drawing.Point(80, 430);
            this.eMailSubjectTextEdit.Name = "eMailSubjectTextEdit";
            this.eMailSubjectTextEdit.Size = new System.Drawing.Size(1093, 20);
            this.eMailSubjectTextEdit.StyleController = this.layoutControl1;
            this.eMailSubjectTextEdit.TabIndex = 14;
            // 
            // eMailBodyRichEditControl
            // 
            this.eMailBodyRichEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.eMailBodyRichEditControl.Location = new System.Drawing.Point(12, 472);
            this.eMailBodyRichEditControl.Name = "eMailBodyRichEditControl";
            this.eMailBodyRichEditControl.Size = new System.Drawing.Size(1161, 105);
            this.eMailBodyRichEditControl.TabIndex = 15;
            this.eMailBodyRichEditControl.Text = "richEditControl1";
            // 
            // fillSimpleButton
            // 
            this.fillSimpleButton.Location = new System.Drawing.Point(649, 12);
            this.fillSimpleButton.Name = "fillSimpleButton";
            this.fillSimpleButton.Size = new System.Drawing.Size(524, 22);
            this.fillSimpleButton.StyleController = this.layoutControl1;
            this.fillSimpleButton.TabIndex = 5;
            this.fillSimpleButton.Text = "FILL";
            this.fillSimpleButton.Click += new System.EventHandler(this.fillSimpleButton_Click);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(72, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(89, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.Tür,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1185, 589);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mtbktGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1165, 389);
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(153, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(153, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(153, 29);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Tarih <=";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.fillSimpleButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(637, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(528, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.eMailBodyRichEditControl;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 442);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1165, 127);
            this.layoutControlItem4.Text = "eMail Body";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(51, 13);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.eMailSubjectTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 418);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1165, 24);
            this.layoutControlItem5.Text = "eMail Subject";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(63, 13);
            this.layoutControlItem5.TextToControlDistance = 5;
            // 
            // Tür
            // 
            this.Tür.Control = this.turRadioGroup;
            this.Tür.Location = new System.Drawing.Point(314, 0);
            this.Tür.Name = "Tür";
            this.Tür.Size = new System.Drawing.Size(323, 29);
            this.Tür.TextSize = new System.Drawing.Size(57, 13);
            // 
            // rptGetTableAdapter
            // 
            this.rptGetTableAdapter.ClearBeforeFill = true;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(225, 12);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(97, 20);
            this.dateEdit2.StyleController = this.layoutControl1;
            this.dateEdit2.TabIndex = 17;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dateEdit2;
            this.layoutControlItem6.Location = new System.Drawing.Point(153, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(161, 29);
            this.layoutControlItem6.Text = "SonMtbkTrh";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(57, 13);
            // 
            // MtbktXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 589);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MtbktXF";
            this.Text = "MtbktXF";
            this.Load += new System.EventHandler(this.MtbktXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtbktGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accMtbktListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtbktGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.turRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMailSubjectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tür)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountRprDataSet accountRprDataSet;
        private DevExpress.XtraGrid.GridControl mtbktGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView mtbktGridView;
        private System.Windows.Forms.BindingSource accMtbktListBindingSource;
        private AccountRprDataSetTableAdapters.ACC_MTBKT_LISTTableAdapter accMtbktListTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTS;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAILS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem printTekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMailTekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMailHepsiToolStripMenuItem;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton fillSimpleButton;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colSendMail;
        private DevExpress.XtraGrid.Columns.GridColumn colSendStatu;
        private DevExpress.XtraGrid.Columns.GridColumn colSendMsj;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private AccountRprDataSetTableAdapters.RPT_GETTableAdapter rptGetTableAdapter;
        private DevExpress.XtraRichEdit.RichEditControl eMailBodyRichEditControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit eMailSubjectTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private AccountRprDataSetTableAdapters.AccountRprQueriesTableAdapter accountRprQueriesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraEditors.RadioGroup turRadioGroup;
        private DevExpress.XtraLayout.LayoutControlItem Tür;
        private System.Windows.Forms.ToolStripMenuItem firmaMutabakatHistoryToolStripMenuItem;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
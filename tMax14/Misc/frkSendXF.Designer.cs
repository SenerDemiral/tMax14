namespace tMax14.Misc
{
    partial class frkSendXF
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
            this.miscDataSet = new tMax14.Misc.MiscDataSet();
            this.frkKmpnyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frkKmpnyTableAdapter = new tMax14.Misc.MiscDataSetTableAdapters.FRK_KMPNYTableAdapter();
            this.frkKmpnyGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mailGonderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frkKmpnyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAILS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendStatu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mailStatuRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colSendMsj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptGetTableAdapter = new tMax14.Misc.MiscDataSetTableAdapters.RPT_GETTableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.eMailSubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.miscQueriesTableAdapter = new tMax14.Misc.MiscDataSetTableAdapters.MiscQueriesTableAdapter();
            this.docSelDetTableAdapter = new tMax14.Misc.MiscDataSetTableAdapters.DOC_SEL_DETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.miscDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frkKmpnyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frkKmpnyGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frkKmpnyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailStatuRepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMailSubjectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // miscDataSet
            // 
            this.miscDataSet.DataSetName = "MiscDataSet";
            this.miscDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frkKmpnyBindingSource
            // 
            this.frkKmpnyBindingSource.DataMember = "FRK_KMPNY";
            this.frkKmpnyBindingSource.DataSource = this.miscDataSet;
            // 
            // frkKmpnyTableAdapter
            // 
            this.frkKmpnyTableAdapter.ClearBeforeFill = true;
            // 
            // frkKmpnyGridControl
            // 
            this.frkKmpnyGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.frkKmpnyGridControl.DataSource = this.frkKmpnyBindingSource;
            this.frkKmpnyGridControl.Location = new System.Drawing.Point(12, 12);
            this.frkKmpnyGridControl.MainView = this.frkKmpnyGridView;
            this.frkKmpnyGridControl.Name = "frkKmpnyGridControl";
            this.frkKmpnyGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.mailStatuRepositoryItemImageComboBox});
            this.frkKmpnyGridControl.Size = new System.Drawing.Size(767, 386);
            this.frkKmpnyGridControl.TabIndex = 0;
            this.frkKmpnyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.frkKmpnyGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailGonderToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(139, 48);
            // 
            // mailGonderToolStripMenuItem
            // 
            this.mailGonderToolStripMenuItem.Name = "mailGonderToolStripMenuItem";
            this.mailGonderToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.mailGonderToolStripMenuItem.Text = "Mail gonder";
            this.mailGonderToolStripMenuItem.Click += new System.EventHandler(this.mailGonderToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // frkKmpnyGridView
            // 
            this.frkKmpnyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFRTID,
            this.colFRTAD,
            this.colEMAILS,
            this.colSendMail,
            this.colSendStatu,
            this.colSendMsj});
            this.frkKmpnyGridView.GridControl = this.frkKmpnyGridControl;
            this.frkKmpnyGridView.Name = "frkKmpnyGridView";
            this.frkKmpnyGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.frkKmpnyGridView.OptionsView.ShowFooter = true;
            this.frkKmpnyGridView.OptionsView.ShowGroupPanel = false;
            this.frkKmpnyGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.frkKmpnyGridView_ShowingEditor);
            this.frkKmpnyGridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.frkKmpnyGridView_CellValueChanging);
            this.frkKmpnyGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.frkKmpnyGridView_ValidateRow);
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.OptionsColumn.AllowEdit = false;
            this.colFRTID.OptionsColumn.FixedWidth = true;
            this.colFRTID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FRTID", "{0}")});
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
            this.colFRTAD.Visible = true;
            this.colFRTAD.VisibleIndex = 1;
            this.colFRTAD.Width = 148;
            // 
            // colEMAILS
            // 
            this.colEMAILS.Caption = "eMails";
            this.colEMAILS.FieldName = "EMAILS";
            this.colEMAILS.Name = "colEMAILS";
            this.colEMAILS.OptionsColumn.AllowEdit = false;
            this.colEMAILS.Visible = true;
            this.colEMAILS.VisibleIndex = 2;
            this.colEMAILS.Width = 148;
            // 
            // colSendMail
            // 
            this.colSendMail.FieldName = "SendMail";
            this.colSendMail.Name = "colSendMail";
            this.colSendMail.OptionsColumn.FixedWidth = true;
            this.colSendMail.Visible = true;
            this.colSendMail.VisibleIndex = 3;
            this.colSendMail.Width = 56;
            // 
            // colSendStatu
            // 
            this.colSendStatu.ColumnEdit = this.mailStatuRepositoryItemImageComboBox;
            this.colSendStatu.FieldName = "SendStatu";
            this.colSendStatu.Name = "colSendStatu";
            this.colSendStatu.OptionsColumn.AllowEdit = false;
            this.colSendStatu.OptionsColumn.FixedWidth = true;
            this.colSendStatu.Visible = true;
            this.colSendStatu.VisibleIndex = 4;
            this.colSendStatu.Width = 80;
            // 
            // mailStatuRepositoryItemImageComboBox
            // 
            this.mailStatuRepositoryItemImageComboBox.AutoHeight = false;
            this.mailStatuRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mailStatuRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Gönderilecek", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Gönderildi", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Gönderilemez", 2, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Gönderilemedi", 3, -1)});
            this.mailStatuRepositoryItemImageComboBox.Name = "mailStatuRepositoryItemImageComboBox";
            // 
            // colSendMsj
            // 
            this.colSendMsj.FieldName = "SendMsj";
            this.colSendMsj.Name = "colSendMsj";
            this.colSendMsj.OptionsColumn.AllowEdit = false;
            this.colSendMsj.Visible = true;
            this.colSendMsj.VisibleIndex = 5;
            this.colSendMsj.Width = 257;
            // 
            // rptGetTableAdapter
            // 
            this.rptGetTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.eMailSubjectTextEdit);
            this.layoutControl1.Controls.Add(this.frkKmpnyGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(791, 434);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // eMailSubjectTextEdit
            // 
            this.eMailSubjectTextEdit.Location = new System.Drawing.Point(80, 402);
            this.eMailSubjectTextEdit.Name = "eMailSubjectTextEdit";
            this.eMailSubjectTextEdit.Size = new System.Drawing.Size(699, 20);
            this.eMailSubjectTextEdit.StyleController = this.layoutControl1;
            this.eMailSubjectTextEdit.TabIndex = 15;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(791, 434);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.frkKmpnyGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(771, 390);
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.eMailSubjectTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 390);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(771, 24);
            this.layoutControlItem2.Text = "eMail Subject";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(63, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // docSelDetTableAdapter
            // 
            this.docSelDetTableAdapter.ClearBeforeFill = true;
            // 
            // frkSendXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 434);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frkSendXF";
            this.Text = "frkSendXF";
            this.Load += new System.EventHandler(this.frkSendXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miscDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frkKmpnyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frkKmpnyGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frkKmpnyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailStatuRepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eMailSubjectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MiscDataSet miscDataSet;
        private System.Windows.Forms.BindingSource frkKmpnyBindingSource;
        private MiscDataSetTableAdapters.FRK_KMPNYTableAdapter frkKmpnyTableAdapter;
        private DevExpress.XtraGrid.GridControl frkKmpnyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView frkKmpnyGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTAD;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAILS;
        private DevExpress.XtraGrid.Columns.GridColumn colSendMail;
        private DevExpress.XtraGrid.Columns.GridColumn colSendStatu;
        private DevExpress.XtraGrid.Columns.GridColumn colSendMsj;
        private MiscDataSetTableAdapters.RPT_GETTableAdapter rptGetTableAdapter;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit eMailSubjectTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mailGonderToolStripMenuItem;
        private MiscDataSetTableAdapters.MiscQueriesTableAdapter miscQueriesTableAdapter;
        private MiscDataSetTableAdapters.DOC_SEL_DETTableAdapter docSelDetTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox mailStatuRepositoryItemImageComboBox;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}
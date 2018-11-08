namespace tMax14.Ops
{
    partial class ProjeFaliyetXF
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
            this.opsDataSet = new tMax14.Ops.OpsDataSet();
            this.prfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prfTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.PRFTableAdapter();
            this.prfGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prfGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPRFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKONU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONCELIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ONCELIKrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colDETAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSORUMLU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATF = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prfGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prfGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ONCELIKrepositoryItemImageComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prfBindingSource
            // 
            this.prfBindingSource.DataMember = "PRF";
            this.prfBindingSource.DataSource = this.opsDataSet;
            // 
            // prfTableAdapter
            // 
            this.prfTableAdapter.ClearBeforeFill = true;
            // 
            // prfGridControl
            // 
            this.prfGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.prfGridControl.DataSource = this.prfBindingSource;
            this.prfGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prfGridControl.Location = new System.Drawing.Point(0, 0);
            this.prfGridControl.MainView = this.prfGridView;
            this.prfGridControl.Name = "prfGridControl";
            this.prfGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ONCELIKrepositoryItemImageComboBox});
            this.prfGridControl.Size = new System.Drawing.Size(690, 321);
            this.prfGridControl.TabIndex = 2;
            this.prfGridControl.Tag = "PRF";
            this.prfGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.prfGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutsToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(116, 26);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // prfGridView
            // 
            this.prfGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPRFID,
            this.colPRTID,
            this.colDRM,
            this.colKONU,
            this.colONCELIK,
            this.colDETAY,
            this.colSORUMLU,
            this.colACIKLAMA,
            this.colETS,
            this.colATS,
            this.colETF,
            this.colATF});
            this.prfGridView.GridControl = this.prfGridControl;
            this.prfGridView.Name = "prfGridView";
            this.prfGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // colPRFID
            // 
            this.colPRFID.FieldName = "PRFID";
            this.colPRFID.Name = "colPRFID";
            this.colPRFID.OptionsColumn.AllowEdit = false;
            this.colPRFID.OptionsColumn.AllowFocus = false;
            this.colPRFID.OptionsColumn.FixedWidth = true;
            this.colPRFID.Visible = true;
            this.colPRFID.VisibleIndex = 0;
            this.colPRFID.Width = 50;
            // 
            // colPRTID
            // 
            this.colPRTID.FieldName = "PRTID";
            this.colPRTID.Name = "colPRTID";
            this.colPRTID.OptionsColumn.AllowEdit = false;
            this.colPRTID.OptionsColumn.AllowFocus = false;
            this.colPRTID.OptionsColumn.FixedWidth = true;
            this.colPRTID.Visible = true;
            this.colPRTID.VisibleIndex = 1;
            this.colPRTID.Width = 50;
            // 
            // colDRM
            // 
            this.colDRM.Caption = "Durum";
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.OptionsColumn.FixedWidth = true;
            this.colDRM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 2;
            this.colDRM.Width = 50;
            // 
            // colKONU
            // 
            this.colKONU.Caption = "Konu";
            this.colKONU.FieldName = "KONU";
            this.colKONU.Name = "colKONU";
            this.colKONU.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colKONU.Visible = true;
            this.colKONU.VisibleIndex = 3;
            this.colKONU.Width = 83;
            // 
            // colONCELIK
            // 
            this.colONCELIK.Caption = "Öncelik";
            this.colONCELIK.ColumnEdit = this.ONCELIKrepositoryItemImageComboBox;
            this.colONCELIK.FieldName = "ONCELIK";
            this.colONCELIK.Name = "colONCELIK";
            this.colONCELIK.OptionsColumn.FixedWidth = true;
            this.colONCELIK.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colONCELIK.Visible = true;
            this.colONCELIK.VisibleIndex = 4;
            this.colONCELIK.Width = 50;
            // 
            // ONCELIKrepositoryItemImageComboBox
            // 
            this.ONCELIKrepositoryItemImageComboBox.AutoHeight = false;
            this.ONCELIKrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ONCELIKrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("1", "1", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("2", "2", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("3", "3", -1)});
            this.ONCELIKrepositoryItemImageComboBox.Name = "ONCELIKrepositoryItemImageComboBox";
            // 
            // colDETAY
            // 
            this.colDETAY.Caption = "Detay";
            this.colDETAY.FieldName = "DETAY";
            this.colDETAY.Name = "colDETAY";
            this.colDETAY.Visible = true;
            this.colDETAY.VisibleIndex = 5;
            this.colDETAY.Width = 94;
            // 
            // colSORUMLU
            // 
            this.colSORUMLU.Caption = "Sorumlu";
            this.colSORUMLU.FieldName = "SORUMLU";
            this.colSORUMLU.Name = "colSORUMLU";
            this.colSORUMLU.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSORUMLU.Visible = true;
            this.colSORUMLU.VisibleIndex = 6;
            this.colSORUMLU.Width = 94;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.Caption = "Açıklama";
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 7;
            this.colACIKLAMA.Width = 94;
            // 
            // colETS
            // 
            this.colETS.FieldName = "ETS";
            this.colETS.Name = "colETS";
            this.colETS.ToolTip = "Hedef Başlangıç";
            this.colETS.Visible = true;
            this.colETS.VisibleIndex = 8;
            // 
            // colATS
            // 
            this.colATS.FieldName = "ATS";
            this.colATS.Name = "colATS";
            this.colATS.ToolTip = "Gerçek Başlangıç";
            this.colATS.Visible = true;
            this.colATS.VisibleIndex = 9;
            // 
            // colETF
            // 
            this.colETF.FieldName = "ETF";
            this.colETF.Name = "colETF";
            this.colETF.ToolTip = "Hedef Bitiş";
            this.colETF.Visible = true;
            this.colETF.VisibleIndex = 10;
            // 
            // colATF
            // 
            this.colATF.FieldName = "ATF";
            this.colATF.Name = "colATF";
            this.colATF.ToolTip = "Gerçek Bitiş";
            this.colATF.Visible = true;
            this.colATF.VisibleIndex = 11;
            // 
            // ProjeFaliyetXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 321);
            this.Controls.Add(this.prfGridControl);
            this.Name = "ProjeFaliyetXF";
            this.Text = "ProjeFaliyetXF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjeFaliyetXF_FormClosing);
            this.Load += new System.EventHandler(this.ProjeFaliyetXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prfGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prfGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ONCELIKrepositoryItemImageComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpsDataSet opsDataSet;
        private System.Windows.Forms.BindingSource prfBindingSource;
        private OpsDataSetTableAdapters.PRFTableAdapter prfTableAdapter;
        private DevExpress.XtraGrid.GridControl prfGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView prfGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colPRFID;
        private DevExpress.XtraGrid.Columns.GridColumn colPRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colKONU;
        private DevExpress.XtraGrid.Columns.GridColumn colONCELIK;
        private DevExpress.XtraGrid.Columns.GridColumn colDETAY;
        private DevExpress.XtraGrid.Columns.GridColumn colSORUMLU;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colATS;
        private DevExpress.XtraGrid.Columns.GridColumn colATF;
        private DevExpress.XtraGrid.Columns.GridColumn colETS;
        private DevExpress.XtraGrid.Columns.GridColumn colETF;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox ONCELIKrepositoryItemImageComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
    }
}
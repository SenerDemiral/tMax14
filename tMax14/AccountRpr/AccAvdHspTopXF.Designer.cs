namespace tMax14.AccountRpr
{
    partial class AccAvdHspTopXF
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
            this.accountRprDataSet = new tMax14.AccountRpr.AccountRprDataSet();
            this.aCC_AVD_HSPTOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCC_AVD_HSPTOPTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.ACC_AVD_HSPTOPTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.tRHLTToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.tRHLTToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aCC_AVD_HSPTOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRC_DVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_DVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKLN_DVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRC_TRL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_TRL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKLN_TRL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR_FRK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSON_ISLEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hesapHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_AVD_HSPTOPBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_AVD_HSPTOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountRprDataSet
            // 
            this.accountRprDataSet.DataSetName = "AccountRprDataSet";
            this.accountRprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCC_AVD_HSPTOPBindingSource
            // 
            this.aCC_AVD_HSPTOPBindingSource.DataMember = "ACC_AVD_HSPTOP";
            this.aCC_AVD_HSPTOPBindingSource.DataSource = this.accountRprDataSet;
            // 
            // aCC_AVD_HSPTOPTableAdapter
            // 
            this.aCC_AVD_HSPTOPTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tRHLTToolStripLabel,
            this.tRHLTToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1039, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // tRHLTToolStripLabel
            // 
            this.tRHLTToolStripLabel.Name = "tRHLTToolStripLabel";
            this.tRHLTToolStripLabel.Size = new System.Drawing.Size(45, 22);
            this.tRHLTToolStripLabel.Text = "TRHLT:";
            // 
            // tRHLTToolStripTextBox
            // 
            this.tRHLTToolStripTextBox.Name = "tRHLTToolStripTextBox";
            this.tRHLTToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // aCC_AVD_HSPTOPGridControl
            // 
            this.aCC_AVD_HSPTOPGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.aCC_AVD_HSPTOPGridControl.DataSource = this.aCC_AVD_HSPTOPBindingSource;
            this.aCC_AVD_HSPTOPGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aCC_AVD_HSPTOPGridControl.Location = new System.Drawing.Point(0, 25);
            this.aCC_AVD_HSPTOPGridControl.MainView = this.gridView1;
            this.aCC_AVD_HSPTOPGridControl.Name = "aCC_AVD_HSPTOPGridControl";
            this.aCC_AVD_HSPTOPGridControl.Size = new System.Drawing.Size(1039, 278);
            this.aCC_AVD_HSPTOPGridControl.TabIndex = 2;
            this.aCC_AVD_HSPTOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHSPNO,
            this.colHSPAD,
            this.colDVZ,
            this.colBRC_DVZ,
            this.colALC_DVZ,
            this.colKLN_DVZ,
            this.colBRC_TRL,
            this.colALC_TRL,
            this.colKLN_TRL,
            this.colKUR_FRK,
            this.colSON_ISLEM,
            this.colDRM});
            this.gridView1.GridControl = this.aCC_AVD_HSPTOPGridControl;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BRC_TRL", null, "BrcTrl: {0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ALC_TRL", null, "AlcTrl: {0:n}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.EndGrouping += new System.EventHandler(this.gridView1_EndGrouping);
            // 
            // colHSPNO
            // 
            this.colHSPNO.Caption = "HspNo";
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "HSPNO", "{0:n0}")});
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 0;
            this.colHSPNO.Width = 87;
            // 
            // colHSPAD
            // 
            this.colHSPAD.Caption = "HspAd";
            this.colHSPAD.FieldName = "HSPAD";
            this.colHSPAD.Name = "colHSPAD";
            this.colHSPAD.Visible = true;
            this.colHSPAD.VisibleIndex = 1;
            this.colHSPAD.Width = 87;
            // 
            // colDVZ
            // 
            this.colDVZ.Caption = "Dvz";
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.OptionsColumn.FixedWidth = true;
            this.colDVZ.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 2;
            this.colDVZ.Width = 40;
            // 
            // colBRC_DVZ
            // 
            this.colBRC_DVZ.Caption = "BrcDvz";
            this.colBRC_DVZ.DisplayFormat.FormatString = "n";
            this.colBRC_DVZ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBRC_DVZ.FieldName = "BRC_DVZ";
            this.colBRC_DVZ.Name = "colBRC_DVZ";
            this.colBRC_DVZ.Visible = true;
            this.colBRC_DVZ.VisibleIndex = 3;
            this.colBRC_DVZ.Width = 91;
            // 
            // colALC_DVZ
            // 
            this.colALC_DVZ.Caption = "AlcDvz";
            this.colALC_DVZ.DisplayFormat.FormatString = "n";
            this.colALC_DVZ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colALC_DVZ.FieldName = "ALC_DVZ";
            this.colALC_DVZ.Name = "colALC_DVZ";
            this.colALC_DVZ.Visible = true;
            this.colALC_DVZ.VisibleIndex = 4;
            this.colALC_DVZ.Width = 91;
            // 
            // colKLN_DVZ
            // 
            this.colKLN_DVZ.Caption = "KlnDvz";
            this.colKLN_DVZ.DisplayFormat.FormatString = "n";
            this.colKLN_DVZ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKLN_DVZ.FieldName = "KLN_DVZ";
            this.colKLN_DVZ.Name = "colKLN_DVZ";
            this.colKLN_DVZ.Visible = true;
            this.colKLN_DVZ.VisibleIndex = 5;
            this.colKLN_DVZ.Width = 91;
            // 
            // colBRC_TRL
            // 
            this.colBRC_TRL.Caption = "BrcTrl";
            this.colBRC_TRL.DisplayFormat.FormatString = "n";
            this.colBRC_TRL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBRC_TRL.FieldName = "BRC_TRL";
            this.colBRC_TRL.Name = "colBRC_TRL";
            this.colBRC_TRL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BRC_TRL", "{0:n}")});
            this.colBRC_TRL.Visible = true;
            this.colBRC_TRL.VisibleIndex = 6;
            this.colBRC_TRL.Width = 91;
            // 
            // colALC_TRL
            // 
            this.colALC_TRL.Caption = "AlcTrl";
            this.colALC_TRL.DisplayFormat.FormatString = "n";
            this.colALC_TRL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colALC_TRL.FieldName = "ALC_TRL";
            this.colALC_TRL.Name = "colALC_TRL";
            this.colALC_TRL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ALC_TRL", "{0:n}")});
            this.colALC_TRL.Visible = true;
            this.colALC_TRL.VisibleIndex = 7;
            this.colALC_TRL.Width = 91;
            // 
            // colKLN_TRL
            // 
            this.colKLN_TRL.Caption = "KlnTrl";
            this.colKLN_TRL.DisplayFormat.FormatString = "n";
            this.colKLN_TRL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKLN_TRL.FieldName = "KLN_TRL";
            this.colKLN_TRL.Name = "colKLN_TRL";
            this.colKLN_TRL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KLN_TRL", "{0:n}")});
            this.colKLN_TRL.Visible = true;
            this.colKLN_TRL.VisibleIndex = 8;
            this.colKLN_TRL.Width = 91;
            // 
            // colKUR_FRK
            // 
            this.colKUR_FRK.Caption = "KurFrkTrl";
            this.colKUR_FRK.DisplayFormat.FormatString = "n";
            this.colKUR_FRK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKUR_FRK.FieldName = "KUR_FRK";
            this.colKUR_FRK.Name = "colKUR_FRK";
            this.colKUR_FRK.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KUR_FRK", "{0:n}")});
            this.colKUR_FRK.Width = 91;
            // 
            // colSON_ISLEM
            // 
            this.colSON_ISLEM.Caption = "SonIslem";
            this.colSON_ISLEM.FieldName = "SON_ISLEM";
            this.colSON_ISLEM.Name = "colSON_ISLEM";
            this.colSON_ISLEM.Visible = true;
            this.colSON_ISLEM.VisibleIndex = 9;
            this.colSON_ISLEM.Width = 95;
            // 
            // colDRM
            // 
            this.colDRM.Caption = "Drm";
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.OptionsColumn.FixedWidth = true;
            this.colDRM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 10;
            this.colDRM.Width = 40;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapHareketleriToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 26);
            // 
            // hesapHareketleriToolStripMenuItem
            // 
            this.hesapHareketleriToolStripMenuItem.Name = "hesapHareketleriToolStripMenuItem";
            this.hesapHareketleriToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.hesapHareketleriToolStripMenuItem.Text = "Hesap Hareketleri";
            this.hesapHareketleriToolStripMenuItem.Click += new System.EventHandler(this.hesapHareketleriToolStripMenuItem_Click);
            // 
            // AccAvdHspTopXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 303);
            this.Controls.Add(this.aCC_AVD_HSPTOPGridControl);
            this.Controls.Add(this.fillToolStrip);
            this.Name = "AccAvdHspTopXF";
            this.Text = "AccAvdHspTopXF";
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_AVD_HSPTOPBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_AVD_HSPTOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccountRprDataSet accountRprDataSet;
        private System.Windows.Forms.BindingSource aCC_AVD_HSPTOPBindingSource;
        private AccountRprDataSetTableAdapters.ACC_AVD_HSPTOPTableAdapter aCC_AVD_HSPTOPTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel tRHLTToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox tRHLTToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.GridControl aCC_AVD_HSPTOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPAD;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colBRC_DVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_DVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colKLN_DVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colBRC_TRL;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_TRL;
        private DevExpress.XtraGrid.Columns.GridColumn colKLN_TRL;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR_FRK;
        private DevExpress.XtraGrid.Columns.GridColumn colSON_ISLEM;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesapHareketleriToolStripMenuItem;
    }
}
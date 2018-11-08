namespace tMax14.Ops
{
    partial class TstSecXF
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
            this.tstLupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tstLupTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.TST_LUPTableAdapter();
            this.tstLupGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.secToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTSTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGCRTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRRID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRRAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOB = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tstLupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tstLupGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tstLupBindingSource
            // 
            this.tstLupBindingSource.DataMember = "TST_LUP";
            this.tstLupBindingSource.DataSource = this.opsDataSet;
            // 
            // tstLupTableAdapter
            // 
            this.tstLupTableAdapter.ClearBeforeFill = true;
            // 
            // tstLupGridControl
            // 
            this.tstLupGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.tstLupGridControl.DataSource = this.tstLupBindingSource;
            this.tstLupGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tstLupGridControl.Location = new System.Drawing.Point(0, 0);
            this.tstLupGridControl.MainView = this.gridView1;
            this.tstLupGridControl.Name = "tstLupGridControl";
            this.tstLupGridControl.Size = new System.Drawing.Size(748, 327);
            this.tstLupGridControl.TabIndex = 2;
            this.tstLupGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // secToolStripMenuItem
            // 
            this.secToolStripMenuItem.Name = "secToolStripMenuItem";
            this.secToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.secToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.secToolStripMenuItem.Text = "Seç";
            this.secToolStripMenuItem.Click += new System.EventHandler(this.secToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTSTID,
            this.colTYP,
            this.colSTU,
            this.colGCRTRH,
            this.colFRTID,
            this.colFRTAD,
            this.colCRRID,
            this.colCRRAD,
            this.colTOB,
            this.colROT,
            this.colMOT,
            this.colPOLS,
            this.colPOUS,
            this.colDTM,
            this.colPTM});
            this.gridView1.GridControl = this.tstLupGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colTSTID
            // 
            this.colTSTID.FieldName = "TSTID";
            this.colTSTID.Name = "colTSTID";
            this.colTSTID.OptionsColumn.FixedWidth = true;
            this.colTSTID.Visible = true;
            this.colTSTID.VisibleIndex = 0;
            this.colTSTID.Width = 60;
            // 
            // colTYP
            // 
            this.colTYP.FieldName = "TYP";
            this.colTYP.Name = "colTYP";
            this.colTYP.OptionsColumn.FixedWidth = true;
            this.colTYP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTYP.Visible = true;
            this.colTYP.VisibleIndex = 1;
            this.colTYP.Width = 60;
            // 
            // colSTU
            // 
            this.colSTU.FieldName = "STU";
            this.colSTU.Name = "colSTU";
            this.colSTU.OptionsColumn.FixedWidth = true;
            this.colSTU.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSTU.Visible = true;
            this.colSTU.VisibleIndex = 2;
            this.colSTU.Width = 60;
            // 
            // colGCRTRH
            // 
            this.colGCRTRH.DisplayFormat.FormatString = "dd.MM.yy";
            this.colGCRTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colGCRTRH.FieldName = "GCRTRH";
            this.colGCRTRH.Name = "colGCRTRH";
            this.colGCRTRH.OptionsColumn.FixedWidth = true;
            this.colGCRTRH.Visible = true;
            this.colGCRTRH.VisibleIndex = 3;
            this.colGCRTRH.Width = 68;
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Width = 48;
            // 
            // colFRTAD
            // 
            this.colFRTAD.Caption = "FRT";
            this.colFRTAD.FieldName = "FRTAD";
            this.colFRTAD.Name = "colFRTAD";
            this.colFRTAD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colFRTAD.Visible = true;
            this.colFRTAD.VisibleIndex = 4;
            this.colFRTAD.Width = 54;
            // 
            // colCRRID
            // 
            this.colCRRID.FieldName = "CRRID";
            this.colCRRID.Name = "colCRRID";
            this.colCRRID.Width = 48;
            // 
            // colCRRAD
            // 
            this.colCRRAD.Caption = "CRR";
            this.colCRRAD.FieldName = "CRRAD";
            this.colCRRAD.Name = "colCRRAD";
            this.colCRRAD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCRRAD.Visible = true;
            this.colCRRAD.VisibleIndex = 12;
            this.colCRRAD.Width = 70;
            // 
            // colROT
            // 
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.OptionsColumn.FixedWidth = true;
            this.colROT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 6;
            this.colROT.Width = 40;
            // 
            // colMOT
            // 
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.OptionsColumn.FixedWidth = true;
            this.colMOT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 7;
            this.colMOT.Width = 40;
            // 
            // colPOLS
            // 
            this.colPOLS.Caption = "POLs";
            this.colPOLS.FieldName = "POLS";
            this.colPOLS.Name = "colPOLS";
            this.colPOLS.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPOLS.Visible = true;
            this.colPOLS.VisibleIndex = 8;
            this.colPOLS.Width = 70;
            // 
            // colPOUS
            // 
            this.colPOUS.Caption = "POUs";
            this.colPOUS.FieldName = "POUS";
            this.colPOUS.Name = "colPOUS";
            this.colPOUS.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPOUS.Visible = true;
            this.colPOUS.VisibleIndex = 9;
            this.colPOUS.Width = 88;
            // 
            // colDTM
            // 
            this.colDTM.FieldName = "DTM";
            this.colDTM.Name = "colDTM";
            this.colDTM.OptionsColumn.FixedWidth = true;
            this.colDTM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDTM.Visible = true;
            this.colDTM.VisibleIndex = 10;
            this.colDTM.Width = 40;
            // 
            // colPTM
            // 
            this.colPTM.FieldName = "PTM";
            this.colPTM.Name = "colPTM";
            this.colPTM.OptionsColumn.FixedWidth = true;
            this.colPTM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPTM.Visible = true;
            this.colPTM.VisibleIndex = 11;
            this.colPTM.Width = 40;
            // 
            // colTOB
            // 
            this.colTOB.FieldName = "TOB";
            this.colTOB.Name = "colTOB";
            this.colTOB.OptionsColumn.FixedWidth = true;
            this.colTOB.Visible = true;
            this.colTOB.VisibleIndex = 5;
            this.colTOB.Width = 40;
            // 
            // TstSecXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 327);
            this.Controls.Add(this.tstLupGridControl);
            this.Name = "TstSecXF";
            this.Text = "Teklif Seç";
            this.Load += new System.EventHandler(this.TstSecXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tstLupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tstLupGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpsDataSet opsDataSet;
        private System.Windows.Forms.BindingSource tstLupBindingSource;
        private OpsDataSetTableAdapters.TST_LUPTableAdapter tstLupTableAdapter;
        private DevExpress.XtraGrid.GridControl tstLupGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTSTID;
        private DevExpress.XtraGrid.Columns.GridColumn colTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colGCRTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTAD;
        private DevExpress.XtraGrid.Columns.GridColumn colCRRID;
        private DevExpress.XtraGrid.Columns.GridColumn colCRRAD;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colPOLS;
        private DevExpress.XtraGrid.Columns.GridColumn colPOUS;
        private DevExpress.XtraGrid.Columns.GridColumn colDTM;
        private DevExpress.XtraGrid.Columns.GridColumn colPTM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTOB;
    }
}
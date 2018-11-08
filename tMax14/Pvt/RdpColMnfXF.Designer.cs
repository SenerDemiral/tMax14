namespace tMax14.Pvt
{
    partial class RdpColMnfXF
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
            this.pvtDataSet = new tMax14.Pvt.PvtDataSet();
            this.oPM_PDP_COLMNFBindingSource = new System.Windows.Forms.BindingSource();
            this.oPM_PDP_COLMNFTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.OPM_PDP_COLMNFTableAdapter();
            this.tableAdapterManager = new tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager();
            this.oPM_PDP_COLMNFGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMREFNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMVHC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAOH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBOOKING = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_NOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_SMPTYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_SITENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_SNDINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_KUTUGONDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_PRTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_STUDYNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_NOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_NOF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_REFNO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPM_PDP_COLMNFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPM_PDP_COLMNFGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oPM_PDP_COLMNFBindingSource
            // 
            this.oPM_PDP_COLMNFBindingSource.DataMember = "OPM_PDP_COLMNF";
            this.oPM_PDP_COLMNFBindingSource.DataSource = this.pvtDataSet;
            // 
            // oPM_PDP_COLMNFTableAdapter
            // 
            this.oPM_PDP_COLMNFTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oPM_PDP_COLMNFGridControl
            // 
            this.oPM_PDP_COLMNFGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.oPM_PDP_COLMNFGridControl.DataSource = this.oPM_PDP_COLMNFBindingSource;
            this.oPM_PDP_COLMNFGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oPM_PDP_COLMNFGridControl.Location = new System.Drawing.Point(0, 0);
            this.oPM_PDP_COLMNFGridControl.MainView = this.gridView1;
            this.oPM_PDP_COLMNFGridControl.Name = "oPM_PDP_COLMNFGridControl";
            this.oPM_PDP_COLMNFGridControl.Size = new System.Drawing.Size(991, 318);
            this.oPM_PDP_COLMNFGridControl.TabIndex = 2;
            this.oPM_PDP_COLMNFGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMID,
            this.colMREFNO,
            this.colMVHC,
            this.colHID,
            this.colAOH,
            this.colBOOKING,
            this.colB_NOR,
            this.colB_SMPTYP,
            this.colB_SITENO,
            this.colB_SNDINFO,
            this.colB_KUTUGONDER,
            this.colB_PRTNO,
            this.colB_STUDYNO,
            this.colB_NOA,
            this.colB_NOF,
            this.colB_REFNO});
            this.gridView1.GridControl = this.oPM_PDP_COLMNFGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMID
            // 
            this.colMID.Caption = "mID";
            this.colMID.FieldName = "MID";
            this.colMID.Name = "colMID";
            this.colMID.OptionsColumn.FixedWidth = true;
            this.colMID.Visible = true;
            this.colMID.VisibleIndex = 0;
            this.colMID.Width = 50;
            // 
            // colMREFNO
            // 
            this.colMREFNO.Caption = "mRefNo";
            this.colMREFNO.FieldName = "MREFNO";
            this.colMREFNO.Name = "colMREFNO";
            this.colMREFNO.Visible = true;
            this.colMREFNO.VisibleIndex = 1;
            this.colMREFNO.Width = 92;
            // 
            // colMVHC
            // 
            this.colMVHC.Caption = "mVehicle";
            this.colMVHC.FieldName = "MVHC";
            this.colMVHC.Name = "colMVHC";
            this.colMVHC.Visible = true;
            this.colMVHC.VisibleIndex = 2;
            this.colMVHC.Width = 92;
            // 
            // colHID
            // 
            this.colHID.Caption = "hID";
            this.colHID.FieldName = "HID";
            this.colHID.Name = "colHID";
            this.colHID.OptionsColumn.FixedWidth = true;
            this.colHID.Visible = true;
            this.colHID.VisibleIndex = 3;
            this.colHID.Width = 50;
            // 
            // colAOH
            // 
            this.colAOH.DisplayFormat.FormatString = "dd.MM.yy HH:mm";
            this.colAOH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colAOH.FieldName = "AOH";
            this.colAOH.Name = "colAOH";
            this.colAOH.OptionsColumn.FixedWidth = true;
            this.colAOH.Visible = true;
            this.colAOH.VisibleIndex = 4;
            this.colAOH.Width = 85;
            // 
            // colBOOKING
            // 
            this.colBOOKING.Caption = "Booking";
            this.colBOOKING.DisplayFormat.FormatString = "dd.MM.yy HH:mm";
            this.colBOOKING.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBOOKING.FieldName = "BOOKING";
            this.colBOOKING.Name = "colBOOKING";
            this.colBOOKING.OptionsColumn.FixedWidth = true;
            this.colBOOKING.Visible = true;
            this.colBOOKING.VisibleIndex = 5;
            this.colBOOKING.Width = 85;
            // 
            // colB_NOR
            // 
            this.colB_NOR.Caption = "NOR";
            this.colB_NOR.FieldName = "B_NOR";
            this.colB_NOR.Name = "colB_NOR";
            this.colB_NOR.OptionsColumn.FixedWidth = true;
            this.colB_NOR.Visible = true;
            this.colB_NOR.VisibleIndex = 6;
            this.colB_NOR.Width = 50;
            // 
            // colB_SMPTYP
            // 
            this.colB_SMPTYP.Caption = "SampleType";
            this.colB_SMPTYP.FieldName = "B_SMPTYP";
            this.colB_SMPTYP.Name = "colB_SMPTYP";
            this.colB_SMPTYP.OptionsColumn.FixedWidth = true;
            this.colB_SMPTYP.Visible = true;
            this.colB_SMPTYP.VisibleIndex = 7;
            this.colB_SMPTYP.Width = 84;
            // 
            // colB_SITENO
            // 
            this.colB_SITENO.Caption = "SiteNo";
            this.colB_SITENO.FieldName = "B_SITENO";
            this.colB_SITENO.Name = "colB_SITENO";
            this.colB_SITENO.OptionsColumn.FixedWidth = true;
            this.colB_SITENO.Visible = true;
            this.colB_SITENO.VisibleIndex = 8;
            this.colB_SITENO.Width = 67;
            // 
            // colB_SNDINFO
            // 
            this.colB_SNDINFO.Caption = "SendInfo";
            this.colB_SNDINFO.FieldName = "B_SNDINFO";
            this.colB_SNDINFO.Name = "colB_SNDINFO";
            this.colB_SNDINFO.Visible = true;
            this.colB_SNDINFO.VisibleIndex = 9;
            this.colB_SNDINFO.Width = 129;
            // 
            // colB_KUTUGONDER
            // 
            this.colB_KUTUGONDER.Caption = "KutuGonder";
            this.colB_KUTUGONDER.FieldName = "B_KUTUGONDER";
            this.colB_KUTUGONDER.Name = "colB_KUTUGONDER";
            this.colB_KUTUGONDER.OptionsColumn.FixedWidth = true;
            this.colB_KUTUGONDER.Visible = true;
            this.colB_KUTUGONDER.VisibleIndex = 10;
            this.colB_KUTUGONDER.Width = 70;
            // 
            // colB_PRTNO
            // 
            this.colB_PRTNO.Caption = "Protocol";
            this.colB_PRTNO.FieldName = "B_PRTNO";
            this.colB_PRTNO.Name = "colB_PRTNO";
            this.colB_PRTNO.Visible = true;
            this.colB_PRTNO.VisibleIndex = 11;
            // 
            // colB_STUDYNO
            // 
            this.colB_STUDYNO.Caption = "Study";
            this.colB_STUDYNO.FieldName = "B_STUDYNO";
            this.colB_STUDYNO.Name = "colB_STUDYNO";
            this.colB_STUDYNO.Visible = true;
            this.colB_STUDYNO.VisibleIndex = 12;
            // 
            // colB_NOA
            // 
            this.colB_NOA.Caption = "NOA";
            this.colB_NOA.FieldName = "B_NOA";
            this.colB_NOA.Name = "colB_NOA";
            this.colB_NOA.Visible = true;
            this.colB_NOA.VisibleIndex = 13;
            // 
            // colB_NOF
            // 
            this.colB_NOF.Caption = "NOF";
            this.colB_NOF.FieldName = "B_NOF";
            this.colB_NOF.Name = "colB_NOF";
            this.colB_NOF.Visible = true;
            this.colB_NOF.VisibleIndex = 14;
            // 
            // colB_REFNO
            // 
            this.colB_REFNO.Caption = "RefNo";
            this.colB_REFNO.FieldName = "B_REFNO";
            this.colB_REFNO.Name = "colB_REFNO";
            this.colB_REFNO.Visible = true;
            this.colB_REFNO.VisibleIndex = 15;
            // 
            // RdpColMnfXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 318);
            this.Controls.Add(this.oPM_PDP_COLMNFGridControl);
            this.Name = "RdpColMnfXF";
            this.Text = "RDP Collection Manifest";
            this.Load += new System.EventHandler(this.RdpColMnfXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPM_PDP_COLMNFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPM_PDP_COLMNFGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PvtDataSet pvtDataSet;
        private System.Windows.Forms.BindingSource oPM_PDP_COLMNFBindingSource;
        private PvtDataSetTableAdapters.OPM_PDP_COLMNFTableAdapter oPM_PDP_COLMNFTableAdapter;
        private PvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl oPM_PDP_COLMNFGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMID;
        private DevExpress.XtraGrid.Columns.GridColumn colMREFNO;
        private DevExpress.XtraGrid.Columns.GridColumn colMVHC;
        private DevExpress.XtraGrid.Columns.GridColumn colHID;
        private DevExpress.XtraGrid.Columns.GridColumn colAOH;
        private DevExpress.XtraGrid.Columns.GridColumn colBOOKING;
        private DevExpress.XtraGrid.Columns.GridColumn colB_NOR;
        private DevExpress.XtraGrid.Columns.GridColumn colB_SMPTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colB_SITENO;
        private DevExpress.XtraGrid.Columns.GridColumn colB_SNDINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colB_KUTUGONDER;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colB_PRTNO;
        private DevExpress.XtraGrid.Columns.GridColumn colB_STUDYNO;
        private DevExpress.XtraGrid.Columns.GridColumn colB_NOA;
        private DevExpress.XtraGrid.Columns.GridColumn colB_NOF;
        private DevExpress.XtraGrid.Columns.GridColumn colB_REFNO;
    }
}
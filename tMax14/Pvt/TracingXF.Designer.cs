namespace tMax14.Pvt
{
    partial class TracingXF
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
            this.pvtDataSet = new tMax14.Pvt.PvtDataSet();
            this.tableAdapterManager = new tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager();
            this.rPR_TRACING_DTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPR_TRACINGGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rPR_TRACINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCRRID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAILS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAILSUBJECT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAILBODY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rPR_TRACINGTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.RPR_TRACINGTableAdapter();
            this.rPR_TRACING_DTYTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.RPR_TRACING_DTYTableAdapter();
            this.rPR_TRACING_DTYGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCRRID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVHC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNTNOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTPAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTPDD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTPDD2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTPAD2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_TRACING_DTYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_TRACINGGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_TRACINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_TRACING_DTYGridControl)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.RPR_TRACING_DTYTableAdapter = null;
            this.tableAdapterManager.SALESREP_OPSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rPR_TRACING_DTYBindingSource
            // 
            this.rPR_TRACING_DTYBindingSource.DataMember = "RPR_TRACING_DTY";
            this.rPR_TRACING_DTYBindingSource.DataSource = this.pvtDataSet;
            // 
            // rPR_TRACINGGridControl
            // 
            this.rPR_TRACINGGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.rPR_TRACINGGridControl.DataSource = this.rPR_TRACINGBindingSource;
            this.rPR_TRACINGGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.rPR_TRACINGGridControl.Location = new System.Drawing.Point(0, 0);
            this.rPR_TRACINGGridControl.MainView = this.mGridView;
            this.rPR_TRACINGGridControl.Name = "rPR_TRACINGGridControl";
            this.rPR_TRACINGGridControl.ShowOnlyPredefinedDetails = true;
            this.rPR_TRACINGGridControl.Size = new System.Drawing.Size(1157, 274);
            this.rPR_TRACINGGridControl.TabIndex = 5;
            this.rPR_TRACINGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mGridView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // eMailToolStripMenuItem
            // 
            this.eMailToolStripMenuItem.Name = "eMailToolStripMenuItem";
            this.eMailToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.eMailToolStripMenuItem.Text = "eMail";
            this.eMailToolStripMenuItem.Click += new System.EventHandler(this.eMailToolStripMenuItem_Click);
            // 
            // rPR_TRACINGBindingSource
            // 
            this.rPR_TRACINGBindingSource.DataMember = "RPR_TRACING";
            this.rPR_TRACINGBindingSource.DataSource = this.pvtDataSet;
            // 
            // mGridView
            // 
            this.mGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCRRID1,
            this.colCRR,
            this.colEMAILS,
            this.colEMAILSUBJECT,
            this.colEMAILBODY});
            this.mGridView.GridControl = this.rPR_TRACINGGridControl;
            this.mGridView.Name = "mGridView";
            this.mGridView.OptionsCustomization.AllowGroup = false;
            // 
            // colCRRID1
            // 
            this.colCRRID1.FieldName = "CRRID";
            this.colCRRID1.Name = "colCRRID1";
            this.colCRRID1.OptionsColumn.FixedWidth = true;
            this.colCRRID1.Visible = true;
            this.colCRRID1.VisibleIndex = 0;
            this.colCRRID1.Width = 60;
            // 
            // colCRR
            // 
            this.colCRR.Caption = "Carrier";
            this.colCRR.FieldName = "CRR";
            this.colCRR.Name = "colCRR";
            this.colCRR.Visible = true;
            this.colCRR.VisibleIndex = 1;
            this.colCRR.Width = 467;
            // 
            // colEMAILS
            // 
            this.colEMAILS.Caption = "eMails";
            this.colEMAILS.FieldName = "EMAILS";
            this.colEMAILS.Name = "colEMAILS";
            this.colEMAILS.Visible = true;
            this.colEMAILS.VisibleIndex = 2;
            this.colEMAILS.Width = 612;
            // 
            // colEMAILSUBJECT
            // 
            this.colEMAILSUBJECT.FieldName = "EMAILSUBJECT";
            this.colEMAILSUBJECT.Name = "colEMAILSUBJECT";
            this.colEMAILSUBJECT.Width = 273;
            // 
            // colEMAILBODY
            // 
            this.colEMAILBODY.FieldName = "EMAILBODY";
            this.colEMAILBODY.Name = "colEMAILBODY";
            // 
            // rPR_TRACINGTableAdapter
            // 
            this.rPR_TRACINGTableAdapter.ClearBeforeFill = true;
            // 
            // rPR_TRACING_DTYTableAdapter
            // 
            this.rPR_TRACING_DTYTableAdapter.ClearBeforeFill = true;
            // 
            // rPR_TRACING_DTYGridControl
            // 
            this.rPR_TRACING_DTYGridControl.ContextMenuStrip = this.contextMenuStrip2;
            this.rPR_TRACING_DTYGridControl.DataMember = "RPR_TRACING_RPR_TRACING_DTY";
            this.rPR_TRACING_DTYGridControl.DataSource = this.rPR_TRACINGBindingSource;
            this.rPR_TRACING_DTYGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPR_TRACING_DTYGridControl.Location = new System.Drawing.Point(0, 274);
            this.rPR_TRACING_DTYGridControl.MainView = this.dGridView;
            this.rPR_TRACING_DTYGridControl.Name = "rPR_TRACING_DTYGridControl";
            this.rPR_TRACING_DTYGridControl.Size = new System.Drawing.Size(1157, 296);
            this.rPR_TRACING_DTYGridControl.TabIndex = 3;
            this.rPR_TRACING_DTYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dGridView});
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(139, 54);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem2.Text = "Layouts";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dGridView
            // 
            this.dGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCRRID,
            this.colOPMID,
            this.colVHC,
            this.colREFNO,
            this.colCNTNOS,
            this.colNSTU,
            this.colROT,
            this.colMOT,
            this.colDST,
            this.colATD,
            this.colETA,
            this.colATA,
            this.colPOU,
            this.colTPAD,
            this.colTPDD,
            this.colTPDD2,
            this.colTPAD2,
            this.colBOS});
            this.dGridView.GridControl = this.rPR_TRACING_DTYGridControl;
            this.dGridView.Name = "dGridView";
            this.dGridView.OptionsCustomization.AllowGroup = false;
            // 
            // colCRRID
            // 
            this.colCRRID.FieldName = "CRRID";
            this.colCRRID.Name = "colCRRID";
            this.colCRRID.OptionsColumn.ReadOnly = true;
            this.colCRRID.Visible = true;
            this.colCRRID.VisibleIndex = 0;
            this.colCRRID.Width = 47;
            // 
            // colOPMID
            // 
            this.colOPMID.FieldName = "OPMID";
            this.colOPMID.Name = "colOPMID";
            this.colOPMID.OptionsColumn.ReadOnly = true;
            this.colOPMID.Visible = true;
            this.colOPMID.VisibleIndex = 1;
            this.colOPMID.Width = 48;
            // 
            // colVHC
            // 
            this.colVHC.Caption = "Vehicle";
            this.colVHC.FieldName = "VHC";
            this.colVHC.Name = "colVHC";
            this.colVHC.OptionsColumn.ReadOnly = true;
            this.colVHC.Visible = true;
            this.colVHC.VisibleIndex = 5;
            this.colVHC.Width = 71;
            // 
            // colREFNO
            // 
            this.colREFNO.Caption = "RefNo";
            this.colREFNO.FieldName = "REFNO";
            this.colREFNO.Name = "colREFNO";
            this.colREFNO.OptionsColumn.ReadOnly = true;
            this.colREFNO.Visible = true;
            this.colREFNO.VisibleIndex = 6;
            this.colREFNO.Width = 74;
            // 
            // colCNTNOS
            // 
            this.colCNTNOS.Caption = "Containers";
            this.colCNTNOS.FieldName = "CNTNOS";
            this.colCNTNOS.Name = "colCNTNOS";
            this.colCNTNOS.OptionsColumn.ReadOnly = true;
            this.colCNTNOS.Visible = true;
            this.colCNTNOS.VisibleIndex = 7;
            this.colCNTNOS.Width = 74;
            // 
            // colNSTU
            // 
            this.colNSTU.FieldName = "NSTU";
            this.colNSTU.Name = "colNSTU";
            this.colNSTU.OptionsColumn.ReadOnly = true;
            this.colNSTU.Visible = true;
            this.colNSTU.VisibleIndex = 8;
            this.colNSTU.Width = 74;
            // 
            // colROT
            // 
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.OptionsColumn.ReadOnly = true;
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 2;
            this.colROT.Width = 33;
            // 
            // colMOT
            // 
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.OptionsColumn.ReadOnly = true;
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 3;
            this.colMOT.Width = 34;
            // 
            // colDST
            // 
            this.colDST.Caption = "Dst";
            this.colDST.FieldName = "DST";
            this.colDST.Name = "colDST";
            this.colDST.Visible = true;
            this.colDST.VisibleIndex = 4;
            // 
            // colATD
            // 
            this.colATD.Caption = "Vehicle Departure Time";
            this.colATD.FieldName = "ATD";
            this.colATD.Name = "colATD";
            this.colATD.OptionsColumn.ReadOnly = true;
            this.colATD.Visible = true;
            this.colATD.VisibleIndex = 9;
            this.colATD.Width = 74;
            // 
            // colETA
            // 
            this.colETA.FieldName = "ETA";
            this.colETA.Name = "colETA";
            this.colETA.Visible = true;
            this.colETA.VisibleIndex = 10;
            this.colETA.Width = 74;
            // 
            // colATA
            // 
            this.colATA.Caption = "Destination Arrival Date";
            this.colATA.FieldName = "ATA";
            this.colATA.Name = "colATA";
            this.colATA.Visible = true;
            this.colATA.VisibleIndex = 11;
            this.colATA.Width = 71;
            // 
            // colPOU
            // 
            this.colPOU.Caption = "Destination Point";
            this.colPOU.FieldName = "POU";
            this.colPOU.Name = "colPOU";
            this.colPOU.OptionsColumn.ReadOnly = true;
            this.colPOU.Visible = true;
            this.colPOU.VisibleIndex = 12;
            this.colPOU.Width = 71;
            // 
            // colTPAD
            // 
            this.colTPAD.Caption = "1.Arrival";
            this.colTPAD.FieldName = "TPAD";
            this.colTPAD.Name = "colTPAD";
            this.colTPAD.Visible = true;
            this.colTPAD.VisibleIndex = 13;
            this.colTPAD.Width = 74;
            // 
            // colTPDD
            // 
            this.colTPDD.Caption = "1.Departure";
            this.colTPDD.FieldName = "TPDD";
            this.colTPDD.Name = "colTPDD";
            this.colTPDD.Visible = true;
            this.colTPDD.VisibleIndex = 14;
            this.colTPDD.Width = 74;
            // 
            // colTPDD2
            // 
            this.colTPDD2.Caption = "2.Departure";
            this.colTPDD2.FieldName = "TPDD2";
            this.colTPDD2.Name = "colTPDD2";
            this.colTPDD2.Visible = true;
            this.colTPDD2.VisibleIndex = 16;
            this.colTPDD2.Width = 84;
            // 
            // colTPAD2
            // 
            this.colTPAD2.Caption = "2.Arrival";
            this.colTPAD2.FieldName = "TPAD2";
            this.colTPAD2.Name = "colTPAD2";
            this.colTPAD2.Visible = true;
            this.colTPAD2.VisibleIndex = 15;
            // 
            // colBOS
            // 
            this.colBOS.Caption = "CurrentLocation";
            this.colBOS.FieldName = "BOS";
            this.colBOS.Name = "colBOS";
            this.colBOS.OptionsColumn.ReadOnly = true;
            this.colBOS.Visible = true;
            this.colBOS.VisibleIndex = 17;
            this.colBOS.Width = 87;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 274);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1157, 5);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            // 
            // TracingXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 570);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.rPR_TRACING_DTYGridControl);
            this.Controls.Add(this.rPR_TRACINGGridControl);
            this.Name = "TracingXF";
            this.Text = "TracingXF";
            this.Load += new System.EventHandler(this.TracingXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_TRACING_DTYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_TRACINGGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rPR_TRACINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_TRACING_DTYGridControl)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PvtDataSet pvtDataSet;
        private PvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource rPR_TRACINGBindingSource;
        private PvtDataSetTableAdapters.RPR_TRACINGTableAdapter rPR_TRACINGTableAdapter;
        private DevExpress.XtraGrid.GridControl rPR_TRACINGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView mGridView;
        private System.Windows.Forms.BindingSource rPR_TRACING_DTYBindingSource;
        private PvtDataSetTableAdapters.RPR_TRACING_DTYTableAdapter rPR_TRACING_DTYTableAdapter;
        private DevExpress.XtraGrid.GridControl rPR_TRACING_DTYGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView dGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCRRID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPMID;
        private DevExpress.XtraGrid.Columns.GridColumn colREFNO;
        private DevExpress.XtraGrid.Columns.GridColumn colCNTNOS;
        private DevExpress.XtraGrid.Columns.GridColumn colNSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colATD;
        private DevExpress.XtraGrid.Columns.GridColumn colETA;
        private DevExpress.XtraGrid.Columns.GridColumn colTPAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTPDD;
        private DevExpress.XtraGrid.Columns.GridColumn colTPDD2;
        private DevExpress.XtraGrid.Columns.GridColumn colTPAD2;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eMailToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colCRRID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCRR;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAILS;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAILSUBJECT;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAILBODY;
        private DevExpress.XtraGrid.Columns.GridColumn colVHC;
        private DevExpress.XtraGrid.Columns.GridColumn colATA;
        private DevExpress.XtraGrid.Columns.GridColumn colBOS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colPOU;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.Columns.GridColumn colDST;
    }
}
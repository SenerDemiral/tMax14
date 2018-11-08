namespace tMax14.Ops
{
    partial class MarkenSiteListXF
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
            this.mslGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmslBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opsDataSet = new tMax14.Ops.OpsDataSet();
            this.mslGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTEMPLATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOADINGDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROTOCOL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPONSOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUDY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONSIGNEENAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPICKUPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPICKUPCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPICKUPDEPARTMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPICKUPCITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPICKUPPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.zmslTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.ZMSLTableAdapter();
            this.opsQueriesTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.OpsQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mslGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zmslBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mslGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mslGridControl
            // 
            this.mslGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.mslGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.mslGridControl.DataSource = this.zmslBindingSource;
            this.mslGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mslGridControl.Location = new System.Drawing.Point(0, 0);
            this.mslGridControl.MainView = this.mslGridView;
            this.mslGridControl.Name = "mslGridControl";
            this.mslGridControl.Size = new System.Drawing.Size(765, 273);
            this.mslGridControl.TabIndex = 0;
            this.mslGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mslGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.newListToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(115, 48);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newListToolStripMenuItem
            // 
            this.newListToolStripMenuItem.Name = "newListToolStripMenuItem";
            this.newListToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newListToolStripMenuItem.Text = "New List";
            this.newListToolStripMenuItem.Click += new System.EventHandler(this.newListToolStripMenuItem_Click);
            // 
            // zmslBindingSource
            // 
            this.zmslBindingSource.DataMember = "ZMSL";
            this.zmslBindingSource.DataSource = this.opsDataSet;
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mslGridView
            // 
            this.mslGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTEMPLATE,
            this.colLOADINGDATE,
            this.colPROTOCOL,
            this.colSPONSOR,
            this.colSTUDY,
            this.colSITE,
            this.colCONSIGNEENAME,
            this.colPICKUPNAME,
            this.colPICKUPCOMPANY,
            this.colPICKUPDEPARTMENT,
            this.colPICKUPCITY,
            this.colPICKUPPHONE});
            this.mslGridView.GridControl = this.mslGridControl;
            this.mslGridView.Name = "mslGridView";
            this.mslGridView.OptionsView.ColumnAutoWidth = false;
            // 
            // colTEMPLATE
            // 
            this.colTEMPLATE.FieldName = "TEMPLATE";
            this.colTEMPLATE.Name = "colTEMPLATE";
            this.colTEMPLATE.Visible = true;
            this.colTEMPLATE.VisibleIndex = 0;
            // 
            // colLOADINGDATE
            // 
            this.colLOADINGDATE.FieldName = "LOADINGDATE";
            this.colLOADINGDATE.Name = "colLOADINGDATE";
            this.colLOADINGDATE.Visible = true;
            this.colLOADINGDATE.VisibleIndex = 1;
            // 
            // colPROTOCOL
            // 
            this.colPROTOCOL.FieldName = "PROTOCOL";
            this.colPROTOCOL.Name = "colPROTOCOL";
            this.colPROTOCOL.Visible = true;
            this.colPROTOCOL.VisibleIndex = 2;
            // 
            // colSPONSOR
            // 
            this.colSPONSOR.FieldName = "SPONSOR";
            this.colSPONSOR.Name = "colSPONSOR";
            this.colSPONSOR.Visible = true;
            this.colSPONSOR.VisibleIndex = 3;
            // 
            // colSTUDY
            // 
            this.colSTUDY.FieldName = "STUDY";
            this.colSTUDY.Name = "colSTUDY";
            this.colSTUDY.Visible = true;
            this.colSTUDY.VisibleIndex = 4;
            // 
            // colSITE
            // 
            this.colSITE.FieldName = "SITE";
            this.colSITE.Name = "colSITE";
            this.colSITE.Visible = true;
            this.colSITE.VisibleIndex = 5;
            // 
            // colCONSIGNEENAME
            // 
            this.colCONSIGNEENAME.FieldName = "CONSIGNEENAME";
            this.colCONSIGNEENAME.Name = "colCONSIGNEENAME";
            this.colCONSIGNEENAME.Visible = true;
            this.colCONSIGNEENAME.VisibleIndex = 6;
            // 
            // colPICKUPNAME
            // 
            this.colPICKUPNAME.FieldName = "PICKUPNAME";
            this.colPICKUPNAME.Name = "colPICKUPNAME";
            this.colPICKUPNAME.Visible = true;
            this.colPICKUPNAME.VisibleIndex = 7;
            // 
            // colPICKUPCOMPANY
            // 
            this.colPICKUPCOMPANY.FieldName = "PICKUPCOMPANY";
            this.colPICKUPCOMPANY.Name = "colPICKUPCOMPANY";
            this.colPICKUPCOMPANY.Visible = true;
            this.colPICKUPCOMPANY.VisibleIndex = 8;
            // 
            // colPICKUPDEPARTMENT
            // 
            this.colPICKUPDEPARTMENT.FieldName = "PICKUPDEPARTMENT";
            this.colPICKUPDEPARTMENT.Name = "colPICKUPDEPARTMENT";
            this.colPICKUPDEPARTMENT.Visible = true;
            this.colPICKUPDEPARTMENT.VisibleIndex = 9;
            // 
            // colPICKUPCITY
            // 
            this.colPICKUPCITY.FieldName = "PICKUPCITY";
            this.colPICKUPCITY.Name = "colPICKUPCITY";
            this.colPICKUPCITY.Visible = true;
            this.colPICKUPCITY.VisibleIndex = 10;
            // 
            // colPICKUPPHONE
            // 
            this.colPICKUPPHONE.FieldName = "PICKUPPHONE";
            this.colPICKUPPHONE.Name = "colPICKUPPHONE";
            this.colPICKUPPHONE.Visible = true;
            this.colPICKUPPHONE.VisibleIndex = 11;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xlsx";
            this.openFileDialog.Filter = "Excel files|*.xlsx";
            // 
            // zmslTableAdapter
            // 
            this.zmslTableAdapter.ClearBeforeFill = true;
            // 
            // MarkenSiteListXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 273);
            this.Controls.Add(this.mslGridControl);
            this.Name = "MarkenSiteListXF";
            this.Text = "MarkenSiteListXF";
            this.Load += new System.EventHandler(this.MarkenSiteListXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mslGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zmslBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mslGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl mslGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView mslGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private OpsDataSet opsDataSet;
        private System.Windows.Forms.ToolStripMenuItem newListToolStripMenuItem;
        private System.Windows.Forms.BindingSource zmslBindingSource;
        private OpsDataSetTableAdapters.ZMSLTableAdapter zmslTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTEMPLATE;
        private DevExpress.XtraGrid.Columns.GridColumn colLOADINGDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colPROTOCOL;
        private DevExpress.XtraGrid.Columns.GridColumn colSPONSOR;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUDY;
        private DevExpress.XtraGrid.Columns.GridColumn colSITE;
        private DevExpress.XtraGrid.Columns.GridColumn colCONSIGNEENAME;
        private DevExpress.XtraGrid.Columns.GridColumn colPICKUPNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colPICKUPCOMPANY;
        private DevExpress.XtraGrid.Columns.GridColumn colPICKUPDEPARTMENT;
        private DevExpress.XtraGrid.Columns.GridColumn colPICKUPCITY;
        private DevExpress.XtraGrid.Columns.GridColumn colPICKUPPHONE;
        private OpsDataSetTableAdapters.OpsQueriesTableAdapter opsQueriesTableAdapter;
    }
}
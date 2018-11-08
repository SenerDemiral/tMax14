namespace tMax14.Teklif
{
    partial class TeklifAlisFiyatRprXF
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
            this.teklifDataSet = new tMax14.Teklif.TeklifDataSet();
            this.tKLF_RPR_ALSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tKLF_RPR_ALSTableAdapter = new tMax14.Teklif.TeklifDataSetTableAdapters.TKLF_RPR_ALSTableAdapter();
            this.tKLF_RPR_ALSGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORGULK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSTULK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRRID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRRAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHTAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teklifDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKLF_RPR_ALSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKLF_RPR_ALSGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // teklifDataSet
            // 
            this.teklifDataSet.DataSetName = "TeklifDataSet";
            this.teklifDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tKLF_RPR_ALSBindingSource
            // 
            this.tKLF_RPR_ALSBindingSource.DataMember = "TKLF_RPR_ALS";
            this.tKLF_RPR_ALSBindingSource.DataSource = this.teklifDataSet;
            // 
            // tKLF_RPR_ALSTableAdapter
            // 
            this.tKLF_RPR_ALSTableAdapter.ClearBeforeFill = true;
            // 
            // tKLF_RPR_ALSGridControl
            // 
            this.tKLF_RPR_ALSGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.tKLF_RPR_ALSGridControl.DataSource = this.tKLF_RPR_ALSBindingSource;
            this.tKLF_RPR_ALSGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tKLF_RPR_ALSGridControl.Location = new System.Drawing.Point(0, 0);
            this.tKLF_RPR_ALSGridControl.MainView = this.gridView1;
            this.tKLF_RPR_ALSGridControl.Name = "tKLF_RPR_ALSGridControl";
            this.tKLF_RPR_ALSGridControl.Size = new System.Drawing.Size(1040, 315);
            this.tKLF_RPR_ALSGridControl.TabIndex = 1;
            this.tKLF_RPR_ALSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTYP,
            this.colID,
            this.colSTU,
            this.colROT,
            this.colMOT,
            this.colORG,
            this.colORGULK,
            this.colDST,
            this.colDSTULK,
            this.colCRRID,
            this.colCRRAD,
            this.colAHTID,
            this.colAHTAD,
            this.colBRM,
            this.colFYT,
            this.colDVZ,
            this.colTOP,
            this.colNOR,
            this.colINFO});
            this.gridView1.GridControl = this.tKLF_RPR_ALSGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colTYP
            // 
            this.colTYP.FieldName = "TYP";
            this.colTYP.Name = "colTYP";
            this.colTYP.Visible = true;
            this.colTYP.VisibleIndex = 0;
            this.colTYP.Width = 45;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            this.colID.Width = 40;
            // 
            // colSTU
            // 
            this.colSTU.FieldName = "STU";
            this.colSTU.Name = "colSTU";
            this.colSTU.Visible = true;
            this.colSTU.VisibleIndex = 2;
            this.colSTU.Width = 65;
            // 
            // colROT
            // 
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 3;
            this.colROT.Width = 65;
            // 
            // colMOT
            // 
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 4;
            this.colMOT.Width = 65;
            // 
            // colORG
            // 
            this.colORG.FieldName = "ORG";
            this.colORG.Name = "colORG";
            this.colORG.Visible = true;
            this.colORG.VisibleIndex = 5;
            this.colORG.Width = 65;
            // 
            // colORGULK
            // 
            this.colORGULK.FieldName = "ORGULK";
            this.colORGULK.Name = "colORGULK";
            this.colORGULK.Visible = true;
            this.colORGULK.VisibleIndex = 6;
            this.colORGULK.Width = 65;
            // 
            // colDST
            // 
            this.colDST.FieldName = "DST";
            this.colDST.Name = "colDST";
            this.colDST.Visible = true;
            this.colDST.VisibleIndex = 7;
            this.colDST.Width = 65;
            // 
            // colDSTULK
            // 
            this.colDSTULK.FieldName = "DSTULK";
            this.colDSTULK.Name = "colDSTULK";
            this.colDSTULK.Visible = true;
            this.colDSTULK.VisibleIndex = 8;
            this.colDSTULK.Width = 65;
            // 
            // colCRRID
            // 
            this.colCRRID.FieldName = "CRRID";
            this.colCRRID.Name = "colCRRID";
            // 
            // colCRRAD
            // 
            this.colCRRAD.FieldName = "CRRAD";
            this.colCRRAD.Name = "colCRRAD";
            this.colCRRAD.Visible = true;
            this.colCRRAD.VisibleIndex = 9;
            this.colCRRAD.Width = 65;
            // 
            // colAHTID
            // 
            this.colAHTID.FieldName = "AHTID";
            this.colAHTID.Name = "colAHTID";
            // 
            // colAHTAD
            // 
            this.colAHTAD.FieldName = "AHTAD";
            this.colAHTAD.Name = "colAHTAD";
            this.colAHTAD.Visible = true;
            this.colAHTAD.VisibleIndex = 10;
            this.colAHTAD.Width = 65;
            // 
            // colBRM
            // 
            this.colBRM.FieldName = "BRM";
            this.colBRM.Name = "colBRM";
            this.colBRM.Visible = true;
            this.colBRM.VisibleIndex = 11;
            this.colBRM.Width = 65;
            // 
            // colFYT
            // 
            this.colFYT.FieldName = "FYT";
            this.colFYT.Name = "colFYT";
            this.colFYT.Visible = true;
            this.colFYT.VisibleIndex = 12;
            this.colFYT.Width = 65;
            // 
            // colDVZ
            // 
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 13;
            this.colDVZ.Width = 65;
            // 
            // colTOP
            // 
            this.colTOP.FieldName = "TOP";
            this.colTOP.Name = "colTOP";
            this.colTOP.Visible = true;
            this.colTOP.VisibleIndex = 14;
            this.colTOP.Width = 65;
            // 
            // colNOR
            // 
            this.colNOR.FieldName = "NOR";
            this.colNOR.Name = "colNOR";
            this.colNOR.Width = 92;
            // 
            // colINFO
            // 
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 15;
            // 
            // TeklifAlisFiyatRprXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 315);
            this.Controls.Add(this.tKLF_RPR_ALSGridControl);
            this.Name = "TeklifAlisFiyatRprXF";
            this.Text = "TeklifAlisFiyatRprXF";
            this.Load += new System.EventHandler(this.TeklifAlisFiyatRprXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teklifDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKLF_RPR_ALSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKLF_RPR_ALSGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TeklifDataSet teklifDataSet;
        private System.Windows.Forms.BindingSource tKLF_RPR_ALSBindingSource;
        private TeklifDataSetTableAdapters.TKLF_RPR_ALSTableAdapter tKLF_RPR_ALSTableAdapter;
        private DevExpress.XtraGrid.GridControl tKLF_RPR_ALSGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colORG;
        private DevExpress.XtraGrid.Columns.GridColumn colORGULK;
        private DevExpress.XtraGrid.Columns.GridColumn colDST;
        private DevExpress.XtraGrid.Columns.GridColumn colDSTULK;
        private DevExpress.XtraGrid.Columns.GridColumn colCRRID;
        private DevExpress.XtraGrid.Columns.GridColumn colCRRAD;
        private DevExpress.XtraGrid.Columns.GridColumn colAHTID;
        private DevExpress.XtraGrid.Columns.GridColumn colAHTAD;
        private DevExpress.XtraGrid.Columns.GridColumn colBRM;
        private DevExpress.XtraGrid.Columns.GridColumn colFYT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colTOP;
        private DevExpress.XtraGrid.Columns.GridColumn colNOR;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
    }
}
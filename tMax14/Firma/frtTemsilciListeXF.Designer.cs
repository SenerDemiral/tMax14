namespace tMax14.Firma
{
    partial class frtTemsilciListeXF
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
            this.firmaDataSet = new tMax14.Firma.FirmaDataSet();
            this.fRT_TEMSILCI_LISTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fRT_TEMSILCI_LISTETableAdapter = new tMax14.Firma.FirmaDataSetTableAdapters.FRT_TEMSILCI_LISTETableAdapter();
            this.fRT_TEMSILCI_LISTEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEHIR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALIDTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBJECT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colODMSKL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASRAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRT_TEMSILCI_LISTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRT_TEMSILCI_LISTEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firmaDataSet
            // 
            this.firmaDataSet.DataSetName = "FirmaDataSet";
            this.firmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fRT_TEMSILCI_LISTEBindingSource
            // 
            this.fRT_TEMSILCI_LISTEBindingSource.DataMember = "FRT_TEMSILCI_LISTE";
            this.fRT_TEMSILCI_LISTEBindingSource.DataSource = this.firmaDataSet;
            // 
            // fRT_TEMSILCI_LISTETableAdapter
            // 
            this.fRT_TEMSILCI_LISTETableAdapter.ClearBeforeFill = true;
            // 
            // fRT_TEMSILCI_LISTEGridControl
            // 
            this.fRT_TEMSILCI_LISTEGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.fRT_TEMSILCI_LISTEGridControl.DataSource = this.fRT_TEMSILCI_LISTEBindingSource;
            this.fRT_TEMSILCI_LISTEGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fRT_TEMSILCI_LISTEGridControl.Location = new System.Drawing.Point(0, 0);
            this.fRT_TEMSILCI_LISTEGridControl.MainView = this.gridView1;
            this.fRT_TEMSILCI_LISTEGridControl.Name = "fRT_TEMSILCI_LISTEGridControl";
            this.fRT_TEMSILCI_LISTEGridControl.Size = new System.Drawing.Size(971, 468);
            this.fRT_TEMSILCI_LISTEGridControl.TabIndex = 2;
            this.fRT_TEMSILCI_LISTEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFRTID,
            this.colAD,
            this.colTEL,
            this.colSEHIR,
            this.colTRH,
            this.colVALIDTY,
            this.colSUBJECT,
            this.colODMSKL,
            this.colMASRAF,
            this.colNOTE});
            this.gridView1.GridControl = this.fRT_TEMSILCI_LISTEGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 0;
            // 
            // colAD
            // 
            this.colAD.Caption = "Firma";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 1;
            // 
            // colTEL
            // 
            this.colTEL.Caption = "Tel";
            this.colTEL.FieldName = "TEL";
            this.colTEL.Name = "colTEL";
            this.colTEL.Visible = true;
            this.colTEL.VisibleIndex = 2;
            // 
            // colSEHIR
            // 
            this.colSEHIR.Caption = "Şehir";
            this.colSEHIR.FieldName = "SEHIR";
            this.colSEHIR.Name = "colSEHIR";
            this.colSEHIR.Visible = true;
            this.colSEHIR.VisibleIndex = 3;
            // 
            // colTRH
            // 
            this.colTRH.Caption = "Tarih";
            this.colTRH.FieldName = "TRH";
            this.colTRH.Name = "colTRH";
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 4;
            // 
            // colVALIDTY
            // 
            this.colVALIDTY.Caption = "Valid";
            this.colVALIDTY.FieldName = "VALIDTY";
            this.colVALIDTY.Name = "colVALIDTY";
            this.colVALIDTY.Visible = true;
            this.colVALIDTY.VisibleIndex = 5;
            // 
            // colSUBJECT
            // 
            this.colSUBJECT.Caption = "Konu";
            this.colSUBJECT.FieldName = "SUBJECT";
            this.colSUBJECT.Name = "colSUBJECT";
            this.colSUBJECT.Visible = true;
            this.colSUBJECT.VisibleIndex = 6;
            // 
            // colODMSKL
            // 
            this.colODMSKL.Caption = "ÖdmŞkl";
            this.colODMSKL.FieldName = "ODMSKL";
            this.colODMSKL.Name = "colODMSKL";
            this.colODMSKL.Visible = true;
            this.colODMSKL.VisibleIndex = 7;
            // 
            // colMASRAF
            // 
            this.colMASRAF.Caption = "Masraf";
            this.colMASRAF.FieldName = "MASRAF";
            this.colMASRAF.Name = "colMASRAF";
            this.colMASRAF.Visible = true;
            this.colMASRAF.VisibleIndex = 8;
            // 
            // colNOTE
            // 
            this.colNOTE.Caption = "Not";
            this.colNOTE.FieldName = "NOTE";
            this.colNOTE.Name = "colNOTE";
            this.colNOTE.Visible = true;
            this.colNOTE.VisibleIndex = 9;
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
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // frtTemsilciListeXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 468);
            this.Controls.Add(this.fRT_TEMSILCI_LISTEGridControl);
            this.Name = "frtTemsilciListeXF";
            this.Text = "frtTemsilciListeXF";
            this.Load += new System.EventHandler(this.frtTemsilciListeXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRT_TEMSILCI_LISTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRT_TEMSILCI_LISTEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FirmaDataSet firmaDataSet;
        private System.Windows.Forms.BindingSource fRT_TEMSILCI_LISTEBindingSource;
        private FirmaDataSetTableAdapters.FRT_TEMSILCI_LISTETableAdapter fRT_TEMSILCI_LISTETableAdapter;
        private DevExpress.XtraGrid.GridControl fRT_TEMSILCI_LISTEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL;
        private DevExpress.XtraGrid.Columns.GridColumn colSEHIR;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colVALIDTY;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT;
        private DevExpress.XtraGrid.Columns.GridColumn colODMSKL;
        private DevExpress.XtraGrid.Columns.GridColumn colMASRAF;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTE;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}
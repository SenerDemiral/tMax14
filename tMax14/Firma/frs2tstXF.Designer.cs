namespace tMax14.Firma
{
    partial class frs2tstXF
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
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ınsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fRS2TST_SELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaDataSet = new tMax14.Firma.FirmaDataSet();
            this.rowFRSID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowROT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMOT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowORG = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowORGZIP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDST = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDSTZIP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCUSLOCID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCUSZIP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTYP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowADR = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDTM = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMALCINSI = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowINFO = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowVOLUME = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTOP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCRRID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTSTIDS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowINSUSR = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.fRS2TST_SELTableAdapter = new tMax14.Firma.FirmaDataSetTableAdapters.FRS2TST_SELTableAdapter();
            this.rowTOB = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fRS2TST_SELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vGridControl1
            // 
            this.vGridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.vGridControl1.DataSource = this.fRS2TST_SELBindingSource;
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(0, 0);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 139;
            this.vGridControl1.RowHeaderWidth = 61;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowFRSID,
            this.rowTOB,
            this.rowROT,
            this.rowMOT,
            this.rowORG,
            this.rowORGZIP,
            this.rowDST,
            this.rowDSTZIP,
            this.rowCUSLOCID,
            this.rowCUSZIP,
            this.rowTYP,
            this.rowTOP,
            this.rowDTM,
            this.rowCRRID,
            this.rowADR,
            this.rowVOLUME,
            this.rowMALCINSI,
            this.rowINFO,
            this.rowTSTIDS,
            this.rowINSUSR});
            this.vGridControl1.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowForFocusedRow;
            this.vGridControl1.Size = new System.Drawing.Size(300, 356);
            this.vGridControl1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınsertToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // ınsertToolStripMenuItem
            // 
            this.ınsertToolStripMenuItem.Name = "ınsertToolStripMenuItem";
            this.ınsertToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ınsertToolStripMenuItem.Text = "Insert";
            this.ınsertToolStripMenuItem.Click += new System.EventHandler(this.ınsertToolStripMenuItem_Click);
            // 
            // fRS2TST_SELBindingSource
            // 
            this.fRS2TST_SELBindingSource.DataMember = "FRS2TST_SEL";
            this.fRS2TST_SELBindingSource.DataSource = this.firmaDataSet;
            // 
            // firmaDataSet
            // 
            this.firmaDataSet.DataSetName = "FirmaDataSet";
            this.firmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rowFRSID
            // 
            this.rowFRSID.Name = "rowFRSID";
            this.rowFRSID.Properties.Caption = "FRSID";
            this.rowFRSID.Properties.FieldName = "FRSID";
            this.rowFRSID.Properties.ReadOnly = true;
            // 
            // rowROT
            // 
            this.rowROT.Name = "rowROT";
            this.rowROT.Properties.Caption = "ROT";
            this.rowROT.Properties.FieldName = "ROT";
            // 
            // rowMOT
            // 
            this.rowMOT.Name = "rowMOT";
            this.rowMOT.Properties.Caption = "MOT";
            this.rowMOT.Properties.FieldName = "MOT";
            // 
            // rowORG
            // 
            this.rowORG.Name = "rowORG";
            this.rowORG.Properties.Caption = "Org";
            this.rowORG.Properties.FieldName = "ORG";
            // 
            // rowORGZIP
            // 
            this.rowORGZIP.Name = "rowORGZIP";
            this.rowORGZIP.Properties.Caption = "OrgZip";
            this.rowORGZIP.Properties.FieldName = "ORGZIP";
            // 
            // rowDST
            // 
            this.rowDST.Name = "rowDST";
            this.rowDST.Properties.Caption = "Dst";
            this.rowDST.Properties.FieldName = "DST";
            // 
            // rowDSTZIP
            // 
            this.rowDSTZIP.Name = "rowDSTZIP";
            this.rowDSTZIP.Properties.Caption = "DstZip";
            this.rowDSTZIP.Properties.FieldName = "DSTZIP";
            // 
            // rowCUSLOCID
            // 
            this.rowCUSLOCID.Name = "rowCUSLOCID";
            this.rowCUSLOCID.Properties.Caption = "CusLocID";
            this.rowCUSLOCID.Properties.FieldName = "CUSLOCID";
            // 
            // rowCUSZIP
            // 
            this.rowCUSZIP.Name = "rowCUSZIP";
            this.rowCUSZIP.Properties.Caption = "CusZip";
            this.rowCUSZIP.Properties.FieldName = "CUSZIP";
            // 
            // rowTYP
            // 
            this.rowTYP.Name = "rowTYP";
            this.rowTYP.Properties.Caption = "Typ";
            this.rowTYP.Properties.FieldName = "TYP";
            // 
            // rowADR
            // 
            this.rowADR.Name = "rowADR";
            this.rowADR.Properties.Caption = "ADR";
            this.rowADR.Properties.FieldName = "ADR";
            // 
            // rowDTM
            // 
            this.rowDTM.Name = "rowDTM";
            this.rowDTM.Properties.Caption = "DTM";
            this.rowDTM.Properties.FieldName = "DTM";
            // 
            // rowMALCINSI
            // 
            this.rowMALCINSI.Name = "rowMALCINSI";
            this.rowMALCINSI.Properties.Caption = "MalCinsi";
            this.rowMALCINSI.Properties.FieldName = "MALCINSI";
            // 
            // rowINFO
            // 
            this.rowINFO.Name = "rowINFO";
            this.rowINFO.Properties.Caption = "Info";
            this.rowINFO.Properties.FieldName = "INFO";
            // 
            // rowVOLUME
            // 
            this.rowVOLUME.Name = "rowVOLUME";
            this.rowVOLUME.Properties.Caption = "Volume";
            this.rowVOLUME.Properties.FieldName = "VOLUME";
            // 
            // rowTOP
            // 
            this.rowTOP.Name = "rowTOP";
            this.rowTOP.Properties.Caption = "TOP";
            this.rowTOP.Properties.FieldName = "TOP";
            // 
            // rowCRRID
            // 
            this.rowCRRID.Name = "rowCRRID";
            this.rowCRRID.Properties.Caption = "Crr";
            this.rowCRRID.Properties.FieldName = "CRRID";
            // 
            // rowTSTIDS
            // 
            this.rowTSTIDS.Name = "rowTSTIDS";
            this.rowTSTIDS.Properties.Caption = "TalepIDs";
            this.rowTSTIDS.Properties.FieldName = "TSTIDS";
            this.rowTSTIDS.Properties.ReadOnly = true;
            // 
            // rowINSUSR
            // 
            this.rowINSUSR.Name = "rowINSUSR";
            this.rowINSUSR.Properties.Caption = "Usr";
            this.rowINSUSR.Properties.FieldName = "INSUSR";
            this.rowINSUSR.Properties.ReadOnly = true;
            // 
            // fRS2TST_SELTableAdapter
            // 
            this.fRS2TST_SELTableAdapter.ClearBeforeFill = true;
            // 
            // rowTOB
            // 
            this.rowTOB.Name = "rowTOB";
            this.rowTOB.Properties.Caption = "TOB";
            this.rowTOB.Properties.FieldName = "TOB";
            // 
            // frs2tstXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 356);
            this.Controls.Add(this.vGridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frs2tstXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis -> TeklifTalep";
            this.Load += new System.EventHandler(this.frs2tstXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fRS2TST_SELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirmaDataSet firmaDataSet;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private System.Windows.Forms.BindingSource fRS2TST_SELBindingSource;
        private FirmaDataSetTableAdapters.FRS2TST_SELTableAdapter fRS2TST_SELTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFRSID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowROT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMOT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowORG;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowORGZIP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDST;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDSTZIP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCUSLOCID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCUSZIP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTYP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowADR;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMALCINSI;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowVOLUME;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowINSUSR;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTOP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCRRID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTSTIDS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ınsertToolStripMenuItem;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDTM;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowINFO;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTOB;
    }
}
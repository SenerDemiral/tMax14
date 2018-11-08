namespace tMax14.KaliteKontrol
{
    partial class kkOlyFlytXF
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
            this.kkDataSet = new tMax14.KaliteKontrol.kkDataSet();
            this.kK_OLYFLYTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kK_OLYFLYTTableAdapter = new tMax14.KaliteKontrol.kkDataSetTableAdapters.KK_OLYFLYTTableAdapter();
            this.kkOlyFlytGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colODRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOBLDSKL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOOLY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOONC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOKYTTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOBLDTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFYTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAMR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFMHT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFHDFTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFYAPTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYAP_BLD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYAP_HDF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAGS = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kK_OLYFLYTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkOlyFlytGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kkDataSet
            // 
            this.kkDataSet.DataSetName = "kkDataSet";
            this.kkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kK_OLYFLYTBindingSource
            // 
            this.kK_OLYFLYTBindingSource.DataMember = "KK_OLYFLYT";
            this.kK_OLYFLYTBindingSource.DataSource = this.kkDataSet;
            // 
            // kK_OLYFLYTTableAdapter
            // 
            this.kK_OLYFLYTTableAdapter.ClearBeforeFill = true;
            // 
            // kkOlyFlytGridControl
            // 
            this.kkOlyFlytGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.kkOlyFlytGridControl.DataSource = this.kK_OLYFLYTBindingSource;
            this.kkOlyFlytGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kkOlyFlytGridControl.Location = new System.Drawing.Point(0, 0);
            this.kkOlyFlytGridControl.MainView = this.gridView1;
            this.kkOlyFlytGridControl.Name = "kkOlyFlytGridControl";
            this.kkOlyFlytGridControl.Size = new System.Drawing.Size(1140, 340);
            this.kkOlyFlytGridControl.TabIndex = 2;
            this.kkOlyFlytGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 26);
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
            this.colOID,
            this.colODRM,
            this.colOBLDSKL,
            this.colOTUR,
            this.colOOLY,
            this.colOONC,
            this.colOKYTTRH,
            this.colOBLDTRH,
            this.colFID,
            this.colFTUR,
            this.colFYTK,
            this.colFAMR,
            this.colFMHT,
            this.colFHDFTRH,
            this.colFYAPTRH,
            this.colYAP_BLD,
            this.colYAP_HDF,
            this.colTAGS});
            this.gridView1.GridControl = this.kkOlyFlytGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colOID
            // 
            this.colOID.Caption = "oID";
            this.colOID.FieldName = "OID";
            this.colOID.Name = "colOID";
            this.colOID.OptionsColumn.FixedWidth = true;
            this.colOID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colOID.Visible = true;
            this.colOID.VisibleIndex = 0;
            this.colOID.Width = 50;
            // 
            // colODRM
            // 
            this.colODRM.Caption = "oDrm";
            this.colODRM.FieldName = "ODRM";
            this.colODRM.Name = "colODRM";
            this.colODRM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colODRM.Visible = true;
            this.colODRM.VisibleIndex = 1;
            this.colODRM.Width = 61;
            // 
            // colOBLDSKL
            // 
            this.colOBLDSKL.Caption = "oBldŞkl";
            this.colOBLDSKL.FieldName = "OBLDSKL";
            this.colOBLDSKL.Name = "colOBLDSKL";
            this.colOBLDSKL.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colOBLDSKL.Visible = true;
            this.colOBLDSKL.VisibleIndex = 2;
            this.colOBLDSKL.Width = 61;
            // 
            // colOTUR
            // 
            this.colOTUR.Caption = "oTür";
            this.colOTUR.FieldName = "OTUR";
            this.colOTUR.Name = "colOTUR";
            this.colOTUR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colOTUR.Visible = true;
            this.colOTUR.VisibleIndex = 3;
            this.colOTUR.Width = 61;
            // 
            // colOOLY
            // 
            this.colOOLY.Caption = "oOly";
            this.colOOLY.FieldName = "OOLY";
            this.colOOLY.Name = "colOOLY";
            this.colOOLY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colOOLY.Visible = true;
            this.colOOLY.VisibleIndex = 4;
            this.colOOLY.Width = 61;
            // 
            // colOONC
            // 
            this.colOONC.Caption = "oÖnc";
            this.colOONC.FieldName = "OONC";
            this.colOONC.Name = "colOONC";
            this.colOONC.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colOONC.Visible = true;
            this.colOONC.VisibleIndex = 5;
            this.colOONC.Width = 61;
            // 
            // colOKYTTRH
            // 
            this.colOKYTTRH.Caption = "oKytTrh";
            this.colOKYTTRH.FieldName = "OKYTTRH";
            this.colOKYTTRH.Name = "colOKYTTRH";
            this.colOKYTTRH.OptionsColumn.FixedWidth = true;
            this.colOKYTTRH.Visible = true;
            this.colOKYTTRH.VisibleIndex = 6;
            this.colOKYTTRH.Width = 66;
            // 
            // colOBLDTRH
            // 
            this.colOBLDTRH.Caption = "oBldTrh";
            this.colOBLDTRH.FieldName = "OBLDTRH";
            this.colOBLDTRH.Name = "colOBLDTRH";
            this.colOBLDTRH.OptionsColumn.FixedWidth = true;
            this.colOBLDTRH.Visible = true;
            this.colOBLDTRH.VisibleIndex = 7;
            this.colOBLDTRH.Width = 66;
            // 
            // colFID
            // 
            this.colFID.Caption = "fID";
            this.colFID.FieldName = "FID";
            this.colFID.Name = "colFID";
            this.colFID.OptionsColumn.FixedWidth = true;
            this.colFID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colFID.Visible = true;
            this.colFID.VisibleIndex = 8;
            this.colFID.Width = 50;
            // 
            // colFTUR
            // 
            this.colFTUR.Caption = "fTür";
            this.colFTUR.FieldName = "FTUR";
            this.colFTUR.Name = "colFTUR";
            this.colFTUR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colFTUR.Visible = true;
            this.colFTUR.VisibleIndex = 9;
            this.colFTUR.Width = 66;
            // 
            // colFYTK
            // 
            this.colFYTK.Caption = "fYtk";
            this.colFYTK.FieldName = "FYTK";
            this.colFYTK.Name = "colFYTK";
            this.colFYTK.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colFYTK.Visible = true;
            this.colFYTK.VisibleIndex = 10;
            this.colFYTK.Width = 66;
            // 
            // colFAMR
            // 
            this.colFAMR.Caption = "fAmr";
            this.colFAMR.FieldName = "FAMR";
            this.colFAMR.Name = "colFAMR";
            this.colFAMR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colFAMR.Visible = true;
            this.colFAMR.VisibleIndex = 11;
            this.colFAMR.Width = 66;
            // 
            // colFMHT
            // 
            this.colFMHT.Caption = "fMhtp";
            this.colFMHT.FieldName = "FMHT";
            this.colFMHT.Name = "colFMHT";
            this.colFMHT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colFMHT.Visible = true;
            this.colFMHT.VisibleIndex = 12;
            this.colFMHT.Width = 126;
            // 
            // colFHDFTRH
            // 
            this.colFHDFTRH.Caption = "fHdfTrh";
            this.colFHDFTRH.FieldName = "FHDFTRH";
            this.colFHDFTRH.Name = "colFHDFTRH";
            this.colFHDFTRH.OptionsColumn.FixedWidth = true;
            this.colFHDFTRH.Visible = true;
            this.colFHDFTRH.VisibleIndex = 13;
            this.colFHDFTRH.Width = 66;
            // 
            // colFYAPTRH
            // 
            this.colFYAPTRH.Caption = "fYapTrh";
            this.colFYAPTRH.FieldName = "FYAPTRH";
            this.colFYAPTRH.Name = "colFYAPTRH";
            this.colFYAPTRH.OptionsColumn.FixedWidth = true;
            this.colFYAPTRH.Visible = true;
            this.colFYAPTRH.VisibleIndex = 14;
            this.colFYAPTRH.Width = 66;
            // 
            // colYAP_BLD
            // 
            this.colYAP_BLD.AppearanceCell.Options.UseTextOptions = true;
            this.colYAP_BLD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYAP_BLD.Caption = "fYap-oBld";
            this.colYAP_BLD.FieldName = "YAP_BLD";
            this.colYAP_BLD.Name = "colYAP_BLD";
            this.colYAP_BLD.OptionsColumn.FixedWidth = true;
            this.colYAP_BLD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colYAP_BLD.Visible = true;
            this.colYAP_BLD.VisibleIndex = 15;
            this.colYAP_BLD.Width = 60;
            // 
            // colYAP_HDF
            // 
            this.colYAP_HDF.AppearanceCell.Options.UseTextOptions = true;
            this.colYAP_HDF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYAP_HDF.Caption = "fYap-fHdf";
            this.colYAP_HDF.FieldName = "YAP_HDF";
            this.colYAP_HDF.Name = "colYAP_HDF";
            this.colYAP_HDF.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colYAP_HDF.Visible = true;
            this.colYAP_HDF.VisibleIndex = 16;
            this.colYAP_HDF.Width = 69;
            // 
            // colTAGS
            // 
            this.colTAGS.Caption = "TAGs";
            this.colTAGS.FieldName = "TAGS";
            this.colTAGS.Name = "colTAGS";
            this.colTAGS.Visible = true;
            this.colTAGS.VisibleIndex = 17;
            // 
            // kkOlyFlytXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 340);
            this.Controls.Add(this.kkOlyFlytGridControl);
            this.Name = "kkOlyFlytXF";
            this.Text = "kkOlyFlyXF";
            this.Load += new System.EventHandler(this.kkOlyFlyXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kK_OLYFLYTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkOlyFlytGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private kkDataSet kkDataSet;
        private System.Windows.Forms.BindingSource kK_OLYFLYTBindingSource;
        private kkDataSetTableAdapters.KK_OLYFLYTTableAdapter kK_OLYFLYTTableAdapter;
        private DevExpress.XtraGrid.GridControl kkOlyFlytGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOID;
        private DevExpress.XtraGrid.Columns.GridColumn colODRM;
        private DevExpress.XtraGrid.Columns.GridColumn colOBLDSKL;
        private DevExpress.XtraGrid.Columns.GridColumn colOTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colOOLY;
        private DevExpress.XtraGrid.Columns.GridColumn colOONC;
        private DevExpress.XtraGrid.Columns.GridColumn colOKYTTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colOBLDTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colFID;
        private DevExpress.XtraGrid.Columns.GridColumn colFTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colFYTK;
        private DevExpress.XtraGrid.Columns.GridColumn colFAMR;
        private DevExpress.XtraGrid.Columns.GridColumn colFMHT;
        private DevExpress.XtraGrid.Columns.GridColumn colFHDFTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colFYAPTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colYAP_BLD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colYAP_HDF;
        private DevExpress.XtraGrid.Columns.GridColumn colTAGS;
    }
}
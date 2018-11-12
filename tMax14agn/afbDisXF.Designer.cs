namespace tMax14agn
{
    partial class afbDisXF
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
            this.dataSet = new tMax14agn.DataSet();
            this.wAN_AGN_RPR_FATURABindingSource = new System.Windows.Forms.BindingSource();
            this.wAN_AGN_RPR_FATURATableAdapter = new tMax14agn.DataSetTableAdapters.WAN_AGN_RPR_FATURATableAdapter();
            this.wAN_AGN_RPR_FATURAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAFBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEFTR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colODMVDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colODMSKL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRTOPTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDVINF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPHM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHTINF3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPINF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKNFRTAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKNDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKNNO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAN_AGN_RPR_FATURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAN_AGN_RPR_FATURAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wAN_AGN_RPR_FATURABindingSource
            // 
            this.wAN_AGN_RPR_FATURABindingSource.DataMember = "WAN_AGN_RPR_FATURA";
            this.wAN_AGN_RPR_FATURABindingSource.DataSource = this.dataSet;
            // 
            // wAN_AGN_RPR_FATURATableAdapter
            // 
            this.wAN_AGN_RPR_FATURATableAdapter.ClearBeforeFill = true;
            // 
            // wAN_AGN_RPR_FATURAGridControl
            // 
            this.wAN_AGN_RPR_FATURAGridControl.DataSource = this.wAN_AGN_RPR_FATURABindingSource;
            this.wAN_AGN_RPR_FATURAGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wAN_AGN_RPR_FATURAGridControl.Location = new System.Drawing.Point(0, 0);
            this.wAN_AGN_RPR_FATURAGridControl.MainView = this.gridView1;
            this.wAN_AGN_RPR_FATURAGridControl.Name = "wAN_AGN_RPR_FATURAGridControl";
            this.wAN_AGN_RPR_FATURAGridControl.Size = new System.Drawing.Size(933, 309);
            this.wAN_AGN_RPR_FATURAGridControl.TabIndex = 2;
            this.wAN_AGN_RPR_FATURAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAFBID,
            this.colDRM,
            this.colEFTR,
            this.colTUR,
            this.colFTRNO,
            this.colFTRTRH,
            this.colODMVDE,
            this.colODMSKL,
            this.colFTRTUT,
            this.colFTRKDV,
            this.colFTRTOPTUT,
            this.colKDVINF,
            this.colDVZ,
            this.colOPID,
            this.colOPHM,
            this.colINFO,
            this.colAHTINF3,
            this.colACIKLAMA,
            this.colOPINF,
            this.colDKNFRTAD,
            this.colDKNDVZ,
            this.colDKNNO});
            this.gridView1.GridControl = this.wAN_AGN_RPR_FATURAGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFTRTRH, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colAFBID
            // 
            this.colAFBID.FieldName = "AFBID";
            this.colAFBID.Name = "colAFBID";
            this.colAFBID.Visible = true;
            this.colAFBID.VisibleIndex = 0;
            // 
            // colDRM
            // 
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            // 
            // colEFTR
            // 
            this.colEFTR.FieldName = "EFTR";
            this.colEFTR.Name = "colEFTR";
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Type";
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 1;
            this.colTUR.Width = 53;
            // 
            // colFTRNO
            // 
            this.colFTRNO.Caption = "Inv#";
            this.colFTRNO.FieldName = "FTRNO";
            this.colFTRNO.Name = "colFTRNO";
            this.colFTRNO.Visible = true;
            this.colFTRNO.VisibleIndex = 3;
            // 
            // colFTRTRH
            // 
            this.colFTRTRH.Caption = "Date";
            this.colFTRTRH.FieldName = "FTRTRH";
            this.colFTRTRH.Name = "colFTRTRH";
            this.colFTRTRH.Visible = true;
            this.colFTRTRH.VisibleIndex = 4;
            // 
            // colODMVDE
            // 
            this.colODMVDE.Caption = "Expiry";
            this.colODMVDE.FieldName = "ODMVDE";
            this.colODMVDE.Name = "colODMVDE";
            this.colODMVDE.Visible = true;
            this.colODMVDE.VisibleIndex = 5;
            // 
            // colODMSKL
            // 
            this.colODMSKL.FieldName = "ODMSKL";
            this.colODMSKL.Name = "colODMSKL";
            // 
            // colFTRTUT
            // 
            this.colFTRTUT.Caption = "Amount";
            this.colFTRTUT.FieldName = "FTRTUT";
            this.colFTRTUT.Name = "colFTRTUT";
            this.colFTRTUT.Visible = true;
            this.colFTRTUT.VisibleIndex = 6;
            // 
            // colFTRKDV
            // 
            this.colFTRKDV.Caption = "VAT";
            this.colFTRKDV.FieldName = "FTRKDV";
            this.colFTRKDV.Name = "colFTRKDV";
            this.colFTRKDV.Visible = true;
            this.colFTRKDV.VisibleIndex = 8;
            this.colFTRKDV.Width = 61;
            // 
            // colFTRTOPTUT
            // 
            this.colFTRTOPTUT.Caption = "Total";
            this.colFTRTOPTUT.FieldName = "FTRTOPTUT";
            this.colFTRTOPTUT.Name = "colFTRTOPTUT";
            this.colFTRTOPTUT.Visible = true;
            this.colFTRTOPTUT.VisibleIndex = 9;
            // 
            // colKDVINF
            // 
            this.colKDVINF.FieldName = "KDVINF";
            this.colKDVINF.Name = "colKDVINF";
            // 
            // colDVZ
            // 
            this.colDVZ.Caption = "Curr";
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 7;
            this.colDVZ.Width = 56;
            // 
            // colOPID
            // 
            this.colOPID.FieldName = "OPID";
            this.colOPID.Name = "colOPID";
            this.colOPID.Visible = true;
            this.colOPID.VisibleIndex = 10;
            // 
            // colOPHM
            // 
            this.colOPHM.Caption = "H/M";
            this.colOPHM.FieldName = "OPHM";
            this.colOPHM.Name = "colOPHM";
            this.colOPHM.Visible = true;
            this.colOPHM.VisibleIndex = 11;
            this.colOPHM.Width = 50;
            // 
            // colINFO
            // 
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            // 
            // colAHTINF3
            // 
            this.colAHTINF3.Caption = "Charge";
            this.colAHTINF3.FieldName = "AHTINF3";
            this.colAHTINF3.Name = "colAHTINF3";
            this.colAHTINF3.Visible = true;
            this.colAHTINF3.VisibleIndex = 2;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            // 
            // colOPINF
            // 
            this.colOPINF.Caption = "OpsInfo";
            this.colOPINF.FieldName = "OPINF";
            this.colOPINF.Name = "colOPINF";
            this.colOPINF.Visible = true;
            this.colOPINF.VisibleIndex = 12;
            // 
            // colDKNFRTAD
            // 
            this.colDKNFRTAD.FieldName = "DKNFRTAD";
            this.colDKNFRTAD.Name = "colDKNFRTAD";
            this.colDKNFRTAD.Visible = true;
            this.colDKNFRTAD.VisibleIndex = 13;
            // 
            // colDKNDVZ
            // 
            this.colDKNDVZ.FieldName = "DKNDVZ";
            this.colDKNDVZ.Name = "colDKNDVZ";
            this.colDKNDVZ.Visible = true;
            this.colDKNDVZ.VisibleIndex = 14;
            // 
            // colDKNNO
            // 
            this.colDKNNO.FieldName = "DKNNO";
            this.colDKNNO.Name = "colDKNNO";
            this.colDKNNO.Visible = true;
            this.colDKNNO.VisibleIndex = 15;
            // 
            // afbDisXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 309);
            this.Controls.Add(this.wAN_AGN_RPR_FATURAGridControl);
            this.Name = "afbDisXF";
            this.Text = "afbDisXF";
            this.Load += new System.EventHandler(this.afbDisXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAN_AGN_RPR_FATURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAN_AGN_RPR_FATURAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource wAN_AGN_RPR_FATURABindingSource;
        private DataSetTableAdapters.WAN_AGN_RPR_FATURATableAdapter wAN_AGN_RPR_FATURATableAdapter;
        private DevExpress.XtraGrid.GridControl wAN_AGN_RPR_FATURAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAFBID;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colEFTR;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRNO;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colODMVDE;
        private DevExpress.XtraGrid.Columns.GridColumn colODMSKL;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRTOPTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colKDVINF;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colOPID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPHM;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colAHTINF3;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colOPINF;
        private DevExpress.XtraGrid.Columns.GridColumn colDKNFRTAD;
        private DevExpress.XtraGrid.Columns.GridColumn colDKNDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDKNNO;
    }
}
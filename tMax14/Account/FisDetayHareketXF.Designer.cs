namespace tMax14.Account
{
    partial class FisDetayHareketXF
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
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.avdHrktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avdHrktTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AVD_HRKTTableAdapter();
            this.aVD_HRKTGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colREFTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avdHrktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVD_HRKTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avdHrktBindingSource
            // 
            this.avdHrktBindingSource.DataMember = "AVD_HRKT";
            this.avdHrktBindingSource.DataSource = this.accountDataSet;
            // 
            // avdHrktTableAdapter
            // 
            this.avdHrktTableAdapter.ClearBeforeFill = true;
            // 
            // aVD_HRKTGridControl
            // 
            this.aVD_HRKTGridControl.DataSource = this.avdHrktBindingSource;
            this.aVD_HRKTGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aVD_HRKTGridControl.Location = new System.Drawing.Point(0, 0);
            this.aVD_HRKTGridControl.MainView = this.gridView1;
            this.aVD_HRKTGridControl.Name = "aVD_HRKTGridControl";
            this.aVD_HRKTGridControl.Size = new System.Drawing.Size(653, 160);
            this.aVD_HRKTGridControl.TabIndex = 2;
            this.aVD_HRKTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colREFTO,
            this.colREFID,
            this.colAVDID,
            this.colAVBID,
            this.colSKL,
            this.colHSPNO,
            this.colBA,
            this.colDTUT,
            this.colDDVZ,
            this.colTRH});
            this.gridView1.GridControl = this.aVD_HRKTGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colREFTO
            // 
            this.colREFTO.AppearanceCell.Options.UseTextOptions = true;
            this.colREFTO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFTO.Caption = "Ref";
            this.colREFTO.FieldName = "REFTO";
            this.colREFTO.Name = "colREFTO";
            this.colREFTO.OptionsColumn.FixedWidth = true;
            this.colREFTO.Visible = true;
            this.colREFTO.VisibleIndex = 0;
            this.colREFTO.Width = 40;
            // 
            // colREFID
            // 
            this.colREFID.Caption = "RefID";
            this.colREFID.FieldName = "REFID";
            this.colREFID.Name = "colREFID";
            this.colREFID.OptionsColumn.FixedWidth = true;
            this.colREFID.Visible = true;
            this.colREFID.VisibleIndex = 1;
            this.colREFID.Width = 60;
            // 
            // colAVDID
            // 
            this.colAVDID.Caption = "AvdID";
            this.colAVDID.FieldName = "AVDID";
            this.colAVDID.Name = "colAVDID";
            this.colAVDID.OptionsColumn.FixedWidth = true;
            this.colAVDID.Visible = true;
            this.colAVDID.VisibleIndex = 2;
            this.colAVDID.Width = 60;
            // 
            // colAVBID
            // 
            this.colAVBID.Caption = "AvbID";
            this.colAVBID.FieldName = "AVBID";
            this.colAVBID.Name = "colAVBID";
            this.colAVBID.OptionsColumn.FixedWidth = true;
            this.colAVBID.Visible = true;
            this.colAVBID.VisibleIndex = 3;
            this.colAVBID.Width = 60;
            // 
            // colSKL
            // 
            this.colSKL.AppearanceCell.Options.UseTextOptions = true;
            this.colSKL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSKL.Caption = "Skl";
            this.colSKL.FieldName = "SKL";
            this.colSKL.Name = "colSKL";
            this.colSKL.OptionsColumn.FixedWidth = true;
            this.colSKL.Visible = true;
            this.colSKL.VisibleIndex = 4;
            this.colSKL.Width = 30;
            // 
            // colHSPNO
            // 
            this.colHSPNO.Caption = "HspNo";
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 5;
            this.colHSPNO.Width = 148;
            // 
            // colBA
            // 
            this.colBA.AppearanceCell.Options.UseTextOptions = true;
            this.colBA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBA.FieldName = "BA";
            this.colBA.Name = "colBA";
            this.colBA.OptionsColumn.FixedWidth = true;
            this.colBA.Visible = true;
            this.colBA.VisibleIndex = 6;
            this.colBA.Width = 30;
            // 
            // colDTUT
            // 
            this.colDTUT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDTUT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDTUT.Caption = "dTut";
            this.colDTUT.DisplayFormat.FormatString = "n";
            this.colDTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDTUT.FieldName = "DTUT";
            this.colDTUT.Name = "colDTUT";
            this.colDTUT.Visible = true;
            this.colDTUT.VisibleIndex = 7;
            this.colDTUT.Width = 170;
            // 
            // colDDVZ
            // 
            this.colDDVZ.Caption = "Dvz";
            this.colDDVZ.FieldName = "DDVZ";
            this.colDDVZ.Name = "colDDVZ";
            this.colDDVZ.OptionsColumn.FixedWidth = true;
            this.colDDVZ.Visible = true;
            this.colDDVZ.VisibleIndex = 8;
            this.colDDVZ.Width = 40;
            // 
            // colTRH
            // 
            this.colTRH.Caption = "Tarih";
            this.colTRH.FieldName = "TRH";
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.FixedWidth = true;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 9;
            this.colTRH.Width = 80;
            // 
            // FisDetayHareketXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 160);
            this.Controls.Add(this.aVD_HRKTGridControl);
            this.Name = "FisDetayHareketXF";
            this.Text = "FisDetayHareketXF";
            this.Load += new System.EventHandler(this.FisDetayHareketXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avdHrktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVD_HRKTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource avdHrktBindingSource;
        private AccountDataSetTableAdapters.AVD_HRKTTableAdapter avdHrktTableAdapter;
        private DevExpress.XtraGrid.GridControl aVD_HRKTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTO;
        private DevExpress.XtraGrid.Columns.GridColumn colREFID;
        private DevExpress.XtraGrid.Columns.GridColumn colAVDID;
        private DevExpress.XtraGrid.Columns.GridColumn colAVBID;
        private DevExpress.XtraGrid.Columns.GridColumn colSKL;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colBA;
        private DevExpress.XtraGrid.Columns.GridColumn colDTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
    }
}
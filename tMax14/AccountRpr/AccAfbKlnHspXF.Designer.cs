namespace tMax14.AccountRpr
{
    partial class AccAfbKlnHspXF
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
            this.accountRprDataSet = new tMax14.AccountRpr.AccountRprDataSet();
            this.accAfbKlnHspBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accAfbKlnHspTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.ACC_AFBKLN_HSPTableAdapter();
            this.accAfbKlnHspGridControl = new DevExpress.XtraGrid.GridControl();
            this.accAfbKlnHspGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAFBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colODMVDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGCKGUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKLN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accAfbKlnHspBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accAfbKlnHspGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accAfbKlnHspGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountRprDataSet
            // 
            this.accountRprDataSet.DataSetName = "AccountRprDataSet";
            this.accountRprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accAfbKlnHspBindingSource
            // 
            this.accAfbKlnHspBindingSource.DataMember = "ACC_AFBKLN_HSP";
            this.accAfbKlnHspBindingSource.DataSource = this.accountRprDataSet;
            // 
            // accAfbKlnHspTableAdapter
            // 
            this.accAfbKlnHspTableAdapter.ClearBeforeFill = true;
            // 
            // accAfbKlnHspGridControl
            // 
            this.accAfbKlnHspGridControl.DataSource = this.accAfbKlnHspBindingSource;
            this.accAfbKlnHspGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accAfbKlnHspGridControl.Location = new System.Drawing.Point(0, 0);
            this.accAfbKlnHspGridControl.MainView = this.accAfbKlnHspGridView;
            this.accAfbKlnHspGridControl.Name = "accAfbKlnHspGridControl";
            this.accAfbKlnHspGridControl.Size = new System.Drawing.Size(991, 306);
            this.accAfbKlnHspGridControl.TabIndex = 2;
            this.accAfbKlnHspGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.accAfbKlnHspGridView});
            // 
            // accAfbKlnHspGridView
            // 
            this.accAfbKlnHspGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAFBID,
            this.colDRM,
            this.colTUR,
            this.colTUR2,
            this.colTUR3,
            this.colFTR,
            this.colBA,
            this.colFTRNO,
            this.colFTRTRH,
            this.colODMVDE,
            this.colGCKGUN,
            this.colFRTID,
            this.colHSPNO,
            this.colDVZ,
            this.colDTUT,
            this.colRTUT,
            this.colDKLN});
            this.accAfbKlnHspGridView.GridControl = this.accAfbKlnHspGridControl;
            this.accAfbKlnHspGridView.Name = "accAfbKlnHspGridView";
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
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 1;
            // 
            // colTUR
            // 
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 2;
            // 
            // colTUR2
            // 
            this.colTUR2.FieldName = "TUR2";
            this.colTUR2.Name = "colTUR2";
            this.colTUR2.Visible = true;
            this.colTUR2.VisibleIndex = 3;
            // 
            // colTUR3
            // 
            this.colTUR3.FieldName = "TUR3";
            this.colTUR3.Name = "colTUR3";
            this.colTUR3.Visible = true;
            this.colTUR3.VisibleIndex = 4;
            // 
            // colFTR
            // 
            this.colFTR.FieldName = "FTR";
            this.colFTR.Name = "colFTR";
            this.colFTR.Visible = true;
            this.colFTR.VisibleIndex = 5;
            // 
            // colBA
            // 
            this.colBA.FieldName = "BA";
            this.colBA.Name = "colBA";
            this.colBA.Visible = true;
            this.colBA.VisibleIndex = 6;
            // 
            // colFTRNO
            // 
            this.colFTRNO.FieldName = "FTRNO";
            this.colFTRNO.Name = "colFTRNO";
            this.colFTRNO.Visible = true;
            this.colFTRNO.VisibleIndex = 7;
            // 
            // colFTRTRH
            // 
            this.colFTRTRH.FieldName = "FTRTRH";
            this.colFTRTRH.Name = "colFTRTRH";
            this.colFTRTRH.Visible = true;
            this.colFTRTRH.VisibleIndex = 8;
            // 
            // colODMVDE
            // 
            this.colODMVDE.FieldName = "ODMVDE";
            this.colODMVDE.Name = "colODMVDE";
            this.colODMVDE.Visible = true;
            this.colODMVDE.VisibleIndex = 9;
            // 
            // colGCKGUN
            // 
            this.colGCKGUN.FieldName = "GCKGUN";
            this.colGCKGUN.Name = "colGCKGUN";
            this.colGCKGUN.Visible = true;
            this.colGCKGUN.VisibleIndex = 10;
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 11;
            // 
            // colHSPNO
            // 
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 12;
            // 
            // colDVZ
            // 
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 13;
            // 
            // colDTUT
            // 
            this.colDTUT.DisplayFormat.FormatString = "n";
            this.colDTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDTUT.FieldName = "DTUT";
            this.colDTUT.Name = "colDTUT";
            this.colDTUT.Visible = true;
            this.colDTUT.VisibleIndex = 14;
            // 
            // colRTUT
            // 
            this.colRTUT.DisplayFormat.FormatString = "n";
            this.colRTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRTUT.FieldName = "RTUT";
            this.colRTUT.Name = "colRTUT";
            this.colRTUT.Visible = true;
            this.colRTUT.VisibleIndex = 15;
            // 
            // colDKLN
            // 
            this.colDKLN.DisplayFormat.FormatString = "n";
            this.colDKLN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDKLN.FieldName = "DKLN";
            this.colDKLN.Name = "colDKLN";
            this.colDKLN.Visible = true;
            this.colDKLN.VisibleIndex = 16;
            // 
            // AccAfbKlnHspXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 306);
            this.Controls.Add(this.accAfbKlnHspGridControl);
            this.Name = "AccAfbKlnHspXF";
            this.Text = "AccAfbKlnHspXF";
            this.Load += new System.EventHandler(this.AccAfbKlnHspXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accAfbKlnHspBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accAfbKlnHspGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accAfbKlnHspGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountRprDataSet accountRprDataSet;
        private System.Windows.Forms.BindingSource accAfbKlnHspBindingSource;
        private AccountRprDataSetTableAdapters.ACC_AFBKLN_HSPTableAdapter accAfbKlnHspTableAdapter;
        private DevExpress.XtraGrid.GridControl accAfbKlnHspGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView accAfbKlnHspGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAFBID;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR2;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR3;
        private DevExpress.XtraGrid.Columns.GridColumn colFTR;
        private DevExpress.XtraGrid.Columns.GridColumn colBA;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRNO;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colODMVDE;
        private DevExpress.XtraGrid.Columns.GridColumn colGCKGUN;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colRTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colDKLN;
    }
}
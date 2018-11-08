namespace tMax14.Account
{
    partial class AccHspNoBkyXF
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
            this.aCC_HSPNO_BKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCC_HSPNO_BKYTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.ACC_HSPNO_BKYTableAdapter();
            this.aCC_HSPNO_BKYGridControl = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.colHSPNO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDBRC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDALC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDBKY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDBRCBKY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDALCBKY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colABRC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAALC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colABKY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colABRCBKY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAALCBKY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRBRC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRALC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRBKY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRBRCBKY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRALCBKY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_HSPNO_BKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_HSPNO_BKYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCC_HSPNO_BKYBindingSource
            // 
            this.aCC_HSPNO_BKYBindingSource.DataMember = "ACC_HSPNO_BKY";
            this.aCC_HSPNO_BKYBindingSource.DataSource = this.accountDataSet;
            // 
            // aCC_HSPNO_BKYTableAdapter
            // 
            this.aCC_HSPNO_BKYTableAdapter.ClearBeforeFill = true;
            // 
            // aCC_HSPNO_BKYGridControl
            // 
            this.aCC_HSPNO_BKYGridControl.DataSource = this.aCC_HSPNO_BKYBindingSource;
            this.aCC_HSPNO_BKYGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aCC_HSPNO_BKYGridControl.Location = new System.Drawing.Point(0, 0);
            this.aCC_HSPNO_BKYGridControl.MainView = this.bandedGridView1;
            this.aCC_HSPNO_BKYGridControl.Name = "aCC_HSPNO_BKYGridControl";
            this.aCC_HSPNO_BKYGridControl.Size = new System.Drawing.Size(1095, 228);
            this.aCC_HSPNO_BKYGridControl.TabIndex = 2;
            this.aCC_HSPNO_BKYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colHSPNO,
            this.colDVZ,
            this.colDBRC,
            this.colDALC,
            this.colDBKY,
            this.colDBRCBKY,
            this.colDALCBKY,
            this.colABRC,
            this.colAALC,
            this.colABKY,
            this.colABRCBKY,
            this.colAALCBKY,
            this.colRBRC,
            this.colRALC,
            this.colRBKY,
            this.colRBRCBKY,
            this.colRALCBKY});
            this.bandedGridView1.GridControl = this.aCC_HSPNO_BKYGridControl;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.ShowFooter = true;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colHSPNO
            // 
            this.colHSPNO.Caption = "HspNo";
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.Visible = true;
            // 
            // colDVZ
            // 
            this.colDVZ.AppearanceCell.Options.UseTextOptions = true;
            this.colDVZ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVZ.AppearanceHeader.Options.UseTextOptions = true;
            this.colDVZ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVZ.Caption = "Dvz";
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.Visible = true;
            this.colDVZ.Width = 44;
            // 
            // colDBRC
            // 
            this.colDBRC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDBRC.AppearanceCell.Options.UseBackColor = true;
            this.colDBRC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDBRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDBRC.Caption = "Brç";
            this.colDBRC.DisplayFormat.FormatString = "n";
            this.colDBRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDBRC.FieldName = "DBRC";
            this.colDBRC.Name = "colDBRC";
            this.colDBRC.Visible = true;
            this.colDBRC.Width = 78;
            // 
            // colDALC
            // 
            this.colDALC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDALC.AppearanceCell.Options.UseBackColor = true;
            this.colDALC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDALC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDALC.Caption = "Alc";
            this.colDALC.DisplayFormat.FormatString = "n";
            this.colDALC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDALC.FieldName = "DALC";
            this.colDALC.Name = "colDALC";
            this.colDALC.Visible = true;
            this.colDALC.Width = 78;
            // 
            // colDBKY
            // 
            this.colDBKY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDBKY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDBKY.AppearanceCell.Options.UseBackColor = true;
            this.colDBKY.AppearanceCell.Options.UseFont = true;
            this.colDBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colDBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDBKY.Caption = "Bky";
            this.colDBKY.DisplayFormat.FormatString = "#,###.00 B;#,###.00 A; ";
            this.colDBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDBKY.FieldName = "DBKY";
            this.colDBKY.Name = "colDBKY";
            this.colDBKY.Visible = true;
            // 
            // colDBRCBKY
            // 
            this.colDBRCBKY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDBRCBKY.AppearanceCell.Options.UseBackColor = true;
            this.colDBRCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colDBRCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDBRCBKY.Caption = "BrçBky";
            this.colDBRCBKY.DisplayFormat.FormatString = "n";
            this.colDBRCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDBRCBKY.FieldName = "DBRCBKY";
            this.colDBRCBKY.Name = "colDBRCBKY";
            this.colDBRCBKY.Visible = true;
            this.colDBRCBKY.Width = 78;
            // 
            // colDALCBKY
            // 
            this.colDALCBKY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDALCBKY.AppearanceCell.Options.UseBackColor = true;
            this.colDALCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colDALCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDALCBKY.Caption = "AlcBky";
            this.colDALCBKY.DisplayFormat.FormatString = "n";
            this.colDALCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDALCBKY.FieldName = "DALCBKY";
            this.colDALCBKY.Name = "colDALCBKY";
            this.colDALCBKY.Visible = true;
            this.colDALCBKY.Width = 78;
            // 
            // colABRC
            // 
            this.colABRC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colABRC.AppearanceCell.Options.UseBackColor = true;
            this.colABRC.AppearanceHeader.Options.UseTextOptions = true;
            this.colABRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colABRC.Caption = "Brç";
            this.colABRC.DisplayFormat.FormatString = "n";
            this.colABRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colABRC.FieldName = "ABRC";
            this.colABRC.Name = "colABRC";
            this.colABRC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABRC", "{0:#,###.00;#,###.00; }")});
            this.colABRC.Visible = true;
            this.colABRC.Width = 78;
            // 
            // colAALC
            // 
            this.colAALC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colAALC.AppearanceCell.Options.UseBackColor = true;
            this.colAALC.AppearanceHeader.Options.UseTextOptions = true;
            this.colAALC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAALC.Caption = "Alc";
            this.colAALC.DisplayFormat.FormatString = "n";
            this.colAALC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAALC.FieldName = "AALC";
            this.colAALC.Name = "colAALC";
            this.colAALC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AALC", "{0:#,###.00;#,###.00; }")});
            this.colAALC.Visible = true;
            this.colAALC.Width = 78;
            // 
            // colABKY
            // 
            this.colABKY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colABKY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colABKY.AppearanceCell.Options.UseBackColor = true;
            this.colABKY.AppearanceCell.Options.UseFont = true;
            this.colABKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colABKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colABKY.Caption = "Bky";
            this.colABKY.DisplayFormat.FormatString = "#,###.00 B;#,###.00 A; ";
            this.colABKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colABKY.FieldName = "ABKY";
            this.colABKY.Name = "colABKY";
            this.colABKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABKY", "{0:#,###.00 B;#,###.00 A; }")});
            this.colABKY.Visible = true;
            // 
            // colABRCBKY
            // 
            this.colABRCBKY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colABRCBKY.AppearanceCell.Options.UseBackColor = true;
            this.colABRCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colABRCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colABRCBKY.Caption = "BrçBky";
            this.colABRCBKY.DisplayFormat.FormatString = "n";
            this.colABRCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colABRCBKY.FieldName = "ABRCBKY";
            this.colABRCBKY.Name = "colABRCBKY";
            this.colABRCBKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABRCBKY", "{0:#,###.00;#,###.00; }")});
            this.colABRCBKY.Visible = true;
            this.colABRCBKY.Width = 78;
            // 
            // colAALCBKY
            // 
            this.colAALCBKY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colAALCBKY.AppearanceCell.Options.UseBackColor = true;
            this.colAALCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colAALCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAALCBKY.Caption = "AlcBky";
            this.colAALCBKY.DisplayFormat.FormatString = "n";
            this.colAALCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAALCBKY.FieldName = "AALCBKY";
            this.colAALCBKY.Name = "colAALCBKY";
            this.colAALCBKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AALCBKY", "{0:#,###.00;#,###.00; }")});
            this.colAALCBKY.Visible = true;
            this.colAALCBKY.Width = 92;
            // 
            // colRBRC
            // 
            this.colRBRC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colRBRC.AppearanceCell.Options.UseBackColor = true;
            this.colRBRC.AppearanceHeader.Options.UseTextOptions = true;
            this.colRBRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRBRC.Caption = "Brç";
            this.colRBRC.DisplayFormat.FormatString = "n";
            this.colRBRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRBRC.FieldName = "RBRC";
            this.colRBRC.Name = "colRBRC";
            this.colRBRC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RBRC", "{0:#,###.00;#,###.00; }")});
            this.colRBRC.Visible = true;
            // 
            // colRALC
            // 
            this.colRALC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colRALC.AppearanceCell.Options.UseBackColor = true;
            this.colRALC.AppearanceHeader.Options.UseTextOptions = true;
            this.colRALC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRALC.Caption = "Alc";
            this.colRALC.DisplayFormat.FormatString = "n";
            this.colRALC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRALC.FieldName = "RALC";
            this.colRALC.Name = "colRALC";
            this.colRALC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RALC", "{0:#,###.00;#,###.00; }")});
            this.colRALC.Visible = true;
            // 
            // colRBKY
            // 
            this.colRBKY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colRBKY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colRBKY.AppearanceCell.Options.UseBackColor = true;
            this.colRBKY.AppearanceCell.Options.UseFont = true;
            this.colRBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colRBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRBKY.Caption = "Bky";
            this.colRBKY.DisplayFormat.FormatString = "#,###.00 B;#,###.00 A; ";
            this.colRBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRBKY.FieldName = "RBKY";
            this.colRBKY.Name = "colRBKY";
            this.colRBKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RBKY", "{0:#,###.00 B;#,###.00 A; }")});
            this.colRBKY.Visible = true;
            // 
            // colRBRCBKY
            // 
            this.colRBRCBKY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colRBRCBKY.AppearanceCell.Options.UseBackColor = true;
            this.colRBRCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colRBRCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRBRCBKY.Caption = "BrçBky";
            this.colRBRCBKY.DisplayFormat.FormatString = "n";
            this.colRBRCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRBRCBKY.FieldName = "RBRCBKY";
            this.colRBRCBKY.Name = "colRBRCBKY";
            this.colRBRCBKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RBRCBKY", "{0:#,###.00;#,###.00; }")});
            this.colRBRCBKY.Visible = true;
            // 
            // colRALCBKY
            // 
            this.colRALCBKY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colRALCBKY.AppearanceCell.Options.UseBackColor = true;
            this.colRALCBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colRALCBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRALCBKY.Caption = "AlcBky";
            this.colRALCBKY.DisplayFormat.FormatString = "n";
            this.colRALCBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRALCBKY.FieldName = "RALCBKY";
            this.colRALCBKY.Name = "colRALCBKY";
            this.colRALCBKY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RALCBKY", "{0:#,###.00;#,###.00; }")});
            this.colRALCBKY.Visible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colHSPNO);
            this.gridBand1.Columns.Add(this.colDVZ);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 119;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridBand2.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Dvz";
            this.gridBand2.Columns.Add(this.colDBRC);
            this.gridBand2.Columns.Add(this.colDALC);
            this.gridBand2.Columns.Add(this.colDBKY);
            this.gridBand2.Columns.Add(this.colDBRCBKY);
            this.gridBand2.Columns.Add(this.colDALCBKY);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 387;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridBand3.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "EUR";
            this.gridBand3.Columns.Add(this.colRBRC);
            this.gridBand3.Columns.Add(this.colRALC);
            this.gridBand3.Columns.Add(this.colRBKY);
            this.gridBand3.Columns.Add(this.colRBRCBKY);
            this.gridBand3.Columns.Add(this.colRALCBKY);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 375;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "TL";
            this.gridBand4.Columns.Add(this.colABRC);
            this.gridBand4.Columns.Add(this.colAALC);
            this.gridBand4.Columns.Add(this.colABKY);
            this.gridBand4.Columns.Add(this.colABRCBKY);
            this.gridBand4.Columns.Add(this.colAALCBKY);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 401;
            // 
            // AccHspNoBkyXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 228);
            this.Controls.Add(this.aCC_HSPNO_BKYGridControl);
            this.Name = "AccHspNoBkyXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccHspNoBkyXF";
            this.Load += new System.EventHandler(this.AccHspNoBkyXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_HSPNO_BKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_HSPNO_BKYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource aCC_HSPNO_BKYBindingSource;
        private AccountDataSetTableAdapters.ACC_HSPNO_BKYTableAdapter aCC_HSPNO_BKYTableAdapter;
        private DevExpress.XtraGrid.GridControl aCC_HSPNO_BKYGridControl;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHSPNO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDVZ;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDBRC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDALC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDBKY;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDBRCBKY;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDALCBKY;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRBRC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRALC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRBKY;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRBRCBKY;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRALCBKY;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colABRC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAALC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colABKY;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colABRCBKY;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAALCBKY;
    }
}
namespace tMax14.Account
{
    partial class Muavin
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
            this.accMuavinGridControl = new DevExpress.XtraGrid.GridControl();
            this.accMuavinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accMuavingridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAVDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colABRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAALC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDALC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accMuavinTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.ACC_MUAVINTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMuavinGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMuavinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMuavingridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accMuavinGridControl
            // 
            this.accMuavinGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.accMuavinGridControl.DataSource = this.accMuavinBindingSource;
            this.accMuavinGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accMuavinGridControl.Location = new System.Drawing.Point(0, 0);
            this.accMuavinGridControl.MainView = this.accMuavingridView;
            this.accMuavinGridControl.Name = "accMuavinGridControl";
            this.accMuavinGridControl.Size = new System.Drawing.Size(933, 304);
            this.accMuavinGridControl.TabIndex = 2;
            this.accMuavinGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.accMuavingridView});
            // 
            // accMuavinBindingSource
            // 
            this.accMuavinBindingSource.DataMember = "ACC_MUAVIN";
            this.accMuavinBindingSource.DataSource = this.accountDataSet;
            // 
            // accMuavingridView
            // 
            this.accMuavingridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAVDID,
            this.colAVBID,
            this.colTUR,
            this.colTRH,
            this.colHSPNO,
            this.colBA,
            this.colDTUT,
            this.colDDVZ,
            this.colDKUR,
            this.colAKUR,
            this.colABRC,
            this.colAALC,
            this.colREFTO,
            this.colREFID,
            this.gridColumn1,
            this.colATUT,
            this.colDBRC,
            this.colDALC});
            this.accMuavingridView.GridControl = this.accMuavinGridControl;
            this.accMuavingridView.GroupCount = 1;
            this.accMuavingridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "AVDID", this.colAVDID, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBRC", this.colDBRC, "{0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DALC", this.colDALC, "{0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABRC", this.colABRC, "{0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AALC", this.colAALC, "{0:n}")});
            this.accMuavingridView.Name = "accMuavingridView";
            this.accMuavingridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.accMuavingridView.OptionsBehavior.Editable = false;
            this.accMuavingridView.OptionsView.EnableAppearanceEvenRow = true;
            this.accMuavingridView.OptionsView.ShowFooter = true;
            this.accMuavingridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDDVZ, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.accMuavingridView.CustomSummaryExists += new DevExpress.Data.CustomSummaryExistEventHandler(this.accMuavingridView_CustomSummaryExists);
            this.accMuavingridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.accMuavingridView_CustomColumnDisplayText);
            // 
            // colAVDID
            // 
            this.colAVDID.Caption = "AVDid";
            this.colAVDID.DisplayFormat.FormatString = "n0";
            this.colAVDID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAVDID.FieldName = "AVDID";
            this.colAVDID.Name = "colAVDID";
            this.colAVDID.OptionsColumn.FixedWidth = true;
            this.colAVDID.Width = 60;
            // 
            // colAVBID
            // 
            this.colAVBID.Caption = "AVBid";
            this.colAVBID.DisplayFormat.FormatString = "n0";
            this.colAVBID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAVBID.FieldName = "AVBID";
            this.colAVBID.Name = "colAVBID";
            this.colAVBID.OptionsColumn.FixedWidth = true;
            this.colAVBID.Width = 60;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.OptionsColumn.FixedWidth = true;
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 1;
            this.colTUR.Width = 53;
            // 
            // colTRH
            // 
            this.colTRH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRH.Caption = "Tarih";
            this.colTRH.FieldName = "TRH";
            this.colTRH.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth;
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.FixedWidth = true;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 2;
            this.colTRH.Width = 69;
            // 
            // colHSPNO
            // 
            this.colHSPNO.Caption = "HspNo";
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 0;
            this.colHSPNO.Width = 104;
            // 
            // colBA
            // 
            this.colBA.AppearanceCell.Options.UseTextOptions = true;
            this.colBA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBA.AppearanceHeader.Options.UseTextOptions = true;
            this.colBA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBA.Caption = "B/A";
            this.colBA.FieldName = "BA";
            this.colBA.Name = "colBA";
            this.colBA.OptionsColumn.FixedWidth = true;
            this.colBA.Visible = true;
            this.colBA.VisibleIndex = 3;
            this.colBA.Width = 33;
            // 
            // colDTUT
            // 
            this.colDTUT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDTUT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDTUT.Caption = "Tut";
            this.colDTUT.DisplayFormat.FormatString = "n2";
            this.colDTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDTUT.FieldName = "DTUT";
            this.colDTUT.Name = "colDTUT";
            this.colDTUT.OptionsColumn.FixedWidth = true;
            this.colDTUT.Width = 93;
            // 
            // colDDVZ
            // 
            this.colDDVZ.AppearanceCell.Options.UseTextOptions = true;
            this.colDDVZ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDDVZ.AppearanceHeader.Options.UseTextOptions = true;
            this.colDDVZ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDDVZ.Caption = "Dvz";
            this.colDDVZ.FieldName = "DDVZ";
            this.colDDVZ.Name = "colDDVZ";
            this.colDDVZ.OptionsColumn.FixedWidth = true;
            this.colDDVZ.Visible = true;
            this.colDDVZ.VisibleIndex = 6;
            this.colDDVZ.Width = 46;
            // 
            // colDKUR
            // 
            this.colDKUR.FieldName = "DKUR";
            this.colDKUR.Name = "colDKUR";
            // 
            // colAKUR
            // 
            this.colAKUR.FieldName = "AKUR";
            this.colAKUR.Name = "colAKUR";
            // 
            // colABRC
            // 
            this.colABRC.AppearanceHeader.Options.UseTextOptions = true;
            this.colABRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colABRC.Caption = "Brç TRL";
            this.colABRC.DisplayFormat.FormatString = "n2";
            this.colABRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colABRC.FieldName = "ABRC";
            this.colABRC.Name = "colABRC";
            this.colABRC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABRC", "{0:n2}")});
            this.colABRC.Visible = true;
            this.colABRC.VisibleIndex = 6;
            this.colABRC.Width = 100;
            // 
            // colAALC
            // 
            this.colAALC.AppearanceHeader.Options.UseTextOptions = true;
            this.colAALC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAALC.Caption = "Alc TRL";
            this.colAALC.DisplayFormat.FormatString = "n2";
            this.colAALC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAALC.FieldName = "AALC";
            this.colAALC.Name = "colAALC";
            this.colAALC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AALC", "{0:n2}")});
            this.colAALC.Visible = true;
            this.colAALC.VisibleIndex = 7;
            this.colAALC.Width = 100;
            // 
            // colREFTO
            // 
            this.colREFTO.FieldName = "REFTO";
            this.colREFTO.Name = "colREFTO";
            // 
            // colREFID
            // 
            this.colREFID.AppearanceHeader.Options.UseTextOptions = true;
            this.colREFID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFID.Caption = "RefID";
            this.colREFID.FieldName = "REFID";
            this.colREFID.Name = "colREFID";
            this.colREFID.OptionsColumn.FixedWidth = true;
            this.colREFID.Visible = true;
            this.colREFID.VisibleIndex = 9;
            this.colREFID.Width = 60;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Kalan TRL";
            this.gridColumn1.FieldName = "aRunTotal";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 100;
            // 
            // colATUT
            // 
            this.colATUT.FieldName = "ATUT";
            this.colATUT.Name = "colATUT";
            // 
            // colDBRC
            // 
            this.colDBRC.AppearanceHeader.Options.UseBackColor = true;
            this.colDBRC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDBRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDBRC.Caption = "Brç Dvz";
            this.colDBRC.DisplayFormat.FormatString = "n";
            this.colDBRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDBRC.FieldName = "DBRC";
            this.colDBRC.Name = "colDBRC";
            this.colDBRC.Visible = true;
            this.colDBRC.VisibleIndex = 4;
            // 
            // colDALC
            // 
            this.colDALC.AppearanceHeader.Options.UseBackColor = true;
            this.colDALC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDALC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDALC.Caption = "Alc Dvz";
            this.colDALC.DisplayFormat.FormatString = "n";
            this.colDALC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDALC.FieldName = "DALC";
            this.colDALC.Name = "colDALC";
            this.colDALC.Visible = true;
            this.colDALC.VisibleIndex = 5;
            // 
            // accMuavinTableAdapter
            // 
            this.accMuavinTableAdapter.ClearBeforeFill = true;
            // 
            // Muavin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accMuavinGridControl);
            this.Name = "Muavin";
            this.Size = new System.Drawing.Size(933, 304);
            this.Load += new System.EventHandler(this.Muavin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMuavinGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMuavinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMuavingridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private DevExpress.XtraGrid.GridControl accMuavinGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView accMuavingridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAVDID;
        private DevExpress.XtraGrid.Columns.GridColumn colAVBID;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colBA;
        private DevExpress.XtraGrid.Columns.GridColumn colDTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colAKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colABRC;
        private DevExpress.XtraGrid.Columns.GridColumn colAALC;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTO;
        private DevExpress.XtraGrid.Columns.GridColumn colREFID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colATUT;
        private System.Windows.Forms.BindingSource accMuavinBindingSource;
        private AccountDataSetTableAdapters.ACC_MUAVINTableAdapter accMuavinTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDBRC;
        private DevExpress.XtraGrid.Columns.GridColumn colDALC;
    }
}
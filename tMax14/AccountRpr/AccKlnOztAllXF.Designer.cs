namespace tMax14.AccountRpr
{
    partial class AccKlnOztAllXF
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
            this.accKlnOztAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accKlnOztAllTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.ACC_KLN_OZT_ALLTableAdapter();
            this.accKlnOztAllGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hesapHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expLvl1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expLvl2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expLvl3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accKlnOztAllGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDALC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBRCKLN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDALCKLN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accKlnOztAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accKlnOztAllGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accKlnOztAllGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountRprDataSet
            // 
            this.accountRprDataSet.DataSetName = "AccountRprDataSet";
            this.accountRprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accKlnOztAllBindingSource
            // 
            this.accKlnOztAllBindingSource.DataMember = "ACC_KLN_OZT_ALL";
            this.accKlnOztAllBindingSource.DataSource = this.accountRprDataSet;
            // 
            // accKlnOztAllTableAdapter
            // 
            this.accKlnOztAllTableAdapter.ClearBeforeFill = true;
            // 
            // accKlnOztAllGridControl
            // 
            this.accKlnOztAllGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.accKlnOztAllGridControl.DataSource = this.accKlnOztAllBindingSource;
            this.accKlnOztAllGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accKlnOztAllGridControl.Location = new System.Drawing.Point(0, 0);
            this.accKlnOztAllGridControl.MainView = this.accKlnOztAllGridView;
            this.accKlnOztAllGridControl.Name = "accKlnOztAllGridControl";
            this.accKlnOztAllGridControl.Size = new System.Drawing.Size(1304, 289);
            this.accKlnOztAllGridControl.TabIndex = 1;
            this.accKlnOztAllGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.accKlnOztAllGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapHareketleriToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.expandLevelToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(160, 70);
            // 
            // hesapHareketleriToolStripMenuItem
            // 
            this.hesapHareketleriToolStripMenuItem.Name = "hesapHareketleriToolStripMenuItem";
            this.hesapHareketleriToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.hesapHareketleriToolStripMenuItem.Text = "Hesap Hareketleri";
            this.hesapHareketleriToolStripMenuItem.Click += new System.EventHandler(this.hesapHareketleriToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // expandLevelToolStripMenuItem
            // 
            this.expandLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expLvl1ToolStripMenuItem,
            this.expLvl2ToolStripMenuItem,
            this.expLvl3ToolStripMenuItem});
            this.expandLevelToolStripMenuItem.Name = "expandLevelToolStripMenuItem";
            this.expandLevelToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.expandLevelToolStripMenuItem.Text = "Expand Level";
            // 
            // expLvl1ToolStripMenuItem
            // 
            this.expLvl1ToolStripMenuItem.Name = "expLvl1ToolStripMenuItem";
            this.expLvl1ToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.expLvl1ToolStripMenuItem.Text = "1";
            this.expLvl1ToolStripMenuItem.Click += new System.EventHandler(this.expLvl1ToolStripMenuItem_Click);
            // 
            // expLvl2ToolStripMenuItem
            // 
            this.expLvl2ToolStripMenuItem.Name = "expLvl2ToolStripMenuItem";
            this.expLvl2ToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.expLvl2ToolStripMenuItem.Text = "2";
            this.expLvl2ToolStripMenuItem.Click += new System.EventHandler(this.expLvl2ToolStripMenuItem_Click);
            // 
            // expLvl3ToolStripMenuItem
            // 
            this.expLvl3ToolStripMenuItem.Name = "expLvl3ToolStripMenuItem";
            this.expLvl3ToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.expLvl3ToolStripMenuItem.Text = "3";
            this.expLvl3ToolStripMenuItem.Click += new System.EventHandler(this.expLvl3ToolStripMenuItem_Click);
            // 
            // accKlnOztAllGridView
            // 
            this.accKlnOztAllGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHSPNO,
            this.colHSPAD,
            this.colYID,
            this.colDDVZ,
            this.colDBRC,
            this.colDALC,
            this.colDBKY,
            this.colREFTO,
            this.colDBRCKLN,
            this.colDALCKLN});
            this.accKlnOztAllGridView.GridControl = this.accKlnOztAllGridControl;
            this.accKlnOztAllGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBRC", null, "   Brç: {0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DALC", null, "   Alc: {0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBKY", null, "   Bky: {0:#,###.00 B;#,###.00 A; }"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBRCKLN", null, "   BrçKln: {0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DALCKLN", null, "   AlcKln: {0:n}")});
            this.accKlnOztAllGridView.Name = "accKlnOztAllGridView";
            this.accKlnOztAllGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.accKlnOztAllGridView.OptionsBehavior.Editable = false;
            this.accKlnOztAllGridView.OptionsPrint.ExpandAllGroups = false;
            this.accKlnOztAllGridView.OptionsPrint.UsePrintStyles = false;
            this.accKlnOztAllGridView.OptionsView.BestFitMaxRowCount = 50;
            this.accKlnOztAllGridView.OptionsView.ColumnAutoWidth = false;
            this.accKlnOztAllGridView.OptionsView.ShowFooter = true;
            this.accKlnOztAllGridView.CustomSummaryExists += new DevExpress.Data.CustomSummaryExistEventHandler(this.accKlnOztAllGridView_CustomSummaryExists);
            // 
            // colHSPNO
            // 
            this.colHSPNO.Caption = "HspNo";
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 0;
            this.colHSPNO.Width = 180;
            // 
            // colHSPAD
            // 
            this.colHSPAD.Caption = "HspAd";
            this.colHSPAD.FieldName = "HSPAD";
            this.colHSPAD.Name = "colHSPAD";
            this.colHSPAD.Visible = true;
            this.colHSPAD.VisibleIndex = 1;
            this.colHSPAD.Width = 253;
            // 
            // colYID
            // 
            this.colYID.AppearanceCell.Options.UseTextOptions = true;
            this.colYID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYID.AppearanceHeader.Options.UseTextOptions = true;
            this.colYID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYID.Caption = "YI/D";
            this.colYID.FieldName = "YID";
            this.colYID.Name = "colYID";
            this.colYID.OptionsColumn.FixedWidth = true;
            this.colYID.Visible = true;
            this.colYID.VisibleIndex = 2;
            this.colYID.Width = 36;
            // 
            // colDDVZ
            // 
            this.colDDVZ.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colDDVZ.AppearanceCell.Options.UseFont = true;
            this.colDDVZ.AppearanceCell.Options.UseTextOptions = true;
            this.colDDVZ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDDVZ.AppearanceHeader.Options.UseTextOptions = true;
            this.colDDVZ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDDVZ.Caption = "Dvz";
            this.colDDVZ.FieldName = "DDVZ";
            this.colDDVZ.Name = "colDDVZ";
            this.colDDVZ.OptionsColumn.FixedWidth = true;
            this.colDDVZ.Visible = true;
            this.colDDVZ.VisibleIndex = 5;
            this.colDDVZ.Width = 40;
            // 
            // colDBRC
            // 
            this.colDBRC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDBRC.AppearanceCell.Options.UseBackColor = true;
            this.colDBRC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDBRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDBRC.Caption = "Brç";
            this.colDBRC.DisplayFormat.FormatString = "n";
            this.colDBRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDBRC.FieldName = "DBRC";
            this.colDBRC.Name = "colDBRC";
            this.colDBRC.Visible = true;
            this.colDBRC.VisibleIndex = 3;
            this.colDBRC.Width = 141;
            // 
            // colDALC
            // 
            this.colDALC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDALC.AppearanceCell.Options.UseBackColor = true;
            this.colDALC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDALC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDALC.Caption = "Alc";
            this.colDALC.DisplayFormat.FormatString = "n";
            this.colDALC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDALC.FieldName = "DALC";
            this.colDALC.Name = "colDALC";
            this.colDALC.Visible = true;
            this.colDALC.VisibleIndex = 4;
            this.colDALC.Width = 141;
            // 
            // colDBKY
            // 
            this.colDBKY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDBKY.AppearanceCell.Options.UseBackColor = true;
            this.colDBKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colDBKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDBKY.Caption = "Bky";
            this.colDBKY.DisplayFormat.FormatString = "#,###.00 B;#,###.00 A; ";
            this.colDBKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDBKY.FieldName = "DBKY";
            this.colDBKY.Name = "colDBKY";
            this.colDBKY.Width = 141;
            // 
            // colREFTO
            // 
            this.colREFTO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colREFTO.AppearanceCell.Options.UseFont = true;
            this.colREFTO.AppearanceCell.Options.UseTextOptions = true;
            this.colREFTO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFTO.AppearanceHeader.Options.UseTextOptions = true;
            this.colREFTO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFTO.Caption = "Tür";
            this.colREFTO.FieldName = "REFTO";
            this.colREFTO.Name = "colREFTO";
            this.colREFTO.OptionsColumn.FixedWidth = true;
            this.colREFTO.Visible = true;
            this.colREFTO.VisibleIndex = 6;
            this.colREFTO.Width = 50;
            // 
            // colDBRCKLN
            // 
            this.colDBRCKLN.AppearanceHeader.Options.UseTextOptions = true;
            this.colDBRCKLN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDBRCKLN.Caption = "Brç Kln";
            this.colDBRCKLN.DisplayFormat.FormatString = "n";
            this.colDBRCKLN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDBRCKLN.FieldName = "DBRCKLN";
            this.colDBRCKLN.Name = "colDBRCKLN";
            this.colDBRCKLN.Visible = true;
            this.colDBRCKLN.VisibleIndex = 7;
            this.colDBRCKLN.Width = 150;
            // 
            // colDALCKLN
            // 
            this.colDALCKLN.AppearanceHeader.Options.UseTextOptions = true;
            this.colDALCKLN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDALCKLN.Caption = "Alc Kln";
            this.colDALCKLN.DisplayFormat.FormatString = "n";
            this.colDALCKLN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDALCKLN.FieldName = "DALCKLN";
            this.colDALCKLN.Name = "colDALCKLN";
            this.colDALCKLN.Visible = true;
            this.colDALCKLN.VisibleIndex = 8;
            this.colDALCKLN.Width = 154;
            // 
            // AccKlnOztAllXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 289);
            this.Controls.Add(this.accKlnOztAllGridControl);
            this.Name = "AccKlnOztAllXF";
            this.Text = "Müşteriler Brç/Alc/Kln Özet [AccKlnOztAllXF]";
            this.Load += new System.EventHandler(this.AccKlnOztAllXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accKlnOztAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accKlnOztAllGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accKlnOztAllGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountRprDataSet accountRprDataSet;
        private System.Windows.Forms.BindingSource accKlnOztAllBindingSource;
        private AccountRprDataSetTableAdapters.ACC_KLN_OZT_ALLTableAdapter accKlnOztAllTableAdapter;
        private DevExpress.XtraGrid.GridControl accKlnOztAllGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView accKlnOztAllGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPAD;
        private DevExpress.XtraGrid.Columns.GridColumn colYID;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDBRC;
        private DevExpress.XtraGrid.Columns.GridColumn colDALC;
        private DevExpress.XtraGrid.Columns.GridColumn colDBKY;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expLvl1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expLvl2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expLvl3ToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDBRCKLN;
        private DevExpress.XtraGrid.Columns.GridColumn colDALCKLN;
        private System.Windows.Forms.ToolStripMenuItem hesapHareketleriToolStripMenuItem;
    }
}
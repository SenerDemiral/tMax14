namespace tMax14.Misc
{
    partial class frkXF
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
            this.miscDataSet = new tMax14.Misc.MiscDataSet();
            this.frkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frkTableAdapter = new tMax14.Misc.MiscDataSetTableAdapters.FRKTableAdapter();
            this.frkGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.attachmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailGonderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frkGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFRKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFQRY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRPTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYYTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDITABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.miscQueriesTableAdapter = new tMax14.Misc.MiscDataSetTableAdapters.MiscQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.miscDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frkGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frkGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // miscDataSet
            // 
            this.miscDataSet.DataSetName = "MiscDataSet";
            this.miscDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frkBindingSource
            // 
            this.frkBindingSource.DataMember = "FRK";
            this.frkBindingSource.DataSource = this.miscDataSet;
            // 
            // frkTableAdapter
            // 
            this.frkTableAdapter.ClearBeforeFill = true;
            // 
            // frkGridControl
            // 
            this.frkGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.frkGridControl.DataSource = this.frkBindingSource;
            this.frkGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frkGridControl.Location = new System.Drawing.Point(0, 0);
            this.frkGridControl.MainView = this.frkGridView;
            this.frkGridControl.Name = "frkGridControl";
            this.frkGridControl.Size = new System.Drawing.Size(639, 305);
            this.frkGridControl.TabIndex = 2;
            this.frkGridControl.Tag = "FRK";
            this.frkGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.frkGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attachmentsToolStripMenuItem,
            this.onaylaToolStripMenuItem,
            this.mailGonderToolStripMenuItem,
            this.reportHistoryToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(151, 92);
            // 
            // attachmentsToolStripMenuItem
            // 
            this.attachmentsToolStripMenuItem.Name = "attachmentsToolStripMenuItem";
            this.attachmentsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.attachmentsToolStripMenuItem.Text = "Attachments";
            this.attachmentsToolStripMenuItem.Click += new System.EventHandler(this.attachmentsToolStripMenuItem_Click);
            // 
            // onaylaToolStripMenuItem
            // 
            this.onaylaToolStripMenuItem.Name = "onaylaToolStripMenuItem";
            this.onaylaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.onaylaToolStripMenuItem.Text = "Onayla";
            this.onaylaToolStripMenuItem.Click += new System.EventHandler(this.onaylaToolStripMenuItem_Click);
            // 
            // mailGonderToolStripMenuItem
            // 
            this.mailGonderToolStripMenuItem.Name = "mailGonderToolStripMenuItem";
            this.mailGonderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.mailGonderToolStripMenuItem.Text = "Mail gonder";
            this.mailGonderToolStripMenuItem.Click += new System.EventHandler(this.mailGonderToolStripMenuItem_Click);
            // 
            // reportHistoryToolStripMenuItem
            // 
            this.reportHistoryToolStripMenuItem.Name = "reportHistoryToolStripMenuItem";
            this.reportHistoryToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.reportHistoryToolStripMenuItem.Text = "Report History";
            this.reportHistoryToolStripMenuItem.Click += new System.EventHandler(this.reportHistoryToolStripMenuItem_Click);
            // 
            // frkGridView
            // 
            this.frkGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFRKID,
            this.colAD,
            this.colTRH,
            this.colFQRY,
            this.colRPTID,
            this.colONYUSR,
            this.colONYYTK,
            this.colONYTRH,
            this.colEDITABLE});
            this.frkGridView.GridControl = this.frkGridControl;
            this.frkGridView.Name = "frkGridView";
            this.frkGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.frkGridView_InitNewRow);
            // 
            // colFRKID
            // 
            this.colFRKID.FieldName = "FRKID";
            this.colFRKID.Name = "colFRKID";
            this.colFRKID.OptionsColumn.AllowEdit = false;
            this.colFRKID.OptionsColumn.AllowFocus = false;
            this.colFRKID.OptionsColumn.FixedWidth = true;
            this.colFRKID.Visible = true;
            this.colFRKID.VisibleIndex = 0;
            this.colFRKID.Width = 60;
            // 
            // colAD
            // 
            this.colAD.Caption = "Ad";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 2;
            this.colAD.Width = 111;
            // 
            // colTRH
            // 
            this.colTRH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRH.Caption = "Trh";
            this.colTRH.DisplayFormat.FormatString = "dd.MM.yy";
            this.colTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRH.FieldName = "TRH";
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.FixedWidth = true;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 3;
            this.colTRH.Width = 52;
            // 
            // colFQRY
            // 
            this.colFQRY.Caption = "Firma Query";
            this.colFQRY.FieldName = "FQRY";
            this.colFQRY.Name = "colFQRY";
            this.colFQRY.Visible = true;
            this.colFQRY.VisibleIndex = 4;
            this.colFQRY.Width = 181;
            // 
            // colRPTID
            // 
            this.colRPTID.Caption = "Rapor";
            this.colRPTID.FieldName = "RPTIDS";
            this.colRPTID.Name = "colRPTID";
            this.colRPTID.Visible = true;
            this.colRPTID.VisibleIndex = 5;
            // 
            // colONYUSR
            // 
            this.colONYUSR.Caption = "OnyUsr";
            this.colONYUSR.FieldName = "ONYUSR";
            this.colONYUSR.Name = "colONYUSR";
            this.colONYUSR.OptionsColumn.AllowEdit = false;
            this.colONYUSR.OptionsColumn.FixedWidth = true;
            this.colONYUSR.Visible = true;
            this.colONYUSR.VisibleIndex = 6;
            this.colONYUSR.Width = 50;
            // 
            // colONYYTK
            // 
            this.colONYYTK.Caption = "OnyYtk";
            this.colONYYTK.FieldName = "ONYYTK";
            this.colONYYTK.Name = "colONYYTK";
            this.colONYYTK.OptionsColumn.AllowEdit = false;
            this.colONYYTK.OptionsColumn.FixedWidth = true;
            this.colONYYTK.Visible = true;
            this.colONYYTK.VisibleIndex = 7;
            this.colONYYTK.Width = 50;
            // 
            // colONYTRH
            // 
            this.colONYTRH.Caption = "OnyTrh";
            this.colONYTRH.DisplayFormat.FormatString = "dd.MM.yy HH:mm";
            this.colONYTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colONYTRH.FieldName = "ONYTRH";
            this.colONYTRH.Name = "colONYTRH";
            this.colONYTRH.OptionsColumn.AllowEdit = false;
            this.colONYTRH.OptionsColumn.FixedWidth = true;
            this.colONYTRH.Visible = true;
            this.colONYTRH.VisibleIndex = 8;
            this.colONYTRH.Width = 95;
            // 
            // colEDITABLE
            // 
            this.colEDITABLE.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDITABLE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDITABLE.Caption = "E";
            this.colEDITABLE.FieldName = "EDITABLE";
            this.colEDITABLE.Name = "colEDITABLE";
            this.colEDITABLE.OptionsColumn.FixedWidth = true;
            this.colEDITABLE.Visible = true;
            this.colEDITABLE.VisibleIndex = 1;
            this.colEDITABLE.Width = 22;
            // 
            // frkXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 305);
            this.Controls.Add(this.frkGridControl);
            this.Name = "frkXF";
            this.Text = "frkXF";
            this.Load += new System.EventHandler(this.frkXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miscDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frkGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frkGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MiscDataSet miscDataSet;
        private System.Windows.Forms.BindingSource frkBindingSource;
        private MiscDataSetTableAdapters.FRKTableAdapter frkTableAdapter;
        private DevExpress.XtraGrid.GridControl frkGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView frkGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colFRKID;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colFQRY;
        private DevExpress.XtraGrid.Columns.GridColumn colONYUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colONYYTK;
        private DevExpress.XtraGrid.Columns.GridColumn colONYTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colEDITABLE;
        private MiscDataSetTableAdapters.MiscQueriesTableAdapter miscQueriesTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem attachmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onaylaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailGonderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportHistoryToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colRPTID;
    }
}
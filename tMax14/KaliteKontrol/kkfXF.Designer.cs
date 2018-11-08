namespace tMax14.KaliteKontrol
{
    partial class kkfXF
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
            this.kkfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kkfTableAdapter = new tMax14.KaliteKontrol.kkDataSetTableAdapters.KKFTableAdapter();
            this.kkfGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.attachmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kkfGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKKFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKKOID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDITABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDETAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colYTKUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHDFTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYAPTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAMRUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMHTUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDGRUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFUD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTLAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTNMUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKYTTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYYTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kkQueriesTableAdapter = new tMax14.KaliteKontrol.kkDataSetTableAdapters.KkQueriesTableAdapter();
            this.bosUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkfGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kkfGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // kkDataSet
            // 
            this.kkDataSet.DataSetName = "kkDataSet";
            this.kkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kkfBindingSource
            // 
            this.kkfBindingSource.DataMember = "KKF";
            this.kkfBindingSource.DataSource = this.kkDataSet;
            // 
            // kkfTableAdapter
            // 
            this.kkfTableAdapter.ClearBeforeFill = true;
            // 
            // kkfGridControl
            // 
            this.kkfGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.kkfGridControl.DataSource = this.kkfBindingSource;
            this.kkfGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kkfGridControl.Location = new System.Drawing.Point(0, 0);
            this.kkfGridControl.MainView = this.kkfGridView;
            this.kkfGridControl.Name = "kkfGridControl";
            this.kkfGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.kkfGridControl.Size = new System.Drawing.Size(1204, 317);
            this.kkfGridControl.TabIndex = 2;
            this.kkfGridControl.Tag = "KKF";
            this.kkfGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.kkfGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attachmentsToolStripMenuItem,
            this.layoutsToolStripMenuItem,
            this.sendEMailToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.onaylaToolStripMenuItem,
            this.bosUpdateToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 158);
            // 
            // attachmentsToolStripMenuItem
            // 
            this.attachmentsToolStripMenuItem.Name = "attachmentsToolStripMenuItem";
            this.attachmentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.attachmentsToolStripMenuItem.Text = "Attachments";
            this.attachmentsToolStripMenuItem.Click += new System.EventHandler(this.attachmentsToolStripMenuItem_Click);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // sendEMailToolStripMenuItem
            // 
            this.sendEMailToolStripMenuItem.Name = "sendEMailToolStripMenuItem";
            this.sendEMailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sendEMailToolStripMenuItem.Text = "Send eMail";
            this.sendEMailToolStripMenuItem.Click += new System.EventHandler(this.eMailToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // onaylaToolStripMenuItem
            // 
            this.onaylaToolStripMenuItem.Name = "onaylaToolStripMenuItem";
            this.onaylaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.onaylaToolStripMenuItem.Text = "Onayla";
            this.onaylaToolStripMenuItem.Click += new System.EventHandler(this.onaylaToolStripMenuItem_Click);
            // 
            // kkfGridView
            // 
            this.kkfGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKKFID,
            this.colKKOID,
            this.colEDITABLE,
            this.colDETAY,
            this.colYTKUSR,
            this.colHDFTRH,
            this.colYAPTRH,
            this.colAMRUSR,
            this.colMHTUSR,
            this.colTUR,
            this.colDGRUSR,
            this.colFUD,
            this.colACIKLAMA,
            this.colNOTLAR,
            this.colTNMUSR,
            this.colKYTTRH,
            this.colONYUSR,
            this.colONYYTK,
            this.colONYTRH});
            this.kkfGridView.GridControl = this.kkfGridControl;
            this.kkfGridView.Name = "kkfGridView";
            this.kkfGridView.OptionsView.ColumnAutoWidth = false;
            this.kkfGridView.OptionsView.RowAutoHeight = true;
            this.kkfGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.kkfGridView_InitNewRow);
            this.kkfGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.kkfGridView_CustomColumnDisplayText);
            // 
            // colKKFID
            // 
            this.colKKFID.FieldName = "KKFID";
            this.colKKFID.Name = "colKKFID";
            this.colKKFID.OptionsColumn.AllowEdit = false;
            this.colKKFID.OptionsColumn.AllowFocus = false;
            this.colKKFID.OptionsColumn.FixedWidth = true;
            this.colKKFID.Visible = true;
            this.colKKFID.VisibleIndex = 0;
            this.colKKFID.Width = 50;
            // 
            // colKKOID
            // 
            this.colKKOID.FieldName = "KKOID";
            this.colKKOID.Name = "colKKOID";
            this.colKKOID.OptionsColumn.AllowEdit = false;
            this.colKKOID.OptionsColumn.AllowFocus = false;
            this.colKKOID.OptionsColumn.FixedWidth = true;
            this.colKKOID.Width = 50;
            // 
            // colEDITABLE
            // 
            this.colEDITABLE.Caption = "E";
            this.colEDITABLE.FieldName = "EDITABLE";
            this.colEDITABLE.Name = "colEDITABLE";
            this.colEDITABLE.OptionsColumn.AllowEdit = false;
            this.colEDITABLE.OptionsColumn.AllowFocus = false;
            this.colEDITABLE.OptionsColumn.FixedWidth = true;
            this.colEDITABLE.Visible = true;
            this.colEDITABLE.VisibleIndex = 1;
            this.colEDITABLE.Width = 24;
            // 
            // colDETAY
            // 
            this.colDETAY.Caption = "Detay";
            this.colDETAY.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDETAY.FieldName = "DETAY";
            this.colDETAY.Name = "colDETAY";
            this.colDETAY.OptionsFilter.AllowAutoFilter = false;
            this.colDETAY.OptionsFilter.AllowFilter = false;
            this.colDETAY.Visible = true;
            this.colDETAY.VisibleIndex = 4;
            this.colDETAY.Width = 220;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colYTKUSR
            // 
            this.colYTKUSR.Caption = "Yetkili";
            this.colYTKUSR.FieldName = "YTKUSR";
            this.colYTKUSR.Name = "colYTKUSR";
            this.colYTKUSR.OptionsColumn.FixedWidth = true;
            this.colYTKUSR.Visible = true;
            this.colYTKUSR.VisibleIndex = 5;
            // 
            // colHDFTRH
            // 
            this.colHDFTRH.Caption = "HdfTrh";
            this.colHDFTRH.FieldName = "HDFTRH";
            this.colHDFTRH.Name = "colHDFTRH";
            this.colHDFTRH.OptionsColumn.FixedWidth = true;
            this.colHDFTRH.ToolTip = "Hedef Tarih";
            this.colHDFTRH.Visible = true;
            this.colHDFTRH.VisibleIndex = 6;
            // 
            // colYAPTRH
            // 
            this.colYAPTRH.Caption = "YapTrh";
            this.colYAPTRH.FieldName = "YAPTRH";
            this.colYAPTRH.Name = "colYAPTRH";
            this.colYAPTRH.OptionsColumn.FixedWidth = true;
            this.colYAPTRH.ToolTip = "Yapılma Tarihi";
            this.colYAPTRH.Visible = true;
            this.colYAPTRH.VisibleIndex = 7;
            // 
            // colAMRUSR
            // 
            this.colAMRUSR.Caption = "MhtpAmir";
            this.colAMRUSR.FieldName = "AMRUSR";
            this.colAMRUSR.Name = "colAMRUSR";
            this.colAMRUSR.OptionsColumn.FixedWidth = true;
            this.colAMRUSR.ToolTip = "Muhatap Amiri";
            this.colAMRUSR.Visible = true;
            this.colAMRUSR.VisibleIndex = 8;
            // 
            // colMHTUSR
            // 
            this.colMHTUSR.Caption = "Muhattap";
            this.colMHTUSR.FieldName = "MHTUSR";
            this.colMHTUSR.Name = "colMHTUSR";
            this.colMHTUSR.OptionsColumn.FixedWidth = true;
            this.colMHTUSR.Visible = true;
            this.colMHTUSR.VisibleIndex = 9;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.OptionsColumn.FixedWidth = true;
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 2;
            // 
            // colDGRUSR
            // 
            this.colDGRUSR.Caption = "DğrUsr";
            this.colDGRUSR.FieldName = "DGRUSR";
            this.colDGRUSR.Name = "colDGRUSR";
            this.colDGRUSR.ToolTip = "Değerlendiren User";
            this.colDGRUSR.Visible = true;
            this.colDGRUSR.VisibleIndex = 10;
            // 
            // colFUD
            // 
            this.colFUD.FieldName = "FUD";
            this.colFUD.Name = "colFUD";
            this.colFUD.ToolTip = "Faaliyet Uygunluk Değerlendirmesi";
            this.colFUD.Visible = true;
            this.colFUD.VisibleIndex = 11;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.Caption = "Açıklama";
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 12;
            // 
            // colNOTLAR
            // 
            this.colNOTLAR.Caption = "Notlar";
            this.colNOTLAR.FieldName = "NOTLAR";
            this.colNOTLAR.Name = "colNOTLAR";
            this.colNOTLAR.Visible = true;
            this.colNOTLAR.VisibleIndex = 13;
            // 
            // colTNMUSR
            // 
            this.colTNMUSR.Caption = "TnmUsr";
            this.colTNMUSR.FieldName = "TNMUSR";
            this.colTNMUSR.Name = "colTNMUSR";
            this.colTNMUSR.ToolTip = "Tanımlayan User";
            this.colTNMUSR.Visible = true;
            this.colTNMUSR.VisibleIndex = 3;
            // 
            // colKYTTRH
            // 
            this.colKYTTRH.Caption = "KytTrh";
            this.colKYTTRH.FieldName = "KYTTRH";
            this.colKYTTRH.Name = "colKYTTRH";
            this.colKYTTRH.OptionsColumn.AllowEdit = false;
            this.colKYTTRH.OptionsColumn.AllowFocus = false;
            this.colKYTTRH.ToolTip = "Kayıt Tarihi";
            // 
            // colONYUSR
            // 
            this.colONYUSR.Caption = "OnyUsr";
            this.colONYUSR.FieldName = "ONYUSR";
            this.colONYUSR.Name = "colONYUSR";
            this.colONYUSR.OptionsColumn.AllowEdit = false;
            this.colONYUSR.OptionsColumn.AllowFocus = false;
            this.colONYUSR.Visible = true;
            this.colONYUSR.VisibleIndex = 14;
            this.colONYUSR.Width = 50;
            // 
            // colONYYTK
            // 
            this.colONYYTK.Caption = "OnyYtk";
            this.colONYYTK.FieldName = "ONYYTK";
            this.colONYYTK.Name = "colONYYTK";
            this.colONYYTK.OptionsColumn.AllowEdit = false;
            this.colONYYTK.OptionsColumn.AllowFocus = false;
            this.colONYYTK.Visible = true;
            this.colONYYTK.VisibleIndex = 15;
            this.colONYYTK.Width = 50;
            // 
            // colONYTRH
            // 
            this.colONYTRH.Caption = "OnyTrh";
            this.colONYTRH.FieldName = "ONYTRH";
            this.colONYTRH.Name = "colONYTRH";
            this.colONYTRH.OptionsColumn.AllowEdit = false;
            this.colONYTRH.OptionsColumn.AllowFocus = false;
            this.colONYTRH.Visible = true;
            this.colONYTRH.VisibleIndex = 16;
            // 
            // bosUpdateToolStripMenuItem
            // 
            this.bosUpdateToolStripMenuItem.Name = "bosUpdateToolStripMenuItem";
            this.bosUpdateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bosUpdateToolStripMenuItem.Text = "Boş Update";
            this.bosUpdateToolStripMenuItem.Click += new System.EventHandler(this.bosUpdateToolStripMenuItem_Click);
            // 
            // kkfXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 317);
            this.Controls.Add(this.kkfGridControl);
            this.Name = "kkfXF";
            this.Tag = "";
            this.Text = "KaliteKontrol OlayFaaliyet [kkfXF]";
            this.Load += new System.EventHandler(this.kkfXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkfGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kkfGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private kkDataSet kkDataSet;
        private System.Windows.Forms.BindingSource kkfBindingSource;
        private kkDataSetTableAdapters.KKFTableAdapter kkfTableAdapter;
        private DevExpress.XtraGrid.GridControl kkfGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView kkfGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colKKFID;
        private DevExpress.XtraGrid.Columns.GridColumn colKKOID;
        private DevExpress.XtraGrid.Columns.GridColumn colDETAY;
        private DevExpress.XtraGrid.Columns.GridColumn colYTKUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colHDFTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colYAPTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colAMRUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colMHTUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private kkDataSetTableAdapters.KkQueriesTableAdapter kkQueriesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDGRUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colFUD;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTLAR;
        private DevExpress.XtraGrid.Columns.GridColumn colTNMUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colKYTTRH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem attachmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEMailToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onaylaToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colONYUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colONYYTK;
        private DevExpress.XtraGrid.Columns.GridColumn colONYTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colEDITABLE;
        private System.Windows.Forms.ToolStripMenuItem bosUpdateToolStripMenuItem;
    }
}
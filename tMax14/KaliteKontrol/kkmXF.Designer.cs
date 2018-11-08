namespace tMax14.KaliteKontrol
{
    partial class kkmXF
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
            this.kkmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kkmTableAdapter = new tMax14.KaliteKontrol.kkDataSetTableAdapters.KKMTableAdapter();
            this.kkmGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kkmGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKKMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKKOID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDITABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMHTUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FRCrepositoryItemGridLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.frcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colN2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKNTTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKNU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYTTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYTUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKYTTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYYTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kkQueriesTableAdapter = new tMax14.KaliteKontrol.kkDataSetTableAdapters.KkQueriesTableAdapter();
            this.frcTableAdapter = new tMax14.KaliteKontrol.kkDataSetTableAdapters.FRCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkmGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kkmGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCrepositoryItemGridLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // kkDataSet
            // 
            this.kkDataSet.DataSetName = "kkDataSet";
            this.kkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kkmBindingSource
            // 
            this.kkmBindingSource.DataMember = "KKM";
            this.kkmBindingSource.DataSource = this.kkDataSet;
            // 
            // kkmTableAdapter
            // 
            this.kkmTableAdapter.ClearBeforeFill = true;
            // 
            // kkmGridControl
            // 
            this.kkmGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.kkmGridControl.DataSource = this.kkmBindingSource;
            this.kkmGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kkmGridControl.Location = new System.Drawing.Point(0, 0);
            this.kkmGridControl.MainView = this.kkmGridView;
            this.kkmGridControl.Name = "kkmGridControl";
            this.kkmGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit,
            this.FRCrepositoryItemGridLookUpEdit});
            this.kkmGridControl.Size = new System.Drawing.Size(1293, 300);
            this.kkmGridControl.TabIndex = 2;
            this.kkmGridControl.Tag = "KKM";
            this.kkmGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.kkmGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutsToolStripMenuItem,
            this.showPreviewToolStripMenuItem,
            this.sendEMailToolStripMenuItem,
            this.onaylaToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(148, 92);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // showPreviewToolStripMenuItem
            // 
            this.showPreviewToolStripMenuItem.Name = "showPreviewToolStripMenuItem";
            this.showPreviewToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.showPreviewToolStripMenuItem.Text = "Show Preview";
            this.showPreviewToolStripMenuItem.Click += new System.EventHandler(this.showPreviewToolStripMenuItem_Click);
            // 
            // sendEMailToolStripMenuItem
            // 
            this.sendEMailToolStripMenuItem.Name = "sendEMailToolStripMenuItem";
            this.sendEMailToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sendEMailToolStripMenuItem.Text = "Send eMail";
            this.sendEMailToolStripMenuItem.Click += new System.EventHandler(this.eMailToolStripMenuItem_Click);
            // 
            // onaylaToolStripMenuItem
            // 
            this.onaylaToolStripMenuItem.Name = "onaylaToolStripMenuItem";
            this.onaylaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.onaylaToolStripMenuItem.Text = "Onayla";
            this.onaylaToolStripMenuItem.Click += new System.EventHandler(this.onaylaToolStripMenuItem_Click);
            // 
            // kkmGridView
            // 
            this.kkmGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKKMID,
            this.colKKOID,
            this.colEDITABLE,
            this.colTOB,
            this.colROT,
            this.colMOT,
            this.colMHTUSR,
            this.colFRTID,
            this.colFRCID,
            this.colN1,
            this.colN2,
            this.colN3,
            this.colN4,
            this.colN5,
            this.colKNTTRH,
            this.colKNU,
            this.colTYTTRH,
            this.colTYTUSR,
            this.colACIKLAMA,
            this.colKYTTRH,
            this.colONYUSR,
            this.colONYYTK,
            this.colONYTRH});
            this.kkmGridView.GridControl = this.kkmGridControl;
            this.kkmGridView.Name = "kkmGridView";
            this.kkmGridView.OptionsView.AutoCalcPreviewLineCount = true;
            this.kkmGridView.OptionsView.ColumnAutoWidth = false;
            this.kkmGridView.CalcPreviewText += new DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(this.kkmGridView_CalcPreviewText);
            this.kkmGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.kkmGridView_InitNewRow);
            // 
            // colKKMID
            // 
            this.colKKMID.FieldName = "KKMID";
            this.colKKMID.Name = "colKKMID";
            this.colKKMID.OptionsColumn.AllowEdit = false;
            this.colKKMID.OptionsColumn.AllowFocus = false;
            this.colKKMID.OptionsColumn.FixedWidth = true;
            this.colKKMID.Visible = true;
            this.colKKMID.VisibleIndex = 0;
            this.colKKMID.Width = 50;
            // 
            // colKKOID
            // 
            this.colKKOID.FieldName = "KKOID";
            this.colKKOID.Name = "colKKOID";
            this.colKKOID.OptionsColumn.AllowEdit = false;
            this.colKKOID.OptionsColumn.AllowFocus = false;
            this.colKKOID.Width = 65;
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
            // colTOB
            // 
            this.colTOB.FieldName = "TOB";
            this.colTOB.Name = "colTOB";
            this.colTOB.OptionsColumn.FixedWidth = true;
            this.colTOB.Visible = true;
            this.colTOB.VisibleIndex = 2;
            this.colTOB.Width = 50;
            // 
            // colROT
            // 
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.OptionsColumn.FixedWidth = true;
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 3;
            this.colROT.Width = 50;
            // 
            // colMOT
            // 
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.OptionsColumn.FixedWidth = true;
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 4;
            this.colMOT.Width = 50;
            // 
            // colMHTUSR
            // 
            this.colMHTUSR.Caption = "Muhatap";
            this.colMHTUSR.FieldName = "MHTUSR";
            this.colMHTUSR.Name = "colMHTUSR";
            this.colMHTUSR.Visible = true;
            this.colMHTUSR.VisibleIndex = 5;
            this.colMHTUSR.Width = 129;
            // 
            // colFRTID
            // 
            this.colFRTID.Caption = "Firma";
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 6;
            this.colFRTID.Width = 129;
            // 
            // colFRCID
            // 
            this.colFRCID.Caption = "Firma Personel";
            this.colFRCID.ColumnEdit = this.FRCrepositoryItemGridLookUpEdit;
            this.colFRCID.FieldName = "FRCID";
            this.colFRCID.Name = "colFRCID";
            this.colFRCID.Visible = true;
            this.colFRCID.VisibleIndex = 7;
            this.colFRCID.Width = 117;
            // 
            // FRCrepositoryItemGridLookUpEdit
            // 
            this.FRCrepositoryItemGridLookUpEdit.AutoHeight = false;
            this.FRCrepositoryItemGridLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FRCrepositoryItemGridLookUpEdit.DataSource = this.frcBindingSource;
            this.FRCrepositoryItemGridLookUpEdit.DisplayMember = "AD";
            this.FRCrepositoryItemGridLookUpEdit.Name = "FRCrepositoryItemGridLookUpEdit";
            this.FRCrepositoryItemGridLookUpEdit.NullText = "[]";
            this.FRCrepositoryItemGridLookUpEdit.ValueMember = "FRCID";
            this.FRCrepositoryItemGridLookUpEdit.View = this.repositoryItemGridLookUpEdit1View;
            this.FRCrepositoryItemGridLookUpEdit.Popup += new System.EventHandler(this.FRCrepositoryItemGridLookUpEdit_Popup);
            // 
            // frcBindingSource
            // 
            this.frcBindingSource.DataMember = "FRC";
            this.frcBindingSource.DataSource = this.kkDataSet;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colN1
            // 
            this.colN1.AppearanceHeader.Options.UseTextOptions = true;
            this.colN1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colN1.ColumnEdit = this.repositoryItemMemoExEdit;
            this.colN1.FieldName = "N1";
            this.colN1.Name = "colN1";
            this.colN1.OptionsColumn.FixedWidth = true;
            this.colN1.OptionsFilter.AllowAutoFilter = false;
            this.colN1.OptionsFilter.AllowFilter = false;
            this.colN1.Visible = true;
            this.colN1.VisibleIndex = 8;
            this.colN1.Width = 50;
            // 
            // repositoryItemMemoExEdit
            // 
            this.repositoryItemMemoExEdit.AutoHeight = false;
            this.repositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit.Name = "repositoryItemMemoExEdit";
            // 
            // colN2
            // 
            this.colN2.AppearanceHeader.Options.UseTextOptions = true;
            this.colN2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colN2.ColumnEdit = this.repositoryItemMemoExEdit;
            this.colN2.FieldName = "N2";
            this.colN2.Name = "colN2";
            this.colN2.OptionsColumn.FixedWidth = true;
            this.colN2.OptionsFilter.AllowAutoFilter = false;
            this.colN2.OptionsFilter.AllowFilter = false;
            this.colN2.Visible = true;
            this.colN2.VisibleIndex = 9;
            this.colN2.Width = 50;
            // 
            // colN3
            // 
            this.colN3.AppearanceHeader.Options.UseTextOptions = true;
            this.colN3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colN3.ColumnEdit = this.repositoryItemMemoExEdit;
            this.colN3.FieldName = "N3";
            this.colN3.Name = "colN3";
            this.colN3.OptionsColumn.FixedWidth = true;
            this.colN3.OptionsFilter.AllowAutoFilter = false;
            this.colN3.OptionsFilter.AllowFilter = false;
            this.colN3.Visible = true;
            this.colN3.VisibleIndex = 10;
            this.colN3.Width = 50;
            // 
            // colN4
            // 
            this.colN4.AppearanceHeader.Options.UseTextOptions = true;
            this.colN4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colN4.ColumnEdit = this.repositoryItemMemoExEdit;
            this.colN4.FieldName = "N4";
            this.colN4.Name = "colN4";
            this.colN4.OptionsColumn.FixedWidth = true;
            this.colN4.OptionsFilter.AllowAutoFilter = false;
            this.colN4.OptionsFilter.AllowFilter = false;
            this.colN4.Visible = true;
            this.colN4.VisibleIndex = 11;
            this.colN4.Width = 50;
            // 
            // colN5
            // 
            this.colN5.AppearanceHeader.Options.UseTextOptions = true;
            this.colN5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colN5.ColumnEdit = this.repositoryItemMemoExEdit;
            this.colN5.FieldName = "N5";
            this.colN5.Name = "colN5";
            this.colN5.OptionsColumn.FixedWidth = true;
            this.colN5.OptionsFilter.AllowAutoFilter = false;
            this.colN5.OptionsFilter.AllowFilter = false;
            this.colN5.Visible = true;
            this.colN5.VisibleIndex = 12;
            this.colN5.Width = 50;
            // 
            // colKNTTRH
            // 
            this.colKNTTRH.Caption = "KNTtrh";
            this.colKNTTRH.FieldName = "KNTTRH";
            this.colKNTTRH.Name = "colKNTTRH";
            this.colKNTTRH.ToolTip = "Kök Neden Tanımlama Tarihi";
            this.colKNTTRH.Visible = true;
            this.colKNTTRH.VisibleIndex = 13;
            // 
            // colKNU
            // 
            this.colKNU.FieldName = "KNU";
            this.colKNU.Name = "colKNU";
            this.colKNU.ToolTip = "Kük Neden Uygunluğu";
            this.colKNU.Visible = true;
            this.colKNU.VisibleIndex = 14;
            this.colKNU.Width = 42;
            // 
            // colTYTTRH
            // 
            this.colTYTTRH.Caption = "TytTrh";
            this.colTYTTRH.FieldName = "TYTTRH";
            this.colTYTTRH.Name = "colTYTTRH";
            this.colTYTTRH.ToolTip = "Teyit Tarihi";
            this.colTYTTRH.Visible = true;
            this.colTYTTRH.VisibleIndex = 15;
            // 
            // colTYTUSR
            // 
            this.colTYTUSR.Caption = "TytUsr";
            this.colTYTUSR.FieldName = "TYTUSR";
            this.colTYTUSR.Name = "colTYTUSR";
            this.colTYTUSR.ToolTip = "Teyit User";
            this.colTYTUSR.Visible = true;
            this.colTYTUSR.VisibleIndex = 16;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.Caption = "Açıklama";
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 17;
            // 
            // colKYTTRH
            // 
            this.colKYTTRH.Caption = "KytTrh";
            this.colKYTTRH.FieldName = "KYTTRH";
            this.colKYTTRH.Name = "colKYTTRH";
            this.colKYTTRH.OptionsColumn.AllowEdit = false;
            this.colKYTTRH.OptionsColumn.AllowFocus = false;
            // 
            // colONYUSR
            // 
            this.colONYUSR.Caption = "OnyUsr";
            this.colONYUSR.FieldName = "ONYUSR";
            this.colONYUSR.Name = "colONYUSR";
            this.colONYUSR.OptionsColumn.AllowEdit = false;
            this.colONYUSR.OptionsColumn.AllowFocus = false;
            this.colONYUSR.Visible = true;
            this.colONYUSR.VisibleIndex = 18;
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
            this.colONYYTK.VisibleIndex = 19;
            // 
            // colONYTRH
            // 
            this.colONYTRH.Caption = "OnyTrh";
            this.colONYTRH.FieldName = "ONYTRH";
            this.colONYTRH.Name = "colONYTRH";
            this.colONYTRH.OptionsColumn.AllowEdit = false;
            this.colONYTRH.OptionsColumn.AllowFocus = false;
            this.colONYTRH.Visible = true;
            this.colONYTRH.VisibleIndex = 20;
            // 
            // frcTableAdapter
            // 
            this.frcTableAdapter.ClearBeforeFill = true;
            // 
            // kkmXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 300);
            this.Controls.Add(this.kkmGridControl);
            this.Name = "kkmXF";
            this.Text = "KaliteKontrol OlayMuhatap [kkmXF]";
            this.Load += new System.EventHandler(this.kkmXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkmGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kkmGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRCrepositoryItemGridLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private kkDataSet kkDataSet;
        private System.Windows.Forms.BindingSource kkmBindingSource;
        private kkDataSetTableAdapters.KKMTableAdapter kkmTableAdapter;
        private DevExpress.XtraGrid.GridControl kkmGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView kkmGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colKKMID;
        private DevExpress.XtraGrid.Columns.GridColumn colKKOID;
        private DevExpress.XtraGrid.Columns.GridColumn colTOB;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colMHTUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colFRCID;
        private DevExpress.XtraGrid.Columns.GridColumn colN1;
        private DevExpress.XtraGrid.Columns.GridColumn colN2;
        private DevExpress.XtraGrid.Columns.GridColumn colN3;
        private DevExpress.XtraGrid.Columns.GridColumn colN4;
        private DevExpress.XtraGrid.Columns.GridColumn colN5;
        private kkDataSetTableAdapters.KkQueriesTableAdapter kkQueriesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit FRCrepositoryItemGridLookUpEdit;
        private System.Windows.Forms.BindingSource frcBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private kkDataSetTableAdapters.FRCTableAdapter frcTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colKNTTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colKNU;
        private DevExpress.XtraGrid.Columns.GridColumn colTYTTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colTYTUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colKYTTRH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onaylaToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colONYUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colONYYTK;
        private DevExpress.XtraGrid.Columns.GridColumn colONYTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colEDITABLE;
    }
}
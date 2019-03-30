namespace tMax14.Firma
{
    partial class frcaXF
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
            this.firmaDataSet = new tMax14.Firma.FirmaDataSet();
            this.frcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frcaTableAdapter = new tMax14.Firma.FirmaDataSetTableAdapters.FRCATableAdapter();
            this.frcaGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.onaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFRCAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDITABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIORITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PriorityRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colHIZMET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colILGI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIRSAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHACIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYYTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firmaQueriesTableAdapter = new tMax14.Firma.FirmaDataSetTableAdapters.FirmaQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcaGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityRepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firmaDataSet
            // 
            this.firmaDataSet.DataSetName = "FirmaDataSet";
            this.firmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frcaBindingSource
            // 
            this.frcaBindingSource.DataMember = "FRCA";
            this.frcaBindingSource.DataSource = this.firmaDataSet;
            // 
            // frcaTableAdapter
            // 
            this.frcaTableAdapter.ClearBeforeFill = true;
            // 
            // frcaGridControl
            // 
            this.frcaGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.frcaGridControl.DataSource = this.frcaBindingSource;
            this.frcaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frcaGridControl.Location = new System.Drawing.Point(0, 0);
            this.frcaGridControl.MainView = this.gridView1;
            this.frcaGridControl.Name = "frcaGridControl";
            this.frcaGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.PriorityRepositoryItemImageComboBox,
            this.repositoryItemImageComboBox1});
            this.frcaGridControl.Size = new System.Drawing.Size(942, 318);
            this.frcaGridControl.TabIndex = 1;
            this.frcaGridControl.Tag = "FRCA";
            this.frcaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onaylaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // onaylaToolStripMenuItem
            // 
            this.onaylaToolStripMenuItem.Name = "onaylaToolStripMenuItem";
            this.onaylaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.onaylaToolStripMenuItem.Text = "Onayla";
            this.onaylaToolStripMenuItem.Click += new System.EventHandler(this.onaylaToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFRCAID,
            this.colFRTID,
            this.colEDITABLE,
            this.colLOCID,
            this.colROT,
            this.colMOT,
            this.colPRIORITY,
            this.colFIYAT,
            this.colHIZMET,
            this.colILGI,
            this.colFIRSAT,
            this.colHACIM,
            this.colINFO,
            this.colONYUSR,
            this.colONYYTK,
            this.colONYTRH});
            this.gridView1.GridControl = this.frcaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // colFRCAID
            // 
            this.colFRCAID.FieldName = "FRCAID";
            this.colFRCAID.Name = "colFRCAID";
            this.colFRCAID.OptionsColumn.AllowEdit = false;
            this.colFRCAID.OptionsColumn.AllowFocus = false;
            this.colFRCAID.Visible = true;
            this.colFRCAID.VisibleIndex = 0;
            this.colFRCAID.Width = 59;
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.OptionsColumn.AllowEdit = false;
            this.colFRTID.OptionsColumn.AllowFocus = false;
            this.colFRTID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colFRTID.Width = 31;
            // 
            // colEDITABLE
            // 
            this.colEDITABLE.Caption = "E";
            this.colEDITABLE.FieldName = "EDITABLE";
            this.colEDITABLE.Name = "colEDITABLE";
            this.colEDITABLE.OptionsColumn.AllowEdit = false;
            this.colEDITABLE.OptionsColumn.AllowFocus = false;
            this.colEDITABLE.Visible = true;
            this.colEDITABLE.VisibleIndex = 1;
            this.colEDITABLE.Width = 27;
            // 
            // colLOCID
            // 
            this.colLOCID.Caption = "LocID";
            this.colLOCID.FieldName = "LOCID";
            this.colLOCID.Name = "colLOCID";
            this.colLOCID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colLOCID.Visible = true;
            this.colLOCID.VisibleIndex = 2;
            this.colLOCID.Width = 63;
            // 
            // colROT
            // 
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.OptionsColumn.FixedWidth = true;
            this.colROT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 3;
            this.colROT.Width = 40;
            // 
            // colMOT
            // 
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.OptionsColumn.FixedWidth = true;
            this.colMOT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 4;
            this.colMOT.Width = 40;
            // 
            // colPRIORITY
            // 
            this.colPRIORITY.Caption = "Priority";
            this.colPRIORITY.ColumnEdit = this.PriorityRepositoryItemImageComboBox;
            this.colPRIORITY.FieldName = "PRIORITY";
            this.colPRIORITY.Name = "colPRIORITY";
            this.colPRIORITY.OptionsColumn.FixedWidth = true;
            this.colPRIORITY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPRIORITY.Visible = true;
            this.colPRIORITY.VisibleIndex = 5;
            this.colPRIORITY.Width = 50;
            // 
            // PriorityRepositoryItemImageComboBox
            // 
            this.PriorityRepositoryItemImageComboBox.AutoHeight = false;
            this.PriorityRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PriorityRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("1", "1", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("2", "2", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("3", "3", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("4", "4", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("5", "5", -1)});
            this.PriorityRepositoryItemImageComboBox.Name = "PriorityRepositoryItemImageComboBox";
            // 
            // colFIYAT
            // 
            this.colFIYAT.Caption = "Fiyat";
            this.colFIYAT.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colFIYAT.FieldName = "FIYAT";
            this.colFIYAT.Name = "colFIYAT";
            this.colFIYAT.OptionsColumn.FixedWidth = true;
            this.colFIYAT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colFIYAT.Visible = true;
            this.colFIYAT.VisibleIndex = 6;
            this.colFIYAT.Width = 50;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("İyi", "1", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Orta", "2", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kötü", "3", -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colHIZMET
            // 
            this.colHIZMET.Caption = "Hizmet";
            this.colHIZMET.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colHIZMET.FieldName = "HIZMET";
            this.colHIZMET.Name = "colHIZMET";
            this.colHIZMET.OptionsColumn.FixedWidth = true;
            this.colHIZMET.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colHIZMET.Visible = true;
            this.colHIZMET.VisibleIndex = 7;
            this.colHIZMET.Width = 50;
            // 
            // colILGI
            // 
            this.colILGI.Caption = "İlgi";
            this.colILGI.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colILGI.FieldName = "ILGI";
            this.colILGI.Name = "colILGI";
            this.colILGI.OptionsColumn.FixedWidth = true;
            this.colILGI.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colILGI.Visible = true;
            this.colILGI.VisibleIndex = 8;
            this.colILGI.Width = 50;
            // 
            // colFIRSAT
            // 
            this.colFIRSAT.Caption = "Fırsat";
            this.colFIRSAT.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colFIRSAT.FieldName = "FIRSAT";
            this.colFIRSAT.Name = "colFIRSAT";
            this.colFIRSAT.Visible = true;
            this.colFIRSAT.VisibleIndex = 9;
            this.colFIRSAT.Width = 48;
            // 
            // colHACIM
            // 
            this.colHACIM.Caption = "Hacim";
            this.colHACIM.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colHACIM.FieldName = "HACIM";
            this.colHACIM.Name = "colHACIM";
            this.colHACIM.Visible = true;
            this.colHACIM.VisibleIndex = 10;
            this.colHACIM.Width = 55;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Info";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 11;
            this.colINFO.Width = 231;
            // 
            // colONYUSR
            // 
            this.colONYUSR.Caption = "OnyUsr";
            this.colONYUSR.FieldName = "ONYUSR";
            this.colONYUSR.Name = "colONYUSR";
            this.colONYUSR.OptionsColumn.AllowEdit = false;
            this.colONYUSR.OptionsColumn.AllowFocus = false;
            this.colONYUSR.Visible = true;
            this.colONYUSR.VisibleIndex = 12;
            this.colONYUSR.Width = 48;
            // 
            // colONYYTK
            // 
            this.colONYYTK.Caption = "OnyYtk";
            this.colONYYTK.FieldName = "ONYYTK";
            this.colONYYTK.Name = "colONYYTK";
            this.colONYYTK.OptionsColumn.AllowEdit = false;
            this.colONYYTK.OptionsColumn.AllowFocus = false;
            this.colONYYTK.Visible = true;
            this.colONYYTK.VisibleIndex = 13;
            this.colONYYTK.Width = 48;
            // 
            // colONYTRH
            // 
            this.colONYTRH.Caption = "OnyTrh";
            this.colONYTRH.FieldName = "ONYTRH";
            this.colONYTRH.Name = "colONYTRH";
            this.colONYTRH.OptionsColumn.AllowEdit = false;
            this.colONYTRH.OptionsColumn.AllowFocus = false;
            this.colONYTRH.Visible = true;
            this.colONYTRH.VisibleIndex = 14;
            this.colONYTRH.Width = 65;
            // 
            // frcaXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 318);
            this.Controls.Add(this.frcaGridControl);
            this.Name = "frcaXF";
            this.Text = "frcaXF";
            this.Load += new System.EventHandler(this.frcaXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcaGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityRepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirmaDataSet firmaDataSet;
        private System.Windows.Forms.BindingSource frcaBindingSource;
        private FirmaDataSetTableAdapters.FRCATableAdapter frcaTableAdapter;
        private DevExpress.XtraGrid.GridControl frcaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFRCAID;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colLOCID;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIORITY;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private FirmaDataSetTableAdapters.FirmaQueriesTableAdapter firmaQueriesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox PriorityRepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colFIYAT;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colHIZMET;
        private DevExpress.XtraGrid.Columns.GridColumn colILGI;
        private DevExpress.XtraGrid.Columns.GridColumn colONYUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colONYYTK;
        private DevExpress.XtraGrid.Columns.GridColumn colONYTRH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem onaylaToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colEDITABLE;
        private DevExpress.XtraGrid.Columns.GridColumn colFIRSAT;
        private DevExpress.XtraGrid.Columns.GridColumn colHACIM;
    }
}
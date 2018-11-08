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
            this.fRCAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFRCAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIORITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PriorityRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colHIZMET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colILGI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firmaQueriesTableAdapter = new tMax14.Firma.FirmaDataSetTableAdapters.FirmaQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRCAGridControl)).BeginInit();
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
            // fRCAGridControl
            // 
            this.fRCAGridControl.DataSource = this.frcaBindingSource;
            this.fRCAGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fRCAGridControl.Location = new System.Drawing.Point(0, 0);
            this.fRCAGridControl.MainView = this.gridView1;
            this.fRCAGridControl.Name = "fRCAGridControl";
            this.fRCAGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.PriorityRepositoryItemImageComboBox,
            this.repositoryItemImageComboBox1});
            this.fRCAGridControl.Size = new System.Drawing.Size(833, 318);
            this.fRCAGridControl.TabIndex = 1;
            this.fRCAGridControl.Tag = "FRCA";
            this.fRCAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFRCAID,
            this.colFRTID,
            this.colLOCID,
            this.colROT,
            this.colMOT,
            this.colPRIORITY,
            this.colFIYAT,
            this.colHIZMET,
            this.colILGI,
            this.colINFO});
            this.gridView1.GridControl = this.fRCAGridControl;
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
            this.colFRCAID.Width = 48;
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 1;
            this.colFRTID.Width = 48;
            // 
            // colLOCID
            // 
            this.colLOCID.Caption = "LocID";
            this.colLOCID.FieldName = "LOCID";
            this.colLOCID.Name = "colLOCID";
            this.colLOCID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colLOCID.Visible = true;
            this.colLOCID.VisibleIndex = 2;
            this.colLOCID.Width = 95;
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
            // colINFO
            // 
            this.colINFO.Caption = "Info";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 9;
            this.colINFO.Width = 344;
            // 
            // frcaXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 318);
            this.Controls.Add(this.fRCAGridControl);
            this.Name = "frcaXF";
            this.Text = "frcaXF";
            this.Load += new System.EventHandler(this.frcaXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRCAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityRepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirmaDataSet firmaDataSet;
        private System.Windows.Forms.BindingSource frcaBindingSource;
        private FirmaDataSetTableAdapters.FRCATableAdapter frcaTableAdapter;
        private DevExpress.XtraGrid.GridControl fRCAGridControl;
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
    }
}
namespace tMax14.AccountRpr
{
    partial class FrmMtbktHstXF
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
            this.fMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fMHTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.FMHTableAdapter();
            this.fmhGridControl = new DevExpress.XtraGrid.GridControl();
            this.fmhGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSTRY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountRprQueriesTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.AccountRprQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmhGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmhGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountRprDataSet
            // 
            this.accountRprDataSet.DataSetName = "AccountRprDataSet";
            this.accountRprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fMHBindingSource
            // 
            this.fMHBindingSource.DataMember = "FMH";
            this.fMHBindingSource.DataSource = this.accountRprDataSet;
            // 
            // fMHTableAdapter
            // 
            this.fMHTableAdapter.ClearBeforeFill = true;
            // 
            // fmhGridControl
            // 
            this.fmhGridControl.DataSource = this.fMHBindingSource;
            this.fmhGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmhGridControl.Location = new System.Drawing.Point(0, 0);
            this.fmhGridControl.MainView = this.fmhGridView;
            this.fmhGridControl.Name = "fmhGridControl";
            this.fmhGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.fmhGridControl.Size = new System.Drawing.Size(805, 304);
            this.fmhGridControl.TabIndex = 2;
            this.fmhGridControl.Tag = "FMH";
            this.fmhGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fmhGridView});
            // 
            // fmhGridView
            // 
            this.fmhGridView.Appearance.Preview.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fmhGridView.Appearance.Preview.Options.UseFont = true;
            this.fmhGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFRTID,
            this.colEXD,
            this.colSTU,
            this.colINFO,
            this.colHSTRY,
            this.colUSR});
            this.fmhGridView.GridControl = this.fmhGridControl;
            this.fmhGridView.Name = "fmhGridView";
            this.fmhGridView.OptionsView.AutoCalcPreviewLineCount = true;
            this.fmhGridView.OptionsView.ShowPreview = true;
            this.fmhGridView.PreviewFieldName = "HSTRY";
            // 
            // colFRTID
            // 
            this.colFRTID.Caption = "Firma";
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.OptionsColumn.AllowEdit = false;
            this.colFRTID.OptionsColumn.AllowFocus = false;
            this.colFRTID.OptionsColumn.FixedWidth = true;
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 1;
            this.colFRTID.Width = 100;
            // 
            // colEXD
            // 
            this.colEXD.FieldName = "EXD";
            this.colEXD.Name = "colEXD";
            this.colEXD.OptionsColumn.AllowEdit = false;
            this.colEXD.OptionsColumn.AllowFocus = false;
            this.colEXD.OptionsColumn.FixedWidth = true;
            this.colEXD.Visible = true;
            this.colEXD.VisibleIndex = 0;
            this.colEXD.Width = 70;
            // 
            // colSTU
            // 
            this.colSTU.Caption = "Statu";
            this.colSTU.FieldName = "STU";
            this.colSTU.Name = "colSTU";
            this.colSTU.OptionsColumn.FixedWidth = true;
            this.colSTU.Visible = true;
            this.colSTU.VisibleIndex = 2;
            this.colSTU.Width = 96;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Info";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 3;
            this.colINFO.Width = 468;
            // 
            // colHSTRY
            // 
            this.colHSTRY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colHSTRY.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colHSTRY.FieldName = "HSTRY";
            this.colHSTRY.Name = "colHSTRY";
            this.colHSTRY.OptionsColumn.ReadOnly = true;
            this.colHSTRY.Width = 162;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.repositoryItemMemoEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colUSR
            // 
            this.colUSR.FieldName = "USR";
            this.colUSR.Name = "colUSR";
            this.colUSR.OptionsColumn.FixedWidth = true;
            this.colUSR.OptionsColumn.ReadOnly = true;
            this.colUSR.Width = 53;
            // 
            // FrmMtbktHstXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 304);
            this.Controls.Add(this.fmhGridControl);
            this.Name = "FrmMtbktHstXF";
            this.Text = "FrmMtbktHstXF";
            this.Load += new System.EventHandler(this.FrmMtbktHstXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmhGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmhGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountRprDataSet accountRprDataSet;
        private System.Windows.Forms.BindingSource fMHBindingSource;
        private AccountRprDataSetTableAdapters.FMHTableAdapter fMHTableAdapter;
        private DevExpress.XtraGrid.GridControl fmhGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fmhGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colEXD;
        private DevExpress.XtraGrid.Columns.GridColumn colSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colHSTRY;
        private DevExpress.XtraGrid.Columns.GridColumn colUSR;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private AccountRprDataSetTableAdapters.AccountRprQueriesTableAdapter accountRprQueriesTableAdapter;
    }
}
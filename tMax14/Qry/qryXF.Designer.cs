namespace tMax14.Qry
{
    partial class qryXF
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
            this.qryDataSet = new tMax14.Qry.QryDataSet();
            this.qRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qRYTableAdapter = new tMax14.Qry.QryDataSetTableAdapters.QRYTableAdapter();
            this.qryGridControl = new DevExpress.XtraGrid.GridControl();
            this.qryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQRYID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTBL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWHR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.whrRepositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whrRepositoryItemMemoExEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // qryDataSet
            // 
            this.qryDataSet.DataSetName = "QryDataSet";
            this.qryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qRYBindingSource
            // 
            this.qRYBindingSource.DataMember = "QRY";
            this.qRYBindingSource.DataSource = this.qryDataSet;
            // 
            // qRYTableAdapter
            // 
            this.qRYTableAdapter.ClearBeforeFill = true;
            // 
            // qryGridControl
            // 
            this.qryGridControl.DataSource = this.qRYBindingSource;
            this.qryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qryGridControl.Location = new System.Drawing.Point(0, 0);
            this.qryGridControl.MainView = this.qryGridView;
            this.qryGridControl.Name = "qryGridControl";
            this.qryGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.whrRepositoryItemMemoExEdit});
            this.qryGridControl.Size = new System.Drawing.Size(360, 290);
            this.qryGridControl.TabIndex = 2;
            this.qryGridControl.Tag = "QRY";
            this.qryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.qryGridView});
            // 
            // qryGridView
            // 
            this.qryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQRYID,
            this.colTBL,
            this.colAD,
            this.colWHR});
            this.qryGridView.GridControl = this.qryGridControl;
            this.qryGridView.Name = "qryGridView";
            this.qryGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.qryGridView_InitNewRow);
            // 
            // colQRYID
            // 
            this.colQRYID.Caption = "QRYid";
            this.colQRYID.FieldName = "QRYID";
            this.colQRYID.Name = "colQRYID";
            this.colQRYID.OptionsColumn.AllowEdit = false;
            this.colQRYID.OptionsColumn.AllowFocus = false;
            this.colQRYID.OptionsColumn.FixedWidth = true;
            this.colQRYID.Visible = true;
            this.colQRYID.VisibleIndex = 0;
            this.colQRYID.Width = 60;
            // 
            // colTBL
            // 
            this.colTBL.Caption = "Tbl";
            this.colTBL.FieldName = "TBL";
            this.colTBL.Name = "colTBL";
            this.colTBL.OptionsColumn.AllowEdit = false;
            this.colTBL.OptionsColumn.AllowFocus = false;
            this.colTBL.OptionsColumn.FixedWidth = true;
            this.colTBL.Visible = true;
            this.colTBL.VisibleIndex = 1;
            this.colTBL.Width = 40;
            // 
            // colAD
            // 
            this.colAD.Caption = "Ad";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 2;
            this.colAD.Width = 119;
            // 
            // colWHR
            // 
            this.colWHR.Caption = "Where";
            this.colWHR.ColumnEdit = this.whrRepositoryItemMemoExEdit;
            this.colWHR.FieldName = "WHR";
            this.colWHR.Name = "colWHR";
            this.colWHR.Visible = true;
            this.colWHR.VisibleIndex = 3;
            this.colWHR.Width = 123;
            // 
            // whrRepositoryItemMemoExEdit
            // 
            this.whrRepositoryItemMemoExEdit.AutoHeight = false;
            this.whrRepositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.whrRepositoryItemMemoExEdit.Name = "whrRepositoryItemMemoExEdit";
            // 
            // qryXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 290);
            this.Controls.Add(this.qryGridControl);
            this.Name = "qryXF";
            this.Text = "qryXF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.qryXF_FormClosing);
            this.Load += new System.EventHandler(this.qryXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whrRepositoryItemMemoExEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QryDataSet qryDataSet;
        private System.Windows.Forms.BindingSource qRYBindingSource;
        private QryDataSetTableAdapters.QRYTableAdapter qRYTableAdapter;
        private DevExpress.XtraGrid.GridControl qryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView qryGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colQRYID;
        private DevExpress.XtraGrid.Columns.GridColumn colTBL;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colWHR;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit whrRepositoryItemMemoExEdit;
    }
}
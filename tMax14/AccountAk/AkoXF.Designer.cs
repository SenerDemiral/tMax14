namespace tMax14.AccountAk
{
    partial class AkoXF
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
            this.accountAkDataSet = new tMax14.AccountAk.AccountAkDataSet();
            this.aKOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aKOTableAdapter = new tMax14.AccountAk.AccountAkDataSetTableAdapters.AKOTableAdapter();
            this.akoGridControl = new DevExpress.XtraGrid.GridControl();
            this.akoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRPI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountAkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountAkDataSet
            // 
            this.accountAkDataSet.DataSetName = "AccountAkDataSet";
            this.accountAkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aKOBindingSource
            // 
            this.aKOBindingSource.DataMember = "AKO";
            this.aKOBindingSource.DataSource = this.accountAkDataSet;
            // 
            // aKOTableAdapter
            // 
            this.aKOTableAdapter.ClearBeforeFill = true;
            // 
            // akoGridControl
            // 
            this.akoGridControl.DataSource = this.aKOBindingSource;
            this.akoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.akoGridControl.Location = new System.Drawing.Point(0, 0);
            this.akoGridControl.MainView = this.akoGridView;
            this.akoGridControl.Name = "akoGridControl";
            this.akoGridControl.Size = new System.Drawing.Size(630, 319);
            this.akoGridControl.TabIndex = 2;
            this.akoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.akoGridView});
            // 
            // akoGridView
            // 
            this.akoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAKID,
            this.colAKMID,
            this.colNOH,
            this.colNOI,
            this.colCRPH,
            this.colCRPI});
            this.akoGridView.GridControl = this.akoGridControl;
            this.akoGridView.Name = "akoGridView";
            this.akoGridView.OptionsBehavior.ReadOnly = true;
            this.akoGridView.OptionsView.ShowFooter = true;
            // 
            // colAKID
            // 
            this.colAKID.FieldName = "AKID";
            this.colAKID.Name = "colAKID";
            // 
            // colAKMID
            // 
            this.colAKMID.Caption = "K/M Mrkz";
            this.colAKMID.FieldName = "AKMID";
            this.colAKMID.Name = "colAKMID";
            this.colAKMID.Visible = true;
            this.colAKMID.VisibleIndex = 0;
            // 
            // colNOH
            // 
            this.colNOH.AppearanceCell.Options.UseTextOptions = true;
            this.colNOH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOH.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOH.Caption = "#H";
            this.colNOH.FieldName = "NOH";
            this.colNOH.Name = "colNOH";
            this.colNOH.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NOH", "{0:n0}")});
            this.colNOH.ToolTip = "Bu dönem içinde faturalanmış House sayısı";
            this.colNOH.Visible = true;
            this.colNOH.VisibleIndex = 1;
            // 
            // colNOI
            // 
            this.colNOI.AppearanceCell.Options.UseTextOptions = true;
            this.colNOI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOI.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOI.Caption = "#Inv";
            this.colNOI.FieldName = "NOI";
            this.colNOI.Name = "colNOI";
            this.colNOI.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NOI", "{0:n0}")});
            this.colNOI.ToolTip = "Bu dönem içindeki fatura sayısı (Sadece Tür = AA / BS)";
            this.colNOI.Visible = true;
            this.colNOI.VisibleIndex = 2;
            // 
            // colCRPH
            // 
            this.colCRPH.AppearanceCell.Options.UseTextOptions = true;
            this.colCRPH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCRPH.AppearanceHeader.Options.UseTextOptions = true;
            this.colCRPH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCRPH.Caption = "#H /  ∑#H";
            this.colCRPH.DisplayFormat.FormatString = "n";
            this.colCRPH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCRPH.FieldName = "CRPH";
            this.colCRPH.Name = "colCRPH";
            this.colCRPH.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CRPH", "{0:p}")});
            this.colCRPH.Visible = true;
            this.colCRPH.VisibleIndex = 3;
            // 
            // colCRPI
            // 
            this.colCRPI.AppearanceCell.Options.UseTextOptions = true;
            this.colCRPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCRPI.AppearanceHeader.Options.UseTextOptions = true;
            this.colCRPI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCRPI.Caption = "#Inv /  ∑#Inv";
            this.colCRPI.DisplayFormat.FormatString = "n";
            this.colCRPI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCRPI.FieldName = "CRPI";
            this.colCRPI.Name = "colCRPI";
            this.colCRPI.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CRPI", "{0:p}")});
            this.colCRPI.Visible = true;
            this.colCRPI.VisibleIndex = 4;
            // 
            // AkoXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 319);
            this.Controls.Add(this.akoGridControl);
            this.Name = "AkoXF";
            this.Text = "AkoXF";
            this.Load += new System.EventHandler(this.AkoXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountAkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountAkDataSet accountAkDataSet;
        private System.Windows.Forms.BindingSource aKOBindingSource;
        private AccountAkDataSetTableAdapters.AKOTableAdapter aKOTableAdapter;
        private DevExpress.XtraGrid.GridControl akoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView akoGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAKID;
        private DevExpress.XtraGrid.Columns.GridColumn colAKMID;
        private DevExpress.XtraGrid.Columns.GridColumn colNOH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOI;
        private DevExpress.XtraGrid.Columns.GridColumn colCRPH;
        private DevExpress.XtraGrid.Columns.GridColumn colCRPI;
    }
}
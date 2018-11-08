namespace tMax14.AccountAk
{
    partial class AkdXF
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
            this.aKDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aKDTableAdapter = new tMax14.AccountAk.AccountAkDataSetTableAdapters.AKDTableAdapter();
            this.akdGridControl = new DevExpress.XtraGrid.GridControl();
            this.akdGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKAKMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMDGTSKL = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountAkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akdGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akdGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountAkDataSet
            // 
            this.accountAkDataSet.DataSetName = "AccountAkDataSet";
            this.accountAkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aKDBindingSource
            // 
            this.aKDBindingSource.DataMember = "AKD";
            this.aKDBindingSource.DataSource = this.accountAkDataSet;
            // 
            // aKDTableAdapter
            // 
            this.aKDTableAdapter.ClearBeforeFill = true;
            // 
            // akdGridControl
            // 
            this.akdGridControl.DataSource = this.aKDBindingSource;
            this.akdGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.akdGridControl.Location = new System.Drawing.Point(0, 0);
            this.akdGridControl.MainView = this.akdGridView;
            this.akdGridControl.Name = "akdGridControl";
            this.akdGridControl.Size = new System.Drawing.Size(378, 321);
            this.akdGridControl.TabIndex = 2;
            this.akdGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.akdGridView});
            // 
            // akdGridView
            // 
            this.akdGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAKID,
            this.colKAKMID,
            this.colMAKMID,
            this.colCRP,
            this.colMDGTSKL});
            this.akdGridView.GridControl = this.akdGridControl;
            this.akdGridView.GroupCount = 1;
            this.akdGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CRP", this.colCRP, "{0:p}")});
            this.akdGridView.Name = "akdGridView";
            this.akdGridView.OptionsBehavior.ReadOnly = true;
            this.akdGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMAKMID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colAKID
            // 
            this.colAKID.FieldName = "AKID";
            this.colAKID.Name = "colAKID";
            // 
            // colKAKMID
            // 
            this.colKAKMID.Caption = "KarMrkz";
            this.colKAKMID.FieldName = "KAKMID";
            this.colKAKMID.Name = "colKAKMID";
            this.colKAKMID.Visible = true;
            this.colKAKMID.VisibleIndex = 0;
            this.colKAKMID.Width = 128;
            // 
            // colMAKMID
            // 
            this.colMAKMID.Caption = "MsrfMrkz";
            this.colMAKMID.FieldName = "MAKMID";
            this.colMAKMID.Name = "colMAKMID";
            this.colMAKMID.Visible = true;
            this.colMAKMID.VisibleIndex = 1;
            // 
            // colCRP
            // 
            this.colCRP.AppearanceCell.Options.UseTextOptions = true;
            this.colCRP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCRP.AppearanceHeader.Options.UseTextOptions = true;
            this.colCRP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCRP.Caption = "Çarpan";
            this.colCRP.DisplayFormat.FormatString = "0.00;[0.00];-";
            this.colCRP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCRP.FieldName = "CRP";
            this.colCRP.Name = "colCRP";
            this.colCRP.Visible = true;
            this.colCRP.VisibleIndex = 2;
            this.colCRP.Width = 190;
            // 
            // colMDGTSKL
            // 
            this.colMDGTSKL.AppearanceCell.Options.UseTextOptions = true;
            this.colMDGTSKL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMDGTSKL.Caption = "MsrfDğtŞkl";
            this.colMDGTSKL.FieldName = "MDGTSKL";
            this.colMDGTSKL.Name = "colMDGTSKL";
            this.colMDGTSKL.OptionsColumn.FixedWidth = true;
            this.colMDGTSKL.Visible = true;
            this.colMDGTSKL.VisibleIndex = 1;
            this.colMDGTSKL.Width = 66;
            // 
            // AkdXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 321);
            this.Controls.Add(this.akdGridControl);
            this.Name = "AkdXF";
            this.Text = "AkdXF";
            this.Load += new System.EventHandler(this.AkdXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountAkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akdGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akdGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountAkDataSet accountAkDataSet;
        private System.Windows.Forms.BindingSource aKDBindingSource;
        private AccountAkDataSetTableAdapters.AKDTableAdapter aKDTableAdapter;
        private DevExpress.XtraGrid.GridControl akdGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView akdGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAKID;
        private DevExpress.XtraGrid.Columns.GridColumn colKAKMID;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKMID;
        private DevExpress.XtraGrid.Columns.GridColumn colCRP;
        private DevExpress.XtraGrid.Columns.GridColumn colMDGTSKL;
    }
}
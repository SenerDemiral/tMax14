namespace tMax14.AccountAk
{
    partial class AktXF
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
            this.aKTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aKTTableAdapter = new tMax14.AccountAk.AccountAkDataSetTableAdapters.AKTTableAdapter();
            this.aktGridControl = new DevExpress.XtraGrid.GridControl();
            this.aktGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDRTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLRTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountAkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountAkDataSet
            // 
            this.accountAkDataSet.DataSetName = "AccountAkDataSet";
            this.accountAkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aKTBindingSource
            // 
            this.aKTBindingSource.DataMember = "AKT";
            this.aKTBindingSource.DataSource = this.accountAkDataSet;
            // 
            // aKTTableAdapter
            // 
            this.aKTTableAdapter.ClearBeforeFill = true;
            // 
            // aktGridControl
            // 
            this.aktGridControl.DataSource = this.aKTBindingSource;
            this.aktGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aktGridControl.Location = new System.Drawing.Point(0, 0);
            this.aktGridControl.MainView = this.aktGridView;
            this.aktGridControl.Name = "aktGridControl";
            this.aktGridControl.Size = new System.Drawing.Size(417, 327);
            this.aktGridControl.TabIndex = 2;
            this.aktGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.aktGridView});
            // 
            // aktGridView
            // 
            this.aktGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAKID,
            this.colHSPNO,
            this.colTUR,
            this.colAKMID,
            this.colGDRTUT,
            this.colGLRTUT});
            this.aktGridView.GridControl = this.aktGridControl;
            this.aktGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GDRTUT", this.colGDRTUT, "{0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GLRTUT", this.colGLRTUT, "{0:n}")});
            this.aktGridView.Name = "aktGridView";
            this.aktGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.aktGridView.OptionsBehavior.ReadOnly = true;
            this.aktGridView.OptionsView.ShowFooter = true;
            // 
            // colAKID
            // 
            this.colAKID.FieldName = "AKID";
            this.colAKID.Name = "colAKID";
            // 
            // colHSPNO
            // 
            this.colHSPNO.Caption = "HspNo";
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 0;
            this.colHSPNO.Width = 157;
            // 
            // colTUR
            // 
            this.colTUR.AppearanceCell.Options.UseTextOptions = true;
            this.colTUR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTUR.Caption = "Tür";
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.OptionsColumn.FixedWidth = true;
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 2;
            this.colTUR.Width = 28;
            // 
            // colAKMID
            // 
            this.colAKMID.Caption = "Mrkz";
            this.colAKMID.FieldName = "AKMID";
            this.colAKMID.Name = "colAKMID";
            this.colAKMID.OptionsColumn.FixedWidth = true;
            this.colAKMID.Visible = true;
            this.colAKMID.VisibleIndex = 1;
            this.colAKMID.Width = 60;
            // 
            // colGDRTUT
            // 
            this.colGDRTUT.AppearanceHeader.Options.UseTextOptions = true;
            this.colGDRTUT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGDRTUT.Caption = "MsrfTut";
            this.colGDRTUT.DisplayFormat.FormatString = "n";
            this.colGDRTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGDRTUT.FieldName = "GDRTUT";
            this.colGDRTUT.Name = "colGDRTUT";
            this.colGDRTUT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GDRTUT", "{0:n}")});
            this.colGDRTUT.Visible = true;
            this.colGDRTUT.VisibleIndex = 3;
            this.colGDRTUT.Width = 80;
            // 
            // colGLRTUT
            // 
            this.colGLRTUT.Caption = "GlrTut";
            this.colGLRTUT.DisplayFormat.FormatString = "n";
            this.colGLRTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGLRTUT.FieldName = "GLRTUT";
            this.colGLRTUT.Name = "colGLRTUT";
            this.colGLRTUT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GLRTUT", "{0:n}")});
            this.colGLRTUT.Visible = true;
            this.colGLRTUT.VisibleIndex = 4;
            this.colGLRTUT.Width = 74;
            // 
            // AktXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 327);
            this.Controls.Add(this.aktGridControl);
            this.Name = "AktXF";
            this.Text = "AktXF";
            this.Load += new System.EventHandler(this.AktXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountAkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountAkDataSet accountAkDataSet;
        private System.Windows.Forms.BindingSource aKTBindingSource;
        private AccountAkDataSetTableAdapters.AKTTableAdapter aKTTableAdapter;
        private DevExpress.XtraGrid.GridControl aktGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView aktGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAKID;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colAKMID;
        private DevExpress.XtraGrid.Columns.GridColumn colGDRTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colGLRTUT;
    }
}
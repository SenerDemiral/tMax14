namespace tMax14.Misc
{
    partial class FrkContactsXF
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
            this.fRK_CONTACTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fRK_CONTACTSTableAdapter = new tMax14.Misc.MiscDataSetTableAdapters.FRK_CONTACTSTableAdapter();
            this.frkContactsGridControl = new DevExpress.XtraGrid.GridControl();
            this.frkContactsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIRMA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.miscDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRK_CONTACTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frkContactsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frkContactsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // miscDataSet
            // 
            this.miscDataSet.DataSetName = "MiscDataSet";
            this.miscDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fRK_CONTACTSBindingSource
            // 
            this.fRK_CONTACTSBindingSource.DataMember = "FRK_CONTACTS";
            this.fRK_CONTACTSBindingSource.DataSource = this.miscDataSet;
            // 
            // fRK_CONTACTSTableAdapter
            // 
            this.fRK_CONTACTSTableAdapter.ClearBeforeFill = true;
            // 
            // frkContactsGridControl
            // 
            this.frkContactsGridControl.DataSource = this.fRK_CONTACTSBindingSource;
            this.frkContactsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frkContactsGridControl.Location = new System.Drawing.Point(0, 0);
            this.frkContactsGridControl.MainView = this.frkContactsGridView;
            this.frkContactsGridControl.Name = "frkContactsGridControl";
            this.frkContactsGridControl.Size = new System.Drawing.Size(694, 320);
            this.frkContactsGridControl.TabIndex = 2;
            this.frkContactsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.frkContactsGridView});
            // 
            // frkContactsGridView
            // 
            this.frkContactsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAD,
            this.colEMAIL,
            this.colFIRMA});
            this.frkContactsGridView.GridControl = this.frkContactsGridControl;
            this.frkContactsGridView.Name = "frkContactsGridView";
            // 
            // colAD
            // 
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 0;
            // 
            // colEMAIL
            // 
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 1;
            // 
            // colFIRMA
            // 
            this.colFIRMA.FieldName = "FIRMA";
            this.colFIRMA.Name = "colFIRMA";
            this.colFIRMA.Visible = true;
            this.colFIRMA.VisibleIndex = 2;
            // 
            // FrkContactsXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 320);
            this.Controls.Add(this.frkContactsGridControl);
            this.Name = "FrkContactsXF";
            this.Text = "FrkContactsXF";
            this.Load += new System.EventHandler(this.FrkContactsXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miscDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRK_CONTACTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frkContactsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frkContactsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MiscDataSet miscDataSet;
        private System.Windows.Forms.BindingSource fRK_CONTACTSBindingSource;
        private MiscDataSetTableAdapters.FRK_CONTACTSTableAdapter fRK_CONTACTSTableAdapter;
        private DevExpress.XtraGrid.GridControl frkContactsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView frkContactsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colFIRMA;
    }
}
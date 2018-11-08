namespace tMax14.Account
{
    partial class FirmaDvzBkyXF
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
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.aCC_FRT_DVZ_BKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCC_FRT_DVZ_BKYTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.ACC_FRT_DVZ_BKYTableAdapter();
            this.frmDvzBkyGridControl = new DevExpress.XtraGrid.GridControl();
            this.frmDvzBkyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBRCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDALCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRBRCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRALCBKY = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_FRT_DVZ_BKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmDvzBkyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmDvzBkyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCC_FRT_DVZ_BKYBindingSource
            // 
            this.aCC_FRT_DVZ_BKYBindingSource.DataMember = "ACC_FRT_DVZ_BKY";
            this.aCC_FRT_DVZ_BKYBindingSource.DataSource = this.accountDataSet;
            // 
            // aCC_FRT_DVZ_BKYTableAdapter
            // 
            this.aCC_FRT_DVZ_BKYTableAdapter.ClearBeforeFill = true;
            // 
            // frmDvzBkyGridControl
            // 
            this.frmDvzBkyGridControl.DataSource = this.aCC_FRT_DVZ_BKYBindingSource;
            this.frmDvzBkyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmDvzBkyGridControl.Location = new System.Drawing.Point(0, 0);
            this.frmDvzBkyGridControl.MainView = this.frmDvzBkyGridView;
            this.frmDvzBkyGridControl.Name = "frmDvzBkyGridControl";
            this.frmDvzBkyGridControl.Size = new System.Drawing.Size(558, 421);
            this.frmDvzBkyGridControl.TabIndex = 1;
            this.frmDvzBkyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.frmDvzBkyGridView});
            // 
            // frmDvzBkyGridView
            // 
            this.frmDvzBkyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFRTID,
            this.colDDVZ,
            this.colDBRCBKY,
            this.colDALCBKY,
            this.colRBRCBKY,
            this.colRALCBKY});
            this.frmDvzBkyGridView.GridControl = this.frmDvzBkyGridControl;
            this.frmDvzBkyGridView.Name = "frmDvzBkyGridView";
            this.frmDvzBkyGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.frmDvzBkyGridView.OptionsBehavior.Editable = false;
            this.frmDvzBkyGridView.OptionsView.AllowCellMerge = true;
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 0;
            // 
            // colDDVZ
            // 
            this.colDDVZ.FieldName = "DDVZ";
            this.colDDVZ.Name = "colDDVZ";
            this.colDDVZ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDDVZ.Visible = true;
            this.colDDVZ.VisibleIndex = 1;
            // 
            // colDBRCBKY
            // 
            this.colDBRCBKY.FieldName = "DBRCBKY";
            this.colDBRCBKY.Name = "colDBRCBKY";
            this.colDBRCBKY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDBRCBKY.Visible = true;
            this.colDBRCBKY.VisibleIndex = 2;
            // 
            // colDALCBKY
            // 
            this.colDALCBKY.FieldName = "DALCBKY";
            this.colDALCBKY.Name = "colDALCBKY";
            this.colDALCBKY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDALCBKY.Visible = true;
            this.colDALCBKY.VisibleIndex = 3;
            // 
            // colRBRCBKY
            // 
            this.colRBRCBKY.FieldName = "RBRCBKY";
            this.colRBRCBKY.Name = "colRBRCBKY";
            this.colRBRCBKY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRBRCBKY.Visible = true;
            this.colRBRCBKY.VisibleIndex = 4;
            // 
            // colRALCBKY
            // 
            this.colRALCBKY.FieldName = "RALCBKY";
            this.colRALCBKY.Name = "colRALCBKY";
            this.colRALCBKY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRALCBKY.Visible = true;
            this.colRALCBKY.VisibleIndex = 5;
            // 
            // FirmaDvzBkyXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 421);
            this.Controls.Add(this.frmDvzBkyGridControl);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "FirmaDvzBkyXF";
            this.Text = "FirmaDvzBkyXF";
            this.Load += new System.EventHandler(this.FirmaDvzBkyXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_FRT_DVZ_BKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmDvzBkyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmDvzBkyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource aCC_FRT_DVZ_BKYBindingSource;
        private AccountDataSetTableAdapters.ACC_FRT_DVZ_BKYTableAdapter aCC_FRT_DVZ_BKYTableAdapter;
        private DevExpress.XtraGrid.GridControl frmDvzBkyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView frmDvzBkyGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDBRCBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colDALCBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colRBRCBKY;
        private DevExpress.XtraGrid.Columns.GridColumn colRALCBKY;
    }
}
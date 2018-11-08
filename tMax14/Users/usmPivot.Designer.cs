namespace tMax14.Users
{
    partial class usmPivot
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
            this.usmPivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.usmPivotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new tMax14.Users.UsersDataSet();
            this.fieldAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDRM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMAAS = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTRH = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUSTID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAy = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYil = new DevExpress.XtraPivotGrid.PivotGridField();
            this.usmPivotTableAdapter = new tMax14.Users.UsersDataSetTableAdapters.USM_PIVOTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usmPivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usmPivotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usmPivotGridControl
            // 
            this.usmPivotGridControl.DataSource = this.usmPivotBindingSource;
            this.usmPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usmPivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldAD,
            this.fieldDRM,
            this.fieldMAAS,
            this.fieldTRH,
            this.fieldUSTID,
            this.fieldAy,
            this.fieldYil});
            this.usmPivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.usmPivotGridControl.Name = "usmPivotGridControl";
            this.usmPivotGridControl.Size = new System.Drawing.Size(572, 273);
            this.usmPivotGridControl.TabIndex = 0;
            // 
            // usmPivotBindingSource
            // 
            this.usmPivotBindingSource.DataMember = "USM_PIVOT";
            this.usmPivotBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldAD
            // 
            this.fieldAD.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldAD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldAD.AreaIndex = 0;
            this.fieldAD.Caption = "Ad";
            this.fieldAD.FieldName = "AD";
            this.fieldAD.Name = "fieldAD";
            // 
            // fieldDRM
            // 
            this.fieldDRM.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldDRM.AreaIndex = 0;
            this.fieldDRM.Caption = "Drm";
            this.fieldDRM.FieldName = "DRM";
            this.fieldDRM.Name = "fieldDRM";
            // 
            // fieldMAAS
            // 
            this.fieldMAAS.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldMAAS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldMAAS.AreaIndex = 0;
            this.fieldMAAS.Caption = "Maaş";
            this.fieldMAAS.CellFormat.FormatString = "n2";
            this.fieldMAAS.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldMAAS.FieldName = "MAAS";
            this.fieldMAAS.Name = "fieldMAAS";
            // 
            // fieldTRH
            // 
            this.fieldTRH.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldTRH.AreaIndex = 1;
            this.fieldTRH.Caption = "Trh";
            this.fieldTRH.FieldName = "TRH";
            this.fieldTRH.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldTRH.Name = "fieldTRH";
            this.fieldTRH.UnboundFieldName = "fieldTRH";
            // 
            // fieldUSTID
            // 
            this.fieldUSTID.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldUSTID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldUSTID.AreaIndex = 4;
            this.fieldUSTID.FieldName = "USTID";
            this.fieldUSTID.Name = "fieldUSTID";
            this.fieldUSTID.Visible = false;
            // 
            // fieldAy
            // 
            this.fieldAy.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldAy.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldAy.AreaIndex = 1;
            this.fieldAy.Caption = "Ay";
            this.fieldAy.FieldName = "TRH";
            this.fieldAy.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldAy.Name = "fieldAy";
            this.fieldAy.UnboundFieldName = "fieldAy";
            // 
            // fieldYil
            // 
            this.fieldYil.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldYil.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYil.AreaIndex = 0;
            this.fieldYil.Caption = "Yıl";
            this.fieldYil.FieldName = "TRH";
            this.fieldYil.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYil.Name = "fieldYil";
            this.fieldYil.UnboundFieldName = "fieldYil";
            // 
            // usmPivotTableAdapter
            // 
            this.usmPivotTableAdapter.ClearBeforeFill = true;
            // 
            // usmPivot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 273);
            this.Controls.Add(this.usmPivotGridControl);
            this.Name = "usmPivot";
            this.Text = "usmPivot";
            this.Load += new System.EventHandler(this.usmPivot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usmPivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usmPivotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl usmPivotGridControl;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource usmPivotBindingSource;
        private UsersDataSetTableAdapters.USM_PIVOTTableAdapter usmPivotTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDRM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMAAS;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTRH;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUSTID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAy;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYil;
    }
}
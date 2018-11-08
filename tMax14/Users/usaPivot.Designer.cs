namespace tMax14.Users
{
    partial class usaPivot
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
            this.usaPivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.usaPivotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new tMax14.Users.UsersDataSet();
            this.fieldUSTID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDRM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTRH = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMIK = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAy = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYil = new DevExpress.XtraPivotGrid.PivotGridField();
            this.usaPivotTableAdapter = new tMax14.Users.UsersDataSetTableAdapters.USA_PIVOTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usaPivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usaPivotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usaPivotGridControl
            // 
            this.usaPivotGridControl.DataSource = this.usaPivotBindingSource;
            this.usaPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usaPivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldUSTID,
            this.fieldDRM,
            this.fieldAD,
            this.fieldTRH,
            this.fieldMIK,
            this.fieldAy,
            this.fieldYil});
            this.usaPivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.usaPivotGridControl.Name = "usaPivotGridControl";
            this.usaPivotGridControl.Size = new System.Drawing.Size(563, 273);
            this.usaPivotGridControl.TabIndex = 0;
            // 
            // usaPivotBindingSource
            // 
            this.usaPivotBindingSource.DataMember = "USA_PIVOT";
            this.usaPivotBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldUSTID
            // 
            this.fieldUSTID.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldUSTID.AreaIndex = 0;
            this.fieldUSTID.Caption = "USTID";
            this.fieldUSTID.FieldName = "USTID";
            this.fieldUSTID.Name = "fieldUSTID";
            this.fieldUSTID.Visible = false;
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
            // fieldMIK
            // 
            this.fieldMIK.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldMIK.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldMIK.AreaIndex = 0;
            this.fieldMIK.Caption = "Mik";
            this.fieldMIK.CellFormat.FormatString = "n0";
            this.fieldMIK.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldMIK.FieldName = "MIK";
            this.fieldMIK.Name = "fieldMIK";
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
            // usaPivotTableAdapter
            // 
            this.usaPivotTableAdapter.ClearBeforeFill = true;
            // 
            // usaPivot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 273);
            this.Controls.Add(this.usaPivotGridControl);
            this.Name = "usaPivot";
            this.Text = "usaPivot";
            this.Load += new System.EventHandler(this.usaPivot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usaPivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usaPivotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl usaPivotGridControl;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource usaPivotBindingSource;
        private UsersDataSetTableAdapters.USA_PIVOTTableAdapter usaPivotTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUSTID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDRM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTRH;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMIK;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAy;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYil;
    }
}
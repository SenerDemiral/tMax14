namespace tMax14.Users
{
    partial class usiPivot
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
            this.usiPivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDRM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIZNSURE = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIZNTRH = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIZNTUR = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIznAy = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIznYil = new DevExpress.XtraPivotGrid.PivotGridField();
            this.usiPivotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new tMax14.Users.UsersDataSet();
            this.usiPivotTableAdapter = new tMax14.Users.UsersDataSetTableAdapters.USI_PIVOTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usiPivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usiPivotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usiPivotGridControl
            // 
            this.usiPivotGridControl.DataSource = this.usiPivotBindingSource;
            this.usiPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usiPivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldAD,
            this.fieldDRM,
            this.fieldIZNSURE,
            this.fieldIZNTRH,
            this.fieldIZNTUR,
            this.fieldIznAy,
            this.fieldIznYil});
            this.usiPivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.usiPivotGridControl.Name = "usiPivotGridControl";
            this.usiPivotGridControl.Size = new System.Drawing.Size(818, 273);
            this.usiPivotGridControl.TabIndex = 0;
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
            // fieldIZNSURE
            // 
            this.fieldIZNSURE.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldIZNSURE.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldIZNSURE.AreaIndex = 0;
            this.fieldIZNSURE.Caption = "Süre(Gün)";
            this.fieldIZNSURE.CellFormat.FormatString = "n1";
            this.fieldIZNSURE.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldIZNSURE.FieldName = "IZNSURE";
            this.fieldIZNSURE.Name = "fieldIZNSURE";
            // 
            // fieldIZNTRH
            // 
            this.fieldIZNTRH.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldIZNTRH.AreaIndex = 2;
            this.fieldIZNTRH.Caption = "İzinTrh";
            this.fieldIZNTRH.FieldName = "IZNTRH";
            this.fieldIZNTRH.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldIZNTRH.Name = "fieldIZNTRH";
            this.fieldIZNTRH.UnboundFieldName = "fieldIZNTRH";
            // 
            // fieldIZNTUR
            // 
            this.fieldIZNTUR.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldIZNTUR.AreaIndex = 1;
            this.fieldIZNTUR.Caption = "İzinTür";
            this.fieldIZNTUR.FieldName = "IZNTUR";
            this.fieldIZNTUR.Name = "fieldIZNTUR";
            // 
            // fieldIznAy
            // 
            this.fieldIznAy.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldIznAy.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldIznAy.AreaIndex = 1;
            this.fieldIznAy.Caption = "İzinAy";
            this.fieldIznAy.FieldName = "IZNTRH";
            this.fieldIznAy.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldIznAy.Name = "fieldIznAy";
            this.fieldIznAy.UnboundFieldName = "fieldIznAy";
            // 
            // fieldIznYil
            // 
            this.fieldIznYil.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldIznYil.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldIznYil.AreaIndex = 0;
            this.fieldIznYil.Caption = "İzinYıl";
            this.fieldIznYil.FieldName = "IZNTRH";
            this.fieldIznYil.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldIznYil.Name = "fieldIznYil";
            this.fieldIznYil.UnboundFieldName = "fieldIznYil";
            // 
            // usiPivotBindingSource
            // 
            this.usiPivotBindingSource.DataMember = "USI_PIVOT";
            this.usiPivotBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usiPivotTableAdapter
            // 
            this.usiPivotTableAdapter.ClearBeforeFill = true;
            // 
            // usiPivot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 273);
            this.Controls.Add(this.usiPivotGridControl);
            this.Name = "usiPivot";
            this.Text = "usiPivot";
            this.Load += new System.EventHandler(this.usiPivot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usiPivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usiPivotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl usiPivotGridControl;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource usiPivotBindingSource;
        private UsersDataSetTableAdapters.USI_PIVOTTableAdapter usiPivotTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDRM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIZNSURE;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIZNTRH;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIZNTUR;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIznAy;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIznYil;
    }
}
namespace tMax14agn
{
    partial class opmUpdXF
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
            this.vGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.updateSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.wANAGNOPMUPDSELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new tMax14agn.DataSet();
            this.repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.rowOPMID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowNSTU = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPSTU = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowATA = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowROS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPOD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowE_PSTU = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowE_ATA = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowE_ROS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowE_POD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.wAN_AGN_OPM_UPD_SELTableAdapter = new tMax14agn.DataSetTableAdapters.WAN_AGN_OPM_UPD_SELTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wANAGNOPMUPDSELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // vGridControl
            // 
            this.vGridControl.DataSource = this.wANAGNOPMUPDSELBindingSource;
            this.vGridControl.Location = new System.Drawing.Point(12, 12);
            this.vGridControl.Name = "vGridControl";
            this.vGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit});
            this.vGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowOPMID,
            this.rowNSTU,
            this.rowPSTU,
            this.rowATA,
            this.rowROS,
            this.rowPOD,
            this.rowE_PSTU,
            this.rowE_ATA,
            this.rowE_ROS,
            this.rowE_POD});
            this.vGridControl.Size = new System.Drawing.Size(222, 118);
            this.vGridControl.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.updateSimpleButton);
            this.layoutControl1.Controls.Add(this.vGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(246, 168);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // updateSimpleButton
            // 
            this.updateSimpleButton.Location = new System.Drawing.Point(12, 134);
            this.updateSimpleButton.Name = "updateSimpleButton";
            this.updateSimpleButton.Size = new System.Drawing.Size(222, 22);
            this.updateSimpleButton.StyleController = this.layoutControl1;
            this.updateSimpleButton.TabIndex = 2;
            this.updateSimpleButton.Text = "Update";
            this.updateSimpleButton.Click += new System.EventHandler(this.updateSimpleButton_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(246, 168);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.vGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(226, 122);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.updateSimpleButton;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(226, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // wANAGNOPMUPDSELBindingSource
            // 
            this.wANAGNOPMUPDSELBindingSource.DataMember = "WAN_AGN_OPM_UPD_SEL";
            this.wANAGNOPMUPDSELBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemDateEdit
            // 
            this.repositoryItemDateEdit.AutoHeight = false;
            this.repositoryItemDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit.Mask.EditMask = "g";
            this.repositoryItemDateEdit.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit.Name = "repositoryItemDateEdit";
            // 
            // rowOPMID
            // 
            this.rowOPMID.Name = "rowOPMID";
            this.rowOPMID.Properties.Caption = "OpmID";
            this.rowOPMID.Properties.FieldName = "OPMID";
            this.rowOPMID.Properties.ReadOnly = true;
            // 
            // rowNSTU
            // 
            this.rowNSTU.Name = "rowNSTU";
            this.rowNSTU.Properties.Caption = "Statu";
            this.rowNSTU.Properties.FieldName = "NSTU";
            this.rowNSTU.Properties.ReadOnly = true;
            // 
            // rowPSTU
            // 
            this.rowPSTU.Name = "rowPSTU";
            this.rowPSTU.Properties.Caption = "Problem";
            this.rowPSTU.Properties.FieldName = "PSTU";
            // 
            // rowATA
            // 
            this.rowATA.Name = "rowATA";
            this.rowATA.Properties.Caption = "ATA";
            this.rowATA.Properties.FieldName = "ATA";
            this.rowATA.Properties.RowEdit = this.repositoryItemDateEdit;
            // 
            // rowROS
            // 
            this.rowROS.Name = "rowROS";
            this.rowROS.Properties.Caption = "ROS";
            this.rowROS.Properties.FieldName = "ROS";
            this.rowROS.Properties.RowEdit = this.repositoryItemDateEdit;
            // 
            // rowPOD
            // 
            this.rowPOD.Name = "rowPOD";
            this.rowPOD.Properties.Caption = "POD";
            this.rowPOD.Properties.FieldName = "POD";
            this.rowPOD.Properties.RowEdit = this.repositoryItemDateEdit;
            // 
            // rowE_PSTU
            // 
            this.rowE_PSTU.Name = "rowE_PSTU";
            this.rowE_PSTU.Properties.Caption = "E_PSTU";
            this.rowE_PSTU.Properties.FieldName = "E_PSTU";
            this.rowE_PSTU.Properties.ReadOnly = true;
            this.rowE_PSTU.Visible = false;
            // 
            // rowE_ATA
            // 
            this.rowE_ATA.Name = "rowE_ATA";
            this.rowE_ATA.Properties.Caption = "E_ATA";
            this.rowE_ATA.Properties.FieldName = "E_ATA";
            this.rowE_ATA.Properties.ReadOnly = true;
            this.rowE_ATA.Visible = false;
            // 
            // rowE_ROS
            // 
            this.rowE_ROS.Name = "rowE_ROS";
            this.rowE_ROS.Properties.Caption = "E_ROS";
            this.rowE_ROS.Properties.FieldName = "E_ROS";
            this.rowE_ROS.Properties.ReadOnly = true;
            this.rowE_ROS.Visible = false;
            // 
            // rowE_POD
            // 
            this.rowE_POD.Name = "rowE_POD";
            this.rowE_POD.Properties.Caption = "E_POD";
            this.rowE_POD.Properties.FieldName = "E_POD";
            this.rowE_POD.Properties.ReadOnly = true;
            this.rowE_POD.Visible = false;
            // 
            // wAN_AGN_OPM_UPD_SELTableAdapter
            // 
            this.wAN_AGN_OPM_UPD_SELTableAdapter.ClearBeforeFill = true;
            // 
            // opmUpdXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 168);
            this.Controls.Add(this.layoutControl1);
            this.Name = "opmUpdXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Updates";
            this.Load += new System.EventHandler(this.opmUpdXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wANAGNOPMUPDSELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl vGridControl;
        private System.Windows.Forms.BindingSource wANAGNOPMUPDSELBindingSource;
        private DataSet dataSet;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowOPMID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowNSTU;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPSTU;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowATA;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowROS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPOD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowE_PSTU;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowE_ATA;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowE_ROS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowE_POD;
        private DataSetTableAdapters.WAN_AGN_OPM_UPD_SELTableAdapter wAN_AGN_OPM_UPD_SELTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton updateSimpleButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
namespace tMax14agn
{
    partial class ophUpdXF
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.updateSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.vGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.wANAGNOPHUPDSELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new tMax14agn.DataSet();
            this.repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.rowOPHID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowNSTU = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPSTU = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowROH = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowROS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRTD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPOD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPODINF = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowE_PSTU = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowE_ROH = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowE_ROS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowE_RTD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowE_POD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowE_PODINF = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.wAN_AGN_OPH_UPD_SELTableAdapter = new tMax14agn.DataSetTableAdapters.WAN_AGN_OPH_UPD_SELTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wANAGNOPHUPDSELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.updateSimpleButton);
            this.layoutControl1.Controls.Add(this.vGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(248, 213);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // updateSimpleButton
            // 
            this.updateSimpleButton.Location = new System.Drawing.Point(12, 179);
            this.updateSimpleButton.Name = "updateSimpleButton";
            this.updateSimpleButton.Size = new System.Drawing.Size(224, 22);
            this.updateSimpleButton.StyleController = this.layoutControl1;
            this.updateSimpleButton.TabIndex = 2;
            this.updateSimpleButton.Text = "Update";
            this.updateSimpleButton.Click += new System.EventHandler(this.updateSimpleButton_Click);
            // 
            // vGridControl
            // 
            this.vGridControl.DataSource = this.wANAGNOPHUPDSELBindingSource;
            this.vGridControl.Location = new System.Drawing.Point(12, 12);
            this.vGridControl.Name = "vGridControl";
            this.vGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit});
            this.vGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowOPHID,
            this.rowNSTU,
            this.rowPSTU,
            this.rowROH,
            this.rowROS,
            this.rowRTD,
            this.rowPOD,
            this.rowPODINF,
            this.rowE_PSTU,
            this.rowE_ROH,
            this.rowE_ROS,
            this.rowE_RTD,
            this.rowE_POD,
            this.rowE_PODINF});
            this.vGridControl.Size = new System.Drawing.Size(224, 163);
            this.vGridControl.TabIndex = 0;
            // 
            // wANAGNOPHUPDSELBindingSource
            // 
            this.wANAGNOPHUPDSELBindingSource.DataMember = "WAN_AGN_OPH_UPD_SEL";
            this.wANAGNOPHUPDSELBindingSource.DataSource = this.dataSet;
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
            // rowOPHID
            // 
            this.rowOPHID.Name = "rowOPHID";
            this.rowOPHID.OptionsRow.AllowFocus = false;
            this.rowOPHID.Properties.Caption = "OphID";
            this.rowOPHID.Properties.FieldName = "OPHID";
            this.rowOPHID.Properties.ReadOnly = true;
            // 
            // rowNSTU
            // 
            this.rowNSTU.Name = "rowNSTU";
            this.rowNSTU.OptionsRow.AllowFocus = false;
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
            // rowROH
            // 
            this.rowROH.Name = "rowROH";
            this.rowROH.Properties.Caption = "ROH";
            this.rowROH.Properties.FieldName = "ROH";
            // 
            // rowROS
            // 
            this.rowROS.Name = "rowROS";
            this.rowROS.Properties.Caption = "ROS";
            this.rowROS.Properties.FieldName = "ROS";
            // 
            // rowRTD
            // 
            this.rowRTD.Name = "rowRTD";
            this.rowRTD.Properties.Caption = "RTD";
            this.rowRTD.Properties.FieldName = "RTD";
            // 
            // rowPOD
            // 
            this.rowPOD.Name = "rowPOD";
            this.rowPOD.Properties.Caption = "POD";
            this.rowPOD.Properties.FieldName = "POD";
            // 
            // rowPODINF
            // 
            this.rowPODINF.Name = "rowPODINF";
            this.rowPODINF.Properties.Caption = "POD Info";
            this.rowPODINF.Properties.FieldName = "PODINF";
            // 
            // rowE_PSTU
            // 
            this.rowE_PSTU.Name = "rowE_PSTU";
            this.rowE_PSTU.Properties.Caption = "E_PSTU";
            this.rowE_PSTU.Properties.FieldName = "E_PSTU";
            this.rowE_PSTU.Properties.ReadOnly = true;
            this.rowE_PSTU.Visible = false;
            // 
            // rowE_ROH
            // 
            this.rowE_ROH.Name = "rowE_ROH";
            this.rowE_ROH.Properties.Caption = "E_ROH";
            this.rowE_ROH.Properties.FieldName = "E_ROH";
            this.rowE_ROH.Properties.ReadOnly = true;
            this.rowE_ROH.Visible = false;
            // 
            // rowE_ROS
            // 
            this.rowE_ROS.Name = "rowE_ROS";
            this.rowE_ROS.Properties.Caption = "E_ROS";
            this.rowE_ROS.Properties.FieldName = "E_ROS";
            this.rowE_ROS.Properties.ReadOnly = true;
            this.rowE_ROS.Visible = false;
            // 
            // rowE_RTD
            // 
            this.rowE_RTD.Name = "rowE_RTD";
            this.rowE_RTD.Properties.Caption = "E_RTD";
            this.rowE_RTD.Properties.FieldName = "E_RTD";
            this.rowE_RTD.Properties.ReadOnly = true;
            this.rowE_RTD.Visible = false;
            // 
            // rowE_POD
            // 
            this.rowE_POD.Name = "rowE_POD";
            this.rowE_POD.Properties.Caption = "E_POD";
            this.rowE_POD.Properties.FieldName = "E_POD";
            this.rowE_POD.Properties.ReadOnly = true;
            this.rowE_POD.Visible = false;
            // 
            // rowE_PODINF
            // 
            this.rowE_PODINF.Name = "rowE_PODINF";
            this.rowE_PODINF.Properties.Caption = "E_PODINF";
            this.rowE_PODINF.Properties.FieldName = "E_PODINF";
            this.rowE_PODINF.Properties.ReadOnly = true;
            this.rowE_PODINF.Visible = false;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(248, 213);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.vGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(228, 167);
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
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 167);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(228, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // wAN_AGN_OPH_UPD_SELTableAdapter
            // 
            this.wAN_AGN_OPH_UPD_SELTableAdapter.ClearBeforeFill = true;
            // 
            // ophUpdXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 213);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ophUpdXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Updates";
            this.Load += new System.EventHandler(this.ophUpdXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wANAGNOPHUPDSELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton updateSimpleButton;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource wANAGNOPHUPDSELBindingSource;
        private DataSet dataSet;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowOPHID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowNSTU;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPSTU;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowROH;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowROS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRTD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPOD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPODINF;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowE_PSTU;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowE_ROH;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowE_ROS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowE_RTD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowE_POD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowE_PODINF;
        private DataSetTableAdapters.WAN_AGN_OPH_UPD_SELTableAdapter wAN_AGN_OPH_UPD_SELTableAdapter;
    }
}
namespace tMax14.Ops
{
    partial class ophBosXF
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
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.ophBosSelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opsDataSet = new tMax14.Ops.OpsDataSet();
            this.rowOPHID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowREFNO = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBYNMNO = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowWBD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPOD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPODINF = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowROH = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRROH = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPSTU = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowAOH = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRTR = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDRBD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDRCD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMALBDL = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMALBDLDVZ = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDDT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDPOGIRTRH = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDPOCIKTRH = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCRRID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDLVID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowORD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowARP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRTD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowAOC = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowKTN = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowACD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowROS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ophBosSelTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.OPH_BOS_SELTableAdapter();
            this.rowRROS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBYNMDRM = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophBosSelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // vGridControl1
            // 
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl1.DataSource = this.ophBosSelBindingSource;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(12, 12);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 122;
            this.vGridControl1.RowHeaderWidth = 78;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowOPHID,
            this.rowREFNO,
            this.rowBYNMNO,
            this.rowWBD,
            this.rowPOD,
            this.rowPODINF,
            this.rowROH,
            this.rowRROH,
            this.rowPSTU,
            this.rowAOH,
            this.rowRTR,
            this.rowDRBD,
            this.rowDRCD,
            this.rowMALBDL,
            this.rowMALBDLDVZ,
            this.rowDDT,
            this.rowDPOGIRTRH,
            this.rowDPOCIKTRH,
            this.rowCRRID,
            this.rowDLVID,
            this.rowORD,
            this.rowARP,
            this.rowRTD,
            this.rowAOC,
            this.rowKTN,
            this.rowACD,
            this.rowROS,
            this.rowRROS,
            this.rowBYNMDRM});
            this.vGridControl1.Size = new System.Drawing.Size(260, 503);
            this.vGridControl1.TabIndex = 0;
            // 
            // ophBosSelBindingSource
            // 
            this.ophBosSelBindingSource.DataMember = "OPH_BOS_SEL";
            this.ophBosSelBindingSource.DataSource = this.opsDataSet;
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rowOPHID
            // 
            this.rowOPHID.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rowOPHID.Appearance.Options.UseFont = true;
            this.rowOPHID.Appearance.Options.UseTextOptions = true;
            this.rowOPHID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rowOPHID.Name = "rowOPHID";
            this.rowOPHID.Properties.Caption = "OPHID";
            this.rowOPHID.Properties.FieldName = "OPHID";
            // 
            // rowREFNO
            // 
            this.rowREFNO.Name = "rowREFNO";
            this.rowREFNO.Properties.Caption = "RefNo";
            this.rowREFNO.Properties.FieldName = "REFNO";
            // 
            // rowBYNMNO
            // 
            this.rowBYNMNO.Name = "rowBYNMNO";
            this.rowBYNMNO.Properties.Caption = "BeyannameNo";
            this.rowBYNMNO.Properties.FieldName = "BYNMNO";
            // 
            // rowWBD
            // 
            this.rowWBD.Name = "rowWBD";
            this.rowWBD.Properties.Caption = "WBD";
            this.rowWBD.Properties.FieldName = "WBD";
            // 
            // rowPOD
            // 
            this.rowPOD.Height = 22;
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
            // rowROH
            // 
            this.rowROH.Name = "rowROH";
            this.rowROH.Properties.Caption = "ROH";
            this.rowROH.Properties.FieldName = "ROH";
            // 
            // rowRROH
            // 
            this.rowRROH.Name = "rowRROH";
            this.rowRROH.Properties.Caption = "rROH";
            this.rowRROH.Properties.FieldName = "RROH";
            // 
            // rowPSTU
            // 
            this.rowPSTU.Name = "rowPSTU";
            this.rowPSTU.Properties.Caption = "PrbStu";
            this.rowPSTU.Properties.FieldName = "PSTU";
            // 
            // rowAOH
            // 
            this.rowAOH.Name = "rowAOH";
            this.rowAOH.Properties.Caption = "AOH";
            this.rowAOH.Properties.FieldName = "AOH";
            // 
            // rowRTR
            // 
            this.rowRTR.Name = "rowRTR";
            this.rowRTR.Properties.Caption = "RTR";
            this.rowRTR.Properties.FieldName = "RTR";
            // 
            // rowDRBD
            // 
            this.rowDRBD.Name = "rowDRBD";
            this.rowDRBD.Properties.Caption = "DRBD";
            this.rowDRBD.Properties.FieldName = "DRBD";
            // 
            // rowDRCD
            // 
            this.rowDRCD.Name = "rowDRCD";
            this.rowDRCD.Properties.Caption = "DRCD";
            this.rowDRCD.Properties.FieldName = "DRCD";
            // 
            // rowMALBDL
            // 
            this.rowMALBDL.Name = "rowMALBDL";
            this.rowMALBDL.Properties.Caption = "MalBdl";
            this.rowMALBDL.Properties.FieldName = "MALBDL";
            // 
            // rowMALBDLDVZ
            // 
            this.rowMALBDLDVZ.Name = "rowMALBDLDVZ";
            this.rowMALBDLDVZ.Properties.Caption = "MalBdlDvz";
            this.rowMALBDLDVZ.Properties.FieldName = "MALBDLDVZ";
            // 
            // rowDDT
            // 
            this.rowDDT.Name = "rowDDT";
            this.rowDDT.Properties.Caption = "DocDeliveredTo";
            this.rowDDT.Properties.FieldName = "DDT";
            // 
            // rowDPOGIRTRH
            // 
            this.rowDPOGIRTRH.Name = "rowDPOGIRTRH";
            this.rowDPOGIRTRH.Properties.Caption = "DpoGirTrh";
            this.rowDPOGIRTRH.Properties.FieldName = "DPOGIRTRH";
            // 
            // rowDPOCIKTRH
            // 
            this.rowDPOCIKTRH.Name = "rowDPOCIKTRH";
            this.rowDPOCIKTRH.Properties.Caption = "DpoÇıkTrh";
            this.rowDPOCIKTRH.Properties.FieldName = "DPOCIKTRH";
            // 
            // rowCRRID
            // 
            this.rowCRRID.Name = "rowCRRID";
            this.rowCRRID.Properties.Caption = "Crr";
            this.rowCRRID.Properties.FieldName = "CRRID";
            // 
            // rowDLVID
            // 
            this.rowDLVID.Name = "rowDLVID";
            this.rowDLVID.Properties.Caption = "Dlvr";
            this.rowDLVID.Properties.FieldName = "DLVID";
            // 
            // rowORD
            // 
            this.rowORD.Name = "rowORD";
            this.rowORD.Properties.Caption = "ORD";
            this.rowORD.Properties.FieldName = "ORD";
            // 
            // rowARP
            // 
            this.rowARP.Name = "rowARP";
            this.rowARP.Properties.Caption = "ARP";
            this.rowARP.Properties.FieldName = "ARP";
            // 
            // rowRTD
            // 
            this.rowRTD.Name = "rowRTD";
            this.rowRTD.Properties.Caption = "RTD";
            this.rowRTD.Properties.FieldName = "RTD";
            // 
            // rowAOC
            // 
            this.rowAOC.Name = "rowAOC";
            this.rowAOC.Properties.Caption = "AOC";
            this.rowAOC.Properties.FieldName = "AOC";
            // 
            // rowKTN
            // 
            this.rowKTN.Name = "rowKTN";
            this.rowKTN.Properties.Caption = "KargoTakip";
            this.rowKTN.Properties.FieldName = "KTN";
            // 
            // rowACD
            // 
            this.rowACD.Name = "rowACD";
            this.rowACD.Properties.Caption = "ACD";
            this.rowACD.Properties.FieldName = "ACD";
            // 
            // rowROS
            // 
            this.rowROS.Name = "rowROS";
            this.rowROS.Properties.Caption = "ROS";
            this.rowROS.Properties.FieldName = "ROS";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.saveSimpleButton);
            this.layoutControl1.Controls.Add(this.vGridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(284, 553);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // saveSimpleButton
            // 
            this.saveSimpleButton.Location = new System.Drawing.Point(12, 519);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(260, 22);
            this.saveSimpleButton.StyleController = this.layoutControl1;
            this.saveSimpleButton.TabIndex = 4;
            this.saveSimpleButton.Text = "Kaydet";
            this.saveSimpleButton.Click += new System.EventHandler(this.saveSimpleButton_Click);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(284, 553);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.vGridControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(264, 507);
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.saveSimpleButton;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 507);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(264, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ophBosSelTableAdapter
            // 
            this.ophBosSelTableAdapter.ClearBeforeFill = true;
            // 
            // rowRROS
            // 
            this.rowRROS.Name = "rowRROS";
            this.rowRROS.Properties.Caption = "rROS";
            this.rowRROS.Properties.FieldName = "RROS";
            // 
            // rowBYNMDRM
            // 
            this.rowBYNMDRM.Name = "rowBYNMDRM";
            this.rowBYNMDRM.Properties.Caption = "BynmDrm";
            this.rowBYNMDRM.Properties.FieldName = "BYNMDRM";
            // 
            // ophBosXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 553);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ophBosXF";
            this.Text = "ophBosXF";
            this.Load += new System.EventHandler(this.ophBosXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophBosSelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private System.Windows.Forms.BindingSource ophBosSelBindingSource;
        private OpsDataSet opsDataSet;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowOPHID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowREFNO;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowWBD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPOD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPODINF;
        private OpsDataSetTableAdapters.OPH_BOS_SELTableAdapter ophBosSelTableAdapter;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBYNMNO;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowROH;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPSTU;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAOH;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRTR;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDRBD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDRCD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMALBDL;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMALBDLDVZ;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDDT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDPOGIRTRH;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDPOCIKTRH;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCRRID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDLVID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRROH;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowORD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowARP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRTD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAOC;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowKTN;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowACD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowROS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRROS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBYNMDRM;
    }
}
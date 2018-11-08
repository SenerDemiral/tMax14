namespace tMax14.Ops
{
    partial class ophChargeCreateXF
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
            this.opsDataSet = new tMax14.Ops.OpsDataSet();
            this.ophCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ophCCTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.OPH_CHARGE_CREATETableAdapter();
            this.tableAdapterManager = new tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager();
            this.ophCCGridControl = new DevExpress.XtraGrid.GridControl();
            this.ophCCGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRMKIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNEWFRMKIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHTAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNEWFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophCCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophCCGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ophCCBindingSource
            // 
            this.ophCCBindingSource.DataMember = "OPH_CHARGE_CREATE";
            this.ophCCBindingSource.DataSource = this.opsDataSet;
            // 
            // ophCCTableAdapter
            // 
            this.ophCCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AFDO_SELTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.OPCCTableAdapter = null;
            this.tableAdapterManager.OPCTableAdapter = null;
            this.tableAdapterManager.OPH_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPH_SELTableAdapter = null;
            this.tableAdapterManager.OPHTableAdapter = null;
            this.tableAdapterManager.OPM_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPM_CNTR_LOADTableAdapter = null;
            this.tableAdapterManager.OPM_SELTableAdapter = null;
            this.tableAdapterManager.OPM2TableAdapter = null;
            this.tableAdapterManager.OPMATableAdapter = null;
            this.tableAdapterManager.OPMCTableAdapter = null;
            this.tableAdapterManager.OPMITableAdapter = null;
            this.tableAdapterManager.OPMTableAdapter = null;
            this.tableAdapterManager.OPOSTableAdapter = null;
            this.tableAdapterManager.OPOTableAdapter = null;
            this.tableAdapterManager.OPP_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPPTableAdapter = null;
            this.tableAdapterManager.OPRH_SEL_DISTableAdapter = null;
            this.tableAdapterManager.PRSTableAdapter = null;
            this.tableAdapterManager.PRTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZMSLTableAdapter = null;
            // 
            // ophCCGridControl
            // 
            this.ophCCGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ophCCGridControl.DataSource = this.ophCCBindingSource;
            this.ophCCGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ophCCGridControl.Location = new System.Drawing.Point(0, 0);
            this.ophCCGridControl.MainView = this.ophCCGridView;
            this.ophCCGridControl.Name = "ophCCGridControl";
            this.ophCCGridControl.Size = new System.Drawing.Size(1002, 408);
            this.ophCCGridControl.TabIndex = 2;
            this.ophCCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ophCCGridView});
            // 
            // ophCCGridView
            // 
            this.ophCCGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHID,
            this.colROT,
            this.colMOT,
            this.colHS,
            this.colHC,
            this.colMS,
            this.colMC,
            this.colPTM,
            this.colTUR,
            this.colFRMKIM,
            this.colNEWFRMKIM,
            this.colFRTID,
            this.colNEWFRTID,
            this.colAHTID,
            this.colAHTAD,
            this.colMIK,
            this.colBRM,
            this.colFYT,
            this.colDVZ,
            this.colKDY});
            this.ophCCGridView.GridControl = this.ophCCGridControl;
            this.ophCCGridView.Name = "ophCCGridView";
            this.ophCCGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.ophCCGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.ophCCGridView.OptionsBehavior.Editable = false;
            // 
            // colHID
            // 
            this.colHID.FieldName = "HID";
            this.colHID.Name = "colHID";
            this.colHID.OptionsColumn.FixedWidth = true;
            this.colHID.Visible = true;
            this.colHID.VisibleIndex = 0;
            this.colHID.Width = 50;
            // 
            // colROT
            // 
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.Width = 56;
            // 
            // colMOT
            // 
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.Width = 56;
            // 
            // colHS
            // 
            this.colHS.FieldName = "HS";
            this.colHS.Name = "colHS";
            this.colHS.OptionsColumn.FixedWidth = true;
            this.colHS.Visible = true;
            this.colHS.VisibleIndex = 1;
            this.colHS.Width = 50;
            // 
            // colHC
            // 
            this.colHC.FieldName = "HC";
            this.colHC.Name = "colHC";
            this.colHC.OptionsColumn.FixedWidth = true;
            this.colHC.Visible = true;
            this.colHC.VisibleIndex = 2;
            this.colHC.Width = 50;
            // 
            // colMS
            // 
            this.colMS.FieldName = "MS";
            this.colMS.Name = "colMS";
            this.colMS.OptionsColumn.FixedWidth = true;
            this.colMS.Visible = true;
            this.colMS.VisibleIndex = 3;
            this.colMS.Width = 50;
            // 
            // colMC
            // 
            this.colMC.FieldName = "MC";
            this.colMC.Name = "colMC";
            this.colMC.OptionsColumn.FixedWidth = true;
            this.colMC.Visible = true;
            this.colMC.VisibleIndex = 4;
            this.colMC.Width = 50;
            // 
            // colPTM
            // 
            this.colPTM.FieldName = "PTM";
            this.colPTM.Name = "colPTM";
            this.colPTM.OptionsColumn.FixedWidth = true;
            this.colPTM.Visible = true;
            this.colPTM.VisibleIndex = 5;
            this.colPTM.Width = 50;
            // 
            // colFRMKIM
            // 
            this.colFRMKIM.Caption = "FrmKim";
            this.colFRMKIM.FieldName = "FRMKIM";
            this.colFRMKIM.Name = "colFRMKIM";
            this.colFRMKIM.OptionsColumn.FixedWidth = true;
            this.colFRMKIM.Visible = true;
            this.colFRMKIM.VisibleIndex = 7;
            this.colFRMKIM.Width = 50;
            // 
            // colNEWFRMKIM
            // 
            this.colNEWFRMKIM.Caption = "NewFrmKim";
            this.colNEWFRMKIM.FieldName = "NEWFRMKIM";
            this.colNEWFRMKIM.Name = "colNEWFRMKIM";
            this.colNEWFRMKIM.OptionsColumn.FixedWidth = true;
            this.colNEWFRMKIM.Visible = true;
            this.colNEWFRMKIM.VisibleIndex = 8;
            this.colNEWFRMKIM.Width = 50;
            // 
            // colFRTID
            // 
            this.colFRTID.Caption = "Firma";
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 9;
            this.colFRTID.Width = 188;
            // 
            // colAHTID
            // 
            this.colAHTID.Caption = "Charge";
            this.colAHTID.FieldName = "AHTID";
            this.colAHTID.Name = "colAHTID";
            this.colAHTID.Visible = true;
            this.colAHTID.VisibleIndex = 11;
            this.colAHTID.Width = 188;
            // 
            // colAHTAD
            // 
            this.colAHTAD.FieldName = "AHTAD";
            this.colAHTAD.Name = "colAHTAD";
            this.colAHTAD.Width = 83;
            // 
            // colMIK
            // 
            this.colMIK.FieldName = "MIK";
            this.colMIK.Name = "colMIK";
            this.colMIK.OptionsColumn.FixedWidth = true;
            this.colMIK.Visible = true;
            this.colMIK.VisibleIndex = 12;
            this.colMIK.Width = 50;
            // 
            // colBRM
            // 
            this.colBRM.FieldName = "BRM";
            this.colBRM.Name = "colBRM";
            this.colBRM.OptionsColumn.FixedWidth = true;
            this.colBRM.Visible = true;
            this.colBRM.VisibleIndex = 13;
            this.colBRM.Width = 50;
            // 
            // colFYT
            // 
            this.colFYT.FieldName = "FYT";
            this.colFYT.MinWidth = 40;
            this.colFYT.Name = "colFYT";
            this.colFYT.Visible = true;
            this.colFYT.VisibleIndex = 14;
            this.colFYT.Width = 64;
            // 
            // colDVZ
            // 
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.OptionsColumn.FixedWidth = true;
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 15;
            this.colDVZ.Width = 50;
            // 
            // colKDY
            // 
            this.colKDY.FieldName = "KDY";
            this.colKDY.Name = "colKDY";
            this.colKDY.OptionsColumn.FixedWidth = true;
            this.colKDY.Visible = true;
            this.colKDY.VisibleIndex = 16;
            this.colKDY.Width = 50;
            // 
            // colNEWFRTID
            // 
            this.colNEWFRTID.Caption = "NewFirma";
            this.colNEWFRTID.FieldName = "NEWFRTID";
            this.colNEWFRTID.Name = "colNEWFRTID";
            this.colNEWFRTID.Visible = true;
            this.colNEWFRTID.VisibleIndex = 10;
            this.colNEWFRTID.Width = 78;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 6;
            this.colTUR.Width = 52;
            // 
            // ophChargeCreateXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 408);
            this.Controls.Add(this.ophCCGridControl);
            this.Name = "ophChargeCreateXF";
            this.Text = "ophChargeCreateXF";
            this.Load += new System.EventHandler(this.ophChargeCreateXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophCCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophCCGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpsDataSet opsDataSet;
        private System.Windows.Forms.BindingSource ophCCBindingSource;
        private OpsDataSetTableAdapters.OPH_CHARGE_CREATETableAdapter ophCCTableAdapter;
        private OpsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl ophCCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ophCCGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colHID;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colHS;
        private DevExpress.XtraGrid.Columns.GridColumn colHC;
        private DevExpress.XtraGrid.Columns.GridColumn colMS;
        private DevExpress.XtraGrid.Columns.GridColumn colMC;
        private DevExpress.XtraGrid.Columns.GridColumn colPTM;
        private DevExpress.XtraGrid.Columns.GridColumn colFRMKIM;
        private DevExpress.XtraGrid.Columns.GridColumn colNEWFRMKIM;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colAHTID;
        private DevExpress.XtraGrid.Columns.GridColumn colAHTAD;
        private DevExpress.XtraGrid.Columns.GridColumn colMIK;
        private DevExpress.XtraGrid.Columns.GridColumn colBRM;
        private DevExpress.XtraGrid.Columns.GridColumn colFYT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colKDY;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colNEWFRTID;
    }
}
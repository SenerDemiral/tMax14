namespace tMax14.Ops
{
    partial class opMAWBstokXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(opMAWBstokXF));
            this.opsDataSet = new tMax14.Ops.OpsDataSet();
            this.opmiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opmiTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.OPMITableAdapter();
            this.tableAdapterManager = new tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager();
            this.opmiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.oPMIBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.opmiGridControl = new DevExpress.XtraGrid.GridControl();
            this.opmiGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCRRID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIRTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBASID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBITID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKLNIDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKLNMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmiBindingNavigator)).BeginInit();
            this.opmiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opmiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opmiBindingSource
            // 
            this.opmiBindingSource.DataMember = "OPMI";
            this.opmiBindingSource.DataSource = this.opsDataSet;
            // 
            // opmiTableAdapter
            // 
            this.opmiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AFDO_SELTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OBSDTableAdapter = null;
            this.tableAdapterManager.OBSTableAdapter = null;
            this.tableAdapterManager.OPCCTableAdapter = null;
            this.tableAdapterManager.OPCTableAdapter = null;
            this.tableAdapterManager.OPH_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPH_SELTableAdapter = null;
            this.tableAdapterManager.OPHTableAdapter = null;
            this.tableAdapterManager.OPM_ACC_ONY_TOPLUTableAdapter = null;
            this.tableAdapterManager.OPM_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPM_CNTR_LOADTableAdapter = null;
            this.tableAdapterManager.OPM_SELTableAdapter = null;
            this.tableAdapterManager.OPM2TableAdapter = null;
            this.tableAdapterManager.OPMATableAdapter = null;
            this.tableAdapterManager.OPMCTableAdapter = null;
            this.tableAdapterManager.OPMITableAdapter = this.opmiTableAdapter;
            this.tableAdapterManager.OPMTableAdapter = null;
            this.tableAdapterManager.OPOSTableAdapter = null;
            this.tableAdapterManager.OPOTableAdapter = null;
            this.tableAdapterManager.OPP_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPPTableAdapter = null;
            this.tableAdapterManager.OPRH_SEL_DISTableAdapter = null;
            this.tableAdapterManager.PRFTableAdapter = null;
            this.tableAdapterManager.PRSTableAdapter = null;
            this.tableAdapterManager.PRTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZMSLTableAdapter = null;
            // 
            // opmiBindingNavigator
            // 
            this.opmiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.opmiBindingNavigator.BindingSource = this.opmiBindingSource;
            this.opmiBindingNavigator.CountItem = null;
            this.opmiBindingNavigator.DeleteItem = null;
            this.opmiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.oPMIBindingNavigatorSaveItem});
            this.opmiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.opmiBindingNavigator.MoveFirstItem = null;
            this.opmiBindingNavigator.MoveLastItem = null;
            this.opmiBindingNavigator.MoveNextItem = null;
            this.opmiBindingNavigator.MovePreviousItem = null;
            this.opmiBindingNavigator.Name = "opmiBindingNavigator";
            this.opmiBindingNavigator.PositionItem = null;
            this.opmiBindingNavigator.Size = new System.Drawing.Size(644, 25);
            this.opmiBindingNavigator.TabIndex = 0;
            this.opmiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // oPMIBindingNavigatorSaveItem
            // 
            this.oPMIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oPMIBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oPMIBindingNavigatorSaveItem.Image")));
            this.oPMIBindingNavigatorSaveItem.Name = "oPMIBindingNavigatorSaveItem";
            this.oPMIBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.oPMIBindingNavigatorSaveItem.Text = "Save Data";
            this.oPMIBindingNavigatorSaveItem.Click += new System.EventHandler(this.oPMIBindingNavigatorSaveItem_Click);
            // 
            // opmiGridControl
            // 
            this.opmiGridControl.DataSource = this.opmiBindingSource;
            this.opmiGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opmiGridControl.Location = new System.Drawing.Point(0, 25);
            this.opmiGridControl.MainView = this.opmiGridView;
            this.opmiGridControl.Name = "opmiGridControl";
            this.opmiGridControl.Size = new System.Drawing.Size(644, 248);
            this.opmiGridControl.TabIndex = 1;
            this.opmiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.opmiGridView});
            // 
            // opmiGridView
            // 
            this.opmiGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCRRID,
            this.colGIRTRH,
            this.colBASID,
            this.colBITID,
            this.colKLNIDS,
            this.colKLNMIK});
            this.opmiGridView.GridControl = this.opmiGridControl;
            this.opmiGridView.Name = "opmiGridView";
            this.opmiGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.opmiGridView_ShowingEditor);
            // 
            // colCRRID
            // 
            this.colCRRID.Caption = "Carrier";
            this.colCRRID.FieldName = "CRRID";
            this.colCRRID.Name = "colCRRID";
            this.colCRRID.Visible = true;
            this.colCRRID.VisibleIndex = 0;
            this.colCRRID.Width = 125;
            // 
            // colGIRTRH
            // 
            this.colGIRTRH.Caption = "GirTrh";
            this.colGIRTRH.FieldName = "GIRTRH";
            this.colGIRTRH.Name = "colGIRTRH";
            this.colGIRTRH.OptionsColumn.FixedWidth = true;
            this.colGIRTRH.Visible = true;
            this.colGIRTRH.VisibleIndex = 1;
            this.colGIRTRH.Width = 68;
            // 
            // colBASID
            // 
            this.colBASID.Caption = "BaşID";
            this.colBASID.FieldName = "BASID";
            this.colBASID.Name = "colBASID";
            this.colBASID.OptionsColumn.FixedWidth = true;
            this.colBASID.Visible = true;
            this.colBASID.VisibleIndex = 2;
            this.colBASID.Width = 68;
            // 
            // colBITID
            // 
            this.colBITID.Caption = "BitID";
            this.colBITID.FieldName = "BITID";
            this.colBITID.Name = "colBITID";
            this.colBITID.OptionsColumn.FixedWidth = true;
            this.colBITID.Visible = true;
            this.colBITID.VisibleIndex = 3;
            this.colBITID.Width = 68;
            // 
            // colKLNIDS
            // 
            this.colKLNIDS.Caption = "Kalan IDs";
            this.colKLNIDS.FieldName = "KLNIDS";
            this.colKLNIDS.Name = "colKLNIDS";
            this.colKLNIDS.Visible = true;
            this.colKLNIDS.VisibleIndex = 5;
            this.colKLNIDS.Width = 297;
            // 
            // colKLNMIK
            // 
            this.colKLNMIK.AppearanceCell.Options.UseTextOptions = true;
            this.colKLNMIK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKLNMIK.Caption = "KlnMik";
            this.colKLNMIK.FieldName = "KLNMIK";
            this.colKLNMIK.Name = "colKLNMIK";
            this.colKLNMIK.OptionsColumn.AllowEdit = false;
            this.colKLNMIK.OptionsColumn.AllowFocus = false;
            this.colKLNMIK.Visible = true;
            this.colKLNMIK.VisibleIndex = 4;
            // 
            // opMAWBstokXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 273);
            this.Controls.Add(this.opmiGridControl);
            this.Controls.Add(this.opmiBindingNavigator);
            this.Name = "opMAWBstokXF";
            this.Text = "opMAWBstokXF";
            this.Load += new System.EventHandler(this.opMAWBstokXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmiBindingNavigator)).EndInit();
            this.opmiBindingNavigator.ResumeLayout(false);
            this.opmiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opmiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmiGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpsDataSet opsDataSet;
        private System.Windows.Forms.BindingSource opmiBindingSource;
        private OpsDataSetTableAdapters.OPMITableAdapter opmiTableAdapter;
        private OpsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator opmiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton oPMIBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl opmiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView opmiGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCRRID;
        private DevExpress.XtraGrid.Columns.GridColumn colGIRTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colBASID;
        private DevExpress.XtraGrid.Columns.GridColumn colBITID;
        private DevExpress.XtraGrid.Columns.GridColumn colKLNIDS;
        private DevExpress.XtraGrid.Columns.GridColumn colKLNMIK;
    }
}
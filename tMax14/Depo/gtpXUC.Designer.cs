namespace tMax14.Depo
{
    partial class gtpXUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.depoDataSet = new tMax14.Depo.DepoDataSet();
            this.gtpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gtpTableAdapter = new tMax14.Depo.DepoDataSetTableAdapters.GTPTableAdapter();
            this.tableAdapterManager = new tMax14.Depo.DepoDataSetTableAdapters.TableAdapterManager();
            this.gtpGridControl = new DevExpress.XtraGrid.GridControl();
            this.gtpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGTPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGTPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTANIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.depoQueriesTableAdapter = new tMax14.Depo.DepoDataSetTableAdapters.DepoQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtpGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // depoDataSet
            // 
            this.depoDataSet.DataSetName = "DepoDataSet";
            this.depoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gtpBindingSource
            // 
            this.gtpBindingSource.DataMember = "GTP";
            this.gtpBindingSource.DataSource = this.depoDataSet;
            // 
            // gtpTableAdapter
            // 
            this.gtpTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DPCATableAdapter = null;
            this.tableAdapterManager.DPGATableAdapter = null;
            this.tableAdapterManager.GTPTableAdapter = this.gtpTableAdapter;
            this.tableAdapterManager.UpdateOrder = tMax14.Depo.DepoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gtpGridControl
            // 
            this.gtpGridControl.DataSource = this.gtpBindingSource;
            this.gtpGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gtpGridControl.Location = new System.Drawing.Point(0, 0);
            this.gtpGridControl.MainView = this.gtpGridView;
            this.gtpGridControl.Name = "gtpGridControl";
            this.gtpGridControl.ShowOnlyPredefinedDetails = true;
            this.gtpGridControl.Size = new System.Drawing.Size(418, 332);
            this.gtpGridControl.TabIndex = 1;
            this.gtpGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gtpGridView});
            this.gtpGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridControl_KeyDown);
            // 
            // gtpGridView
            // 
            this.gtpGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGTPID,
            this.colGTPNO,
            this.colTANIM,
            this.colBRM});
            this.gtpGridView.GridControl = this.gtpGridControl;
            this.gtpGridView.Name = "gtpGridView";
            this.gtpGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gtpGridView.OptionsView.ShowGroupPanel = false;
            this.gtpGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gtpGridView_InitNewRow);
            this.gtpGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gtpGridView_RowUpdated);
            // 
            // colGTPID
            // 
            this.colGTPID.FieldName = "GTPID";
            this.colGTPID.Name = "colGTPID";
            this.colGTPID.OptionsColumn.AllowEdit = false;
            this.colGTPID.OptionsColumn.AllowFocus = false;
            this.colGTPID.OptionsColumn.FixedWidth = true;
            this.colGTPID.Visible = true;
            this.colGTPID.VisibleIndex = 0;
            this.colGTPID.Width = 60;
            // 
            // colGTPNO
            // 
            this.colGTPNO.Caption = "GTP No";
            this.colGTPNO.FieldName = "GTPNO";
            this.colGTPNO.Name = "colGTPNO";
            this.colGTPNO.Visible = true;
            this.colGTPNO.VisibleIndex = 1;
            this.colGTPNO.Width = 91;
            // 
            // colTANIM
            // 
            this.colTANIM.Caption = "Tanım";
            this.colTANIM.FieldName = "TANIM";
            this.colTANIM.Name = "colTANIM";
            this.colTANIM.Visible = true;
            this.colTANIM.VisibleIndex = 2;
            this.colTANIM.Width = 179;
            // 
            // colBRM
            // 
            this.colBRM.Caption = "Birim";
            this.colBRM.FieldName = "BRM";
            this.colBRM.Name = "colBRM";
            this.colBRM.Visible = true;
            this.colBRM.VisibleIndex = 3;
            this.colBRM.Width = 70;
            // 
            // gtpUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gtpGridControl);
            this.Name = "gtpUC";
            this.Size = new System.Drawing.Size(418, 332);
            this.Load += new System.EventHandler(this.gtpUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtpGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtpGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DepoDataSet depoDataSet;
        private System.Windows.Forms.BindingSource gtpBindingSource;
        private DepoDataSetTableAdapters.GTPTableAdapter gtpTableAdapter;
        private DepoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gtpGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gtpGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colGTPID;
        private DevExpress.XtraGrid.Columns.GridColumn colGTPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colTANIM;
        private DevExpress.XtraGrid.Columns.GridColumn colBRM;
        private DepoDataSetTableAdapters.DepoQueriesTableAdapter depoQueriesTableAdapter;
    }
}

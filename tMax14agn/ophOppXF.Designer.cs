namespace tMax14agn
{
    partial class ophOppXF
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
            this.dataSet = new tMax14agn.DataSet();
            this.ophOppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ophOppTableAdapter = new tMax14agn.DataSetTableAdapters.OPH_OPPTableAdapter();
            this.ophOppGridControl = new DevExpress.XtraGrid.GridControl();
            this.ophOppGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVM3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophOppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophOppGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophOppGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ophOppBindingSource
            // 
            this.ophOppBindingSource.DataMember = "OPH_OPP";
            this.ophOppBindingSource.DataSource = this.dataSet;
            // 
            // ophOppTableAdapter
            // 
            this.ophOppTableAdapter.ClearBeforeFill = true;
            // 
            // ophOppGridControl
            // 
            this.ophOppGridControl.DataSource = this.ophOppBindingSource;
            this.ophOppGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ophOppGridControl.Location = new System.Drawing.Point(0, 0);
            this.ophOppGridControl.MainView = this.ophOppGridView;
            this.ophOppGridControl.Name = "ophOppGridControl";
            this.ophOppGridControl.Size = new System.Drawing.Size(776, 370);
            this.ophOppGridControl.TabIndex = 2;
            this.ophOppGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ophOppGridView});
            // 
            // ophOppGridView
            // 
            this.ophOppGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTOP,
            this.colNOP,
            this.colPCS,
            this.colGRW,
            this.colVM3,
            this.colDIMS,
            this.colHINFO,
            this.colMINFO});
            this.ophOppGridView.GridControl = this.ophOppGridControl;
            this.ophOppGridView.Name = "ophOppGridView";
            this.ophOppGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colTOP
            // 
            this.colTOP.FieldName = "TOP";
            this.colTOP.Name = "colTOP";
            this.colTOP.OptionsColumn.FixedWidth = true;
            this.colTOP.Visible = true;
            this.colTOP.VisibleIndex = 0;
            this.colTOP.Width = 60;
            // 
            // colNOP
            // 
            this.colNOP.FieldName = "NOP";
            this.colNOP.Name = "colNOP";
            this.colNOP.OptionsColumn.FixedWidth = true;
            this.colNOP.Visible = true;
            this.colNOP.VisibleIndex = 1;
            this.colNOP.Width = 60;
            // 
            // colPCS
            // 
            this.colPCS.FieldName = "PCS";
            this.colPCS.Name = "colPCS";
            this.colPCS.OptionsColumn.FixedWidth = true;
            this.colPCS.Visible = true;
            this.colPCS.VisibleIndex = 2;
            this.colPCS.Width = 60;
            // 
            // colGRW
            // 
            this.colGRW.FieldName = "GRW";
            this.colGRW.Name = "colGRW";
            this.colGRW.OptionsColumn.FixedWidth = true;
            this.colGRW.Visible = true;
            this.colGRW.VisibleIndex = 3;
            this.colGRW.Width = 60;
            // 
            // colVM3
            // 
            this.colVM3.FieldName = "VM3";
            this.colVM3.Name = "colVM3";
            this.colVM3.OptionsColumn.FixedWidth = true;
            this.colVM3.Visible = true;
            this.colVM3.VisibleIndex = 4;
            this.colVM3.Width = 60;
            // 
            // colDIMS
            // 
            this.colDIMS.FieldName = "DIMS";
            this.colDIMS.Name = "colDIMS";
            this.colDIMS.Visible = true;
            this.colDIMS.VisibleIndex = 5;
            this.colDIMS.Width = 147;
            // 
            // colHINFO
            // 
            this.colHINFO.FieldName = "HINFO";
            this.colHINFO.Name = "colHINFO";
            this.colHINFO.Visible = true;
            this.colHINFO.VisibleIndex = 6;
            this.colHINFO.Width = 147;
            // 
            // colMINFO
            // 
            this.colMINFO.FieldName = "MINFO";
            this.colMINFO.Name = "colMINFO";
            this.colMINFO.Visible = true;
            this.colMINFO.VisibleIndex = 7;
            this.colMINFO.Width = 164;
            // 
            // ophOppXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ophOppGridControl);
            this.Name = "ophOppXF";
            this.Size = new System.Drawing.Size(776, 370);
            this.Load += new System.EventHandler(this.OphOppXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophOppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophOppGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophOppGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource ophOppBindingSource;
        private DataSetTableAdapters.OPH_OPPTableAdapter ophOppTableAdapter;
        private DevExpress.XtraGrid.GridControl ophOppGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ophOppGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTOP;
        private DevExpress.XtraGrid.Columns.GridColumn colNOP;
        private DevExpress.XtraGrid.Columns.GridColumn colPCS;
        private DevExpress.XtraGrid.Columns.GridColumn colGRW;
        private DevExpress.XtraGrid.Columns.GridColumn colVM3;
        private DevExpress.XtraGrid.Columns.GridColumn colDIMS;
        private DevExpress.XtraGrid.Columns.GridColumn colHINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colMINFO;
    }
}
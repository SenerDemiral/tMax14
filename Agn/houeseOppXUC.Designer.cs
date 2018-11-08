namespace Agn
{
    partial class houeseOppXUC
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
            this.agnDataSet = new Agn.AgnDataSet();
            this.wAN_AGN_OPH_OPP_SELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wAN_AGN_OPH_OPP_SELTableAdapter = new Agn.AgnDataSetTableAdapters.WAN_AGN_OPH_OPP_SELTableAdapter();
            this.hOppSelGridControl = new DevExpress.XtraGrid.GridControl();
            this.hOppSelgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVM3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.agnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAN_AGN_OPH_OPP_SELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOppSelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOppSelgridView)).BeginInit();
            this.SuspendLayout();
            // 
            // agnDataSet
            // 
            this.agnDataSet.DataSetName = "AgnDataSet";
            this.agnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wAN_AGN_OPH_OPP_SELBindingSource
            // 
            this.wAN_AGN_OPH_OPP_SELBindingSource.DataMember = "WAN_AGN_OPH_OPP_SEL";
            this.wAN_AGN_OPH_OPP_SELBindingSource.DataSource = this.agnDataSet;
            // 
            // wAN_AGN_OPH_OPP_SELTableAdapter
            // 
            this.wAN_AGN_OPH_OPP_SELTableAdapter.ClearBeforeFill = true;
            // 
            // hOppSelGridControl
            // 
            this.hOppSelGridControl.DataSource = this.wAN_AGN_OPH_OPP_SELBindingSource;
            this.hOppSelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hOppSelGridControl.Location = new System.Drawing.Point(0, 0);
            this.hOppSelGridControl.MainView = this.hOppSelgridView;
            this.hOppSelGridControl.Name = "hOppSelGridControl";
            this.hOppSelGridControl.Size = new System.Drawing.Size(452, 353);
            this.hOppSelGridControl.TabIndex = 2;
            this.hOppSelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.hOppSelgridView});
            // 
            // hOppSelgridView
            // 
            this.hOppSelgridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTOP,
            this.colNOP,
            this.colPCS,
            this.colGRW,
            this.colVM3,
            this.colDIMS,
            this.colHINFO,
            this.colMINFO});
            this.hOppSelgridView.GridControl = this.hOppSelGridControl;
            this.hOppSelgridView.Name = "hOppSelgridView";
            this.hOppSelgridView.OptionsView.ShowGroupPanel = false;
            // 
            // colTOP
            // 
            this.colTOP.FieldName = "TOP";
            this.colTOP.Name = "colTOP";
            this.colTOP.OptionsColumn.FixedWidth = true;
            this.colTOP.Visible = true;
            this.colTOP.VisibleIndex = 0;
            this.colTOP.Width = 50;
            // 
            // colNOP
            // 
            this.colNOP.FieldName = "NOP";
            this.colNOP.Name = "colNOP";
            this.colNOP.OptionsColumn.FixedWidth = true;
            this.colNOP.Visible = true;
            this.colNOP.VisibleIndex = 1;
            this.colNOP.Width = 50;
            // 
            // colPCS
            // 
            this.colPCS.FieldName = "PCS";
            this.colPCS.Name = "colPCS";
            this.colPCS.OptionsColumn.FixedWidth = true;
            this.colPCS.Visible = true;
            this.colPCS.VisibleIndex = 2;
            this.colPCS.Width = 50;
            // 
            // colGRW
            // 
            this.colGRW.FieldName = "GRW";
            this.colGRW.Name = "colGRW";
            this.colGRW.OptionsColumn.FixedWidth = true;
            this.colGRW.Visible = true;
            this.colGRW.VisibleIndex = 3;
            this.colGRW.Width = 50;
            // 
            // colVM3
            // 
            this.colVM3.FieldName = "VM3";
            this.colVM3.Name = "colVM3";
            this.colVM3.OptionsColumn.FixedWidth = true;
            this.colVM3.Visible = true;
            this.colVM3.VisibleIndex = 4;
            this.colVM3.Width = 50;
            // 
            // colDIMS
            // 
            this.colDIMS.FieldName = "DIMS";
            this.colDIMS.Name = "colDIMS";
            this.colDIMS.Visible = true;
            this.colDIMS.VisibleIndex = 5;
            this.colDIMS.Width = 60;
            // 
            // colHINFO
            // 
            this.colHINFO.FieldName = "HINFO";
            this.colHINFO.Name = "colHINFO";
            this.colHINFO.Visible = true;
            this.colHINFO.VisibleIndex = 6;
            this.colHINFO.Width = 60;
            // 
            // colMINFO
            // 
            this.colMINFO.FieldName = "MINFO";
            this.colMINFO.Name = "colMINFO";
            this.colMINFO.Visible = true;
            this.colMINFO.VisibleIndex = 7;
            this.colMINFO.Width = 64;
            // 
            // houeseOppXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hOppSelGridControl);
            this.Name = "houeseOppXUC";
            this.Size = new System.Drawing.Size(452, 353);
            this.Load += new System.EventHandler(this.houeseOppXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAN_AGN_OPH_OPP_SELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOppSelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOppSelgridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AgnDataSet agnDataSet;
        private System.Windows.Forms.BindingSource wAN_AGN_OPH_OPP_SELBindingSource;
        private AgnDataSetTableAdapters.WAN_AGN_OPH_OPP_SELTableAdapter wAN_AGN_OPH_OPP_SELTableAdapter;
        private DevExpress.XtraGrid.GridControl hOppSelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView hOppSelgridView;
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

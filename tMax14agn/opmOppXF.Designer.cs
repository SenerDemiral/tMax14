namespace tMax14agn
{
    partial class opmOppXF
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
            this.opmOppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opmOppTableAdapter = new tMax14agn.DataSetTableAdapters.OPM_OPPTableAdapter();
            this.opmOppGridControl = new DevExpress.XtraGrid.GridControl();
            this.opmOppGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOPPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEALNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmOppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmOppGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmOppGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opmOppBindingSource
            // 
            this.opmOppBindingSource.DataMember = "OPM_OPP";
            this.opmOppBindingSource.DataSource = this.dataSet;
            // 
            // opmOppTableAdapter
            // 
            this.opmOppTableAdapter.ClearBeforeFill = true;
            // 
            // opmOppGridControl
            // 
            this.opmOppGridControl.DataSource = this.opmOppBindingSource;
            this.opmOppGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opmOppGridControl.Location = new System.Drawing.Point(0, 0);
            this.opmOppGridControl.MainView = this.opmOppGridView;
            this.opmOppGridControl.Name = "opmOppGridControl";
            this.opmOppGridControl.Size = new System.Drawing.Size(947, 461);
            this.opmOppGridControl.TabIndex = 2;
            this.opmOppGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.opmOppGridView});
            // 
            // opmOppGridView
            // 
            this.opmOppGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOPPID,
            this.colOPID,
            this.colTOP,
            this.colCNTNO,
            this.colSEALNO,
            this.colINFO});
            this.opmOppGridView.GridControl = this.opmOppGridControl;
            this.opmOppGridView.Name = "opmOppGridView";
            this.opmOppGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colOPPID
            // 
            this.colOPPID.FieldName = "OPPID";
            this.colOPPID.Name = "colOPPID";
            this.colOPPID.OptionsColumn.FixedWidth = true;
            this.colOPPID.Visible = true;
            this.colOPPID.VisibleIndex = 0;
            // 
            // colOPID
            // 
            this.colOPID.FieldName = "OPID";
            this.colOPID.Name = "colOPID";
            this.colOPID.OptionsColumn.FixedWidth = true;
            this.colOPID.Visible = true;
            this.colOPID.VisibleIndex = 1;
            // 
            // colTOP
            // 
            this.colTOP.FieldName = "TOP";
            this.colTOP.Name = "colTOP";
            this.colTOP.OptionsColumn.FixedWidth = true;
            this.colTOP.Visible = true;
            this.colTOP.VisibleIndex = 2;
            // 
            // colCNTNO
            // 
            this.colCNTNO.FieldName = "CNTNO";
            this.colCNTNO.Name = "colCNTNO";
            this.colCNTNO.OptionsColumn.FixedWidth = true;
            this.colCNTNO.Visible = true;
            this.colCNTNO.VisibleIndex = 3;
            // 
            // colSEALNO
            // 
            this.colSEALNO.FieldName = "SEALNO";
            this.colSEALNO.Name = "colSEALNO";
            this.colSEALNO.OptionsColumn.FixedWidth = true;
            this.colSEALNO.Visible = true;
            this.colSEALNO.VisibleIndex = 4;
            // 
            // colINFO
            // 
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 5;
            // 
            // opmOppXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.opmOppGridControl);
            this.Name = "opmOppXF";
            this.Size = new System.Drawing.Size(947, 461);
            this.Load += new System.EventHandler(this.opmOppXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmOppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmOppGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmOppGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource opmOppBindingSource;
        private DataSetTableAdapters.OPM_OPPTableAdapter opmOppTableAdapter;
        private DevExpress.XtraGrid.GridControl opmOppGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView opmOppGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colOPPID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPID;
        private DevExpress.XtraGrid.Columns.GridColumn colTOP;
        private DevExpress.XtraGrid.Columns.GridColumn colCNTNO;
        private DevExpress.XtraGrid.Columns.GridColumn colSEALNO;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
    }
}
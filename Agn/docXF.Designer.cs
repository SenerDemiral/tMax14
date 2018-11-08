namespace Agn
{
    partial class docXF
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
            this.agnDataSet = new Agn.AgnDataSet();
            this.wAN_AGN_DOC_SELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wAN_AGN_DOC_SELTableAdapter = new Agn.AgnDataSetTableAdapters.WAN_AGN_DOC_SELTableAdapter();
            this.docSelGridControl = new DevExpress.XtraGrid.GridControl();
            this.docSelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDOCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agnQueriesTableAdapter = new Agn.AgnDataSetTableAdapters.AgnQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.agnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAN_AGN_DOC_SELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSelGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // agnDataSet
            // 
            this.agnDataSet.DataSetName = "AgnDataSet";
            this.agnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wAN_AGN_DOC_SELBindingSource
            // 
            this.wAN_AGN_DOC_SELBindingSource.DataMember = "WAN_AGN_DOC_SEL";
            this.wAN_AGN_DOC_SELBindingSource.DataSource = this.agnDataSet;
            // 
            // wAN_AGN_DOC_SELTableAdapter
            // 
            this.wAN_AGN_DOC_SELTableAdapter.ClearBeforeFill = true;
            // 
            // docSelGridControl
            // 
            this.docSelGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.docSelGridControl.DataSource = this.wAN_AGN_DOC_SELBindingSource;
            this.docSelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docSelGridControl.Location = new System.Drawing.Point(0, 0);
            this.docSelGridControl.MainView = this.docSelGridView;
            this.docSelGridControl.Name = "docSelGridControl";
            this.docSelGridControl.Size = new System.Drawing.Size(581, 284);
            this.docSelGridControl.TabIndex = 2;
            this.docSelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.docSelGridView});
            // 
            // docSelGridView
            // 
            this.docSelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDOCID,
            this.colAD,
            this.colTYP,
            this.colEXD,
            this.colDET});
            this.docSelGridView.GridControl = this.docSelGridControl;
            this.docSelGridView.Name = "docSelGridView";
            this.docSelGridView.OptionsBehavior.Editable = false;
            // 
            // colDOCID
            // 
            this.colDOCID.FieldName = "DOCID";
            this.colDOCID.Name = "colDOCID";
            this.colDOCID.OptionsColumn.FixedWidth = true;
            this.colDOCID.Visible = true;
            this.colDOCID.VisibleIndex = 0;
            // 
            // colAD
            // 
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 1;
            // 
            // colTYP
            // 
            this.colTYP.FieldName = "TYP";
            this.colTYP.Name = "colTYP";
            this.colTYP.OptionsColumn.FixedWidth = true;
            this.colTYP.Visible = true;
            this.colTYP.VisibleIndex = 2;
            // 
            // colEXD
            // 
            this.colEXD.FieldName = "EXD";
            this.colEXD.Name = "colEXD";
            this.colEXD.OptionsColumn.FixedWidth = true;
            this.colEXD.Visible = true;
            this.colEXD.VisibleIndex = 3;
            // 
            // colDET
            // 
            this.colDET.FieldName = "DET";
            this.colDET.Name = "colDET";
            this.colDET.OptionsColumn.FixedWidth = true;
            this.colDET.Visible = true;
            this.colDET.VisibleIndex = 4;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // docXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 284);
            this.Controls.Add(this.docSelGridControl);
            this.Name = "docXF";
            this.Text = "docXF";
            this.Load += new System.EventHandler(this.docXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAN_AGN_DOC_SELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSelGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AgnDataSet agnDataSet;
        private System.Windows.Forms.BindingSource wAN_AGN_DOC_SELBindingSource;
        private AgnDataSetTableAdapters.WAN_AGN_DOC_SELTableAdapter wAN_AGN_DOC_SELTableAdapter;
        private DevExpress.XtraGrid.GridControl docSelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView docSelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDOCID;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colEXD;
        private DevExpress.XtraGrid.Columns.GridColumn colDET;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private AgnDataSetTableAdapters.AgnQueriesTableAdapter agnQueriesTableAdapter;
    }
}
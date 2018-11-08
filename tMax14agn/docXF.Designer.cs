namespace tMax14agn
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
            this.docGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDOCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dataSet = new tMax14agn.DataSet();
            this.docTableAdapter = new tMax14agn.DataSetTableAdapters.DOCTableAdapter();
            this.queriesTableAdapter = new tMax14agn.DataSetTableAdapters.QueriesTableAdapter();
            this.dOCbindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.docGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // docGridControl
            // 
            this.docGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.docGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docGridControl.Location = new System.Drawing.Point(0, 0);
            this.docGridControl.MainView = this.docGridView;
            this.docGridControl.Name = "docGridControl";
            this.docGridControl.Size = new System.Drawing.Size(515, 281);
            this.docGridControl.TabIndex = 2;
            this.docGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.docGridView});
            this.docGridControl.Load += new System.EventHandler(this.docGridControl_Load);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(129, 26);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // docGridView
            // 
            this.docGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDOCID,
            this.colAD,
            this.colTYP,
            this.colEXD,
            this.colDET});
            this.docGridView.GridControl = this.docGridControl;
            this.docGridView.Name = "docGridView";
            this.docGridView.OptionsBehavior.Editable = false;
            this.docGridView.OptionsView.ShowGroupPanel = false;
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
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // docTableAdapter
            // 
            this.docTableAdapter.ClearBeforeFill = true;
            // 
            // dOCbindingSource
            // 
            this.dOCbindingSource.DataMember = "DOC";
            this.dOCbindingSource.DataSource = this.dataSet;
            // 
            // docXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.docGridControl);
            this.Name = "docXF";
            this.Size = new System.Drawing.Size(515, 281);
            ((System.ComponentModel.ISupportInitialize)(this.docGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.docGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl docGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView docGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDOCID;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colEXD;
        private DevExpress.XtraGrid.Columns.GridColumn colDET;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private DataSet dataSet;
        private DataSetTableAdapters.DOCTableAdapter docTableAdapter;
        private DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.BindingSource dOCbindingSource;
    }
}
namespace tMax14.Genel
{
    partial class mapXF
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
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bingMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStreetMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelDataSet = new tMax14.Genel.GenelDataSet();
            this.lOC_COORDINATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOC_COORDINATETableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.LOC_COORDINATETableAdapter();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOC_COORDINATEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bingMapToolStripMenuItem,
            this.openStreetMapToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(154, 48);
            // 
            // bingMapToolStripMenuItem
            // 
            this.bingMapToolStripMenuItem.Name = "bingMapToolStripMenuItem";
            this.bingMapToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.bingMapToolStripMenuItem.Text = "Bing Map";
            this.bingMapToolStripMenuItem.Click += new System.EventHandler(this.bingMapToolStripMenuItem_Click);
            // 
            // openStreetMapToolStripMenuItem
            // 
            this.openStreetMapToolStripMenuItem.Name = "openStreetMapToolStripMenuItem";
            this.openStreetMapToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openStreetMapToolStripMenuItem.Text = "OpenStreet Map";
            this.openStreetMapToolStripMenuItem.Click += new System.EventHandler(this.openStreetMapToolStripMenuItem_Click);
            // 
            // genelDataSet
            // 
            this.genelDataSet.DataSetName = "GenelDataSet";
            this.genelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOC_COORDINATEBindingSource
            // 
            this.lOC_COORDINATEBindingSource.DataMember = "LOC_COORDINATE";
            this.lOC_COORDINATEBindingSource.DataSource = this.genelDataSet;
            // 
            // lOC_COORDINATETableAdapter
            // 
            this.lOC_COORDINATETableAdapter.ClearBeforeFill = true;
            // 
            // mapXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 403);
            this.Name = "mapXF";
            this.Text = "mapXF";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mapXF_FormClosed);
            this.Load += new System.EventHandler(this.mapXF_Load);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOC_COORDINATEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem bingMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openStreetMapToolStripMenuItem;
        private GenelDataSet genelDataSet;
        private System.Windows.Forms.BindingSource lOC_COORDINATEBindingSource;
        private GenelDataSetTableAdapters.LOC_COORDINATETableAdapter lOC_COORDINATETableAdapter;
    }
}
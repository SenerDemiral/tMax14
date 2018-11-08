namespace tMax14.Genel
{
    partial class TrhLockXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrhLockXF));
            this.genelDataSet = new tMax14.Genel.GenelDataSet();
            this.tRH_LOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRH_LOCKTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.TRH_LOCKTableAdapter();
            this.tRH_LOCKBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tRH_LOCKBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tRH_LOCKGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRHLT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRH_LOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRH_LOCKBindingNavigator)).BeginInit();
            this.tRH_LOCKBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRH_LOCKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // genelDataSet
            // 
            this.genelDataSet.DataSetName = "GenelDataSet";
            this.genelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRH_LOCKBindingSource
            // 
            this.tRH_LOCKBindingSource.DataMember = "TRH_LOCK";
            this.tRH_LOCKBindingSource.DataSource = this.genelDataSet;
            // 
            // tRH_LOCKTableAdapter
            // 
            this.tRH_LOCKTableAdapter.ClearBeforeFill = true;
            // 
            // tRH_LOCKBindingNavigator
            // 
            this.tRH_LOCKBindingNavigator.AddNewItem = null;
            this.tRH_LOCKBindingNavigator.BindingSource = this.tRH_LOCKBindingSource;
            this.tRH_LOCKBindingNavigator.CountItem = null;
            this.tRH_LOCKBindingNavigator.DeleteItem = null;
            this.tRH_LOCKBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tRH_LOCKBindingNavigatorSaveItem});
            this.tRH_LOCKBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tRH_LOCKBindingNavigator.MoveFirstItem = null;
            this.tRH_LOCKBindingNavigator.MoveLastItem = null;
            this.tRH_LOCKBindingNavigator.MoveNextItem = null;
            this.tRH_LOCKBindingNavigator.MovePreviousItem = null;
            this.tRH_LOCKBindingNavigator.Name = "tRH_LOCKBindingNavigator";
            this.tRH_LOCKBindingNavigator.PositionItem = null;
            this.tRH_LOCKBindingNavigator.Size = new System.Drawing.Size(394, 25);
            this.tRH_LOCKBindingNavigator.TabIndex = 0;
            this.tRH_LOCKBindingNavigator.Text = "bindingNavigator1";
            // 
            // tRH_LOCKBindingNavigatorSaveItem
            // 
            this.tRH_LOCKBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tRH_LOCKBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tRH_LOCKBindingNavigatorSaveItem.Image")));
            this.tRH_LOCKBindingNavigatorSaveItem.Name = "tRH_LOCKBindingNavigatorSaveItem";
            this.tRH_LOCKBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tRH_LOCKBindingNavigatorSaveItem.Text = "Save Data";
            this.tRH_LOCKBindingNavigatorSaveItem.Click += new System.EventHandler(this.tRH_LOCKBindingNavigatorSaveItem_Click);
            // 
            // tRH_LOCKGridControl
            // 
            this.tRH_LOCKGridControl.DataSource = this.tRH_LOCKBindingSource;
            this.tRH_LOCKGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tRH_LOCKGridControl.Location = new System.Drawing.Point(0, 25);
            this.tRH_LOCKGridControl.MainView = this.gridView1;
            this.tRH_LOCKGridControl.Name = "tRH_LOCKGridControl";
            this.tRH_LOCKGridControl.Size = new System.Drawing.Size(394, 148);
            this.tRH_LOCKGridControl.TabIndex = 1;
            this.tRH_LOCKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTRHLT});
            this.gridView1.GridControl = this.tRH_LOCKGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 74;
            // 
            // colTRHLT
            // 
            this.colTRHLT.FieldName = "TRHLT";
            this.colTRHLT.Name = "colTRHLT";
            this.colTRHLT.Visible = true;
            this.colTRHLT.VisibleIndex = 1;
            this.colTRHLT.Width = 302;
            // 
            // TrhLockXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 173);
            this.Controls.Add(this.tRH_LOCKGridControl);
            this.Controls.Add(this.tRH_LOCKBindingNavigator);
            this.Name = "TrhLockXF";
            this.Text = "TrhLockXF";
            this.Load += new System.EventHandler(this.TrhLockXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRH_LOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRH_LOCKBindingNavigator)).EndInit();
            this.tRH_LOCKBindingNavigator.ResumeLayout(false);
            this.tRH_LOCKBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRH_LOCKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GenelDataSet genelDataSet;
        private System.Windows.Forms.BindingSource tRH_LOCKBindingSource;
        private GenelDataSetTableAdapters.TRH_LOCKTableAdapter tRH_LOCKTableAdapter;
        private System.Windows.Forms.BindingNavigator tRH_LOCKBindingNavigator;
        private System.Windows.Forms.ToolStripButton tRH_LOCKBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl tRH_LOCKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTRHLT;
    }
}
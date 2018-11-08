namespace tMax14.Genel
{
    partial class opstXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(opstXF));
            this.genelDataSet = new tMax14.Genel.GenelDataSet();
            this.oPSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPSTTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.OPSTTableAdapter();
            this.oPSTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.oPSTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.opstGridControl = new DevExpress.XtraGrid.GridControl();
            this.opstGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINF = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPSTBindingNavigator)).BeginInit();
            this.oPSTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opstGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opstGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // genelDataSet
            // 
            this.genelDataSet.DataSetName = "GenelDataSet";
            this.genelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oPSTBindingSource
            // 
            this.oPSTBindingSource.DataMember = "OPST";
            this.oPSTBindingSource.DataSource = this.genelDataSet;
            // 
            // oPSTTableAdapter
            // 
            this.oPSTTableAdapter.ClearBeforeFill = true;
            // 
            // oPSTBindingNavigator
            // 
            this.oPSTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oPSTBindingNavigator.BindingSource = this.oPSTBindingSource;
            this.oPSTBindingNavigator.CountItem = null;
            this.oPSTBindingNavigator.DeleteItem = null;
            this.oPSTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.oPSTBindingNavigatorSaveItem});
            this.oPSTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oPSTBindingNavigator.MoveFirstItem = null;
            this.oPSTBindingNavigator.MoveLastItem = null;
            this.oPSTBindingNavigator.MoveNextItem = null;
            this.oPSTBindingNavigator.MovePreviousItem = null;
            this.oPSTBindingNavigator.Name = "oPSTBindingNavigator";
            this.oPSTBindingNavigator.PositionItem = null;
            this.oPSTBindingNavigator.Size = new System.Drawing.Size(329, 25);
            this.oPSTBindingNavigator.TabIndex = 0;
            this.oPSTBindingNavigator.Text = "bindingNavigator1";
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
            // oPSTBindingNavigatorSaveItem
            // 
            this.oPSTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oPSTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oPSTBindingNavigatorSaveItem.Image")));
            this.oPSTBindingNavigatorSaveItem.Name = "oPSTBindingNavigatorSaveItem";
            this.oPSTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.oPSTBindingNavigatorSaveItem.Text = "Save Data";
            this.oPSTBindingNavigatorSaveItem.Click += new System.EventHandler(this.oPSTBindingNavigatorSaveItem_Click);
            // 
            // opstGridControl
            // 
            this.opstGridControl.DataSource = this.oPSTBindingSource;
            this.opstGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opstGridControl.Location = new System.Drawing.Point(0, 25);
            this.opstGridControl.MainView = this.opstGridView;
            this.opstGridControl.Name = "opstGridControl";
            this.opstGridControl.Size = new System.Drawing.Size(329, 284);
            this.opstGridControl.TabIndex = 1;
            this.opstGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.opstGridView});
            // 
            // opstGridView
            // 
            this.opstGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTU,
            this.colNP,
            this.colAD,
            this.colINF});
            this.opstGridView.GridControl = this.opstGridControl;
            this.opstGridView.Name = "opstGridView";
            // 
            // colSTU
            // 
            this.colSTU.FieldName = "STU";
            this.colSTU.Name = "colSTU";
            this.colSTU.Visible = true;
            this.colSTU.VisibleIndex = 0;
            // 
            // colNP
            // 
            this.colNP.FieldName = "NP";
            this.colNP.Name = "colNP";
            this.colNP.Visible = true;
            this.colNP.VisibleIndex = 1;
            // 
            // colAD
            // 
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 2;
            // 
            // colINF
            // 
            this.colINF.FieldName = "INF";
            this.colINF.Name = "colINF";
            this.colINF.Visible = true;
            this.colINF.VisibleIndex = 3;
            // 
            // opstXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 309);
            this.Controls.Add(this.opstGridControl);
            this.Controls.Add(this.oPSTBindingNavigator);
            this.Name = "opstXF";
            this.Text = "Ops Statu Tanımları";
            this.Load += new System.EventHandler(this.opstXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPSTBindingNavigator)).EndInit();
            this.oPSTBindingNavigator.ResumeLayout(false);
            this.oPSTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opstGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opstGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GenelDataSet genelDataSet;
        private System.Windows.Forms.BindingSource oPSTBindingSource;
        private GenelDataSetTableAdapters.OPSTTableAdapter oPSTTableAdapter;
        private System.Windows.Forms.BindingNavigator oPSTBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton oPSTBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl opstGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView opstGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colNP;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colINF;
    }
}
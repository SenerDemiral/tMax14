namespace tMax14.Account
{
    partial class HspPlnAltXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HspPlnAltXF));
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.aHPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aHPXTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AHPXTableAdapter();
            this.aHPXBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aHPXBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ahpxGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colXHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXHSPAD = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aHPXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aHPXBindingNavigator)).BeginInit();
            this.aHPXBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ahpxGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aHPXBindingSource
            // 
            this.aHPXBindingSource.DataMember = "AHPX";
            this.aHPXBindingSource.DataSource = this.accountDataSet;
            // 
            // aHPXTableAdapter
            // 
            this.aHPXTableAdapter.ClearBeforeFill = true;
            // 
            // aHPXBindingNavigator
            // 
            this.aHPXBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aHPXBindingNavigator.BindingSource = this.aHPXBindingSource;
            this.aHPXBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aHPXBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aHPXBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aHPXBindingNavigatorSaveItem});
            this.aHPXBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aHPXBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aHPXBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aHPXBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aHPXBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aHPXBindingNavigator.Name = "aHPXBindingNavigator";
            this.aHPXBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aHPXBindingNavigator.Size = new System.Drawing.Size(509, 25);
            this.aHPXBindingNavigator.TabIndex = 0;
            this.aHPXBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // aHPXBindingNavigatorSaveItem
            // 
            this.aHPXBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aHPXBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aHPXBindingNavigatorSaveItem.Image")));
            this.aHPXBindingNavigatorSaveItem.Name = "aHPXBindingNavigatorSaveItem";
            this.aHPXBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aHPXBindingNavigatorSaveItem.Text = "Save Data";
            this.aHPXBindingNavigatorSaveItem.Click += new System.EventHandler(this.aHPXBindingNavigatorSaveItem_Click);
            // 
            // ahpxGridControl
            // 
            this.ahpxGridControl.DataSource = this.aHPXBindingSource;
            this.ahpxGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ahpxGridControl.Location = new System.Drawing.Point(0, 25);
            this.ahpxGridControl.MainView = this.gridView1;
            this.ahpxGridControl.Name = "ahpxGridControl";
            this.ahpxGridControl.Size = new System.Drawing.Size(509, 250);
            this.ahpxGridControl.TabIndex = 1;
            this.ahpxGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colXHSPNO,
            this.colXHSPAD});
            this.gridView1.GridControl = this.ahpxGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colXHSPNO
            // 
            this.colXHSPNO.Caption = "xHspNo";
            this.colXHSPNO.FieldName = "XHSPNO";
            this.colXHSPNO.Name = "colXHSPNO";
            this.colXHSPNO.Visible = true;
            this.colXHSPNO.VisibleIndex = 0;
            this.colXHSPNO.Width = 117;
            // 
            // colXHSPAD
            // 
            this.colXHSPAD.Caption = "xHspAd";
            this.colXHSPAD.FieldName = "XHSPAD";
            this.colXHSPAD.Name = "colXHSPAD";
            this.colXHSPAD.Visible = true;
            this.colXHSPAD.VisibleIndex = 1;
            this.colXHSPAD.Width = 374;
            // 
            // HspPlnAltXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 275);
            this.Controls.Add(this.ahpxGridControl);
            this.Controls.Add(this.aHPXBindingNavigator);
            this.Name = "HspPlnAltXF";
            this.Text = "HspPlnAltXF";
            this.Load += new System.EventHandler(this.HspPlnAltXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aHPXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aHPXBindingNavigator)).EndInit();
            this.aHPXBindingNavigator.ResumeLayout(false);
            this.aHPXBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ahpxGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource aHPXBindingSource;
        private AccountDataSetTableAdapters.AHPXTableAdapter aHPXTableAdapter;
        private System.Windows.Forms.BindingNavigator aHPXBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aHPXBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl ahpxGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colXHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colXHSPAD;
    }
}
namespace tMax14.AccountAk
{
    partial class AkXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AkXF));
            this.accountAkDataSet = new tMax14.AccountAk.AccountAkDataSet();
            this.aKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aKTableAdapter = new tMax14.AccountAk.AccountAkDataSetTableAdapters.AKTableAdapter();
            this.aKBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aKBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.akGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opsSayilariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.merkezMasraflariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dagitimCarpanlariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dagitimYuzdeleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountAkQueriesTableAdapter = new tMax14.AccountAk.AccountAkDataSetTableAdapters.AccountAkQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.accountAkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKBindingNavigator)).BeginInit();
            this.aKBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountAkDataSet
            // 
            this.accountAkDataSet.DataSetName = "AccountAkDataSet";
            this.accountAkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aKBindingSource
            // 
            this.aKBindingSource.DataMember = "AK";
            this.aKBindingSource.DataSource = this.accountAkDataSet;
            // 
            // aKTableAdapter
            // 
            this.aKTableAdapter.ClearBeforeFill = true;
            // 
            // aKBindingNavigator
            // 
            this.aKBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aKBindingNavigator.BindingSource = this.aKBindingSource;
            this.aKBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aKBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aKBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aKBindingNavigatorSaveItem});
            this.aKBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aKBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aKBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aKBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aKBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aKBindingNavigator.Name = "aKBindingNavigator";
            this.aKBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aKBindingNavigator.Size = new System.Drawing.Size(462, 25);
            this.aKBindingNavigator.TabIndex = 0;
            this.aKBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // aKBindingNavigatorSaveItem
            // 
            this.aKBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aKBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aKBindingNavigatorSaveItem.Image")));
            this.aKBindingNavigatorSaveItem.Name = "aKBindingNavigatorSaveItem";
            this.aKBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aKBindingNavigatorSaveItem.Text = "Save Data";
            this.aKBindingNavigatorSaveItem.Click += new System.EventHandler(this.aKBindingNavigatorSaveItem_Click);
            // 
            // akGridControl
            // 
            this.akGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.akGridControl.DataSource = this.aKBindingSource;
            this.akGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.akGridControl.Location = new System.Drawing.Point(0, 25);
            this.akGridControl.MainView = this.akGridView;
            this.akGridControl.Name = "akGridControl";
            this.akGridControl.Size = new System.Drawing.Size(462, 321);
            this.akGridControl.TabIndex = 1;
            this.akGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.akGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.opsSayilariToolStripMenuItem,
            this.merkezMasraflariToolStripMenuItem,
            this.dagitimCarpanlariToolStripMenuItem,
            this.toolStripSeparator1,
            this.dagitimYuzdeleriToolStripMenuItem,
            this.createToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(214, 142);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.showToolStripMenuItem.Text = "Masraf Dağılımları";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // opsSayilariToolStripMenuItem
            // 
            this.opsSayilariToolStripMenuItem.Name = "opsSayilariToolStripMenuItem";
            this.opsSayilariToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.opsSayilariToolStripMenuItem.Text = "Ops Sayıları";
            this.opsSayilariToolStripMenuItem.Click += new System.EventHandler(this.opsSayilariToolStripMenuItem_Click);
            // 
            // merkezMasraflariToolStripMenuItem
            // 
            this.merkezMasraflariToolStripMenuItem.Name = "merkezMasraflariToolStripMenuItem";
            this.merkezMasraflariToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.merkezMasraflariToolStripMenuItem.Text = "Masraf/Gelir Tutarları";
            this.merkezMasraflariToolStripMenuItem.Click += new System.EventHandler(this.merkezMasraflariToolStripMenuItem_Click);
            // 
            // dagitimCarpanlariToolStripMenuItem
            // 
            this.dagitimCarpanlariToolStripMenuItem.Name = "dagitimCarpanlariToolStripMenuItem";
            this.dagitimCarpanlariToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.dagitimCarpanlariToolStripMenuItem.Text = "Dağıtım Çarpanları";
            this.dagitimCarpanlariToolStripMenuItem.Click += new System.EventHandler(this.dagitimCarpanlariToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // dagitimYuzdeleriToolStripMenuItem
            // 
            this.dagitimYuzdeleriToolStripMenuItem.Name = "dagitimYuzdeleriToolStripMenuItem";
            this.dagitimYuzdeleriToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.dagitimYuzdeleriToolStripMenuItem.Text = "Dağıtım Yüzdeleri Şablonu";
            this.dagitimYuzdeleriToolStripMenuItem.Click += new System.EventHandler(this.dagitimYuzdeleriToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // akGridView
            // 
            this.akGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAKID,
            this.colTRH1,
            this.colTRH2,
            this.colAD});
            this.akGridView.GridControl = this.akGridControl;
            this.akGridView.Name = "akGridView";
            this.akGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.akGridView_InitNewRow);
            // 
            // colAKID
            // 
            this.colAKID.FieldName = "AKID";
            this.colAKID.Name = "colAKID";
            this.colAKID.OptionsColumn.AllowEdit = false;
            this.colAKID.OptionsColumn.AllowFocus = false;
            this.colAKID.OptionsColumn.FixedWidth = true;
            this.colAKID.Visible = true;
            this.colAKID.VisibleIndex = 0;
            this.colAKID.Width = 56;
            // 
            // colTRH1
            // 
            this.colTRH1.Caption = "Trh1 >=";
            this.colTRH1.FieldName = "TRH1";
            this.colTRH1.Name = "colTRH1";
            this.colTRH1.OptionsColumn.FixedWidth = true;
            this.colTRH1.Visible = true;
            this.colTRH1.VisibleIndex = 1;
            this.colTRH1.Width = 82;
            // 
            // colTRH2
            // 
            this.colTRH2.Caption = "<= Trh2";
            this.colTRH2.FieldName = "TRH2";
            this.colTRH2.Name = "colTRH2";
            this.colTRH2.OptionsColumn.FixedWidth = true;
            this.colTRH2.Visible = true;
            this.colTRH2.VisibleIndex = 2;
            this.colTRH2.Width = 82;
            // 
            // colAD
            // 
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 3;
            this.colAD.Width = 191;
            // 
            // AkXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 346);
            this.Controls.Add(this.akGridControl);
            this.Controls.Add(this.aKBindingNavigator);
            this.Name = "AkXF";
            this.Text = "AkXF [AK]";
            this.Load += new System.EventHandler(this.AkXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountAkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKBindingNavigator)).EndInit();
            this.aKBindingNavigator.ResumeLayout(false);
            this.aKBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.akGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccountAkDataSet accountAkDataSet;
        private System.Windows.Forms.BindingSource aKBindingSource;
        private AccountAkDataSetTableAdapters.AKTableAdapter aKTableAdapter;
        private System.Windows.Forms.BindingNavigator aKBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aKBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl akGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView akGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAKID;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH2;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private AccountAkDataSetTableAdapters.AccountAkQueriesTableAdapter accountAkQueriesTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dagitimYuzdeleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opsSayilariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem merkezMasraflariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dagitimCarpanlariToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
namespace tMax14.Ops
{
    partial class ProjeSablonXUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjeSablonXUC));
            this.opsDataSet = new tMax14.Ops.OpsDataSet();
            this.prsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prsTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.PRSTableAdapter();
            this.tableAdapterManager = new tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager();
            this.prsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pRSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prsGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSablonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buSablonuKullanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPRSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSABLON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRichTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsBindingNavigator)).BeginInit();
            this.prsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prsGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prsBindingSource
            // 
            this.prsBindingSource.DataMember = "PRS";
            this.prsBindingSource.DataSource = this.opsDataSet;
            // 
            // prsTableAdapter
            // 
            this.prsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AFDO_SELTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OPH_SELTableAdapter = null;
            this.tableAdapterManager.OPHTableAdapter = null;
            this.tableAdapterManager.OPM_CNTR_LOADTableAdapter = null;
            this.tableAdapterManager.OPM_SELTableAdapter = null;
            this.tableAdapterManager.OPM2TableAdapter = null;
            this.tableAdapterManager.OPMATableAdapter = null;
            this.tableAdapterManager.OPMCTableAdapter = null;
            this.tableAdapterManager.OPMTableAdapter = null;
            this.tableAdapterManager.OPOSTableAdapter = null;
            this.tableAdapterManager.OPOTableAdapter = null;
            this.tableAdapterManager.OPPTableAdapter = null;
            this.tableAdapterManager.OPRH_SEL_DISTableAdapter = null;
            this.tableAdapterManager.PRSTableAdapter = this.prsTableAdapter;
            this.tableAdapterManager.PRTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prsBindingNavigator
            // 
            this.prsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prsBindingNavigator.BindingSource = this.prsBindingSource;
            this.prsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pRSBindingNavigatorSaveItem});
            this.prsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prsBindingNavigator.Name = "prsBindingNavigator";
            this.prsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prsBindingNavigator.Size = new System.Drawing.Size(338, 25);
            this.prsBindingNavigator.TabIndex = 0;
            this.prsBindingNavigator.Text = "bindingNavigator1";
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
            // pRSBindingNavigatorSaveItem
            // 
            this.pRSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRSBindingNavigatorSaveItem.Image")));
            this.pRSBindingNavigatorSaveItem.Name = "pRSBindingNavigatorSaveItem";
            this.pRSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pRSBindingNavigatorSaveItem.Text = "Save Data";
            this.pRSBindingNavigatorSaveItem.Click += new System.EventHandler(this.pRSBindingNavigatorSaveItem_Click);
            // 
            // prsGridControl
            // 
            this.prsGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.prsGridControl.DataSource = this.prsBindingSource;
            this.prsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prsGridControl.Location = new System.Drawing.Point(0, 25);
            this.prsGridControl.MainView = this.prsGridView;
            this.prsGridControl.Name = "prsGridControl";
            this.prsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRichTextEdit});
            this.prsGridControl.Size = new System.Drawing.Size(338, 245);
            this.prsGridControl.TabIndex = 1;
            this.prsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.prsGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSablonToolStripMenuItem,
            this.toolStripSeparator1,
            this.buSablonuKullanToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(158, 54);
            // 
            // editSablonToolStripMenuItem
            // 
            this.editSablonToolStripMenuItem.Name = "editSablonToolStripMenuItem";
            this.editSablonToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.editSablonToolStripMenuItem.Text = "Edit Sablon";
            this.editSablonToolStripMenuItem.Click += new System.EventHandler(this.editSablonToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // buSablonuKullanToolStripMenuItem
            // 
            this.buSablonuKullanToolStripMenuItem.Name = "buSablonuKullanToolStripMenuItem";
            this.buSablonuKullanToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.buSablonuKullanToolStripMenuItem.Text = "Bu Sablonu kullan";
            this.buSablonuKullanToolStripMenuItem.Click += new System.EventHandler(this.buSablonuKullanToolStripMenuItem_Click);
            // 
            // prsGridView
            // 
            this.prsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPRSID,
            this.colAD,
            this.colSABLON});
            this.prsGridView.GridControl = this.prsGridControl;
            this.prsGridView.Name = "prsGridView";
            this.prsGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.prsGridView_InitNewRow);
            // 
            // colPRSID
            // 
            this.colPRSID.Caption = "PRSid";
            this.colPRSID.FieldName = "PRSID";
            this.colPRSID.Name = "colPRSID";
            this.colPRSID.OptionsColumn.AllowEdit = false;
            this.colPRSID.OptionsColumn.AllowFocus = false;
            this.colPRSID.OptionsColumn.FixedWidth = true;
            this.colPRSID.Visible = true;
            this.colPRSID.VisibleIndex = 0;
            this.colPRSID.Width = 60;
            // 
            // colAD
            // 
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 1;
            this.colAD.Width = 133;
            // 
            // colSABLON
            // 
            this.colSABLON.Caption = "Şablon";
            this.colSABLON.ColumnEdit = this.repositoryItemRichTextEdit;
            this.colSABLON.FieldName = "SABLON";
            this.colSABLON.Name = "colSABLON";
            this.colSABLON.OptionsColumn.AllowEdit = false;
            this.colSABLON.OptionsColumn.AllowFocus = false;
            this.colSABLON.Visible = true;
            this.colSABLON.VisibleIndex = 2;
            this.colSABLON.Width = 135;
            // 
            // repositoryItemRichTextEdit
            // 
            this.repositoryItemRichTextEdit.Name = "repositoryItemRichTextEdit";
            this.repositoryItemRichTextEdit.ShowCaretInReadOnly = false;
            // 
            // ProjeSablonXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 270);
            this.Controls.Add(this.prsGridControl);
            this.Controls.Add(this.prsBindingNavigator);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "ProjeSablonXUC";
            this.Text = "Proje Şablonları";
            this.Load += new System.EventHandler(this.ProjeSablonXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsBindingNavigator)).EndInit();
            this.prsBindingNavigator.ResumeLayout(false);
            this.prsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prsGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpsDataSet opsDataSet;
        private System.Windows.Forms.BindingSource prsBindingSource;
        private OpsDataSetTableAdapters.PRSTableAdapter prsTableAdapter;
        private OpsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pRSBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl prsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView prsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colPRSID;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colSABLON;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editSablonToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem buSablonuKullanToolStripMenuItem;
    }
}

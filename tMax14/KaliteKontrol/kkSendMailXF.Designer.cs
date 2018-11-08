namespace tMax14.KaliteKontrol
{
    partial class kkSendMailXF
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
            this.kkDataSet = new tMax14.KaliteKontrol.kkDataSet();
            this.kKESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kKESTableAdapter = new tMax14.KaliteKontrol.kkDataSetTableAdapters.KKESTableAdapter();
            this.kKES_TBL_SELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kKES_TBL_SELTableAdapter = new tMax14.KaliteKontrol.kkDataSetTableAdapters.KKES_TBL_SELTableAdapter();
            this.kksmGridControl = new DevExpress.XtraGrid.GridControl();
            this.kksmGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKKESID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBJECT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBODY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MEMOrepositoryItemMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colEMAILS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendEMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kKESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kKES_TBL_SELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kksmGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kksmGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEMOrepositoryItemMemoEdit)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // kkDataSet
            // 
            this.kkDataSet.DataSetName = "kkDataSet";
            this.kkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kKESBindingSource
            // 
            this.kKESBindingSource.DataMember = "KKES";
            this.kKESBindingSource.DataSource = this.kkDataSet;
            // 
            // kKESTableAdapter
            // 
            this.kKESTableAdapter.ClearBeforeFill = true;
            // 
            // kKES_TBL_SELBindingSource
            // 
            this.kKES_TBL_SELBindingSource.DataMember = "KKES_TBL_SEL";
            this.kKES_TBL_SELBindingSource.DataSource = this.kkDataSet;
            // 
            // kKES_TBL_SELTableAdapter
            // 
            this.kKES_TBL_SELTableAdapter.ClearBeforeFill = true;
            // 
            // kksmGridControl
            // 
            this.kksmGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.kksmGridControl.DataSource = this.kKES_TBL_SELBindingSource;
            this.kksmGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kksmGridControl.Location = new System.Drawing.Point(0, 0);
            this.kksmGridControl.MainView = this.kksmGridView;
            this.kksmGridControl.Name = "kksmGridControl";
            this.kksmGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.MEMOrepositoryItemMemoEdit});
            this.kksmGridControl.Size = new System.Drawing.Size(509, 335);
            this.kksmGridControl.TabIndex = 1;
            this.kksmGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.kksmGridView});
            // 
            // kksmGridView
            // 
            this.kksmGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKKESID,
            this.colSUBJECT,
            this.colBODY,
            this.colEMAILS});
            this.kksmGridView.GridControl = this.kksmGridControl;
            this.kksmGridView.Name = "kksmGridView";
            this.kksmGridView.OptionsBehavior.ReadOnly = true;
            this.kksmGridView.OptionsView.RowAutoHeight = true;
            this.kksmGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colKKESID
            // 
            this.colKKESID.FieldName = "KKESID";
            this.colKKESID.Name = "colKKESID";
            this.colKKESID.OptionsColumn.FixedWidth = true;
            this.colKKESID.Visible = true;
            this.colKKESID.VisibleIndex = 0;
            this.colKKESID.Width = 50;
            // 
            // colSUBJECT
            // 
            this.colSUBJECT.FieldName = "SUBJECT";
            this.colSUBJECT.Name = "colSUBJECT";
            this.colSUBJECT.Visible = true;
            this.colSUBJECT.VisibleIndex = 1;
            this.colSUBJECT.Width = 146;
            // 
            // colBODY
            // 
            this.colBODY.ColumnEdit = this.MEMOrepositoryItemMemoEdit;
            this.colBODY.FieldName = "BODY";
            this.colBODY.Name = "colBODY";
            this.colBODY.Visible = true;
            this.colBODY.VisibleIndex = 2;
            this.colBODY.Width = 146;
            // 
            // MEMOrepositoryItemMemoEdit
            // 
            this.MEMOrepositoryItemMemoEdit.Name = "MEMOrepositoryItemMemoEdit";
            // 
            // colEMAILS
            // 
            this.colEMAILS.ColumnEdit = this.MEMOrepositoryItemMemoEdit;
            this.colEMAILS.FieldName = "EMAILS";
            this.colEMAILS.Name = "colEMAILS";
            this.colEMAILS.Visible = true;
            this.colEMAILS.VisibleIndex = 3;
            this.colEMAILS.Width = 149;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendEMailToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(174, 26);
            // 
            // sendEMailToolStripMenuItem
            // 
            this.sendEMailToolStripMenuItem.Name = "sendEMailToolStripMenuItem";
            this.sendEMailToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.sendEMailToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.sendEMailToolStripMenuItem.Text = "Send eMail";
            this.sendEMailToolStripMenuItem.Click += new System.EventHandler(this.sendEMailToolStripMenuItem_Click);
            // 
            // kkSendMailXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 335);
            this.Controls.Add(this.kksmGridControl);
            this.Name = "kkSendMailXF";
            this.Text = "kkSendMailXF";
            this.Load += new System.EventHandler(this.kkSendMailXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kKESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kKES_TBL_SELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kksmGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kksmGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEMOrepositoryItemMemoEdit)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private kkDataSet kkDataSet;
        private System.Windows.Forms.BindingSource kKESBindingSource;
        private kkDataSetTableAdapters.KKESTableAdapter kKESTableAdapter;
        private System.Windows.Forms.BindingSource kKES_TBL_SELBindingSource;
        private kkDataSetTableAdapters.KKES_TBL_SELTableAdapter kKES_TBL_SELTableAdapter;
        private DevExpress.XtraGrid.GridControl kksmGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView kksmGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colKKESID;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJECT;
        private DevExpress.XtraGrid.Columns.GridColumn colBODY;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit MEMOrepositoryItemMemoEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAILS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sendEMailToolStripMenuItem;
    }
}
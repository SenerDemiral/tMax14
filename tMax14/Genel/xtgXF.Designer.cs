namespace tMax14.Genel
{
    partial class xtgXF
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
            this.mainDataSet = new tMax14.MainDataSet();
            this.xtgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtgTableAdapter = new tMax14.MainDataSetTableAdapters.XTGTableAdapter();
            this.xtgGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUnSavedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xtgGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTBL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TbLrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colTAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TAGrepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.TAG2repositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.TAG3repositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtgGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtgGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbLrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAGrepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAG2repositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAG3repositoryItemTextEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtgBindingSource
            // 
            this.xtgBindingSource.DataMember = "XTG";
            this.xtgBindingSource.DataSource = this.mainDataSet;
            // 
            // xtgTableAdapter
            // 
            this.xtgTableAdapter.ClearBeforeFill = true;
            // 
            // xtgGridControl
            // 
            this.xtgGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.xtgGridControl.DataSource = this.xtgBindingSource;
            this.xtgGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtgGridControl.EmbeddedNavigator.Buttons.EndEdit.Hint = "Save";
            this.xtgGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.xtgGridControl_EmbeddedNavigator_ButtonClick);
            this.xtgGridControl.Location = new System.Drawing.Point(0, 0);
            this.xtgGridControl.MainView = this.xtgGridView;
            this.xtgGridControl.Name = "xtgGridControl";
            this.xtgGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TAGrepositoryItemTextEdit,
            this.TAG2repositoryItemTextEdit,
            this.TAG3repositoryItemTextEdit,
            this.TbLrepositoryItemImageComboBox,
            this.repositoryItemMemoExEdit1});
            this.xtgGridControl.Size = new System.Drawing.Size(513, 266);
            this.xtgGridControl.TabIndex = 1;
            this.xtgGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xtgGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.deleteUnSavedToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 120);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // deleteUnSavedToolStripMenuItem
            // 
            this.deleteUnSavedToolStripMenuItem.Enabled = false;
            this.deleteUnSavedToolStripMenuItem.Name = "deleteUnSavedToolStripMenuItem";
            this.deleteUnSavedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteUnSavedToolStripMenuItem.Text = "Delete UnSaved";
            this.deleteUnSavedToolStripMenuItem.Click += new System.EventHandler(this.deleteUnSavedToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // xtgGridView
            // 
            this.xtgGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTBL,
            this.colTAG,
            this.colAD,
            this.colINFO});
            this.xtgGridView.GridControl = this.xtgGridControl;
            this.xtgGridView.Name = "xtgGridView";
            this.xtgGridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.xtgGridView.OptionsCustomization.AllowFilter = false;
            this.xtgGridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.xtgGridView.OptionsMenu.EnableGroupPanelMenu = false;
            this.xtgGridView.OptionsView.ShowGroupedColumns = true;
            this.xtgGridView.OptionsView.ShowGroupPanel = false;
            this.xtgGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.xtgGridView_ShowingEditor);
            // 
            // colTBL
            // 
            this.colTBL.Caption = "Tbl";
            this.colTBL.ColumnEdit = this.TbLrepositoryItemImageComboBox;
            this.colTBL.FieldName = "TBL";
            this.colTBL.Name = "colTBL";
            this.colTBL.Visible = true;
            this.colTBL.VisibleIndex = 0;
            // 
            // TbLrepositoryItemImageComboBox
            // 
            this.TbLrepositoryItemImageComboBox.AutoHeight = false;
            this.TbLrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TbLrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Firma", "FRT", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Ops", "OPS", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Doc", "DOC", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Jurnal", "JRN", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Fatura", "AFB", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Teklif", "TB", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Event Follow-up", "EFU", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kalite", "KKO", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Proje", "PRT", -1)});
            this.TbLrepositoryItemImageComboBox.Name = "TbLrepositoryItemImageComboBox";
            // 
            // colTAG
            // 
            this.colTAG.ColumnEdit = this.TAGrepositoryItemTextEdit;
            this.colTAG.FieldName = "TAG";
            this.colTAG.Name = "colTAG";
            this.colTAG.Visible = true;
            this.colTAG.VisibleIndex = 1;
            this.colTAG.Width = 81;
            // 
            // TAGrepositoryItemTextEdit
            // 
            this.TAGrepositoryItemTextEdit.AutoHeight = false;
            this.TAGrepositoryItemTextEdit.Mask.EditMask = "(\\<[0-9A-Z_\\+\\-.:]{1,10}\\>)";
            this.TAGrepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TAGrepositoryItemTextEdit.Name = "TAGrepositoryItemTextEdit";
            // 
            // colAD
            // 
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 2;
            this.colAD.Width = 234;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Info";
            this.colINFO.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 3;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // TAG2repositoryItemTextEdit
            // 
            this.TAG2repositoryItemTextEdit.AutoHeight = false;
            this.TAG2repositoryItemTextEdit.Mask.EditMask = "(\\<[0-9A-Z_]{1,10}\\>)|(\\{[0-9A-Z_]{1,10}\\})";
            this.TAG2repositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TAG2repositoryItemTextEdit.Name = "TAG2repositoryItemTextEdit";
            // 
            // TAG3repositoryItemTextEdit
            // 
            this.TAG3repositoryItemTextEdit.AutoHeight = false;
            this.TAG3repositoryItemTextEdit.Mask.EditMask = "(\\<(Priority|Konu|Amac):[0-9A-Z_]{1,10}\\>)";
            this.TAG3repositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TAG3repositoryItemTextEdit.Name = "TAG3repositoryItemTextEdit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // xtgXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 266);
            this.Controls.Add(this.xtgGridControl);
            this.Name = "xtgXF";
            this.Text = "TAGs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xtgXUC_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtgGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtgGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbLrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAGrepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAG2repositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAG3repositoryItemTextEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource xtgBindingSource;
        private MainDataSetTableAdapters.XTGTableAdapter xtgTableAdapter;
        private DevExpress.XtraGrid.GridControl xtgGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView xtgGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TAGrepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TAG2repositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TAG3repositoryItemTextEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUnSavedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTBL;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TbLrepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

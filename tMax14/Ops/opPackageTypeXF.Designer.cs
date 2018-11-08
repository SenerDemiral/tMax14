namespace tMax14.Ops
{
    partial class opPackageTypeXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(opPackageTypeXF));
            this.mainDataSet = new tMax14.MainDataSet();
            this.otpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otpTableAdapter = new tMax14.MainDataSetTableAdapters.OTPTableAdapter();
            this.oTPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.oTPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.otpGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kayitEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TOPrepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVM3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTARE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAYLOAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TURrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BOYUTrepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colBE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKY = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTPBindingNavigator)).BeginInit();
            this.oTPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otpGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOPrepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TURrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOYUTrepositoryItemTextEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otpBindingSource
            // 
            this.otpBindingSource.DataMember = "OTP";
            this.otpBindingSource.DataSource = this.mainDataSet;
            // 
            // otpTableAdapter
            // 
            this.otpTableAdapter.ClearBeforeFill = true;
            // 
            // oTPBindingNavigator
            // 
            this.oTPBindingNavigator.AddNewItem = null;
            this.oTPBindingNavigator.BindingSource = this.otpBindingSource;
            this.oTPBindingNavigator.CountItem = null;
            this.oTPBindingNavigator.DeleteItem = null;
            this.oTPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oTPBindingNavigatorSaveItem});
            this.oTPBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oTPBindingNavigator.MoveFirstItem = null;
            this.oTPBindingNavigator.MoveLastItem = null;
            this.oTPBindingNavigator.MoveNextItem = null;
            this.oTPBindingNavigator.MovePreviousItem = null;
            this.oTPBindingNavigator.Name = "oTPBindingNavigator";
            this.oTPBindingNavigator.PositionItem = null;
            this.oTPBindingNavigator.Size = new System.Drawing.Size(609, 25);
            this.oTPBindingNavigator.TabIndex = 0;
            this.oTPBindingNavigator.Text = "bindingNavigator1";
            // 
            // oTPBindingNavigatorSaveItem
            // 
            this.oTPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oTPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oTPBindingNavigatorSaveItem.Image")));
            this.oTPBindingNavigatorSaveItem.Name = "oTPBindingNavigatorSaveItem";
            this.oTPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.oTPBindingNavigatorSaveItem.Text = "Save Data";
            this.oTPBindingNavigatorSaveItem.Click += new System.EventHandler(this.oTPBindingNavigatorSaveItem_Click);
            // 
            // otpGridControl
            // 
            this.otpGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.otpGridControl.DataSource = this.otpBindingSource;
            this.otpGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otpGridControl.Location = new System.Drawing.Point(0, 25);
            this.otpGridControl.MainView = this.otpGridView;
            this.otpGridControl.Name = "otpGridControl";
            this.otpGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TURrepositoryItemImageComboBox,
            this.TOPrepositoryItemTextEdit,
            this.BOYUTrepositoryItemTextEdit});
            this.otpGridControl.Size = new System.Drawing.Size(609, 263);
            this.otpGridControl.TabIndex = 1;
            this.otpGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.otpGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayitEkleToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(168, 26);
            // 
            // kayitEkleToolStripMenuItem
            // 
            this.kayitEkleToolStripMenuItem.Name = "kayitEkleToolStripMenuItem";
            this.kayitEkleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.kayitEkleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kayitEkleToolStripMenuItem.Text = "Kayit ekle";
            this.kayitEkleToolStripMenuItem.Click += new System.EventHandler(this.kayitEkleToolStripMenuItem_Click);
            // 
            // otpGridView
            // 
            this.otpGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTOP,
            this.colAD,
            this.colVM3,
            this.colINFO,
            this.colTARE,
            this.colPAYLOAD,
            this.colTUR,
            this.colBB,
            this.colBE,
            this.colBY,
            this.colKE,
            this.colKY});
            this.otpGridView.GridControl = this.otpGridControl;
            this.otpGridView.GroupCount = 1;
            this.otpGridView.GroupFormat = "{1} {2}";
            this.otpGridView.Name = "otpGridView";
            this.otpGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTUR, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.otpGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.otpGridView_ShowingEditor);
            // 
            // colTOP
            // 
            this.colTOP.ColumnEdit = this.TOPrepositoryItemTextEdit;
            this.colTOP.FieldName = "TOP";
            this.colTOP.Name = "colTOP";
            this.colTOP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTOP.OptionsColumn.FixedWidth = true;
            this.colTOP.Visible = true;
            this.colTOP.VisibleIndex = 0;
            this.colTOP.Width = 79;
            // 
            // TOPrepositoryItemTextEdit
            // 
            this.TOPrepositoryItemTextEdit.MaxLength = 5;
            this.TOPrepositoryItemTextEdit.Name = "TOPrepositoryItemTextEdit";
            // 
            // colAD
            // 
            this.colAD.Caption = "Ad";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 1;
            this.colAD.Width = 160;
            // 
            // colVM3
            // 
            this.colVM3.AppearanceCell.Options.UseTextOptions = true;
            this.colVM3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVM3.AppearanceHeader.Options.UseTextOptions = true;
            this.colVM3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVM3.DisplayFormat.FormatString = "n2";
            this.colVM3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVM3.FieldName = "VM3";
            this.colVM3.Name = "colVM3";
            this.colVM3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colVM3.OptionsColumn.FixedWidth = true;
            this.colVM3.Visible = true;
            this.colVM3.VisibleIndex = 3;
            this.colVM3.Width = 47;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Info";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 2;
            this.colINFO.Width = 121;
            // 
            // colTARE
            // 
            this.colTARE.Caption = "Tare";
            this.colTARE.DisplayFormat.FormatString = "n1";
            this.colTARE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTARE.FieldName = "TARE";
            this.colTARE.Name = "colTARE";
            this.colTARE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTARE.OptionsColumn.FixedWidth = true;
            this.colTARE.Visible = true;
            this.colTARE.VisibleIndex = 4;
            this.colTARE.Width = 50;
            // 
            // colPAYLOAD
            // 
            this.colPAYLOAD.Caption = "Payload";
            this.colPAYLOAD.DisplayFormat.FormatString = "n1";
            this.colPAYLOAD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPAYLOAD.FieldName = "PAYLOAD";
            this.colPAYLOAD.Name = "colPAYLOAD";
            this.colPAYLOAD.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPAYLOAD.OptionsColumn.FixedWidth = true;
            this.colPAYLOAD.Visible = true;
            this.colPAYLOAD.VisibleIndex = 5;
            this.colPAYLOAD.Width = 50;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.ColumnEdit = this.TURrepositoryItemImageComboBox;
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.OptionsColumn.FixedWidth = true;
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 0;
            this.colTUR.Width = 74;
            // 
            // TURrepositoryItemImageComboBox
            // 
            this.TURrepositoryItemImageComboBox.AutoHeight = false;
            this.TURrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TURrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("-", "-", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Palet", "P", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Container", "C", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "T", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Vagon", "V", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("GOH", "G", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bio", "B", -1)});
            this.TURrepositoryItemImageComboBox.Name = "TURrepositoryItemImageComboBox";
            // 
            // colBB
            // 
            this.colBB.Caption = "Boy";
            this.colBB.ColumnEdit = this.BOYUTrepositoryItemTextEdit;
            this.colBB.DisplayFormat.FormatString = "n0";
            this.colBB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBB.FieldName = "BB";
            this.colBB.Name = "colBB";
            this.colBB.Visible = true;
            this.colBB.VisibleIndex = 7;
            // 
            // BOYUTrepositoryItemTextEdit
            // 
            this.BOYUTrepositoryItemTextEdit.AutoHeight = false;
            this.BOYUTrepositoryItemTextEdit.Mask.EditMask = "n0";
            this.BOYUTrepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BOYUTrepositoryItemTextEdit.Name = "BOYUTrepositoryItemTextEdit";
            // 
            // colBE
            // 
            this.colBE.Caption = "En";
            this.colBE.ColumnEdit = this.BOYUTrepositoryItemTextEdit;
            this.colBE.DisplayFormat.FormatString = "n0";
            this.colBE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBE.FieldName = "BE";
            this.colBE.Name = "colBE";
            this.colBE.Visible = true;
            this.colBE.VisibleIndex = 6;
            // 
            // colBY
            // 
            this.colBY.Caption = "Yükseklik";
            this.colBY.ColumnEdit = this.BOYUTrepositoryItemTextEdit;
            this.colBY.DisplayFormat.FormatString = "n0";
            this.colBY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBY.FieldName = "BY";
            this.colBY.Name = "colBY";
            this.colBY.Visible = true;
            this.colBY.VisibleIndex = 8;
            // 
            // colKE
            // 
            this.colKE.Caption = "KapıEn";
            this.colKE.ColumnEdit = this.BOYUTrepositoryItemTextEdit;
            this.colKE.DisplayFormat.FormatString = "n0";
            this.colKE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKE.FieldName = "KE";
            this.colKE.Name = "colKE";
            this.colKE.Visible = true;
            this.colKE.VisibleIndex = 9;
            // 
            // colKY
            // 
            this.colKY.Caption = "KapıYükseklik";
            this.colKY.ColumnEdit = this.BOYUTrepositoryItemTextEdit;
            this.colKY.DisplayFormat.FormatString = "n0";
            this.colKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKY.FieldName = "KY";
            this.colKY.Name = "colKY";
            this.colKY.Visible = true;
            this.colKY.VisibleIndex = 10;
            // 
            // opPackageTypeXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 288);
            this.Controls.Add(this.otpGridControl);
            this.Controls.Add(this.oTPBindingNavigator);
            this.Name = "opPackageTypeXF";
            this.Text = "opPackageTypeXF";
            this.Load += new System.EventHandler(this.opPackageTypeXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTPBindingNavigator)).EndInit();
            this.oTPBindingNavigator.ResumeLayout(false);
            this.oTPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otpGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.otpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOPrepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TURrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOYUTrepositoryItemTextEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource otpBindingSource;
        private MainDataSetTableAdapters.OTPTableAdapter otpTableAdapter;
        private System.Windows.Forms.BindingNavigator oTPBindingNavigator;
        private System.Windows.Forms.ToolStripButton oTPBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl otpGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView otpGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTOP;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colVM3;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colTARE;
        private DevExpress.XtraGrid.Columns.GridColumn colPAYLOAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TURrepositoryItemImageComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem kayitEkleToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TOPrepositoryItemTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colBB;
        private DevExpress.XtraGrid.Columns.GridColumn colBE;
        private DevExpress.XtraGrid.Columns.GridColumn colBY;
        private DevExpress.XtraGrid.Columns.GridColumn colKE;
        private DevExpress.XtraGrid.Columns.GridColumn colKY;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit BOYUTrepositoryItemTextEdit;
    }
}
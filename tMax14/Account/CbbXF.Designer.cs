namespace tMax14.Account
{
    partial class CbbXF
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
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.cBBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBBTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.CBBTableAdapter();
            this.cBBGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuScript = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhasebeFisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCBBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBANK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLATRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHATALI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountQueriesTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AccountQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBBGridControl)).BeginInit();
            this.contextMenuScript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankRepositoryItemImageComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cBBBindingSource
            // 
            this.cBBBindingSource.DataMember = "CBB";
            this.cBBBindingSource.DataSource = this.accountDataSet;
            // 
            // cBBTableAdapter
            // 
            this.cBBTableAdapter.ClearBeforeFill = true;
            // 
            // cBBGridControl
            // 
            this.cBBGridControl.ContextMenuStrip = this.contextMenuScript;
            this.cBBGridControl.DataSource = this.cBBBindingSource;
            this.cBBGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBBGridControl.Location = new System.Drawing.Point(0, 0);
            this.cBBGridControl.MainView = this.gridView1;
            this.cBBGridControl.Name = "cBBGridControl";
            this.cBBGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BankRepositoryItemImageComboBox});
            this.cBBGridControl.Size = new System.Drawing.Size(945, 390);
            this.cBBGridControl.TabIndex = 2;
            this.cBBGridControl.Tag = "CBB";
            this.cBBGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuScript
            // 
            this.contextMenuScript.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayToolStripMenuItem,
            this.muhasebeFisiToolStripMenuItem});
            this.contextMenuScript.Name = "contextMenuScript";
            this.contextMenuScript.Size = new System.Drawing.Size(150, 48);
            // 
            // detayToolStripMenuItem
            // 
            this.detayToolStripMenuItem.Name = "detayToolStripMenuItem";
            this.detayToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.detayToolStripMenuItem.Text = "Detay";
            this.detayToolStripMenuItem.Click += new System.EventHandler(this.detayToolStripMenuItem_Click);
            // 
            // muhasebeFisiToolStripMenuItem
            // 
            this.muhasebeFisiToolStripMenuItem.Name = "muhasebeFisiToolStripMenuItem";
            this.muhasebeFisiToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.muhasebeFisiToolStripMenuItem.Text = "Muhasebe Fisi";
            this.muhasebeFisiToolStripMenuItem.Click += new System.EventHandler(this.muhasebeFisiToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCBBID,
            this.colBANK,
            this.colTRH,
            this.colDRM,
            this.colACIKLAMA,
            this.colAVBID,
            this.colINSUSR,
            this.colINSTRH,
            this.colLAUSR,
            this.colLATRH,
            this.colHATALI});
            this.gridView1.GridControl = this.cBBGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // colCBBID
            // 
            this.colCBBID.DisplayFormat.FormatString = "n0";
            this.colCBBID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCBBID.FieldName = "CBBID";
            this.colCBBID.Name = "colCBBID";
            this.colCBBID.OptionsColumn.FixedWidth = true;
            this.colCBBID.OptionsColumn.ReadOnly = true;
            this.colCBBID.Visible = true;
            this.colCBBID.VisibleIndex = 0;
            this.colCBBID.Width = 70;
            // 
            // colBANK
            // 
            this.colBANK.Caption = "Bank";
            this.colBANK.ColumnEdit = this.BankRepositoryItemImageComboBox;
            this.colBANK.FieldName = "BANK";
            this.colBANK.Name = "colBANK";
            this.colBANK.OptionsColumn.FixedWidth = true;
            this.colBANK.Visible = true;
            this.colBANK.VisibleIndex = 1;
            this.colBANK.Width = 40;
            // 
            // BankRepositoryItemImageComboBox
            // 
            this.BankRepositoryItemImageComboBox.AutoHeight = false;
            this.BankRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BankRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("GB", "GB", -1)});
            this.BankRepositoryItemImageComboBox.Name = "BankRepositoryItemImageComboBox";
            // 
            // colTRH
            // 
            this.colTRH.Caption = "Tarih";
            this.colTRH.DisplayFormat.FormatString = "dd.MM.yy";
            this.colTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRH.FieldName = "TRH";
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.FixedWidth = true;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 2;
            this.colTRH.Width = 69;
            // 
            // colDRM
            // 
            this.colDRM.Caption = "Drm";
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.OptionsColumn.FixedWidth = true;
            this.colDRM.OptionsColumn.ReadOnly = true;
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 3;
            this.colDRM.Width = 39;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.Caption = "Açıklama";
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 5;
            this.colACIKLAMA.Width = 301;
            // 
            // colAVBID
            // 
            this.colAVBID.FieldName = "AVBID";
            this.colAVBID.Name = "colAVBID";
            this.colAVBID.OptionsColumn.FixedWidth = true;
            this.colAVBID.OptionsColumn.ReadOnly = true;
            this.colAVBID.Visible = true;
            this.colAVBID.VisibleIndex = 6;
            this.colAVBID.Width = 70;
            // 
            // colINSUSR
            // 
            this.colINSUSR.Caption = "InsUsr";
            this.colINSUSR.FieldName = "INSUSR";
            this.colINSUSR.Name = "colINSUSR";
            this.colINSUSR.OptionsColumn.FixedWidth = true;
            this.colINSUSR.OptionsColumn.ReadOnly = true;
            this.colINSUSR.Visible = true;
            this.colINSUSR.VisibleIndex = 7;
            this.colINSUSR.Width = 50;
            // 
            // colINSTRH
            // 
            this.colINSTRH.Caption = "InsTrh";
            this.colINSTRH.FieldName = "INSTRH";
            this.colINSTRH.Name = "colINSTRH";
            this.colINSTRH.OptionsColumn.FixedWidth = true;
            this.colINSTRH.OptionsColumn.ReadOnly = true;
            this.colINSTRH.Visible = true;
            this.colINSTRH.VisibleIndex = 8;
            this.colINSTRH.Width = 80;
            // 
            // colLAUSR
            // 
            this.colLAUSR.Caption = "LAUsr";
            this.colLAUSR.FieldName = "LAUSR";
            this.colLAUSR.Name = "colLAUSR";
            this.colLAUSR.OptionsColumn.FixedWidth = true;
            this.colLAUSR.OptionsColumn.ReadOnly = true;
            this.colLAUSR.Visible = true;
            this.colLAUSR.VisibleIndex = 9;
            this.colLAUSR.Width = 50;
            // 
            // colLATRH
            // 
            this.colLATRH.Caption = "LATrh";
            this.colLATRH.FieldName = "LATRH";
            this.colLATRH.Name = "colLATRH";
            this.colLATRH.OptionsColumn.FixedWidth = true;
            this.colLATRH.OptionsColumn.ReadOnly = true;
            this.colLATRH.Visible = true;
            this.colLATRH.VisibleIndex = 10;
            this.colLATRH.Width = 80;
            // 
            // colHATALI
            // 
            this.colHATALI.Caption = "Hata";
            this.colHATALI.FieldName = "HATALI";
            this.colHATALI.Name = "colHATALI";
            this.colHATALI.OptionsColumn.FixedWidth = true;
            this.colHATALI.OptionsColumn.ReadOnly = true;
            this.colHATALI.Visible = true;
            this.colHATALI.VisibleIndex = 4;
            this.colHATALI.Width = 48;
            // 
            // CbbXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 390);
            this.Controls.Add(this.cBBGridControl);
            this.Name = "CbbXF";
            this.Tag = "";
            this.Text = "CbbXF";
            this.Load += new System.EventHandler(this.CbbXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBBGridControl)).EndInit();
            this.contextMenuScript.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankRepositoryItemImageComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource cBBBindingSource;
        private AccountDataSetTableAdapters.CBBTableAdapter cBBTableAdapter;
        private DevExpress.XtraGrid.GridControl cBBGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCBBID;
        private DevExpress.XtraGrid.Columns.GridColumn colBANK;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colAVBID;
        private DevExpress.XtraGrid.Columns.GridColumn colINSUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colINSTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colLAUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colLATRH;
        private DevExpress.XtraGrid.Columns.GridColumn colHATALI;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox BankRepositoryItemImageComboBox;
        private AccountDataSetTableAdapters.AccountQueriesTableAdapter accountQueriesTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuScript;
        private System.Windows.Forms.ToolStripMenuItem detayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhasebeFisiToolStripMenuItem;
    }
}
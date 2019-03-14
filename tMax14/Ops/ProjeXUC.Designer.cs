namespace tMax14.Ops
{
    partial class ProjeXUC
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
            this.opsDataSet = new tMax14.Ops.OpsDataSet();
            this.prtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prtTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.PRTTableAdapter();
            this.tableAdapterManager = new tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager();
            this.prtGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.faaliyetlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jurnalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prtGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDITABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAMAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colYONETICI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSORUMLU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBKMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAGS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTKPTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOZLDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYYTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.TURrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemRichTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.onaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prtGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TURrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prtBindingSource
            // 
            this.prtBindingSource.DataMember = "PRT";
            this.prtBindingSource.DataSource = this.opsDataSet;
            // 
            // prtTableAdapter
            // 
            this.prtTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AFDO_SELTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OBSDTableAdapter = null;
            this.tableAdapterManager.OBSTableAdapter = null;
            this.tableAdapterManager.OPCCTableAdapter = null;
            this.tableAdapterManager.OPCTableAdapter = null;
            this.tableAdapterManager.OPH_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPH_SELTableAdapter = null;
            this.tableAdapterManager.OPHTableAdapter = null;
            this.tableAdapterManager.OPM_ACC_ONY_TOPLUTableAdapter = null;
            this.tableAdapterManager.OPM_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPM_CNTR_LOADTableAdapter = null;
            this.tableAdapterManager.OPM_SELTableAdapter = null;
            this.tableAdapterManager.OPM2TableAdapter = null;
            this.tableAdapterManager.OPMATableAdapter = null;
            this.tableAdapterManager.OPMCTableAdapter = null;
            this.tableAdapterManager.OPMITableAdapter = null;
            this.tableAdapterManager.OPMTableAdapter = null;
            this.tableAdapterManager.OPOSTableAdapter = null;
            this.tableAdapterManager.OPOTableAdapter = null;
            this.tableAdapterManager.OPP_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPPTableAdapter = null;
            this.tableAdapterManager.OPRH_SEL_DISTableAdapter = null;
            this.tableAdapterManager.PRFTableAdapter = null;
            this.tableAdapterManager.PRSTableAdapter = null;
            this.tableAdapterManager.PRTTableAdapter = this.prtTableAdapter;
            this.tableAdapterManager.UpdateOrder = tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZMSLTableAdapter = null;
            // 
            // prtGridControl
            // 
            this.prtGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.prtGridControl.DataSource = this.prtBindingSource;
            this.prtGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prtGridControl.Location = new System.Drawing.Point(0, 0);
            this.prtGridControl.MainView = this.prtGridView;
            this.prtGridControl.Name = "prtGridControl";
            this.prtGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit,
            this.TURrepositoryItemImageComboBox,
            this.repositoryItemRichTextEdit,
            this.repositoryItemMemoEdit});
            this.prtGridControl.ShowOnlyPredefinedDetails = true;
            this.prtGridControl.Size = new System.Drawing.Size(805, 404);
            this.prtGridControl.TabIndex = 1;
            this.prtGridControl.Tag = "PRT";
            this.prtGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.prtGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faaliyetlerToolStripMenuItem,
            this.jurnalToolStripMenuItem,
            this.bookmarkToolStripMenuItem,
            this.attachmentToolStripMenuItem,
            this.layoutsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.onaylaToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 180);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // faaliyetlerToolStripMenuItem
            // 
            this.faaliyetlerToolStripMenuItem.Name = "faaliyetlerToolStripMenuItem";
            this.faaliyetlerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.faaliyetlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faaliyetlerToolStripMenuItem.Text = "Faaliyetler";
            this.faaliyetlerToolStripMenuItem.Click += new System.EventHandler(this.faaliyetlerToolStripMenuItem_Click);
            // 
            // jurnalToolStripMenuItem
            // 
            this.jurnalToolStripMenuItem.Name = "jurnalToolStripMenuItem";
            this.jurnalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jurnalToolStripMenuItem.Text = "Jurnal";
            this.jurnalToolStripMenuItem.Click += new System.EventHandler(this.jurnalToolStripMenuItem_Click);
            // 
            // bookmarkToolStripMenuItem
            // 
            this.bookmarkToolStripMenuItem.Name = "bookmarkToolStripMenuItem";
            this.bookmarkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.bookmarkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookmarkToolStripMenuItem.Text = "Bookmark";
            this.bookmarkToolStripMenuItem.Click += new System.EventHandler(this.bookmarkToolStripMenuItem_Click);
            // 
            // attachmentToolStripMenuItem
            // 
            this.attachmentToolStripMenuItem.Name = "attachmentToolStripMenuItem";
            this.attachmentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.attachmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.attachmentToolStripMenuItem.Text = "Attachment";
            this.attachmentToolStripMenuItem.Click += new System.EventHandler(this.attachmentToolStripMenuItem_Click);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // prtGridView
            // 
            this.prtGridView.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prtGridView.Appearance.TopNewRow.Options.UseBackColor = true;
            this.prtGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPRTID,
            this.colEDITABLE,
            this.colTUR,
            this.colDRM,
            this.colAD,
            this.colAMAC,
            this.colYONETICI,
            this.colSORUMLU,
            this.colACIKLAMA,
            this.colATS,
            this.colETF,
            this.colATF,
            this.colBKMS,
            this.colTAGS,
            this.colTKPTRH,
            this.colOZLDRM,
            this.colONYUSR,
            this.colONYYTK,
            this.colONYTRH});
            this.prtGridView.GridControl = this.prtGridControl;
            this.prtGridView.Name = "prtGridView";
            this.prtGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.prtGridView_ShowingEditor);
            this.prtGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.prtGridView_InitNewRow);
            // 
            // colPRTID
            // 
            this.colPRTID.FieldName = "PRTID";
            this.colPRTID.Name = "colPRTID";
            this.colPRTID.OptionsColumn.FixedWidth = true;
            this.colPRTID.Visible = true;
            this.colPRTID.VisibleIndex = 0;
            this.colPRTID.Width = 50;
            // 
            // colEDITABLE
            // 
            this.colEDITABLE.Caption = "E";
            this.colEDITABLE.FieldName = "EDITABLE";
            this.colEDITABLE.Name = "colEDITABLE";
            this.colEDITABLE.OptionsColumn.AllowEdit = false;
            this.colEDITABLE.OptionsColumn.AllowFocus = false;
            this.colEDITABLE.ToolTip = "Editable";
            this.colEDITABLE.Visible = true;
            this.colEDITABLE.VisibleIndex = 1;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 2;
            this.colTUR.Width = 55;
            // 
            // colDRM
            // 
            this.colDRM.Caption = "Durum";
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.OptionsColumn.FixedWidth = true;
            this.colDRM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 3;
            this.colDRM.Width = 50;
            // 
            // colAD
            // 
            this.colAD.Caption = "Ad";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 4;
            this.colAD.Width = 55;
            // 
            // colAMAC
            // 
            this.colAMAC.Caption = "Amaç";
            this.colAMAC.ColumnEdit = this.repositoryItemMemoEdit;
            this.colAMAC.FieldName = "AMAC";
            this.colAMAC.Name = "colAMAC";
            this.colAMAC.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colAMAC.Visible = true;
            this.colAMAC.VisibleIndex = 5;
            this.colAMAC.Width = 55;
            // 
            // repositoryItemMemoEdit
            // 
            this.repositoryItemMemoEdit.AcceptsTab = true;
            this.repositoryItemMemoEdit.LinesCount = 10;
            this.repositoryItemMemoEdit.Name = "repositoryItemMemoEdit";
            // 
            // colYONETICI
            // 
            this.colYONETICI.Caption = "Yönetici";
            this.colYONETICI.FieldName = "YONETICI";
            this.colYONETICI.Name = "colYONETICI";
            this.colYONETICI.Visible = true;
            this.colYONETICI.VisibleIndex = 6;
            this.colYONETICI.Width = 55;
            // 
            // colSORUMLU
            // 
            this.colSORUMLU.Caption = "Sorumlu";
            this.colSORUMLU.FieldName = "SORUMLU";
            this.colSORUMLU.Name = "colSORUMLU";
            this.colSORUMLU.Visible = true;
            this.colSORUMLU.VisibleIndex = 7;
            this.colSORUMLU.Width = 55;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.Caption = "Açıklama";
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 8;
            this.colACIKLAMA.Width = 55;
            // 
            // colATS
            // 
            this.colATS.FieldName = "ATS";
            this.colATS.Name = "colATS";
            this.colATS.ToolTip = "Gerçek Başlangıç";
            this.colATS.Visible = true;
            this.colATS.VisibleIndex = 9;
            this.colATS.Width = 55;
            // 
            // colETF
            // 
            this.colETF.FieldName = "ETF";
            this.colETF.Name = "colETF";
            this.colETF.ToolTip = "Hedef Bitiş";
            this.colETF.Visible = true;
            this.colETF.VisibleIndex = 10;
            this.colETF.Width = 55;
            // 
            // colATF
            // 
            this.colATF.FieldName = "ATF";
            this.colATF.Name = "colATF";
            this.colATF.ToolTip = "Gerçek Bitiş";
            this.colATF.Visible = true;
            this.colATF.VisibleIndex = 11;
            this.colATF.Width = 55;
            // 
            // colBKMS
            // 
            this.colBKMS.Caption = "BKMs";
            this.colBKMS.FieldName = "BKMS";
            this.colBKMS.Name = "colBKMS";
            this.colBKMS.Visible = true;
            this.colBKMS.VisibleIndex = 12;
            this.colBKMS.Width = 55;
            // 
            // colTAGS
            // 
            this.colTAGS.Caption = "TAGs";
            this.colTAGS.FieldName = "TAGS";
            this.colTAGS.Name = "colTAGS";
            this.colTAGS.Visible = true;
            this.colTAGS.VisibleIndex = 13;
            this.colTAGS.Width = 55;
            // 
            // colTKPTRH
            // 
            this.colTKPTRH.Caption = "TkpTrh";
            this.colTKPTRH.DisplayFormat.FormatString = "dd.MM.yy";
            this.colTKPTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTKPTRH.FieldName = "TKPTRH";
            this.colTKPTRH.Name = "colTKPTRH";
            this.colTKPTRH.Visible = true;
            this.colTKPTRH.VisibleIndex = 14;
            // 
            // colOZLDRM
            // 
            this.colOZLDRM.Caption = "ÖzelDurum";
            this.colOZLDRM.FieldName = "OZLDRM";
            this.colOZLDRM.Name = "colOZLDRM";
            this.colOZLDRM.Width = 82;
            // 
            // colONYUSR
            // 
            this.colONYUSR.Caption = "oUsr";
            this.colONYUSR.FieldName = "ONYUSR";
            this.colONYUSR.Name = "colONYUSR";
            this.colONYUSR.OptionsColumn.AllowEdit = false;
            this.colONYUSR.OptionsColumn.AllowFocus = false;
            this.colONYUSR.Visible = true;
            this.colONYUSR.VisibleIndex = 15;
            // 
            // colONYYTK
            // 
            this.colONYYTK.Caption = "oYtk";
            this.colONYYTK.FieldName = "ONYYTK";
            this.colONYYTK.Name = "colONYYTK";
            this.colONYYTK.OptionsColumn.AllowEdit = false;
            this.colONYYTK.OptionsColumn.AllowFocus = false;
            this.colONYYTK.Visible = true;
            this.colONYYTK.VisibleIndex = 16;
            // 
            // colONYTRH
            // 
            this.colONYTRH.Caption = "oTrh";
            this.colONYTRH.DisplayFormat.FormatString = "dd.MM.yy HH:mm";
            this.colONYTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colONYTRH.FieldName = "ONYTRH";
            this.colONYTRH.Name = "colONYTRH";
            this.colONYTRH.OptionsColumn.AllowEdit = false;
            this.colONYTRH.OptionsColumn.AllowFocus = false;
            this.colONYTRH.Visible = true;
            this.colONYTRH.VisibleIndex = 17;
            // 
            // repositoryItemMemoExEdit
            // 
            this.repositoryItemMemoExEdit.AutoHeight = false;
            this.repositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit.Name = "repositoryItemMemoExEdit";
            // 
            // TURrepositoryItemImageComboBox
            // 
            this.TURrepositoryItemImageComboBox.AutoHeight = false;
            this.TURrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TURrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bir", "1", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Iki", "2", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Uc", "3", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Dort", "4", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bes", "5", -1)});
            this.TURrepositoryItemImageComboBox.Name = "TURrepositoryItemImageComboBox";
            // 
            // repositoryItemRichTextEdit
            // 
            this.repositoryItemRichTextEdit.Name = "repositoryItemRichTextEdit";
            this.repositoryItemRichTextEdit.ShowCaretInReadOnly = false;
            // 
            // onaylaToolStripMenuItem
            // 
            this.onaylaToolStripMenuItem.Name = "onaylaToolStripMenuItem";
            this.onaylaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.onaylaToolStripMenuItem.Text = "Onayla";
            this.onaylaToolStripMenuItem.Click += new System.EventHandler(this.onaylaToolStripMenuItem_Click);
            // 
            // ProjeXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prtGridControl);
            this.Name = "ProjeXUC";
            this.Size = new System.Drawing.Size(805, 404);
            this.Load += new System.EventHandler(this.ProjeXUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prtGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TURrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpsDataSet opsDataSet;
        private System.Windows.Forms.BindingSource prtBindingSource;
        private OpsDataSetTableAdapters.PRTTableAdapter prtTableAdapter;
        private OpsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl prtGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView prtGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TURrepositoryItemImageComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit;
        private System.Windows.Forms.ToolStripMenuItem jurnalToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colPRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colAMAC;
        private DevExpress.XtraGrid.Columns.GridColumn colYONETICI;
        private DevExpress.XtraGrid.Columns.GridColumn colSORUMLU;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colATS;
        private DevExpress.XtraGrid.Columns.GridColumn colETF;
        private DevExpress.XtraGrid.Columns.GridColumn colATF;
        private DevExpress.XtraGrid.Columns.GridColumn colBKMS;
        private DevExpress.XtraGrid.Columns.GridColumn colTAGS;
        private DevExpress.XtraGrid.Columns.GridColumn colOZLDRM;
        private System.Windows.Forms.ToolStripMenuItem faaliyetlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachmentToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colTKPTRH;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colEDITABLE;
        private DevExpress.XtraGrid.Columns.GridColumn colONYUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colONYYTK;
        private DevExpress.XtraGrid.Columns.GridColumn colONYTRH;
        private System.Windows.Forms.ToolStripMenuItem onaylaToolStripMenuItem;
    }
}

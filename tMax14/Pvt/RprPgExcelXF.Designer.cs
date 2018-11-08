namespace tMax14.Pvt
{
    partial class RprPgExcelXF
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
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.commonBar1 = new DevExpress.XtraSpreadsheet.UI.CommonBar();
            this.spreadsheetCommandBarButtonItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.eMailbarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pvtDataSet = new tMax14.Pvt.PvtDataSet();
            this.tableAdapterManager = new tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager();
            this.spreadsheetBarController1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController();
            this.rPR_PGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPR_PGTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.RPR_PGTableAdapter();
            this.rPR_PG_EMAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPR_PG_EMAILSTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.RPR_PG_EMAILSTableAdapter();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_PGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_PG_EMAILSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 31);
            this.spreadsheetControl1.MenuManager = this.barManager1;
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(1040, 375);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            this.spreadsheetControl1.DocumentLoaded += new System.EventHandler(this.spreadsheetControl1_DocumentLoaded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getTemplateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
            // 
            // getTemplateToolStripMenuItem
            // 
            this.getTemplateToolStripMenuItem.Name = "getTemplateToolStripMenuItem";
            this.getTemplateToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.getTemplateToolStripMenuItem.Text = "Get Template";
            this.getTemplateToolStripMenuItem.Click += new System.EventHandler(this.getTemplateToolStripMenuItem_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.commonBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.spreadsheetCommandBarButtonItem1,
            this.spreadsheetCommandBarButtonItem2,
            this.spreadsheetCommandBarButtonItem3,
            this.spreadsheetCommandBarButtonItem4,
            this.spreadsheetCommandBarButtonItem5,
            this.spreadsheetCommandBarButtonItem6,
            this.spreadsheetCommandBarButtonItem7,
            this.spreadsheetCommandBarButtonItem8,
            this.spreadsheetCommandBarButtonItem9,
            this.spreadsheetCommandBarButtonItem10,
            this.eMailbarButtonItem1,
            this.barEditItem1});
            this.barManager1.MaxItemId = 12;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            // 
            // commonBar1
            // 
            this.commonBar1.Control = this.spreadsheetControl1;
            this.commonBar1.DockCol = 0;
            this.commonBar1.DockRow = 0;
            this.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.commonBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.spreadsheetCommandBarButtonItem3, false),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.spreadsheetCommandBarButtonItem4, false),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.eMailbarButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1)});
            // 
            // spreadsheetCommandBarButtonItem1
            // 
            this.spreadsheetCommandBarButtonItem1.CommandName = "FileNew";
            this.spreadsheetCommandBarButtonItem1.Id = 1;
            this.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1";
            // 
            // spreadsheetCommandBarButtonItem2
            // 
            this.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen";
            this.spreadsheetCommandBarButtonItem2.Id = 2;
            this.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2";
            // 
            // spreadsheetCommandBarButtonItem3
            // 
            this.spreadsheetCommandBarButtonItem3.CommandName = "FileSave";
            this.spreadsheetCommandBarButtonItem3.Id = 3;
            this.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3";
            // 
            // spreadsheetCommandBarButtonItem4
            // 
            this.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs";
            this.spreadsheetCommandBarButtonItem4.Id = 4;
            this.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4";
            // 
            // spreadsheetCommandBarButtonItem5
            // 
            this.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint";
            this.spreadsheetCommandBarButtonItem5.Id = 5;
            this.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5";
            // 
            // spreadsheetCommandBarButtonItem6
            // 
            this.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint";
            this.spreadsheetCommandBarButtonItem6.Id = 6;
            this.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6";
            // 
            // spreadsheetCommandBarButtonItem7
            // 
            this.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview";
            this.spreadsheetCommandBarButtonItem7.Id = 7;
            this.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7";
            // 
            // spreadsheetCommandBarButtonItem8
            // 
            this.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo";
            this.spreadsheetCommandBarButtonItem8.Id = 8;
            this.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8";
            // 
            // spreadsheetCommandBarButtonItem9
            // 
            this.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo";
            this.spreadsheetCommandBarButtonItem9.Id = 9;
            this.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9";
            // 
            // spreadsheetCommandBarButtonItem10
            // 
            this.spreadsheetCommandBarButtonItem10.CommandName = "FileShowDocumentProperties";
            this.spreadsheetCommandBarButtonItem10.Id = 10;
            this.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10";
            // 
            // eMailbarButtonItem1
            // 
            this.eMailbarButtonItem1.Caption = "Send eMail";
            this.eMailbarButtonItem1.Id = 0;
            this.eMailbarButtonItem1.Name = "eMailbarButtonItem1";
            this.eMailbarButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.eMailbarButtonItem1_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 11;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Size = new System.Drawing.Size(500, 0);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1040, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 406);
            this.barDockControlBottom.Size = new System.Drawing.Size(1040, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 375);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1040, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 375);
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.RPR_TRACING_DTYTableAdapter = null;
            this.tableAdapterManager.SALESREP_OPSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // spreadsheetBarController1
            // 
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem7);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem10);
            this.spreadsheetBarController1.Control = this.spreadsheetControl1;
            // 
            // rPR_PGBindingSource
            // 
            this.rPR_PGBindingSource.DataMember = "RPR_PG";
            this.rPR_PGBindingSource.DataSource = this.pvtDataSet;
            // 
            // rPR_PGTableAdapter
            // 
            this.rPR_PGTableAdapter.ClearBeforeFill = true;
            // 
            // rPR_PG_EMAILSBindingSource
            // 
            this.rPR_PG_EMAILSBindingSource.DataMember = "RPR_PG_EMAILS";
            this.rPR_PG_EMAILSBindingSource.DataSource = this.pvtDataSet;
            // 
            // rPR_PG_EMAILSTableAdapter
            // 
            this.rPR_PG_EMAILSTableAdapter.ClearBeforeFill = true;
            // 
            // RprPgExcelXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 406);
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "RprPgExcelXF";
            this.Text = "OphPgExcelXF";
            this.Load += new System.EventHandler(this.OphPgExcelXF_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_PGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_PG_EMAILSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem getTemplateToolStripMenuItem;
        private PvtDataSet pvtDataSet;
        private PvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraSpreadsheet.UI.CommonBar commonBar1;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem1;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem2;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem3;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem4;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem5;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem6;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem7;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem8;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem9;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem10;
        private DevExpress.XtraBars.BarButtonItem eMailbarButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController spreadsheetBarController1;
        private System.Windows.Forms.BindingSource rPR_PGBindingSource;
        private PvtDataSetTableAdapters.RPR_PGTableAdapter rPR_PGTableAdapter;
        private System.Windows.Forms.BindingSource rPR_PG_EMAILSBindingSource;
        private PvtDataSetTableAdapters.RPR_PG_EMAILSTableAdapter rPR_PG_EMAILSTableAdapter;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
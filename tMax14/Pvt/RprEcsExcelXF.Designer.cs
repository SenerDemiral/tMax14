﻿namespace tMax14.Pvt
{
    partial class RprEcsExcelXF
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
            this.pvtDataSet = new tMax14.Pvt.PvtDataSet();
            this.rPR_ECSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPR_ECSTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.RPR_ECSTableAdapter();
            this.tableAdapterManager = new tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
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
            this.SendMailBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.eMailBarEditItem = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.spreadsheetBarController1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController();
            this.rpR_ECS_EMAILSTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.RPR_ECS_EMAILSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_ECSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPR_ECSBindingSource
            // 
            this.rPR_ECSBindingSource.DataMember = "RPR_ECS";
            this.rPR_ECSBindingSource.DataSource = this.pvtDataSet;
            // 
            // rPR_ECSTableAdapter
            // 
            this.rPR_ECSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.RPR_TRACING_DTYTableAdapter = null;
            this.tableAdapterManager.SALESREP_OPSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 31);
            this.spreadsheetControl1.MenuManager = this.barManager1;
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(1092, 347);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
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
            this.SendMailBarButtonItem,
            this.eMailBarEditItem});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.spreadsheetCommandBarButtonItem8, false),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.SendMailBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.eMailBarEditItem, "", false, true, true, 297)});
            // 
            // spreadsheetCommandBarButtonItem1
            // 
            this.spreadsheetCommandBarButtonItem1.CommandName = "FileNew";
            this.spreadsheetCommandBarButtonItem1.Id = 0;
            this.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1";
            // 
            // spreadsheetCommandBarButtonItem2
            // 
            this.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen";
            this.spreadsheetCommandBarButtonItem2.Id = 1;
            this.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2";
            // 
            // spreadsheetCommandBarButtonItem3
            // 
            this.spreadsheetCommandBarButtonItem3.CommandName = "FileSave";
            this.spreadsheetCommandBarButtonItem3.Id = 2;
            this.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3";
            // 
            // spreadsheetCommandBarButtonItem4
            // 
            this.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs";
            this.spreadsheetCommandBarButtonItem4.Id = 3;
            this.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4";
            // 
            // spreadsheetCommandBarButtonItem5
            // 
            this.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint";
            this.spreadsheetCommandBarButtonItem5.Id = 4;
            this.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5";
            // 
            // spreadsheetCommandBarButtonItem6
            // 
            this.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint";
            this.spreadsheetCommandBarButtonItem6.Id = 5;
            this.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6";
            // 
            // spreadsheetCommandBarButtonItem7
            // 
            this.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview";
            this.spreadsheetCommandBarButtonItem7.Id = 6;
            this.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7";
            // 
            // spreadsheetCommandBarButtonItem8
            // 
            this.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo";
            this.spreadsheetCommandBarButtonItem8.Id = 7;
            this.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8";
            // 
            // spreadsheetCommandBarButtonItem9
            // 
            this.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo";
            this.spreadsheetCommandBarButtonItem9.Id = 8;
            this.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9";
            // 
            // spreadsheetCommandBarButtonItem10
            // 
            this.spreadsheetCommandBarButtonItem10.CommandName = "FileShowDocumentProperties";
            this.spreadsheetCommandBarButtonItem10.Id = 9;
            this.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10";
            // 
            // SendMailBarButtonItem
            // 
            this.SendMailBarButtonItem.Caption = "Send eMail";
            this.SendMailBarButtonItem.Id = 10;
            this.SendMailBarButtonItem.Name = "SendMailBarButtonItem";
            this.SendMailBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SendMailBarButtonItem_ItemClick);
            // 
            // eMailBarEditItem
            // 
            this.eMailBarEditItem.Caption = "barEditItem1";
            this.eMailBarEditItem.Edit = this.repositoryItemTextEdit1;
            this.eMailBarEditItem.Id = 11;
            this.eMailBarEditItem.Name = "eMailBarEditItem";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1092, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 378);
            this.barDockControlBottom.Size = new System.Drawing.Size(1092, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 347);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1092, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 347);
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
            // rpR_ECS_EMAILSTableAdapter
            // 
            this.rpR_ECS_EMAILSTableAdapter.ClearBeforeFill = true;
            // 
            // RprEcsExcelXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 378);
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "RprEcsExcelXF";
            this.Text = "RprEcsExcelXF";
            this.Load += new System.EventHandler(this.RprEcsExcelXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_ECSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PvtDataSet pvtDataSet;
        private System.Windows.Forms.BindingSource rPR_ECSBindingSource;
        private PvtDataSetTableAdapters.RPR_ECSTableAdapter rPR_ECSTableAdapter;
        private PvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
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
        private DevExpress.XtraBars.BarButtonItem SendMailBarButtonItem;
        private DevExpress.XtraBars.BarEditItem eMailBarEditItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController spreadsheetBarController1;
        private PvtDataSetTableAdapters.RPR_ECS_EMAILSTableAdapter rpR_ECS_EMAILSTableAdapter;
    }
}
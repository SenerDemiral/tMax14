using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Dynamic;

using DevExpress.XtraReports;
using tMax14ReportClassLibrary;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid;
using DevExpress.Data;
using DevExpress.XtraGrid.Columns;

using System.Collections;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Text;

namespace tMax14.Account
{
    public partial class FaturaXF : DevExpress.XtraEditors.XtraForm
    {
        public int AFBid = 0,
                   RefAfbID = 0,
                   FRTid = 0, //Deneme
                   OPid = 0;
        string layoutName = "Account.FaturaXF";

        public FaturaXF()
        {
            InitializeComponent();
        }

        private void FaturaXF_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (AFBid != 0)
                sb.Append(string.Format("AFBid = {0}", AFBid));
            else if (RefAfbID != 0)
                sb.Append(string.Format("RefAfbID = {0}", RefAfbID));
            else if (FRTid != 0)
                sb.Append(string.Format("FRTid = {0}", FRTid));
            else if (OPid != 0)
                sb.Append(string.Format("OPid = {0}", OPid));
            else
                sb.Append(string.Format(" "));

            this.afbTableAdapter.ClearBeforeFill = true;
            this.afbTableAdapter.Fill(this.accountDataSet.AFB, sb.ToString(), Program.USR);
            this.afbTableAdapter.ClearBeforeFill = false;

            Program.MF.GridControlSettings(afbGridControl);
            afbGridView.ShowingEditor += afbGridView_ShowingEditor;

            afbGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDKNFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDKNDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colBDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colTUR.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            colTUR2.ColumnEdit = Program.MF.afbTUR2repositoryItemImageComboBox;
            colTUR3.ColumnEdit = Program.MF.afbTUR3repositoryItemImageComboBox;
            colTAGS.ColumnEdit = Program.MF.TAGselAFBrepositoryItemCheckedComboBoxEdit;
            colHSPNO.ColumnEdit = Program.MF.AHPHspAdNoRepositoryItemLookUpEdit;
            colDRM.ColumnEdit = Program.MF.AFBdrmRepositoryItemImageComboBox;
            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            compBA.ColumnEdit = Program.MF.BArepositoryItemImageComboBox;
            colEMLD.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            Program.MF.DVTrepositoryItemLookUpEdit.Closed += DVTrepositoryItemLookUpEdit_Closed;

            Qry.qsvAfbXUC frm = new Qry.qsvAfbXUC();
            frm.AFB = accountDataSet.AFB;
            frm.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(frm);

            //afbGridView.FormatConditions[0].Expression = string.Format("Contains([BKMS], '{0}')", Program.USRtag);
            
            GridFormatRule gridFormatRule = new GridFormatRule();
            FormatConditionRuleExpression formatConditionRuleExpression = new FormatConditionRuleExpression();
            gridFormatRule.Column = colBKMS;
            gridFormatRule.ApplyToRow = true;
            formatConditionRuleExpression.PredefinedName = "Bold Text"; // "Red Fill, Red Text";
            formatConditionRuleExpression.Expression = string.Format("Contains([BKMS], '{0}')", Program.USRtag);
            gridFormatRule.Rule = formatConditionRuleExpression;
            afbGridView.FormatRules.Add(gridFormatRule);


            Program.MF.XGLrestore(layoutName, 0, afbGridView);
            afbGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Account.FaturaXF", true);
        }

        private void FaturaXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MF.DVTrepositoryItemLookUpEdit.Closed -= DVTrepositoryItemLookUpEdit_Closed;
        }

        void DVTrepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            var a = sender as LookUpEdit;
            if (a.OldEditValue != a.EditValue && afbGridControl.IsFocused)
            {
                object trh, kur;
                //object aaa = afbGridView.GetFocusedRowCellValue(colFTRTRH);
                //object bbb = afbGridView.GetFocusedRowCellValue(colINSTS);

                trh = afbGridView.GetFocusedRowCellValue(colFTRTRH) == DBNull.Value ? DateTime.Today : afbGridView.GetFocusedRowCellValue(colFTRTRH);
                kur = accountQueriesTableAdapter.AFB_KUR(a.EditValue.ToString(), (DateTime)trh);
                afbGridView.SetFocusedRowCellValue(colBKUR, kur);
            }
        }

        private void afbGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var www = (e.Row as System.Data.DataRowView)["AFBID"];
        }

        public void Save()  // MainForm
        {
            try
            {
                this.Validate();
                this.afbBindingSource.EndEdit();

                //this.afbTableAdapter.Save(accountDataSet.AFB);

                // Zaten her satirda i/u oluyor yani birden cok olmuyor array a koymaya gerek yokki, neyse boyle kalsin simdilik. bir 4 sene daha
                int[] afbId = new int[100];
                int i = 0;

                foreach (AccountDataSet.AFBRow row in accountDataSet.AFB.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        afbId[i++] = row.AFBID;
                        row.UPDUSR = Program.USR;
                    }
                    else if (row.RowState == DataRowState.Added)
                    {
                        afbId[i++] = row.AFBID;
                        row.INSUSR = Program.USR;
                    }
                }
                afbTableAdapter.Update(accountDataSet.AFB);

                for(int j = 0; j < i; j++)
                {
                    if (afbId[j] != 0)
                        afbTableAdapter.Fill(this.accountDataSet.AFB, string.Format("AFBid = {0}", afbId[j]), Program.USR); //Refresh
                }

                /* 4 sene sonra duzelttim!!!
                AccountDataSet.AFBDataTable mdt = (AccountDataSet.AFBDataTable)accountDataSet.AFB.GetChanges(DataRowState.Modified | DataRowState.Added | DataRowState.Deleted);
                if (mdt != null)
                {
                    foreach (AccountDataSet.AFBRow row in mdt)
                        if (row.RowState == DataRowState.Modified)
                            row.UPDUSR = Program.USR;
                        else if (row.RowState == DataRowState.Added)
                            row.INSUSR = Program.USR;

                    this.afbTableAdapter.Update(mdt);
                    
                    foreach (AccountDataSet.AFBRow row in mdt)
                    {
                        if (row.RowState != DataRowState.Deleted)
                            this.afbTableAdapter.Fill(this.accountDataSet.AFB, string.Format("AFBid = {0}", row.AFBID), Program.USR); //Refresh
                    }
                }*/
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.accountDataSet.AFB.RejectChanges();
            }
        }

        private void faturaDetaylariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validate();// Save();

            //dynamic inf = new ExpandoObject();
            //inf._ = "Fatura Başlık Bilgileri";
            //inf.ID = afbGridView.GetFocusedRowCellDisplayText(colAFBID);
            //inf.FtrTrh = afbGridView.GetFocusedRowCellDisplayText(colFTRTRH);
            //inf.ÖdmVde = afbGridView.GetFocusedRowCellDisplayText(colODMVDE);
            //inf.Dvz = afbGridView.GetFocusedRowCellDisplayText(colBDVZ);
            //inf.Kur = afbGridView.GetFocusedRowCellDisplayText(colBKUR);
            //inf.Tut = afbGridView.GetFocusedRowCellDisplayText(colBTUTBRT);

            int afbID = (int)afbGridView.GetFocusedRowCellValue(colAFBID);
            FaturaDetayXF frm = new FaturaDetayXF(afbID, false);
            frm.ShowDialog();

            // Refresh
            this.afbTableAdapter.Fill(this.accountDataSet.AFB, string.Format("AFBid = {0}", afbID), Program.USR); //Refresh
            //string qry = string.Format("afbID = {0}", frm.afbRow.AFBID);
            //this.afbTableAdapter.Fill(this.accountDataSet.AFB_REC_SEL, qry);

        }

        private void afbGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            int afbID = (int)accountQueriesTableAdapter.GET_PK("ACC");
            view.SetFocusedRowCellValue(colAFBID, afbID);
            view.SetFocusedRowCellValue(colDRM, "A");   // Acik
            view.SetFocusedRowCellValue(colTUR, "BS");  // Satis
            view.SetFocusedRowCellValue(colTUR2, "I");  // yurtIci
            view.SetFocusedRowCellValue(colTUR3, "G");  // Genel
            view.SetFocusedRowCellValue(colFTRTRH, DateTime.Today); // Null olamaz!
            view.SetFocusedRowCellValue(colBDVZ, "TRL"); 
            view.SetFocusedRowCellValue(colBKUR, 1.000);

            colTUR3.OptionsColumn.AllowEdit = false;    // Burdan Ops icin Fatura giremez (FaturaLink'den)
        }

        private void afbGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle ||
                view.GetDataRow(view.FocusedRowHandle).RowState == DataRowState.Added)
                e.Cancel = false;
            else
            {
                string tur3 = view.GetFocusedRowCellValue(colTUR3).ToString();
                if (tur3 == "O")
                {
                    if (view.FocusedColumn == colTUR || 
                        view.FocusedColumn == colTUR2 || 
                        view.FocusedColumn == colTUR3 || 
                        view.FocusedColumn == colFRTID ||
                        view.FocusedColumn == colFTRTRH ||
                        view.FocusedColumn == colODMVDE ||
                        view.FocusedColumn == colBDVZ ||
                        view.FocusedColumn == colDKNFRTID ||
                        view.FocusedColumn == colDKNDVZ ||
                        view.FocusedColumn == colDKNNO)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                if (tur3 == "G")
                {
                    if (view.FocusedColumn == colTUR3)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                string E = view.GetFocusedRowCellValue(colEDITABLE).ToString();
                if (E == "F")
                {
                    e.Cancel = true;
                    var aaa = view.GetFocusedRowCellValue(colFTRNO);
                    if (view.GetFocusedRowCellValue(colFTRNO) == DBNull.Value)
                    {
                        if (view.FocusedColumn == colFTRNO || view.FocusedColumn == colFTRTRH)
                            e.Cancel = false;
                    }
                }
            }
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            int afbID = (int)view.GetFocusedRowCellValue(colAFBID);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = view.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "AFB";
            frm.TblPK = afbID;
            frm.ShowDialog();
            frm.Dispose();
            this.afbTableAdapter.Fill(this.accountDataSet.AFB, string.Format("AFBid = {0}", afbID), Program.USR); //Refresh Clear=false
        }

        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BKMS = afbGridView.GetFocusedRowCellValue(colBKMS).ToString();
            // Toggle 
            if (BKMS.Contains(Program.USRtag))   // Varsa cikar
            {
                BKMS = BKMS.Replace(Program.USRtag, "");
                //afbGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                //afbGridView.UpdateCurrentRow();
            }
            else                        // Yoksa ekle
            {
                BKMS += Program.USRtag;
                //afbGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                //afbGridView.UpdateCurrentRow();
            }

            //Save BKMS
            int PK = (int)afbGridView.GetFocusedRowCellValue(colAFBID);
            Program.MF.mainQueriesTableAdapter.BKMS_UPD("AFB", PK, BKMS);
            this.afbTableAdapter.Fill(this.accountDataSet.AFB, string.Format("AFBid = {0}", PK), Program.USR);

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellValue(colDRM).ToString() != "A")
                return;

            string tur = view.GetFocusedRowCellValue(colTUR).ToString();
            string tur3 = view.GetFocusedRowCellValue(colTUR3).ToString();
            string entryCheck = "";
            if (tur == "BS" || tur == "BA")
            {
                if (tur3 == "O")
                    entryCheck = "Account.FaturaKapaXF.Satis.Ops";
                else
                    entryCheck = "Account.FaturaKapaXF.Satis.Genel";
            }
            else if (tur == "AS" || tur == "AA")
            {
                if (tur3 == "O")
                    entryCheck = "Account.FaturaKapaXF.Alis.Ops";
                else
                    entryCheck = "Account.FaturaKapaXF.Alis.Genel";
            }
            else if (tur == "AD" || tur == "BD")
            {
                if (tur3 == "O")
                    entryCheck = "Account.FaturaKapaXF.Dekont.Ops";
                else
                    entryCheck = "Account.FaturaKapaXF.Dekont.Genel";
            }

            if (entryCheck != "" && !Program.MF.EntryCheck(entryCheck, false))
                return;

            int afbID = (int)view.GetFocusedRowCellValue(colAFBID);
            FaturaKapaXF frm = new FaturaKapaXF(afbID, tur);

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.afbTableAdapter.Fill(this.accountDataSet.AFB, string.Format("AFBid = {0}", afbID), Program.USR); //Refresh Clear=false

            frm.Dispose();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            //Program.MF.YetkiCheck(view.GetFocusedRowCellDisplayText(colONYYTK), false);

            try
            {
                int afbID = (int)view.GetFocusedRowCellValue(colAFBID);
                if (accountQueriesTableAdapter.AFB_AC(afbID, Program.USR).ToString() == "T")
                    this.afbTableAdapter.Fill(this.accountDataSet.AFB, string.Format("AFBid = {0}", afbID), Program.USR); //Refresh Clear=false
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Fatura Aç");
            }
        }

        private void ftrNoDegistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !afbGridView.IsDataRow(view.FocusedRowHandle))
                return;

            if (Program.MF.EntryCheck("Account.FaturaXF.FtrNoUpd", false))
            {
                try
                {
                    int PK = (int)view.GetFocusedRowCellValue(colAFBID);
                    if (accountQueriesTableAdapter.AFB_UPD_FTRNO(PK, newFtrNoToolStripTextBox.Text).ToString() == "T")
                        this.afbTableAdapter.Fill(this.accountDataSet.AFB, string.Format("AFBid = {0}", PK), Program.USR); //Refresh Clear=false
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "FtrNo Değiştir");
                }
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            var view = afbGridView;

            if (view.IsDataRow(afbGridView.FocusedRowHandle))
            {
                newFtrNoToolStripTextBox.Text = view.GetFocusedRowCellDisplayText(colFTRNO);

                if (view.GetFocusedRowCellValue(colDRM).ToString() == "A")
                    kapatToolStripMenuItem.Enabled = true;
                else
                    kapatToolStripMenuItem.Enabled = false;
            }
        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            Jurnal.jrnXF frm = new Jurnal.jrnXF();
                
            frm.RefTbl = "AFB";
            frm.RefID = (int)view.GetFocusedRowCellValue(colAFBID);;
            frm.AltTbl = "FRT";
            frm.AltID = (int)view.GetFocusedRowCellValue(colFRTID); ;
                
            frm.ShowDialog();
            frm.Dispose();
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            Doc.DocXF frm = new Doc.DocXF();

            frm.RefTbl = "AFB";
            frm.RefID = (int)view.GetFocusedRowCellValue(colAFBID);
            frm.RefInfo = "Fatura: " + view.GetFocusedRowCellDisplayText(colAFBID);
            frm.AltTbl = "FRT";
            frm.AltID = (int)view.GetFocusedRowCellValue(colFRTID); ;
            
            frm.ShowDialog();
            frm.Dispose();
        }

        private void muhasebeFisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (afbGridView.GetFocusedRowCellValue(colDRM).ToString() != "A")
            {
                int afbID = (int)afbGridView.GetFocusedRowCellValue(colAFBID);
                FisDetayXF frm = new FisDetayXF("F", afbID);
                frm.ShowDialog();
            }
        }

        private void afbGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;

            if (e.Column == colOPID)
                e.DisplayText = string.Format("{0:N0} {1}", e.Value, view.GetListSourceRowCellValue(e.ListSourceRowIndex, colOPHM));
                
                //e.DisplayText = string.Format("{0:N0} {1}", e.Value, view.GetRowCellValue(e.RowHandle, colOPHM));
        }

        private void showPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPreviewToolStripMenuItem.Checked = !showPreviewToolStripMenuItem.Checked;
            afbGridView.OptionsView.ShowPreview = showPreviewToolStripMenuItem.Checked;
            colOZLDRM.Visible = !showPreviewToolStripMenuItem.Checked;
            colTAGS.Visible = showPreviewToolStripMenuItem.Checked;
        }

        private void faturaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //colTAGS.Visible = false;


            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = afbGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("FATURALAR");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void ticariFatura2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int afbID = (int)view.GetFocusedRowCellValue(colAFBID);
            Fatura5XR rpr = new Fatura5XR(afbID, antetToolStripComboBox.Text, Program.USR);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
                //                if (printTool.PrintingSystem.GetCommandVisibility(PrintingSystemCommand.Watermark) != CommandVisibility.None)
                //                {
                //                    printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
                //                }
                printTool.ShowPreviewDialog();
            }
        }

        private void ticariFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int afbID = (int)view.GetFocusedRowCellValue(colAFBID);
            FaturaXR rpr = new FaturaXR(afbID, antetToolStripComboBox.Text, Program.USR);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
//                if (printTool.PrintingSystem.GetCommandVisibility(PrintingSystemCommand.Watermark) != CommandVisibility.None)
//                {
//                    printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
//                }
                printTool.ShowPreviewDialog();
            }
        }

        private void faturaYurtdisiDraftKDVDahilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int afbID = (int)view.GetFocusedRowCellValue(colAFBID);
            Fatura2XR rpr = new Fatura2XR(afbID, antetToolStripComboBox.Text, Program.USR);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                if (printTool.PrintingSystem.GetCommandVisibility(PrintingSystemCommand.Watermark) != CommandVisibility.None)
                {
                    printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
                }
                printTool.ShowPreviewDialog();
            }
        }

        private void opsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellDisplayText(colOPHM) == "M")
            {
                Ops.opMasterXUC frm = new Ops.opMasterXUC();
                frm.qsString = string.Format("OPMid = {0}", view.GetFocusedRowCellValue(colOPID));
                frm.Show();

                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                panel.FloatLocation = new Point(100, 100);
                panel.FloatSize = new Size(600, 300);
                panel.Name = "Ops";
                panel.Text = "Ops:" + view.GetFocusedRowCellDisplayText(colOPID);

                frm.Dock = DockStyle.Fill;
                panel.Controls.Add(frm);
            }

            else if (afbGridView.GetFocusedRowCellDisplayText(colOPHM) == "H")
            {
                Ops.opHouseXUC frm = new Ops.opHouseXUC();
                frm.qsString = string.Format("OPHid = {0}", view.GetFocusedRowCellValue(colOPID));
                frm.Show();

                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                panel.FloatLocation = new Point(100, 100);
                panel.FloatSize = new Size(600, 300);
                panel.Name = "Ops";
                panel.Text = "Ops:" + view.GetFocusedRowCellDisplayText(colOPID);

                frm.Dock = DockStyle.Fill;
                panel.Controls.Add(frm);
            }
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            Firma.frtXUC frm = new Firma.frtXUC();
            frm.qsString = string.Format("FRTid = {0}", view.GetFocusedRowCellValue(colFRTID));
            frm.Show();

            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
            panel.FloatLocation = new Point(100, 100);
            panel.FloatSize = new Size(600, 300);
            panel.Name = "Firma";
            panel.Text = "Firma:" + view.GetFocusedRowCellDisplayText(colFRTID);

            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
        }

        private void eMailFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;
            view.ExpandAllGroups();
            
            StringBuilder sb = new StringBuilder();
            
            int currentRowHandle = view.GetVisibleRowHandle(0);
            if (view.IsDataRow(currentRowHandle))
                sb.Append(view.GetRowCellValue(currentRowHandle, colAFBID).ToString());
            
            while (currentRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (view.IsDataRow(currentRowHandle))
                {
                    if (sb.Length > 0)
                        sb.Append(",");
                    sb.Append(view.GetRowCellValue(currentRowHandle, colAFBID).ToString());
                }
                
                currentRowHandle = view.GetNextVisibleRow(currentRowHandle);
            }
            //MessageBox.Show(sb.ToString());
            //Clipboard.Clear();
            //Clipboard.SetText(sb.ToString());

            TopluFaturaXF frm = new TopluFaturaXF();
            frm.afbIDs = sb.ToString();
            frm.USR = Program.USR;
            frm.USReMail = Program.USReMail;
            frm.ShowDialog();
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = afbGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void afbGridView_CustomSummaryExists(object sender, CustomSummaryExistEventArgs e)
        {
            /*
            GridView view = (GridView)sender;
            GridSummaryItem item = e.Item as GridSummaryItem;
            if (item == null) return;
            GridColumn col = view.Columns[item.FieldName];
            if (col == null) return;
            */
            if (e.Item is GridGroupSummaryItem)
            {
                var aaa = e.Item;
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                //if (e.IsGroupSummary && e.GroupLevel != colBDVZ.GroupIndex && fn == "BTUTBRT")
                if (colBDVZ.GroupIndex == -1 && fn == "BTUTBRT")
                    e.Exists = false;
                else if (e.GroupLevel < colBDVZ.GroupIndex && fn == "BTUTBRT")
                    e.Exists = false;
            }
        }


        /// <summary>
        /// Group Row degererini ilgili Column da gosterir
        /// </summary>
        /// <param name="view"></param>
        /// <returns></returns>
        /*
        private void afbGridView_CustomDrawGroupRow(object sender, RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            ArrayList items = ExtractSummaryItems(view);
            if (items.Count == 0) return;
            DrawBackground(e, view);
            DrawSummaryValues(e, view, items);
            e.Handled = true;
        }
        */

        private void afbGridView_CustomDrawGroupRow(object sender, RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            ArrayList groupSummaryItems = ExtractSummaryItems(view);
            if (groupSummaryItems.Count == 0) return;
            DrawBackground(e, view);
            DrawSummaryValues(e, view, groupSummaryItems);
            e.Handled = true;
        }

        private ArrayList ExtractSummaryItems(GridView view)
        {
            ArrayList groupSummaryItems = new ArrayList();
            foreach (GridSummaryItem si in view.GroupSummary)
                if (si is GridGroupSummaryItem && si.SummaryType != DevExpress.Data.SummaryItemType.None)
                    groupSummaryItems.Add(si);
            return groupSummaryItems;
        }

        private void DrawBackground(RowObjectCustomDrawEventArgs e, GridView view)
        {
            GridGroupRowPainter painter;
            GridGroupRowInfo info;
            painter = e.Painter as GridGroupRowPainter;
            info = e.Info as GridGroupRowInfo;
            int level = view.GetRowLevel(e.RowHandle);
            int row = view.GetDataRowHandleByGroupRowHandle(e.RowHandle);
            info.GroupText = string.Format("{0}: {1}", view.GroupedColumns[level].Caption,
                view.GetRowCellDisplayText(row, view.GroupedColumns[level]));
            e.Appearance.DrawBackground(e.Cache, info.Bounds);
            painter.ElementsPainter.GroupRow.DrawObject(info);
        }

        private void DrawSummaryValues(RowObjectCustomDrawEventArgs e, GridView view, ArrayList items)
        {
            Hashtable values = view.GetGroupSummaryValues(e.RowHandle);
            foreach (GridGroupSummaryItem item in items)
            {
                Rectangle rect = GetColumnBounds(view, item);
                if (rect.IsEmpty) continue;
                string text = item.GetDisplayText(values[item], false);
                rect = CalcSummaryRect(text, e, view.Columns[item.FieldName]);
                e.Appearance.DrawString(e.Cache, text, rect);
            }
        }

        private Rectangle GetColumnBounds(GridView view, GridGroupSummaryItem item)
        {
            GridColumn column = view.Columns[item.FieldName];
            return GetColumnBounds(column);
        }
        GridViewInfo gridInfo = null;
        private Rectangle GetColumnBounds(GridColumn column)
        {
            gridInfo = (GridViewInfo)column.View.GetViewInfo();
            GridColumnInfoArgs colInfo = gridInfo.ColumnsInfo[column];

            if (colInfo != null)
                return colInfo.Bounds;
            else
                return Rectangle.Empty;
        }

        private Rectangle CalcSummaryRect(string text, RowObjectCustomDrawEventArgs e, GridColumn column)
        {
            Rectangle result = GetColumnBounds(column);
            SizeF sz = TextUtils.GetStringSize(e.Graphics, text, e.Appearance.Font);
            int width = Convert.ToInt32(sz.Width) + 1;
            if (!gridInfo.ViewRects.FixedLeft.IsEmpty)
            {
                int fixedLeftRight = gridInfo.ViewRects.FixedLeft.Right;
                int marginLeft = result.Right - width - fixedLeftRight;
                if (marginLeft < 0 && column.Fixed == FixedStyle.None)
                    return Rectangle.Empty;
            }
            if (!gridInfo.ViewRects.FixedRight.IsEmpty)
            {
                int fixedRightLeft = gridInfo.ViewRects.FixedRight.Left;
                if (fixedRightLeft <= result.Right && column.Fixed == FixedStyle.None)
                    return Rectangle.Empty;
            }
            result = FixLeftEdge(width, result);
            result.Width = result.Width;
            result.Y = e.Bounds.Y;
            result.Height = e.Bounds.Height - 2;

            return PreventSummaryTextOverlapping(e, result);
        }

        private Rectangle FixLeftEdge(int width, Rectangle result)
        {
            int delta = result.Width - width - 2;
            if (delta > 0)
            {
                result.X += delta;
                result.Width -= delta;
            }
            return result;
        }

        private Rectangle PreventSummaryTextOverlapping(RowObjectCustomDrawEventArgs e, Rectangle rect)
        {
            GridGroupRowInfo gInfo = (GridGroupRowInfo)e.Info;
            int groupTextLocation = gInfo.ButtonBounds.Right + 10;
            int groupTextWidth = TextUtils.GetStringSize(e.Graphics, gInfo.GroupText, e.Appearance.Font).Width;
            int fixedLeft = gInfo.ViewInfo.ViewRects.FixedLeft.Left;
            Rectangle r = new Rectangle(groupTextLocation, 0, groupTextWidth, e.Info.Bounds.Height);
            if (r.Right > rect.X)
            {
                if (r.Right > rect.Right)
                    rect.Width = 0;
                else
                {
                    rect.Width -= r.Right - rect.X;
                    rect.X = r.Right;
                }
            }
            return rect;
        }

        private void exportToETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;
            view.ExpandAllGroups();

            StringBuilder sb = new StringBuilder();

            int currentRowHandle = view.GetVisibleRowHandle(0);
            if (view.IsDataRow(currentRowHandle))
                sb.Append(view.GetRowCellValue(currentRowHandle, colAFBID).ToString());

            while (currentRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (view.IsDataRow(currentRowHandle))
                {
                    if (sb.Length > 0)
                        sb.Append(",");
                    sb.Append(view.GetRowCellValue(currentRowHandle, colAFBID).ToString());
                }

                currentRowHandle = view.GetNextVisibleRow(currentRowHandle);
            }
            //MessageBox.Show(sb.ToString());
            //Clipboard.Clear();
            //Clipboard.SetText(sb.ToString());

            AccountETA.EtaFtrXF frm = new AccountETA.EtaFtrXF();
            frm.afbIDs = sb.ToString();
            frm.ShowDialog();
            
            frm.Dispose();
        }

        private void afbGridView_CalcPreviewText(object sender, CalcPreviewTextEventArgs e)
        {
            GridView View = sender as GridView;
            string tags = View.GetRowCellDisplayText(e.RowHandle, colTAGS);
            string ozlDrm = View.GetRowCellDisplayText(e.RowHandle, colOZLDRM);
               
            //if (View.GetRowCellDisplayText(e.RowHandle, colTAGS) != "")
                e.PreviewText = View.GetRowCellDisplayText(e.RowHandle, colTAGS);
                if (e.PreviewText != "" && ozlDrm != "")
                    e.PreviewText += "\r\n";
                e.PreviewText += View.GetRowCellDisplayText(e.RowHandle, colOZLDRM);
            
            /*
            GridView View = sender as GridView;
            var aaa = e.RowHeight;
            var bbb = View.GetRowPreviewDisplayText(e.RowHandle);
            //if (View.GetRowCellDisplayText(e.RowHandle, colTAGS) == "")
                if (View.GetRowPreviewDisplayText(e.RowHandle) == "")
                    e.RowHeight = 0;*/
        }

        private void afbGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.GetRowCellValue(e.RowHandle, "TUR") == DBNull.Value)
            {
                e.ErrorText = "Tür girilmemiş.!\n";
                e.Valid = false;
            }
            else if (view.GetRowCellValue(e.RowHandle, "TUR").ToString().Substring(1, 1) == "D" && view.GetRowCellValue(e.RowHandle, "DKNFRTID") == DBNull.Value)
            {
                e.ErrorText = "Dekont Firma girilmemiş.!\n";
                e.Valid = false;
            }
            else if (view.GetRowCellValue(e.RowHandle, "FRTID") == DBNull.Value)
            {
                e.ErrorText = "Firma girilmemiş.!\n";
                e.Valid = false;
            }
        }

        /*
        private void TEKmarkenFaturaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string afbID = afbGridView.GetFocusedRowCellValue("AFBID").ToString();

            AccountRpr.AccMarkenFtrXF frm = new AccountRpr.AccMarkenFtrXF();
            frm.afbIDs = afbID;
            frm.ShowDialog();
        }
        */
        private void markenFaturaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;
            view.ExpandAllGroups();

            StringBuilder sb = new StringBuilder();

            int currentRowHandle = view.GetVisibleRowHandle(0);
            if (view.IsDataRow(currentRowHandle))
                sb.Append(view.GetRowCellValue(currentRowHandle, colAFBID).ToString());

            while (currentRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (view.IsDataRow(currentRowHandle))
                {
                    if (sb.Length > 0)
                        sb.Append(",");
                    sb.Append(view.GetRowCellValue(currentRowHandle, colAFBID).ToString());
                }

                currentRowHandle = view.GetNextVisibleRow(currentRowHandle);
            }
            //MessageBox.Show(sb.ToString());
            //Clipboard.Clear();
            //Clipboard.SetText(sb.ToString());

            AccountRpr.AccMarkenFtrXF frm = new AccountRpr.AccMarkenFtrXF();
            frm.afbIDs = sb.ToString();
            frm.ShowDialog();
        }

        private void faturaResmiMarkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int afbID = (int)view.GetFocusedRowCellValue(colAFBID);
            Fatura3XR rpr = new Fatura3XR(afbID, antetToolStripComboBox.Text, Program.USR);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                if (printTool.PrintingSystem.GetCommandVisibility(PrintingSystemCommand.Watermark) != CommandVisibility.None)
                {
                    printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
                }
                printTool.ShowPreviewDialog();
            }
        }

        private void faturaResmiMarken2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int afbID = (int)view.GetFocusedRowCellValue(colAFBID);
            Fatura32XR rpr = new Fatura32XR(afbID, antetToolStripComboBox.Text, Program.USR);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                if (printTool.PrintingSystem.GetCommandVisibility(PrintingSystemCommand.Watermark) != CommandVisibility.None)
                {
                    printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
                }
                printTool.ShowPreviewDialog();
            }
        }

        private void ticariFaturaAllInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int afbID = (int)view.GetFocusedRowCellValue(colAFBID);
            FaturaXR rpr = new FaturaXR(afbID, antetToolStripComboBox.Text, Program.USR, true);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
                printTool.ShowPreviewDialog();
            }

        }

        private void kurFarkiFaturaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            // AFB_INS_KURFARKI (curAfbID, topKurFarkiTL, FtrTrh, FtrNo, Usr)
            // Tur BS/AS disinda olamaz.
            if (!view.IsDataRow(view.FocusedRowHandle))
                return;


            // Simdilik aktif degil
            //if (!Program.MF.EntryCheck("AFB.FaturaKurFarkiInsXF", false))
            //    return;

            string tur = afbGridView.GetFocusedRowCellValue(colTUR).ToString();
            if (tur == "BS" || tur == "AA")
            {
                int afbID = (int)view.GetFocusedRowCellValue(colAFBID);
                FaturaKurFarkiInsXF frm = new FaturaKurFarkiInsXF();
                frm.refAfbID = afbID;
                frm.ShowDialog();

                FaturaXF ftr = new FaturaXF();
                ftr.AFBid = frm.newAfbID;
                ftr.ShowDialog();
                ftr.Dispose();
            }

        }

        private void refFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellValue(colREFAFBID) != DBNull.Value)
            {
                FaturaXF ftr = new FaturaXF();
                ftr.AFBid = (int)view.GetFocusedRowCellValue(colREFAFBID);
                ftr.ShowDialog();
                ftr.Dispose();
            }

        }

        private void kurFarkiFaturasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            FaturaXF ftr = new FaturaXF();
            ftr.RefAfbID = (int)view.GetFocusedRowCellValue(colAFBID);
            ftr.ShowDialog();
            ftr.Dispose();
        }

        private void tAGUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int afbID = (int)view.GetFocusedRowCellValue(colAFBID);
            Genel.TblTagMdfyXF frm = new Genel.TblTagMdfyXF();
            frm.RefTbl = "AFB";
            frm.RefID = afbID;
            frm.TAGs = view.GetFocusedRowCellValue("TAGS");
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.afbTableAdapter.Fill(this.accountDataSet.AFB, string.Format("AFBID = {0}", afbID), Program.USR);
            }
        }

        private void kPISetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            if (!Program.MF.EntryCheck("Genel.KpiSetXF", false))
                return;

            int PK = (int)view.GetFocusedRowCellValue(colAFBID);

            Genel.KpiSetXF frm = new Genel.KpiSetXF();
            frm.Tbl = "AFB";
            frm.TblPK = PK;
            frm.KPI = view.GetFocusedRowCellValue(colKPI).ToString();
            frm.KpiUsr = view.GetFocusedRowCellValue(colKPIUSR).ToString();
            frm.KpiTrh = view.GetFocusedRowCellValue(colKPITRH);
            frm.ShowDialog();
            frm.Dispose();

            this.afbTableAdapter.Fill(this.accountDataSet.AFB, string.Format("AFBID = {0}", PK), Program.USR);
        }

    }

}
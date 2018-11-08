using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraBars.Docking;

using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace tMax14.Firma
{
    public partial class frtXUC : DevExpress.XtraEditors.XtraUserControl
    {
        //Docs.docForm docFrm;
        string qryPrmStr = string.Empty;
        string qryStr = string.Empty;
        FirebirdSql.Data.FirebirdClient.FbCommand activeFbCommand = new FbCommand();
        public string qsString = string.Empty;
        Qry.qsvFrtXUC qsFrm = new Qry.qsvFrtXUC();

        //string usrBKM= "<" + Program.USTid.ToString() + ">";

        public frtXUC()
        {
            InitializeComponent();

            //this.frtTableAdapter.ClearBeforeFill = false;
            //this.frcTableAdapter.ClearBeforeFill = false; Onemli degil

            //this.firmaDataSet.FRT.Columns.Add("hasFRC", System.Type.GetType("Boolean"));
            //dockManager1.

            frtGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTUR.ColumnEdit = Program.MF.frtTurRepositoryItemLookUpEdit;
            colDRM.ColumnEdit = Program.MF.frtDrmRepositoryItemLookUpEdit;
            colHDQID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colSREPIDS.ColumnEdit = Program.MF.ustListRepositoryItemCheckedComboBoxEdit;
            colTAGS.ColumnEdit = Program.MF.TAGselFRTrepositoryItemCheckedComboBoxEdit;
            colLOCID.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colSRVULK.ColumnEdit = Program.MF.CNTRYrepositoryItemCheckedComboBoxEdit;

            if (!Program.MF.EntryCheck("Firma.frtXUC.TopluExtre", true))
                topluExtreToolStripMenuItem.Enabled = false;
        }

        public bool Save()
        {
            try
            {
                this.Validate();
                this.frtBindingSource.EndEdit();
                this.frtTableAdapter.Update(this.firmaDataSet.FRT_REC_SEL);
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return false;
                //throw;
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

        }

        private void frtForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frtForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(qsString))
            {
                int nor = 0;
                Program.MF.startSW();
                try
                {
                    nor = this.frtTableAdapter.Fill(this.firmaDataSet.FRT_REC_SEL, qsString, Program.USR);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                finally
                {
                    Program.MF.stopSW("Firma", nor);
                }
            }


            //Qry.qsvFrtXUC frm2 = new Qry.qsvFrtXUC();
            qsFrm.FRT = firmaDataSet.FRT_REC_SEL;
            qsFrm.Dock = DockStyle.Fill;

            qsDockPanel.Controls.Add(qsFrm);
            //frm2.Show();

            //frtGridControl.DataSource = this.firmaDataSet.FRT;    //Ozellikle YOK
            Program.MF.GridControlSettings(frtGridControl);
            frtGridView.FormatConditions[0].Expression = string.Format("Contains([BKMS], '{0}')", Program.USRtag);


        }

        #region Fill Childs dynamically

        private int getFrtId()
        {
            if (!frtGridView.IsEmpty && frtGridView.IsDataRow(frtGridView.FocusedRowHandle))
            {
                return (int)frtGridView.GetFocusedRowCellValue(colFRTID);
            }
            return 0;
        }

        private int getDataSourceRowIndex()
        {
            if (!frtGridView.IsEmpty && frtGridView.IsDataRow(frtGridView.FocusedRowHandle))
            {
                return frtGridView.GetDataSourceRowIndex(frtGridView.FocusedRowHandle);
            }
            return GridControl.InvalidRowHandle;
        }

        private void frtGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            /*
            if (docFrm != null)
            {
                if (e.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle ||
                    e.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle ||
                    !frtGridView.IsDataRow(e.FocusedRowHandle))
                    docFrm.NewId(0);
                else
                    docFrm.NewId((int)frtGridView.GetFocusedRowCellValue(colFRTID));
            }*/
        }

        #endregion Fill Childs dynamically

        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int refId; 
            /* // Merkezi/HQ varsa onun altinda topla
            if (frtGridView.GetFocusedRowCellValue(colHDQID) == DBNull.Value)
                refId = (int)frtGridView.GetFocusedRowCellValue(colFRTID);
            else
                refId = (int)frtGridView.GetFocusedRowCellValue(colHDQID);
            */

            refId = (int)frtGridView.GetFocusedRowCellValue(colFRTID);

            Jurnal.jrnXF frm = new Jurnal.jrnXF();
            frm.RefTbl = "FRT";
            frm.RefID = refId;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frtGridView.DataRowCount == 0)
                return;

            int refId;
            /* // Merkezi/HQ varsa onun altinda topla
            if (frtGridView.GetFocusedRowCellValue(colHDQID) == DBNull.Value)
                refId = (int)frtGridView.GetFocusedRowCellValue(colFRTID);
            else
                refId = (int)frtGridView.GetFocusedRowCellValue(colHDQID);
            */
            refId = (int)frtGridView.GetFocusedRowCellValue(colFRTID);

            Doc.DocXF frm = new Doc.DocXF();
            frm.RefTbl = "FRT";
            frm.RefID = refId;
            frm.RefInfo = frtGridView.GetFocusedRowCellDisplayText(colADN);
            frm.ShowDialog();
            frm.Dispose();

            /*
            bool panelYok = true;
            for (int i = 0; i < dockManager.Panels.Count; i++)
            {
                if (dockManager.Panels[i].Name == "docPanel")
                {
                    dockManager.Panels[i].Show();
                    panelYok = false;
                }
            }
            if (panelYok)
            {
                int refId; // Merkezi/HQ varsa onun altinda topla
                if (frtGridView.GetFocusedRowCellValue(colHDQID) == DBNull.Value)
                    refId = (int)frtGridView.GetFocusedRowCellValue(colFRTID);
                else
                    refId = (int)frtGridView.GetFocusedRowCellValue(colHDQID);

                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
                panel.Name = "docPanel";

                docFrm = new Docs.docForm();
                docFrm.refTbl = "FRT";
                docFrm.refId = refId;
                panel.Text = "Attachments " + docFrm.refTbl + "/" + refId.ToString();
                docFrm.Dock = DockStyle.Fill;
                panel.Controls.Add(docFrm);     // Panel Show edilene kadar FormLoad cagrilmiyor
            }*/
        }

        public void Query()
        {
            int nor = 0;
            Program.MF.startSW();
            
            Program.QPF.TBL = "FRT";
            if (Program.QPF.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            qryStr = Program.QPF.prepareQryStr();

            //DataTable dt = (DataTable)this.firmaDataSet.FRT;
            this.firmaDataSet.FRT_REC_SEL.Clear();
            //Program.QPF.doQry("FRT", (DataTable)this.firmaDataSet.FRT_REC_SEL, activeFbCommand, qryPrmStr);   // Kullanma: FRT_REC_SEL Procedure orada olan olanlar Table da yok
            nor = this.frtTableAdapter.Fill(this.firmaDataSet.FRT_REC_SEL, qryStr, Program.USR);
            Program.MF.stopSW("Firma", nor);
        }

        private void qryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void yeniKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int FRTid = 0;
            frtEditForm frm = new frtEditForm();
            frm.FRTid = FRTid;
            frm.ShowDialog();
            FRTid = frm.FRTid;
            frm.Dispose();

            if (FRTid != 0)
            {
                this.frtTableAdapter.ClearBeforeFill = false;
                this.frtTableAdapter.Fill(this.firmaDataSet.FRT_REC_SEL, string.Format("FRTid = {0}", FRTid), Program.USR);
                this.frtTableAdapter.ClearBeforeFill = true;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var aaa = frtGridView.FocusedRowHandle;
            //var bbb = frtGridView.GetFocusedRowCellValue(colFRTID);

            if (!Program.MF.EntryCheck("Firma.frtEditForm", true))
                return;

            int FRTid = 0;
            if (!string.IsNullOrWhiteSpace(frtGridView.GetFocusedRowCellDisplayText(colFRTID)))
                FRTid = (int)frtGridView.GetFocusedRowCellValue(colFRTID);
            frtEditForm frm = new frtEditForm();
            frm.FRTid = FRTid;
            frm.ShowDialog();
            FRTid = frm.FRTid;
            frm.Dispose();

            if (FRTid != 0)
            {
                this.frtTableAdapter.ClearBeforeFill = false;
                this.frtTableAdapter.Fill(this.firmaDataSet.FRT_REC_SEL, string.Format("FRTid = {0}", FRTid), Program.USR);
                this.frtTableAdapter.ClearBeforeFill = true;
            }

            //reQuery();  // ModalForm dan dondugunde frtGridControl_Enter calismiyor
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reQuery();
        }

        private void reQuery()
        {
            if (!string.IsNullOrEmpty(activeFbCommand.CommandText))
            {
                //DataTable dt = (DataTable)this.firmaDataSet.FRT;
                Program.QPF.reQry((DataTable)this.firmaDataSet.FRT_REC_SEL, activeFbCommand);
            }
        }

        private void frtGridControl_Enter(object sender, EventArgs e)
        {
            reQuery();
        }

        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BKMS = frtGridView.GetFocusedRowCellValue(colBKMS).ToString();
            // Toggle 
            if (BKMS.Contains(Program.USRtag))   // Varsa cikar
            {
                BKMS = BKMS.Replace(Program.USRtag, "");
                frtGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                frtGridView.UpdateCurrentRow();
            }
            else                        // Yoksa ekle
            {
                BKMS += Program.USRtag;
                frtGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                frtGridView.UpdateCurrentRow();
            }
            Save();
        }

        private void dockManager_ClosedPanel(object sender, DockPanelEventArgs e)
        {
            e.Panel.Dispose();
        }

        private void housesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opHouseXUC", false))
                return;

            Ops.opHouseXUC frm = new Ops.opHouseXUC();
            frm.qsString = string.Format("{0} in (ShpID,CneID,MnfID,DcnID,NfyID,Nf2ID,CrrID,AccID)", frtGridView.GetFocusedRowCellValue(colFRTID));
            frm.Show();

            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
            panel.FloatLocation = new Point(100, 100);
            panel.FloatSize = new Size(600, 300);
            panel.Name = "House";
            panel.Text = "Houses of " + frtGridView.GetFocusedRowCellDisplayText(colAD);

            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);   
        }

        private void mastersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opMasterXUC", false))
                return;

            Ops.opMasterXUC frm = new Ops.opMasterXUC();
            frm.qsString = string.Format("{0} in (ShpID,CneID,CrrID,CraID)", frtGridView.GetFocusedRowCellValue(colFRTID));
            frm.Show();

            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
            panel.FloatLocation = new Point(100, 100);
            panel.FloatSize = new Size(600, 300);
            panel.Name = "Master";
            panel.Text = "Masters of " + frtGridView.GetFocusedRowCellDisplayText(colAD);

            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
        }

        private void merkezVeSubeleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frtTableAdapter.ClearBeforeFill = false;
            this.frtTableAdapter.FillByHDQ(this.firmaDataSet.FRT_REC_SEL, (int)frtGridView.GetFocusedRowCellValue(colFRTID));
            this.frtTableAdapter.ClearBeforeFill = true;
            colHDQID.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        }

        private void hesapHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("AccountRpr.AvdHstXF", false))
                return;

            var view = frtGridView;
            AccountRpr.AvdHstXF frm = new AccountRpr.AvdHstXF();
            frm.HspNo = "";
            frm.FRTid = (int)view.GetFocusedRowCellValue(colFRTID);
            frm.info = string.Format("{0} #{1}", view.GetFocusedRowCellDisplayText(colADN), view.GetFocusedRowCellValue(colFRTID));
            frm.Show();
            
            /*
            Account.FisDetayHistoryXF frm = new Account.FisDetayHistoryXF();
            frm.iQry = "";
            frm.FRTid = (int)view.GetFocusedRowCellValue(colFRTID);
            frm.info = string.Format("{0} #{1}", view.GetFocusedRowCellDisplayText(colADN), view.GetFocusedRowCellValue(colFRTID));
            //frm.info = view.GetFocusedRowCellValue(colHSPAD).ToString() + "  " + view.GetFocusedRowCellDisplayText(colHSPNOS);
            //frm.Show();

            frm.Dock = DockStyle.Fill;
            var dd = frm.Size.Height;
            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
            panel.Text = view.GetFocusedRowCellDisplayText(colADN);
            panel.FloatSize = new Size(frm.Size.Width, frm.Size.Height);
            panel.Controls.Add(frm);
            var ddd = dockManager.Panels.Count;
            if (dockManager.Panels.Count > 2)
            {
                dockManager.Panels[1].Show();
                panel.DockAsTab(dockManager.Panels[1], 0);
                //panel.DockTo(dockManager.Panels[0]);
                //panel.ParentPanel.Tabbed = true;
            }
            */
        }

        private void faturaLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)frtGridView.GetFocusedRowCellValue(colFRTID);
            string IDskl = "FRT"; 

            Account.FaturaLinkXF frm = new Account.FaturaLinkXF();
            frm.ID = ID;
            frm.IDskl = IDskl;
            frm.IDtyp = "F";
            frm.ShowDialog();
            frm.Dispose();
        }

        private void faturaLink2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Account.FaturaLink2XF", false))
                return;

            int ID = (int)frtGridView.GetFocusedRowCellValue(colFRTID);
            string IDskl = "FRT";

            Account.FaturaLink2XF frm = new Account.FaturaLink2XF();
            frm.ID = ID;
            frm.IDskl = IDskl;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void onayliTedarikcilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnayliTedarikcilerXR rpr = new OnayliTedarikcilerXR(qsFrm.searchQry);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
                printTool.ShowPreviewDialog();
            }
        }

        private void anlasmalarOdemelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnlasmaOdemeXR rpr = new AnlasmaOdemeXR(qsFrm.searchQry);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
                printTool.ShowPreviewDialog();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = frtGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("FİRMALAR");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void hesapExtresiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("AccountRpr.ExtreXF", false))
                return;

            AccountRpr.ExtreXF frm = new AccountRpr.ExtreXF();
            frm.frtID = (int)frtGridView.GetFocusedRowCellValue(colFRTID);
            frm.firma = string.Format("{0} #{1}", frtGridView.GetFocusedRowCellDisplayText(colADN), frtGridView.GetFocusedRowCellValue(colFRTID));
            frm.Show();
        }

        private void hesapBakiyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Account.AccHspNoBkyXF", false))
                return;

            var view = frtGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int frtID = (int)view.GetFocusedRowCellValue(colFRTID);
            Account.AccHspNoBkyXF frm = new Account.AccHspNoBkyXF("", frtID);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void frtGridView_CalcRowHeight(object sender, RowHeightEventArgs e)
        {
            if (e.RowHandle < 0)
                e.RowHeight = 0;
        }

        private void topluExtreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Bunun icin Menude secenek YOK!!!
            //if (!Program.MF.EntryCheck("AccountRpr.AccAfbKlnDtyXF", false))
            //    return;

            tMax14ReportClassLibrary.TopluExtreXF rpr = new tMax14ReportClassLibrary.TopluExtreXF();
            rpr.USR = Program.USR;
            rpr.USReMail = Program.USReMail;
            rpr.Show();
        }

        private void topluEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = frtGridView;
            view.ExpandAllGroups();
            StringBuilder sb = new StringBuilder();
            for (int rh = 0; rh < view.RowCount; rh++)
            {
                sb.AppendLine(view.GetRowCellValue(rh, "FRTID").ToString());
            }
            MessageBox.Show(sb.ToString());
        }

        private void reportHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.rphXF frm = new Genel.rphXF();

            frm.iQry = string.Format("FrtID = {0}", frtGridView.GetFocusedRowCellValue(colFRTID));

            frm.ShowDialog();
            frm.Dispose();
        }

        private void faturaHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("AccountRpr.AccAfbKlnDtyXF", false))
                return;

            AccountRpr.AccAfbKlnDtyXF frm = new AccountRpr.AccAfbKlnDtyXF();
            frm.frtID = (int)frtGridView.GetFocusedRowCellValue(colFRTID);
            //frm.firma = string.Format("{0} #{1}", frtGridView.GetFocusedRowCellDisplayText(colADN), frtGridView.GetFocusedRowCellValue(colFRTID));
            frm.Show();
        }

        private void hesapBakiyeFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("AccountRpr.AccAfbKlnHspXF", false))
                return;

            AccountRpr.AccAfbKlnHspXF frm = new AccountRpr.AccAfbKlnHspXF();
            frm.frtID = (int)frtGridView.GetFocusedRowCellValue(colFRTID);
            //frm.firma = string.Format("{0} #{1}", frtGridView.GetFocusedRowCellDisplayText(colADN), frtGridView.GetFocusedRowCellValue(colFRTID));
            frm.Show();
        }

        private void temsilciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Firma.FrtTemsilciListeXF", isSilent: false))
                return;

            frtTemsilciListeXF frm = new frtTemsilciListeXF();
            frm.iQry = qsFrm.searchQry;  //qryStr;
            frm.Show();
        }

        private void countryAgentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frcaXF frm = new frcaXF();
            frm.FrtID = (int)frtGridView.GetFocusedRowCellValue(colFRTID);
            frm.ShowDialog();
        }

    }
}
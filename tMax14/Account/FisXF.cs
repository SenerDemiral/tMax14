using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using System.Collections;

namespace tMax14.Account
{
    public partial class FisXF : DevExpress.XtraEditors.XtraForm
    {
        public int iAVBid = 0;
        public string iQry;
        string qryStr = string.Empty;
        string layoutName = "Account.FisXF";
        bool Editable = false;

        public FisXF()
        {
            InitializeComponent();

            Program.MF.GridControlSettings(avbGridControl);

            avbGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTUR.ColumnEdit = Program.MF.AVBTrepositoryItemLookUpEdit;
            colDRM.ColumnEdit = Program.MF.AVBdrmRepositoryItemImageComboBox;
            colTAGS.ColumnEdit = Program.MF.TAGselAVBrepositoryItemCheckedComboBoxEdit;

            colHSPNO.ColumnEdit = Program.MF.AHPrepositoryItemGridLookUpEdit;

            avbGridView.FormatConditions[0].Expression = string.Format("Contains([BKMS], '{0}')", Program.USRtag);

            Program.MF.XGLrestore(layoutName, 0, avbGridView);

            Editable = Program.MF.ModifyCheck("Account.FisXF", true);
            avbGridView.OptionsBehavior.Editable = Editable;
        }

        private void FisXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }
        
        public void Save()
        {
            try
            {
                object AVBid = avbGridView.GetFocusedRowCellValue(colAVBID);

                this.Validate();
                this.avbBindingSource.EndEdit();
                //this.avbTableAdapter.Save(this.accountDataSet.AVB);     !!Save Kullanma 5.9.1 de hata geliyor
                this.avbTableAdapter.Update(this.accountDataSet.AVB);

                if (AVBid != null)
                    this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("AVBid = {0}", AVBid), Program.USR);
            }
            catch (Exception e)
            {
                this.accountDataSet.AVB.RejectChanges();
                XtraMessageBox.Show(e.Message, "Kayıt edilemedi");
            }
        }

        private void FisXF_Load(object sender, EventArgs e)
        {
            Qry.qsvAvbXUC frm = new Qry.qsvAvbXUC();
            frm.AVB = accountDataSet.AVB;
            frm.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(frm);

            int nor = 0;
            Program.MF.startSW();

            if (iAVBid != 0)
                nor = this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("AVB.AVBid = {0}", iAVBid), Program.USR);
            else if (!string.IsNullOrEmpty(iQry))
                nor = this.avbTableAdapter.Fill(this.accountDataSet.AVB, iQry, Program.USR);
            //else
            //    nor = this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("AVB.AVBid > {0}", 0), Program.USR);
            this.avbTableAdapter.ClearBeforeFill = false;
            
            Program.MF.stopSW("Fiş", nor);
        }

        private void fisDetaylariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            int AVBid = (int)avbGridView.GetFocusedRowCellValue(colAVBID);
            FisDetayXF frm = new FisDetayXF("V", AVBid, Editable);
            frm.ShowDialog();

            this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("AVB.AVBid = {0}", AVBid), Program.USR);
        }

        private void avbGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int AVBid = (int)accountQueriesTableAdapter.GET_PK("ACC");
            view.SetFocusedRowCellValue(colAVBID, AVBid);
            view.SetFocusedRowCellValue(colTUR, "M");
            view.SetFocusedRowCellValue(colDRM, "A");
            view.SetFocusedRowCellValue(colTRH, DateTime.Today);
        }

        private void fisiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avbGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellValue(colDRM).ToString() != "A")
                return;

            if (!Program.MF.EntryCheck("Account.FisXF.Kapat", false))
                return;

            Save();
            try
            {
                int PK = (int)view.GetFocusedRowCellValue(colAVBID);
                if (accountQueriesTableAdapter.AVB_KAPA(PK, Program.USR).ToString() == "T")
                    this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("AVB.AVBid = {0}", PK), Program.USR);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Fiş Kapat");
            }
        }

        private void fisiAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avbGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellValue(colDRM).ToString() != "K")
                return;

            if (!Program.MF.EntryCheck("Account.FisXF.Ac", false))
                return;

            Save();
            try
            {
                int PK = (int)view.GetFocusedRowCellValue(colAVBID);
                if (accountQueriesTableAdapter.AVB_AC(PK, Program.USR).ToString() == "T")
                    this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("AVB.AVBid = {0}", PK), Program.USR);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Fiş Aç");
            }

        }

        private void avbGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            
            e.Cancel = !Program.MF.YetkiCheck(view.GetFocusedRowCellValue(colONYYTK).ToString());

            if (avbGridView.GetFocusedRowCellValue(colDRM).ToString() != "A" &&
                view.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle &&
                view.GetDataRow(view.FocusedRowHandle).RowState != DataRowState.Added)
                e.Cancel = true;
            else if (view.FocusedColumn != colTUR && view.FocusedColumn != colACIKLAMA &&
                     view.GetFocusedRowCellValue(colREFID) != DBNull.Value && 
                     view.GetFocusedRowCellValue(colREFTO).ToString() != "E")    // OdemeEmri disindakiler
                e.Cancel = true;
        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avbGridView;

            if (view.DataRowCount > 0 && view.IsDataRow(view.FocusedRowHandle))
            {
                int PK = (int)view.GetFocusedRowCellValue(colAVBID);
                Jurnal.jrnXF frm = new Jurnal.jrnXF();
                frm.RefTbl = "AVB";
                frm.RefID = PK;
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private void avbGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Column == colREFID)
                e.DisplayText = string.Format("{0:N0} {1}", e.Value, view.GetListSourceRowCellValue(e.ListSourceRowIndex, colREFTO));
        }

        private void referansKaydiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avbGridView;

            if (view.DataRowCount > 0 && view.IsDataRow(view.FocusedRowHandle))
            {
                object refTO = view.GetFocusedRowCellValue(colREFTO);
                if (refTO != DBNull.Value)
                {
                    object refID = view.GetFocusedRowCellValue(colREFID);
                    if (refTO.ToString() == "F")
                    {
                        FaturaDetayXF frm = new FaturaDetayXF((int)refID, false);
                        frm.ShowDialog();
                    }
                }
            }
        }

        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BKMS = avbGridView.GetFocusedRowCellValue(colBKMS).ToString();
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
            int PK = (int)avbGridView.GetFocusedRowCellValue(colAVBID);
            Program.MF.mainQueriesTableAdapter.BKMS_UPD("AVB", PK, BKMS);
            this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("AVBid = {0}", PK), Program.USR);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colEDITABLE.Visible = false;
            colAVDID.Visible = false;
            colSKL.Visible = false;
            
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = avbGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Muhasebe Fişleri");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void avbGridView_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            string avbID = avbGridView.GetRowCellValue(e.RowHandle, colAVBID).ToString();
            int nor = this.accountDataSet.AVD.Select("AVBID = " + avbID).Length;
            if ( nor == 0)
                this.avdTableAdapter.Fill(this.accountDataSet.AVD, (int)avbGridView.GetRowCellValue(e.RowHandle, colAVBID));

        }

        private void ExpandAllRows()
        {
            var View = avbGridView;

            View.BeginUpdate();
            try
            {
                int dataRowCount = View.DataRowCount;
                for (int rHandle = 0; rHandle < dataRowCount; rHandle++)
                    View.SetMasterRowExpanded(rHandle, true);
            }
            finally
            {
                View.EndUpdate();
            }
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = avbGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void usrTkpNoEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avbGridView;
            int avbID;
           
            view.ExpandAllGroups();
            int usrTkpID = (int)accountQueriesTableAdapter.GET_PK("UTID");

            for (int i = 0; i < view.RowCount; i++)
            {
                if (view.IsDataRow(i))
                {
                    avbID = (int)view.GetRowCellValue(i, colAVBID);
                    accountQueriesTableAdapter.AVB_UPD_USRTKPID(avbID, usrTkpID);
                }
            }
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avbGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            int PK = (int)view.GetFocusedRowCellValue(colAVBID);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = view.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "AVB";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();
            this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("AVBid = {0}", PK), Program.USR); //Refresh Clear=false
        }

        private void onaylaQuickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avbGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            int PK = (int)view.GetFocusedRowCellValue(colAVBID);
            if (Program.MF.OnaylaUsrYtk("AVB", PK, false))
                this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("AVBid = {0}", PK), Program.USR); //Refresh Clear=false

        }

        private void kapamaFisiBitirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avbGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            // Sadece Acik olan Kapama Fisleri icin yap
            if (view.GetFocusedRowCellValue("TUR").ToString() != "K" ||
                view.GetFocusedRowCellValue("DRM").ToString() != "A")
                return;

            // Fis kapatma yetkili olmali
            if (!Program.MF.EntryCheck("Account.FisXF.Kapat", false))
                return;

            int AVBid = (int)view.GetFocusedRowCellValue("AVBID");
            FisKapamaFisiXF frm = new FisKapamaFisiXF();
            frm.AvbID = AVBid;
            frm.ShowDialog();
        
            this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("AVB.AVBid = {0}", AVBid), Program.USR);
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query();
        }

        public void Query()
        {
            int nor = 0;
            Program.MF.startSW();

            Program.QPF.TBL = "AVB";
            if (Program.QPF.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            qryStr = Program.QPF.prepareQryStr();

            //DataTable dt = (DataTable)this.firmaDataSet.FRT;
            accountDataSet.AVB.Clear();
            //Program.QPF.doQry("FRT", (DataTable)this.firmaDataSet.FRT_REC_SEL, activeFbCommand, qryPrmStr);   // Kullanma: FRT_REC_SEL Procedure orada olan olanlar Table da yok
            nor = this.avbTableAdapter.Fill(accountDataSet.AVB, qryStr, Program.USR);
            Program.MF.stopSW("Fiş", nor);
        }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Account
{
    public partial class OdemeEmriXF : DevExpress.XtraEditors.XtraForm
    {
        public int iAVBid = 0;

        public OdemeEmriXF()
        {
            InitializeComponent();

            avbeGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colHSPNO.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            Program.MF.GridControlSettings(avbeGridControl);
        }

        private void OdemeEmriXF_Load(object sender, EventArgs e)
        {
            if (iAVBid != 0)
                this.avbeTableAdapter.Fill(this.accountDataSet.AVBE, string.Format("AVBid = {0}", iAVBid), Program.USR);
            else
                this.avbeTableAdapter.Fill(this.accountDataSet.AVBE, "AVBid > 0", Program.USR);

            this.avbeTableAdapter.ClearBeforeFill = false;
        }

        public void Save()
        {
            int PK = 0;
            if (avbeGridView.IsDataRow(avbeGridView.FocusedRowHandle))
                PK = (int)avbeGridView.GetFocusedRowCellValue(colAVBID);

            this.Validate();
            this.avbeBindingSource.EndEdit();
            this.avbeTableAdapter.Update(this.accountDataSet.AVBE);

            if (PK != 0)
                this.avbeTableAdapter.Fill(this.accountDataSet.AVBE, string.Format("AVBid = {0}", PK), Program.USR);
        }

        private void hazirlandiOnayiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avbeGridView.SetFocusedRowCellValue(colONY1USR, Program.USR);
            Save();
        }

        private void ilkOnayiniVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avbeGridView.SetFocusedRowCellValue(colONY2USR, Program.USR);
            Save();
        }

        private void sonOnayiniVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avbeGridView.SetFocusedRowCellValue(colONY3USR, Program.USR);
            Save();
        }

        private void revizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avbeGridView.SetFocusedRowCellValue(colDRM, "R");   // Revize
            /*
            avbeGridView.SetFocusedRowCellValue(colAVBBRC, null);
            avbeGridView.SetFocusedRowCellValue(colAVBALC, null);
            avbeGridView.SetFocusedRowCellValue(colAVBDVZ, null);

            avbeGridView.SetFocusedRowCellValue(colONY1YTK, null);
            avbeGridView.SetFocusedRowCellValue(colONY1USR, null);
            avbeGridView.SetFocusedRowCellValue(colONY1TRH, null);

            avbeGridView.SetFocusedRowCellValue(colONY2YTK, null);
            avbeGridView.SetFocusedRowCellValue(colONY2USR, null);
            avbeGridView.SetFocusedRowCellValue(colONY2TRH, null);

            avbeGridView.SetFocusedRowCellValue(colONY3YTK, null);
            avbeGridView.SetFocusedRowCellValue(colONY3USR, null);
            avbeGridView.SetFocusedRowCellValue(colONY3TRH, null);
            */
            Save();
        }

        private void avbeGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            int AVBid = (int)accountQueriesTableAdapter.GET_PK("ACC");

            avbeGridView.SetRowCellValue(e.RowHandle, colAVBID, AVBid);
            avbeGridView.SetRowCellValue(e.RowHandle, colEDITABLE, "T");
            avbeGridView.SetRowCellValue(e.RowHandle, colDRM, "H"); // Hazirlaniyor
        }

        private void odemeFisineGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            int AVBid = (int)avbeGridView.GetFocusedRowCellValue(colAVBID);

            FisXF frm = new FisXF();
            frm.iAVBid = AVBid;
            frm.Show();
            
        }

        private void muhasebeFisDetayiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            int AVBid = (int)avbeGridView.GetFocusedRowCellValue(colAVBID);

            FisDetayXF frm = new FisDetayXF("V", AVBid);
            frm.ShowDialog();
        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avbeGridView;

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

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avbeGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellValue(colDRM).ToString() == "K")
                return;

            if (!Program.MF.EntryCheck("Account.OdemeEmriXF.Kapat", false))
                return;

            Save();
            try
            {
                int PK = (int)view.GetFocusedRowCellValue(colAVBID);
                accountQueriesTableAdapter.AVBE_KAPA(PK);
                this.avbeTableAdapter.Fill(this.accountDataSet.AVBE, string.Format("AVBid = {0}", PK), Program.USR);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ÖdemeEmri Kapat");
            }
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avbeGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellValue(colDRM).ToString() != "K")
                return;

            if (!Program.MF.EntryCheck("Account.OdemeEmriXF.Ac", false))
                return;

            Save();
            try
            {
                int PK = (int)view.GetFocusedRowCellValue(colAVBID);
                accountQueriesTableAdapter.AVBE_AC(PK, Program.USR);
                this.avbeTableAdapter.Fill(this.accountDataSet.AVBE, string.Format("AVBid = {0}", PK), Program.USR);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ÖdemeEmri Aç");
            }

        }

        private void avbeGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = avbeGridView.GetFocusedRowCellValue(colEDITABLE).ToString() != "T";
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            bool E = avbeGridView.GetFocusedRowCellValue(colEDITABLE).ToString() == "T";
            hazirlandiOnayiToolStripMenuItem.Enabled = E;
            ilkOnayiniVerToolStripMenuItem.Enabled = E;
            sonOnayiniVerToolStripMenuItem.Enabled = E;
            revizeToolStripMenuItem.Enabled = E;
            
            kapatToolStripMenuItem.Enabled = E;
            acToolStripMenuItem.Enabled = E;

            // OdemeEmri kapatildiginda Ilgili Fis de kapatilir.
            // OdemeEmri acildiginda Ilgili Fis de acilir.
            
        }

    }
}
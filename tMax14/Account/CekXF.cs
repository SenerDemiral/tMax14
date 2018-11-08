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
using DevExpress.XtraPrinting;

namespace tMax14.Account
{
    public partial class CekXF : DevExpress.XtraEditors.XtraForm
    {
        public CekXF()
        {
            InitializeComponent();

            acsGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            
            colDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colCEKHSPNO.ColumnEdit = Program.MF.AHPrepositoryItemLookUpEdit;
            colMUSHSPNO.ColumnEdit = Program.MF.AHPrepositoryItemLookUpEdit;
            colDRM.ColumnEdit = Program.MF.AFBdrmRepositoryItemImageComboBox;
            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            Program.MF.GridControlSettings(acsGridControl);
            Program.MF.DVTrepositoryItemLookUpEdit.Closed += DVTrepositoryItemLookUpEdit_Closed;
        }

        void DVTrepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            var a = sender as LookUpEdit;
            if (a.OldEditValue != a.EditValue && acsGridControl.IsFocused)
            {
                object trh = acsGridView.GetFocusedRowCellValue(colGRSTRH) == DBNull.Value ? DateTime.Today : acsGridView.GetFocusedRowCellValue(colGRSTRH);
                this.kuR_AVBTableAdapter.Fill(this.accountDataSet.KUR_AVB, a.EditValue.ToString(), (DateTime)trh);
                acsGridView.SetFocusedRowCellValue(colKUR, accountDataSet.KUR_AVB[0].BKUR);
                acsGridView.SetFocusedRowCellValue(colAKUR, accountDataSet.KUR_AVB[0].AKUR);
            }
        }

        private void CekXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
            Program.MF.DVTrepositoryItemLookUpEdit.Closed -= DVTrepositoryItemLookUpEdit_Closed;
        }

        private void CekXF_Load(object sender, EventArgs e)
        {
            this.acsTableAdapter.Fill(this.accountDataSet.ACS, string.Format("ACSid > 0"), Program.USR);
            this.acsTableAdapter.ClearBeforeFill = false;
        }

        public void Save()
        {
            try
            {
                this.Validate();
                this.acsBindingSource.EndEdit();
                this.acsTableAdapter.Update(this.accountDataSet.ACS);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Save");
                this.accountDataSet.ACS.RejectChanges();
            }
        }

        private void muhasebeFisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FisXF frm = new FisXF();
            frm.iQry = string.Format("REFID = {0} and REFTO = 'C'", acsGridView.GetFocusedRowCellValue(colACSID));
            frm.Show();

        }

        private void muhasebeFisDetayiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ACSid = (int)acsGridView.GetFocusedRowCellValue(colACSID);

            FisDetayXF frm = new FisDetayXF("C", ACSid);
            frm.ShowDialog();

        }

        private void hareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = acsGridView;
            //FisDetayHistoryXF frm = new FisDetayHistoryXF();
            //frm.iQry = string.Format("RefTO = 'C' and RefID = {0}", view.GetFocusedRowCellValue(colACSID)); 
            //frm.info = string.Format("Çek# {0}", view.GetFocusedRowCellDisplayText(colACSID));
            //!!!frm.Show();

            FisDetayHistoryXF frm = new FisDetayHistoryXF();
            frm.iQry = string.Format("RefTO = 'C' and RefID = {0}", view.GetFocusedRowCellValue(colACSID));
            //frm.info = view.GetFocusedRowCellValue(colHSPAD).ToString() + "  " + view.GetFocusedRowCellDisplayText(colHSPNOS);
            //frm.Show();

            frm.Dock = DockStyle.Fill;
            var dd = frm.Size.Height;
            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
            panel.Text = string.Format("Çek# {0}", view.GetFocusedRowCellDisplayText(colACSID));
            panel.FloatSize = new Size(frm.Size.Width, frm.Size.Height);
            panel.Controls.Add(frm);
            var ddd = dockManager.Panels.Count;
            if (dockManager.Panels.Count > 1)      // Ilki kendisi
            {
                dockManager.Panels[0].Show();
                panel.DockAsTab(dockManager.Panels[0], 0);
                dockManager.RootPanels[0].ActiveChildIndex = 0;
            }

        }

        private void acsGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            //BeginInvoke(new MethodInvoker(view.CancelUpdateCurrentRow));  //CancelNewRow
            
            int ACSid = (int)accountQueriesTableAdapter.GET_PK("ACC");

            view.SetFocusedRowCellValue(colACSID, ACSid);
            view.SetFocusedRowCellValue(colTUR, "A");
            view.SetFocusedRowCellValue(colDRM, "A");
            view.SetFocusedRowCellValue(colGRSTRH, DateTime.Today);
            view.SetFocusedRowCellValue(colDVZ, "TRL");
            view.SetFocusedRowCellValue(colKUR, 1);
            view.SetFocusedRowCellValue(colAKUR, 1);
        }

        private void acsGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            e.Cancel = view.GetFocusedRowCellValue(colEDITABLE).ToString() == "F";
        }

        private void cekAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = acsGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellValue(colDRM).ToString() != "K")
                return;

            if (!Program.MF.EntryCheck("Account.CekXF.Ac", false))
                return;

            Save();
            try
            {
                int PK = (int)view.GetFocusedRowCellValue(colACSID);
                if (accountQueriesTableAdapter.ACS_AC(PK, Program.USR).ToString() == "T")
                    this.acsTableAdapter.Fill(this.accountDataSet.ACS, string.Format("ACSID = {0}", PK), Program.USR);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Çek Aç");
            }
        }

        private void cekKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = acsGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellValue(colDRM).ToString() != "A")
                return;

            if (!Program.MF.EntryCheck("Account.CekXF.Kapat", false))
                return;
            
            Save();
            try
            {
                int PK = (int)view.GetFocusedRowCellValue(colACSID);
                if (accountQueriesTableAdapter.ACS_KAPA(PK).ToString() == "T")
                    this.acsTableAdapter.Fill(this.accountDataSet.ACS, string.Format("ACSID = {0}", PK), Program.USR);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Çek Kapat");
            }
}

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = acsGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "Çekler", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();

        }


    }
}
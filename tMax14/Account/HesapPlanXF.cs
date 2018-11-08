using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;

namespace tMax14.Account
{
    public partial class HesapPlanXF : DevExpress.XtraEditors.XtraForm
    {
        public HesapPlanXF()
        {
            InitializeComponent();

            ahpGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colHSPNO.ColumnEdit = Program.MF.HspNoRepositoryItemTextEdit;
            colAKMIDa.ColumnEdit = Program.MF.AKMrepositoryItemLookUpEdit;
            colFRTIDS.ColumnEdit = Program.MF.FRTrepositoryItemCheckedComboBoxEdit;
            colFRTID.ColumnEdit = Program.MF.frtRepositoryItemSearchLookUpEdit;

            //Program.MF.GridControlSettings(ahpGridControl);


        }

        private void HesapPlanXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountDataSet.AHPX' table. You can move, or remove it, as needed.
            this.aHPXTableAdapter.Fill(this.accountDataSet.AHPX);
            this.adatTableAdapter.Fill(this.accountDataSet.ADAT);
            this.ahpaTableAdapter.Fill(this.accountDataSet.AHPA);
            this.ahpTableAdapter.Fill(this.accountDataSet.AHP);
            //this.ahpBindingSource.DataSource = Program.MF.mainDataSet.AHP;
        }

        private void aHPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        public void Save()
        {
            try
            {
                this.Validate();
                this.ahpBindingSource.EndEdit();
                this.ahpTableAdapter.Update(accountDataSet.AHP);
                this.ahpaTableAdapter.Update(accountDataSet.AHPA);
                //Program.MF.ahpTableAdapter.Update(Program.MF.mainDataSet.AHP);

            }
            catch (Exception ex)
            {
                accountDataSet.AHP.RejectChanges();
                XtraMessageBox.Show(ex.Message, "Save");
            }
        }

        private void hesapHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = ahpGridView;

            AccountRpr.AvdHstXF frm = new AccountRpr.AvdHstXF();
            frm.HspNo = view.GetFocusedRowCellDisplayText(colHSPNO);
            frm.FRTid = 0;
            frm.info = string.Format("{0} • {1}", view.GetFocusedRowCellDisplayText(colHSPNO), view.GetFocusedRowCellDisplayText(colHSPAD));
            frm.Show();

            
            //string HspNo = view.GetFocusedRowCellValue(colHSPNO).ToString();
            //FisDetayHistoryXF frm = new FisDetayHistoryXF();
            //frm.iQry = string.Format("HspNo = '{0}'", view.GetFocusedRowCellValue(colHSPNO));
            //frm.info = view.GetFocusedRowCellValue(colHSPAD).ToString() + "  " + view.GetFocusedRowCellValue(colHSPNO).ToString();
            //!!!frm.Show();

            /*
            FisDetayHistoryXF frm = new FisDetayHistoryXF();
            frm.iQry = string.Format("HspNo = '{0}'", view.GetFocusedRowCellValue(colHSPNO));
            //frm.info = view.GetFocusedRowCellValue(colHSPAD).ToString() + "  " + view.GetFocusedRowCellDisplayText(colHSPNOS);
            //frm.Show();

            frm.Dock = DockStyle.Fill;
            var dd = frm.Size.Height;
            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
            panel.Text = view.GetFocusedRowCellDisplayText(colHSPAD) + "  " + view.GetFocusedRowCellDisplayText(colHSPNO);
            panel.FloatSize = new Size(frm.Size.Width, frm.Size.Height);
            panel.Controls.Add(frm);
            var ddd = dockManager.Panels.Count;
            if (dockManager.Panels.Count > 1)      // Ilki kendisi
            {
                dockManager.Panels[0].Show();
                panel.DockAsTab(dockManager.Panels[0], 0);
                dockManager.RootPanels[0].ActiveChildIndex = 0;
            }
            */
        }

        private void ahpGridControl_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ahpGridControl.ShowPrintPreview();

            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = ahpGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "HESAP PLANI", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", "" });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();

        }

        private void dockManager_ClosingPanel(object sender, DevExpress.XtraBars.Docking.DockPanelCancelEventArgs e)
        {
            e.Panel.Dispose();
        }

        private void muavinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = ahpGridView;
            //string HspNo = view.GetFocusedRowCellValue(colHSPNO).ToString();
            //FisDetayHistoryXF frm = new FisDetayHistoryXF();
            //frm.iQry = string.Format("HspNo = '{0}'", view.GetFocusedRowCellValue(colHSPNO));
            //frm.info = view.GetFocusedRowCellValue(colHSPAD).ToString() + "  " + view.GetFocusedRowCellValue(colHSPNO).ToString();
            //!!!frm.Show();


            Muavin frm = new Muavin();
            frm.HspNo = (string)view.GetFocusedRowCellValue(colHSPNO);

            frm.Dock = DockStyle.Fill;
            var dd = frm.Size.Height;
            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
            panel.Text = view.GetFocusedRowCellDisplayText(colHSPAD) + "  " + view.GetFocusedRowCellDisplayText(colHSPNO);
            panel.FloatSize = new Size(frm.Size.Width, frm.Size.Height);
            panel.Controls.Add(frm);
            /*
            var ddd = dockManager.Panels.Count;
            if (dockManager.Panels.Count > 1)      // Ilki kendisi
            {
                dockManager.Panels[0].Show();
                panel.DockAsTab(dockManager.Panels[0], 0);
                dockManager.RootPanels[0].ActiveChildIndex = 0;
            }*/
        }

        private void hesapBakiyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = ahpGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            string hspNo = view.GetFocusedRowCellValue(colHSPNO).ToString();
            AccHspNoBkyXF frm = new AccHspNoBkyXF(hspNo, 0);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var view = ahpGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            string hspNo = view.GetFocusedRowCellValue(colHSPNO).ToString();

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
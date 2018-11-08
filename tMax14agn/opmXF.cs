using DevExpress.XtraBars.Docking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tMax14agn
{
    public partial class opmXF : DevExpress.XtraEditors.XtraForm
    {
        public opmXF()
        {
            InitializeComponent();
        }

        private void opmXF_Load(object sender, EventArgs e)
        {
            try
            {
                this.oPMTableAdapter.Fill(this.dataSet.OPM, Program.agn, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void houseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ophXF frm = new ophXF();
            //frm.opmID = opmGridView.GetFocusedRowCellValue(colOPMID);
            //Program.MF.tabbedView.AddDocument(frm);
            //frm.Show(Program.MF);
            //Program.MF.addForm(frm);
            //Program.MF.newHouse();

            ophXF frm = new ophXF();
            frm.opmID = opmGridView.GetFocusedRowCellValue(colOPMID);
            //frm.MdiParent = Program.MF;
            Program.MF.tabbedView.AddDocument(frm);
            //frm.Show();
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            DockPanel dp = dockManager.AddPanel(DockingStyle.Float);
            ophXF frm = new ophXF();
            dp.Controls.Add(frm);
            //DockPanel dp = new DockPanel();
            //dockManager1.AddPanel(DockingStyle.Bottom, dp);
            dp.DockAsTab(dockPanel1);
            //dockPanel1.DockAsTab(dp);
            */
            docXF frm = new docXF();
            frm.iQry = string.Format("RefTBL = 'OPM' and RefID = {0}", opmGridView.GetFocusedRowCellValue(colOPMID));
            frm.Dock = DockStyle.Fill;
            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
            panel.Text = string.Format("A/M{0}", opmGridView.GetFocusedRowCellValue(colOPMID));
            panel.FloatSize = new Size(frm.Size.Width, frm.Size.Height);
            panel.Controls.Add(frm);
            if (dockManager.Panels.Count > 1)
            {
                panel.DockAsTab(dockManager.Panels[0], 0);
                dockManager.Panels[0].Show();
                dockManager.RootPanels[0].ActiveChildIndex = 0;
            }
        }

        private void aMETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opmaXF frm = new opmaXF();
            frm.opmID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            frm.aStu = opmGridView.GetFocusedRowCellValue(colASTU).ToString();
            frm.opmRow = (DataSet.OPMRow)opmGridView.GetFocusedDataRow();
            frm.Dock = DockStyle.Fill;
            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
            panel.Text = string.Format("AMETA/M{0} : {1}", opmGridView.GetFocusedRowCellValue(colOPMID), opmGridView.GetFocusedRowCellDisplayText(colASTU));
            panel.FloatSize = new Size(frm.Size.Width, frm.Size.Height);
            panel.Controls.Add(frm);
            if (dockManager.Panels.Count > 1)
            {
                panel.DockAsTab(dockManager.Panels[0], 0);
                dockManager.Panels[0].Show();
                dockManager.RootPanels[0].ActiveChildIndex = 0;
            }
        }

        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opmOppXF frm = new opmOppXF();
            frm.opID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            frm.Dock = DockStyle.Fill;
            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
            panel.Text = string.Format("P/M{0}", opmGridView.GetFocusedRowCellValue(colOPMID));
            panel.FloatSize = new Size(frm.Size.Width, frm.Size.Height);
            panel.Controls.Add(frm);
            if (dockManager.Panels.Count > 1)
            {
                panel.DockAsTab(dockManager.Panels[0], 0);
                dockManager.Panels[0].Show();
                dockManager.RootPanels[0].ActiveChildIndex = 0;
            }
        }

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opmUpdXF frm = new opmUpdXF();
            int opmID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            frm.opmID = opmID;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.oPMTableAdapter.ClearBeforeFill = false;
                int nor = this.oPMTableAdapter.Fill(this.dataSet.OPM, Program.agn, string.Format("OPMID = {0}", opmID));
            }
        }

        private void dockManager_ClosedPanel(object sender, DockPanelEventArgs e)
        {
            dockManager.RemovePanel(e.Panel);
        }
    }
}

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
    public partial class ophXF : DevExpress.XtraEditors.XtraForm
    {
        public object opmID = 0;

        public ophXF()
        {
            InitializeComponent();
        }

        private void ophXF_Load(object sender, EventArgs e)
        {
            try
            {
                if (opmID != null && (int)opmID > 0)
                {
                    Text = string.Format("H/M{0}", opmID);
                    this.oPHTableAdapter.Fill(this.dataSet.OPH, Program.agn, string.Format("OPMid = {0}", opmID));
                }
                else
                {
                    this.oPHTableAdapter.Fill(this.dataSet.OPH, Program.agn, "");
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ophOppXF frm = new ophOppXF();
            frm.opID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            frm.Dock = DockStyle.Fill;
            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
            panel.Text = string.Format("P/H{0}", ophGridView.GetFocusedRowCellValue(colOPHID));
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
            ophUpdXF frm = new ophUpdXF();
            int ophID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            frm.ophID = ophID;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.oPHTableAdapter.ClearBeforeFill = false;
                this.oPHTableAdapter.Fill(this.dataSet.OPH, Program.agn, string.Format("OPHID = {0}", ophID));
            }
        }

        private void dockManager_ClosedPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e)
        {
            dockManager.RemovePanel(e.Panel);
        }
    }
}

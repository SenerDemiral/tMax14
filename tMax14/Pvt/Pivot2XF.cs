using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Pvt
{
    public partial class Pivot2XF : DevExpress.XtraEditors.XtraForm
    {
        public Pivot2XF()
        {
            InitializeComponent();

            printToolStripMenuItem.Enabled = Program.MF.EntryCheck("Pvt.Pivot2XF.Print", true);
        }

        private void Pivot2XF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pvtDataSet.PVT_2' table. You can move, or remove it, as needed.
            this.pVT_2TableAdapter.Fill(this.pvtDataSet.PVT_2);
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = "Pvt.Pivot2XF";
            frm.origin = pivotGridControl1;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pivotGridControl1.ShowPrintPreview();
        }
    }
}
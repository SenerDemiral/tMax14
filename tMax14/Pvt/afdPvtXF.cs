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
    public partial class afdPvtXF : DevExpress.XtraEditors.XtraForm
    {
        public afdPvtXF()
        {
            InitializeComponent();
        }

        private void afdPvtXF_Load(object sender, EventArgs e)
        {
            this.pVT_AFDTableAdapter.Fill(this.pvtDataSet.PVT_AFD);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pivotGridControl1.ShowPrintPreview();
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = "Pvt.afdPvtXF";
            frm.origin = pivotGridControl1;
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
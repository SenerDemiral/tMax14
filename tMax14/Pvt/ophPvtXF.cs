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
    public partial class ophPvtXF : DevExpress.XtraEditors.XtraForm
    {
        public ophPvtXF()
        {
            InitializeComponent();
        }

        private void ophPvtXF_Load(object sender, EventArgs e)
        {
            int nor = 0;
            Program.MF.startSW();
            nor  = ophPvtTableAdapter.Fill(pvtDataSet.OPH_PVT, "");
            Program.MF.stopSW("House Pivot", nor);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pivotGridControl.ShowPrintPreview();
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = "Pvt.ophPvtXF";
            frm.origin = pivotGridControl;
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
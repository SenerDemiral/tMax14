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
    public partial class opmPvtXF : DevExpress.XtraEditors.XtraForm
    {
        public string iQry = "";

        public opmPvtXF()
        {
            InitializeComponent();

        }

        private void opmPvtXF_Load(object sender, EventArgs e)
        {
            int nor = 0;
            Program.MF.startSW();

            Text = "Master Pivot -> " + iQry;
            this.pvtOpmTableAdapter.Fill(pvtDataSet.PVT_OPM, iQry);

            Program.MF.stopSW("Master Pivot", nor);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pivotGridControl1.ShowPrintPreview();
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = "Pvt.opmPvtXF";
            frm.origin = pivotGridControl1;
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
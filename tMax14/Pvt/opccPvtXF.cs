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
    public partial class opccPvtXF : DevExpress.XtraEditors.XtraForm
    {
        public opccPvtXF()
        {
            InitializeComponent();
        }

        private void opccPvtXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pvtDataSet.OPCC_PVT' table. You can move, or remove it, as needed.
            this.opccPvtTableAdapter.Fill(this.pvtDataSet.OPCC_PVT);

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pivotGridControl1.ShowPrintPreview();
        }
    }
}
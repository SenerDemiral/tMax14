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
    public partial class afbPvtXF : DevExpress.XtraEditors.XtraForm
    {
        public afbPvtXF()
        {
            InitializeComponent();
        }

        private void afbPvt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pvtDataSet.PVT_AFB' table. You can move, or remove it, as needed.
            this.afbTableAdapter.Fill(this.pvtDataSet.PVT_AFB);

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pivotGridControl1.ShowPrintPreview();
        }
    }
}
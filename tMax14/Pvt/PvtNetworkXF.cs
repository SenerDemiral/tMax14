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
    public partial class PvtNetworkXF : DevExpress.XtraEditors.XtraForm
    {
        public PvtNetworkXF()
        {
            InitializeComponent();
        }

        private void PvtNetworkXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pvtDataSet.FRTGRP' table. You can move, or remove it, as needed.
            this.fRTGRPTableAdapter.Fill(this.pvtDataSet.FRTGRP);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.pVT_NETWORKTableAdapter.Fill(this.pvtDataSet.PVT_NETWORK, FrtGrpCheckedComboBoxEdit.EditValue.ToString(), dateEdit1.DateTime);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pivotGridControl1.ShowPrintPreview();
        }
    }
}
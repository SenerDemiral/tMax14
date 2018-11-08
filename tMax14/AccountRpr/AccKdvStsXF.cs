using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.AccountRpr
{
    public partial class AccKdvStsXF : DevExpress.XtraEditors.XtraForm
    {
        public AccKdvStsXF()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int nor = 0;
            Program.MF.startSW();
            nor = this.aCC_KDV_STSTableAdapter.Fill(this.accountRprDataSet.ACC_KDV_STS, (DateTime?)dateEdit1.EditValue, (DateTime?)dateEdit2.EditValue);
            Program.MF.stopSW("AccKdvStş", nor);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accKdvStsGridControl.ShowPrintPreview();
        }
    }
}
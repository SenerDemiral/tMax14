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
    public partial class AccAhpxPvtXF : DevExpress.XtraEditors.XtraForm
    {
        public AccAhpxPvtXF()
        {
            InitializeComponent();
        }

        private void fillSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.aCC_AHPX_PVTTableAdapter.Fill(this.accountRprDataSet.ACC_AHPX_PVT, dateEdit1.DateTime);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pivotGridControl1.ShowPrintPreview();
        }
    }
}
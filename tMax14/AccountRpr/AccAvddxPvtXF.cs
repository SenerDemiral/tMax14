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
    public partial class AccAvddxPvtXF : DevExpress.XtraEditors.XtraForm
    {
        public AccAvddxPvtXF()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int nor = 0;
                Program.MF.startSW();
                if (ATDcheckEdit.Checked)
                    nor = this.aCC_AVDDX_PVTTableAdapter.Fill(this.accountRprDataSet.ACC_AVDDX_PVT, dateEdit1.DateTime, dateEdit2.DateTime, "ATD");
                else
                    nor = this.aCC_AVDDX_PVTTableAdapter.Fill(this.accountRprDataSet.ACC_AVDDX_PVT, dateEdit1.DateTime, dateEdit2.DateTime, "");

                Program.MF.stopSW("Fiş Harcama Merkezleri", nor);
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
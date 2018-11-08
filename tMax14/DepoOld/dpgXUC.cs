using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.DepoOld
{
    public partial class dpgXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public dpgXUC()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.depoDPGselTableAdapter.Fill(this.depoOldDataSet.DepoDPGsel, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(lM_TSToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void depoDPGselGridControl_Click(object sender, EventArgs e)
        {

        }

        private void yeniGirisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dpgInsForm frm = new dpgInsForm();
            frm.ShowDialog();
        }
    }
}

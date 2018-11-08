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
    public partial class dpcXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public dpcXUC()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.depoDPCselTableAdapter.Fill(this.depoOldDataSet.DepoDPCsel, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(lM_TSToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tMax14agn
{
    public partial class opmOppXF : DevExpress.XtraEditors.XtraUserControl
    {
        public int opID;

        public opmOppXF()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void opmOppXF_Load(object sender, EventArgs e)
        {
            try
            {
                this.opmOppTableAdapter.Fill(this.dataSet.OPM_OPP, opID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

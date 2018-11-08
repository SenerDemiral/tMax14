using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14cln
{
    public partial class mainXF : DevExpress.XtraEditors.XtraForm
    {
        public mainXF()
        {
            InitializeComponent();

            this.Text = string.Format("tMax14 Client #{0} {1}", Program.cln, Program.clnAd);

        }

        private void ophSimpleButton_Click(object sender, EventArgs e)
        {
            ophXF frm = new ophXF();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
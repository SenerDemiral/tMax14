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

namespace tMax14.Account
{
    public partial class FisDetayHareketXF : DevExpress.XtraEditors.XtraForm
    {
        public int avdID = 0;

        public FisDetayHareketXF()
        {
            InitializeComponent();
        }

        private void FisDetayHareketXF_Load(object sender, EventArgs e)
        {
            this.avdHrktTableAdapter.Fill(this.accountDataSet.AVD_HRKT, avdID);
        }
    }
}
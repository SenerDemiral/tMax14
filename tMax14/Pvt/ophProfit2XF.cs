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
    public partial class ophProfit2XF : DevExpress.XtraEditors.XtraForm
    {
        public ophProfit2XF()
        {
            InitializeComponent();
        }

        private void ophProfit2XF_Load(object sender, EventArgs e)
        {
            int nor = 0;
            Program.MF.startSW();
            nor = this.oPH_PROFITTableAdapter.Fill(this.pvtDataSet.OPH_PROFIT, "T");
            Program.MF.stopSW("House Profit Trace", nor);
        }
    }
}
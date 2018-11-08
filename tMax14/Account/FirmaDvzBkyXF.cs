using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Account
{
    public partial class FirmaDvzBkyXF : DevExpress.XtraEditors.XtraForm
    {
        public FirmaDvzBkyXF()
        {
            InitializeComponent();
        }

        private void FirmaDvzBkyXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountDataSet.ACC_FRT_DVZ_BKY' table. You can move, or remove it, as needed.
            this.aCC_FRT_DVZ_BKYTableAdapter.Fill(this.accountDataSet.ACC_FRT_DVZ_BKY);

        }
    }
}
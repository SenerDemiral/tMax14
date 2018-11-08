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
    public partial class AccAfbKlnHspXF : DevExpress.XtraEditors.XtraForm
    {
        public int frtID = 0;
        public AccAfbKlnHspXF()
        {
            InitializeComponent();
        }

        private void AccAfbKlnHspXF_Load(object sender, EventArgs e)
        {
            this.accAfbKlnHspTableAdapter.Fill(this.accountRprDataSet.ACC_AFBKLN_HSP, frtID);
        }
    }
}
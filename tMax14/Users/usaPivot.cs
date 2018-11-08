using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Users
{
    public partial class usaPivot : DevExpress.XtraEditors.XtraForm
    {
        public usaPivot()
        {
            InitializeComponent();
        }

        private void usaPivot_Load(object sender, EventArgs e)
        {
            this.usaPivotTableAdapter.Fill(this.usersDataSet.USA_PIVOT);
            usaPivotGridControl.BestFit();
        }
    }
}
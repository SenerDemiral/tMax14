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
    public partial class usiPivot : DevExpress.XtraEditors.XtraForm
    {
        public usiPivot()
        {
            InitializeComponent();
        }

        private void usiPivot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.USI_PIVOT' table. You can move, or remove it, as needed.
            this.usiPivotTableAdapter.Fill(this.usersDataSet.USI_PIVOT);
            usiPivotGridControl.BestFit();
        }
    }
}
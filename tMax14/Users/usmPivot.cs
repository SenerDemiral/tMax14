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
    public partial class usmPivot : DevExpress.XtraEditors.XtraForm
    {
        public usmPivot()
        {
            InitializeComponent();
        }

        private void usmPivot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.USM_PIVOT' table. You can move, or remove it, as needed.
            this.usmPivotTableAdapter.Fill(this.usersDataSet.USM_PIVOT);
            usmPivotGridControl.BestFit();
        }
    }
}
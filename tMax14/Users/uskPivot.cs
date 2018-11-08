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
    public partial class uskPivot : DevExpress.XtraEditors.XtraForm
    {
        public uskPivot()
        {
            InitializeComponent();
        }

        private void uskPivot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.USK_PIVOT' table. You can move, or remove it, as needed.
            this.uskPivotTableAdapter.Fill(this.usersDataSet.USK_PIVOT);
            uskPivotGridControl.BestFit();
        }
    }
}
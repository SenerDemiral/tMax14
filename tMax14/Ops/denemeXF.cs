using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Ops
{
    public partial class denemeXF : DevExpress.XtraEditors.XtraForm
    {
        public denemeXF()
        {
            InitializeComponent();
        }

        private void denemeXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'opsDataSet.OPM' table. You can move, or remove it, as needed.
            this.oPMTableAdapter.Fill(this.opsDataSet.OPM);

        }
    }
}
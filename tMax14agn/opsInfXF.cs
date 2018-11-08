using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14agn
{
    public partial class opsInfXF : DevExpress.XtraEditors.XtraForm
    {
        string HM;
        int OPID;

        public opsInfXF()
        {
            InitializeComponent();
        }

        private void sendSimpleButton_Click(object sender, EventArgs e)
        {
            queriesTableAdapter.WAN_AGN_OPS_INF(Program.agn, HM, OPID, msjMemoEdit.Text);
        }

        private void opsInfXF_Load(object sender, EventArgs e)
        {
            opsTextEdit.Text = string.Format("{0}#{1}", HM, OPID);
            Close();
        }
    }
}
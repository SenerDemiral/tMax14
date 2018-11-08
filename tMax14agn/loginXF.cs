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
    public partial class loginXF : DevExpress.XtraEditors.XtraForm
    {
        public loginXF()
        {
            InitializeComponent();
        }

        private void loginSimpleButton_Click(object sender, EventArgs e)
        {
            Program.agn = Convert.ToInt32(agnIDtextEdit.Text);
            Program.agnAd = queriesTableAdapter.WAN_AGN_LOGIN(Program.agn, pwdTextEdit.Text).ToString();
            if (Program.agnAd == "")
                XtraMessageBox.Show("Incorrect agentID/password");
            else
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }
    }
}
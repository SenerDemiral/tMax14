using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14cln
{
    public partial class loginXF : DevExpress.XtraEditors.XtraForm
    {
        public loginXF()
        {
            InitializeComponent();
        }

        private void loginSimpleButton_Click(object sender, EventArgs e)
        {
            Program.cln = Convert.ToInt32(idTextEdit.Text);
            Program.clnAd = queriesTableAdapter.WAN_LOGIN(Program.cln, pwdTextEdit.Text).ToString();
            if (Program.clnAd == "")
                XtraMessageBox.Show("Incorrect agentID/password");
            else
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }
    }
}
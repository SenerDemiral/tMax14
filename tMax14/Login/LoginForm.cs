using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Login
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OKsimpleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pwdTextEdit.Text))
            {
                this.ActiveControl = pwdTextEdit;
                return;
            }
            int USTid;
            if (Int32.TryParse(utIdTextEdit.Text, out USTid))
                Program.USTid = USTid;

            string Ad = (string)loginQueriesTableAdapter.LOGIN(USTid, pwdTextEdit.Text);
            if (Ad == "")
            {
                XtraMessageBox.Show("Hatalı Id/Password.!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                pwdTextEdit.Text = "";
                this.ActiveControl = pwdTextEdit;
                return;
            }
            Program.USTid = USTid;
            string[] AdUsr = Ad.Split(new char[] { '/' },  StringSplitOptions.RemoveEmptyEntries);
            Program.USTad = AdUsr[0];
            Program.USR = AdUsr[1];
            if (AdUsr.Length > 2)
                Program.USReMail = AdUsr[2];
            Program.USRtag = "<" + Program.USR + ">";
            //Program.MF.userBarStaticItem.Caption = Program.USTad + " #" + Program.USTid.ToString() + "/" + Program.USR;
            Program.MF.userToolStripStatusLabel.Text = Program.USTad + " #" + Program.USTid.ToString() + "/" + Program.USR;
            uspSelUsrTableAdapter.Fill(Program.MF.mainDataSet.USP_SEL_USR, USTid);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
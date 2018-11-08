using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Login
{
    public partial class PwdChangeForm : DevExpress.XtraEditors.XtraForm
    {
        public PwdChangeForm()
        {
            InitializeComponent();
        }

        private void OKsimpleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(utIdTextEdit.Text) ||
                string.IsNullOrEmpty(oldPwdTextEdit.Text) ||
                string.IsNullOrEmpty(newPwdTextEdit.Text) ||
                string.IsNullOrEmpty(newPwd2TextEdit.Text))
            {
                XtraMessageBox.Show("Gerekli Alanları doldurun.");
                return;
            }

            if (newPwdTextEdit.Text != newPwd2TextEdit.Text)
            {
                XtraMessageBox.Show("Yeni Password ler uyuşmuyor.");
                return;
            }

            int uid = 0;
            Int32.TryParse(utIdTextEdit.Text, out uid);
            
            string sonuc = (string)loginQueriesTableAdapter.LOGIN_PWDCHANGE(uid, oldPwdTextEdit.Text, newPwdTextEdit.Text);
            if (sonuc == "F")
            {
                XtraMessageBox.Show("Password değiştirilemedi.");
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
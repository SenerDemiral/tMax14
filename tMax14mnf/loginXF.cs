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

namespace tMax14mnf
{
    public partial class loginXF : DevExpress.XtraEditors.XtraForm
    {
        public loginXF()
        {
            InitializeComponent();
        }

        private void loginSimpleButton_Click(object sender, EventArgs e)
        {
            Program.mnf = Convert.ToInt32(IDtextEdit.Text);
            Program.mnfAd = queriesTableAdapter.WAN_LOGIN(Program.mnf, pwdTextEdit.Text).ToString();
            if (Program.mnfAd == "")
                XtraMessageBox.Show("Incorrect ID/password");
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
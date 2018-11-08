using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Genel
{
    public partial class xgtNewForm : DevExpress.XtraEditors.XtraForm
    {
        //public int idLength = 5;
        public string ID, VAL;

        public xgtNewForm(int idLength)
        {
            InitializeComponent();

            IDtextEdit.Properties.MaxLength = idLength;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDtextEdit.Text) || string.IsNullOrEmpty(VALtextEdit.Text))
                XtraMessageBox.Show("Alan boş olamaz");
            else
            {
                ID = IDtextEdit.Text;
                VAL = VALtextEdit.Text;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
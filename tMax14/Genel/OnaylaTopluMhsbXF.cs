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

namespace tMax14.Genel
{
    public partial class OnaylaTopluMhsbXF : DevExpress.XtraEditors.XtraForm
    {
        public OnaylaTopluMhsbXF()
        {
            InitializeComponent();
        }

        private void onaylaSetSimpleButton_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Eminmisiniz?", "Toplu Onay Fiş", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                return;
            genelQueriesTableAdapter.ONAYLA_TOPLU("AVB", dateEdit1.DateTime, Program.USR);
            XtraMessageBox.Show("Onaylandı.", "Toplu Onay Fiş");

        }
    }
}
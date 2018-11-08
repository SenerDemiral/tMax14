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

namespace tMax14.Users
{
    public partial class ustXF : DevExpress.XtraEditors.XtraForm
    {
        public ustXF()
        {
            InitializeComponent();
        }

        private void ustXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.UST' table. You can move, or remove it, as needed.
            this.ustTableAdapter.Fill(this.usersDataSet.UST);

        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int refId = (int)gridView1.GetFocusedRowCellValue(colUSTID);

            Jurnal.jrnXF frm = new Jurnal.jrnXF();
            frm.RefTbl = "UST";
            frm.RefID = refId;
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
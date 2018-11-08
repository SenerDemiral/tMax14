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

namespace tMax14.Ops
{
    public partial class obsdEkleXF : DevExpress.XtraEditors.XtraForm
    {

        public int obsID = 0;

        public obsdEkleXF()
        {
            InitializeComponent();

            GrsTrhDateEdit.DateTime = DateTime.Today;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            opsQueriesTableAdapter.OBSD_EKLE(obsID, GrsTrhDateEdit.DateTime, (int)BasStkNoSpinEdit.Value, (int)AdetSpinEdit.Value);
        }
    }
}
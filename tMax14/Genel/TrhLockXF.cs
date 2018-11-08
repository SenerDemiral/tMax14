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
    public partial class TrhLockXF : DevExpress.XtraEditors.XtraForm
    {
        public TrhLockXF()
        {
            InitializeComponent();
        }

        private void tRH_LOCKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRH_LOCKBindingSource.EndEdit();
            this.tRH_LOCKTableAdapter.Update(this.genelDataSet.TRH_LOCK);

        }

        private void TrhLockXF_Load(object sender, EventArgs e)
        {
            this.tRH_LOCKTableAdapter.Fill(this.genelDataSet.TRH_LOCK, Program.USR);

        }
    }
}
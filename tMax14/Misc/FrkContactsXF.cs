using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Misc
{
    public partial class FrkContactsXF : DevExpress.XtraEditors.XtraForm
    {
        public int frkID = 0;
        public FrkContactsXF()
        {
            InitializeComponent();
        }

        private void FrkContactsXF_Load(object sender, EventArgs e)
        {
            this.fRK_CONTACTSTableAdapter.Fill(this.miscDataSet.FRK_CONTACTS, frkID);
        }
    }
}
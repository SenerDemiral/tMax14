using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.AccountAk
{
    public partial class AktXF : DevExpress.XtraEditors.XtraForm
    {
        public int akID = 0;
        public string akAD = "";

        public AktXF()
        {
            InitializeComponent();
        }

        private void AktXF_Load(object sender, EventArgs e)
        {
            Text = string.Format("[{0}] {1} Masraf/Gelir Tutarları [AKT]", akID, akAD);
            this.aKTTableAdapter.Fill(this.accountAkDataSet.AKT, akID);
        }

    }
}
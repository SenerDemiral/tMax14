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
    public partial class AkdXF : DevExpress.XtraEditors.XtraForm
    {
        public int akID = 0;
        public string akAD = "";

        public AkdXF()
        {
            InitializeComponent();
        }

        private void AkdXF_Load(object sender, EventArgs e)
        {
            Text = string.Format("[{0}] {1} Dağıtım Çarpanları [AKD]", akID, akAD);
            this.aKDTableAdapter.Fill(this.accountAkDataSet.AKD, akID);
        }
    }
}
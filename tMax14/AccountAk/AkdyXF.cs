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
    public partial class AkdyXF : DevExpress.XtraEditors.XtraForm
    {
        public AkdyXF()
        {
            InitializeComponent();
        }

        private void aKDYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aKDYBindingSource.EndEdit();
            this.aKDYTableAdapter.Update(this.accountAkDataSet.AKDY);

        }

        private void AkdyXF_Load(object sender, EventArgs e)
        {
            Text = "Dağıtım Yüzdeleri [AKDY]";
            this.aKDYTableAdapter.Fill(this.accountAkDataSet.AKDY);

        }
    }
}
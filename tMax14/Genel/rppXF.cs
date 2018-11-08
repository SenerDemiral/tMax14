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
    public partial class rppXF : DevExpress.XtraEditors.XtraForm
    {
        public rppXF()
        {
            InitializeComponent();
        }

        private void rPPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rPPBindingSource.EndEdit();
            this.rPPTableAdapter.Update(this.genelDataSet.RPP);

        }

        private void rppXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'genelDataSet.RPP' table. You can move, or remove it, as needed.
            this.rPPTableAdapter.Fill(this.genelDataSet.RPP);

        }
    }
}
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
    public partial class opstXF : DevExpress.XtraEditors.XtraForm
    {
        public opstXF()
        {
            InitializeComponent();
        }

        private void oPSTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oPSTBindingSource.EndEdit();
            this.oPSTTableAdapter.Update(this.genelDataSet.OPST);

        }

        private void opstXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'genelDataSet.OPST' table. You can move, or remove it, as needed.
            this.oPSTTableAdapter.Fill(this.genelDataSet.OPST);

        }
    }
}
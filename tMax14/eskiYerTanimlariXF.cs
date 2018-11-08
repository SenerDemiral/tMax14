using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14
{
    public partial class eskiYerTanimlariXF : DevExpress.XtraEditors.XtraForm
    {
        public eskiYerTanimlariXF()
        {
            InitializeComponent();
        }

        private void yTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ytBindingSource.EndEdit();
            this.ytTableAdapter.Update(this.mainDataSet.YT);

        }

        private void eskiYerTanimlariXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.YT' table. You can move, or remove it, as needed.
            this.ytTableAdapter.Fill(this.mainDataSet.YT);

        }
    }
}
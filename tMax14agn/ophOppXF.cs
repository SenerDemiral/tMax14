using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tMax14agn
{
    public partial class ophOppXF : DevExpress.XtraEditors.XtraUserControl
    {
        public int opID;

        public ophOppXF()
        {
            InitializeComponent();
        }

        private void OphOppXF_Load(object sender, EventArgs e)
        {
            try
            {
                this.ophOppTableAdapter.Fill(this.dataSet.OPH_OPP, opID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

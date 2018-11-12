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

namespace tMax14agn
{
    public partial class afbDisXF : DevExpress.XtraEditors.XtraForm
    {
        public afbDisXF()
        {
            InitializeComponent();
        }

        private void afbDisXF_Load(object sender, EventArgs e)
        {
            try
            {
                this.wAN_AGN_RPR_FATURATableAdapter.Fill(this.dataSet.WAN_AGN_RPR_FATURA, Program.agn);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
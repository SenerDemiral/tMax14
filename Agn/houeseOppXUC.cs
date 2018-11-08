using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Agn
{
    public partial class houeseOppXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public int ophID = 0;
        
        public houeseOppXUC()
        {
            InitializeComponent();
        }

        private void houeseOppXUC_Load(object sender, EventArgs e)
        {
            this.wAN_AGN_OPH_OPP_SELTableAdapter.Fill(this.agnDataSet.WAN_AGN_OPH_OPP_SEL, ophID);
        }

    }
}

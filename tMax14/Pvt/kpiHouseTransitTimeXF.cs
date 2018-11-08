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

namespace tMax14.Pvt
{
    public partial class kpiHouseTransitTimeXF : DevExpress.XtraEditors.XtraForm
    {
        public kpiHouseTransitTimeXF()
        {
            InitializeComponent();
        }

        private void kpiHouseTransitTimeXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pvtDataSet.PVT_KPI_H_TRANSITTIMES' table. You can move, or remove it, as needed.
            this.pVT_KPI_H_TRANSITTIMESTableAdapter.Fill(this.pvtDataSet.PVT_KPI_H_TRANSITTIMES);

        }
    }
}
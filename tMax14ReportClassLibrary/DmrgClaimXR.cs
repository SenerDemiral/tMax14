using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class DmrgClaimXR : DevExpress.XtraReports.UI.XtraReport
    {
        public DmrgClaimXR(int opmID, string usr)
        {
            InitializeComponent();

            rprDmrgClaimTableAdapter.Fill(reportDataSet.RPR_DMRG_CLAIM, opmID, usr);

        }

    }
}

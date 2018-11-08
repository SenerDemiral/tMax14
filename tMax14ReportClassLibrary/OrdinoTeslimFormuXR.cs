using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class OrdinoTeslimFormuXR : DevExpress.XtraReports.UI.XtraReport
    {
        public OrdinoTeslimFormuXR(int hID)
        {
            InitializeComponent();

            rprOTFTableAdapter.Fill(reportDataSet.RPR_OTF, hID);
        }

    }
}

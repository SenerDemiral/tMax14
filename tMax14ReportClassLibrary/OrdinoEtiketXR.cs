using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class OrdinoEtiketXR : DevExpress.XtraReports.UI.XtraReport
    {
        public OrdinoEtiketXR(int hID)
        {
            InitializeComponent();

            rprOrdinoEtiketTableAdapter.Fill(reportDataSet1.RPR_ORDINO_ETIKET, hID);
        }

    }
}

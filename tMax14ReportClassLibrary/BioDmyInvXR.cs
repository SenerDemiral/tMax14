using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class BioDmyInvXR : DevExpress.XtraReports.UI.XtraReport
    {
        public BioDmyInvXR(int mID)
        {
            InitializeComponent();

            rpR_BIO_DMY_INVTableAdapter1.Fill(reportDataSet1.RPR_BIO_DMY_INV, mID);
        }

    }
}

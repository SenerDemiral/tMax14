using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14.Firma
{
    public partial class AnlasmaOdemeXR : DevExpress.XtraReports.UI.XtraReport
    {
        public AnlasmaOdemeXR(string iQry)
        {
            InitializeComponent();

            rpR_ANLASMA_ODEMETableAdapter1.Fill(firmaDataSet1.RPR_ANLASMA_ODEME, iQry);
        }

    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14.Firma
{
    public partial class OnayliTedarikcilerXR : DevExpress.XtraReports.UI.XtraReport
    {
        public OnayliTedarikcilerXR(string iQry)
        {
            InitializeComponent();

            rpR_ONAYLI_TEDARIKCILERTableAdapter1.Fill(firmaDataSet1.RPR_ONAYLI_TEDARIKCILER, iQry);
        }

    }
}

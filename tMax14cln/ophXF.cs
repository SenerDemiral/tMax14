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

namespace tMax14cln
{
    public partial class ophXF : DevExpress.XtraEditors.XtraForm
    {
        public ophXF()
        {
            InitializeComponent();
        }

        private void ophXF_Load(object sender, EventArgs e)
        {
            ophTableAdapter.Fill(this.dataSet.OPH, 31967, "");

            opmTableAdapter.ClearBeforeFill = false;
            oppTableAdapter.ClearBeforeFill = false;
            foreach (DataSet.OPHRow row in dataSet.OPH.Rows)
            {
                if (!row.IsOPMIDNull())
                    this.opmTableAdapter.Fill(dataSet.OPM, row.OPMID);
                this.oppTableAdapter.Fill(dataSet.OPP, row.OPHID);
            }
        }

    }
}
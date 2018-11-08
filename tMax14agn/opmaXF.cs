using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tMax14agn
{
    public partial class opmaXF : DevExpress.XtraEditors.XtraUserControl
    {
        public int opmID;
        public string aStu = "1";
        public DataSet.OPMRow opmRow;

        public opmaXF()
        {
            InitializeComponent();
        }

        private void opmaXF_Load(object sender, EventArgs e)
        {
            if (aStu != "2")
                ametaGridView.OptionsBehavior.Editable = false;

            try
            {
                if (aStu != "1")    // TO Pending'i bitirdiyse
                {
                    this.aMETATableAdapter.Fill(this.dataSet.AMETA, opmID);
                    this.aMETA_PROFIT_CALCTableAdapter.Fill(this.dataSet.AMETA_PROFIT_CALC, opmID);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ametaGridView.OptionsBehavior.Editable)
                this.aMETATableAdapter.Update(this.dataSet.AMETA);

        }

        private void setAgnPendingFinsihedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ametaGridView.OptionsBehavior.Editable)
                this.aMETATableAdapter.Update(this.dataSet.AMETA);

            queriesTableAdapter.WAN_AGN_AMETA_ENDED(opmID);
            opmRow.ASTU = "3";
        }
    }
}

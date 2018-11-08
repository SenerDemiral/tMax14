using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Ops
{
    public partial class ophChargeCreateXF : DevExpress.XtraEditors.XtraForm
    {
        public int mID;

        public ophChargeCreateXF()
        {
            InitializeComponent();

            ophCCGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colNEWFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAHTID.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;

        }

        private void ophChargeCreateXF_Load(object sender, EventArgs e)
        {
            this.ophCCTableAdapter.Fill(this.opsDataSet.OPH_CHARGE_CREATE, mID);
            ophCCGridView.BestFitColumns();
        }
    }
}
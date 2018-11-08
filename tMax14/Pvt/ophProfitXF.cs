using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Pvt
{
    public partial class ophProfitXF : DevExpress.XtraEditors.XtraForm
    {
        public int mID = 189403;

        public ophProfitXF()
        {
            InitializeComponent();

            oPH_PROFIT_AFDSGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            colAHTIDd.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colFRTIDd.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colTURd.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            //colBRMd.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;
        }

        private void ophProfitXF_Load(object sender, EventArgs e)
        {
            Text = string.Format("OphProfitDeneme mID:{0}", mID);
            this.oPH_PROFIT_TOPTableAdapter.Fill(this.pvtDataSet.OPH_PROFIT_TOP, mID);
            this.oPH_PROFIT_AFDSTableAdapter.Fill(this.pvtDataSet.OPH_PROFIT_AFDS, mID);
        }
    }
}
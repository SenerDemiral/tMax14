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
    public partial class opcChargesXF : DevExpress.XtraEditors.XtraForm
    {
        public int opcID;

        public opcChargesXF()
        {
            InitializeComponent();

            oPC_CHARGESGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            colAHTID.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colTUR.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
        }

        private void opcChargesXF_Load(object sender, EventArgs e)
        {
            this.oPC_CHARGESTableAdapter.Fill(this.pvtDataSet.OPC_CHARGES, opcID);
        }
    }
}
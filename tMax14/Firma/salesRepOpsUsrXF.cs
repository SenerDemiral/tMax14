using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Firma
{
    public partial class salesRepOpsUsrXF : DevExpress.XtraEditors.XtraForm
    {
        string layoutName = "Firma.salesRepOpsUsr";

        public salesRepOpsUsrXF()
        {
            InitializeComponent();

            salesRepOpsUsrGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            colSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            //colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colACCID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

            colMSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colMCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colSREPID.ColumnEdit = Program.MF.ustRepositoryItemLookUpEdit;
            colSUSRID.ColumnEdit = Program.MF.ustRepositoryItemLookUpEdit;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int nor = 0;
            Program.MF.startSW();
            nor = this.salesRepOpsTableAdapter.Fill(this.firmaDataSet.SALESREP_OPS, (DateTime?)dateEdit1.EditValue, (DateTime?)dateEdit2.EditValue, Program.USTid);
            Program.MF.stopSW("SalesRep Ops", nor);
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = salesRepOpsUsrGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void salesRepOpsUsrXF_Load(object sender, EventArgs e)
        {
            Text = "salesRepOpsUsrXF, " + Program.USTad;
            Program.MF.XGLrestore(layoutName, 0, salesRepOpsUsrGridView);
        }

        private void salesRepOpsUsrXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.salesRepOpsBindingSource.EndEdit();
            this.salesRepOpsTableAdapter.Update(this.firmaDataSet.SALESREP_OPS);
        }
    }
}
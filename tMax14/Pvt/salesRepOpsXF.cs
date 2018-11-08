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
    public partial class salesRepOpsXF : DevExpress.XtraEditors.XtraForm
    {
        string layoutName = "Pvt.salesRepOps";
        
        public salesRepOpsXF()
        {
            InitializeComponent();

            salesRepOpsGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            colSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            //colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colACCID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

            colMSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colMCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colSREPID.ColumnEdit = Program.MF.ustRepositoryItemLookUpEdit;
            colSUSRID.ColumnEdit = Program.MF.ustRepositoryItemLookUpEdit;
            //colTUS.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;

        }

        private void salesRepOpsXF_Load(object sender, EventArgs e)
        {
            Program.MF.XGLrestore(layoutName, 0, salesRepOpsGridView);


        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesRepOpsGridControl.ShowPrintPreview();
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = salesRepOpsGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int nor = 0;
            Program.MF.startSW();
            nor = this.salesRepOpsTableAdapter.Fill(this.pvtDataSet.SALESREP_OPS, (DateTime?)dateEdit1.EditValue, (DateTime?)dateEdit2.EditValue, 0);
            Program.MF.stopSW("SalesRep Ops", nor);
        }

        private void salesRepOpsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.salesRepOpsTableAdapter.Update(this.pvtDataSet.SALESREP_OPS);
        }

        private void salesRepOpsXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.salesRepOpsBindingSource.EndEdit();
            this.salesRepOpsTableAdapter.Update(this.pvtDataSet.SALESREP_OPS);
            
        }
    }
}
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
    public partial class frs2tstXF : DevExpress.XtraEditors.XtraForm
    {
        public FirmaDataSet.FRSRow frsRow;
        public int FrsID = 0;

        public frs2tstXF()
        {
            InitializeComponent();

            vGridControl1.ExternalRepository = Program.MF.mainPersistentRepository;

            rowTOB.Properties.RowEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            rowROT.Properties.RowEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            rowMOT.Properties.RowEdit = Program.MF.MOTrepositoryItemLookUpEdit;

            rowORG.Properties.RowEdit = Program.MF.locRepositoryItemLookUpEdit;
            rowDST.Properties.RowEdit = Program.MF.locRepositoryItemLookUpEdit;
            rowCUSLOCID.Properties.RowEdit = Program.MF.locRepositoryItemLookUpEdit;
            rowADR.Properties.RowEdit = Program.MF.TFrepositoryItemCheckEdit;
            rowTYP.Properties.RowEdit = Program.MF.TklfTypRepositoryItemImageComboBox;
            rowTOP.Properties.RowEdit = Program.MF.TOPrepositoryItemLookUpEdit;
            rowDTM.Properties.RowEdit = Program.MF.DTMrepositoryItemLookUpEdit;
            rowCRRID.Properties.RowEdit = Program.MF.FRTrepositoryItemLookUpEdit;
        }

        private void frs2tstXF_Load(object sender, EventArgs e)
        {
            this.fRS2TST_SELTableAdapter.Fill(this.firmaDataSet.FRS2TST_SEL,  FrsID, Program.USR);
        }

        private void ınsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fRS2TST_SELBindingSource.EndEdit();
            var aa = this.fRS2TST_SELTableAdapter.Update(this.firmaDataSet.FRS2TST_SEL);
            
            this.Close();
        }

    }
}
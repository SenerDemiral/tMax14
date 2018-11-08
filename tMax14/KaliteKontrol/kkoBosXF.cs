using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.KaliteKontrol
{
    public partial class kkoBosXF : DevExpress.XtraEditors.XtraForm
    {
        public int kkoID = 0;
        
        public kkoBosXF()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kKO_BOS_SELBindingSource.EndEdit();
            this.kKO_BOS_SELTableAdapter.Update(this.kkDataSet.KKO_BOS_SEL);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void kkoBosXF_Load(object sender, EventArgs e)
        {
            int nor = this.kKO_BOS_SELTableAdapter.Fill(this.kkDataSet.KKO_BOS_SEL, kkoID, Program.USR);
            if (nor == 0)
                simpleButton1.Enabled = false;

            vGridControl1.ExternalRepository = Program.MF.mainPersistentRepository;
            rowDRM.Properties.RowEdit = Program.MF.KkoDrmRepositoryItemLookUpEdit;
            rowBLDSKL.Properties.RowEdit = Program.MF.KkoBldSklRepositoryItemLookUpEdit;
            rowTUR.Properties.RowEdit = Program.MF.KkoTurRepositoryItemLookUpEdit;
            rowONC.Properties.RowEdit = Program.MF.KkoOncRepositoryItemLookUpEdit;
            rowINFO.Properties.RowEdit = Program.MF.MEMOrepositoryItemMemoEdit;
            rowTOUSR.Properties.RowEdit = Program.MF.USRrepositoryItemLookUpEdit;
            rowTAGS.Properties.RowEdit = Program.MF.TAGselKKOrepositoryItemCheckedComboBoxEdit;
            rowILGUSRS.Properties.RowEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;

        }
    }
}
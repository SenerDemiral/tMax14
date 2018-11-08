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
    public partial class frcmXF : DevExpress.XtraEditors.XtraForm
    {
        public frcmXF()
        {
            InitializeComponent();

            frcmGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;  GECICI
            colCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;  GECICI
        }

        private void fRCMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fRCMBindingSource.EndEdit();
            this.fRCMTableAdapter.Update(this.firmaDataSet.FRCM);

        }

        private void frcmXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmaDataSet.FRCM' table. You can move, or remove it, as needed.
            this.fRCMTableAdapter.Fill(this.firmaDataSet.FRCM);

        }
    }
}
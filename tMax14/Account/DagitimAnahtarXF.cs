using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Account
{
    public partial class DagitimAnahtarXF : DevExpress.XtraEditors.XtraForm
    {
        public DagitimAnahtarXF()
        {
            InitializeComponent();

            adatGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colAKMID.ColumnEdit = Program.MF.AKMrepositoryItemLookUpEdit;

        }

        private void aDABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adatBindingSource.EndEdit();
            this.adaBindingSource.EndEdit();
            this.adatTableAdapter.Update(this.accountDataSet.ADAT);
            this.adaTableAdapter.Update(this.accountDataSet.ADA);

        }

        private void DagitimAnahtarXF_Load(object sender, EventArgs e)
        {
            this.adatTableAdapter.Fill(this.accountDataSet.ADAT);
            this.adaTableAdapter.Fill(this.accountDataSet.ADA);

        }

        private void adatGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
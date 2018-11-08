using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.AccountRpr
{
    public partial class FrmMtbktHstXF : DevExpress.XtraEditors.XtraForm
    {
        public FrmMtbktHstXF()
        {
            InitializeComponent();

            fmhGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colSTU.ColumnEdit = Program.MF.FMHstuRepositoryItemLookUpEdit;

            Program.MF.GridControlSettings(fmhGridControl);
        }

        public void Save()
        {
            this.Validate();
            this.fMHBindingSource.EndEdit();
            this.fMHTableAdapter.Update(this.accountRprDataSet.FMH);
        }

        private void FrmMtbktHstXF_Load(object sender, EventArgs e)
        {
            this.fMHTableAdapter.Fill(this.accountRprDataSet.FMH, "", Program.USR);
        }
    }
}
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
    public partial class kkfBosXF : DevExpress.XtraEditors.XtraForm
    {
        public int kkfID = 0;

        public kkfBosXF()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kKF_BOS_SELBindingSource.EndEdit();
            this.kKF_BOS_SELTableAdapter.Update(this.kkDataSet.KKF_BOS_SEL);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void kkfBosXF_Load(object sender, EventArgs e)
        {
            int nor = this.kKF_BOS_SELTableAdapter.Fill(this.kkDataSet.KKF_BOS_SEL, kkfID, Program.USR);
            if (nor == 0)
                simpleButton1.Enabled = false;

            vGridControl1.ExternalRepository = Program.MF.mainPersistentRepository;
            rowYTKUSR.Properties.RowEdit = Program.MF.USRrepositoryItemLookUpEdit; ;
            rowTUR.Properties.RowEdit = Program.MF.KkfTurRepositoryItemLookUpEdit;
        }
    }
}
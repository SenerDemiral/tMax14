using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.DepoOld
{
    public partial class dpgInsForm : DevExpress.XtraEditors.XtraForm
    {
        public dpgInsForm()
        {
            InitializeComponent();

            GirTrhDateEdit.DateTime = DateTime.Now;
        }

        private void dpgInsForm_Load(object sender, EventArgs e)
        {
            this.depoMBgirecekTableAdapter.Fill(this.depoOldDataSet.DepoMBgirecek);
            this.depoHBgirecekTableAdapter.Fill(this.depoOldDataSet.DepoHBgirecek);
        }

        private void OKsimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void HMradioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HMradioGroup.SelectedIndex == 0)
            {
                HBgridLookUpEdit.Enabled = true;
                MBgridLookUpEdit.Enabled = false;
            }
            else
            {
                HBgridLookUpEdit.Enabled = false;
                MBgridLookUpEdit.Enabled = true;
            }
        }
    }
}
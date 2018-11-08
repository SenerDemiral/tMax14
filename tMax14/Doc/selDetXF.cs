using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Doc
{
    public partial class selDetXF : DevExpress.XtraEditors.XtraForm
    {
        public string DET = "";

        public selDetXF()
        {
            InitializeComponent();

            lookUpEdit1.Properties.DataSource = Program.MF.DOCdetRepositoryItemLookUpEdit.DataSource;
        }

        private void OKsimpleButton_Click(object sender, EventArgs e)
        {
            DET = lookUpEdit1.EditValue.ToString();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            OKsimpleButton.Enabled = false;
            if (lookUpEdit1.EditValue != null)
                OKsimpleButton.Enabled = true;
        }
    }
}
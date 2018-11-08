using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Account
{
    public partial class AfdFytUpdXF : DevExpress.XtraEditors.XtraForm
    {
        public int AfdID = 0;
        public decimal oFyt = 0;
        public string oDvz = "";

        public AfdFytUpdXF()
        {
            InitializeComponent();

            //nDvzLookUpEdit.Da
        }

        private void AfdFytUpdXF_Load(object sender, EventArgs e)
        {
            oDvzTextEdit.EditValue = oDvz;
            nDvzLookUpEdit.EditValue = oDvz;
            oFytTextEdit.EditValue = $"{oFyt:n}";
            // TODO: This line of code loads data into the 'mainDataSet.DVT' table. You can move, or remove it, as needed.
            this.dVTTableAdapter.Fill(this.mainDataSet.DVT);

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                accountQueriesTableAdapter.AFD_UPD_DFYT(AfdID, (decimal)nFytEdit.EditValue, nDvzLookUpEdit.EditValue.ToString());
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
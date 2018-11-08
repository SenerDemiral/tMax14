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

namespace tMax14.Genel
{
    public partial class KpiSetXF : DevExpress.XtraEditors.XtraForm
    {
        public string Tbl;
        public int TblPK = 0;
        public string KPI = "";
        public string KpiUsr = "";
        public object KpiTrh;

        public KpiSetXF()
        {
            InitializeComponent();
        }

        private void kpiSetSimpleButton_Click(object sender, EventArgs e)
        {
            if (kpiLookUpEdit.EditValue != null)
            {
                DateTime? trh = null;
                if (dateEdit1.EditValue != null)
                    trh = dateEdit1.DateTime;
                string msj = genelQueriesTableAdapter.KPI_SET(Tbl, TblPK, kpiLookUpEdit.EditValue.ToString(), usrCheckedComboBoxEdit.EditValue.ToString(), trh, Program.USR).ToString();
                if (msj != "")
                    XtraMessageBox.Show(msj, "KPI Set");
                else
                    this.Close();
            }
            else
                XtraMessageBox.Show("KPI seçin!", "KPI Set");

        }

        private void KpiSetXF_Load(object sender, EventArgs e)
        {
            this.uSTTableAdapter.Fill(this.genelDataSet.UST);
            this.xGTTableAdapter.FillByGRP(this.genelDataSet.XGT, "KPI");

            kpiLookUpEdit.EditValue = KPI;
            //usrCheckedComboBoxEdit.EditValue = KpiUsr;

            if (KpiTrh != DBNull.Value)
                dateEdit1.EditValue = KpiTrh;   // Bos ise DB current atar

        }

        private void xGTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.xGTBindingSource.EndEdit();
            this.xGTTableAdapter.Update(this.genelDataSet.XGT);

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
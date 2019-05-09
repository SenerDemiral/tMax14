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
    public partial class FaturaKurFarkiInsXF : DevExpress.XtraEditors.XtraForm
    {
        public int refAfbID = 0;
        public decimal topKurFarkiTL = 0;
        public int newAfbID = 0;

        public FaturaKurFarkiInsXF()
        {
            InitializeComponent();
        }

        private void FaturaKurFarkiInsXF_Load(object sender, EventArgs e)
        {
            refAfbIDtextEdit.EditValue = $"{refAfbID}";
            ftrTrhDateEdit.DateTime = DateTime.Today;
            usrTextEdit.EditValue = Program.USR;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                topKurFarkiTL = Convert.ToDecimal(topKurFarkiTLtextEdit.EditValue);
                newAfbID = (int)accountQueriesTableAdapter.AFB_INS_KURFARKI(refAfbID, topKurFarkiTL, ftrTrhDateEdit.DateTime, ftrNoTextEdit.EditValue.ToString(), Program.USR);
                XtraMessageBox.Show($"AfbID: {newAfbID}", "KurFarkıFaturası", MessageBoxButtons.OK);
                Clipboard.SetDataObject($"{newAfbID}");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "KurFarkıFaturası Ekle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
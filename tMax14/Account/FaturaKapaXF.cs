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
    public partial class FaturaKapaXF : DevExpress.XtraEditors.XtraForm
    {
        private int afbID;
        private string tur;

        public FaturaKapaXF(int afbID, string tur)
        {
            InitializeComponent();

            this.afbID = afbID;
            this.tur = tur;

            if (tur.Substring(1, 1) != "D")
                dknNoTextEdit.Enabled = false;

            if (tur == "BS" || tur == "BA")
            {
                string ftrNo = accountQueriesTableAdapter.AFBNO_GET(afbID).ToString();
                ftrNoTextEdit.Text = ftrNo;
                ftrTrhDateEdit.DateTime = DateTime.Today;
            }
        }

        private void kapaSimpleButton_Click(object sender, EventArgs e)
        {
            string hata = "";
            if (string.IsNullOrWhiteSpace(ftrNoTextEdit.Text))
                hata = "FaturaNo girin";
            else if (dknNoTextEdit.Enabled && string.IsNullOrWhiteSpace(ftrNoTextEdit.Text))
                hata = "DekontNo girin";
            else if (ftrTrhDateEdit.EditValue == null)
                hata = "Belge tarihi girin";

            if (hata != "")
            {
                XtraMessageBox.Show(hata);
                return;
            }

            try
            {
                accountQueriesTableAdapter.AFB_KAPA_NOTRH(afbID, ftrNoTextEdit.Text, ftrTrhDateEdit.DateTime, dknNoTextEdit.Text, Program.USR);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Fatura Kapat");
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
        }

    }
}
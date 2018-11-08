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
using DevExpress.XtraPrinting;
using System.Globalization;

namespace tMax14.Account
{
    public partial class CbdXF : DevExpress.XtraEditors.XtraForm
    {
        public int cbbID = 0;
        public string drm = "K";
        public DateTime trh;

        public CbdXF()
        {
            InitializeComponent();

            cBDGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colCORRHSPNO.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;

           // Program.MF.GridControlSettings(this.cBDGridControl);  // Insert, Delete yapamaz

        }

        private void cBDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
            this.cBDTableAdapter.Fill(this.accountDataSet.CBD, cbbID);
        }

        private void CbdXF_Load(object sender, EventArgs e)
        {
            Text = string.Format("{0:dd.MM.yy} Banka Extre Detayları", trh);
            if (drm == "K")
            {
                gridView1.OptionsBehavior.ReadOnly = true;
                Text += " [ReadOnly]";
                downloadToolStripMenuItem.Enabled = false;
                muhasebeFisiOlusturToolStripMenuItem.Enabled = false;
            }

            this.cBDTableAdapter.Fill(this.accountDataSet.CBD, cbbID);
        }

        private void Save()
        {
            this.Validate();
            this.cBDBindingSource.EndEdit();
            this.cBDTableAdapter.Update(this.accountDataSet.CBD);

        }

        private void CbdXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            GetGarantiExtre();

        }

        private void muhasebeFisiOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string msj = accountQueriesTableAdapter.CB2AV_TEK(cbbID, Program.USR).ToString();
                XtraMessageBox.Show(msj, "Fiş oluştur");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Fiş oluştur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetGarantiExtre()
        {
            var client = new ServiceReference1.FirmAccountActivitySoapClient();

            ServiceReference1.SecureToken secureToken = new ServiceReference1.SecureToken();
            secureToken.UserId = "TRANSY";
            secureToken.Encoded = "avSn2vxfWsgfIV3m/SsMew==";   // MD5 of "90.158.110.194135219fa:25x9z15fgdf:"  Transorient
            //secureToken.Encoded = "c3taowaNCWnimN6Q9STyZQ==";     // MD5 of "217.160.13.102135219fa:25x9z15fgdf:"  SenerWebServer
            secureToken.Password = "";
            secureToken.CreateTimestamp = "";

            /*
            GARANTİ BANKASI - TEKSTİLKENT ŞUBESİ ŞUBE KODU: 1120
            TL  : 6202627 - IBAN NO:TR490006200112000006202627
            EUR : 9094374 - IBAN NO:TR230006200112000009094374
            GBP : 9011124 - IBAN NO:TR890006200112000009011124
            USD : 9011125 - IBAN NO:TR620006200112000009011125
            */
            Dictionary<string, string> IBANs = new Dictionary<string, string>();
            IBANs["TR490006200112000006202627"] = "TL";
            IBANs["TR230006200112000009094374"] = "EUR";
            IBANs["TR890006200112000009011124"] = "GBP";
            IBANs["TR620006200112000009011125"] = "USD";

            ServiceReference1.FirmAccountActivity firmAccountActivity = new ServiceReference1.FirmAccountActivity();
            
            firmAccountActivity.FirmCode = "187528";
            // Herhangi biriyle sorgulandiginda Bankanin kayitli tum hesaplari geliyor
            firmAccountActivity.IBAN = "TR490006200112000006202627";

            DateTime sD, eD;
            sD = trh;
            eD = sD.AddDays(1);
            firmAccountActivity.StartDate = string.Format("{0:yyyy-MM-dd}-00.00.00.000001", sD);
            firmAccountActivity.EndDate = string.Format("{0:yyyy-MM-dd}-00.00.00.000000", eD);
            //firmAccountActivity.EndDate = "2018-02-10-00.00.00.000000";

            firmAccountActivity.securetoken = secureToken;

            long cbdID = 0;
            decimal tut = 0;
            ServiceReference1.FirmAccountActivityResponse res;
            
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

            try
            {
                res = client.FirmAccountActivity(firmAccountActivity);

                XtraMessageBox.Show(res.MessageText, "Download GarantiBank Extre");
                
                if (res != null && res.ReturnVal == "00")
                {
                    foreach (var fa in res.FirmAccounts)
                    {
                        if (fa.AccountActivities != null)
                        {
                            foreach (var aa in fa.AccountActivities)
                            {
                                if (IBANs.ContainsKey(fa.IBAN))
                                {
                                    cbdID = long.Parse(aa.TransactionReferenceId.Replace("-", "").Replace(".", "").Remove(0, 2));
                                    
                                    //tut = decimal.Parse(aa.Amount.Replace(",", ""));
                                    tut = decimal.Parse(aa.Amount, culture);
                                    
                                    accountQueriesTableAdapter.CBD_ADD(cbbID, cbdID, fa.IBAN, aa.CorrIBAN.Trim(), fa.CurrencyCode, tut, aa.Explanation.Replace(" ", "[]").Replace("][", "").Replace("[]", " "));
                                }
                            }
                        }
                    }
                    accountQueriesTableAdapter.CBB_AKTAR_END(cbbID, Program.USR);
                    this.cBDTableAdapter.Fill(this.accountDataSet.CBD, cbbID);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Download GarantiBank Extre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = cBDGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format(Text);
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Mail;
using System.Threading.Tasks;

namespace tMax14.Misc
{
    public partial class KampanyaXF : DevExpress.XtraEditors.XtraForm
    {
        public KampanyaXF()
        {
            InitializeComponent();

            mktGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTIDS.ColumnEdit = Program.MF.FRTrepositoryItemCheckedComboBoxEdit;
        }

        private void mKTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mKTBindingSource.EndEdit();
            this.mKTTableAdapter.Update(this.miscDataSet.MKT);

        }

        private void KampanyaXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'miscDataSet.MKT' table. You can move, or remove it, as needed.
            this.mKTTableAdapter.Fill(this.miscDataSet.MKT);

        }

        private void mktGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            int PK = (int)miscQueriesTableAdapter.docGET_PK("MKT");
            mktGridView.SetRowCellValue(e.RowHandle, colMKTID, PK);
            mktGridView.SetRowCellValue(e.RowHandle, colEXD, DateTime.Today);
        }

        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Task.Factory.StartNew(() =>
            {
                MainDataSet.SMTPRow SMTP = Program.MF.SMTP();
                try
                {
                    StringBuilder tos = new StringBuilder();
                    string sUsr = string.Empty;
                    frtEmailsTableAdapter.Fill(miscDataSet.FRT_EMAILS, mktGridView.GetFocusedRowCellValue(colFRTIDS).ToString());

                    foreach (MiscDataSet.FRT_EMAILSRow row in miscDataSet.FRT_EMAILS.Rows)
                    {
                        MailMessage mail = new MailMessage();
                        mail.To.Add(row.EMAIL); // Virgulle ayrilmis bircok adres olabilir
                        mail.Subject = mktGridView.GetFocusedRowCellValue(colKONU).ToString(); // string.Format("{From:{1}, Jurnal:{2}, Konu:{0}", jrnMdfylayoutView.GetFocusedRowCellValue(colSUBJECTm).ToString(), Program.USTad, 1); //jrnMdfylayoutView.GetFocusedRowCellValue(colJRNIDm));
                        mail.Body = mktGridView.GetFocusedRowCellValue(colBODY).ToString();
                        mail.IsBodyHtml = true;

                        mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);
                        SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
                        smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
                        smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
                        smtp.Port = SMTP.PORT;

                        smtp.Send(mail);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error sending eMail.\n" + ex.ToString());
                }
            });

        }
    }
}
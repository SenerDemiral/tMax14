using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Net.Mail;
using DevExpress.XtraPrinting;

namespace tMax14.AccountRpr
{
    public partial class MtbktXF : DevExpress.XtraEditors.XtraForm
    {
        enum sendStatu {Gonderilecek, Gonderildi, Gonderilemez, Gonderilemedi};
        private AccountRprDataSet.RPT_GETRow rptRow;
        private MainDataSet.SMTPRow SMTP;

        public MtbktXF()
        {
            InitializeComponent();

            dateEdit1.DateTime = DateTime.Today;
        }

        private void MtbktXF_Load(object sender, EventArgs e)
        {
            SMTP = Program.MF.SMTP();
        }

        private void fillSimpleButton_Click(object sender, EventArgs e)
        {
            int rptID = 103;    // Mtbkt
            if (turRadioGroup.SelectedIndex == 1)
                rptID = 104;    // Mtbkt+BaBs

            this.rptGetTableAdapter.Fill(this.accountRprDataSet.RPT_GET, rptID);  // Mtbkt / Mtbkt+BaBs
            rptRow = this.accountRprDataSet.RPT_GET[0];

            eMailSubjectTextEdit.Text = rptRow.EMAILSUBJECT;
            eMailBodyRichEditControl.Document.HtmlText = rptRow.EMAILBODY;

            this.accMtbktListTableAdapter.Fill(this.accountRprDataSet.ACC_MTBKT_LIST, dateEdit1.DateTime, dateEdit2.DateTime);

            foreach (AccountRprDataSet.ACC_MTBKT_LISTRow row in accountRprDataSet.ACC_MTBKT_LIST.Rows)
            {
                if (row.IsEMAILSNull() || string.IsNullOrEmpty(row.EMAILS))
                {
                    row.SendMail = false;
                    row.SendStatu = (int)sendStatu.Gonderilemez;
                    row.SendMsj = "Mail adresi yok.";
                }
                else
                {
                    row.SendMail = true;
                    row.SendStatu = 0;
                }
            }

        }

        private void printTekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int frtID = (int)mtbktGridView.GetFocusedRowCellValue(colFRTID);

            if (turRadioGroup.SelectedIndex == 0)
            {
                tMax14ReportClassLibrary.MtbktXR rpr = new tMax14ReportClassLibrary.MtbktXR(frtID, dateEdit1.DateTime);
                using (ReportPrintTool printTool = new ReportPrintTool(rpr))
                {
                    printTool.ShowPreviewDialog();
                }
            }
            else
            {
                tMax14ReportClassLibrary.Mtbkt_BaBsXR rpr = new tMax14ReportClassLibrary.Mtbkt_BaBsXR(frtID, dateEdit1.DateTime);
                using (ReportPrintTool printTool = new ReportPrintTool(rpr))
                {
                    printTool.ShowPreviewDialog();
                }
            }
        }

        private void eMailTekToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
            smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
            smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
            smtp.Port = SMTP.PORT;

            int sri = mtbktGridView.GetFocusedDataSourceRowIndex();
            AccountRprDataSet.ACC_MTBKT_LISTRow row = (AccountRprDataSet.ACC_MTBKT_LISTRow)accountRprDataSet.ACC_MTBKT_LIST.Rows[sri];

            if (row.SendStatu == (int)sendStatu.Gonderilemez)
                XtraMessageBox.Show("Gonderilemez", "Send eMail");
            else
                send2Firma(smtp, row);

            smtp.Dispose();
        }

        private void eMailHepsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Seçilmiş Firmalara toplu eMail atılacaktır.  Eminmisiniz?", "Toplu eMail", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                return;

            //SmtpClient smtp = new SmtpClient(tMaxOrtak.OrtakProps.SmtpClientHost);
            //smtp.Credentials = new System.Net.NetworkCredential(tMaxOrtak.OrtakProps.SmtpCredentialsUserName, tMaxOrtak.OrtakProps.SmtpCredentialsUserPassword);
            //smtp.EnableSsl = tMaxOrtak.OrtakProps.SmtpEnableSsl;
            //smtp.Port = tMaxOrtak.OrtakProps.SmtpPort;

            //mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);
            SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
            smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
            smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
            smtp.Port = SMTP.PORT;


            foreach (AccountRprDataSet.ACC_MTBKT_LISTRow row in accountRprDataSet.ACC_MTBKT_LIST.Rows)
            {
                if (row.SendMail)
                {
                    send2Firma(smtp, row);
                    accountRprQueriesTableAdapter.FMH_IOU(row.FRTID, dateEdit1.DateTime, "M", "Mail", Program.USR);
                }
            }

            smtp.Dispose();
        }

        private void send2Firma(SmtpClient smtp, AccountRprDataSet.ACC_MTBKT_LISTRow row)
        {
            string eMails = row.EMAILS;

            if (!string.IsNullOrEmpty(Program.USReMail))
                eMails += ", " + Program.USReMail;  // Aktif usera da mail gonder Control

            string fn = "Mutabakat.pdf";

            MemoryStream ms = new MemoryStream();

            if (turRadioGroup.SelectedIndex == 0)
            {
                tMax14ReportClassLibrary.MtbktXR rpr = new tMax14ReportClassLibrary.MtbktXR(row.FRTID, dateEdit1.DateTime);
                rpr.ExportToPdf(ms);
            }
            else
            {
                tMax14ReportClassLibrary.Mtbkt_BaBsXR rpr = new tMax14ReportClassLibrary.Mtbkt_BaBsXR(row.FRTID, dateEdit1.DateTime);
                rpr.ExportToPdf(ms);
            }

            ms.Seek(0, System.IO.SeekOrigin.Begin);
            var attachment = new Attachment(ms, fn);

            try
            {
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);
                mail.To.Add(eMails);
                mail.Subject = eMailSubjectTextEdit.Text;
                mail.Body = eMailBodyRichEditControl.Document.HtmlText;
                mail.IsBodyHtml = true;
                mail.Attachments.Add(attachment);
               
                smtp.Send(mail);
                
                mail.Dispose();
                
                row.SendMail = false;
                row.SendStatu = (int)sendStatu.Gonderildi;
                accountRprQueriesTableAdapter.RPH_INS(rptRow.KOD, "FRT", row.FRTID, Program.USR, "F", null);
            }
            catch (Exception ex)
            {
                row.SendStatu = (int)sendStatu.Gonderilemedi;
                row.SendMsj = ex.Message;
            }
            
            
        }
        
        private void mtbktGridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colSendMail)
            {
                if ((bool)e.Value)
                {
                    if (mtbktGridView.GetRowCellDisplayText(e.RowHandle, colEMAILS) == "")
                        mtbktGridView.SetRowCellValue(e.RowHandle, colSendStatu, (int)sendStatu.Gonderilemez);
                    else
                    {
                        mtbktGridView.SetRowCellValue(e.RowHandle, colSendStatu, (int)sendStatu.Gonderilecek);
                        mtbktGridView.SetRowCellValue(e.RowHandle, colSendMsj, "");
                    }
                }
                else
                    mtbktGridView.SetRowCellValue(e.RowHandle, colSendStatu, null);
            }
        }

        private void mtbktGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (mtbktGridView.GetRowCellValue(e.RowHandle, colSendStatu) != DBNull.Value && (int)mtbktGridView.GetRowCellValue(e.RowHandle, colSendStatu) == 2)
                mtbktGridView.SetRowCellValue(e.RowHandle, colSendMail, false);
        }

        private void mtbktGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if ((int)mtbktGridView.GetFocusedRowCellValue(colSendStatu) == (int)sendStatu.Gonderilemez)
                e.Cancel = true;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = mtbktGridControl;
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Mutabakat {0:dd.MM.yyyy}", dateEdit1.DateTime);
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void firmaMutabakatHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMtbktHstXF frm = new FrmMtbktHstXF();
            frm.Show();
        }


    }
}
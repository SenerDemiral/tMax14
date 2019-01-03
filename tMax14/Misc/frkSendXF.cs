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
using System.IO;
using DevExpress.XtraPrinting;

namespace tMax14.Misc
{
    public partial class frkSendXF : DevExpress.XtraEditors.XtraForm
    {
        public int frkID;
        public string info;
        enum sendStatu { Gonderilecek, Gonderildi, Gonderilemez, Gonderilemedi };
        private MiscDataSet.RPT_GETRow rptRow;
        private MailMessage mail = new MailMessage();

        public frkSendXF()
        {
            InitializeComponent();
        }

        private void frkSendXF_Load(object sender, EventArgs e)
        {
            Text = string.Format("{0}  [frkSend]", info);
            
            this.rptGetTableAdapter.Fill(this.miscDataSet.RPT_GET, 120);  // Kampanya
            rptRow = this.miscDataSet.RPT_GET[0];

            eMailSubjectTextEdit.Text = rptRow.EMAILSUBJECT;
            //eMailBodyRichEditControl.Document.HtmlText = rptRow.EMAILBODY;

            this.frkKmpnyTableAdapter.Fill(this.miscDataSet.FRK_KMPNY, frkID);

            foreach (MiscDataSet.FRK_KMPNYRow row in miscDataSet.FRK_KMPNY.Rows)
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

        private void mailGonderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Seçilmiş Firmalara toplu eMail atılacaktır.  Eminmisiniz?", "Toplu eMail", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                return;

            docSelDetTableAdapter.Fill(this.miscDataSet.DOC_SEL_DET, "FRK", frkID, "FRK");
            int rowCount = miscDataSet.DOC_SEL_DET.Rows.Count;

            if (rowCount == 0)
            {
                XtraMessageBox.Show("FRK Attachemnt bulunamadı", Text);
                return;
            }

            MiscDataSet.DOC_SEL_DETRow drow = (MiscDataSet.DOC_SEL_DETRow)miscDataSet.DOC_SEL_DET.Rows[0];
            byte[] byteArray = drow.BLB;
            string body = System.Text.Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);

            MainDataSet.SMTPRow SMTP = Program.MF.SMTP();

            mail.Subject = eMailSubjectTextEdit.Text;

            // Body Attachment dan gelsin
            mail.Body = body;
            //mail.Body = eMailBodyRichEditControl.Document.HtmlText;
            mail.IsBodyHtml = true;

            mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);
            SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
            smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
            smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
            smtp.Port = SMTP.PORT;

            foreach (MiscDataSet.FRK_KMPNYRow row in miscDataSet.FRK_KMPNY.Rows)
            {
                if (row.SendMail)
                    send2Firma(smtp, row);
            }

            smtp.Dispose();
        }

        private void mailGonderToolStripMenuItem_Click_OLD(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Seçilmiş Firmalara toplu eMail atılacaktır.  Eminmisiniz?", "Toplu eMail", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                return;

            if (!attDocuments("FRK", frkID))
                return;

            MainDataSet.SMTPRow SMTP = Program.MF.SMTP();

            mail.Subject = eMailSubjectTextEdit.Text;

            //mail.Body = eMailBodyRichEditControl.Document.HtmlText;
            mail.IsBodyHtml = true;

            mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);
            SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
            smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
            smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
            smtp.Port = SMTP.PORT;

            foreach (MiscDataSet.FRK_KMPNYRow row in miscDataSet.FRK_KMPNY.Rows)
            {
                if (row.SendMail)
                    send2Firma(smtp, row);
            }

            smtp.Dispose();
        }

        private void send2Firma(SmtpClient smtp, MiscDataSet.FRK_KMPNYRow row)
        {
            string eMails = row.EMAILS;

            //if (!string.IsNullOrEmpty(Program.USReMail))
            //    eMails += ", " + Program.USReMail;  // Aktif usera da mail gonder Control

            try
            {
                mail.To.Clear();
                mail.To.Add(eMails);

                smtp.Send(mail);

                row.SendMail = false;
                row.SendStatu = (int)sendStatu.Gonderildi;
                miscQueriesTableAdapter.RPH_INS(rptRow.KOD, "FRT", row.FRTID, Program.USR, "F", $"FrkID:{frkID}");
            }
            catch (Exception ex)
            {
                row.SendStatu = (int)sendStatu.Gonderilemedi;
                row.SendMsj = ex.Message;
            }
        }

        private bool attDocuments(string refTbl, int refID)
        {
            string disEvrakTur = "FRK";
            this.docSelDetTableAdapter.Fill(this.miscDataSet.DOC_SEL_DET, refTbl, refID, disEvrakTur);
            int rowCount = this.miscDataSet.DOC_SEL_DET.Rows.Count;

            if (rowCount == 0)
            {
                XtraMessageBox.Show("FRK Attachemnt bulunamadı", Text);
                return false;
            }

            foreach (MiscDataSet.DOC_SEL_DETRow row in this.miscDataSet.DOC_SEL_DET.Rows)
            {
                byte[] byteArray = row.BLB; //(byte[])this.reportDataSet.DOC_SEL_DET.Rows[0]["BLB"];
                MemoryStream ms = new MemoryStream(byteArray);
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                if (ms.Length > 0)
                {
                    mail.Attachments.Add(new Attachment(ms, row.AD+row.TYP));
                }
            }
            return true;
        }

        private void frkKmpnyGridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colSendMail)
            {
                if ((bool)e.Value)
                {
                    if (frkKmpnyGridView.GetRowCellDisplayText(e.RowHandle, colEMAILS) == "")
                        frkKmpnyGridView.SetRowCellValue(e.RowHandle, colSendStatu, (int)sendStatu.Gonderilemez);
                    else
                    {
                        frkKmpnyGridView.SetRowCellValue(e.RowHandle, colSendStatu, (int)sendStatu.Gonderilecek);
                        frkKmpnyGridView.SetRowCellValue(e.RowHandle, colSendMsj, "");
                    }
                }
                else
                    frkKmpnyGridView.SetRowCellValue(e.RowHandle, colSendStatu, null);
            }
        }

        private void frkKmpnyGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (frkKmpnyGridView.GetRowCellValue(e.RowHandle, colSendStatu) != DBNull.Value && (int)frkKmpnyGridView.GetRowCellValue(e.RowHandle, colSendStatu) == 2)
                frkKmpnyGridView.SetRowCellValue(e.RowHandle, colSendMail, false);
        }

        private void frkKmpnyGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if ((int)frkKmpnyGridView.GetFocusedRowCellValue(colSendStatu) == (int)sendStatu.Gonderilemez)
                e.Cancel = true;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = frkKmpnyGridControl;
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Kampanya {0}", info);
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
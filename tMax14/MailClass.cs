using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Net.Mail;
using DevExpress.XtraReports.UI;
using System.Threading.Tasks;
using tMax14.Properties;

namespace tMax14
{
//    public class dmy : System.Windows.Forms.Form
//    {
//    }

    public static class MailClass
    {

        static DevExpress.XtraBars.Alerter.AlertControl alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl();
        
        //static dmy d = new dmy();

       
        public static void MailReportAsync(XtraReport xtr, string eMailAdres)
        {
            //Task task1 = new Task(new Action(MailReport));
            //task1.Start();
            alertControl1.Show(null, "Caption", "Text");

           // Task task2 = Task.Factory.StartNew(() => MailReport(xtr, eMailAdres));
            
        }

        public static void MailReportTask(rptInfo rpti, string Caption, XtraReport xr, string eMails, string eMailSubject, string eMailBody, string attTyp = "PDF")
        {
            MainDataSet.SMTPRow SMTP = Program.MF.SMTP();

            alertControl1.FormLoad += alertControl1_FormLoad;
            alertControl1.BeforeFormShow += alertControl1_BeforeFormShow;
            alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.BottomRight;
            alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.MoveHorizontal;
            alertControl1.AutoFormDelay = 10000;
            alertControl1.AutoHeight = true;
            System.Drawing.Bitmap img = Resources.mailForward64;  //Resources.ResourceManager.GetObject("mailForward64"); //Bu da OK

            Task<string>.Factory.StartNew(() =>
            {
                // Background work
                try
                {
                    MemoryStream mem = new MemoryStream();

                    MailMessage mail = new MailMessage();
                    System.Net.Mail.Attachment att;

                    if (attTyp == "PDF")
                    {
                        xr.ExportToPdf(mem);
                        mem.Seek(0, System.IO.SeekOrigin.Begin);
                        att = new System.Net.Mail.Attachment(mem, Caption + ".pdf", "application/pdf");
                        mail.Attachments.Add(att);
                    }
                    else if (attTyp == "RTF")
                    {
                        xr.ExportToRtf(mem);
                        mem.Seek(0, System.IO.SeekOrigin.Begin);
                        att = new System.Net.Mail.Attachment(mem, Caption + ".rtf", "application/rtf");
                        mail.Attachments.Add(att);
                    }
                    // Create a new message and attach the PDF report to it.

                    mail.To.Add(eMails);
                    mail.Subject = eMailSubject; //string.Format("{0}{1} {2}", rpti.refTO, rpti.refID, eMailSubject);
                    mail.Body = eMailBody;
                    mail.IsBodyHtml = true;
                    mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);
                    
                    SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
                    smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
                    smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
                    smtp.Port = SMTP.PORT;

                    smtp.Send(mail);
                    mem.Close();    // Close the memory stream.

                    return "";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }

            }).ContinueWith((t) =>
            {
                // Update UI thread
                //alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.B;

                if (string.IsNullOrEmpty(t.Result))
                {
                    alertControl1.Show(null, Caption, eMails.Replace(",", "\n"), img);
                    Program.MF.reportDone(rpti, false);
                }
                else
                    alertControl1.Show(null, Caption, t.Result, img);
 
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        static void alertControl1_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            e.AlertForm.OpacityLevel = 1;
        }

        static void alertControl1_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            //e.Buttons.PinButton.SetDown(true);    // Effect kayboluyor
        }

        public static void MailReportAsBodyTask(rptInfo rpti, string Caption, XtraReport xr, string eMails, string eMailSubject, string eMailBody)
        {
            MainDataSet.SMTPRow SMTP = Program.MF.SMTP();

            alertControl1.FormLoad += alertControl1_FormLoad;
            alertControl1.BeforeFormShow += alertControl1_BeforeFormShow;
            alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.BottomRight;
            alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.MoveHorizontal;
            alertControl1.AutoFormDelay = 10000;
            alertControl1.AutoHeight = true;
            System.Drawing.Bitmap img = Resources.mailForward64;  //Resources.ResourceManager.GetObject("mailForward64"); //Bu da OK

            Task<string>.Factory.StartNew(() =>
            {
                // Background work
                try
                {
                    MemoryStream mem = new MemoryStream();
                    xr.ExportToHtml(mem);

                    mem.Seek(0, System.IO.SeekOrigin.Begin);
                    var aaa = Encoding.UTF8.GetString(mem.ToArray());

                    //System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(mem, Caption + ".pdf", "application/pdf");

                    MailMessage mail = new MailMessage();
                    mail.To.Add(eMails);
                    mail.Subject = string.Format("{0} {1}{2}", eMailSubject, rpti.refTO, rpti.refID);
                    mail.Body = aaa; // eMailBody;
                    mail.IsBodyHtml = true;
                    mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);

                    SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
                    smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
                    smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
                    smtp.Port = SMTP.PORT;

                    smtp.Send(mail);
                    mem.Close();    // Close the memory stream.

                    return "";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }

            }).ContinueWith((t) =>
            {
                // Update UI thread
                //alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.B;

                if (string.IsNullOrEmpty(t.Result))
                {
                    alertControl1.Show(null, Caption, eMails.Replace(",", "\n"), img);
                    Program.MF.reportDone(rpti, false);
                }
                else
                {
                  
                    alertControl1.Show(null, Caption, t.Result, img);
                }

            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

    }

    public class rptInfo
    {
        public string msg { get; set; }
        public string kod { get; set; }
        public string refTO { get; set; }
        public int refID { get; set; }
        public string usr { get; set; }
        public string rspW { get; set; }
        public string info { get; set; }

        public rptInfo()
        {
            msg = "";
        }

        public void put(string kod, string refTO, int refID, string usr, string rspW, string info)
        {
            this.kod = kod;
            this.refTO = refTO;
            this.refID = refID;
            this.usr = usr;
            this.rspW = rspW;
            this.info = info;
        }
    }
}

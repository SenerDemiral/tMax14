using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Net.Mail;

namespace tMax14ReportClassLibrary
{
    public partial class TopluAlertXF : DevExpress.XtraEditors.XtraForm
    {
        public string USR = "ADMN";
        public string USReMail;
        public int opID = 0;
        public string refTO = "";
        public string HM = "";
        public string ROT = "", MOT = "";
        public int rptID = 0;
        private bool hata = false;
        private ReportDataSet.RPR_TOPLUALERTRow topluAlertRow;

        private ReportDataSet.SMTPRow SMTP;

        //private List<Attachment> attachments;
        //private List<RPH> rph;  // Report History

        public TopluAlertXF()
        {
            InitializeComponent();
        }

        private void TopluAlertXF_Load(object sender, EventArgs e)
        {
            if (HM == "M")
                refTO = "OPM";
            else if (HM == "H")
                refTO = "OPH";

            checkSimpleButton.PerformClick();
        
            ReportDataSetTableAdapters.SMTPTableAdapter smtpTableAdapter = new ReportDataSetTableAdapters.SMTPTableAdapter();
            ReportDataSet.SMTPDataTable SMTPTable = (ReportDataSet.SMTPDataTable)smtpTableAdapter.GetData();
            SMTP = (ReportDataSet.SMTPRow)SMTPTable.Rows[0];
        }

        private void sendMail(string mailTo, string subject, string body)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                MailMessage mail = new MailMessage();

                object obj;
                for (int i = 0; i < attCheckedListBoxControl.CheckedItemsCount; i++)
                {
                    obj = attCheckedListBoxControl.CheckedItems[i];
                    if (obj is RPT)
                        mail.Attachments.Add((obj as RPT).attachment);
                }

                mail.To.Add(mailTo);

                mail.Subject = string.Format("{0}{1} {2}", refTO, opID, subject);
                mail.Body = body;
                mail.IsBodyHtml = true;

                // gMail
                //mail.From = new MailAddress("transorient.tmax@gmail.com", "Transorient tMax Drone");  // gMail
                //SmtpClient smtp = new SmtpClient("smtp.gmail.com");   // gMail
                //smtp.Credentials = new System.Net.NetworkCredential("transorient.tmax", "tMaxTeam");  // gMail
                //smtp.EnableSsl = true;    // gMail
                //smtp.Port = 587;

                mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);
                SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
                smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
                smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
                smtp.Port = SMTP.PORT;

                smtp.Send(mail);
                stuLabelControl.Text = "SendMail: Mail Sent";
                hata = false;
            }
            catch (Exception ex)
            {
                hata = true;
                stuLabelControl.Text = "Hata! " + ex.Message;
                if (ex.InnerException != null)
                    stuLabelControl.Text = string.Format("Hata! {0}\n{1}", ex.Message, ex.InnerException.Message);
            }
            Cursor = Cursors.Default;
        }

        private void attCargoManifest(int mID)
        {
            string fn = "CargoManifest" + mID + ".pdf";
            CargoManifestXR rpr = new CargoManifestXR(mID);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            RPT rpt = new RPT();
            rpt.rptKod = "CM";
            rpt.info = string.Format("M:{0}", mID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attMAWB(int mID)   // MasterAirwayBill
        {
            string fn = "MAWB" + mID + ".pdf";
            MawbXR rpr = new MawbXR(mID, true);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            RPT rpt = new RPT();
            rpt.rptKod = "MAWB";
            rpt.info = string.Format("M:{0}", mID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attHAWB(int hID)
        {
            string fn = "HAWB" + hID + ".pdf";
            HawbXR rpr = new HawbXR(hID, true);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            RPT rpt = new RPT();
            rpt.rptKod = "HAWB";
            rpt.info = string.Format("H:{0}", hID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);
            
            Application.DoEvents();
        }

        private void attHAWBs()      // HAWBs in Master
        {
            string[] hIDs = topluAlertRow.HIDS.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int id;
            foreach (string hID in hIDs)
            {
                id = Convert.ToInt32(hID);
                attHAWB(id);
            }
        }

        private void attShippingAdviceHouse(int hID)
        {
            string fn = "ShippingAdviceHouse" + hID + ".pdf";
            ShippingAdviceHouseXR rpr = new ShippingAdviceHouseXR(hID);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            RPT rpt = new RPT();
            rpt.rptKod = "SAH";
            rpt.info = string.Format("H:{0}", hID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attShippingAdviceMaster(int mID)
        {
            string fn = "ShippingAdviceMaster" + mID + ".pdf";
            ShippingAdviceMasterXR rpr = new ShippingAdviceMasterXR(mID);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            RPT rpt = new RPT();
            rpt.rptKod = "SAM";
            rpt.info = string.Format("M:{0}", mID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);
            
            Application.DoEvents();
        }

        private void attHBL(int hID)
        {
            if (reportQueriesTableAdapter.RPH_CHECK("HBL", "OPH", hID).ToString() == "T")    // House'dan basildiysa
            {
                string fn = "HBL" + hID + ".pdf";
                HblXR rpr = new HblXR(hID, true);
                MemoryStream ms = new MemoryStream();
                rpr.ExportToPdf(ms);
                ms.Seek(0, System.IO.SeekOrigin.Begin);

                RPT rpt = new RPT();
                rpt.rptKod = "HBL";
                rpt.info = string.Format("H:{0}", hID);
                rpt.attachment = new Attachment(ms, fn);
                attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

                Application.DoEvents();
            }
        }

        private void attHBLs()      // HAWBs in Master
        {
            string[] hIDs = topluAlertRow.HIDS.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int id;
            foreach (string hID in hIDs)
            {
                id = Convert.ToInt32(hID);
                //if (reportQueriesTableAdapter.RPH_CHECK("FBL", "OPH", id).ToString() == "T")    // House'dan basildiysa
                    attHBL(id);
            }
        }

        private void attFBL(int hID)
        {
            if (reportQueriesTableAdapter.RPH_CHECK("FBL", "OPH", hID).ToString() == "T")    // House'dan basildiysa
            {
                string fn = "FBL" + hID + ".pdf";
                FblXR rpr = new FblXR(hID, true);
                MemoryStream ms = new MemoryStream();
                rpr.ExportToPdf(ms);
                ms.Seek(0, System.IO.SeekOrigin.Begin);

                RPT rpt = new RPT();
                rpt.rptKod = "FBL";
                rpt.info = string.Format("H:{0}", hID);
                rpt.attachment = new Attachment(ms, fn);
                attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

                Application.DoEvents();
            }
        }

        private void attFBLs()      // HAWBs in Master
        {
            string[] hIDs = topluAlertRow.HIDS.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int id;
            foreach (string hID in hIDs)
            {
                id = Convert.ToInt32(hID);
                //if (reportQueriesTableAdapter.RPH_CHECK("FBL", "OPH", id).ToString() == "T")    // House'dan basildiysa
                attFBL(id);
            }
        }

        private void attFCR(int hID)
        {
            if (reportQueriesTableAdapter.RPH_CHECK("FCR", "OPH", hID).ToString() == "T")    // House'dan basildiysa
            {
                string fn = "FCR" + hID + ".pdf";
                FcrXR rpr = new FcrXR(hID, true);
                MemoryStream ms = new MemoryStream();
                rpr.ExportToPdf(ms);
                ms.Seek(0, System.IO.SeekOrigin.Begin);

                RPT rpt = new RPT();
                rpt.rptKod = "FCR";
                rpt.info = string.Format("H:{0}", hID);
                rpt.attachment = new Attachment(ms, fn);
                attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

                Application.DoEvents();
            }
        }

        private void attFCRs()      // HAWBs in Master
        {
            string[] hIDs = topluAlertRow.HIDS.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int id;
            foreach (string hID in hIDs)
            {
                id = Convert.ToInt32(hID);
                //if (reportQueriesTableAdapter.RPH_CHECK("FCR", "OPH", id).ToString() == "T")    // House'dan basildiysa
                    attFCR(id);
            }
        }

        private void attCikisIhbari(int hID)
        {
            string fn = "CikisIhbar" + hID + ".pdf";
            CikisIhbariXR rpr = new CikisIhbariXR(hID);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            RPT rpt = new RPT();
            rpt.rptKod = "CI";
            rpt.info = string.Format("H:{0}", hID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attVarisIhbari(int hID)
        {
            string fn = "VarisIhbar" + hID + ".pdf";
            VarisIhbarXR rpr = new VarisIhbarXR(hID, 1);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            RPT rpt = new RPT();
            rpt.rptKod = "VI";
            rpt.info = string.Format("H:{0}", hID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attHouseOfMasterDocuments(string disEvrkTur, bool zorunlu)
        {
            string[] hIDs = topluAlertRow.HIDS.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int refID;
            foreach (string hID in hIDs)
            {
                refID = Convert.ToInt32(hID);
                attDocuments("OPH", refID, disEvrkTur, zorunlu);
            }
        }

        private void attDocuments(string refTbl, int refID, string disEvrkTur, bool zorunlu)
        {
            this.docSelDetTableAdapter.Fill(this.reportDataSet.DOC_SEL_DET, refTbl, refID, disEvrkTur);
            int rowCount = this.reportDataSet.DOC_SEL_DET.Rows.Count;
            
            if (rowCount == 0)
            {
                if (zorunlu)
                    hata = true;

                attCheckedListBoxControl.Items.Add(null, string.Format("Attachment {0}: Bulunamadı", disEvrkTur), CheckState.Indeterminate, false);

                return;
            }

            foreach (ReportDataSet.DOC_SEL_DETRow row in this.reportDataSet.DOC_SEL_DET.Rows)
            {
                byte[] byteArray = row.BLB; //(byte[])this.reportDataSet.DOC_SEL_DET.Rows[0]["BLB"];
                MemoryStream ms = new MemoryStream(byteArray);
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                if (ms.Length > 0)
                {
                    string attName = string.Format("{0}{1}{2}-{3}{4}", disEvrkTur, refTbl, refID, row.DOCID, row.TYP);
                    
                    RPT rpt = new RPT();
                    rpt.rptKod = "-" + disEvrkTur;   // 15.07.17 //topluAlertRow.RPTKOD;
                    rpt.disEvrkTur = disEvrkTur;
                    //rpt.rptKod = "ATCH";
                    //rpt.rptKod = "A:" + disEvrkTur;
                    rpt.info = string.Format("A:{0}", row.DOCID);
                    rpt.attachment = new Attachment(ms, attName);
                    attCheckedListBoxControl.Items.Add(rpt, string.Format("Attachment [{0}]: {1}", attName, row.AD), CheckState.Checked, true);
                }
            }
        }

        private void topluAlertParams()
        {
            rprTopluAlertTableAdapter.Fill(reportDataSet.RPR_TOPLUALERT, rptID, HM, opID);
            topluAlertRow = (ReportDataSet.RPR_TOPLUALERTRow)reportDataSet.RPR_TOPLUALERT.Rows[0];

            hdrLabelControl.Text = string.Format("{0} {1}/{2}", topluAlertRow.RPTAD, ROT, MOT);

            if (string.IsNullOrWhiteSpace(topluAlertRow.EMAILS))
            {
                attCheckedListBoxControl.Items.Add(null, string.Format("eMail adresi bulunamadı"), CheckState.Indeterminate, false);
                hata = true;
            }
            else
            {
                string[] mails = topluAlertRow.EMAILS.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string mail in mails)
                {
                    attCheckedListBoxControl.Items.Add(mail, string.Format("Mail to: {0}", mail), CheckState.Checked, true);    // Istedigine gondermiyebilir
                }
                attCheckedListBoxControl.Items.Add(USReMail, string.Format("Mail to: {0}", USReMail), CheckState.Checked, true);    // Aktif usera da mail gonder Control
            }
        }

        private void checkSimpleButton_Click(object sender, EventArgs e)
        {
            attCheckedListBoxControl.Items.Clear();
            
            topluAlertParams();

            if (rptID == 400)   // --MAWA Marken Airwaybill Alert House
            {
                attDocuments("OPH", opID, "MRKAW", true);
            }
            else if (rptID == 600)  // T1
            {
                attDocuments("OPM", opID, "INV", false);
                attDocuments("OPM", opID, "PCKL", false);
                attDocuments("OPM", opID, "ATR", false);
                attDocuments("OPM", opID, "BYN", false);
            }
            else if (rptID == 605)  // TSLM TeslimEvragi
            {
                attDocuments("OPH", opID, "TSLM", true);
            }
            else if (rptID == -1 && ROT == "E" && MOT == "A")   // taMrkn Master
            {
                attCargoManifest(opID);
                attMAWB(opID);
                attDocuments("OPM", opID, "MRKIN", true);
            }
            else if (rptID == -2 && ROT == "E")            // taSAM Master AgentShippingAdvice
            {
                attShippingAdviceMaster(opID);
                if (MOT == "A")
                {
                    attMAWB(opID);
                    attHAWBs();
                    attCargoManifest(opID);
                    attDocuments("OPM", opID, "ATR", false);
                    attDocuments("OPM", opID, "INV", false);
                    attDocuments("OPM", opID, "PCKL", false);
                    attDocuments("OPM", opID, "EURO1", false);
                    attDocuments("OPM", opID, "MNS", false);

                    attDocuments("OPM", opID, "PDPAW", false);
                    attDocuments("OPM", opID, "PDPM", false);
                    attDocuments("OPM", opID, "CDCS", false);

                    attHouseOfMasterDocuments("INV", false);
                    attHouseOfMasterDocuments("PCKL", false);
                    attHouseOfMasterDocuments("ATR", false);
                }
                else if (MOT == "S")
                {
                    attHBLs();
                    attFBLs();
                    attFCRs();
                    attDocuments("OPM", opID, "MBL", false);
                    attDocuments("OPM", opID, "INV", false);
                    attDocuments("OPM", opID, "PCKL", false);
                    attDocuments("OPM", opID, "ATR", false);

                    attHouseOfMasterDocuments("INV", false);
                    attHouseOfMasterDocuments("PCKL", false);
                    attHouseOfMasterDocuments("ATR", false);
                }
                else if (MOT == "T")
                {
                    attHBLs();
                    attFBLs();
                    attFCRs();
                    attDocuments("OPM", opID, "INV", false);
                    attDocuments("OPM", opID, "PCKL", false);
                    attDocuments("OPM", opID, "ATR", false);
                    attDocuments("OPM", opID, "TRKRN", false);
                    attDocuments("OPM", opID, "CMR", false);

                    attHouseOfMasterDocuments("INV", false);
                    attHouseOfMasterDocuments("PCKL", false);
                    attHouseOfMasterDocuments("ATR", false);
                }
                else if (MOT == "R")
                {
                    attHBLs();
                    attFBLs();
                    attFCRs();
                    attDocuments("OPM", opID, "INV", false);
                    attDocuments("OPM", opID, "PCKL", false);
                    attDocuments("OPM", opID, "ATR", false);
                    attDocuments("OPM", opID, "CIM", false);
                    attDocuments("OPM", opID, "ECS", false);
                    attDocuments("OPM", opID, "BYN", false);
                    attDocuments("OPM", opID, "T1", false);

                    attDocuments("OPM", opID, "DOCS", false);

                    attHouseOfMasterDocuments("INV", false);
                    attHouseOfMasterDocuments("PCKL", false);
                    attHouseOfMasterDocuments("ATR", false);
                }
            }
            else if (rptID == -3 && ROT == "E")    // taSAH House
            {
                attShippingAdviceHouse(opID);
                if (MOT == "A")
                {
                    attHAWB(opID);
                }
                else if (MOT == "S")
                {
                    attHBL(opID);   // Basildiysa
                    attFBL(opID);   // Basildiysa
                    attFCR(opID);   // Basildiysa
                }
                else if (MOT == "T")
                {
                    attHBL(opID);   // Basildiysa
                    attFBL(opID);   // Basildiysa
                    attFCR(opID);   // Basildiysa
                }
                else if (MOT == "R")
                {
                    attHBL(opID);   // Basildiysa
                    attFBL(opID);   // Basildiysa
                    attFCR(opID);   // Basildiysa
                    attDocuments("OPH", opID, "CIM", false);
                }
            }
            else if (rptID == -4 && ROT == "I")    // taCI
            {
                attCikisIhbari(opID);
                attDocuments("OPH", opID, "PRALR", false);
            }
            else if (rptID == -5 && ROT == "I" && MOT == "T")  // taVI
            {
                attVarisIhbari(opID);
                attDocuments("OPH", opID, "TRKRN", false);
            }
            
            eMailSendSimpleButton.Enabled = !hata;
        }

        private void eMailSendSimpleButton_Click(object sender, EventArgs e)
        {
            string eMails = ""; //topluAlertRow.EMAILS + ", " + USReMail;
            object obj;

            for (int i = 0; i < attCheckedListBoxControl.CheckedItemsCount; i++)
            {
                obj = attCheckedListBoxControl.CheckedItems[i];
                if (obj is string)  // eMail
                {
                    if (eMails != "")
                        eMails += "," + obj.ToString();
                    else
                        eMails = obj.ToString();
                }
            }
            stuLabelControl.Text = eMails;

            sendMail(eMails, topluAlertRow.EMAILSUBJECT, topluAlertRow.EMAILBODY);

            if (!hata)
            {
                if (rptID < 0) // toplu
                    reportQueriesTableAdapter.RPH_INS_ATCH(topluAlertRow.RPTKOD, refTO, opID, "", USR, "F", "ILK"); // 15.07.17
                saveRPH();
            }
        }

        private void saveRPH()
        {
            /*
            if (rph != null)
            {
                foreach (RPH r in rph)
                    reportQueriesTableAdapter.RPH_INS(r.rptKod, refTO, opID, USR, "F", r.info); 
            }
            */
            object obj;
            RPT rpt;
            for (int i = 0; i < attCheckedListBoxControl.CheckedItemsCount; i++)
            {
                obj = attCheckedListBoxControl.CheckedItems[i];
                //if (obj != null && obj is RPT)
                if (obj is RPT)
                {
                    rpt = obj as RPT;
                    reportQueriesTableAdapter.RPH_INS_ATCH(rpt.rptKod, refTO, opID, rpt.disEvrkTur, USR, "F", rpt.info);
                }
            }

        }
    }

//-----------------------------------------------------------------------------------------    
    public class RPT
    {
        public int rptID { get; set; }
        public string rptKod { get; set; }
        public string refTO { get; set; }
        public int refID { get; set; }
        public string usr { get; set; }
        public string rspW { get; set; }
        public string info { get; set; }
        public string disEvrkTur { get; set; }
        public Attachment attachment { get; set; }
    }

    public class MRPT
    {
        public int rptID { get; set; }
        public string rptKod { get; set; }
        public string refTO { get; set; }
        public int refID { get; set; }
        public string usr { get; set; }
        public string rspW { get; set; }
        public string info { get; set; }
        public string disEvrkTur { get; set; }
        public Attachment attachment { get; set; }
    }

    public class RPH
    {
        public string rptKod { get; set; }
        public string info { get; set; }

        public RPH(string rptKod, string info)
        {
            this.rptKod = rptKod;
            this.info = info;
        }
    }

}
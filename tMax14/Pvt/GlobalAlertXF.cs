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
using tMax14ReportClassLibrary;
using System.IO;
using System.Net.Mail;

namespace tMax14.Pvt
{
    public partial class GlobalAlertXF : DevExpress.XtraEditors.XtraForm
    {
        private bool hata = false;
        private PvtDataSet.RPR_TOPLUALERTRow topluAlertRow; // Sadece hIDs kullaniliyor
        private PvtDataSet.SMTPRow SMTP;
        bool cancelSend = false;
        //bool deneme = true;     // Sadece kendisine gonder, RPH history'e ekleme
        StringBuilder resSB = new StringBuilder();

        public GlobalAlertXF()
        {
            InitializeComponent();

            SENDsimpleButton.Enabled = false;
            CANCELsimpleButton.Enabled = false;
            cancelSend = false;

            rPR_GLOBAL_ALERT_FINDGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colHACCID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

        }

        private void GlobalAlertXF_Load(object sender, EventArgs e)
        {
            PvtDataSetTableAdapters.SMTPTableAdapter smtpTableAdapter = new PvtDataSetTableAdapters.SMTPTableAdapter();
            PvtDataSet.SMTPDataTable SMTPTable = (PvtDataSet.SMTPDataTable)smtpTableAdapter.GetData();
            SMTP = (PvtDataSet.SMTPRow)SMTPTable.Rows[0];
            SENDsimpleButton.Enabled = false;

            Trh1dateEdit.EditValue = DateTime.Today;
            Trh2dateEdit.EditValue = DateTime.Today.AddDays(1);
        }

        private void FILLsimpleButton_Click(object sender, EventArgs e)
        {
            this.rprGlobalAlertFindTableAdapter.Fill(this.pvtDataSet.RPR_GLOBAL_ALERT_FIND, Trh1dateEdit.DateTime, Trh2dateEdit.DateTime, Program.USR);
            SENDsimpleButton.Enabled = true;
            cancelSend = false;
        }

        private void CANCELsimpleButton_Click(object sender, EventArgs e)
        {
            cancelSend = true;
            //Application.DoEvents();

            CANCELsimpleButton.Enabled = false;
        }

        private void topluAlertParams(int rptID, string HM, int opID)
        {
            rprTopluAlertTableAdapter.Fill(pvtDataSet.RPR_TOPLUALERT, rptID, HM, opID);
            topluAlertRow = (PvtDataSet.RPR_TOPLUALERTRow)pvtDataSet.RPR_TOPLUALERT.Rows[0];
        }

        private void SENDsimpleButton_Click(object sender, EventArgs e)
        {
            SENDsimpleButton.Enabled = false;
            CANCELsimpleButton.Enabled = true;
            Application.DoEvents();

            var view = gridView1;
            view.ExpandAllGroups();

            int dsi = 0;
            PvtDataSet.RPR_GLOBAL_ALERT_FINDRow row;

            int currentRowHandle = view.GetVisibleRowHandle(0);

            while (!cancelSend && currentRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (view.IsDataRow(currentRowHandle))
                {
                    view.FocusedRowHandle = currentRowHandle;
                    dsi = gridView1.ViewRowHandleToDataSourceIndex(currentRowHandle);
                    row = (PvtDataSet.RPR_GLOBAL_ALERT_FINDRow)pvtDataSet.RPR_GLOBAL_ALERT_FIND.Rows[dsi];
                    if (row.EMAILS == "")
                        row.Result = "! eMail";
                    else
                    {
                        resSB.Clear();

                        PrintRow(row, row.RPTID, row.RPTKOD, row.OPS, row.OPSID, row.ROT, row.MOT);

                        if (resSB.Length == 0)  // Hata Yoksa
                        {
                            if (DENEMEcheckEdit.Checked)    // Deneme: Sadece kullaniciya gonder
                                row.Result = sendMail(Program.USReMail, row.EMAILSUBJECT, row.EMAILBODY, row.RPTID, row.RPTKOD, row.OPS, row.OPSID, row.MAIL_FROM_ADDRESS, row.CREDENTIALS_USER_NAME, row.CREDENTIALS_USER_PASSWORD);
                            else
                                row.Result = sendMail(row.EMAILS, row.EMAILSUBJECT, row.EMAILBODY, row.RPTID, row.RPTKOD, row.OPS, row.OPSID, row.MAIL_FROM_ADDRESS, row.CREDENTIALS_USER_NAME, row.CREDENTIALS_USER_PASSWORD);
                        }
                        else
                            row.Result = "! " + resSB.ToString();
                    }
                    //MessageBox.Show(row.OPSID.ToString());
                }
                currentRowHandle = view.GetNextVisibleRow(currentRowHandle);
            }
            SENDsimpleButton.Enabled = false;
            CANCELsimpleButton.Enabled = false;
        }

        private void PrintRow(PvtDataSet.RPR_GLOBAL_ALERT_FINDRow row, int rptID, string rptKod, string HM, int opID, string ROT, string MOT)
        {
            attCheckedListBoxControl.Items.Clear();

            topluAlertParams(rptID, HM, opID);
            
            if (rptID == -1)   // taMrkn Master
            {
                attCargoManifest(opID);
                attMAWB(opID);

                attDocuments(rptKod, "OPM", opID, "MRKIN", true);
            }
            else if (rptID == -2 && !row.IsHAGNIDNull())            // taSAM Master icindeki hAgn'a gidecek
            {
                if (MOT == "T")
                {

                    attAgnHBLs(row.AGNHIDS);  // 07.02.18 de eklendi 3u
                    attAgnFBLs(row.AGNHIDS);
                    attAgnFCRs(row.AGNHIDS);

                    attAgnHouseOfMasterDocuments(row.AGNHIDS, rptKod, "INV", true);
                    attAgnHouseOfMasterDocuments(row.AGNHIDS, rptKod, "PCKL", false);
                    attAgnHouseOfMasterDocuments(row.AGNHIDS, rptKod, "ATR", true);
                }
                else
                {
                    attAgnHouseOfMasterDocuments(row.AGNHIDS, rptKod, "INV", false);
                    attAgnHouseOfMasterDocuments(row.AGNHIDS, rptKod, "PCKL", false);
                    attAgnHouseOfMasterDocuments(row.AGNHIDS, rptKod, "ATR", false);
                }
            }
            else if (rptID == -2 && row.IsHAGNIDNull())            // taSAM Master AgentShippingAdvice
            {
                attShippingAdviceMaster(opID);

                if (MOT == "A")
                {
                    attMAWB(opID);
                    attHAWBs();
                    attCargoManifest(opID);

                    attDocuments(rptKod, "OPM", opID, "ATR", false);
                    attDocuments(rptKod, "OPM", opID, "INV", false);
                    attDocuments(rptKod, "OPM", opID, "PCKL", false);
                    attDocuments(rptKod, "OPM", opID, "EURO1", false);
                    attDocuments(rptKod, "OPM", opID, "MNS", false);
                    attDocuments(rptKod, "OPM", opID, "PDPAW", false);
                    attDocuments(rptKod, "OPM", opID, "PDPM", false);
                    attDocuments(rptKod, "OPM", opID, "CDCS", false);

                    attHouseOfMasterDocuments(rptKod, "INV", false);
                    attHouseOfMasterDocuments(rptKod, "PCKL", false);
                    attHouseOfMasterDocuments(rptKod, "ATR", false);
                }
                else if (MOT == "S")
                {
                    attHBLs();
                    attFBLs();
                    attFCRs();

                    attDocuments(rptKod, "OPM", opID, "MBL", true);
                    attDocuments(rptKod, "OPM", opID, "INV", false);
                    attDocuments(rptKod, "OPM", opID, "PCKL", false);
                    attDocuments(rptKod, "OPM", opID, "ATR", false);

                    attHouseOfMasterDocuments(rptKod, "INV", false);
                    attHouseOfMasterDocuments(rptKod, "PCKL", false);
                    attHouseOfMasterDocuments(rptKod, "ATR", false);
                }
                else if (MOT == "T")
                {
                    attHBLs();
                    attFBLs();
                    attFCRs();

                    //attDocuments(rptKod, "OPM", opID, "INV", false);
                    attDocuments(rptKod, "OPM", opID, "PCKL", false);
                    //attDocuments(rptKod, "OPM", opID, "ATR", false);
                    attDocuments(rptKod, "OPM", opID, "TRKRN", false);
                    attDocuments(rptKod, "OPM", opID, "CMR", false);

                    attHouseOfMasterDocuments(rptKod, "INV", true);
                    attHouseOfMasterDocuments(rptKod, "PCKL", false);
                    attHouseOfMasterDocuments(rptKod, "ATR", true);
                }
                else if (MOT == "R")
                {
                    attHBLs();
                    attFBLs();
                    attFCRs();

                    attDocuments(rptKod, "OPM", opID, "INV", false);
                    attDocuments(rptKod, "OPM", opID, "PCKL", false);
                    attDocuments(rptKod, "OPM", opID, "ATR", false);
                    attDocuments(rptKod, "OPM", opID, "CIM", false);
                    attDocuments(rptKod, "OPM", opID, "ECS", false);
                    attDocuments(rptKod, "OPM", opID, "BYN", false);
                    attDocuments(rptKod, "OPM", opID, "T1", false);
                    attDocuments(rptKod, "OPM", opID, "DOCS", false);

                    attHouseOfMasterDocuments(rptKod, "INV", false);
                    attHouseOfMasterDocuments(rptKod, "PCKL", false);
                    attHouseOfMasterDocuments(rptKod, "ATR", false);
                }
            }
            else if (rptID == -3)    // taSAH House
            {
                attShippingAdviceHouse(opID);

                if (row.IsHACCIDNull() || row.HACCID != 71) // Matalan disindakilere digerlerini gonder
                {
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
                        attDocuments(rptKod, "OPH", opID, "CIM", false);
                    }
                }
            }
            else if (rptID == -4)    // taCI
            {
                attCikisIhbari(opID);
                attDocuments(rptKod, "OPH", opID, "PRALR", false);
            }
            else if (rptID == -5)  // taVI
            {
                attVarisIhbari(opID);
                attDocuments(rptKod, "OPH", opID, "TRKRN", false);
            }
            else if (rptID == 3)    // SAM (Sadece E/S)   ////////////////////////////////////////////////
            {
                // opID is Master
                attSAM(opID);
                attDocuments(rptKod, "OPM", opID, "MBLD", false);

                // House da FBLD varsa gonder yoksa uret gonder. Houselarin sadece birine gider
                int hID = int.Parse(row.AGNHIDS);
                docSelDetTableAdapter.Fill(pvtDataSet.DOC_SEL_DET, "OPH", hID, "FBLD");
                int rowCount = pvtDataSet.DOC_SEL_DET.Rows.Count;

                if (rowCount == 0)  // Doc da bulunamadi, uret
                    attFBLalways(hID, rptKod);
                else
                    attAsAnaDocuments(rptKod, "OPH", hID, "FBLD", false);
            }
            else if (rptID == 900)    // KonsimentoOnay (Sadece E/S)   ////////////////////////////////////////////////
            {
                // opID is House, AgnHidS dolu ise MasterOnly (Baska bir alan tanimlamamak icin kullandim)
                if (!row.IsAGNHIDSNull())
                    attAsAnaDocuments(rptKod, "OPH", opID, "MBLD", false);
                else
                {
                    // House da FBLD varsa gonder yoksa uret gonder. (Daha once gonderilmemis ise RPH da yok)
                    docSelDetTableAdapter.Fill(pvtDataSet.DOC_SEL_DET, "OPH", opID, "FBLD");
                    int rowCount = pvtDataSet.DOC_SEL_DET.Rows.Count;

                    if (rowCount == 0)
                        attFBLalways(opID, rptKod);
                    else
                        attAsAnaDocuments(rptKod, "OPH", opID, "FBLD", false);
                }
            }
            else if (rptID == 904)    // TS TeklifSorgulama  (TST 
            {
                attDocumentSon(rptKod, "TST", opID, "TKLF", true); // Attachment yoksa bos gitmemeli!!!
            }
            else if (rptID == 906)    // YTT YuklemeTalimatiTalep
            {
                // Ilgili House'a RptID:906 nin ekindeki DET=YTT yi gonder
                attRPTdoc(rptID, rptKod, "OPH", opID, "YTT", true);  // RaporTanim ekindeki YTT evragini gonder
            }
            else if (rptID == 908)    // KTB KargoTakipBilgisi
            {
                attEmpty(rptKod, "OPH", opID);
                // Rapor&Ek yok sadece Subject/Body gidecek
            }
            else if (rptID == 913)    // CIM EvrakTaip
            {
                attEmpty(rptKod, "OPM", opID);
                // Rapor&Ek yok sadece Subject/Body gidecek
            }
            else if (rptID == 920)    // ZiyaretAnketi
            {
                attEmpty(rptKod, "FRT", opID);
                // Rapor&Ek yok sadece Subject/Body gidecek
            }
            else if (rptID == 5)    // POD
            {
                attPOD(opID);
            }
            else if (rptID == 7)    // VI
            {
                attVarisIhbari(opID);
            }
            else if (rptID == 22)    // RTF
            {
                attRezervasyonTeyit(opID);
            }
            else if (rptID == 605)    // TSLM
            {
                attDocuments(rptKod, "OPH", opID, "TSLM", false);
            }
            else if (rptID == 700)    // AKTB
            {
                attAktarmaBilgilendirme(opID);
            }

            //SENDsimpleButton.Enabled = !hata;
        }

        private string sendMail(string mailTo, string subject, string body, int rptID, string rptKod, string Ops, int OpsID, string mailFrom, string cUsrNme, string cUsrPwd)
        {
            string result = "OK";
            Cursor = Cursors.WaitCursor;
            try
            {
                MailMessage mail = new MailMessage();

                object obj;

                for (int i = 0; i < attCheckedListBoxControl.CheckedItemsCount; i++)
                {
                    obj = attCheckedListBoxControl.CheckedItems[i];
                    if (obj is RPT && (obj as RPT).attachment != null)
                        mail.Attachments.Add((obj as RPT).attachment);
                }

                mail.To.Add(mailTo);

                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                //mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);
                mail.From = new MailAddress(mailFrom, SMTP.MAIL_FROM_DISPLAY_NAME);
                SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
                //smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
                smtp.Credentials = new System.Net.NetworkCredential(cUsrNme, cUsrPwd);
                smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
                smtp.Port = SMTP.PORT;

                smtp.Send(mail);

                stuLabelControl.Text = "SendMail: Mail Sent";

                if (!DENEMEcheckEdit.Checked)    // Deneme de RPH'a kaydetme
                {
                    if (rptID < 0) // topluAlertlerin ILK kayitlari GlobalAlert_Find bu kayitlara bakacak (toplular icin) (TopluAlert bakmiyor kullanici isterse defalarca yapabilir) (TopluAlert'dn yapildiysa burasi yapmayacak)
                    {
                        if (Ops == "H")
                            pvtQueriesTableAdapter.RPH_INS_ATCH(rptKod, "OPH", OpsID, "", Program.USR, "F", "ILK");
                        else if(Ops == "M")
                            pvtQueriesTableAdapter.RPH_INS_ATCH(rptKod, "OPM", OpsID, "", Program.USR, "F", "ILK");
                        else if (Ops == "T")
                            pvtQueriesTableAdapter.RPH_INS_ATCH(rptKod, "TST", OpsID, "", Program.USR, "F", "ILK");
                    }
                    saveRPH();
                }
            }
            catch (Exception ex)
            {
                result = "Hata! " + ex.Message;
                stuLabelControl.Text = "Hata! " + ex.Message;
                if (ex.InnerException != null)
                    stuLabelControl.Text = string.Format("Hata! {0}\n{1}", ex.Message, ex.InnerException.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return result;
        }

        private void saveRPH()
        {
            object obj;
            RPT rpt;
            for (int i = 0; i < attCheckedListBoxControl.CheckedItemsCount; i++)
            {
                obj = attCheckedListBoxControl.CheckedItems[i];
                if (obj is RPT)
                {
                    rpt = obj as RPT;
                    pvtQueriesTableAdapter.RPH_INS_ATCH(rpt.rptKod, rpt.refTO, rpt.refID, rpt.disEvrkTur, Program.USR, "F", rpt.info);
                }
            }
        }
        
        #region Reports

        private void attCargoManifest(int mID)
        {
            string fn = "CargoManifest" + mID + ".pdf";
            CargoManifestXR rpr = new CargoManifestXR(mID);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            RPT rpt = new RPT();
            rpt.rptKod = "CM";
            rpt.refTO = "OPM";
            rpt.refID = mID;
            rpt.info = string.Format("M:{0}", mID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attSAM(int mID)   // ShippingAdviceMaster
        {
            string fn = "SAM" + mID + ".pdf";
            ShippingAdviceMasterXR rpr = new ShippingAdviceMasterXR(mID);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            RPT rpt = new RPT();
            rpt.rptKod = "SAM";
            rpt.refTO = "OPM";
            rpt.refID = mID;
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
            rpt.refTO = "OPM";
            rpt.refID = mID;
            rpt.info = string.Format("M:{0}", mID);
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

        private void attHAWB(int hID)
        {
            string fn = "HAWB" + hID + ".pdf";
            HawbXR rpr = new HawbXR(hID, true);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            RPT rpt = new RPT();
            rpt.rptKod = "HAWB";
            rpt.refTO = "OPH";
            rpt.refID = hID;
            rpt.info = string.Format("H:{0}", hID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
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
            rpt.refTO = "OPH";
            rpt.refID = hID;
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
            rpt.refTO = "OPM";
            rpt.refID = mID;
            rpt.info = string.Format("M:{0}", mID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attHBLs()      // HAWBs in Master
        {
            string[] hIDs = topluAlertRow.HIDS.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int id;
            foreach (string hID in hIDs)
            {
                id = Convert.ToInt32(hID);
                attHBL(id);
            }
        }

        private void attHBL(int hID)
        {
            if (pvtQueriesTableAdapter.RPH_CHECK("HBL", "OPH", hID).ToString() == "T")    // House'dan basildiysa
            {
                string fn = "HBL" + hID + ".pdf";
                HblXR rpr = new HblXR(hID, true);
                MemoryStream ms = new MemoryStream();
                rpr.ExportToPdf(ms);
                ms.Seek(0, System.IO.SeekOrigin.Begin);

                RPT rpt = new RPT();
                rpt.rptKod = "HBL";
                rpt.refTO = "OPH";
                rpt.refID = hID;
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
                attFBL(id);
            }
        }

        private void attFBL(int hID)
        {
            if (pvtQueriesTableAdapter.RPH_CHECK("FBL", "OPH", hID).ToString() == "T")    // House'dan basildiysa
            {
                string fn = "FBL" + hID + ".pdf";
                FblXR rpr = new FblXR(hID, true);
                MemoryStream ms = new MemoryStream();
                rpr.ExportToPdf(ms);
                ms.Seek(0, System.IO.SeekOrigin.Begin);

                RPT rpt = new RPT();
                rpt.rptKod = "FBL";
                rpt.refTO = "OPH";
                rpt.refID = hID;
                rpt.info = string.Format("H:{0}", hID);
                rpt.attachment = new Attachment(ms, fn);
                attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

                Application.DoEvents();
            }
        }

        private void attFBLalways(int hID, string rptKod)
        {
            string fn = "FBL" + hID + ".pdf";
            FblXR rpr = new FblXR(hID, true);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            RPT rpt = new RPT();
            rpt.rptKod = rptKod;
            rpt.refTO = "OPH";
            rpt.refID = hID;
            rpt.info = string.Format("H:{0}", hID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attFCRs()      // HAWBs in Master
        {
            string[] hIDs = topluAlertRow.HIDS.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int id;
            foreach (string hID in hIDs)
            {
                id = Convert.ToInt32(hID);
                attFCR(id);
            }
        }

        private void attFCR(int hID)
        {
            if (pvtQueriesTableAdapter.RPH_CHECK("FCR", "OPH", hID).ToString() == "T")    // House'dan basildiysa
            {
                string fn = "FCR" + hID + ".pdf";
                FcrXR rpr = new FcrXR(hID, true);
                MemoryStream ms = new MemoryStream();
                rpr.ExportToPdf(ms);
                ms.Seek(0, System.IO.SeekOrigin.Begin);

                RPT rpt = new RPT();
                rpt.refTO = "OPH";
                rpt.refID = hID;
                rpt.rptKod = "FCR";
                rpt.info = string.Format("H:{0}", hID);
                rpt.attachment = new Attachment(ms, fn);
                attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

                Application.DoEvents();
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
            rpt.refTO = "OPH";
            rpt.refID = hID;
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
            rpt.refTO = "OPH";
            rpt.refID = hID;
            rpt.info = string.Format("H:{0}", hID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attPOD(int hID)
        {
            string fn = "POD" + hID + ".pdf";
            ProofOfDeliveryXR rpr = new ProofOfDeliveryXR(hID);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            //rpti.put("POD", "OPH", OPHid, Program.USR, "F", "eMail");
            RPT rpt = new RPT();
            rpt.rptKod = "POD";
            rpt.refTO = "OPH";
            rpt.refID = hID;
            rpt.info = string.Format("H:{0}", hID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attKO(int hID)
        {
            string fn = "POD" + hID + ".pdf";
            ProofOfDeliveryXR rpr = new ProofOfDeliveryXR(hID);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            RPT rpt = new RPT();
            rpt.rptKod = "KO";  // KonsimentoOnay
            rpt.refTO = "OPH";
            rpt.refID = hID;
            rpt.info = string.Format("H:{0}", hID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attAktarmaBilgilendirme(int hID)
        {
            
            string fn = "AKTB" + hID + ".pdf";
            /*
            AktarmaBilgilendirmeXR rpr = new AktarmaBilgilendirmeXR(hID);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);
            */
            //rpti.put("AKTB", "OPH", OPHid, Program.USR, "F", "eMail");
            RPT rpt = new RPT();
            rpt.rptKod = "AKTB";
            rpt.refTO = "OPH";
            rpt.refID = hID;
            rpt.info = string.Format("H:{0}", hID);
            rpt.attachment = null; // Attachment yok new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attRezervasyonTeyit(int hID)
        {
            string fn = "RTF" + hID + ".pdf";
            RezervasyonTeyitFormXR rpr = new RezervasyonTeyitFormXR(hID);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            //rpti.put("RTF", "OPH", OPHid, Program.USR, "F", "eMail");
            RPT rpt = new RPT();
            rpt.rptKod = "RTF";
            rpt.refTO = "OPH";
            rpt.refID = hID;
            rpt.info = string.Format("H:{0}", hID);
            rpt.attachment = new Attachment(ms, fn);
            attCheckedListBoxControl.Items.Add(rpt, string.Format("{0}", fn), CheckState.Checked, true);

            Application.DoEvents();
        }

        private void attHouseOfMasterDocuments(string rptKod, string disEvrkTur, bool zorunlu)
        {
            string[] hIDs = topluAlertRow.HIDS.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int refID;
            foreach (string hID in hIDs)
            {
                refID = Convert.ToInt32(hID);
                attDocuments(rptKod, "OPH", refID, disEvrkTur, zorunlu);
            }
        }

        private void attAgnHouseOfMasterDocuments(string AgnHIDs, string rptKod, string disEvrkTur, bool zorunlu)
        {
            string[] hIDs = AgnHIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int refID;
            foreach (string hID in hIDs)
            {
                refID = Convert.ToInt32(hID);
                attDocuments(rptKod, "OPH", refID, disEvrkTur, zorunlu);
            }
        }

        private void attAgnHBLs(string AgnHIDs)      // hAgn'in HIDs
        {
            string[] hIDs = AgnHIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string hID in hIDs)
            {
                attHBL(Convert.ToInt32(hID));
            }
        }

        private void attAgnFBLs(string AgnHIDs)      // hAgn'in HIDs
        {
            string[] hIDs = AgnHIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string hID in hIDs)
            {
                attFBL(Convert.ToInt32(hID));
            }
        }

        private void attAgnFCRs(string AgnHIDs)      // hAgn'in HIDs
        {
            string[] hIDs = AgnHIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string hID in hIDs)
            {
                attFCR(Convert.ToInt32(hID));
            }
        }

        #endregion Reports

        private void attEmpty(string rptKod, string refTO, int refID)
        {
            RPT rpt = new RPT();
            rpt.rptKod = rptKod;
            rpt.refTO = refTO;
            rpt.refID = refID;
            attCheckedListBoxControl.Items.Add(rpt, "No Attachment", CheckState.Checked, true);
        }

        private void attRPTdoc(int docID, string rptKod, string refTO, int refID, string disEvrkTur, bool zorunlu)
        {
            //RPT.rptID den ek(ler)i bul
            docSelDetTableAdapter.Fill(pvtDataSet.DOC_SEL_DET, "RPT", docID, disEvrkTur);
            int rowCount = pvtDataSet.DOC_SEL_DET.Rows.Count;

            if (rowCount == 0)
            {
                if (zorunlu)
                {
                    resSB.Append(disEvrkTur + " ");
                    hata = true;
                }
                //attCheckedListBoxControl.Items.Add(null, string.Format("Attachment {0}: Bulunamadı", disEvrkTur), CheckState.Indeterminate, false);

                return;
            }

            foreach (PvtDataSet.DOC_SEL_DETRow row in pvtDataSet.DOC_SEL_DET.Rows)
            {
                byte[] byteArray = row.BLB;
                MemoryStream ms = new MemoryStream(byteArray);
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                if (ms.Length > 0)
                {
                    string attName = string.Format("{0}{1}{2}-{3}{4}", disEvrkTur, refTO, refID, row.DOCID, row.TYP);

                    RPT rpt = new RPT();
                    rpt.rptKod = rptKod;
                    rpt.disEvrkTur = disEvrkTur;
                    rpt.refTO = refTO;
                    rpt.refID = refID;
                    rpt.info = string.Format("A:{0}", row.DOCID);
                    rpt.attachment = new Attachment(ms, attName);
                    attCheckedListBoxControl.Items.Add(rpt, string.Format("Attachment [{0}]: {1}", attName, row.AD), CheckState.Checked, true);
                }
            }

        }

        private void attAsAnaDocuments(string rptKod, string refTO, int refID, string disEvrkTur, bool zorunlu)
        {
            this.docSelDetTableAdapter.Fill(this.pvtDataSet.DOC_SEL_DET, refTO, refID, disEvrkTur);
            int rowCount = this.pvtDataSet.DOC_SEL_DET.Rows.Count;

            if (rowCount == 0)
            {
                if (zorunlu)
                {
                    resSB.Append(disEvrkTur + " ");
                    hata = true;
                }
                //attCheckedListBoxControl.Items.Add(null, string.Format("Attachment {0}: Bulunamadı", disEvrkTur), CheckState.Indeterminate, false);

                return;
            }

            foreach (PvtDataSet.DOC_SEL_DETRow row in this.pvtDataSet.DOC_SEL_DET.Rows)
            {
                byte[] byteArray = row.BLB;
                MemoryStream ms = new MemoryStream(byteArray);
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                if (ms.Length > 0)
                {
                    string attName = string.Format("{0}{1}{2}-{3}{4}", disEvrkTur, refTO, refID, row.DOCID, row.TYP);

                    RPT rpt = new RPT();
                    rpt.rptKod = rptKod;
                    rpt.disEvrkTur = disEvrkTur;
                    rpt.refTO = refTO;
                    rpt.refID = refID;
                    rpt.info = string.Format("A:{0}", row.DOCID);
                    rpt.attachment = new Attachment(ms, attName);
                    attCheckedListBoxControl.Items.Add(rpt, string.Format("Attachment [{0}]: {1}", attName, row.AD), CheckState.Checked, true);
                }
            }

        }

        private void attDocuments(string rptKod, string refTO, int refID, string disEvrkTur, bool zorunlu)
        {
            this.docSelDetTableAdapter.Fill(this.pvtDataSet.DOC_SEL_DET, refTO, refID, disEvrkTur);
            int rowCount = this.pvtDataSet.DOC_SEL_DET.Rows.Count;

            if (rowCount == 0)
            {
                if (zorunlu)
                {
                    resSB.Append(disEvrkTur + " ");
                    hata = true;
                }
                //attCheckedListBoxControl.Items.Add(null, string.Format("Attachment {0}: Bulunamadı", disEvrkTur), CheckState.Indeterminate, false);

                return;
            }

            foreach (PvtDataSet.DOC_SEL_DETRow row in this.pvtDataSet.DOC_SEL_DET.Rows)
            {
                byte[] byteArray = row.BLB; //(byte[])this.reportDataSet.DOC_SEL_DET.Rows[0]["BLB"];
                MemoryStream ms = new MemoryStream(byteArray);
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                if (ms.Length > 0)
                {
                    string attName = string.Format("{0}{1}{2}-{3}{4}", disEvrkTur, refTO, refID, row.DOCID, row.TYP);

                    RPT rpt = new RPT();
                    rpt.rptKod = "-" + disEvrkTur;//rptKod; // topluAlertRow.RPTKOD;
                    rpt.disEvrkTur = disEvrkTur;
                    rpt.refTO = refTO;
                    rpt.refID = refID;
                    rpt.info = string.Format("A:{0}", row.DOCID);
                    rpt.attachment = new Attachment(ms, attName);
                    attCheckedListBoxControl.Items.Add(rpt, string.Format("Attachment [{0}]: {1}", attName, row.AD), CheckState.Checked, true);
                }
            }

        }

        private void attDocumentSon(string rptKod, string refTO, int refID, string disEvrkTur, bool zorunlu)
        {
            this.docSelDetSonTableAdapter.Fill(this.pvtDataSet.DOC_SEL_DET_SON, refTO, refID, disEvrkTur);
            int rowCount = this.pvtDataSet.DOC_SEL_DET_SON.Rows.Count;

            if (rowCount == 0)
            {
                if (zorunlu)
                {
                    resSB.Append(disEvrkTur + " ");
                    hata = true;
                }
                //attCheckedListBoxControl.Items.Add(null, string.Format("Attachment {0}: Bulunamadı", disEvrkTur), CheckState.Indeterminate, false);

                return;
            }

            foreach (PvtDataSet.DOC_SEL_DET_SONRow row in this.pvtDataSet.DOC_SEL_DET_SON.Rows)
            {
                byte[] byteArray = row.BLB;
                MemoryStream ms = new MemoryStream(byteArray);
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                if (ms.Length > 0)
                {
                    string attName = string.Format("{0}{1}{2}-{3}{4}", disEvrkTur, refTO, refID, row.DOCID, row.TYP);

                    RPT rpt = new RPT();
                    rpt.rptKod = rptKod; // topluAlertRow.RPTKOD;
                    rpt.disEvrkTur = disEvrkTur;
                    rpt.refTO = refTO;
                    rpt.refID = refID;
                    rpt.info = string.Format("A:{0}", row.DOCID);
                    rpt.attachment = new Attachment(ms, attName);
                    attCheckedListBoxControl.Items.Add(rpt, string.Format("Attachment [{0}]: {1}", attName, row.AD), CheckState.Checked, true);
                }
            }

        }

    }
}
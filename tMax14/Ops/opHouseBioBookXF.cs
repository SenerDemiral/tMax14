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
using System.Globalization;
using ExcelDataReader;
using tMax14ReportClassLibrary;
using System.Net.Mail;
using DevExpress.XtraReports.UI;

namespace tMax14.Ops
{
    public partial class opHouseBioBookXF : DevExpress.XtraEditors.XtraForm
    {
        bool dup = false;

        public opHouseBioBookXF()
        {
            InitializeComponent();

            ophLayoutView.OptionsCustomization.AllowFilter = false;
            ophLayoutView.OptionsCustomization.AllowSort = false;

            ophGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colNSTU.ColumnEdit = Program.MF.OpsStuNrmRepositoryItemLookUpEdit;
            colROT.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colOWNR.ColumnEdit = Program.MF.OWNRrepositoryItemImageComboBox;
            colTOB.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            colORG.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colDST.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colSHPID.ColumnEdit = Program.MF.frtRepositoryItemSearchLookUpEdit; //FRTrepositoryItemGridLookUpEdit;  //FRTrepositoryItemLookUpEdit;
            colCNEID.ColumnEdit = Program.MF.frtRepositoryItemSearchLookUpEdit;
            colACCID.ColumnEdit = Program.MF.frtRepositoryItemSearchLookUpEdit;

            colB_SMPTYP.ColumnEdit = Program.MF.BSMPTYPrepositoryItemLookUpEdit;
            colB_BOXTYP.ColumnEdit = Program.MF.BBOXTYPrepositoryItemLookUpEdit;
            colB_CCC.ColumnEdit = Program.MF.BCCCrepositoryItemCheckedComboBoxEdit;

            colEOH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;

            Program.MF.frtRepositoryItemSearchLookUpEdit.Closed += frtRepositoryItemSearchLookUpEdit_Closed;
        }

        void frtRepositoryItemSearchLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            var edit = sender as SearchLookUpEdit;
            if (e.CloseMode == PopupCloseMode.Normal && edit.OldEditValue != edit.EditValue)
            {
                var frtRow = Program.MF.mainDataSet.FRT.FindByFRTID((int)edit.EditValue);
                if (frtRow != null)
                {
                    if (ophLayoutView.FocusedColumn == colSHPID)
                        ophLayoutView.SetFocusedRowCellValue(colORG, frtRow.LOCID);
                    else if (ophLayoutView.FocusedColumn == colCNEID)
                        ophLayoutView.SetFocusedRowCellValue(colDST, frtRow.LOCID);
                    else if (ophLayoutView.FocusedColumn == colACCID)
                    {
                        if (!frtRow.IsOFCNONull())
                        {
                            int se = Math.Min(4, frtRow.OFCNO.Length);
                            string ofn = frtRow.OFCNO.Substring(0, se);
                            ophLayoutView.SetFocusedRowCellValue(colB_OFCNO, ofn);
                        }
                    }
                }
            }
        }

        private void oPHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            this.Validate();
            this.ophBindingSource.EndEdit();
            DataTable onlyAddTable = opsDataSet.OPH.GetChanges();

            List<int> hIDs = new List<int>();

            foreach (OpsDataSet.OPHRow row in opsDataSet.OPH.Rows)
            {
                hIDs.Add(row.OPHID);
                /*
                row.GODINF = "";
                if (row.B_SMPTYP == "FROZEN")
                    row.GODINF = "UN3373 BIOLOGICAL SUBSTANCE CATEGORY B, HUMAN BLOOD SAMPLES, UN 1845 DRY ICE  NET WEIGHT:1x4 KG TOTAL NET WEIGHT:4 KG - - PU DATE : __ / 1F (1F box supplied)";
                if (row.B_SMPTYP == "AMBIENT")
                    row.GODINF = "UN3373 BIOLOGICAL SUBSTANCE CATEGORY B, HUMAN BLOOD SAMPLES  - - PU DATE AND TIME : __ / 1A (1F Overpack box supplied)";
                if (row.B_SMPTYP == "REEFER")
                    row.GODINF = "UN3373 BIOLOGIAL SUBSTANCE CATEGORY B, HUMAN BLOOD SAMPLES / / PU DATE AND TIME : __ / 1Refrigerated (1Ref. 3.5 box supplied)";
                if (row.B_SMPTYP == "BOTH")
                    row.GODINF = "(Frozen+Ambiant): UN3373 BIOLOGICAL SUBSTANCE CATEGORY B, HUMAN BLOOD SAMPLES, UN 1845 DRY ICE  NET WEIGHT:1x4 KG TOTAL NET WEIGHT:4 KG - - PU DATE AND TIME : __ / 1F +1A (1F +1F Overpack box supplied)";
                if (row.B_SMPTYP == "AMBREF")
                    row.GODINF = "UN3373 BIOLOGICAL SUBSTANCE CATEGORY B, HUMAN BLOOD SAMPLES  - - PU DATE AND TIME : __ / 1A + 1REF (1F Overpack box supplied + 1Ref. 3.5 box supplied)";
                 */
            }

            //this.opsDataSet.OPH.Rows[0]
            //this.oPHTableAdapter.Update(onlyAddTable.Rows);

            this.ophTableAdapter.Update(this.opsDataSet.OPH);

            ophTableAdapter.ClearBeforeFill = false;
            foreach (int hId in hIDs)
                ophTableAdapter.FillByPK(this.opsDataSet.OPH, hId);

            //this.opsDataSet.OPH.Clear();
        }

        private void opHouseBioBookXF_Load(object sender, EventArgs e)
        {
            this.zmslTableAdapter.Fill(this.opsDataSet.ZMSL);
            //this.oPHTableAdapter.Fill(this.opsDataSet.OPH);
        }

        OpsDataSet.OPHRow dRow;

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Duplicate

            var view = ophLayoutView;
            dRow = (OpsDataSet.OPHRow)view.GetDataRow(view.FocusedRowHandle);

            bindingNavigatorAddNewItem.PerformClick();
        }

        private void layoutView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Layout.LayoutView;

            if (dRow == null)
            {
                int PK = (int)Program.MF.mainQueriesTableAdapter.GET_PK("OPS");
                view.SetRowCellValue(e.RowHandle, colOPHID, PK);
                view.SetRowCellValue(e.RowHandle, colNSTU, "B");
                view.SetRowCellValue(e.RowHandle, colOWNR, "1");
                view.SetRowCellValue(e.RowHandle, colTOB, "B");
                view.SetRowCellValue(e.RowHandle, colROT, "E");
                view.SetRowCellValue(e.RowHandle, colMOT, "A");

                view.SetRowCellValue(e.RowHandle, colORG, "TR");
            }
            else
            {
                int PK = (int)Program.MF.mainQueriesTableAdapter.GET_PK("OPS");
                view.SetRowCellValue(e.RowHandle, colOPHID, PK);
                view.SetRowCellValue(e.RowHandle, colNSTU, "B");
                view.SetRowCellValue(e.RowHandle, colOWNR, "1");
                view.SetRowCellValue(e.RowHandle, colTOB, "B");
                view.SetRowCellValue(e.RowHandle, colROT, "E");
                view.SetRowCellValue(e.RowHandle, colMOT, "A");

                view.SetRowCellValue(e.RowHandle, colSHPID, dRow["SHPID"]);
                view.SetRowCellValue(e.RowHandle, colB_PUDPT, dRow["B_PUDPT"]);
                view.SetRowCellValue(e.RowHandle, colORG, dRow["ORG"]);
                view.SetRowCellValue(e.RowHandle, colB_SNDINFO, dRow["B_SNDINFO"]);
                view.SetRowCellValue(e.RowHandle, colB_NOA, dRow["B_NOA"]);
                view.SetRowCellValue(e.RowHandle, colB_NOF, dRow["B_NOF"]);
                view.SetRowCellValue(e.RowHandle, colB_NOT, dRow["B_NOT"]);
                view.SetRowCellValue(e.RowHandle, colB_NOR, dRow["B_NOR"]);
                view.SetRowCellValue(e.RowHandle, colB_CCC, dRow["B_CCC"]);
                view.SetRowCellValue(e.RowHandle, colB_KUTUGONDER, dRow["B_KUTUGONDER"]);
                view.SetRowCellValue(e.RowHandle, colB_DLGONDER, dRow["B_DLGONDER"]);
                view.SetRowCellValue(e.RowHandle, colB_BOXTYP, dRow["B_BOXTYP"]);
                view.SetRowCellValue(e.RowHandle, colEOH, dRow["EOH"]);
                view.SetRowCellValue(e.RowHandle, colACCID, dRow["ACCID"]);
                view.SetRowCellValue(e.RowHandle, colB_TOS, dRow["B_TOS"]);
                view.SetRowCellValue(e.RowHandle, colCNEID, dRow["CNEID"]);
                view.SetRowCellValue(e.RowHandle, colDST, dRow["DST"]);
                view.SetRowCellValue(e.RowHandle, colB_RCVINFO, dRow["B_RCVINFO"]);
                view.SetRowCellValue(e.RowHandle, colB_TEMPLATE, dRow["B_TEMPLATE"]);
                view.SetRowCellValue(e.RowHandle, colB_PRTNO, dRow["B_PRTNO"]);
                view.SetRowCellValue(e.RowHandle, colB_SMPTYP, dRow["B_SMPTYP"]);
                view.SetRowCellValue(e.RowHandle, colB_SITENO, dRow["B_SITENO"]);
                view.SetRowCellValue(e.RowHandle, colB_MRKBILDIR, dRow["B_MRKBILDIR"]);
                view.SetRowCellValue(e.RowHandle, colB_KUTUDONDU, dRow["B_KUTUDONDU"]);
                view.SetRowCellValue(e.RowHandle, colB_DLDONDU, dRow["B_DLDONDU"]);

                dRow = null;
            }
        }

        private void selectFromMarkenSiteListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented yet.");
        }

        private void secToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!zmslGridView.IsDataRow(zmslGridView.FocusedRowHandle))
                return;
            
            if (ophLayoutView.RecordCount == 0)
                ophLayoutView.AddNewRow();

            // Kayit edildiyse uzerine Sec ile yazma yeni kayit ekle, ama manuel degistirebilir.
            DataRowState drs = ophLayoutView.GetFocusedDataRow().RowState;
            if (drs == DataRowState.Unchanged || drs == DataRowState.Modified)
                ophLayoutView.AddNewRow();

            ophLayoutView.SetFocusedRowCellValue(colB_PRTNO, zmslGridView.GetFocusedRowCellValue(colPROTOCOL));
            ophLayoutView.SetFocusedRowCellValue(colB_STUDYNO, zmslGridView.GetFocusedRowCellValue(colSTUDY));
            ophLayoutView.SetFocusedRowCellValue(colB_SITENO, zmslGridView.GetFocusedRowCellValue(colSITE));
            //ophLayoutView.SetFocusedRowCellValue(colB_SNDINFO, zmslGridView.GetFocusedRowCellValue(colPICKUPNAME));
            ophLayoutView.SetFocusedRowCellValue(colB_PUDPT, zmslGridView.GetFocusedRowCellValue(colPICKUPDEPARTMENT));

            ophLayoutView.SetFocusedRowCellValue(colDST, zmslGridView.GetFocusedRowCellValue(colCONSIGNEECOUNTRYCODE));
        }

        private void newListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            FileStream stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader;

            var ext = Path.GetExtension(openFileDialog.FileName);
            if (ext == ".xls")
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            else
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            if (excelReader == null) // || !excelReader.IsValid)
            {
                MessageBox.Show("Selected file is not valid Excel file");
                return;
            }

            //CultureInfo culture = new CultureInfo("en-US");
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            this.opsDataSet.ZMSL.Clear();
            int i = 0;
            DateTime ld;
            excelReader.IsFirstRowAsColumnNames = true;     // Nuget 3.4e Update'den sonra bozuldu, eskisine 3.0.develop00019 a geri aldim
            excelReader.Read();
            while (excelReader.Read())
            {
                i++;
                OpsDataSet.ZMSLRow row = opsDataSet.ZMSL.NewZMSLRow();
                //row.ID = i++;
                // var bbb = excelReader.GetOrdinal("Template"); Calismiyor
                row.TEMPLATE = excelReader.GetString(0);

                if (DateTime.TryParse(excelReader.GetString(1), out ld))
                    row.LOADINGDATE = ld;

/*
                try
                {
                    //MessageBox.Show(excelReader.GetString(1));
                    //row.LOADINGDATE = Convert.ToDateTime(excelReader.GetString(1).Substring(0, 10));
                    ld = DateTime.Parse(excelReader.GetString(1));
                    row.LOADINGDATE = ld;
                    //MessageBox.Show(excelReader.GetString(1) + "  " + row.LOADINGDATE.ToString());
                    //row.LOADINGDATE = Convert.ToDateTime(excelReader.GetValue(1), culture); //excelReader.GetDateTime(1); //.ToString();  //Convert.ToDateTime(excelReader.GetString(1).Substring(0, 10));
                }
                catch (Exception ee)
                {
                    //MessageBox.Show(excelReader.GetString(1));
                    //ld = DateTime.Parse(excelReader.GetString(1), culture);
                    //row.LOADINGDATE = ld;
                }
 */
                row.STATUS = excelReader.GetString(2);
                row.PROTOCOL = excelReader.GetString(3);
                row.SPONSOR = excelReader.GetString(4);
                row.STUDY = excelReader.GetString(5);
                row.SITE = excelReader.GetString(6);

                row.WEEKAMB = excelReader.GetString(8);
                row.WEEKREF = excelReader.GetString(9);
                row.WEEKFRZ = excelReader.GetString(10);
                //
                row.WEEKENDAMB = excelReader.GetString(12);
                row.WEEKENDREF = excelReader.GetString(13);
                row.WEEKENDFRZ = excelReader.GetString(14);

                row.CONSIGNEECOMPANY = excelReader.GetString(19);
                row.CONSIGNEECITY = excelReader.GetString(23);
                row.CONSIGNEECOUNTRYCODE = excelReader.GetString(26);
                row.PICKUPNAME = excelReader.GetString(50);
                row.PICKUPCOMPANY = excelReader.GetString(51);
                row.PICKUPDEPARTMENT = excelReader.GetString(52);
                row.PICKUPCITY = excelReader.GetString(55);
                row.PICKUPPHONE = excelReader.GetString(59);

                opsDataSet.ZMSL.AddZMSLRow(row);
            }
            excelReader.Close();

        }

        private void saveNewListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opsQueriesTableAdapter.ZMSL_DELETE_ALL();
            this.zmslTableAdapter.Update(this.opsDataSet.ZMSL);
        }

        rptInfo rpti = new rptInfo();

        private void markenHAWBRequestMailSendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();

            var view = ophLayoutView;
            int OPHid = (int)view.GetFocusedRowCellValue(colOPHID);
            MrkHAWBrequestXR rpr = new MrkHAWBrequestXR(OPHid);
            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "Marken HAWB Request Form", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("MHAWBRF", "OPH", OPHid, Program.USR, "F", "eMail");

            MailClass.MailReportAsBodyTask(rpti, "eMail Marken HAWB Request Form", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
            //sendEMail(rpti, "eMail Marken HAWB Request Form", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void sendEMail(rptInfo rpti, string Caption, XtraReport xr, string eMails, string eMailSubject, string eMailBody)
        {
            try
            {
                MainDataSet.SMTPRow SMTP = Program.MF.SMTP();
                
                MemoryStream mem = new MemoryStream();
                xr.ExportToHtml(mem);

                // Create a new attachment and put the PDF report into it.
                mem.Seek(0, System.IO.SeekOrigin.Begin);
                var aaa = Encoding.UTF8.GetString(mem.ToArray());

                // Create a new message and attach the PDF report to it.
                MailMessage mail = new MailMessage();
                //mail.Attachments.Add(att);

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

                Program.MF.reportDone(rpti, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error sending eMail.\n" + ex.ToString());
            }
        }

        private void ophLayoutView_HiddenEditor(object sender, EventArgs e)
        {
            var view = ophLayoutView;
            var aaa = view.FocusedColumn.FieldName;
            string s = "";

            if (view.FocusedColumn.FieldName == "B_NOA" ||
                view.FocusedColumn.FieldName == "B_NOF" ||
                view.FocusedColumn.FieldName == "B_NOR")
            {
                if (view.GetFocusedRowCellValue("B_NOA") != DBNull.Value)
                    s += "+15+25";
                if (view.GetFocusedRowCellValue("B_NOF") != DBNull.Value)
                    s += string.IsNullOrWhiteSpace(s) ? "-80C" : ", -80C";
                if (view.GetFocusedRowCellValue("B_NOR") != DBNull.Value)
                    s += string.IsNullOrWhiteSpace(s) ? "+2+8" : ", +2+8";

                view.SetRowCellValue(view.FocusedRowHandle, "B_CCC", s);
            }
        }

    }

}
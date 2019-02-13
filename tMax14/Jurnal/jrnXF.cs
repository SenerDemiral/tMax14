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
using DevExpress.XtraBars.Docking;
using DevExpress.XtraPrinting;

namespace tMax14.Jurnal
{
    public partial class jrnXF : DevExpress.XtraEditors.XtraForm
    {
        public string RefTbl = "", AltTbl = "";
        public int RefID = 0, AltID = 0;
        private MainDataSet.SMTPRow SMTP;
        string layoutName = "Jurnal.jrnXF";

        public jrnXF()
        {
            InitializeComponent();
        }

        private void jrnXF_Load(object sender, EventArgs e)
        {
            SMTP = Program.MF.SMTP();
            //MainDataSet.SMTPRow SMPTP2 = Program.SMTP2;
            
            /*
                        Qry.qsJrnXF frm = new Qry.qsJrnXF();
                        frm.JRN = jurnalDataSet.JRN;
                        frm.Tbl = RefTbl;
                        frm.TblPK = RefID;
                        frm.Dock = DockStyle.Fill;
                        qsDockPanel.Controls.Add(frm);*/

            Qry.qsvJrnXUC frm2 = new Qry.qsvJrnXUC();
            frm2.JRN = jurnalDataSet.JRN;
            frm2.RefTbl = RefTbl;
            frm2.RefID = RefID;
            frm2.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(frm2);

            jrnMdfyGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTAGSm.ColumnEdit = Program.MF.TAGselJRNrepositoryItemCheckedComboBoxEdit;
            colMBRSm.ColumnEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;

            jrnNewGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTAGSn.ColumnEdit = Program.MF.TAGselJRNrepositoryItemCheckedComboBoxEdit;
            colMBRSn.ColumnEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;

            initJrnNewRow();
            initJrnMdfyRow();

            if (!string.IsNullOrEmpty(RefTbl))
            {
                if (RefTbl == "FRT")
                {
                    string refIDs = jurnalQueriesTableAdapter.FRT_SEL_HDQ_LIST(RefID).ToString();
                    jrnTableAdapter.Fill(jurnalDataSet.JRN, Program.USR, string.Format("(RefTbl = '{0}' and RefID in ({1})) or (AltTbl='{0}' and AltID in ({1}))", RefTbl, refIDs));
                }
                else
                    jrnTableAdapter.Fill(jurnalDataSet.JRN, Program.USR, string.Format("REFTBL='{0}' and RefID = {1}", RefTbl, RefID));
            }
            jrnGridView.FormatConditions[0].Expression = string.Format("Contains([BKMS], '{0}')", Program.USRtag);
            jrnGridView.ActiveFilterString = string.Format("[UPD_USR] <> '{0}'", Program.USR);
            jrnGridView.ActiveFilterEnabled = false;

            Program.MF.XGLrestore(layoutName, 0, jrnGridView);
        }

        private void initJrnNewRow()
        {
            jurnalDataSet.JrnNew.Clear();

            jrnNewLayoutView.BeginDataUpdate();

            var nRow = jurnalDataSet.JrnNew.NewJrnNewRow();
            
            nRow.PRVT = "F";
            nRow.BKMD = false;
            nRow.eMail = false;
            nRow.SUBJECT = "";
            nRow.MSJ = "";
            nRow.MBRS = Program.USRtag;

            jurnalDataSet.JrnNew.Rows.Add(nRow);

            jrnNewLayoutView.EndDataUpdate();
        }

        private void initJrnMdfyRow()
        {
            jurnalDataSet.JrnMdfy.Clear();

            jrnMdfylayoutView.BeginDataUpdate();

            var newRow = jurnalDataSet.JrnMdfy.NewJrnMdfyRow();

            newRow.JRNID = -1;
            newRow.Close = false;
            newRow.eMail = false;
            newRow.PRVT = "F";
            newRow.BKMD = false;
            newRow.MBRS = Program.USRtag;
            newRow.TAGS = "";
            newRow.SUBJECT = "";
            newRow.MSJ = "";
            newRow.STU = "";
            newRow.BKMS = "";
            newRow.TkpTrh = DateTime.Today;

            jurnalDataSet.JrnMdfy.Rows.Add(newRow);

            jrnMdfylayoutView.EndDataUpdate();

        }

        private void jrnGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            /*
            if (e.Column == colUPD_TS)
            {
                DateTime updTS = (DateTime)e.Value;
                DateTime today = DateTime.Today;
                if (updTS >= today)
                    e.DisplayText = string.Format("{0:HH:mm}", e.Value);
                else if (updTS.Year == today.Year)
                    e.DisplayText = string.Format("{0:d MMM}", e.Value);
                else
                    e.DisplayText = string.Format("{0:dd.MM.yy}", e.Value);
            }*/
        }

        private void sendEMail(string sbj, string bdy, string mbrs)
        {
            //Task.Factory.StartNew(() =>
            {
                try
                {
                    StringBuilder tos = new StringBuilder();
                    string sUsr = string.Empty;
                    string[] sa = mbrs.Split(new char[] { ',' });
                    foreach (string s in sa)
                    {
                        sUsr = s.TrimStart(new char[] { '<', ' ' }).TrimEnd(new char[] { '>' });
                        if (sUsr != Program.USR) // Kendisine atma
                        {
                            sUsr = string.Format("[USR] = '{0}'", sUsr);
                            MainDataSet.USTRow[] ustRow = (MainDataSet.USTRow[])Program.MF.mainDataSet.UST.Select(sUsr);
                            if (ustRow != null && !ustRow[0].IsEMAILNull() && !string.IsNullOrEmpty(ustRow[0].EMAIL))
                            {
                                if (tos.Length > 0)
                                    tos.Append(",");
                                tos.Append(string.Format("{0} <{1}>", ustRow[0].AD, ustRow[0].EMAIL));
                            }
                        }
                    }
                    if (tos.Length > 0)
                    {
                        MailMessage mail = new MailMessage();

                        mail.To.Add(tos.ToString());
                        mail.Subject = sbj;
                        mail.Body = bdy;
                        mail.IsBodyHtml = false;
                       
                        //mail.From = new MailAddress(tMaxOrtak.OrtakProps.SmtpMailFromAddress, tMaxOrtak.OrtakProps.SmtpMailFromDisplayName);
                        //SmtpClient smtp = new SmtpClient(tMaxOrtak.OrtakProps.SmtpClientHost);
                        //smtp.Credentials = new System.Net.NetworkCredential(tMaxOrtak.OrtakProps.SmtpCredentialsUserName, tMaxOrtak.OrtakProps.SmtpCredentialsUserPassword);
                        //smtp.EnableSsl = tMaxOrtak.OrtakProps.SmtpEnableSsl;
                        //smtp.Port = tMaxOrtak.OrtakProps.SmtpPort;

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
            }//);
        }

        private void refKaydaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tbl = jrnGridView.GetFocusedRowCellDisplayText(colREFTBL);
            string tblPK = jrnGridView.GetFocusedRowCellDisplayText(colREFID);

            if (string.IsNullOrEmpty(tbl) || string.IsNullOrEmpty(tblPK))
                return;

            if (tbl == "OPH")
            {
                Ops.opHouseXUC frm = new Ops.opHouseXUC();
                frm.qsString = string.Format("OPHID = {0}", jrnGridView.GetFocusedRowCellValue(colREFID));
                //frm.Show();

                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                panel.FloatLocation = new Point(100, 100);
                panel.FloatSize = new Size(600, 300);
                panel.Name = "House";
                panel.Text = "House of Jurnal " + jrnGridView.GetFocusedRowCellDisplayText(colJRNID);

                frm.Dock = DockStyle.Fill;
                panel.Controls.Add(frm);
            }
            if (tbl == "OPM")
            {
                var aa = tbl;
                
                Ops.opMasterXUC frm = new Ops.opMasterXUC();
                frm.qsString = string.Format("OPMID = {0}", jrnGridView.GetFocusedRowCellValue(colREFID));
                frm.Show();

                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                panel.FloatLocation = new Point(100, 100);
                panel.FloatSize = new Size(600, 300);
                panel.Name = "Master";
                panel.Text = "Master of Jurnal " + jrnGridView.GetFocusedRowCellDisplayText(colJRNID);

                frm.Dock = DockStyle.Fill;
                panel.Controls.Add(frm);
            }
            if (tbl == "FRT")
            {
                Firma.frtXUC frm = new Firma.frtXUC();
                frm.qsString = string.Format("FRTID = {0}", jrnGridView.GetFocusedRowCellValue(colREFID));

                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                panel.FloatLocation = new Point(100, 100);
                panel.FloatSize = new Size(600, 300);
                panel.Name = "Firma";
                panel.Text = "Firma of Jurnal " + jrnGridView.GetFocusedRowCellDisplayText(colJRNID);

                frm.Dock = DockStyle.Fill;
                panel.Controls.Add(frm);
                frm.Show();
            }
            if (tbl == "AFB")
            {
                Account.FaturaXF frm = new Account.FaturaXF();
                frm.AFBid = (int)jrnGridView.GetFocusedRowCellValue(colREFID);
                
                frm.TopLevel = false;

                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                panel.FloatLocation = new Point(100, 100);
                panel.FloatSize = new Size(600, 300);
                panel.Name = "Fatura";
                panel.Text = "Fatura of Jurnal " + jrnGridView.GetFocusedRowCellDisplayText(colJRNID);

                frm.Dock = DockStyle.Fill;
                panel.Controls.Add(frm);
                //frm.LoadData();
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.Show();
            }
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = jrnGridView;

            if (view.DataRowCount > 0 && view.IsDataRow(view.FocusedRowHandle))
            {
                Doc.DocXF frm = new Doc.DocXF();
                frm.RefTbl = "JRN";
                frm.RefID = (int)view.GetFocusedRowCellValue(colJRNID);
                frm.RefInfo = view.GetFocusedRowCellDisplayText(colSUBJECT);
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = jrnGridView;

            StringBuilder bkms = new StringBuilder();
            bkms.Append(view.GetFocusedRowCellValue(colBKMS));

            if (!bkms.ToString().Contains(Program.USRtag))
            {
                if (bkms.Length > 0)
                    bkms.Append(", ");
                bkms.Append(Program.USRtag);
            }
            else
            {
                bkms.Replace(", " + Program.USRtag, "");
                bkms.Replace(Program.USRtag, "");
            }
            view.SetFocusedRowCellValue(colBKMS, bkms.ToString());

            view.UpdateCurrentRow();
            jrnTableAdapter.Update(jurnalDataSet.JRN);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Program.USR == "ADMN" && jrnGridView.IsDataRow(jrnGridView.FocusedRowHandle))
            {
                if (XtraMessageBox.Show("Delete record", "Jurnal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    jrnGridView.DeleteRow(jrnGridView.FocusedRowHandle);
                    jrnTableAdapter.Update(jurnalDataSet.JRN);
                }
            }
        }

        private void mdfyDockPanel_Enter(object sender, EventArgs e)
        {
            //this.Text = "Modify Panel Active";
            /*
            if (string.IsNullOrEmpty(jrnGridView.GetFocusedRowCellDisplayText(colJRNID)))
            {
                //jrnMdfylayoutView.SetFocusedRowCellValue(colNEWm, true);
                //colNEWm.OptionsColumn.AllowEdit = false;
                jrnMdfyNew();
            }
            else
            {
                //jrnMdfylayoutView.SetFocusedRowCellValue(colNEWm, false);
                //colNEWm.OptionsColumn.AllowEdit = true;
                if (jrnGridView.GetFocusedRowCellValue(colJRNID) != jrnMdfylayoutView.GetFocusedRowCellValue(colJRNIDm))
                    jrnMdfyCurrent();
            }*/
        }

        private void jrnGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.FocusedColumn == colPRVT)
            {
                e.Cancel = !view.GetFocusedRowCellDisplayText(colMBRS).Contains(Program.USRtag);
            }

        }

        private void jrnGridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.FocusedColumn == colPRVT)
            {
                view.SetFocusedRowCellValue(colPRVT, e.Value);

                view.UpdateCurrentRow();
                int aaa = jrnTableAdapter.Update(jurnalDataSet.JRN);
            }
        }

        private void yeniJurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDockPanel.Show();
        }

        private void insSimpleButton_Click(object sender, EventArgs e)
        {
            var view = jrnNewLayoutView;
            view.UpdateCurrentRow();
            
            JurnalDataSet.JrnNewRow row = jurnalDataSet.JrnNew[0];

            if (string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colSUBJECTn)))
            {
                XtraMessageBox.Show("Subject girin", "Jurnal New", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            DateTime? tkpTrh = null;
            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colTkpTrhn)))
                tkpTrh = (DateTime)view.GetFocusedRowCellValue(colTkpTrhn);


            if (row.IsMBRSNull() || string.IsNullOrEmpty(row.MBRS))
                row.MBRS = Program.USRtag;
            
            int JRNid = (int)jurnalQueriesTableAdapter.JRN_INS(
                row.PRVT,
                Program.USR,
                Program.USTad,
                RefTbl,
                RefID,
                AltTbl,
                AltID,
                tkpTrh,
                row.SUBJECT,
                row.MSJ,
                row.IsTAGSNull() ? null : row.TAGS,
                row.IsBKMSNull() ? null : row.BKMS,
                row.IsMBRSNull() ? null : row.MBRS
            );

            jrnTableAdapter.ClearBeforeFill = false;
            jrnTableAdapter.Fill(jurnalDataSet.JRN, Program.USR, string.Format("JRNid = {0}", JRNid));
            jrnTableAdapter.ClearBeforeFill = true;

            var jrnRow = jurnalDataSet.JRN.FindByJRNID(JRNid);
            
            if (row.eMail)
            {
                string sbj;
                string tblInfo = jrnRow.IsTBLINFONull() ? "" : jrnRow.TBLINFO;
                string subject = jrnRow.IsSUBJECTNull() ? "" : jrnRow.SUBJECT;

                if (jrnRow.IsREFIDNull())
                    sbj = string.Format("JRN{0} {1}", JRNid, subject);
                else
                    sbj = string.Format("JRN:{0} {1} {2}", JRNid, tblInfo, subject);

                   //sbj = string.Format("JRN:{0} {1}:{2} {3} {4}", JRNid, RefTbl, RefID, view.GetFocusedRowCellDisplayText(colTBLINFO), row.SUBJECT);

                sendEMail(sbj, jrnRow.JOURNAL, jrnRow.MBRS);
                //sendEMail(sbj, row.MSJ, row.MBRS);
            }

            initJrnNewRow();

            //jrnGridView.Focus();
        }

        private void mdfySimpleButton_Click(object sender, EventArgs e)
        {
            var view = jrnMdfylayoutView;
            view.UpdateCurrentRow();

            JurnalDataSet.JrnMdfyRow row = jurnalDataSet.JrnMdfy[0];

            if (string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colSUBJECTm)))
            {
                XtraMessageBox.Show("Subject girin", "Jurnal Modify", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if ((bool)view.GetFocusedRowCellValue(colClose))
                row.STU = "C";

            DateTime? tkpTrh = null;
            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colTkpTrhm)))
                tkpTrh = (DateTime)view.GetFocusedRowCellValue(colTkpTrhm);

            if (row.IsMBRSNull() || string.IsNullOrEmpty(row.MBRS))
                row.MBRS = Program.USRtag;

            string rslt = (string)jurnalQueriesTableAdapter.JRN_MFY(
                        row.JRNID,
                        row.STU,
                        row.PRVT,
                        Program.USR,
                        Program.USTad,
                        tkpTrh,
                        row.SUBJECT,
                        row.MSJ,
                        row.IsTAGSNull() ? null : row.TAGS,
                        row.IsBKMSNull() ? null : row.BKMS,
                        row.IsMBRSNull() ? null : row.MBRS
                    );

            if (!string.IsNullOrEmpty(rslt))
            {
                XtraMessageBox.Show(rslt + " Mesaj ekleyemezsiniz!", "Mesaj Ekle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int JRNid = row.JRNID;  // Convert.ToInt32(rslt.Substring(1));
            jrnTableAdapter.ClearBeforeFill = false;
            jrnTableAdapter.Fill(jurnalDataSet.JRN, Program.USR, string.Format("JRNid = {0}", JRNid));
            jrnTableAdapter.ClearBeforeFill = true;

            var jrnRow = jurnalDataSet.JRN.FindByJRNID(JRNid);

            if (row.eMail)
            {
                string sbj;
                if (jrnRow.IsREFIDNull())
                    sbj = string.Format("JRN{0} {1}", JRNid, jrnRow.SUBJECT);
                else
                    sbj = string.Format("JRN:{0} {1} {2}", JRNid, jrnRow.TBLINFO, jrnRow.SUBJECT);
                    //sbj = string.Format("JRN:{0} {1}:{2} {3}", row.JRNID, RefTbl, RefID, row.SUBJECT);

                sendEMail(sbj, jrnRow.JOURNAL, jrnRow.MBRS);
                //sendEMail(sbj, row.MSJ, row.MBRS);
            }

            //view.SetFocusedRowCellValue(colClose, false);

        }

        private void jrnGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var sView = jrnGridView;

            if (!sView.IsDataRow(sView.FocusedRowHandle))
            {
            //    mdfyDockPanel.Visibility = DockVisibility.Hidden;
                if (mdfyDockPanel.Visibility == DockVisibility.Visible)
                    mdfyDockPanel.Visibility = DockVisibility.AutoHide;

                //if (mdfyDockPanel.Visibility == DockVisibility.Visible)    
                //    mdfyDockPanel.HideImmediately();
                return;
            }

            var dView = jrnMdfylayoutView;

            dView.SetFocusedRowCellValue(colJRNIDm, sView.GetFocusedRowCellValue(colJRNID));
            dView.SetFocusedRowCellValue(colSTUm, sView.GetFocusedRowCellValue(colSTU));
            dView.SetFocusedRowCellValue(colClose, false);
            dView.SetFocusedRowCellValue(colPRVTm, sView.GetFocusedRowCellValue(colPRVT));

            bool bkmd = false;
            if (sView.GetFocusedRowCellValue(colBKMS) != DBNull.Value)
                if (sView.GetFocusedRowCellValue(colBKMS).ToString().Contains(Program.USRtag))
                    bkmd = true;

            dView.SetFocusedRowCellValue(colBKMDm, bkmd);
            dView.SetFocusedRowCellValue(colBKMSm, sView.GetFocusedRowCellValue(colBKMS));
            dView.SetFocusedRowCellValue(colTAGSm, sView.GetFocusedRowCellValue(colTAGS));
            dView.SetFocusedRowCellValue(colMBRSm, sView.GetFocusedRowCellValue(colMBRS));

            dView.SetFocusedRowCellValue(colSUBJECTm, sView.GetFocusedRowCellValue(colSUBJECT));
            dView.SetFocusedRowCellValue(colMSJm, "");

            dView.UpdateCurrentRow();

        }
        private void jrnMdfylayoutView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colBKMDm)
            {
                StringBuilder bkms = new StringBuilder();
                bkms.Append(jrnMdfylayoutView.GetRowCellDisplayText(e.RowHandle, colBKMSm));
                if ((bool)e.Value == true)
                {
                    if (!bkms.ToString().Contains(Program.USRtag))
                    {
                        if (bkms.Length > 0)
                            bkms.Append(", ");
                        bkms.Append(Program.USRtag);
                    }
                }
                else
                {
                    bkms.Replace(", " + Program.USRtag, "");
                    bkms.Replace(Program.USRtag, "");
                }
                jrnMdfylayoutView.SetRowCellValue(e.RowHandle, colBKMSm, bkms.ToString());
            }

        }

        private void jrnNewLayoutView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colBKMDn)
            {
                StringBuilder bkms = new StringBuilder();
                bkms.Append(jrnNewLayoutView.GetRowCellDisplayText(e.RowHandle, colBKMSn));
                if ((bool)e.Value == true)
                {
                    if (!bkms.ToString().Contains(Program.USRtag))
                    {
                        if (bkms.Length > 0)
                            bkms.Append(", ");
                        bkms.Append(Program.USRtag);
                    }
                }
                else
                {
                    bkms.Replace(", " + Program.USRtag, "");
                    bkms.Replace(Program.USRtag, "");
                }
                jrnNewLayoutView.SetRowCellValue(e.RowHandle, colBKMSm, bkms.ToString());
            }
        }

        private void dockManager_Expanding(object sender, DockPanelCancelEventArgs e)
        {
            if (e.Panel == mdfyDockPanel && !jrnGridView.IsDataRow(jrnGridView.FocusedRowHandle))
                e.Cancel = true;

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //jrnGridView.PreviewFieldName = "JOURNAL";
            //jrnGridView.OptionsView.AutoCalcPreviewLineCount = true;
            //jrnGridView.OptionsView.ShowPreview = true;
            //jrnGridView.OptionsPrint.PrintPreview = true;

            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = jrnGridControl;
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;
            // Subscribe to the CreateReportHeaderArea event used to generate the report header. 
            //link.CreateMarginalHeaderArea += link_CreateMarginalHeaderArea;
            //link.CreateMarginalFooterArea += link_CreateMarginalFooterArea;
            link.CreateDocument();
            link.ShowPreview();

        }

        private void layoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = jrnGridView;
            frm.ShowDialog();
            frm.Dispose();

        }

        private void previewBodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jrnGridView.OptionsView.ShowPreview = previewBodyToolStripMenuItem.Checked;

            if (jrnGridView.OptionsView.ShowPreview)
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            else
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            exportToolStripMenuItem.Enabled = Program.MF.EntryCheck("Jurnal.jrnXF.Export", true);
        }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace tMax14.Traxon
{
    public partial class Trx2XF : DevExpress.XtraEditors.XtraForm
    {
        public int mID = 0;

        public struct MyStruct
        {
            public string REFNO, ACK, ERR, MSGID;
        }

        public Trx2XF()
        {
            InitializeComponent();
        }

        private void Trx2XF_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void fill()
        {
            try
            {
                string iQry = "1=1";
                if (mID != 0)
                    iQry = string.Format("MID = {0}", mID);

                this.tRX3TableAdapter.Fill(this.traxonDataSet.TRX3, iQry);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getProc();
        }

        private void getProc()
        {
            Cursor = Cursors.WaitCursor;

            string[] directoryList = GetDirectoryListFromServer();
            int lngth = directoryList.Length;

            progressBarControl.Properties.Step = 1;
            progressBarControl.Properties.Maximum = lngth;

            for (int i = 0; i < directoryList.Length; i++)
            {
                string fileName = directoryList[i];

                //this.Text = string.Format("[ReadFile] : {0}/{1} {2}", i + 1, lngth, fileName);

                string fileContent = ReadFileFromServer(fileName);

                ParseFileContent(fileName, fileContent);

                progressBarControl.PerformStep();
                progressBarControl.Update();
                
            }

            Cursor = Cursors.Default;
            fill();
        }

        private string[] GetDirectoryListFromServer()
        {
            string[] separators = { "\r\n" };

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://ftp.champ.aero/out");
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            //request.Credentials = new NetworkCredential("TsTstw", "T89sm77v");
            request.Credentials = new NetworkCredential(Program.smtp_TRAXON_USER_NAME, Program.smtp_TRAXON_USER_PASSWORD);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string fileNames = reader.ReadToEnd();

            string[] directoryList = fileNames.Split(separators, StringSplitOptions.RemoveEmptyEntries);


            //MessageBox.Show("Directory List Complete, status {0}", response.StatusDescription);

            reader.Close();
            response.Close();

            // fileName'in sonu tarih fileName_yyyyaaggssddmmss.msg
            // Tarihe gore sil, Eskiden yeniye
            Array.Sort(directoryList, (p, q) => {
                return p.Substring(p.IndexOf('_')).CompareTo(q.Substring(q.IndexOf('_')));
            });

            return directoryList;
        }

        private string ReadFileFromServer(string fileName)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://ftp.champ.aero/" + fileName);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            //request.Credentials = new NetworkCredential("TsTstw", "T89sm77v");
            request.Credentials = new NetworkCredential(Program.smtp_TRAXON_USER_NAME, Program.smtp_TRAXON_USER_PASSWORD);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            string fileContent = reader.ReadToEnd();

            //MessageBox.Show("Download Complete, status {0}", response.StatusDescription);

            reader.Close();
            response.Close();

            return fileContent;
        }

        public MyStruct ParseFMA(string fileName, string[] lines)
        {
            // FMA: Acknowledgement
            MyStruct R = new MyStruct();
            R.MSGID = "FMA";
            
            int line = 1;
            R.ACK = lines[line++].Substring(4);  // ACK/.....

            R.ERR = "";
            while (lines[line].StartsWith("/ "))    // Errors
                R.ERR += lines[line++];

            while (lines[line].StartsWith("/"))     // Varsa onlari da gec
                line++;

            // Sonraki FHL veya FWB olacak
            if (lines[line].StartsWith("FHL/"))
                R.REFNO = lines[++line].Substring(4, 12);   // MBI/refno
            else if (lines[line].StartsWith("FWB/"))
                R.REFNO = lines[++line].Substring(0, 12);   // refno(123-56789012)

            return R;
        }

        public MyStruct ParseFSU14(string fileName, string[] lines)
        {
            // FSU/14: StatuUpdate
            MyStruct R = new MyStruct();
            R.MSGID = "FSU14";

            int line = 1;
            R.REFNO = lines[line].Substring(0, 12);   // refno(123-56789012)

            return R;
        }

        public MyStruct ParseFNA1(string fileName, string[] lines)
        {
            // FNA/1: Rejected
            MyStruct R = new MyStruct();
            R.MSGID = "FNA1";
            /*
                ACK/AWB REJECTED
                /SPH0155
                FWB/16
                020-57735182SEAJED/T2K3
            */

            int line = 1;
            R.ACK = lines[line++].Substring(4);  // ACK/.....

            R.ERR = "";
            while (lines[line].StartsWith("/"))
                R.ERR += lines[line++];   

            if (lines[line].StartsWith("FWB/"))
                R.REFNO = lines[++line].Substring(0, 12);   // refno(123-56789012)

            return R;
        }

        public void ParseFileContent(string fileName, string fileContent)
        {
            int i = 0;
            fileContent = fileContent.Replace("\r", "");    // bazi satirlarda sadece \n olabiliyor

/*
            string[] lines = Regex.Split(fileContent, "\n");
//            string[] lines = Regex.Split(fileContent, "\r\n");

            MyStruct R = new MyStruct();

            if (lines[0].EndsWith("FNA/1"))
                R = ParseFNA1(fileName, lines);
            else if (lines[0].EndsWith("FSU/14"))
                R = ParseFSU14(fileName, lines);
            else if (lines[0].EndsWith("FMA"))
                R = ParseFMA(fileName, lines);
*/
//            Match mMsgID = Regex.Match(fileContent, @"\'FNA/1|FSU/14|FMA\n");
            Match mMsgID = Regex.Match(fileContent, @"\'F.+\n");    // Ilk satirin sonuda tirnak+F ile baslayip \n ile biten
            Match mRefNo = Regex.Match(fileContent, @"\d\d\d-\d\d\d\d\d\d\d\d");

            //string msg = mMsgID.Value;
            string refNo = mRefNo.Value;
            string msgID = mMsgID.Value.Replace("'", "").Replace("\n", "").Replace("/", "");

//            if (!string.IsNullOrEmpty(R.REFNO) && R.REFNO[3] == '-')

            if (!string.IsNullOrEmpty(refNo) && refNo[3] == '-')
            {
                int si = fileName.IndexOf('_');
                int ei = fileName.IndexOf('.');
                string fts = fileName.Substring(si + 1, ei - si);  //fileTimeStamp yyyyMMddHHmmSS 
                DateTime EXD = new DateTime(Convert.ToInt32(fts.Substring(0, 4)),
                                            Convert.ToInt32(fts.Substring(4, 2)),
                                            Convert.ToInt32(fts.Substring(6, 2)),
                                            Convert.ToInt32(fts.Substring(8, 2)),
                                            Convert.ToInt32(fts.Substring(10, 2)),
                                            Convert.ToInt32(fts.Substring(12, 2)));

                fileContent = fileContent.Replace("\n", "\r\n");
                traxonQueriesTableAdapter.TRX3_APND(refNo, EXD, msgID, fileContent);
//                traxonQueriesTableAdapter.TRX3_APND(R.REFNO, EXD, R.MSGID, R.ACK, R.ERR, fileContent);

                DeleteFileFromServer(fileName);
            }
        }

        public void DeleteFileFromServer(string fileName)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://ftp.champ.aero/" + fileName);
            request.Method = WebRequestMethods.Ftp.DeleteFile;
            //request.Credentials = new NetworkCredential("TsTstw", "T89sm77v");
            request.Credentials = new NetworkCredential(Program.smtp_TRAXON_USER_NAME, Program.smtp_TRAXON_USER_PASSWORD);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            response.Close();
        }

        //-------------------------------------------------------------        

        private void putToolStripMenuItem_Click(object sender, EventArgs e)
        {
            putProc();
        }

        private void putProc()
        {
            // Deneme UpladFileToServer("sener.tmp", "SENER");
            if (mID == 0)
            {
                XtraMessageBox.Show("Master'dan gelinmeli", "Traxon AWB/AHL gönderilemez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.traxonDataSet.TRX3.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Bu master daha önce gönderilmiş\nÖnceki mesajlar silinecek ve yenisi gönderilecek", "Traxon AWB/AHL gönderimi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                    return;
            }
            
            string HATA = traxonQueriesTableAdapter.TRX3_CHECK(mID).ToString();
            if (!string.IsNullOrEmpty(HATA))
            {
                XtraMessageBox.Show(HATA, "Traxon AWB/AHL gönderilemez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.trX3_FWB16TableAdapter1.Fill(this.traxonDataSet.TRX3_FWB16, mID);
                string fileName = string.Format("FWB_{0}.tmp", mID);
                UpladFileToServer(fileName, this.traxonDataSet.TRX3_FWB16[0].FWB);

                this.trX3_FHL4TableAdapter1.Fill(this.traxonDataSet.TRX3_FHL4, mID);
                
                for (int i = 0; i < this.traxonDataSet.TRX3_FHL4.Rows.Count; i++)
                {
                    fileName = string.Format("FHL_{0}_{1}.tmp", mID, i);
                    UpladFileToServer(fileName, this.traxonDataSet.TRX3_FHL4[i].FHL);
                }

                traxonQueriesTableAdapter.TRX3_INS(mID, Program.USR);    // FBL+FHLs

                fill();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Traxon AWB/AHL gönderilemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;

        }

        private void UpladFileToServer(string fileName, string fileContent)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://ftp.champ.aero/in/" + fileName);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            //request.Credentials = new NetworkCredential("TsTstw", "T89sm77v");
            request.Credentials = new NetworkCredential(Program.smtp_TRAXON_USER_NAME, Program.smtp_TRAXON_USER_PASSWORD);

            byte[] byteBuffer = Encoding.ASCII.GetBytes(fileContent);
            request.ContentLength = byteBuffer.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(byteBuffer, 0, byteBuffer.Length);
            requestStream.Close();

            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                this.Text = string.Format("Upload File Complete, status {0}", response.StatusDescription);
                response.Close();

                RenameFileOnServer(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void RenameFileOnServer(string fileName)
        {
            // Change Extension to "msg"
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://ftp.champ.aero/in/" + fileName);
            request.Method = WebRequestMethods.Ftp.Rename;
            //request.Credentials = new NetworkCredential("TsTstw", "T89sm77v");
            request.Credentials = new NetworkCredential(Program.smtp_TRAXON_USER_NAME, Program.smtp_TRAXON_USER_PASSWORD);

            string newFileName = fileName.Replace(".tmp", ".msg");
            request.RenameTo = newFileName;
            request.GetResponse();

        }

    }
}
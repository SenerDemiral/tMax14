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

namespace tMax14.Doc
{
    public partial class DocXF : DevExpress.XtraEditors.XtraForm
    {
        public string RefTbl = "", AltTbl = "";
        public int RefID = 0, AltID = 0;
        public string RefInfo;
        public bool Editable = true;

        string docDir = @"C:\SOS\DOCs";

        public DocXF()
        {
            InitializeComponent();

            docGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTAGS.ColumnEdit = Program.MF.TAGselDOCrepositoryItemCheckedComboBoxEdit;
            colDET.ColumnEdit = Program.MF.DOCdetRepositoryItemLookUpEdit;
            colMBRS.ColumnEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;
            colPRVT.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            System.IO.Directory.CreateDirectory(docDir);
        }

        public void Save()
        {
            this.Validate();
            this.docBindingSource.EndEdit();
            this.docTableAdapter.Update(this.docDataSet.DOC);
        }

        private void DocXF_Load(object sender, EventArgs e)
        {
            docGridView.OptionsBehavior.Editable = Editable;
            yeniToolStripMenuItem.Enabled = Editable;

            Qry.qsDocXF frm = new Qry.qsDocXF();
            frm.DOC = docDataSet.DOC;
            frm.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(frm);

            docGridView.FormatConditions[0].Expression = string.Format("Contains([BKMS], '{0}')", Program.USRtag);
            
            if (!string.IsNullOrEmpty(RefTbl))
            {
                this.Text = RefInfo + " Attachments";
                //colREFTBL.Visible = false;
                //colREFID.Visible = false;
                if (RefTbl == "FRT")
                {
                    string refIDs = docQueriesTableAdapter.FRT_SEL_HDQ_LIST(RefID).ToString();
                    this.docTableAdapter.Fill(this.docDataSet.DOC, string.Format("(RefTbl = '{0}' and RefID in ({1})) or (AltTbl = '{0}' and AltID in ({1}))", RefTbl, refIDs));
                }
                else if (RefTbl == "OPM")
                {
                    string ophIDs = docQueriesTableAdapter.OPM_HOUSE_LIST(RefID).ToString();
                    this.docTableAdapter.Fill(this.docDataSet.DOC, string.Format("(RefTbl = 'OPM' and RefID = {0}) or (RefTbl = 'OPH' and RefID in ({1}))", RefID, ophIDs));
                }
                else
                    this.docTableAdapter.Fill(this.docDataSet.DOC, string.Format("RefTbl = '{0}' and RefID = {1}", RefTbl, RefID));
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
            Doc.selDetXF frm = new selDetXF();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                docGridView.AddNewRow();
                docGridView.SetFocusedRowCellValue(colDET, frm.DET);
                uploadDialog(); // Call
                if (docGridView.GetFocusedRowCellValue(colTYP) == DBNull.Value)
                    docGridView.DeleteRow(docGridView.FocusedRowHandle);
            }
        }

        private void docGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            object docID = docQueriesTableAdapter.GET_PK("DOC");
            if (docID == DBNull.Value)
            {
                // Sleep 500msec
                System.Threading.Thread.Sleep(500);
                docID = docQueriesTableAdapter.GET_PK("DOC");
            }

            docGridView.SetRowCellValue(e.RowHandle, colDOCID, docID);
            docGridView.SetRowCellValue(e.RowHandle, colREFTBL, RefTbl);
            docGridView.SetRowCellValue(e.RowHandle, colREFID, RefID);
            docGridView.SetRowCellValue(e.RowHandle, colINSUSR, Program.USR);
            if (AltID != 0)
            {
                docGridView.SetRowCellValue(e.RowHandle, colALTTBL, AltTbl);
                docGridView.SetRowCellValue(e.RowHandle, colALTID, AltID);
            }
        }

        private void docGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (docDataSet.HasChanges())
                Save();
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uploadDialog();
        }

        private void uploadDialog()
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Upload(openFileDialog.FileName);
            }
        }

        private void Upload(string fullFileName)
        {
            if (File.Exists(fullFileName))
            {
                int docID = (int)docGridView.GetFocusedRowCellValue(colDOCID);

                string fileName = Path.GetFileNameWithoutExtension(fullFileName);
                string fileExt = Path.GetExtension(fullFileName);

                docGridView.SetFocusedRowCellValue(colAD, fileName);
                docGridView.SetFocusedRowCellValue(colTYP, fileExt);

                Save();

                UploadFile(docID, fullFileName);
            }
        }

        private void UploadFile(int docID, string fileName)
        {
            if (fileName.GetType() != typeof(DBNull))
            {
                try
                {
                    FileStream fs = new FileStream((string)fileName, FileMode.Open, FileAccess.Read);
                    byte[] img = new byte[fs.Length];
                    int len = System.Convert.ToInt32(fs.Length);
                    fs.Read(img, 0, len);
                    fs.Close();
                    docQueriesTableAdapter.DOC_UPD_BLB(docID, img);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docGridView.GetFocusedRowCellValue(colTYP) != DBNull.Value && docGridView.GetFocusedRowCellValue(colTYP).ToString() != ".")
            {
                int docID = (int)docGridView.GetFocusedRowCellValue(colDOCID);
                string fullfileName = docDir + @"\" + docGridView.GetFocusedRowCellValue(colAD).ToString() + docGridView.GetFocusedRowCellValue(colTYP).ToString();

                if (downLoadFile(docID, fullfileName))
                {
                    DateTime fileCreatedDate = File.GetCreationTime(fullfileName);      // Eklenme Tarihi
                    DateTime fileModified = File.GetLastWriteTime(fullfileName);        // Acilma Tarihi
                    //Text = fileCreatedDate.ToString() + "  " + fileModified.ToString();

                    var proc = System.Diagnostics.Process.Start(fullfileName);
                }
            }
        }

        private bool downLoadFile(int docID, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            byte[] img = new byte[0];
            img = (byte[])docQueriesTableAdapter.DOC_SEL_BLB(docID, Program.USR);
            if (img != null)
            {
                int ArraySize = new int();
                ArraySize = img.GetLength(0);
                fs.Write(img, 0, ArraySize);
                fs.Close();
                return true;
            }
            return false;
        }

        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BKMS = docGridView.GetFocusedRowCellValue(colBKMS).ToString();
            // Toggle 
            if (BKMS.Contains(Program.USRtag))   // Varsa cikar
            {
                BKMS = BKMS.Replace(Program.USRtag, "");
                docGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                docGridView.UpdateCurrentRow();
            }
            else                        // Yoksa ekle
            {
                BKMS += Program.USRtag;
                docGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                docGridView.UpdateCurrentRow();
            }
            Save();
        }

        private void DocXF_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (FileInfo f in new DirectoryInfo(docDir).GetFiles("*.*"))
            {
                try
                {
                    f.Delete();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void DocXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !this.Validate();
            Save();
        }

        private void docGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (docGridView.GetRowCellValue(e.RowHandle, colDET) == DBNull.Value)
            {
                e.ErrorText = "DET girilmemiş";
                e.Valid = false;
            }
        }

        private void docGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            var view = docGridView;
            if (view.GetFocusedRowCellValue(colINSUSR) == DBNull.Value)
                return;

            var fc = view.FocusedColumn;
            if ((fc == colMBRS || fc == colPRVT) && view.GetFocusedRowCellDisplayText(colINSUSR) != Program.USR)
                e.Cancel = true;
        }

        private void DocXF_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void DocXF_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                string fileExt = Path.GetExtension(file);

                if (fileExt != ".exe" && fileExt != ".dll")
                {
                    docGridView.AddNewRow();
                    docGridView.SetFocusedRowCellValue(colDET, "GNL");

                    if (docGridView.GetFocusedRowCellValue(colDOCID) == DBNull.Value)
                    {
                        docGridView.CancelUpdateCurrentRow();
                        // Sleep 500msec
                        System.Threading.Thread.Sleep(500);
                        docGridView.AddNewRow();
                        docGridView.SetFocusedRowCellValue(colDET, "GNL");
                    }

                    if (docGridView.GetFocusedRowCellValue(colDOCID) != DBNull.Value)
                    {
                        int docID = (int)docGridView.GetFocusedRowCellValue(colDOCID);

                        docGridView.SetFocusedRowCellValue(colAD, fileName);
                        docGridView.SetFocusedRowCellValue(colTYP, fileExt);

                        Save();

                        UploadFile(docID, file);
                    }
                }
            }
        }

        private void deleteADMNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.USR == "ADMN" && docGridView.IsDataRow(docGridView.FocusedRowHandle))
            {
                if (XtraMessageBox.Show("Delete record", "Attachment", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    docGridView.DeleteRow(docGridView.FocusedRowHandle);
                    docTableAdapter.Update(docDataSet.DOC);
                }
            }

        }

        private void saveToDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docGridView.GetFocusedRowCellValue(colTYP) != DBNull.Value && docGridView.GetFocusedRowCellValue(colTYP).ToString() != ".")
            {
                int docID = (int)docGridView.GetFocusedRowCellValue(colDOCID);
                string fullfileName = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\" + docGridView.GetFocusedRowCellValue(colAD).ToString() + docGridView.GetFocusedRowCellValue(colTYP).ToString();

                downLoadFile(docID, fullfileName);
            }
        }
    }
}
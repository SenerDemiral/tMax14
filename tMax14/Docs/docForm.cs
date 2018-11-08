using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using System.IO;
using DevExpress.XtraTreeList.Nodes.Operations;

namespace tMax14.Docs
{
    public partial class docForm : DevExpress.XtraEditors.XtraUserControl//DevExpress.XtraEditors.XtraForm
    {
        Font prFont;
        string usrBkm;
        string docDir = @"C:\SOS\DOCs";
        int refIdRoot = 0;
        public string refTbl = string.Empty;
        public int refId = 0;
        TreeListBookmarkOperation operation;

        public docForm()
        {
            InitializeComponent();

            usrBkm = "<" + Program.USTid.ToString() + ">";

            operation = new TreeListBookmarkOperation(usrBkm);
            docTreeList.ForceInitialize();
            searchTAGrepositoryItemTextEdit.Mask.EditMask = Program.MF.TAGmultiRepositoryItemTextEdit.Mask.EditMask;
        }

        public void NewId(int id)
        {
            if (id == 0)        // Belirsiz
            {
                this.docsDataSet.DOC.Clear();
                docTreeList.Enabled = false;
                return;
            }
            docTreeList.Enabled = true;
            refId = id;
            refIdRoot = 0;
            if (!string.IsNullOrWhiteSpace(refTbl))
            {
                refIdRoot = (int)docsQueriesTableAdapter.DOC_REF_ROOT(refTbl, refId);
                FillByQRY("");
            }
            if (this.Parent.Parent is DevExpress.XtraBars.Docking.DockPanel)
            {
                DevExpress.XtraBars.Docking.DockPanel panel = (DevExpress.XtraBars.Docking.DockPanel)this.Parent.Parent;
                panel.Text = "Attachments " + refTbl + "/" + refId.ToString();
            }
        }

        private void docForm_Load(object sender, EventArgs e)
        {
            // Panele eklendiginde cagrilmiyor, Show edilince cagriliyor..
            this.docTreeList.OptionsBehavior.AllowIncrementalSearch = true;
            this.docTreeList.OptionsBehavior.AutoFocusNewNode = true;
            this.docTreeList.OptionsBehavior.DragNodes = true;
            this.docTreeList.OptionsBehavior.EnableFiltering = true;
            this.docTreeList.OptionsBehavior.EnterMovesNextColumn = true;
            this.docTreeList.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
            this.docTreeList.OptionsBehavior.ImmediateEditor = false;
            this.docTreeList.OptionsBehavior.PopulateServiceColumns = true;
            this.docTreeList.OptionsBehavior.UseTabKey = true;
            this.docTreeList.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.docTreeList.OptionsFilter.ShowAllValuesInFilterPopup = true;
            this.docTreeList.OptionsFind.AllowFindPanel = true;
            this.docTreeList.OptionsFind.FindFilterColumns = "NAME;TAG";
            this.docTreeList.OptionsView.EnableAppearanceEvenRow = true;
            this.docTreeList.OptionsView.ShowSummaryFooter = true;

            prFont = new Font(docTreeList.Appearance.FocusedRow.Font, FontStyle.Bold);
            Directory.CreateDirectory(docDir);

            docTreeList.ExternalRepository = Program.MF.mainPersistentRepository;
            //colTAG.ColumnEdit = Program.MF.TAGmultiRepositoryItemTextEdit;
            colTAG.ColumnEdit = Program.MF.TAGselDOCrepositoryItemCheckedComboBoxEdit;

            colEXD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;


            //refTbl = "FRT";
            //refId = 15;
            refIdRoot = 0;
            if (!string.IsNullOrWhiteSpace(refTbl))
            {
                refIdRoot = (int)docsQueriesTableAdapter.DOC_REF_ROOT(refTbl, refId);
                FillByQRY("");
            }
        }

        private void Fill()
        {
        }

        private void FillByQRY(string TAG)
        {
            // TODO: This line of code loads data into the 'docManDataSet.DOC' table. You can move, or remove it, as needed.
            //this.docTableAdapter.FillByTAG(this.docManDataSet.DOC, TAG);

            string BKM = "";
            if (bookmarkedBarCheckItem.Checked)
                BKM = "<" + Program.USTid.ToString() + ">";

            this.docTableAdapter.FillByQRY(this.docsDataSet.DOC, refTbl, refId, TAG, BKM);

            docTreeList.NodesIterator.DoOperation(operation);
        }

        private void Save()
        {
            this.Validate();
            this.docBindingSource.EndEdit();
            this.docTableAdapter.Update(this.docsDataSet.DOC);
        }

        private void docForm_Leave(object sender, EventArgs e)
        {
            Save();
        }

        private int AddNode(int prDocId)
        {
            // prDocId = 0:Add2Root

            //if (docTreeList.FocusedNode.Level == 0 && prDocId != 0)
            //    return -1;

            if (refIdRoot == 0)      // Dogrudan docForm a gelmis ise
            {
                if (prDocId == 0)
                    return -1;
                if (docTreeList.FocusedNode[colTYP] != DBNull.Value)
                    return -1;      // Type Null olmadikca acamaz
            }
            else
            {

           // if (prDocId == 0 && (Convert.ToInt32(docTreeList.FocusedNode[colDOCID]) < 0 || docTreeList.FocusedNode[colPRID] == DBNull.Value || Convert.ToInt32(docTreeList.FocusedNode[colPRID]) < 0))
           //     return -1;
           // if (prDocId != 0 && Convert.ToInt32(docTreeList.FocusedNode[colDOCID]) < 0)
           //     return -1;
           // if (docTreeList.FocusedNode[colTYP] != DBNull.Value)
           //     return -1;
            }
            DocsDataSet.DOCRow docRow = docsDataSet.DOC.NewDOCRow();
            docRow.DOCID = (int)docsQueriesTableAdapter.GET_PK("DOC");
            docRow.REFTBL = refTbl;
            docRow.REFID = refId;
            if (prDocId != 0)
            {
                docRow.PRID = prDocId;
                //docRow.NAME = "Child " + docRow.DOCID.ToString() + " / " + prDocId.ToString();
            }
            else
            {
                if( refIdRoot != 0)
                    docRow.PRID = refIdRoot;
                //docRow.NAME = "Parent " + docRow.DOCID.ToString();
            }
            
            this.docsDataSet.DOC.AddDOCRow(docRow);

            return docRow.DOCID;
        }
 
        private void docTreeList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                TreeListHitInfo ht = docTreeList.CalcHitInfo(new Point(e.X, e.Y));
                if (ht != null && ht.Node != null)
                    docTreeList.FocusedNode = ht.Node;
            }
        }

        private void docTreeList_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            if (e.Node.HasChildren && e.Column == colNAME)
                e.Appearance.Font = prFont; //new Font(e.Appearance.Font, FontStyle.Bold);
        }

        private void docTreeList_DragOver(object sender, DragEventArgs e)
        {
            TreeList tl = sender as TreeList;
            Point p = tl.PointToClient(new Point(e.X, e.Y));
            //Text = tl.CalcHitInfo(p).HitInfoType.ToString();

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (docTreeList.AllNodesCount == 0)
                    e.Effect = DragDropEffects.All;
                else if (tl.CalcHitInfo(p).HitInfoType != HitInfoType.Cell)
                    e.Effect = DragDropEffects.All;
                else
                {
                    TreeListNode targetNode = tl.CalcHitInfo(p).Node;
                    if (targetNode[colTYP] != DBNull.Value)
                        e.Effect = DragDropEffects.None;
                    else
                        e.Effect = DragDropEffects.All;
                }
            }
            else if (e.Data.GetDataPresent(typeof(TreeListNode)))
            {
                if (tl.CalcHitInfo(p).HitInfoType != HitInfoType.Cell)
                    e.Effect = DragDropEffects.None;
                else 
                { 
                    TreeListNode targetNode = tl.CalcHitInfo(p).Node;
                    if (targetNode != null && targetNode[colTYP] != DBNull.Value)
                        e.Effect = DragDropEffects.None;
                    else
                        e.Effect = DragDropEffects.All;
                }
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void docTreeList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void docTreeList_DragDrop(object sender, DragEventArgs e)
        {
            TreeListNode targetNode;
            TreeList tl = sender as TreeList;
            Point p = tl.PointToClient(new Point(e.X, e.Y));
            targetNode = tl.CalcHitInfo(p).Node;

            if (e.Data.GetDataPresent(typeof(TreeListNode)))    // Drag data TreeList ise birak kendisi yapsin
                return;

            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < s.Length; i++)
            {
                if ((e.KeyState & 4) == 4 || docTreeList.AllNodesCount == 0 || targetNode == null)  // Shift, Bos
                {
                    AddNode(0);     //RootNode
                }
                else
                {
                    int prId = (int)targetNode.GetValue(colDOCID);
                    int docId = AddNode(prId);
                }
                Upload(s[i]);
            }
        }

        private void uploadOpenFile()
        {
            if (docTreeList.AllNodesCount == 0 || docTreeList.FocusedNode.HasChildren || docTreeList.FocusedNode[colTYP] != DBNull.Value)
            {
                XtraMessageBox.Show("Bu Noda Dosya ekleyemezsiniz");
                return;
            }

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Upload(openFileDialog.FileName);
            }
        }

        private void Upload(string fullFileName)
        {
            if (File.Exists(fullFileName))
            {
                int docId = (int)docTreeList.FocusedNode.GetValue(colDOCID);
                string fileName = Path.GetFileNameWithoutExtension(fullFileName);
                string fileExt = Path.GetExtension(fullFileName);

                docTreeList.FocusedNode.SetValue(colNAME, fileName);
                docTreeList.FocusedNode.SetValue(colTYP, fileExt);
                
                Save();

                UploadFile(docId, fullFileName);
            }
        }

        private void UploadFile(int docId, string fileName)
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
                    docsQueriesTableAdapter.DOC_BLB_UPD(docId, img, len);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void downLoadFile(int docId, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            byte[] img = new byte[0];
            img = (byte[])docsQueriesTableAdapter.DOC_BLB_SEL(docId);
            int ArraySize = new int();
            ArraySize = img.GetLength(0);
            fs.Write(img, 0, ArraySize);
            fs.Close();
        }

        private void openFile()
        {
            if (docTreeList.FocusedNode.GetValue(colTYP) != DBNull.Value && docTreeList.FocusedNode.GetValue(colTYP).ToString() != "." )
            {
                int docId = (int)docTreeList.FocusedNode.GetValue(colDOCID);
                string fullfileName = docDir + @"\" + docTreeList.FocusedNode.GetValue(colNAME).ToString() + docTreeList.FocusedNode.GetValue(colTYP).ToString();

                downLoadFile(docId, fullfileName);

                DateTime fileCreatedDate = File.GetCreationTime(fullfileName);      // Eklenme Tarihi
                DateTime fileModified = File.GetLastWriteTime(fullfileName);        // Acilma Tarihi
                //Text = fileCreatedDate.ToString() + "  " + fileModified.ToString();

                var proc = System.Diagnostics.Process.Start(fullfileName);
            }
        }

        private void uploadModifiedCopy()
        {
            // Focused Node Open edilmisise (docDir de Varsa) ve Degistirilmisse
            if (docTreeList.FocusedNode.GetValue(colTYP) != DBNull.Value)
            {
                //int docId = (int)docTreeList.FocusedNode.GetValue(colDOCID);
                string fullfileName = docDir + @"\" + docTreeList.FocusedNode.GetValue(colNAME).ToString() + docTreeList.FocusedNode.GetValue(colTYP).ToString();

                if (File.Exists(fullfileName))
                {
                    if (docTreeList.FocusedNode.Level == 0)
                        AddNode(0);     //RootNode
                    else
                        AddNode((int)docTreeList.FocusedNode.ParentNode.GetValue(colDOCID));

                    Upload(fullfileName);
                }
            }
        }

        #region ContextMenu

        private void addRootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNode(0);
        }

        private void addChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docTreeList.Nodes.Count == 0)
                AddNode(0);
            else
            {
                if (docTreeList.FocusedNode[colTYP] != DBNull.Value)
                {
                    XtraMessageBox.Show("Bu Noda Child node ekleyemezsiniz", "Document Attachments");
                    return;
                }

                int prDocId = (int)docTreeList.FocusedNode.GetValue(colDOCID);
                AddNode(prDocId);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docTreeList.ExpandAll();
        }

        private void expandChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docTreeList.FocusedNode.ExpandAll();
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docTreeList.CollapseAll();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docTreeList.ExpandAll();
            docTreeList.ShowFindPanel();
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uploadOpenFile();
        }

        private void uploadModifiedCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uploadModifiedCopy();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        #endregion ContextMenu

        private void searchTAGrepositoryItemTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string value;
                if ((barManager.ActiveEditor as DevExpress.XtraEditors.TextEdit).EditValue == null)
                    value = "";
                else
                    value = (barManager.ActiveEditor as DevExpress.XtraEditors.TextEdit).EditValue.ToString();

                FillByQRY(value);
                
                docTreeList.ExpandAll();
                e.Handled = true;
            }
        }

        private void docTreeList_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(docTreeList.FocusedNode[colDOCID]) < 0 || 
                docTreeList.FocusedNode[colPRID] == DBNull.Value ||
                (Convert.ToInt32(docTreeList.FocusedNode[colPRID]) < 0 && Convert.ToInt32(docTreeList.FocusedNode[colPRID]) > -90)) // Help ve Others icin izin ver
                e.Cancel = true;
        }

        private void bookmarkedBarCheckItem_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bookmarkedBarCheckItem.Checked)
                bookmarkedBarCheckItem.Caption = "Bookmarked only";
            else
                bookmarkedBarCheckItem.Caption = "No Bookmark";
        }

        private void docTreeList_AfterCheckNode(object sender, NodeEventArgs e)
        {
            if (e.Node.Checked)
                e.Node[colBKM] += usrBkm;
            else
                e.Node[colBKM] = e.Node[colBKM].ToString().Replace(usrBkm, "");
        }

        private void docTreeList_BeforeCheckNode(object sender, CheckNodeEventArgs e)
        {
            if (e.Node[colTYP] != DBNull.Value) 
                e.CanCheck = true;
            else
                e.CanCheck = false;
        }

        private void docTreeList_StateChanged(object sender, EventArgs e)
        {
            //if (this.docsDataSet.HasChanges())
            //    ;// barStaticItem1.ImageIndex = 2;
        }

    }

    public class TreeListBookmarkOperation : TreeListOperation
    {
        string usrBkm;
        public TreeListBookmarkOperation(string usrBkm)
        {
            this.usrBkm = usrBkm;
        }
        // incrementing the counter if the node's value exceeds the limit
        public override void Execute(TreeListNode node)
        {
            string bkms = Convert.ToString(node["BKM"]);
            if (bkms.Contains(usrBkm))
                node.Checked = true;
        }
    }

    public class TreeListExceedLimitOperation : TreeListOperation
    {
        private string fieldName;
        private int upperLimit;
        private int result;

        public TreeListExceedLimitOperation(string fieldName, int upperLimit)
        {
            this.fieldName = fieldName;
            this.upperLimit = upperLimit;
            result = 0;
        }
        // incrementing the counter if the node's value exceeds the limit
        public override void Execute(TreeListNode node)
        {
            string bkms = Convert.ToString(node["BKM"]);
            if (bkms.Contains(" -1 "))
                node.Checked = true;
            //int nodeValue = Convert.ToInt32(node[fieldName]);
            //if (nodeValue > upperLimit)
            //    result++;
        }
        public int Result
        {
            get { return result; }
        }
    }
}
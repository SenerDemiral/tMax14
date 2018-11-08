using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.SmallTalk
{
    public partial class stSelInUC : DevExpress.XtraEditors.XtraUserControl
    {
        DateTime SonOkuTrh = new DateTime(2000, 1, 1, 0, 0, 0);
        string qStu = "O";  //Opens
        string usrBKM;

        public stSelInUC()
        {
            InitializeComponent();

            usrBKM= "<" + Program.USTid.ToString() + ">";


            stSelInGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colOUSRID.ColumnEdit = Program.MF.ustRepositoryItemLookUpEdit;
            colMUSRID.ColumnEdit = Program.MF.ustRepositoryItemLookUpEdit;
            colSTRID.ColumnEdit = Program.MF.strRepositoryItemLookUpEdit;
            colCAT.ColumnEdit = Program.MF.stCatRepositoryItemLookUpEdit;
        }

        private void stSelInUserControl_Load(object sender, EventArgs e)
        {
            fill();
            this.stSelInTableAdapter.ClearBeforeFill = false;
        }

        private void fill()
        {
            int nor = this.stSelInTableAdapter.Fill(this.smallTalkDataSet.ST_SEL_IN, Program.USTid, qStu, SonOkuTrh);
            statusBarStaticItem.Caption = SonOkuTrh.ToString("HH:mm:ss") + " den sonra " + nor.ToString() + " Adet yeni mesajınız var";
            SonOkuTrh = Convert.ToDateTime(smallTalkQueriesTableAdapter.GET_SERVERTIME());
            stSelInGridView.ExpandAllGroups();
            if (!timer1.Enabled && qStu == "O")
                timer1.Enabled = true;
        }

        #region ContextMenu

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            konuyaMesajEkleToolStripMenuItem.Enabled = true;
            konuyuKapaToolStripMenuItem.Enabled = true;
            konuyuIptalToolStripMenuItem.Enabled = true;

            if (!stSelInGridView.IsDataRow(stSelInGridView.FocusedRowHandle) || stSelInGridView.GetFocusedRowCellValue(colSTU).ToString() != "O")
            {
                konuyaMesajEkleToolStripMenuItem.Enabled = false;
                konuyuKapaToolStripMenuItem.Enabled = false;
                konuyuIptalToolStripMenuItem.Enabled = false;
            }
        }

        private void yeniKonuAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stNewForm frm = new stNewForm("New");
            frm.STid = 0;
            frm.ShowDialog();
            fill();
        }

        private void konuyaMesajEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stNewForm frm = new stNewForm("Append");
            frm.STid = (int)stSelInGridView.GetFocusedRowCellValue(colSTID);
            frm.ShowDialog();
            fill();
        }

        private void konuyuKapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stNewForm frm = new stNewForm("Close");
            frm.STid = (int)stSelInGridView.GetFocusedRowCellValue(colSTID);
            frm.ShowDialog();
            fill();
        }

        private void konuyuIptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stNewForm frm = new stNewForm("Cancel");
            frm.STid = (int)stSelInGridView.GetFocusedRowCellValue(colSTID);
            frm.ShowDialog();
            fill();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stuOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qStu = "O";
            stuCancelledToolStripMenuItem.Checked = false;
            stuClosedToolStripMenuItem.Checked = false;
            fill();
        }

        private void stuCancelledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qStu = "X";
            stuOpenToolStripMenuItem.Checked = false;
            stuClosedToolStripMenuItem.Checked = false;
            fill();
        }

        private void stuClosedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qStu = "C";
            stuCancelledToolStripMenuItem.Checked = false;
            stuOpenToolStripMenuItem.Checked = false;
            fill();
        }

        #endregion ContextMenu


        private void stSelGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            // Gidenler Okundu yapilamaz
            //if (stSelGridView.GetFocusedRowCellValue("YON").ToString() == "O")
            //    e.Cancel = true;
        }

        private void TAGbuttonEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string TAG = stSelInGridView.GetFocusedRowCellValue(colTAG).ToString();
            int PK = Convert.ToInt32(stSelInGridView.GetFocusedRowCellValue(colSTID));
            
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                TAG += "<" + TAGbuttonEdit.Text + ">";
                stSelInGridView.SetFocusedRowCellValue(colTAG, TAG);

            }
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)
            {
                MessageBox.Show("Del " + TAGbuttonEdit.Text);
                string[] sa = TAGbuttonEdit.Text.Split('>');
                for (int i = 0; i < sa.Length; i++)
                {
                    TAG = TAG.Replace(sa[i]+">", "");
                }
                stSelInGridView.SetFocusedRowCellValue(colTAG, TAG);
            }
            stSelInGridView.UpdateCurrentRow();
            smallTalkQueriesTableAdapter.ST_UPD(PK, stSelInGridView.GetFocusedRowCellValue(colTAG).ToString(), stSelInGridView.GetFocusedRowCellValue(colBKM).ToString());
        }

        private void addBKMsimpleButton_Click(object sender, EventArgs e)
        {
            string BKM = stSelInGridView.GetFocusedRowCellValue(colBKM).ToString();

            if (!BKM.Contains(usrBKM))
            {
                int PK = Convert.ToInt32(stSelInGridView.GetFocusedRowCellValue(colSTID));
                BKM += usrBKM;
                stSelInGridView.SetFocusedRowCellValue(colBKM, BKM);
                stSelInGridView.UpdateCurrentRow();
                smallTalkQueriesTableAdapter.ST_UPD(PK, stSelInGridView.GetFocusedRowCellValue(colTAG).ToString(), stSelInGridView.GetFocusedRowCellValue(colBKM).ToString());
            }
        }

        private void delBKMsimpleButton_Click(object sender, EventArgs e)
        {
            string BKM = stSelInGridView.GetFocusedRowCellValue(colBKM).ToString();

            if (BKM.Contains(usrBKM))
            {
                BKM = BKM.Replace(usrBKM, "");
                stSelInGridView.SetFocusedRowCellValue(colBKM, BKM);
                stSelInGridView.UpdateCurrentRow();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fill();
        }

        private void tagGirisiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}

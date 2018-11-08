using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Genel
{
    public partial class uytXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public uytXUC()
        {
            InitializeComponent();
        }

        private void uYTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void uytXUC_Load(object sender, EventArgs e)
        {
            uytTableAdapter.Fill(this.mainDataSet.UYT);
            uuyTableAdapter.Fill(this.mainDataSet.UUY);
            
            uytGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colUSRS.ColumnEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;
            colCN.ColumnEdit = Program.MF.YTKrepositoryItemCheckedComboBoxEdit;
        }

        Char[] sc = new Char[] { ',' };
        
        private void fullChildNodes()
        {
            for (int i = 0; i < mainDataSet.UYT.Rows.Count; i++)
                mainDataSet.UYT.Rows[i]["FCN"] = "";

            string CN;
            for (int i = 0; i < mainDataSet.UYT.Rows.Count; i++)
            {
                CN = mainDataSet.UYT.Rows[i]["CN"].ToString();
                if (!string.IsNullOrWhiteSpace(CN))
                    mainDataSet.UYT.Rows[i]["FCN"] = string.Format(",{0},", childTara(CN));  // Kendisini ekleme
            }
        }

        private string childTara(string CN)
        {
            StringBuilder YtkS = new StringBuilder();
            int c = 0;
/*           
            List<string> srcList = CN.Replace(" ", "").Split(sc).ToList();
            for (int i = 0; i < srcList.Count; i++)
            {
                if (YtkS.Length > 0)
                    YtkS.Append(",");
                YtkS.Append(srcList[i]);

                MainDataSet.UYTRow zRow = mainDataSet.UYT.FindByYTK(srcList[i]);
                if (zRow != null && !zRow.IsCNNull())
                {
                    var dstList = zRow.CN.Replace(" ","").Split(sc).ToList();
                    for (int k = 0; k < dstList.Count; k++)
                    {
                        if (!string.IsNullOrWhiteSpace(dstList[k]) && !srcList.Contains(dstList[k]))
                            YtkS.Append("," + dstList[k]);
                    }
                }
            }
            return YtkS.ToString();            
*/            
            CN = CN.Replace(" ", "");
            YtkS.Append(CN);
            do
            {
                c = 0;
                string[] cYtkA = CN.Split(sc);
                foreach (string cYtk in cYtkA)
                {
                    MainDataSet.UYTRow zRow = mainDataSet.UYT.FindByYTK(cYtk);
                    if (zRow != null && !zRow.IsCNNull())
                    {
                        string[] zYtkA = zRow.CN.Replace(" ","").Split(sc);
                        foreach (string zYtk in zYtkA)
                        {
                            //if (!sb.ToString().Contains("<"+s2+">"))
                            if (zYtk.Length > 1 && !(","+YtkS.ToString()+",").Contains(","+zYtk+","))
                            {
                                YtkS.Append(string.Format(",{0}", zYtk));
                                c++;
                            }
                        }
                    }
                }
                CN = YtkS.ToString();
            } while (c > 0);

            return YtkS.ToString();
        }

        private void fullParentNodes()
        {
            for (int i = 0; i < mainDataSet.UYT.Rows.Count; i++)
                mainDataSet.UYT.Rows[i]["FPN"] = "";

            StringBuilder sb = new StringBuilder();
            string YTK;
            for (int i = 0; i < mainDataSet.UYT.Rows.Count; i++)
            {
                sb.Clear();
                YTK = "," + mainDataSet.UYT.Rows[i]["YTK"].ToString().Trim() + ",";
                for (int j = 0; j < mainDataSet.UYT.Rows.Count; j++)
                {
                    string CN = "," + mainDataSet.UYT.Rows[j]["CN"].ToString().Replace(" ", "") + ",";
                    if (CN.Contains(YTK))
                    {
                        if (sb.Length > 0)
                            sb.Append(",");
                        sb.Append(mainDataSet.UYT.Rows[j]["YTK"]);
                    }
                }
                if (sb.Length == 0)
                    mainDataSet.UYT.Rows[i]["PN"] = "";
                else
                    mainDataSet.UYT.Rows[i]["PN"] = sb.ToString();
            }

            string PN;
            for (int i = 0; i < mainDataSet.UYT.Rows.Count; i++)
            {
                PN = mainDataSet.UYT.Rows[i]["PN"].ToString();
                if (!string.IsNullOrWhiteSpace(PN))
                    mainDataSet.UYT.Rows[i]["FPN"] = "," + parentTara(PN) + ",";
            }

        }

        private string parentTara(string CN)
        {
            StringBuilder sb = new StringBuilder();
            int c = 0;
            sb.Append(CN);
            do
            {
                c = 0;
                string[] sa = CN.Split(sc);
                foreach (string s in sa)
                {
                    MainDataSet.UYTRow zRow = mainDataSet.UYT.FindByYTK(s);
                    if (!string.IsNullOrWhiteSpace(zRow.PN))
                    {
                        string[] sa2 = zRow.PN.Split(sc);
                        foreach (string s2 in sa2)
                        {
                            if (!sb.ToString().Contains("," + s2 + ","))
                            {
                                sb.Append("," + s2);
                                c++;
                            }
                        }
                    }
                }
                CN = sb.ToString();
            } while (c > 0);

            return CN;
        }

        private void checkNodes()
        {
            string YTK;
            for (int i = 0; i < mainDataSet.UYT.Rows.Count; i++)
            {
                YTK = mainDataSet.UYT.Rows[i]["YTK"].ToString().Trim();
                string FCN = mainDataSet.UYT.Rows[i]["FCN"].ToString();
                mainDataSet.UYT.Rows[i].RowError = "";
                if (FCN.Contains(YTK))
                    mainDataSet.UYT.Rows[i].RowError = "HATA";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkNodes();
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fullChildNodes();
            fullParentNodes();
            //checkNodes();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainDataSet.HasChanges())
            {
                /*
                fullChildNodes();
                fullParentNodes();
                checkNodes();
                if (mainDataSet.HasErrors)
                {
                    XtraMessageBox.Show("HATA var kaydedemezsiniz!", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                userYetkileri();*/
                this.Validate();
                this.uytBindingSource.EndEdit();
                this.uytTableAdapter.Update(this.mainDataSet.UYT);
                this.uuyTableAdapter.Update(this.mainDataSet.UUY);
            }
        }

        private void userYetkileri()
        {
            mainQueriesTableAdapter.UUY_DELETEALL();

            mainDataSet.UUY.Clear();

            for (int i = 0; i < mainDataSet.UYT.Rows.Count; i++)
            {
                string USRS = mainDataSet.UYT.Rows[i]["USRS"].ToString().Replace(" ", "");
                string YTK = mainDataSet.UYT.Rows[i]["YTK"].ToString();
                string FCN = mainDataSet.UYT.Rows[i]["FCN"].ToString();
                if (string.IsNullOrWhiteSpace(FCN))
                    FCN = "," + YTK + ",";
                else
                    FCN = "," + YTK + FCN;

                string FPN = mainDataSet.UYT.Rows[i]["FPN"].ToString();
                if (!string.IsNullOrWhiteSpace(USRS))
                {
                    StringBuilder sb = new StringBuilder();
                    string[] usrs = USRS.Split(sc);
                    foreach (string usr in usrs)
                    {
                        if (mainDataSet.UUY.FindByUSRYTK(usr, YTK) == null)
                        {
                            var newRow = mainDataSet.UUY.NewUUYRow();
                            newRow.USR = usr;
                            newRow.YTK = YTK;
                            newRow.FCN = FCN;
                            newRow.FPN = FPN;
                            mainDataSet.UUY.AddUUYRow(newRow);
                        }
                    }
                }
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userYetkileri();
        }

        private void yetkiCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string curYTK = uytGridView.GetFocusedRowCellDisplayText(colYTK);
            bool OK = Program.MF.YetkiCheck(curYTK);
            MessageBox.Show(string.Format("curUSR: {0},  curYTK: {1},  Yetkili?: {2}", Program.USR, curYTK, OK));

            Genel.onayXF frm = new onayXF();
            frm.curYTK = curYTK;
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}

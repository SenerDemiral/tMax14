using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System.Reflection;
using DevExpress.XtraTreeList.Nodes;
using System.Diagnostics;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors.Controls;
using System.IO;

namespace tMax14
{
    public partial class mainForm : DevExpress.XtraEditors.XtraForm
    {
        public DataView stCatDW, strDW;

        public mainForm()
        {
            InitializeComponent();

            userBarStaticItem.Caption = Program.USTad + " [" + Program.USTid.ToString() + "]";

            versionBarStaticItem.Caption = "tMax14 v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                versionBarStaticItem.Caption = "tMax14 v" + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }

//            initLookups();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            mnuUsrTableAdapter.Fill(this.mainDataSet.MNU_USR, Program.USTid);

        }

        public void QSsave(string layoutName, int idx, DataTable dt)
        {
            System.IO.StringWriter writer = new System.IO.StringWriter();
            dt.WriteXml(writer, XmlWriteMode.IgnoreSchema, false);
            mainQueriesTableAdapter.XGL_SET(Program.USR, layoutName, idx, writer.ToString());
        }

        public void QSrestore(string layoutName, int idx, DataTable dt)
        {
            dt.Clear();
            string text = (string)mainQueriesTableAdapter.XGL_GET(Program.USR, layoutName, idx);
            if (!string.IsNullOrEmpty(text))
            {
                System.IO.StringReader reader = new System.IO.StringReader(text);
                dt.ReadXml(reader);
                dt.AcceptChanges();
            }
        }

        public void XGLsave(string layoutName, int idx, object sender)
        {
            dynamic view = sender;
            Stream str = new System.IO.MemoryStream();
            view.SaveLayoutToStream(str);
            str.Seek(0, System.IO.SeekOrigin.Begin);
            StreamReader reader = new StreamReader(str);
            mainQueriesTableAdapter.XGL_SET(Program.USR, layoutName, idx, reader.ReadToEnd());
        }

        public void XGLrestore(string layoutName, int idx, object sender)
        {
            dynamic view = sender;
            string text = (string)mainQueriesTableAdapter.XGL_GET(Program.USR, layoutName, idx);
            if (!string.IsNullOrEmpty(text))
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(text);
                MemoryStream stream = new MemoryStream(byteArray);
                view.RestoreLayoutFromStream(stream);
                stream.Close();
            }
        }
        
        #region Lookups

        private void initLookups()
        {
            DataView frtTurDW = new DataView(this.mainDataSet.XGT, "GRP = 'FRT.TUR' and ID <> '+'", "ID", DataViewRowState.CurrentRows);
            frtTurRepositoryItemLookUpEdit.DataSource = frtTurDW;
            frtTurRepositoryItemCheckedComboBoxEdit.DataSource = frtTurDW;

            DataView frtFlyDW = new DataView(this.mainDataSet.XGT, "GRP = 'FRT.FLY' and ID <> '+'", "ID", DataViewRowState.CurrentRows);
            frtFlyRepositoryItemCheckedComboBoxEdit.DataSource = frtFlyDW;

            DataView frtIlsDW = new DataView(this.mainDataSet.XGT, "GRP = 'FRT.ILS' and ID <> '+'", "ID", DataViewRowState.CurrentRows);
            frtIlsRepositoryItemCheckedComboBoxEdit.DataSource = frtIlsDW;

            DataView frtGrpDW = new DataView(this.mainDataSet.XGT, "GRP = 'FRT.GRP' and ID <> '+'", "ID", DataViewRowState.CurrentRows);
            frtGrpRepositoryItemCheckedComboBoxEdit.DataSource = frtGrpDW;

            DataView frtSrcTypDW = new DataView(this.mainDataSet.XGT, "GRP = 'FRT.KYN' and ID <> '+'", "ID", DataViewRowState.CurrentRows);
            frtSrcTypRepositoryItemLookUpEdit.DataSource = frtSrcTypDW;

            DataView uspFrmDW = new DataView(this.mainDataSet.XGT, "GRP = 'USP.FRM' and ID <> '+'", "ID", DataViewRowState.CurrentRows);
            uspFrmRepositoryItemLookUpEdit.DataSource = uspFrmDW;

            DataView usiTurDW = new DataView(this.mainDataSet.XGT, "GRP = 'USI.TUR' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            usiTurRepositoryItemLookUpEdit.DataSource = usiTurDW;

            DataView ustDrmDW = new DataView(this.mainDataSet.XGT, "GRP = 'UST.DRM' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            ustDrmRepositoryItemLookUpEdit.DataSource = ustDrmDW;

            DataView isYerDW = new DataView(this.mainDataSet.XGT, "GRP = 'ISYER' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            isYerRepositoryItemLookUpEdit.DataSource = isYerDW;

            DataView krySvyDW = new DataView(this.mainDataSet.XGT, "GRP = 'KRYSVY' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            krySvyRepositoryItemLookUpEdit.DataSource = krySvyDW;

            DataView clsGrpDW = new DataView(this.mainDataSet.XGT, "GRP = 'CLSGRP' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            clsGrpRepositoryItemLookUpEdit.DataSource = clsGrpDW;

            DataView dptDW = new DataView(this.mainDataSet.XGT, "GRP = 'DPT' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            dptRepositoryItemLookUpEdit.DataSource = dptDW;

            DataView sexDW = new DataView(this.mainDataSet.XGT, "GRP = 'SEX' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            sexRepositoryItemLookUpEdit.DataSource = sexDW;

            DataView kanGrpDW = new DataView(this.mainDataSet.XGT, "GRP = 'KANGRP' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            kanGrpRepositoryItemLookUpEdit.DataSource = kanGrpDW;

            stCatDW = new DataView(this.mainDataSet.XGT, "GRP = 'ST.CAT' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            stCatRepositoryItemLookUpEdit.DataSource = stCatDW;


            DataView RotDW = new DataView(this.mainDataSet.XGT, "GRP = 'ROT' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            ROTrepositoryItemLookUpEdit.DataSource = RotDW;
            ROTrepositoryItemCheckedComboBoxEdit.DataSource = RotDW;

            DataView MotDW = new DataView(this.mainDataSet.XGT, "GRP = 'MOT' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            MOTrepositoryItemLookUpEdit.DataSource = MotDW;
            MOTrepositoryItemCheckedComboBoxEdit.DataSource = MotDW;

            DataView DtmDW = new DataView(this.mainDataSet.XGT, "GRP = 'OPS.DTM' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            DTMrepositoryItemLookUpEdit.DataSource = DtmDW;
            DataView DtpDW = new DataView(this.mainDataSet.XGT, "GRP = 'OPS.DTP' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            DTPrepositoryItemLookUpEdit.DataSource = DtpDW;
            DataView PtmDW = new DataView(this.mainDataSet.XGT, "GRP = 'OPS.PTM' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            PTMrepositoryItemLookUpEdit.DataSource = PtmDW;
            DataView TovDW = new DataView(this.mainDataSet.XGT, "GRP = 'OPS.TOV' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            TOVrepositoryItemLookUpEdit.DataSource = TovDW;
            DataView TolDW = new DataView(this.mainDataSet.XGT, "GRP = 'OPS.TOL' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            TOLrepositoryItemLookUpEdit.DataSource = TolDW;
            //DataView TopDW = new DataView(this.mainDataSet.XGT, "GRP = 'OPS.TOP' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            //TOPrepositoryItemLookUpEdit.DataSource = TopDW;
            DataView TobDW = new DataView(this.mainDataSet.XGT, "GRP = 'OPS.TOB' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            TOBrepositoryItemLookUpEdit.DataSource = TobDW;
            DataView PagDW = new DataView(this.mainDataSet.XGT, "GRP = 'OPS.PAG' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            PAGrepositoryItemLookUpEdit.DataSource = PagDW;
            DataView TosDW = new DataView(this.mainDataSet.XGT, "GRP = 'OPS.TOS' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            TOSrepositoryItemLookUpEdit.DataSource = TosDW;
            DataView TocDW = new DataView(this.mainDataSet.XGT, "GRP = 'OPS.TOC' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            TOCrepositoryItemLookUpEdit.DataSource = TocDW;
            DataView SovDW = new DataView(this.mainDataSet.XGT, "GRP = 'OPS.SOV' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            SOVrepositoryItemLookUpEdit.DataSource = SovDW;
            DataView PorDW = new DataView(this.mainDataSet.XGT, "GRP = 'OPS.POR' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            PORrepositoryItemLookUpEdit.DataSource = PorDW;

            DataView PrtTurDW = new DataView(this.mainDataSet.XGT, "GRP = 'PRT.TUR' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            prtTurRepositoryItemLookUpEdit.DataSource = PrtTurDW;

            DataView DOCdetDW = new DataView(this.mainDataSet.XGT, "GRP = 'DOC.DET' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            DOCdetRepositoryItemLookUpEdit.DataSource = DOCdetDW;

            DataView AFDbrmDW = new DataView(this.mainDataSet.XGT, "GRP = 'AFD.BRM' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);
            AFDbrmRepositoryItemLookUpEdit.DataSource = AFDbrmDW;

            // Depo TAG sablonunu ve parametrelerini al
            DataView tagDpoDW = new DataView(this.mainDataSet.XGT, "GRP = 'TAG.DPO' and ID <> '+'", "VAL", DataViewRowState.CurrentRows);

            DataView TAGselDOCdw = new DataView(this.mainDataSet.XTG, "TBL = 'DOC'", "TAG", DataViewRowState.CurrentRows);
            TAGselDOCrepositoryItemCheckedComboBoxEdit.DataSource = TAGselDOCdw;
            DataView TAGselFRTdw = new DataView(this.mainDataSet.XTG, "TBL = 'FRT'", "TAG", DataViewRowState.CurrentRows);
            TAGselFRTrepositoryItemCheckedComboBoxEdit.DataSource = TAGselFRTdw;
            DataView TAGselJRNdw = new DataView(this.mainDataSet.XTG, "TBL = 'JRN'", "TAG", DataViewRowState.CurrentRows);
            TAGselJRNrepositoryItemCheckedComboBoxEdit.DataSource = TAGselJRNdw;
            DataView TAGselOPSdw = new DataView(this.mainDataSet.XTG, "TBL = 'OPS'", "TAG", DataViewRowState.CurrentRows);
            TAGselOPSrepositoryItemCheckedComboBoxEdit.DataSource = TAGselOPSdw;
            DataView TAGselAFBdw = new DataView(this.mainDataSet.XTG, "TBL = 'AFB'", "TAG", DataViewRowState.CurrentRows);
            TAGselAFBrepositoryItemCheckedComboBoxEdit.DataSource = TAGselAFBdw;
            DataView TAGselTBdw = new DataView(this.mainDataSet.XTG, "TBL = 'TB'", "TAG", DataViewRowState.CurrentRows);
            TAGselTBrepositoryItemCheckedComboBoxEdit.DataSource = TAGselTBdw;

            DataView OpsStuNrmdw = new DataView(this.mainDataSet.OPST, "NP = 'N'", "STU", DataViewRowState.CurrentRows);
            OpsStuNrmRepositoryItemLookUpEdit.DataSource = OpsStuNrmdw;
            OpsStuNrmRepositoryItemCheckedComboBoxEdit.DataSource = OpsStuNrmdw;
            DataView OpsStuPrbdw = new DataView(this.mainDataSet.OPST, "NP = 'P'", "STU", DataViewRowState.CurrentRows);
            OpsStuPrbRepositoryItemLookUpEdit.DataSource = OpsStuPrbdw;
            OpsStuPrbRepositoryItemCheckedComboBoxEdit.DataSource = OpsStuPrbdw;
            /*
            string tagMask = tagDpoDW[0].Row["VAL"].ToString(); // Ilk kayit (Id='-') Value da Sablon, sonrakilerde parametreler var
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < tagDpoDW.Count; i++)
            {
                if (i > 1)
                    sb.Append("|");
                sb.Append(tagDpoDW[i].Row["ID"].ToString());
            }
            tagMask = tagMask.Replace("@", sb.ToString());
            TagDepoRepositoryItemTextEdit.Mask.EditMask = tagMask;
            */

            DataView AHTopsdw = new DataView(this.mainDataSet.AHT, "TUR like 'O%'", "AD", DataViewRowState.CurrentRows);
            AHTopsRepositoryItemLookUpEdit.DataSource = AHTopsdw;

            DataView AHPdtydw = new DataView(this.mainDataSet.AHP, "DTY = 'T'", "HSPAD", DataViewRowState.CurrentRows);
            AHPdtyRepositoryItemLookUpEdit.DataSource = AHPdtydw;

            DataView locCntryDW = new DataView(this.mainDataSet.LOC_LU_TREE, "ISNULL(PRID,'') = ''", "AD", DataViewRowState.CurrentRows);
            locPopupCntryLookUpEdit.Properties.DataSource = locCntryDW;
            CNTRYrepositoryItemCheckedComboBoxEdit.DataSource = locCntryDW;
            CNTRYrepositoryItemLookUpEdit.DataSource = locCntryDW;

        }

        public void FillTanimlar()
        {
            
            int nor = 0;
            System.Threading.Tasks.Task<int>.Factory.StartNew(() =>
            {
                startSW();
                //System.Threading.Thread.Sleep(10000);   //Test
                nor += ustTableAdapter.Fill(this.mainDataSet.UST);
                //nor += uspTableAdapter.Fill(this.mainDataSet.USP); USP_SEL_USR oldu -> Login
                nor += xgtTableAdapter.Fill(this.mainDataSet.XGT);
                nor += xtgTableAdapter.Fill(this.mainDataSet.XTG);
                nor += locLUtreeTableAdapter.Fill(this.mainDataSet.LOC_LU_TREE);
                //nor += ftTableAdapter.Fill(this.mainDataSet.FT);
                nor += frtTableAdapter.Fill(this.mainDataSet.FRT);      ///////////////////////////////////////////////////////////////////////
                nor += uytTableAdapter.Fill(this.mainDataSet.UYT);
                nor += uuyTableAdapter.Fill(this.mainDataSet.UUY);
                nor += ahtTableAdapter.Fill(this.mainDataSet.AHT);
                nor += rptTableAdapter.Fill(this.mainDataSet.RPT);
                nor += prtSelTableAdapter.Fill(this.mainDataSet.PRT_SEL);
                nor += dvtTableAdapter.Fill(this.mainDataSet.DVT);
                nor += opstTableAdapter.Fill(this.mainDataSet.OPST);
                nor += ahpTableAdapter.Fill(this.mainDataSet.AHP);
                nor += avbtTableAdapter.Fill(this.mainDataSet.AVBT);
                nor += otpTableAdapter.Fill(this.mainDataSet.OTP);
                nor += akmTableAdapter.Fill(this.mainDataSet.AKM);

                stopSW(string.Format("{0:N0} Tanım entries read in", nor));
                return nor;
            }).ContinueWith((t) =>
            {
                // Update UI thread
                //stopSW(string.Format("{0:N0} Tanım entries read in", t.Result));
                initLookups();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext()); 
        }
        /*
        public async void FillTanimlar()
        {
            // for .net4 install NuGet 'Microsoft.Bcl.Async'
            startSW();
            int nor = 0;
            //Her iki sekilde de OK
            //await DoWork(); // Fill Table
            //alertControl1.Show(this, "Background ops", "Tanımlar okunuyor");
            await System.Threading.Tasks.TaskEx.Run(() =>
            {
                //System.Threading.Thread.Sleep(30000);   //Test
                //mnuUsrTableAdapter.Fill(this.mainDataSet.MNU_USR, Program.USTid);
                //MessageBox.Show(Program.USTid.ToString());
                nor += ustTableAdapter.Fill(this.mainDataSet.UST);
                nor += uspTableAdapter.Fill(this.mainDataSet.USP);
                nor += xgtTableAdapter.Fill(this.mainDataSet.XGT);
                nor += xtgTableAdapter.Fill(this.mainDataSet.XTG);
                nor += locLUtreeTableAdapter.Fill(this.mainDataSet.LOC_LU_TREE);
                nor += strTableAdapter.Fill(this.mainDataSet.STR);
                nor += gtpTableAdapter.Fill(this.mainDataSet.GTP);
                //nor += ftTableAdapter.Fill(this.mainDataSet.FT);
                nor += frtTableAdapter.Fill(this.mainDataSet.FRT);      ///////////////////////////////////////////////////////////////////////
                nor += uytTableAdapter.Fill(this.mainDataSet.UYT);
                nor += uuyTableAdapter.Fill(this.mainDataSet.UUY);
                nor += ahtTableAdapter.Fill(this.mainDataSet.AHT);
                nor += rptTableAdapter.Fill(this.mainDataSet.RPT);

                stopSW(string.Format("{0:N0} Tanım entries read in", nor));
            });
            initLookups();
        }
        */

        private void locRepositoryItemSearchLookUpEdit_Popup(object sender, EventArgs e)
        {
            TextEdit editor = ((sender as DevExpress.Utils.Win.IPopupControl).PopupWindow.Controls[2].Controls[0].Controls[7] as TextEdit);
            editor.KeyPress += editor_KeyPress;
        }

        void editor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'i')
                e.KeyChar = 'I';
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        #endregion Lookups

        #region StopWatch

        Stopwatch stopWatch = new Stopwatch();

        public void startSW()
        {
            stopWatch.Restart();
        }

        public void stopSW(string info)
        {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string s = info + " " + String.Format("{0:N3} sec", ts.TotalSeconds);
            
            elapsedTimeBarStaticItem.Caption = s;
        }

        #endregion StopWatch

        #region Menu

        private void menuTreeList_MouseClick(object sender, MouseEventArgs e)
        {
            //return;
            //MessageBox.Show("2");
            TreeListHitInfo hi = menuTreeList.CalcHitInfo(new Point(e.X, e.Y));
            string elementName = hi.HitInfoType.ToString();
            if (hi.HitInfoType == DevExpress.XtraTreeList.HitInfoType.Cell)
            {
                //MessageBox.Show(elementName + "  " + menuTreeList.FocusedNode[treeListColumn1].ToString());
                if (menuTreeList.FocusedNode[colTYP].ToString() == "M")
                    menuTreeList.FocusedNode.ExpandAll();
                else
                    InvokeForm(menuTreeList.FocusedNode[colAD].ToString(), menuTreeList.FocusedNode[colFRM].ToString(), menuTreeList.FocusedNode[colTYP].ToString());
            }
        }

        public void InvokeForm(string frmText, string frmFullName, string typ)
        {
            // frmFullName NameSapace.Form
            // frmName case-Sensitive
            // parametre dogru olmayinca bulamiyor
            string frmName = frmFullName;
            int ip = frmFullName.IndexOf('.');
            if (ip >= 0)
                frmName = frmFullName.Substring(ip+1);

            try
            {
                if (!findShowForm(frmName))
                {
                    if (CanUserDo(frmFullName, "ENT", isSilent: false))
                    {
                        dynamic d = Activator.CreateInstance(Type.GetType("tMax14." + frmFullName, true, true));
                        if (typ == "D")
                            d.ShowDialog();
                        else
                        {
                            d.Show();

                            tabbedView.AddDocument(d);
                            tabbedView.ActiveDocument.Caption = frmText;
                            tabbedView.ActiveDocument.FloatSize = new Size(200, 300);
                            tabbedView.ActiveDocument.FloatLocation = new Point(100, 100);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ilgili Form bulunamadı " + ex.Message);
            }
        }

        public Boolean findShowForm(string frmName)
        {
            foreach (var doc in tabbedView.FloatDocuments)
            {
                //MessageBox.Show(doc.Control.Tag.ToString());
                //if (object.Equals(doc.Control.Tag, searchTag))
                if (frmName == doc.Control.Name)
                {
                    tabbedView.ActivateDocument(doc.Control);
                    return true;
                }
            }
            foreach (var doc in tabbedView.Documents)
            {
                //MessageBox.Show(doc.Control.Tag.ToString());
                //if (object.Equals(doc.Control.Tag, searchTag))
                if (frmName == doc.Control.Name)
                {
                    tabbedView.ActivateDocument(doc.Control);
                    return true;
                }
            }
            return false;
        }

        private void menuTreeList_MouseMove(object sender, MouseEventArgs e)
        {
            TreeList treelist = sender as DevExpress.XtraTreeList.TreeList;
            TreeListHitInfo info = treelist.CalcHitInfo(new Point(e.X, e.Y));
            HotTrackNode = info.HitInfoType == HitInfoType.Cell ? info.Node : null;
        }

        private void menuTreeList_MouseLeave(object sender, EventArgs e)
        {
            HotTrackNode = null;
        }

        private TreeListNode hotTrackNode = null;
        
        private TreeListNode HotTrackNode
        {
            get { return hotTrackNode; }
            set
            {
                if (hotTrackNode != value)
                {
                    TreeListNode prevHotTrackNode = hotTrackNode;
                    hotTrackNode = value;
                    if (menuTreeList.ActiveEditor != null)
                        menuTreeList.PostEditor();
                    menuTreeList.RefreshNode(prevHotTrackNode);
                    menuTreeList.RefreshNode(hotTrackNode);
                }
            }
        }

        private void menuTreeList_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            //if (!e.Node.HasChildren)
            //    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
            
            if (e.Node == HotTrackNode)
            {
                e.Appearance.Font = menuTreeList.Appearance.FocusedRow.Font;
                e.Appearance.BackColor = menuTreeList.Appearance.FocusedRow.BackColor;  //Color.Coral; //LightBlue;
                e.Appearance.ForeColor = menuTreeList.Appearance.FocusedRow.ForeColor; //Color.White;

            }
        }

        public void InvokeChildMethod(string caption, string invokeMethod)  //deneme
        {
            // Call invokeMethod of this Form
            Type t = this.GetType();
            if (t.GetMethod(invokeMethod, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic) != null)
            {
                t.InvokeMember(invokeMethod, BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.NonPublic, null, this, null);
            }
            else
                MessageBox.Show(caption + " işlemi tanımsız");
        }

        private void a1() //deneme
        {
            MessageBox.Show("a1 called");
            string asdf = "Form2";
            try
            {
                Type CAType = Type.GetType("DXWindowsApplication1." + asdf);
                object[] o = new object[2];
                o[0] = 1;
                o[1] = "sener";

                /*
                int[] numbers = new int[5] {1, 2, 3, 4, 5};
                string[] names = new string[3] {"Matt", "Joanne", "Robert"};

                You can omit the size of the array, like this:

                int[] numbers = new int[] {1, 2, 3, 4, 5};
                string[] names = new string[] {"Matt", "Joanne", "Robert"};

                You can also omit the new operator if an initializer is provided, like this:

                int[] numbers = {1, 2, 3, 4, 5};
                string[] names = {"Matt", "Joanne", "Robert"};
                */


                //Form nextForm2 = (Form)Activator.CreateInstance(CAType, o);
                Form nextForm2 = (Form)Activator.CreateInstance(CAType, new object[] { 1, "sener" });   // parametre dogru olmayinca bulmuyor
                nextForm2.Show();
                //nextForm2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ilgili Form bulunamadi\n" + ex.Message);
            }
        }

        #endregion Menu

        #region Global

        private void minimizeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void sizableBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sizableBarButtonItem.Down)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            
        }

        private void refreshBarButtonItem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FillTanimlar();
            //TestForm1 frm = new TestForm1();
            //tabbedView.AddDocument(frm);
            //frm.Show();
        }

        #endregion Global

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // IPTAL
            //Docs.docForm frm = new Docs.docForm();
            //frm.Show();
        }

        #region GridControlSettings

        public void GridControl_KeyUp(object sender, KeyEventArgs e)
        {
            var grid = sender as DevExpress.XtraGrid.GridControl;
            var view = (DevExpress.XtraGrid.Views.Grid.GridView)grid.FocusedView;
            //var aaa = grid.TopLevelControl; // Main
            //var bbb = grid.FindForm();      // UserControl bulmuyor
            // Insert yetkisi view.Editable ile Form da belirlenmis
            
            if (e.KeyCode == Keys.Insert && e.Alt)  // Duplicate Row
            {
                if (view.OptionsBehavior.ReadOnly || !view.OptionsBehavior.Editable)    // Insert de OnayCheck Yok
                {
                    XtraMessageBox.Show("İşlem yapamazsınız.!", "Ekle, Kopyala, Sil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DataRow curRow = view.GetFocusedDataRow();
                var curColumns = curRow.Table.Columns;
                view.AddNewRow();
                DataRow newRow = view.GetFocusedDataRow();
                for (int i = 0; i < curColumns.Count; i++)
                {
                    if (!curColumns[i].ReadOnly && !curColumns[i].Unique)
                    {
                        newRow[i] = curRow[i];
                    }
                }
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Insert && e.Control)      // Add NewRow
            {
                if (view.OptionsBehavior.ReadOnly || !view.OptionsBehavior.Editable)
                {
                    XtraMessageBox.Show("İşlem yapamazsınız.!", "Ekle, Kopyala, Sil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                view.AddNewRow();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Delete && e.Shift)        // Cancel Update
            {
                if (view.OptionsBehavior.ReadOnly || !view.OptionsBehavior.Editable)
                {
                    XtraMessageBox.Show("İşlem yapamazsınız.!", "Ekle, Kopyala, Sil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                view.CancelUpdateCurrentRow();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Delete && e.Control)      // Delete Row
            {
                if (view.OptionsBehavior.ReadOnly || !view.OptionsBehavior.Editable)
                {
                    XtraMessageBox.Show("İşlem yapamazsınız.!", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                var col = view.Columns.ColumnByFieldName("EDITABLE");
                if (col == null || view.GetFocusedRowCellValue(col).ToString() == "T")
                {
                    if (XtraMessageBox.Show("Bu kayıt ve varsa detayları silinecektir.!", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        view.DeleteRow(view.FocusedRowHandle);

                        Control parent = grid.Parent;
                        while (parent.GetType().BaseType != typeof(XtraForm) && parent.GetType().BaseType != typeof(XtraUserControl) && parent.GetType().BaseType != typeof(Form))
                            parent = parent.Parent;
                        dynamic frm = parent;
                        frm.Save(); // public Save() olmali
                        e.Handled = true;
                    }
                }
            }
        }

        void view_ShowingEditor(object sender, CancelEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            var col = view.Columns.ColumnByFieldName("EDITABLE");   //("ONYYTK");
            if (col != null)
                e.Cancel = view.GetFocusedRowCellValue(col).ToString() == "F" ? true : false;     //!YetkiCheck(view.GetFocusedRowCellDisplayText(col), true);
        }

        void view_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            var grid = view.GridControl;
            Control parent = grid.Parent;
            while (parent.GetType().BaseType != typeof(XtraForm) && parent.GetType().BaseType != typeof(XtraUserControl) && parent.GetType().BaseType != typeof(Form))
            {
                parent = parent.Parent;
            }
            dynamic frm = parent;//grid.Parent.Parent.Parent.Parent;
            frm.Save();
        }

        public void GridControlSettings(object sender)
        {
            if (sender is DevExpress.XtraGrid.GridControl)
            {
                var grid = sender as DevExpress.XtraGrid.GridControl;
                grid.KeyUp += GridControl_KeyUp;
                DevExpress.XtraGrid.Views.Grid.GridView mView = (DevExpress.XtraGrid.Views.Grid.GridView)grid.MainView;
                mView.OptionsView.ShowFooter = true;
                //mView.OptionsView.ShowGroupPanel = false;

                mView.RowUpdated += view_RowUpdated;
                mView.ShowingEditor += view_ShowingEditor;
                mView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
                //mView.Appearance.HorzLine.BackColor = System.Drawing.Color.WhiteSmoke;
                //mView.Appearance.HorzLine.Options.UseBackColor = true;
                //mView.Appearance.VertLine.BackColor = System.Drawing.Color.WhiteSmoke;
                //mView.Appearance.VertLine.Options.UseBackColor = true;

                if (mView.OptionsBehavior.Editable)
                    mView.OptionsBehavior.Editable = CanUserDo(grid.Tag.ToString(), "UPD", true);
                //mView.OptionsBehavior.Editable = CanUserDo(grid.DataSource.ToString(), "UPD", true);
                
                foreach (GridColumn col in mView.Columns)
                {
                    string aaaa = col.GetType().ToString();
                    string bbbb = col.ColumnType.ToString();
                    if (col.ColumnType.FullName == "System.Int32")
                    {
                        col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        col.DisplayFormat.FormatString = "n0";

                        if (!col.FieldName.EndsWith("ID"))
                        {
                            col.SummaryItem.FieldName = col.FieldName;
                            col.SummaryItem.DisplayFormat = "{0:n0}";
                            col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;

                            mView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, col.FieldName, col, "{0:n0}")});
                        }
                    }
                    else if (col.ColumnType.FullName == "System.Decimal")
                    {
                        if (col.DisplayFormat.FormatType == DevExpress.Utils.FormatType.None)
                        {
                            col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                            col.DisplayFormat.FormatString = "n2";

                            col.SummaryItem.FieldName = col.FieldName;
                            col.SummaryItem.DisplayFormat = "{0:n2}";
                            col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;

                            mView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                        new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, col.FieldName, col, "{0:n2}")});
                        }
                    }
                    else if (col.ColumnType.FullName == "System.DateTime")
                    {
                        col.OptionsColumn.FixedWidth = true;
                        col.Width = 80;
                    }

                    if (col.AbsoluteIndex == 0 && col.ColumnType.FullName == "System.Int32")
                    {
                        col.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
                        col.AppearanceCell.Options.UseBackColor = true;
                        col.OptionsColumn.AllowEdit = false;
                        col.OptionsColumn.AllowFocus = false;
                        col.OptionsColumn.FixedWidth = true;
                        col.Width = 60;

                        col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        col.DisplayFormat.FormatString = "n0";

                        col.SummaryItem.FieldName = col.FieldName;
                        col.SummaryItem.DisplayFormat = "{0:n0}";
                        col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;

                        mView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                        new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, col.FieldName, col, "{0:n0}")});
                    }
                }
            }
        }

        #endregion GridControlSettings


        #region Location PopupContainer

        private void locRepositoryItemPopupContainerEdit_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            e.Value = locPopupPortSearchLookUpEdit.EditValue; // locPopupPortTextEdit.EditValue;
        }

        private void locRepositoryItemPopupContainerEdit_QueryDisplayText(object sender, DevExpress.XtraEditors.Controls.QueryDisplayTextEventArgs e)
        {
            
            if (e.EditValue == null)// || string.IsNullOrEmpty(e.EditValue.ToString()))
                return;
            locPopupPortTextEdit.Text = e.EditValue.ToString();
            //locPopupPortSearchLookUpEdit.EditValue = locPopupPortTextEdit.EditValue; //e.EditValue.ToString();
            //locPopupCntryLookUpEdit.EditValue = e.EditValue.ToString().Substring(0, 2);
            MainDataSet.LOC_LU_TREERow row = mainDataSet.LOC_LU_TREE.FindByLOCID(e.EditValue.ToString());
            if (row != null)
            {

                e.DisplayText = row.LOCID + "/" + row.AD;
                if (!row.IsCNTRYNull())
                    e.DisplayText += "@" + row.CNTRY;
            }
        }

        private void locPopupPortSearchLookUpEdit_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal)
            {
                locPopupPortTextEdit.EditValue = e.Value;
                e.AcceptValue = true;
                SendKeys.Send("{F4}");  // Close locRepositoryItemPopupContainerEdit
            }
        }

        private void locRepositoryItemPopupContainerEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (locPopupPortTextEdit.EditValue == null || string.IsNullOrEmpty(locPopupPortTextEdit.Text))
                return;

            locPopupPortSearchLookUpEdit.EditValue = locPopupPortTextEdit.EditValue;
            locPopupCntryLookUpEdit.EditValue = locPopupPortTextEdit.EditValue.ToString().Substring(0, 2);
        }

        private void locPopupCntryLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            DataView locDW = new DataView(this.mainDataSet.LOC_LU_TREE, "PRID = '" + locPopupCntryLookUpEdit.EditValue.ToString() + "'", "LOCID", DataViewRowState.CurrentRows);
            locPopupPortSearchLookUpEdit.Properties.DataSource = locDW;
        }

        private void locRepositoryItemPopupContainerEdit_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            //locPopupPortTextEdit.EditValue = e.Value;

        }

        private void locPopupPortSearchLookUpEdit_QueryCloseUp(object sender, CancelEventArgs e)
        {

        }

        #endregion Location PopupContainer


        // ORNEK kullanilmiyor
        private void TAGselRepositoryItemCheckedComboBoxEdit_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // ORNEK kullanilmiyor
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                CheckedComboBoxEdit edit = (sender as CheckedComboBoxEdit);
                DevExpress.XtraGrid.GridControl grid = (DevExpress.XtraGrid.GridControl)edit.Parent;

                Control parent = edit.Parent;
                while (parent.GetType().BaseType != typeof(XtraForm) && parent.GetType().BaseType != typeof(XtraUserControl) && parent.GetType().BaseType != typeof(Form))
                {
                    parent = parent.Parent;
                }
                dynamic senderForm = parent;

                dynamic p2 = (sender as CheckedComboBoxEdit).Parent;
                grid.MainView.CloseEditor();
                
                // New TAG form
                Genel.newTagXF frm = new Genel.newTagXF();
                frm.newTbl = senderForm.Tag.ToString();
                frm.ShowDialog();
                string newTag = frm.newTag;
                frm.Dispose();
                
                TAGselRepositoryItemCheckedComboBoxEdit.GetItems();
                

                grid.MainView.ShowEditor();

                if (!edit.EditValue.ToString().Contains(newTag))
                {
                    if (!string.IsNullOrEmpty(edit.Text))
                        edit.EditValue += ", ";
                    edit.EditValue += newTag;
                }
            }
        }

        private void TAGselDOCrepositoryItemCheckedComboBoxEdit_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                dynamic prntCntrl;
                
                CheckedComboBoxEdit edit = (sender as CheckedComboBoxEdit);
                if (edit.Parent is DevExpress.XtraGrid.GridControl)
                    prntCntrl = (edit.Parent as DevExpress.XtraGrid.GridControl).MainView;
                else if (edit.Parent is DevExpress.XtraTreeList.TreeList)
                    prntCntrl = (edit.Parent as DevExpress.XtraTreeList.TreeList);
                else
                    return;

                prntCntrl.CloseEditor();

                // New TAG form
                Genel.newTagXF frm = new Genel.newTagXF();
                frm.newTbl = "DOC";
                frm.ShowDialog();
                string newTag = frm.newTag;
                frm.Dispose();

                TAGselDOCrepositoryItemCheckedComboBoxEdit.GetItems();

                prntCntrl.ShowEditor();

                if (!edit.EditValue.ToString().Contains(newTag))
                {
                    if (!string.IsNullOrEmpty(edit.Text))
                        edit.EditValue += ", ";
                    edit.EditValue += newTag;
                }
            }
        }

        private void TAGselFRTRepositoryItemCheckedComboBoxEdit_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                CheckedComboBoxEdit edit = (sender as CheckedComboBoxEdit);
                DevExpress.XtraGrid.GridControl grid = (DevExpress.XtraGrid.GridControl)edit.Parent;

                grid.MainView.CloseEditor();

                // New TAG form
                Genel.newTagXF frm = new Genel.newTagXF();
                frm.newTbl = "FRT";
                frm.ShowDialog();
                string newTag = frm.newTag;
                frm.Dispose();

                TAGselFRTrepositoryItemCheckedComboBoxEdit.GetItems();

                grid.MainView.ShowEditor();

                if (!edit.EditValue.ToString().Contains(newTag))
                {
                    if (!string.IsNullOrEmpty(edit.Text))
                        edit.EditValue += ", ";
                    edit.EditValue += newTag;
                }
            }
        }

        private void TAGselJRNrepositoryItemCheckedComboBoxEdit_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                CheckedComboBoxEdit edit = (sender as CheckedComboBoxEdit);
                DevExpress.XtraGrid.GridControl grid = (DevExpress.XtraGrid.GridControl)edit.Parent;

                grid.MainView.CloseEditor();

                // New TAG form
                Genel.newTagXF frm = new Genel.newTagXF();
                frm.newTbl = "JRN";
                frm.ShowDialog();
                string newTag = frm.newTag;
                frm.Dispose();

                TAGselJRNrepositoryItemCheckedComboBoxEdit.GetItems();

                grid.MainView.ShowEditor();

                if (!edit.EditValue.ToString().Contains(newTag))
                {
                    if (!string.IsNullOrEmpty(edit.Text))
                        edit.EditValue += ", ";
                    edit.EditValue += newTag;
                }
            }
        }

        private void TAGselOPSrepositoryItemCheckedComboBoxEdit_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                CheckedComboBoxEdit edit = (sender as CheckedComboBoxEdit);
                DevExpress.XtraGrid.GridControl grid = (DevExpress.XtraGrid.GridControl)edit.Parent;

                grid.MainView.CloseEditor();

                // New TAG form
                Genel.newTagXF frm = new Genel.newTagXF();
                frm.newTbl = "OPS";
                frm.ShowDialog();
                string newTag = frm.newTag;
                frm.Dispose();

                TAGselOPSrepositoryItemCheckedComboBoxEdit.GetItems();

                grid.MainView.ShowEditor();

                if (!edit.EditValue.ToString().Contains(newTag))
                {
                    if (!string.IsNullOrEmpty(edit.Text))
                        edit.EditValue += ", ";
                    edit.EditValue += newTag;
                }
            }
        }

        private void TAGselAFBrepositoryItemCheckedComboBoxEdit_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                CheckedComboBoxEdit edit = (sender as CheckedComboBoxEdit);
                DevExpress.XtraGrid.GridControl grid = (DevExpress.XtraGrid.GridControl)edit.Parent;

                grid.MainView.CloseEditor();

                // New TAG form
                Genel.newTagXF frm = new Genel.newTagXF();
                frm.newTbl = "AFB";
                frm.ShowDialog();
                string newTag = frm.newTag;
                frm.Dispose();

                TAGselAFBrepositoryItemCheckedComboBoxEdit.GetItems();

                grid.MainView.ShowEditor();

                if (!edit.EditValue.ToString().Contains(newTag))
                {
                    if (!string.IsNullOrEmpty(edit.Text))
                        edit.EditValue += ", ";
                    edit.EditValue += newTag;
                }
            }
        }


        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ID = 17061;
            string IDskl = "OP";

            Account.FaturaLinkXF frm = new Account.FaturaLinkXF();
            frm.ID = ID;
            frm.IDskl = IDskl;
            frm.ShowDialog();
            frm.Dispose();
        }

        public bool EntryCheck(string frm, bool isSilent)
        {
            if (Program.USTid < 2)
                return true;

            string Ent = "F";
            var uspRow = mainDataSet.USP_SEL_USR.FindByFRM(frm);
            if (uspRow != null)
                Ent = uspRow.ENT;   

            bool res = Ent == "T" ? true : false;

            if (!isSilent && !res)
                XtraMessageBox.Show("Yetkili değilsiniz", "Entry Check " + frm, MessageBoxButtons.OK, MessageBoxIcon.Stop);

            return res;
        }

        public bool ModifyCheck(string frm, bool isSilent)
        {
            if (Program.USTid < 2)
                return true;

            string Mdf = "F";
            var uspRow = mainDataSet.USP_SEL_USR.FindByFRM(frm);
            if (uspRow != null)
                Mdf = uspRow.MDF;

            bool res = Mdf == "T" ? true : false;

            if (!isSilent && !res)
                XtraMessageBox.Show("Yetkili değilsiniz", "Modify Check " + frm, MessageBoxButtons.OK, MessageBoxIcon.Stop);

            return res;
        }

        public bool CanUserDo(string tbl, string ops, bool isSilent)
        {
            return true;    // Simdilik herkese acik

            if (Program.USTid < 2)
                return true;

            string val = string.Empty;
            string frmAd = "Form Entry, Yetki kontrol";

            var uspRow = mainDataSet.USP.FindByUSTIDFRM(Program.USTid, tbl);
            if (uspRow != null)
            {
                frmAd = uspRow.FRMAD;
                switch (ops)
                {
                    case "ENT":
                        val = uspRow.ENT;
                        break;
                    case "SEL":
                        val = uspRow.SEL;
                        break;
                    case "INS":
                        val = uspRow.INS;
                        break;
                    case "UPD":
                        val = uspRow.UPD;
                        break;
                    case "DEL":
                        val = uspRow.DEL;
                        break;
                    case "PRN":
                        val = uspRow.PRN;
                        break;
                }
            }

            bool res = val == "T" ? true : false;

            if (!isSilent && !res)
                XtraMessageBox.Show("Yetkili değilsiniz", frmAd, MessageBoxButtons.OK, MessageBoxIcon.Stop);

            return res;
        }

        public bool YetkiCheck(string curYTK, bool isSilent = true)
        {
            //return true;    // Simdilik herkese acik

            if (Program.USR == "ADMN" || string.IsNullOrEmpty(curYTK))  // Admin/Onaylanmamis
                return true;
            
            var rows = mainDataSet.UUY.Select(string.Format("USR = '{0}'", Program.USR), "USR", DataViewRowState.OriginalRows);
            if (rows.Length != 0)
            {
                foreach (var row in rows)
                {
                    string FCN = row["FCN"].ToString();
                    if (FCN.Contains(string.Format(",{0},", curYTK)))
                        return true;
                }
            }
            if (!isSilent)
                XtraMessageBox.Show("Yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return false;
        }

        public void IslAccCurYtk(string opHM, int opID, out string islYtkCur, out string accYtkCur)
        {
            string iaYtk = mainQueriesTableAdapter.OPS_GET_YETKI(opHM, opID).ToString();
            string[] islAccYtk = iaYtk.Split(new char[] { '/' });

            islYtkCur = islAccYtk[0];
            accYtkCur = islAccYtk[1];
        }
        
        public bool YetkiCheckAcc(string opHM, int opID, bool isSilent = true)
        {
            bool res;
            string iaYtk = mainQueriesTableAdapter.OPS_GET_YETKI(opHM, opID).ToString();
            string[] islAccYtk = iaYtk.Split(new char[] { '/' });

            bool islYtk = YetkiCheck(islAccYtk[0], false);
            bool accYtk = YetkiCheck(islAccYtk[1], false);

            res = islYtk & accYtk;
            if (!res && !isSilent)
                XtraMessageBox.Show("Yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            return res;
        }
        
        private void AHPrepositoryItemSearchLookUpEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            var edit = sender as SearchLookUpEdit;
            
            // Calismayan Hesaplari kabul etme
            string dty = mainDataSet.AHP.FindByHSPNO(e.Value.ToString()).DTY;
            if (e.CloseMode == PopupCloseMode.Normal &&  dty == "F")
                e.AcceptValue = false;
        }

        private void AHPrepositoryItemLookUpEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            // Calismayan Hesaplari kabul etme
            if (e.CloseMode == PopupCloseMode.Normal && mainDataSet.AHP.FindByHSPNO(e.Value.ToString()).DTY == "F")
                e.AcceptValue = false;
        }

        private void AHPrepositoryItemGridLookUpEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal && mainDataSet.AHP.FindByHSPNO(e.Value.ToString()).DTY == "F")
                e.AcceptValue = false;
        }

        public void reportDone(rptInfo ri, bool sor = true)
        {
            if (sor)
            {
                if (XtraMessageBox.Show("İşlem tamamlandı mı?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    mainQueriesTableAdapter.RPH_INS(ri.kod, ri.refTO, ri.refID, ri.usr, ri.rspW, ri.info);
            }
            else
                mainQueriesTableAdapter.RPH_INS(ri.kod, ri.refTO, ri.refID, ri.usr, ri.rspW, ri.info);
        }

    }
}
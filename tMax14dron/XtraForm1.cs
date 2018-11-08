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
using System.Xml;

namespace tMax14dron
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        public void kurUpdate() //public string TlKarsiligi(KurKodu kodu, Tur turu)
        {
            /*
            if (lclDvz != "TL")
                return;

            // MB kurlari HaftaIci saat 15.30 den sonra yayinliyor, simdi 15:30 - 23:30 arasiysa kur oku
            DateTime now = DateTime.Now;
            string saat = now.ToString("HH:mm");
            //if (usr > 0)
           
            {
                if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
                    return;
                if (saat.CompareTo("15:30") < 0 || saat.CompareTo("23:30") > 0)
                    return;
            }
            
            try
            {
                XmlTextReader xmlRdr = new XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlRdr);
                XmlNodeList xmlNode;
                string dvz, trh, kur;

                trh = xmlDoc.DocumentElement.Attributes[0].Value.ToString();
                foreach (DataRow dTDataRow in this.lookUpDataSet.DT)
                {
                    dvz = (string)dTDataRow["DVZ"];
                    //if ((string)dTDataRow["TUR"] == "D" && (dvz != "YTL" || dvz != "TL") )
                    if ((string)dTDataRow["TUR"] == "D" && dvz != "YTL" && dvz != "TL")
                    {
                        xmlNode = xmlDoc.SelectNodes("/Tarih_Date/Currency[@Kod='" + dvz + "']/" + "ForexBuying");
                        kur = xmlNode.Item(0).InnerXml.ToString();
                        //MessageBox.Show(trh + " " + dvz + " = " + kur);
                        lookupQueriesTableAdapter.DK_UPDATE(trh, dvz, kur);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Günlük kurları almak için Merkez Bankasına bağlantı kurulamadı. \n" + ex.Message);
                //                MessageBox.Show(ex.InnerException.Message + "  " + ex.Message);
            }
            */
        }
    }
}
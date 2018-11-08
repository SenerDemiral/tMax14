using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using tMax14GetDvz.DataSet1TableAdapters;

namespace tMax14GetDvz
{
    class Program
    {
        //private DataSet1TableAdapters.QueriesTableAdapter queriesTableAdapter;
        
        static void Main(string[] args)
        {
            GetMerkezDvzKur();
            GetDvzKur();      // MB IPTAL
        }

        static void GetMerkezDvzKur()
        {
            QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();

            XmlDocument MB = new XmlDocument();
            MB.Load("http://www.tcmb.gov.tr/kurlar/today.xml");     // Merkez Bankasi
            XmlNode MBroot = MB.DocumentElement;
            string trh = MBroot.Attributes["Tarih"].InnerText;      // Kullanilmiyor
            XmlNodeList MBnodeList = MBroot.SelectNodes("Currency");
            foreach (XmlNode xn in MBnodeList)
            {
                string foex = xn.Attributes["CurrencyCode"].InnerText;
                if (xn["ForexBuying"] != null && xn["ForexSelling"] != null)
                {
                    string buy = xn["ForexBuying"].InnerText;
                    string sell = xn["ForexSelling"].InnerText;
                    queriesTableAdapter.KUR_UPD(foex, "MB", buy, sell);
                }
            }
        }

        static void GetDvzKur()
        {
            QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();

            /*
            XmlDocument MB = new XmlDocument();

            MB.Load("http://api.piyasa.com/xml/?kaynak=doviz_guncel_tcmb");    // Merkez Bankasi

            XmlNode MBroot = MB.DocumentElement;
            XmlNodeList MBnodeList = MBroot.SelectNodes("node");

            foreach (XmlNode xn in MBnodeList)
            {
                string foex = xn["foex"].InnerText;
                string buy = xn["buy"].InnerText;
                string sell = xn["sell"].InnerText;
                queriesTableAdapter.KUR_UPD(foex, "MB", buy, sell);
            }
            */
            //doc.RemoveAll();

            XmlDocument YK = new XmlDocument();
            YK.Load("http://api.piyasa.com/xml/?kaynak=doviz_guncel_yapi");    // Yapi Kredi

            XmlNodeList YKnodeList = YK.DocumentElement.SelectNodes("node");

            foreach (XmlNode xn in YKnodeList)
            {
                string foex = xn["foex"].InnerText;
                string buy = xn["buy"].InnerText;
                string sell = xn["sell"].InnerText;
                queriesTableAdapter.KUR_UPD(foex, "YK", buy, sell);
            }

        }
    }
}

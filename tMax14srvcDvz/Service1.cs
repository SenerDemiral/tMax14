using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace tMax14srvcDvz
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            getDvzKur();
        }

        protected override void OnStop()
        {
        }

        async Task getDvzKur()
        {
            XmlDocument doc = new XmlDocument();

            while (true)
            {
                doc.Load("http://api.piyasa.com/xml/?kaynak=doviz_guncel_tcmb");    // Merkez Bankasi

                XmlNodeList nodeList;
                XmlNode root = doc.DocumentElement;

                nodeList = root.SelectNodes("node");

                foreach (XmlNode xn in nodeList)
                {
                    string foex = xn["foex"].InnerText;
                    string buy = xn["buy"].InnerText;
                    string sell = xn["sell"].InnerText;
                    queriesTableAdapter.KUR_UPD(foex, "MB", buy, sell);
                }

                doc.RemoveAll();
                doc.Load("http://api.piyasa.com/xml/?kaynak=doviz_guncel_yapi");    // Yapi Kredi

                root = doc.DocumentElement;

                foreach (XmlNode xn in nodeList)
                {
                    string foex = xn["foex"].InnerText;
                    string buy = xn["buy"].InnerText;
                    string sell = xn["sell"].InnerText;
                    queriesTableAdapter.KUR_UPD(foex, "YK", buy, sell);
                }

                await Task.Delay(TimeSpan.FromSeconds(30));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tMax14dron
{
    class Cron
    {
        int[][] cronArray = new int[5][];   // 0:Min 1:Hour 2:Day 3:WeekDay 4:Month
        string prevRunTime = string.Empty;

        public string prevRunDay { get; set; }  // Client islem basaril bir sekilde yapildiginda bunu set edecek, gun icinde birdaha yapilmayacak (Gunluk Kurlar)

        public Cron(string cronString)
        {
            cronArray[0] = new int[60]; // Min   0-59
            cronArray[1] = new int[24]; // Hour  0-23
            cronArray[2] = new int[32]; // Day   1-31
            cronArray[3] = new int[7];  // Week  0-6 0:Pazar
            cronArray[4] = new int[13]; // Month 1-12

            string[] sa = cronString.Split(new char[] { ' ' });

            int z = 0;
            for (int i = 0; i < sa.Length; i++)
            {
                if (sa[i] == "*")
                    for (int k = 0; k < cronArray[i].Length; k++)
                        cronArray[i][k] = 1;
                else
                {
                    string[] ss = sa[i].Split(new char[] { ' ', ',' });
                    //List<int> nL = new List<int>();
                    for (int j = 0; j < ss.Length; j++)
                    {
                        z = Convert.ToInt32(ss[j]);
                        cronArray[i][z] = 1;
                    }
                }
            }
        }

        public bool CanRunNow(DateTime now)
        {
            if (prevRunDay == now.ToString("dd.MM.yy"))
                return false;

            if (prevRunTime == now.ToString("dd.MM.yy HH:mm"))
                return false;

            if (cronArray[0][now.Minute] == 1 &&
                cronArray[1][now.Hour] == 1 &&
                cronArray[2][now.Day] == 1 &&
                cronArray[3][(int)now.DayOfWeek] == 1 &&
                cronArray[4][now.Month] == 1)
            {
                prevRunTime = now.ToString("dd.MM.yy HH:mm");
                return true;
            }
            return false;
        }
    }
}

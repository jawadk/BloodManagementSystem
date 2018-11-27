using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApplication1
{
    class Blood
    {
        Connection con;

        public string id;
        public DateTime D;
        public DateTime D1;
        public string wash;
        public string temp;
        public string HB;
        public string AmountOfblood;

        public Blood()
        {
        
        }

        public Blood(string pid, DateTime d, DateTime d1, string Wash, string Temp, string hb, string amount)
        {
            id = pid;
            D = d;
            D1 = d1;
            wash = Wash;
            temp = Temp;
            HB = hb;
            AmountOfblood = amount;
        }
    }
}
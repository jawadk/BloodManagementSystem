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

        string id;
        DateTime D;
        DateTime D1;
        string wash;
        string temp;
        string HB;
        string AmountOfblood;

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

        public void insertData()
        {
            con = new Connection();
            string insertQuery;
            insertQuery = String.Format("INSERT INTO `Blood` (`Patient_Number`, `TransfusionDate`, `NextTransfusion`, `BloodWash`, `Temperature`, `HB`, `AmountOfBlood`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", id, D, D1, wash, temp, HB,AmountOfblood).ToString();
            OleDbCommand cmd = new OleDbCommand(insertQuery, con.connect());
            cmd.ExecuteNonQuery();
        }

        public DataTable getTable(string query)
        {
            con = new Connection();
            try
            {
                DataTable table = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, con.connect());
                adapter.Fill(table);
                return table;
            }
            catch (Exception excp)
            {
                throw excp;
            }
        }      
    }
}
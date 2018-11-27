using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.DOA
{
    class BloodManager
    {
        Connection conn;

        public OleDbDataReader GetPatientNumber() 
        {
            conn = new Connection();
            string q = "Select Patient_Number from patient";
            OleDbCommand cmd = new OleDbCommand(q, conn.connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void insertData(Blood blood)
        {
            conn = new Connection();
            string insertQuery;
            insertQuery = String.Format("INSERT INTO `Blood` (`Patient_Number`, `TransfusionDate`, `NextTransfusion`, `BloodWash`, `Temperature`, `HB`, `AmountOfBlood`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", blood.id, blood.D, blood.D1, blood.wash, blood.temp, blood.HB, blood.AmountOfblood).ToString();
            OleDbCommand cmd = new OleDbCommand(insertQuery, conn.connect());
            cmd.ExecuteNonQuery();
        }

        public DataTable getTable(string query)
        {
            conn = new Connection();
            try
            {
                DataTable table = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn.connect());
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

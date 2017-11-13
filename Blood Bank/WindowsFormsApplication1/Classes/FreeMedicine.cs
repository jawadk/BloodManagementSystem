using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApplication1
{
    class FreeMedicine
    {
        Connection connect;

        string id;
        string tape;
        string butterfly;
        string seringe;
        string asunra;
        string defsrol;
        string bisstle;
        string alchol;
        DateTime D;

        public FreeMedicine()
        {
        
        }

        public FreeMedicine(string pid, string Tape, string Butterfly, string Seringe, string Asunra, string Defsorl, string Bistlewater, string Alchol, DateTime Date)
        {
             id = pid;
             tape = Tape;
             butterfly = Butterfly;
             seringe = Seringe;
             asunra = Asunra;
             defsrol = Defsorl;
             bisstle = Bistlewater;
             alchol = Alchol;
             D = Date;
        }

        public void insertData()
        {
            connect = new Connection();
            string insertQuery = String.Format("INSERT INTO `Medicine` (`Patient_Number`, `Tape`, `Butterfly`, `Seringe`, `Asunra`, `Defsorol`, `BisstleWater`, `Alchol`, `NewDate`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", id, tape, butterfly, seringe, asunra, defsrol, bisstle, alchol, D).ToString();
            OleDbCommand com = new OleDbCommand(insertQuery,connect.connect());
            com.ExecuteNonQuery();      
        }

        public DataTable getTable(string query)
        {
            connect = new Connection();
            try
            {
                DataTable table = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connect.connect());
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
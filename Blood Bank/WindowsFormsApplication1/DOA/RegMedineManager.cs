using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.DOA
{
    class RegMedineManager
    {
        Connection connect;

        public void insertData(RegMedineTemp freeMedicine)
        {
            connect = new Connection();
            string insertQuery = String.Format("INSERT INTO `Medicine` (`Patient_Number`, `Tape`, `Butterfly`, `Seringe`, `Asunra`, `Defsorol`, `BisstleWater`, `Alchol`, `NewDate`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", freeMedicine.id, freeMedicine.tape, freeMedicine.butterfly, freeMedicine.seringe, freeMedicine.asunra, freeMedicine.defsrol, freeMedicine.bisstle, freeMedicine.alchol, freeMedicine.D).ToString();
            OleDbCommand com = new OleDbCommand(insertQuery, connect.connect());
            com.ExecuteNonQuery();
        }

        public OleDbDataReader getPatients() {
            connect = new Connection();
            string q = "Select Patient_Number from patient";
            OleDbCommand cmd = new OleDbCommand(q, connect.connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }





    }
}

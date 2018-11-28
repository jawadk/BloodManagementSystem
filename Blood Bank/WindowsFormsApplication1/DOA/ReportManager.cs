using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.DOA
{
    class ReportManager
    {
        Connection con;

        public void insertreport(Reports r)
        {
            con = new Connection();
            string q = string.Format("INSERT INTO `report` (`Patient_Number`, `Patient_Name`, `Patient_Cell`, `Patient_Age`,`Patient_Blood_Group`,`Patient_Address`, `Report_Date`,`Test_Result`,`Types_of_Test`,`Bill`)VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", r.patientId, r.patientname, r.Cell, r.Age, r.BloodGroup, r.Address, r.d, r.testresultdate, r.typesoftest, r.Bill).ToString();
            OleDbCommand com = new OleDbCommand(q, con.connect());
            com.ExecuteNonQuery();
        }

        public DataTable selectData(string id)
        {
            DataTable tbl = new DataTable();
            con = new Connection();
            string query = "SELECT * FROM report WHERE  Report_Number= " + id;
            OleDbCommand cmd = new OleDbCommand(query, con.connect());
            cmd.Parameters.AddWithValue("@p1", id);
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            adp.Fill(tbl);
            return tbl;
        }

        public void inserttest(Reports r)
        {
            con = new Connection();
            string q = string.Format("INSERT INTO `test` (`Report_Number`, `Report`,`Patient_Number`,`Bill`)VALUES ('{0}','{1}','{2}','{3}')", r.reportId, r.reports, r.patientId, r.billpayed).ToString();
            OleDbCommand com = new OleDbCommand(q, con.connect());
            com.ExecuteNonQuery();
        }

        public OleDbDataReader GetReport()
        {
            con = new Connection();
            string q = "Select Report_Number from report";
            OleDbCommand cmd = new OleDbCommand(q, con.connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }

    }
}

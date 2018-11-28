using System;
using System.Collections.Generic;
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
    }
}

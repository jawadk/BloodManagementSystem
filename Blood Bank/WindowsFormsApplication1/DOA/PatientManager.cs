using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.DOA
{
    class PatientManager
    {
        //Initized Connection object.
        Connection con;

        public OleDbDataReader GetBloodGroup()
        {
            con = new Connection();
            string q = "Select Blood_Group from patient";
            OleDbCommand cmd = new OleDbCommand(q, con.connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public OleDbDataReader GetBranchLocation()
        {
            con = new Connection();
            string a = "Select Branch_Location from patient";
            OleDbCommand cm = new OleDbCommand(a, con.connect());
            OleDbDataReader reader = cm.ExecuteReader();
            return reader;
        }

        // Insert Query for Patient Registration Form
        public void insertData(Patient patient)
        {
            con = new Connection();
            string insertQuery;
            insertQuery = String.Format("INSERT INTO `patient` (`Blood_Group`, `Patient_Name`, `Patient_DOB`, `Patient_Add1`, `Patient_Add2`, `Patient_Ph-No`, `Patient_Cell-No`, `Date`, `Branch_Location`, `City`, `Amount_of_Blood`, `Patient_Email`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", patient.BloodGroup, patient.Name, patient.DOB, patient.Add1, patient.Add2, patient.PhoneNo, patient.CellNo, patient.Date, patient.BranchLocation, patient.City, patient.AmountofBlood, patient.EmailId).ToString();
            OleDbCommand cmd = new OleDbCommand(insertQuery, con.connect());
            cmd.ExecuteNonQuery();
        }

        //Coding for Patient's Data Grid View
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

        //Select Data for Update Query
        public DataTable selectData(string IdNumber)
        {
            DataTable tbl = new DataTable();
            con = new Connection();
            string query = "SELECT * FROM patient WHERE Patient_Number = " + IdNumber;
            OleDbCommand cmd = new OleDbCommand(query, con.connect());
            cmd.Parameters.AddWithValue("@p1", IdNumber);
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            adp.Fill(tbl);
            return tbl;
        }

        //Update Query for Patients
        public void updateData(int IdNumber, Patient patient)
        {
            con = new Connection();
            string query = "UPDATE patient SET Blood_Group = '" + patient.BloodGroup + "', Patient_Name = '" + patient.Name + "', Patient_DOB = '" + patient.DOB + "', Patient_Add1 = '" + patient.Add1 + "', Patient_Add2 = '" + patient.Add2 + "', `Patient_Ph-No` = '" + patient.PhoneNo + "', `Patient_Cell-No` = '" + patient.CellNo + "', `Date` = '" + patient.Date + "', Branch_Location = '" + patient.BranchLocation + "', city = '" + patient.City + "', Amount_of_Blood = '" + patient.AmountofBlood + "', Patient_Email = '" + patient.EmailId + "' WHERE Patient_Number = " + IdNumber;
            OleDbCommand cmd = new OleDbCommand(query, con.connect());
            cmd.ExecuteNonQuery();
        }

        //Join Query for Patients Record (Data Grid View)
        public DataTable joinTable(string query)
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

        public DataTable select(string IdNumber)
        {
            DataTable tbl = new DataTable();
            con = new Connection();
            string query = "SELECT `Blood_Group`, `Patient_Name`, `Patient_Add1`, `Patient_Add2`, `Patient_Cell-No`, `Branch_Location`, `city`, `Amount_of_Blood` FROM patient WHERE `Patient_Number` = '" + IdNumber + "'";
            OleDbCommand cmd = new OleDbCommand(query, con.connect());
            cmd.Parameters.AddWithValue("@p1", IdNumber);
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            adp.Fill(tbl);
            return tbl;
        }

        public OleDbDataReader GetPatientsByNumber(){
            con = new Connection();
            string q = "Select Patient_Number from patient";
            OleDbCommand cmd = new OleDbCommand(q, con.connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public DataTable DeleteUser(string PatientID)
        {
            con = new Connection();
            try
            {
                string query = "DELETE * From `patient` where Patient_Number = " + PatientID;
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

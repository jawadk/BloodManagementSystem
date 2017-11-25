using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApplication1
{
    class Patient : Person
    {
        Connection con;
        
        // Default Constructor
        public Patient()
        {
        }

        // Customized Constructor; taking parameters
        public Patient(string _bgroup, string _pname, string _pdob, string _padd1, string _padd2, string _pphno, string _pcellno, string _date, string _blocation, string _city, string _amountofblood, string _pemailid)
        {
            //IdNumber = _pnumber;
            BloodGroup = _bgroup;
            Name = _pname;
            DOB = _pdob;
            Add1 = _padd1;
            Add2 = _padd2;
            PhoneNo = _pphno;
            CellNo = _pcellno;
            Date = _date;
            BranchLocation = _blocation;
            City = _city;
            AmountofBlood = _amountofblood;
            EmailId = _pemailid;
        }

        //public Patient(string _pnumber)
        //{
        //    IdNumber = _pnumber;
        //}

        // Insert Query for Patient Registration Form
        public void insertData()
        {
            con = new Connection();
            string insertQuery;
            insertQuery = String.Format("INSERT INTO `patient` (`Blood_Group`, `Patient_Name`, `Patient_DOB`, `Patient_Add1`, `Patient_Add2`, `Patient_Ph-No`, `Patient_Cell-No`, `Date`, `Branch_Location`, `City`, `Amount_of_Blood`, `Patient_Email`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", BloodGroup, Name, DOB, Add1, Add2, PhoneNo, CellNo, Date, BranchLocation, City, AmountofBlood, EmailId).ToString();            
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
        public void updateData(int IdNumber)
        {
            con = new Connection();            
            string query = "UPDATE patient SET Blood_Group = '"+BloodGroup+"', Patient_Name = '"+Name+"', Patient_DOB = '"+DOB+"', Patient_Add1 = '"+Add1+"', Patient_Add2 = '"+Add2+"', `Patient_Ph-No` = '"+PhoneNo+"', `Patient_Cell-No` = '"+CellNo+"', `Date` = '"+Date+"', Branch_Location = '"+BranchLocation+"', city = '"+City+"', Amount_of_Blood = '"+AmountofBlood+"', Patient_Email = '"+EmailId+"' WHERE Patient_Number = "+IdNumber;
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
    }
}
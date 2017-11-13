using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApplication1
{
    class Donor : Person
    {
        Connection con;

        //Default Constructor
        public Donor()
        {
        }

        //Customized Constructor; taking parameters
        public Donor(string _dnumber, string _bgroup, string _dname, string _ddob, string _dadd1, string _dadd2, string _dphno, string _dcellno, string _date, string _blocation, string _city, string _amountofblood, string _demailid)
        {
            IdNumber = _dnumber;
            BloodGroup = _bgroup;
            Name = _dname;
            DOB = _ddob;
            Add1 = _dadd1;
            Add2 = _dadd2;
            PhoneNo = _dphno;
            CellNo = _dcellno;
            Date = _date;
            BranchLocation = _blocation;
            City = _city;
            AmountofBlood = _amountofblood;
            EmailId = _demailid;
        }

        //Insert Query for Donor Registration Form
        public void insertData()
        {
            con = new Connection();
            string insertQuery;
            insertQuery = String.Format("INSERT INTO `donor` (`Donor_Number`, `Blood_Group`, `Donor_Name`, `Donor_DOB`, `Donor_Add1`, `Donor_Add2`, `Donor_Ph-No`, `Donor_Cell-No`, `Date`, `Branch_Location`, `City`, `Amount_of_Blood`, `Donor_Email`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", IdNumber, BloodGroup, Name, DOB, Add1, Add2, PhoneNo, CellNo, Date, BranchLocation, City, AmountofBlood, EmailId).ToString();
            OleDbCommand cmd = new OleDbCommand(insertQuery, con.connect());
            cmd.ExecuteNonQuery();
        }

        //Code for Donor's Data Grid View
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
            string query = "SELECT * FROM donor WHERE Donor_Number = '" + IdNumber + "'";
            OleDbCommand cmd = new OleDbCommand(query, con.connect());
            cmd.Parameters.AddWithValue("@d1", IdNumber);
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            adp.Fill(tbl);
            return tbl;
        }

        //Update Query for donors
        public void updateData()
        {
            con = new Connection();
            string query = "UPDATE donor SET Blood_Group = '" + BloodGroup + "', Donor_Name = '" + Name + "', Donor_DOB = '" + DOB + "', Donor_Add1 = '" + Add1 + "', Donor_Add2 = '" + Add2 + "', `Donor_Ph-No` = '" + PhoneNo + "', `Donor_Cell-No` = '" + CellNo + "', `date` = '" + Date + "', Branch_Location = '" + BranchLocation + "', city = '" + City + "', Amount_of_Blood = '" + AmountofBlood + "', Donor_Email = '" + EmailId + "' WHERE Donor_Number = '" + IdNumber + "'";
            OleDbCommand cmd = new OleDbCommand(query, con.connect());
            cmd.ExecuteNonQuery();
        }
    }
}
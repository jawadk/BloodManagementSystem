using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.DOA
{
    class DonorManager
    {
        //Initized Connection object.
        Connection con;

        public OleDbDataReader getBloodGroup() {     
            con = new Connection();
            string q = "Select Blood_Group from donor";
            OleDbCommand cmd = new OleDbCommand(q, con.connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }


        public OleDbDataReader GetBranchLocation() {
            con = new Connection();
            string a = "Select Branch_Location from donor";
            OleDbCommand cm = new OleDbCommand(a, con.connect());
            OleDbDataReader reader = cm.ExecuteReader();
            return reader;
        }

        //Insert Query for Donor Registration Form
        public void insertData(Donor donor)
        {
            con = new Connection();
            string insertQuery;
            insertQuery = String.Format("INSERT INTO `donor` (`Blood_Group`, `Donor_Name`, `Donor_DOB`, `Donor_Add1`, `Donor_Add2`, `Donor_Ph-No`, `Donor_Cell-No`, `Date`, `Branch_Location`, `City`, `Amount_of_Blood`, `Donor_Email`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", donor.BloodGroup, donor.BloodGroup, donor.Name, donor.DOB, donor.Add1, donor.Add2, donor.PhoneNo, donor.CellNo, donor.Date, donor.BranchLocation, donor.City, donor.AmountofBlood, donor.EmailId).ToString();
            OleDbCommand cmd = new OleDbCommand(insertQuery, con.connect());
            cmd.ExecuteNonQuery();
        }

        //Select Data for Update Query
        public DataTable selectData(string IdNumber)
        {
            DataTable tbl = new DataTable();
            con = new Connection();
            string query = "SELECT * FROM donor WHERE Donor_Number = " + IdNumber;
            OleDbCommand cmd = new OleDbCommand(query, con.connect());
            cmd.Parameters.AddWithValue("@d1", IdNumber);
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            adp.Fill(tbl);
            return tbl;
        }

        //Update Query for donors
        public void updateData(int IdNumber, Donor donor)
        {
            con = new Connection();
            string query = "UPDATE donor SET Blood_Group = '" + donor.BloodGroup + "', Donor_Name = '" + donor.Name + "', Donor_DOB = '" + donor.DOB + "', Donor_Add1 = '" + donor.Add1 + "', Donor_Add2 = '" + donor.Add2 + "', `Donor_Ph-No` = '" + donor.PhoneNo + "', `Donor_Cell-No` = '" + donor.CellNo + "', `date` = '" + donor.Date + "', Branch_Location = '" + donor.BranchLocation + "', city = '" + donor.City + "', Amount_of_Blood = '" + donor.AmountofBlood + "', Donor_Email = '" + donor.EmailId + "' WHERE Donor_Number = " + IdNumber;
            OleDbCommand cmd = new OleDbCommand(query, con.connect());
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

        public OleDbDataReader GetDonorNumber() 
        {
            con = new Connection();
            string q = "Select Donor_Number from donor";
            OleDbCommand cmd = new OleDbCommand(q, con.connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}

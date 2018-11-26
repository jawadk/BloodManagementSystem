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
            //IdNumber = _dnumber;
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

        public string BloodGroup { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string PhoneNo { get; set; }
        public string CellNo { get; set; }
        public string Date { get; set; }
        public string BranchLocation { get; set; }
        public string City { get; set; }
        public string AmountofBlood { get; set; }
        public string EmailId { get; set; }



        ////Insert Query for Donor Registration Form
        //public void insertData()
        //{
        //    con = new Connection();
        //    string insertQuery;
        //    insertQuery = String.Format("INSERT INTO `donor` (`Blood_Group`, `Donor_Name`, `Donor_DOB`, `Donor_Add1`, `Donor_Add2`, `Donor_Ph-No`, `Donor_Cell-No`, `Date`, `Branch_Location`, `City`, `Amount_of_Blood`, `Donor_Email`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", BloodGroup, Name, DOB, Add1, Add2, PhoneNo, CellNo, Date, BranchLocation, City, AmountofBlood, EmailId).ToString();
        //    OleDbCommand cmd = new OleDbCommand(insertQuery, con.connect());
        //    cmd.ExecuteNonQuery();
        //}

        
    }
}
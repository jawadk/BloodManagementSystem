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
    }
}
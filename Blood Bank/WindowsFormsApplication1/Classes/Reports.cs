using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;


namespace WindowsFormsApplication1
{
    class Reports
    {
        Connection con;
        public string patientId;
        public string patientname;
        public string Age;
        public string typesoftest;
        public string BloodGroup;
        public string Cell;
        public string Address;
        public DateTime d;
        public DateTime testresultdate;
        public string Bill;
        public string billpayed;
        public string reports;
        public string reportId;

        public Reports(DateTime testdate, DateTime reultdate, string typeoftests, string bills)
        {
            d = testdate;
            testresultdate = reultdate;
            typesoftest = typeoftests;
            Bill = bills;        
        }

        public Reports(string Reportid, string report, string payed,string id)
        {
            reportId = Reportid;
            reports = report; 
            patientId = id;       
            billpayed = payed;
        }

        public Reports(string id, string name, string cell, string age, string bloodgroup, string address, DateTime date, DateTime resultdate, string types, string bill)
        {
            patientId = id;
            patientname = name;
            Age = age;
            BloodGroup = bloodgroup;
            Cell = cell;
            Address = address;
            d = date;
            testresultdate = resultdate;
            typesoftest = types;
            Bill = bill;          
        }

        public Reports()
        {

        }
    }
}

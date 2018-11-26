using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.DOA
{
    class LoginManager
    {
        //Initilize Database Connection
        Connection con;

        public OleDbDataReader GetAdminCredentials(string userName, string userPass) 
        {
            con = new Connection();
            string query = "SELECT User_Name, User_Password FROM admin WHERE User_Name = '" + userName + "' AND User_Password = '" + userPass + "'";
            OleDbCommand cmd = new OleDbCommand(query, con.connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}

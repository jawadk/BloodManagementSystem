    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.OleDb;
    using System.Data;

namespace WindowsFormsApplication1
{
    class Login
    {
        Connection con;
        string userName;
        string userPass;

        public Login(string _user, string _pass)
        {
            userName = _user;
            userPass = _pass;
        }
        public bool getLogin()
        {
            con = new Connection();
            bool _check;           
            string query = "SELECT User_Name, User_Password FROM admin WHERE User_Name = '" + userName + "' AND User_Password = '" + userPass + "'";
            OleDbCommand cmd = new OleDbCommand(query, con.connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                _check = true;
            }
            else
            {
                _check = false;
            }
            return _check;
        }       
    }
}
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.OleDb;
    using System.Data;
using WindowsFormsApplication1.DOA;

namespace WindowsFormsApplication1
{
    class Login
    {
        LoginManager loginManager;
        string userName;
        string userPass;

        public Login(string _user, string _pass)
        {
            userName = _user;
            userPass = _pass;
        }
        public bool getLogin()
        {
            bool _check;

            loginManager = new LoginManager();

            OleDbDataReader reader = loginManager.GetAdminCredentials(userName, userPass);
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
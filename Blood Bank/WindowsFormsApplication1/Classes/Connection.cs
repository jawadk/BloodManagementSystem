using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

namespace WindowsFormsApplication1
{
    class Connection
    {
        string connectionString;
        
        public Connection()
        {
            connectionString = ConfigurationManager.AppSettings["database"].ToString();
            connectionString = "provider=microsoft.ace.oledb.12.0;data source=" + connectionString;
        }
        public OleDbConnection connect()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception excep)
            {
                throw excep;
            }
        }
        public DataTable getTable(string query)
        {
            try
            {
                DataTable table = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connect());
                adapter.Fill(table);
                return table;
            }
            catch (Exception excep)
            {
                throw excep;
            }
        }
    }
}
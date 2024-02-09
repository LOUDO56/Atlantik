using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.utils
{
    internal class BDD
    {

        private string host;
        private string dbName;
        private MySqlConnection conn;

        public BDD()
        {
            host = "localhost";
            dbName = "atlantik";
        }

        public MySqlConnection get()
        {
            return conn;
        }

        public Boolean Open()
        {
            conn = new MySqlConnection("mysql:host=" + host + ";dbname=" + dbName);
            try
            {
                conn.Open();
                return true;
            } catch (MySqlException e)
            {
                return false;
            }
        }

        public Boolean Close()
        {
            if(conn is object & conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                return true;
            }
            return false;
        }

    }
}

using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.utils
{
    internal class BDD
    {

        private string host;
        private string port;
        private string username;
        private string password;
        private string dbName;
        private MySqlConnection conn;

        public BDD()
        {
            host = "127.0.0.1";
            port = "3306";
            username = "root";
            password = "";
            dbName = "atlantik";
        }

        public bool Open()
        {
            conn = new MySqlConnection($"Server={host};Port={port};User Id={username};Password={password};Database={dbName};");
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erreur durant connexion Atlantik BDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public void Close()
        {
            if(conn is object & conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void Run(string sql, Hashtable parameters)
        {
            try
            {
                var maCde = new MySqlCommand(sql, conn);

                foreach(DictionaryEntry value in parameters)
                {
                    maCde.Parameters.AddWithValue(value.Key.ToString(), value.Value);
                }
                int nbLigneAffecte = maCde.ExecuteNonQuery();
                string pluriel = "";
                if(nbLigneAffecte > 1)
                {
                    pluriel = "s";
                }

                MessageBox.Show($"Requête effectué avec succès. {nbLigneAffecte} ligne{pluriel} affecté.", "Requête effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Erreur durant requête SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MySqlDataReader Get(string sql, Hashtable parameters = null)
        {
            try
            {
                var maCde = new MySqlCommand(sql, conn);

                if(parameters != null) // Si la requête à des paramètres
                {
                    foreach (DictionaryEntry value in parameters)
                    {
                        maCde.Parameters.AddWithValue(value.Key.ToString(), value.Value);
                    }
                }

                return maCde.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(sql + " n'a pas fonctionné : " + ex.Message, "Erreur durant requête SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



    }
}

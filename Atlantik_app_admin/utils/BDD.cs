using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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

        public Boolean Open()
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

        public void Send(string sql, Dictionary<string, string> parameters)
        {
            try
            {
                var maCde = new MySqlCommand(sql, conn);

                for (int i = 0; i < parameters.Count; i++)
                {
                    maCde.Parameters.AddWithValue(parameters.ElementAt(i).Key, parameters.ElementAt(i).Value);
                }

                int nbLigneAffecte = maCde.ExecuteNonQuery();
                string ligne;
                if (nbLigneAffecte > 1)
                {
                    ligne = "lignes";
                } else
                {
                    ligne = "ligne";
                }
                MessageBox.Show($"Requête effectué avec succès. {nbLigneAffecte} {ligne} affecté.", "Requête effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Erreur durant requête SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MySqlDataReader Get(string sql, Dictionary<string, string> parameters = null)
        {
            try
            {
                var maCde = new MySqlCommand(sql, conn);

                if(parameters != null) // Si la requête ne demande aucun paramètre.
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        maCde.Parameters.AddWithValue(parameters.ElementAt(i).Key, parameters.ElementAt(i).Value);
                    }
                }

                return maCde.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Erreur durant requête SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



    }
}

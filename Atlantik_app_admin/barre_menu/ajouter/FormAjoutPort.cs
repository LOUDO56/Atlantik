using Atlantik_app_admin.utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik_app_admin.barre_menu.ajouter
{
    public partial class FormAjoutPort : Form
    {

        MySqlConnection conn = new MySqlConnection(BDD.CONNECTION_STRING);

        public FormAjoutPort()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(ConfirmerAjout.confirmer() == false) { return; }

            if (tbx_port.Text == "") 
            {
                InformationManquante.SHOW("le port");
                return; 
            }

            if (!Regex.IsMatch(tbx_port.Text, @"^[A-Za-z ]+$"))
            {
                RegexMatchWarning.ONLY_ALPHABETS("pour le nom du port");
                return;
            }

            try
            {
                conn.Open();
                string req = "INSERT INTO port(NOM) VALUES(@NOM)";
                var cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@NOM", tbx_port.Text);
                BDD.REQUEST_SUCCESS(cmd.ExecuteNonQuery());
            }

            catch (MySqlException err)
            {
                BDD.REQUEST_FAILURE(err.Message);
            }

            finally
            {
                if (conn is object & conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
    }
}

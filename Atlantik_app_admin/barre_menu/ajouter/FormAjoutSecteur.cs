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
using Atlantik_app_admin.utils;
using MySql.Data.MySqlClient;

namespace Atlantik_app_admin.barre_menu.ajouter
{
    public partial class FormAjoutSecteur : Form
    {

        MySqlConnection conn = new MySqlConnection(BDD.CONNECTION_STRING);

        public FormAjoutSecteur()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            if (ConfirmerAjout.confirmer() == false) { return; }
            if (tbx_secteur.Text == "")
            {
                InformationManquante.SHOW("le secteur");
                return;
            }

            if(!Regex.IsMatch(tbx_secteur.Text, @"^[A-Za-z]+$"))
            {
                RegexMatchWarning.ONLY_ALPHABETS("pour le nom du secteur");
                return;
            }

            try
            {
                conn.Open();
                string req = "INSERT INTO secteur(NOM) VALUES(@NOM)";
                var cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@NOM", tbx_secteur.Text);
                BDD.REQUEST_SUCCESS(cmd.ExecuteNonQuery());
            } 

            catch(MySqlException err)
            {
                BDD.REQUEST_FAILURE(err.Message);
            }

            finally
            {
                if(conn is object & conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            



        }

    }
}

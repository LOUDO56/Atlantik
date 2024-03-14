using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atlantik_app_admin.utils;
using MySql.Data.MySqlClient;

namespace Atlantik_app_admin.barre_menu.ajouter
{
    public partial class SecteurGui : Form
    {

        MySqlConnection conn = new MySqlConnection(BDD2.CONNECTION_STRING);

        public SecteurGui()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            if (ConfirmerAjout.confirmer() == false) { return; }
            if (ControleSaisie.value(tbx_secteur.Text, "le nom du secteur") == false) { return; }

            try
            {
                conn.Open();
                string req = "INSERT INTO secteur(NOM) VALUES(@NOM)";
                var cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@NOM", tbx_secteur.Text);
                BDD2.REQUEST_SUCCESS(cmd.ExecuteNonQuery());
            } 

            catch(MySqlException err)
            {
                BDD2.REQUEST_FAILURE(err.ToString());
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

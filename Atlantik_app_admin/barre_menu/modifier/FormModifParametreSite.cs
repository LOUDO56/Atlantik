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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik_app_admin.barre_menu.modifier
{
    public partial class FormModifParametreSite : Form
    {

        MySqlConnection conn = new MySqlConnection(BDD.CONNECTION_STRING);

        public FormModifParametreSite()
        {
            InitializeComponent();
        }

        private void FormModifParametreSite_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string req = "SELECT * FROM parametres";
                var cmd = new MySqlCommand(req, conn);
                var param = cmd.ExecuteReader();
                while (param.Read())
                {
                    tbx_site.Text = param["SITE_PB"].ToString();
                    tbx_rang.Text = param["RANG_PB"].ToString();
                    tbx_identifiant.Text = param["IDENTIFIANT_PB"].ToString();
                    tbx_cleHMAC.Text = param["CLEHMAC_PB"].ToString();
                    cbx_production.Checked = param["ENPRODUCTION"].ToString() == "True";
                    tbx_melSite.Text = param["MELSITE"].ToString();

                }
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

        private void btn_modifier_Click(object sender, EventArgs e)
        {

            if(ConfirmerAjout.confirmer() == false) return;

            try
            {
                conn.Open();
                string req = "UPDATE parametres " +
                "SET SITE_PB = @SITE " +
                "WHERE NOIDENTIFIANT = 0; " +

                "UPDATE parametres " +
                "SET RANG_PB = @RANG " +
                "WHERE NOIDENTIFIANT = 0; " +

                "UPDATE parametres " +
                "SET IDENTIFIANT_PB = @IDENTIFIANT " +
                "WHERE NOIDENTIFIANT = 0; " +

                "UPDATE parametres " +
                "SET CLEHMAC_PB = @CLEHMAC " +
                "WHERE NOIDENTIFIANT = 0; " +

                "UPDATE parametres " +
                "SET ENPRODUCTION = @ENPRODUCTION " +
                "WHERE NOIDENTIFIANT = 0; " +

                "UPDATE parametres " +
                "SET MELSITE = @MEL " +
                "WHERE NOIDENTIFIANT = 0; ";

                var cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@SITE", tbx_site.Text);
                cmd.Parameters.AddWithValue("@RANG", tbx_rang.Text);
                cmd.Parameters.AddWithValue("@IDENTIFIANT", tbx_identifiant.Text);
                cmd.Parameters.AddWithValue("@CLEHMAC", tbx_cleHMAC.Text);
                cmd.Parameters.AddWithValue("@ENPRODUCTION", cbx_production.Checked);
                cmd.Parameters.AddWithValue("@MEL", tbx_melSite.Text);
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

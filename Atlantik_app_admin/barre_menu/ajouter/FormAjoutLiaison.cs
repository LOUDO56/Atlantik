using Atlantik_app_admin.utils;
using MySql.Data.MySqlClient;
using Atlantik_app_admin.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using Google.Protobuf.WellKnownTypes;
using System.Collections;

namespace Atlantik_app_admin.barre_menu.ajouter
{
    public partial class FormAjoutLiaison : Form
    {

        MySqlConnection conn = new MySqlConnection(BDD.CONNECTION_STRING);

        public FormAjoutLiaison()
        {
            InitializeComponent();
        }

        private void LiaisonGui_Load(object sender, EventArgs e)
        {



            // Secteurs

            try
            {
                conn.Open();
                string req = "SELECT * FROM secteur";
                var cmd = new MySqlCommand(req, conn);
                var secteurs = cmd.ExecuteReader();
                while (secteurs.Read())
                {
                    lbx_secteur.Items.Add(new Secteur(int.Parse(secteurs["NOSECTEUR"].ToString()), secteurs["NOM"].ToString()));
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


            // Départ
            try
            {
                conn.Open();
                string req = "SELECT * FROM PORT";
                var cmd = new MySqlCommand(req, conn);
                var departs = cmd.ExecuteReader();
                while (departs.Read())
                {
                    cmb_depart_liste.Items.Add(new Port(int.Parse(departs["NOPORT"].ToString()), departs["NOM"].ToString()));
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

            // Arrivé
            try
            {
                conn.Open();
                string req = "SELECT * FROM PORT";
                var cmd = new MySqlCommand(req, conn);
                var arrives = cmd.ExecuteReader();
                while (arrives.Read())
                {
                    cmb_arrivee_list.Items.Add(new Port(int.Parse(arrives["NOPORT"].ToString()), arrives["NOM"].ToString()));
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

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (ConfirmerAjout.confirmer() == false) { return; }
            if (lbx_secteur.SelectedItem == null) 
            {
                InformationManquante.SHOW("le secteur");
                return;
            }
            if (cmb_depart_liste.SelectedItem == null)
            {
                InformationManquante.SHOW("le port de départ");
                return;
            }
            if (cmb_arrivee_list.SelectedItem == null)
            {
                InformationManquante.SHOW("le port d'arrivé");
                return;
            }

            string secteur = ((Secteur)lbx_secteur.SelectedItem).Id.ToString();
            string port_depart = ((Port)cmb_depart_liste.SelectedItem).Id.ToString();
            string port_arrive = ((Port)cmb_arrivee_list.SelectedItem).Id.ToString();
            string distance = tbx_distance_value.Text;

            if(tbx_distance_value.Text == "")
            {
                InformationManquante.SHOW("la distance");
                return;
            }

            try
            {
                conn.Open();
                string req = "INSERT INTO liaison(NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE) " +
                    "VALUES(@NOPORT_DEPART, @NOSECTEUR, @NOPORT_ARRIVEE, @DISTANCE);";
                var cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@NOPORT_DEPART", port_depart);
                cmd.Parameters.AddWithValue("@NOSECTEUR", secteur);
                cmd.Parameters.AddWithValue("@NOPORT_ARRIVEE", port_arrive);
                cmd.Parameters.AddWithValue("@DISTANCE", distance);
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

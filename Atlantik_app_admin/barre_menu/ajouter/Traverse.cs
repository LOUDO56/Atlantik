using Atlantik_app_admin.classes;
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

namespace Atlantik_app_admin.barre_menu.ajouter
{
    public partial class TraverseGui : Form
    {

        MySqlConnection conn = new MySqlConnection(BDD.CONNECTION_STRING);

        public TraverseGui()
        {
            InitializeComponent();
        }

        private void TraverseGui_Load(object sender, EventArgs e)
        {

            cmb_liaison.Enabled = false;
            cmb_liaison.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_liaison.Text = "Sélectionnez.";

            // Secteur
            try
            {
                conn.Open();
                string req = "SELECT * FROM secteur";
                var cmd = new MySqlCommand(req, conn);
                var secteur = cmd.ExecuteReader();
                while (secteur.Read())
                {
                    lbx_secteur.Items.Add(new Secteur(int.Parse(secteur["NOSECTEUR"].ToString()), secteur["NOM"].ToString()));
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

            // Bateau
            try
            {
                conn.Open();
                string req = "SELECT * FROM bateau";
                var cmd = new MySqlCommand(req, conn);
                var bateau = cmd.ExecuteReader();
                while (bateau.Read())
                {
                    cmb_bateau.Items.Add(new Bateau(int.Parse(bateau["NOBATEAU"].ToString()), bateau["NOM"].ToString()));
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

        private void lbx_secteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string req = "SELECT *, " +
                    "p_dep.NOM AS NomPortDepart, " +
                    "p_arr.NOM AS NomPortArrivee, " +
                    "s.NOM AS NomSecteur " +
                    "FROM liaison l " +
                    "INNER JOIN port p_dep ON l.NOPORT_DEPART = p_dep.NOPORT " +
                    "INNER JOIN port p_arr ON l.NOPORT_ARRIVEE = p_arr.NOPORT " +
                    "INNER JOIN secteur s ON l.NOSECTEUR = s.NOSECTEUR " +
                    "WHERE s.NOSECTEUR = @NOSECTEUR;";

                var cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@NOSECTEUR", ((Secteur)lbx_secteur.SelectedItem).Id);
                var liaison = cmd.ExecuteReader();

                cmb_liaison.Items.Clear();

                while (liaison.Read())
                {
                    Port port_depart = new Port(int.Parse(liaison["NOPORT_DEPART"].ToString()), liaison["NomPortDepart"].ToString());
                    Port port_arrivee = new Port(int.Parse(liaison["NOPORT_ARRIVEE"].ToString()), liaison["NomPortArrivee"].ToString());
                    Secteur secteur1 = new Secteur(int.Parse(liaison["NOSECTEUR"].ToString()), liaison["NomSecteur"].ToString());
                    int noLiaison = int.Parse(liaison["NOLIAISON"].ToString());
                    float distance = float.Parse(liaison["DISTANCE"].ToString());

                    cmb_liaison.Items.Add(new Liaison(noLiaison, port_depart, secteur1, port_arrivee, distance));
                }

                // Gérer visuel retour requête
                if (cmb_liaison.Items.Count > 0)
                {
                    cmb_liaison.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmb_liaison.SelectedIndex = 0;
                    cmb_liaison.Enabled = true;
                }
                else
                {
                    cmb_liaison.Enabled = false;
                    cmb_liaison.DropDownStyle = ComboBoxStyle.DropDown;
                    cmb_liaison.Text = "Aucun résultat.";
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

            if (ConfirmerAjout.confirmer() == false) return;

            if (cmb_liaison.Enabled == false)
            {
                MessageBox.Show("La liaison est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(cmb_bateau.SelectedItem == null)
            {
                InformationManquante.SHOW("le bateau");
                return;
            }

            string date_heure_depart = dtp_depart.Value.ToString("yyyy-MM-dd hh:mm:ss").Replace("/", "-");
            string date_heure_arrivee = dtp_arrivee.Value.ToString("yyyy-MM-dd hh:mm:ss").Replace("/", "-");

            try
            {
                conn.Open();
                string req = "INSERT INTO traversee(NOLIAISON, NOBATEAU, DATEHEUREDEPART, DATEHEUREARRIVEE) " +
                    "VALUES(@NOLIAISON, @NOBATEAU, @DATEHEUREDEPART, @DATEHEUREARRIVEE)";
                var cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("NOLIAISON", ((Liaison)cmb_liaison.SelectedItem).Id);
                cmd.Parameters.AddWithValue("NOBATEAU", ((Bateau)cmb_bateau.SelectedItem).Id);
                cmd.Parameters.AddWithValue("DATEHEUREDEPART", date_heure_depart);
                cmd.Parameters.AddWithValue("DATEHEUREARRIVEE", date_heure_arrivee);
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

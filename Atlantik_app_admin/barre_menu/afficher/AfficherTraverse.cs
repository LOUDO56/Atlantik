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

namespace Atlantik_app_admin.barre_menu.afficher
{
    public partial class AfficherTraverse : Form
    {

        MySqlConnection conn = new MySqlConnection(BDD.CONNECTION_STRING);

        public AfficherTraverse()
        {
            InitializeComponent();
        }

        private void AfficherTraverse_Load(object sender, EventArgs e)
        {

            cmb_liaison.Enabled = false;
            cmb_liaison.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_liaison.Text = "Sélectionnez.";

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

            // Ajout colonne

            lv_traverse.Columns.Add("N°");
            lv_traverse.Columns.Add("Heure");
            lv_traverse.Columns.Add("Bateau");

            try
            {
                conn.Open();
                string req = "SELECT * FROM categorie";
                var cmd = new MySqlCommand(req, conn);
                var categorie = cmd.ExecuteReader();
                while (categorie.Read())
                {
                    lv_traverse.Columns.Add(categorie["LETTRECATEGORIE"].ToString() + " " + categorie["LIBELLE"].ToString(), 100);
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

        private void btn_afficherTraverse_Click(object sender, EventArgs e)
        {

            if (cmb_liaison.Enabled == false)
            {
                MessageBox.Show("La liaison est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn.Open();
                lv_traverse.Items.Clear();
                string req = "SELECT *, DATE_FORMAT(DATEHEUREDEPART, '%H:%i') as HEURE FROM traversee " +
                    "INNER JOIN bateau ON traversee.NOBATEAU = bateau.NOBATEAU " +
                    "WHERE traversee.NOLIAISON = @NOLIAISON " +
                    "AND DATE(DATEHEUREDEPART) = @DATEHEUREDEPART";
                var cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@NOLIAISON", ((Liaison)cmb_liaison.SelectedItem).Id);
                cmd.Parameters.AddWithValue("@DATEHEUREDEPART", dtp_date.Value.ToString("yyyy-MM-dd"));
                var traversee = cmd.ExecuteReader();

                var tabItem = new string[5];

                while (traversee.Read())
                {
                    tabItem[0] = traversee["NOTRAVERSEE"].ToString();
                    tabItem[1] = traversee["HEURE"].ToString();
                    tabItem[2] = traversee["NOM"].ToString();
                    lv_traverse.Items.Add(new ListViewItem(tabItem));
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


    }
}

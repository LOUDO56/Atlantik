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
        public TraverseGui()
        {
            InitializeComponent();
        }

        private void TraverseGui_Load(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            if (!bdd.Open()) { return; };

            // Secteur

            MySqlDataReader secteur = bdd.Get("SELECT * FROM secteur");
            if (secteur == null) { return; }

            while (secteur.Read())
            {
                lbx_secteur.Items.Add(new Secteur(int.Parse(secteur["NOSECTEUR"].ToString()), secteur["NOM"].ToString()));
            }

            lbx_secteur.SelectedIndex = 0;

            secteur.Close();

            // Bateau

            MySqlDataReader bateau = bdd.Get("SELECT * FROM bateau");
            if (bateau == null) { return; }

            while (bateau.Read())
            {
                cmb_bateau.Items.Add(new Bateau(int.Parse(bateau["NOBATEAU"].ToString()), bateau["NOM"].ToString()));
            }

            cmb_bateau.SelectedIndex = 0;

            bateau.Close();


        }

        private void lbx_secteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            if (!bdd.Open()) { return; };

            Hashtable param = new Hashtable() {
                { "@NOSECTEUR", ((Secteur)lbx_secteur.SelectedItem).Id }
            };

            MySqlDataReader liaison = bdd.Get("SELECT *, " +
                "p_dep.NOM AS NomPortDepart, " +
                "p_arr.NOM AS NomPortArrivee, " +
                "s.NOM AS NomSecteur " +
                "FROM liaison l " +
                "INNER JOIN port p_dep ON l.NOPORT_DEPART = p_dep.NOPORT " +
                "INNER JOIN port p_arr ON l.NOPORT_ARRIVEE = p_arr.NOPORT " +
                "INNER JOIN secteur s ON l.NOSECTEUR = s.NOSECTEUR " +
                "WHERE s.NOSECTEUR = @NOSECTEUR;"
                , param);

            if (liaison == null) { return; }

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

            liaison.Close();

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

            bdd.Close();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {

            if (ConfirmerAjout.confirmer() == false) return;

            if (cmb_liaison.Enabled == false)
            {
                MessageBox.Show("La liaison est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BDD bdd = new BDD();
            if (!bdd.Open()) return;

            string date_heure_depart = dtp_depart.Value.ToString("yyyy-MM-dd hh:mm:ss").Replace("/", "-");
            string date_heure_arrivee = dtp_arrivee.Value.ToString("yyyy-MM-dd hh:mm:ss").Replace("/", "-");

            bdd.Run("INSERT INTO traversee(NOLIAISON, NOBATEAU, DATEHEUREDEPART, DATEHEUREARRIVEE) VALUES(@NOLIAISON, @NOBATEAU, @DATEHEUREDEPART, @DATEHEUREARRIVEE)",
                new Hashtable
                {
                    {"@NOLIAISON", ((Liaison)cmb_liaison.SelectedItem).Id },
                    {"@NOBATEAU", ((Bateau)cmb_bateau.SelectedItem).Id },
                    {"@DATEHEUREDEPART", date_heure_depart },
                    {"@DATEHEUREARRIVEE", date_heure_arrivee }
                });

            bdd.Close();

        }
    }
}

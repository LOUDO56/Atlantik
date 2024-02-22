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
        public AfficherTraverse()
        {
            InitializeComponent();
        }

        private void AfficherTraverse_Load(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            if (!bdd.Open()) return;

            // Secteurs
            MySqlDataReader secteurs = bdd.Get("SELECT * FROM secteur");
            if (secteurs == null) { return; }
            while (secteurs.Read())
            {
                lbx_secteur.Items.Add(new Secteur(int.Parse(secteurs["NOSECTEUR"].ToString()), secteurs["NOM"].ToString()));
            }
            secteurs.Close();

            lbx_secteur.SelectedIndex = 0;

            // Ajout colonne
            lv_traverse.Columns.Add("N°");
            lv_traverse.Columns.Add("Heure");
            lv_traverse.Columns.Add("Bateau");
            lv_traverse.Columns.Add("A\nPassager");
            lv_traverse.Columns.Add("B\nVéh.inf.2m");
            lv_traverse.Columns.Add("C\nVéh.sup.2m");
        }

        private void lbx_secteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            if (!bdd.Open()) { return; };

            Hashtable param = new Hashtable() {
                { "@NOSECTEUR", ((Secteur)lbx_secteur.SelectedItem).Id.ToString() }
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

        private void btn_afficherTraverse_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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

namespace Atlantik_app_admin.barre_menu.ajouter
{
    public partial class LiaisonGui : Form
    {
        public LiaisonGui()
        {
            InitializeComponent();
        }

        private void LiaisonGui_Load(object sender, EventArgs e)
        {
            BDD bDD = new BDD();
            if (!bDD.Open()) { return; }

            // Secteurs
            MySqlDataReader secteurs = bDD.Get("SELECT * FROM secteur");
            if (secteurs == null) { return; }
            while (secteurs.Read())
            {
                secteur_list.Items.Add(new Secteur(int.Parse(secteurs["NOSECTEUR"].ToString()), secteurs["NOM"].ToString()));
            }
            secteurs.Close();

            // Départ
            MySqlDataReader departs = bDD.Get("SELECT DISTINCT NOPORT,p.NOM FROM port p INNER JOIN liaison l ON p.NOPORT = l.NOPORT_DEPART");
            if (departs == null) { return; }
            while (departs.Read())
            {
                depart_liste.Items.Add(new Port(int.Parse(departs["NOPORT"].ToString()), departs["NOM"].ToString()));
            }
            departs.Close();

            // Arrivé
            MySqlDataReader arrives = bDD.Get("SELECT DISTINCT NOPORT,p.NOM FROM port p INNER JOIN liaison l ON p.NOPORT = l.NOPORT_ARRIVEE");
            if (arrives == null) { return; }
            while (arrives.Read())
            {
                arrivee_list.Items.Add(new Port(int.Parse(arrives["NOPORT"].ToString()), arrives["NOM"].ToString()));
            }
            arrives.Close();

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if(confirmer_ajout.confirmer() == false) { return; }

            string secteur = ((Secteur)secteur_list.SelectedItem).Id.ToString();
            string port_depart = ((Port)depart_liste.SelectedItem).Id.ToString();
            string port_arrive = ((Port)arrivee_list.SelectedItem).Id.ToString();
            string distance = distance_value.Text;

            BDD bDD = new BDD();
            if (!bDD.Open()) { return; }

            bDD.Send("INSERT INTO liaison(NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE) " +
                "VALUES(@NOPORT_DEPART, @NOSECTEUR, @NOPORT_ARRIVEE, @DISTANCE)",

                 new Dictionary<string, string> {
                        {"@NOPORT_DEPART", port_depart},
                        {"@NOSECTEUR", secteur },
                        {"@NOPORT_ARRIVEE", port_arrive },
                        {"@DISTANCE", distance },
                  }
            );
            bDD.Close();


        }
    }
}

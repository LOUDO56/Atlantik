﻿using Atlantik_app_admin.utils;
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
    public partial class LiaisonGui : Form
    {

        MySqlConnection conn = new MySqlConnection(BDD2.CONNECTION_STRING);

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
                lbx_secteur.Items.Add(new Secteur(int.Parse(secteurs["NOSECTEUR"].ToString()), secteurs["NOM"].ToString()));
            }
            secteurs.Close();

            // Départ
            MySqlDataReader departs = bDD.Get("SELECT * FROM PORT");
            if (departs == null) { return; }
            while (departs.Read())
            {
                cmb_depart_liste.Items.Add(new Port(int.Parse(departs["NOPORT"].ToString()), departs["NOM"].ToString()));
            }
            departs.Close();

            // Arrivé
            MySqlDataReader arrives = bDD.Get("SELECT * FROM PORT");
            if (arrives == null) { return; }
            while (arrives.Read())
            {
                cmb_arrivee_list.Items.Add(new Port(int.Parse(arrives["NOPORT"].ToString()), arrives["NOM"].ToString()));
            }
            arrives.Close();

            lbx_secteur.SelectedIndex = 0;
            cmb_depart_liste.SelectedIndex = 0;
            cmb_arrivee_list.SelectedIndex = 0;

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (ConfirmerAjout.confirmer() == false) { return; }

            string secteur = ((Secteur)lbx_secteur.SelectedItem).Id.ToString();
            string port_depart = ((Port)cmb_depart_liste.SelectedItem).Id.ToString();
            string port_arrive = ((Port)cmb_arrivee_list.SelectedItem).Id.ToString();
            string distance = tbx_distance_value.Text;

            if (ControleSaisie.value(distance, "la distance") == false) { return; }

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
                BDD2.REQUEST_SUCCESS(cmd.ExecuteNonQuery());

            }
            catch(MySqlException err)
            {
                BDD2.REQUEST_FAILURE(err.Message);
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

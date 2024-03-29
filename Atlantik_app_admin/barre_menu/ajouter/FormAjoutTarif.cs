﻿using Atlantik_app_admin.classes;
using Atlantik_app_admin.utils;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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

namespace Atlantik_app_admin.barre_menu.ajouter
{

    public partial class FormAjoutTarif : Form
    {

        MySqlConnection conn = new MySqlConnection(BDD.CONNECTION_STRING);

        public FormAjoutTarif()
        {
            InitializeComponent();
        }

        private void Tarif_Load(object sender, EventArgs e)
        {

            cmb_liaison.Enabled = false;
            cmb_liaison.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_liaison.Text = "Sélectionnez.";

            // GroupBox

            int categorie_x = lbl_categorie_type.Location.X;
            int categorie_y = lbl_categorie_type.Location.Y + 35;
            int tarif_x = lbl_tarif.Location.X;
            int tarif_y = lbl_categorie_type.Location.Y + 30;

            try
            {
                conn.Open();
                string req = "SELECT * FROM type";
                var cmd = new MySqlCommand(req, conn);
                var categories = cmd.ExecuteReader();

                while (categories.Read())
                {

                    Label lbl_categorie = new Label();
                    lbl_categorie.AutoSize = true;
                    lbl_categorie.Location = new Point(categorie_x, categorie_y);
                    lbl_categorie.Text = categories["LETTRECATEGORIE"].ToString() + categories["NOTYPE"].ToString() + " - " + categories["LIBELLE"].ToString() + " :";
                    lbl_categorie.Font = new Font("Segoe UI", 9);
                    categorie_y += 40;
                    gbx_tarif.Controls.Add(lbl_categorie);

                    TextBox tbx_tarif = new TextBox();
                    tbx_tarif.Location = new Point(tarif_x, tarif_y);
                    tbx_tarif.Font = new Font("Segoe UI", 9);
                    tbx_tarif.Tag = categories["LETTRECATEGORIE"].ToString() + ";" + categories["NOTYPE"].ToString() + ";" + categories["LIBELLE"].ToString();

                    tarif_y += 40;
                    gbx_tarif.Controls.Add(tbx_tarif);

                }

                // Dynamique d'écran en cas de nouveau tarif
                gbx_tarif.Height = categorie_y;
                this.Height = categorie_y + 160;
                pnl_bottom.Location = new Point(pnl_bottom.Location.X, categorie_y + 45);

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

            // Période

            try
            {
                conn.Open();
                string req = "SELECT * FROM periode";
                var cmd = new MySqlCommand(req, conn);
                var periode = cmd.ExecuteReader();
                while (periode.Read())
                {
                    int noPeriode = int.Parse(periode["NOPERIODE"].ToString());
                    string dateDebut = periode["DATEDEBUT"].ToString().Replace("00:00:00", "");
                    string dateFin = periode["DATEFIN"].ToString().Replace("00:00:00", "");

                    cmb_periode.Items.Add(new Periode(noPeriode, dateDebut, dateFin));

                    cmb_periode.SelectedIndex = 0;
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

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            if (ConfirmerAjout.confirmer() == false) { return; }
            if(cmb_liaison.Enabled == false) 
            {
                MessageBox.Show("La liaison est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Vérifier si toutes les valeurs sont valide et ne contienne pas de lettres.
            foreach(TextBox tarif_value in gbx_tarif.Controls.OfType<TextBox>())
            {

                if (tarif_value.Text != "" && !Regex.IsMatch(tarif_value.Text, @"^[0-9]+$"))
                {
                    string quelCase = tarif_value.Tag.ToString().Split(';')[2];
                    MessageBox.Show("Le tarif dans la case \"" + quelCase + "\" n'est pas valide", "Controle saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            bool cases_vide = true; // true par défaut

            try
            {
                conn.Open();
                string req = "INSERT INTO tarifer(NOPERIODE, LETTRECATEGORIE, NOTYPE, NOLIAISON, TARIF) VALUES ";
                for (int i = 0; i < gbx_tarif.Controls.Count; i++)
                {
                    if(gbx_tarif.Controls[i].GetType() == typeof(TextBox) & gbx_tarif.Controls[i].Text != "")
                    {
                        cases_vide = false;
                        req += $"(@NOPERIODE{i}, @LETTRECATEGORIE{i}, @NOTYPE{i}, @NOLIAISON{i}, @TARIF{i}),";

                    }
                }

                req = req.Remove(req.Length - 1, 1) + ";";

                var cmd = new MySqlCommand(req, conn);

                for (int i = 0; i < gbx_tarif.Controls.Count; i++)
                {
                    if (gbx_tarif.Controls[i].GetType() == typeof(TextBox) & gbx_tarif.Controls[i].Text != "")
                    {
                        string[] type = gbx_tarif.Controls[i].Tag.ToString().Split(';'); // Récupérer la lettre et le type

                        cmd.Parameters.AddWithValue($"@NOPERIODE{i}", ((Periode)cmb_periode.SelectedItem).Id);
                        cmd.Parameters.AddWithValue($"@LETTRECATEGORIE{i}", type[0]);
                        cmd.Parameters.AddWithValue($"@NOTYPE{i}", type[1]);
                        cmd.Parameters.AddWithValue($"@NOLIAISON{i}", ((Liaison)cmb_liaison.SelectedItem).Id);
                        cmd.Parameters.AddWithValue($"@TARIF{i}", gbx_tarif.Controls[i].Text);

                    }
                }

                if (cases_vide)
                {
                    InformationManquante.SHOW("un tarif");
                    return;
                }

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
    }
}

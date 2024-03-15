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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik_app_admin.barre_menu.ajouter
{
    public partial class FormAjoutBateau : Form
    {

        MySqlConnection conn = new MySqlConnection(BDD.CONNECTION_STRING);

        public FormAjoutBateau()
        {
            InitializeComponent();
        }
        private void BateauGui_Load(object sender, EventArgs e)
        {

            int x_lbl = 24;
            int y_lbl = 39;

            int x_tbx = 137;
            int y_tbx = 36;

            try
            {
                conn.Open();
                string req = "SELECT * FROM categorie";
                var cmd = new MySqlCommand(req, conn);
                var categorie = cmd.ExecuteReader();

                while (categorie.Read())
                {
                    Label nom_categorie = new Label();
                    nom_categorie.Text = categorie["LETTRECATEGORIE"].ToString() + " (" + categorie["LIBELLE"] + ") :";
                    nom_categorie.Location = new Point(x_lbl, y_lbl);
                    gbx_capacitesMaximales.Controls.Add(nom_categorie);
                    y_lbl += 60;

                    TextBox valeur_categorie = new TextBox();
                    valeur_categorie.Location = new Point(x_tbx, y_tbx);
                    valeur_categorie.Tag = categorie["LETTRECATEGORIE"].ToString();
                    gbx_capacitesMaximales.Controls.Add(valeur_categorie);

                    y_tbx += 60;

                }

                // Dynamique d'écran en cas de nouvelle catégorie

                gbx_capacitesMaximales.Height = y_lbl - 20;
                this.Height = y_lbl + 50;
                pnl_bateau.Location = new Point(pnl_bateau.Location.X, this.Height - 85);

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

            if(ConfirmerAjout.confirmer() == false) return;
            if(tbx_bateau.Text == "")
            {
                InformationManquante.SHOW("le nom du bateau");
                return;
            }

            

            // Vérifier si toutes les valeurs sont valide et ne contienne pas de lettres.
            foreach (TextBox values in gbx_capacitesMaximales.Controls.OfType<TextBox>())
            {
                if (values.Text != "" && values.Text.Any(x => char.IsLetter(x)))
                {
                    MessageBox.Show("La valeur capacité maximum dans la case \"" + values.Tag + "\" n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Voir si au moins une case de capacité maximum a été rempli.
            int caseVide = 0;

            foreach (TextBox values in gbx_capacitesMaximales.Controls.OfType<TextBox>())
            {
                if (values.Text == "")
                {
                    caseVide++;
                }
            }

            if (caseVide == gbx_capacitesMaximales.Controls.Count / 2)
            {
                MessageBox.Show("Vous n'avez renseigné aucune capacité maximum", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string newIdBateau = "0";

            // Ajout du bateau
            try
            {
                conn.Open();
                string req = "INSERT INTO bateau(NOM) VALUES (@NOM); SELECT LAST_INSERT_ID();";
                var cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@NOM", tbx_bateau.Text);
                newIdBateau = cmd.ExecuteScalar().ToString();
                BDD.REQUEST_SUCCESS(1);
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

            // Ajout des capacités max
            try
            {
                conn.Open();
                string req = "INSERT INTO contenir(LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES ";
                for (int i = 0; i < gbx_capacitesMaximales.Controls.Count; i++)
                {
                    if (gbx_capacitesMaximales.Controls[i].GetType() == typeof(TextBox) & gbx_capacitesMaximales.Controls[i].Text != "")
                    {
                        req += $"(@LETTRECATEGORIE{i}, @NOBATEAU{i}, @CAPACITEMAX{i}),";
                    }
                }

                req = req.Remove(req.Length - 1, 1) + ";";

                var cmd = new MySqlCommand(req, conn);

                for(int i = 0; i < gbx_capacitesMaximales.Controls.Count; i++)
                {
                    if (gbx_capacitesMaximales.Controls[i].GetType() == typeof(TextBox) & gbx_capacitesMaximales.Controls[i].Text != "")
                    {
                        cmd.Parameters.AddWithValue($"@LETTRECATEGORIE{i}", gbx_capacitesMaximales.Controls[i].Tag);
                        cmd.Parameters.AddWithValue($"@NOBATEAU{i}", newIdBateau);
                        cmd.Parameters.AddWithValue($"@CAPACITEMAX{i}", int.Parse(gbx_capacitesMaximales.Controls[i].Text));
                    }
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


    }
}

using Atlantik_app_admin.classes;
using Atlantik_app_admin.utils;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
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
    public partial class FormModifBateau : Form
    {

        MySqlConnection conn = new MySqlConnection(BDD.CONNECTION_STRING);

        public FormModifBateau()
        {
            InitializeComponent();
        }

        private void ModifBateau_Load(object sender, EventArgs e)
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

        private void cmb_bateau_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (TextBox value in gbx_capacitesMaximales.Controls.OfType<TextBox>())
            {
                try
                {
                    conn.Open();
                    string req = "SELECT CAPACITEMAX from contenir " +
                        "WHERE NOBATEAU = @NOBATEAU AND LETTRECATEGORIE = @LETTRECATEGORIE";
                    var cmd = new MySqlCommand(req, conn);
                    cmd.Parameters.AddWithValue("@NOBATEAU", ((Bateau)cmb_bateau.SelectedItem).Id);
                    cmd.Parameters.AddWithValue("@LETTRECATEGORIE", value.Tag);
                    var capaciteMax = cmd.ExecuteScalar();
                    if(capaciteMax != null)
                    {
                        value.Text = capaciteMax.ToString();
                    } else
                    {
                        value.Text = "";
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

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (ConfirmerAjout.confirmer() == false) return;

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
                MessageBox.Show("Vous n'avez renseigné aucune capacité maximum", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string req = "";
                    
            for (int i = 0; i < gbx_capacitesMaximales.Controls.Count; i++)
            {
                if (gbx_capacitesMaximales.Controls[i].GetType() == typeof(TextBox) & gbx_capacitesMaximales.Controls[i].Text != "")
                {
                    req += $"UPDATE contenir SET CAPACITEMAX = @CAPACITEMAX{i} " +
                        $"WHERE NOBATEAU = @NOBATEAU{i} AND LETTRECATEGORIE = @LETTRECATEGORIE{i};";
                }
            }

            try
            {
                conn.Open();
                var cmd = new MySqlCommand(req, conn);

                for (int i = 0; i < gbx_capacitesMaximales.Controls.Count; i++)
                {
                    if (gbx_capacitesMaximales.Controls[i].GetType() == typeof(TextBox) & gbx_capacitesMaximales.Controls[i].Text != "")
                    {
                        cmd.Parameters.AddWithValue($"@CAPACITEMAX{i}", double.Parse(gbx_capacitesMaximales.Controls[i].Text));
                        cmd.Parameters.AddWithValue($"@NOBATEAU{i}", ((Bateau)cmb_bateau.SelectedItem).Id);
                        cmd.Parameters.AddWithValue($"@LETTRECATEGORIE{i}", gbx_capacitesMaximales.Controls[i].Tag);
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

using Atlantik_app_admin.classes;
using Atlantik_app_admin.utils;
using Google.Protobuf.WellKnownTypes;
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

namespace Atlantik_app_admin.barre_menu.modifier
{
    public partial class ModifBateau : Form
    {

        private List<TextBox> tbx_capaciteMaxArray = new List<TextBox>();

        public ModifBateau()
        {
            InitializeComponent();
        }

        private void ModifBateau_Load(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            if (!bdd.Open()) { return; }

            MySqlDataReader categorie = bdd.Get("SELECT * FROM categorie");
            if (categorie == null) { return; }

            int x_lbl = 24;
            int y_lbl = 39;

            int x_tbx = 137;
            int y_tbx = 36;

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
                tbx_capaciteMaxArray.Add(valeur_categorie);
                gbx_capacitesMaximales.Controls.Add(valeur_categorie);

                y_tbx += 60;


            }

            categorie.Close();

            // Dynamique d'écran en cas de nouvelle catégorie

            gbx_capacitesMaximales.Height = y_lbl - 20;
            this.Height = y_lbl + 50;
            pnl_bateau.Location = new Point(pnl_bateau.Location.X, this.Height - 85);


            // Bateau

            MySqlDataReader bateau = bdd.Get("SELECT * FROM bateau");
            if (bateau == null) { return; }

            while (bateau.Read())
            {
                cmb_bateau.Items.Add(new Bateau(int.Parse(bateau["NOBATEAU"].ToString()), bateau["NOM"].ToString()));
            }

            cmb_bateau.SelectedIndex = 0;

            bdd.Close();
        }

        private void cmb_bateau_SelectedIndexChanged(object sender, EventArgs e)
        {

            BDD bdd = new BDD();
            if (!bdd.Open()) { return; }


            foreach (TextBox value in tbx_capaciteMaxArray)
            {
                MySqlDataReader capaciteMax = bdd.Get("SELECT CAPACITEMAX from contenir " +
                    "WHERE NOBATEAU = @NOBATEAU AND LETTRECATEGORIE = @LETTRECATEGORIE",
                    new Hashtable
                    {
                        {"@NOBATEAU", ((Bateau)cmb_bateau.SelectedItem).Id },
                        {"@LETTRECATEGORIE", value.Tag},
                    });

                if (capaciteMax.Read())
                {
                    value.Text = capaciteMax["CAPACITEMAX"].ToString();
                } else
                {
                    value.Text = "";
                }

                capaciteMax.Close();
            }

            bdd.Close();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (ConfirmerAjout.confirmer() == false) return;

            BDD bdd = new BDD();
            if (!bdd.Open()) { return; }

            // Vérifier si toutes les valeurs sont valide et ne contienne pas de lettres.
            foreach (TextBox values in tbx_capaciteMaxArray)
            {
                if (values.Text != "" && values.Text.Any(x => char.IsLetter(x)))
                {
                    MessageBox.Show("La valeur capacité maximum dans la case \"" + values.Tag + "\" n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Voir si au moins une case de capacité maximum a été rempli.
            int caseVide = 0;

            foreach (TextBox values in tbx_capaciteMaxArray)
            {
                if (values.Text == "")
                {
                    caseVide++;
                }
            }

            if (caseVide == tbx_capaciteMaxArray.Count)
            {
                MessageBox.Show("Vous n'avez renseigné aucune capacité maximum", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (TextBox value in tbx_capaciteMaxArray)
            {
                if (value.Text != "")
                {

                    bdd.Run("UPDATE contenir SET CAPACITEMAX = @CAPACITEMAX " +
                        "WHERE NOBATEAU = @NOBATEAU AND LETTRECATEGORIE = @LETTRECATEGORIE",
                        new Hashtable {
                            { "@CAPACITEMAX", double.Parse(value.Text) },
                            { "@NOBATEAU", ((Bateau)cmb_bateau.SelectedItem).Id },
                            {"@LETTRECATEGORIE", value.Tag}
                        });
                }
            }

            bdd.Close();
        }
    }
}

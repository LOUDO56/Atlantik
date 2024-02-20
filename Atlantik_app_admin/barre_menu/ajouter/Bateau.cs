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
    public partial class BateauGui : Form
    {

        private List<TextBox> tbx_capaciteMaxArray = new List<TextBox>();

        public BateauGui()
        {
            InitializeComponent();
        }
        private void BateauGui_Load(object sender, EventArgs e)
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

            bdd.Close();


        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {

            if(ConfirmerAjout.confirmer() == false) return;
            if (ControleSaisie.value(tbx_bateau.Text, "le nom du bateau") == false) return;

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
                if(values.Text == "")
                {
                    caseVide++;
                }
            }

            if(caseVide == tbx_capaciteMaxArray.Count)
            {
                MessageBox.Show("Vous n'avez renseigné aucune capacité maximum", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlDataReader noBateau = bdd.Get("SELECT MAX(nobateau) FROM bateau");
            if(noBateau ==  null) return;

            int newIdBateau = 0;
            while(noBateau.Read()) 
            {
                newIdBateau = int.Parse(noBateau["MAX(nobateau)"].ToString()) + 1;
            }

            noBateau.Close();

            bdd.Run("INSERT INTO bateau(NOM) VALUES (@NOM)", new Hashtable {
                { "@NOM", tbx_bateau.Text } 
            });

            bool ajout_effectue = false;

            foreach (TextBox values in tbx_capaciteMaxArray)
            {
                if(values.Text != "") {

                    ajout_effectue = true;

                    bdd.Run("INSERT INTO contenir(LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) " +
                        "VALUES(@LETTRECATEGORIE, @NOBATEAU, @CAPACITEMAX)", 
                        new Hashtable {
                            { "@LETTRECATEGORIE", values.Tag },
                            { "@NOBATEAU", newIdBateau },
                            { "@CAPACITEMAX", int.Parse(values.Text) }
                        });
                }
            }

            bdd.Close();



        }


    }
}

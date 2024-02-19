using Atlantik_app_admin.utils;
using MySql.Data.MySqlClient;
using System;
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
                valeur_categorie.Tag = nom_categorie.Text.Replace(" :", "");
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

            BDD bdd = new BDD();
            if (!bdd.Open()) { return; }




        }


    }
}

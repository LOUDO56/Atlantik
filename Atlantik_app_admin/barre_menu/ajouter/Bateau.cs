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

            int x_template_lbl = 24;
            int y_template_lbl = 59;

            int x_template_tbx = 137;
            int y_template_tbx = 56;

            while (categorie.Read())
            {
                Label nom_categorie = new Label();
                nom_categorie.Text = categorie["LETTRECATEGORIE"].ToString() + " (" + categorie["LIBELLE"] + ") :";
                nom_categorie.Location = new Point(x_template_lbl, y_template_lbl);
                gbx_capacitesMaximales.Controls.Add(nom_categorie);
                y_template_lbl += 60;

                TextBox valeur_categorie = new TextBox();
                valeur_categorie.Location = new Point(x_template_tbx, y_template_tbx);
                valeur_categorie.Tag = nom_categorie.Text.Replace(" :", "");
                gbx_capacitesMaximales.Controls.Add(valeur_categorie);


                y_template_tbx += 60;


            }

            if (y_template_lbl > gbx_capacitesMaximales.Height)
            {

            }

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {

        }


    }
}

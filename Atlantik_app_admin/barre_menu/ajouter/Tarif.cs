using Atlantik_app_admin.utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik_app_admin.barre_menu.ajouter
{
    public partial class TarifGui : Form
    {
        public TarifGui()
        {
            InitializeComponent();
        }

        private void Tarif_Load(object sender, EventArgs e)
        {
            BDD bdd = new BDD();

            if (!bdd.Open()) { return; }

            // GroupBox

            int categorie_x = lbl_categorie_type.Location.X;
            int categorie_y = lbl_categorie_type.Location.Y + 35;
            int tarif_x = lbl_tarif.Location.X;
            int tarif_y = lbl_categorie_type.Location.Y + 30;

            MySqlDataReader categories = bdd.Get("SELECT * FROM type");
            if (categories == null) { return; }

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
                tarif_y += 40;
                gbx_tarif.Controls.Add(tbx_tarif);
            }

            categories.Close();



        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

        }
    }
}

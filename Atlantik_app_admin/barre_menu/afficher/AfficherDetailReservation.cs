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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik_app_admin.barre_menu.afficher
{
    public partial class AfficherDetailReservation : Form
    {
        public AfficherDetailReservation()
        {
            InitializeComponent();
        }

        private void AfficherDetailReservation_Load(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            if (!bdd.Open()) return;

            MySqlDataReader client = bdd.Get("SELECT noclient,nom,prenom FROM client");
            if (client == null) return;

            while (client.Read())
            {
                cmb_nom.Items.Add(new Client(int.Parse(client["NOCLIENT"].ToString()),
                    client["NOM"].ToString(),
                    client["PRENOM"].ToString()));
            }

            client.Close();
            cmb_nom.SelectedIndex = 0;

            lv_detail.Columns.Add("N° Réservation", 100);
            lv_detail.Columns.Add("Liaison", 130);
            lv_detail.Columns.Add("N° Traversée", 100);
            lv_detail.Columns.Add("Date départ", 130);

            MySqlDataReader detail_reservation = bdd.Get("SELECT *, p_dep.NOM AS NomPortDepart, p_arr.NOM AS NomPortArrivee " +
                "FROM reservation " +
                "INNER JOIN traversee ON reservation.NORESERVATION = traversee.NOTRAVERSEE " +
                "INNER JOIN liaison ON traversee.NOLIAISON = liaison.NOLIAISON " +
                "INNER JOIN port p_dep ON liaison.NOPORT_DEPART = p_dep.NOPORT " +
                "INNER JOIN port p_arr ON liaison.NOPORT_ARRIVEE = p_arr.NOPORT "
                );

            if (detail_reservation == null) return;

            while (detail_reservation.Read())
            {
                var tabItem = new string[4];
                tabItem[0] = detail_reservation["NORESERVATION"].ToString();
                tabItem[1] = detail_reservation["NomPortDepart"].ToString() + "-" + detail_reservation["NomPortArrivee"].ToString();
                tabItem[2] = detail_reservation["NOTRAVERSEE"].ToString();
                tabItem[3] = detail_reservation["DATEHEUREDEPART"].ToString();
                lv_detail.Items.Add(new ListViewItem(tabItem));

            }

            detail_reservation.Close();

            if (lv_detail.Items.Count > 0)
            {
                lv_detail.Items[0].Selected = true;
                lv_detail.Select();
            }

            bdd.Close();

        }

        private void lv_detail_SelectedIndexChanged(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            if(!bdd.Open()) return;

            var noReservation = lv_detail.SelectedItems[0];

            MySqlDataReader tarif_reservation = bdd.Get("SELECT LIBELLE from enregistrer " +
                "INNER JOIN type ON enregistrer.NOTYPE = type.NOTYPE " +
                "WHERE NORESERVATION = @NORESERVATION", new Hashtable
                {
                    { "@NORESERVATION", noReservation }
                });

            if (tarif_reservation != null) return;
            
            int lbl_tarif_pos_x = 34;
            int lbl_tarif_pos_y = 42;

            while (tarif_reservation.Read())
            {
                Label lbl_tarif = new Label();
                lbl_tarif.Location = new Point(lbl_tarif_pos_x, lbl_tarif_pos_y);
                lbl_tarif.Text = tarif_reservation["LIBELLE"].ToString();
                lbl_tarif_pos_y += 15;
                gbx_reservation.Controls.Add(lbl_tarif);
            }

            tarif_reservation.Close();



        }
    }
}

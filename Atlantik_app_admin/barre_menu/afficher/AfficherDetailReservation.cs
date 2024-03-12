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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            //if (lv_detail.Items.Count > 0)
            //{
                //lv_detail.Items[0].Selected = true;
              //  lv_detail.Select();
            //}

            bdd.Close();

        }

        private void lv_detail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_detail.SelectedItems.Count == 0) return;

            BDD bdd = new BDD();
            if (!bdd.Open()) return;

            gbx_reservation.Controls.Clear();
            string noReservation = "";
           
            noReservation = lv_detail.SelectedItems[0].Text;


            MySqlDataReader tarif_reservation = bdd.Get("SELECT type.LIBELLE, enregistrer.QUANTITERESERVEE FROM enregistrer " +
                "JOIN type ON enregistrer.LETTRECATEGORIE = type.LETTRECATEGORIE AND enregistrer.NOTYPE = type.NOTYPE " +
                "WHERE NORESERVATION = @NORESERVATION", new Hashtable
                {
                    { "@NORESERVATION", noReservation }
                });

            if (tarif_reservation == null) return;
            
            int lbl_pos_x = 34;
            int lbl_pos_y = 42;

            while (tarif_reservation.Read())
            {
                Label lbl_tarif = new Label();
                lbl_tarif.Location = new Point(lbl_pos_x, lbl_pos_y);
                lbl_tarif.AutoSize = true;
                lbl_tarif.Text = tarif_reservation["LIBELLE"].ToString() + " :";
                lbl_tarif.Font = new Font("Segoe UI", 9);
                gbx_reservation.Controls.Add(lbl_tarif);

                Label lbl_quantitereserve = new Label();
                lbl_quantitereserve.Location = new Point(lbl_pos_x + 200, lbl_pos_y);
                lbl_quantitereserve.AutoSize = true;
                lbl_quantitereserve.Text = tarif_reservation["QUANTITERESERVEE"].ToString();
                lbl_quantitereserve.Font = new Font("Segoe UI", 9);
                gbx_reservation.Controls.Add(lbl_quantitereserve);

                lbl_pos_y += 30;

            }

            tarif_reservation.Close();

            MySqlDataReader payement = bdd.Get("SELECT MONTANTTOTAL, MODEREGLEMENT FROM reservation " +
                "WHERE NORESERVATION = @NORESERVATION", new Hashtable
                {
                    { "@NORESERVATION", noReservation }
                });

            payement.Read();
            
            // Texte montant total
            Label lbl_montanttotal = new Label();
            lbl_montanttotal.Location = new Point(lbl_pos_x, lbl_pos_y);
            lbl_montanttotal.AutoSize = true;
            lbl_montanttotal.Text = "Montant total :";
            lbl_montanttotal.Font = new Font("Segoe UI", 9);
            gbx_reservation.Controls.Add(lbl_montanttotal);


            // Affichage du montant total
            Label lbl_montanttotal_value = new Label();
            lbl_montanttotal_value.Location = new Point(lbl_pos_x + 200, lbl_pos_y);
            lbl_montanttotal_value.AutoSize = true;
            lbl_montanttotal_value.Text = payement["MONTANTTOTAL"].ToString() + "€";
            lbl_montanttotal_value.Font = new Font("Segoe UI", 9);
            gbx_reservation.Controls.Add(lbl_montanttotal_value);

            lbl_pos_y += 30;

            Label lbl_reglement = new Label();
            lbl_reglement.Location = new Point(lbl_pos_x, lbl_pos_y);
            lbl_reglement.AutoSize = true;
            string reglement = payement["MODEREGLEMENT"].ToString();
            if(reglement == "")
            {
                reglement = "Inconnu.";
            }
            lbl_reglement.Text = "Réglement via : " + reglement;
            lbl_reglement.Font = new Font("Segoe UI", 9);
            gbx_reservation.Controls.Add(lbl_reglement);

            

            payement.Close();

            // Génération dynamique
            gbx_reservation.Height = lbl_pos_y + 50;

            if(gbx_reservation.Height > 300)
            {
                this.Height = gbx_reservation.Height + 250;
            } else
            {
                this.Height = 492;
            }

            bdd.Close();


        }
    }
}

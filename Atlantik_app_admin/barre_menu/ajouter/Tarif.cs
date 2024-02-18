using Atlantik_app_admin.classes;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik_app_admin.barre_menu.ajouter
{
    public partial class TarifGui : Form
    {
        private List<Type> typeArray = new List<Type>();
        private List<TextBox> tbx_tarifArray = new List<TextBox>();

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
                Type newType = new Type(categories["LETTRECATEGORIE"].ToString(), int.Parse(categories["NOTYPE"].ToString()), categories["LIBELLE"].ToString());
                typeArray.Add(newType);

                Label lbl_categorie = new Label();
                lbl_categorie.AutoSize = true;
                lbl_categorie.Location = new Point(categorie_x, categorie_y);
                lbl_categorie.Text = newType.LettreCategorie + newType.TypeNombre + " - " + newType.Libelle + " :";
                lbl_categorie.Font = new Font("Segoe UI", 9);
                categorie_y += 40;
                gbx_tarif.Controls.Add(lbl_categorie);

                TextBox tbx_tarif = new TextBox();
                tbx_tarif.Location = new Point(tarif_x, tarif_y);
                tbx_tarif.Font = new Font("Segoe UI", 9);
                tbx_tarifArray.Add(tbx_tarif);
                tarif_y += 40;
                gbx_tarif.Controls.Add(tbx_tarif);

            }

            // Dynamique d'écran en cas de nouveau tarif
            gbx_tarif.Height = categorie_y;
            this.Height = categorie_y + 160;
            pnl_bottom.Location = new Point(pnl_bottom.Location.X, categorie_y + 45);

            categories.Close();

            // Secteur

            MySqlDataReader secteur = bdd.Get("SELECT * FROM secteur");
            if (secteur == null) { return; }

            while (secteur.Read())
            {
                lbx_secteur.Items.Add(new Secteur(int.Parse(secteur["NOSECTEUR"].ToString()), secteur["NOM"].ToString()));
            }

            lbx_secteur.SelectedIndex = 0;

            secteur.Close();

            

            // Période

            MySqlDataReader periode = bdd.Get("SELECT * FROM periode");
            if (periode == null) { return; }

            while (periode.Read())
            {
                int noPeriode = int.Parse(periode["NOPERIODE"].ToString());
                string dateDebut = periode["DATEDEBUT"].ToString().Replace("00:00:00", "");
                string dateFin = periode["DATEFIN"].ToString().Replace("00:00:00", "");

                cbx_periode.Items.Add(new Periode(noPeriode, dateDebut, dateFin));
            }

            cbx_periode.SelectedIndex = 0;
            periode.Close();

            bdd.Close();

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            if (ConfirmerAjout.confirmer() == false) { return; }

            BDD bdd = new BDD();
            if (!bdd.Open()) { return; }

            // Créez une liste pour stocker les paramètres des insertions
            List<Hashtable> paramList = new List<Hashtable>();

            for (int i = 0; i < tbx_tarifArray.Count; i++)
            {
                if (tbx_tarifArray[i].Text != "")
                {
                    Hashtable param = new Hashtable() {
            {"@NOPERIODE", ((Periode)cbx_periode.SelectedItem).Id },
            {"@LETTRECATEGORIE", typeArray[i].LettreCategorie},
            {"@NOTYPE", typeArray[i].TypeNombre },
            {"@NOLIAISON", ((Liaison)cbx_liaison.SelectedItem).Id },
            {"@TARIF", tbx_tarifArray[i].Text }
        };

                    // Ajoutez les paramètres à la liste
                    paramList.Add(param);
                }
            }

            if (paramList.Count > 0)
            {
                // Créez une seule instruction d'insertion avec des paramètres multiples
                string query = "INSERT INTO tarifer(NOPERIODE, LETTRECATEGORIE, NOTYPE, NOLIAISON, TARIF) VALUES ";

                for (int i = 0; i < paramList.Count; i++)
                {
                    query += "(@NOPERIODE" + i + ", @LETTRECATEGORIE" + i + ", @NOTYPE" + i + ", @NOLIAISON" + i + ", @TARIF" + i + "),";
                }

                // Supprimez la virgule finale
                query = query.TrimEnd(',');

                // Exécutez la commande avec une seule requête
                bdd.SendMultiple(query, paramList);
            }

            bdd.Close();



        }

        private void lbx_secteur_SelectedIndexChanged(object sender, EventArgs e)
        {   

            BDD bdd = new BDD();
            if (!bdd.Open()) { return; };

            Hashtable param = new Hashtable() {
                { "@NOSECTEUR", ((Secteur)lbx_secteur.SelectedItem).Id.ToString() }
            };

            MySqlDataReader liaison = bdd.Get("SELECT *, " +
                "p_dep.NOM AS NomPortDepart, " +
                "p_arr.NOM AS NomPortArrivee, " +
                "s.NOM AS NomSecteur " +
                "FROM liaison l " +
                "INNER JOIN port p_dep ON l.NOPORT_DEPART = p_dep.NOPORT " +
                "INNER JOIN port p_arr ON l.NOPORT_ARRIVEE = p_arr.NOPORT " +
                "INNER JOIN secteur s ON l.NOSECTEUR = s.NOSECTEUR " +
                "WHERE s.NOSECTEUR = @NOSECTEUR;"
                , param);

            if (liaison == null) { return; }

            cbx_liaison.Items.Clear();

            while (liaison.Read())
            {
                Port port_depart = new Port(int.Parse(liaison["NOPORT_DEPART"].ToString()), liaison["NomPortDepart"].ToString());
                Port port_arrivee = new Port(int.Parse(liaison["NOPORT_ARRIVEE"].ToString()), liaison["NomPortArrivee"].ToString());
                Secteur secteur1 = new Secteur(int.Parse(liaison["NOSECTEUR"].ToString()), liaison["NomSecteur"].ToString());
                int noLiaison = int.Parse(liaison["NOLIAISON"].ToString());
                float distance = float.Parse(liaison["DISTANCE"].ToString());

                cbx_liaison.Items.Add(new Liaison(noLiaison, port_depart, secteur1, port_arrivee, distance));
            }

            liaison.Close();

            // Gérer visuel retour requête
            if(cbx_liaison.Items.Count > 0)
            {
                cbx_liaison.DropDownStyle = ComboBoxStyle.DropDownList;
                cbx_liaison.SelectedIndex = 0;
                cbx_liaison.Enabled = true;
            } else
            {
                cbx_liaison.Enabled = false;
                cbx_liaison.DropDownStyle = ComboBoxStyle.DropDown;
                cbx_liaison.Text = "Aucun résultat.";
            }

            bdd.Close();
        }
    }
}

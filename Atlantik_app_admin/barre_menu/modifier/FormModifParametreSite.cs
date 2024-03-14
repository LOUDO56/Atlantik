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

namespace Atlantik_app_admin.barre_menu.modifier
{
    public partial class FormModifParametreSite : Form
    {
        public FormModifParametreSite()
        {
            InitializeComponent();
        }

        private void FormModifParametreSite_Load(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            if (!bdd.Open()) return;

            MySqlDataReader param = bdd.Get("SELECT * FROM parametres");
            if (param == null) return;

            while (param.Read())
            {
                tbx_site.Text = param["SITE_PB"].ToString();
                tbx_rang.Text = param["RANG_PB"].ToString();
                tbx_identifiant.Text = param["IDENTIFIANT_PB"].ToString();
                tbx_cleHMAC.Text = param["CLEHMAC_PB"].ToString();
                cbx_production.Checked = param["ENPRODUCTION"].ToString() == "True";
                tbx_melSite.Text = param["MELSITE"].ToString();

            }

            param.Close();

            bdd.Close();

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {

            if(ConfirmerAjout.confirmer() == false) return;

            BDD bdd = new BDD();
            if (!bdd.Open()) return;

            Hashtable param_modif = new Hashtable();
            param_modif.Add("@SITE", tbx_site.Text);
            param_modif.Add("@RANG", tbx_rang.Text);
            param_modif.Add("@IDENTIFIANT", tbx_identifiant.Text);
            param_modif.Add("@CLEHMAC", tbx_cleHMAC.Text);
            param_modif.Add("@ENPRODUCTION", cbx_production.Checked);
            param_modif.Add("@MEL", tbx_melSite.Text);

            bdd.Run("UPDATE parametres " +
                "SET SITE_PB = @SITE " +
                "WHERE NOIDENTIFIANT = 0; " +

                "UPDATE parametres " +
                "SET RANG_PB = @RANG " +
                "WHERE NOIDENTIFIANT = 0; " +

                "UPDATE parametres " +
                "SET IDENTIFIANT_PB = @IDENTIFIANT " +
                "WHERE NOIDENTIFIANT = 0; " +

                "UPDATE parametres " +
                "SET CLEHMAC_PB = @CLEHMAC " +
                "WHERE NOIDENTIFIANT = 0; " +

                "UPDATE parametres " +
                "SET ENPRODUCTION = @CLEHMAC " +
                "WHERE NOIDENTIFIANT = 0; " +

                "UPDATE parametres " +
                "SET MELSITE = @MEL " +
                "WHERE NOIDENTIFIANT = 0; "
                , param_modif);

            bdd.Close();

        }
    }
}

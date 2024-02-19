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
using Atlantik_app_admin.utils;
using MySql.Data.MySqlClient;

namespace Atlantik_app_admin.barre_menu.ajouter
{
    public partial class SecteurGui : Form
    {
        public SecteurGui()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            if (ConfirmerAjout.confirmer() == false) { return; }
            if (ControleSaisie.value(tbx_values.Text, "le nom du secteur") == false) { return; }

            BDD bDD = new BDD();
            if (!bDD.Open()) return; // Si la connexion à la bdd ne fonctionne pas, dans ce cas on stop le programme

            
            bDD.Set("INSERT INTO secteur(NOM) VALUES(@nom)", 
                new Hashtable() {
                    { "@nom", tbx_values.Text },
                }
            );
            bDD.Close();

        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

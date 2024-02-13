using System;
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

        private void confirm_add_secteur_Click(object sender, EventArgs e)
        {
            BDD bDD = new BDD();
            if (!bDD.Open()) return; // Si la connexion à la bdd ne fonctionne pas, dans ce cas on stop le programme

            Dictionary<string, string> param = new Dictionary<string, string> {
                {"@nom", secteur_textbox.Text}
            };
            bDD.Send("INSERT INTO secteur(NOM) VALUES(@nom)", param);
            bDD.Close();

        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

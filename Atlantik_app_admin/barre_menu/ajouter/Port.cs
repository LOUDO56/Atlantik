using Atlantik_app_admin.utils;
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
    public partial class PortGui : Form
    {
        public PortGui()
        {
            InitializeComponent();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(ConfirmerAjout.confirmer() == false) { return; }
            if (ControleSaisie.value(tbx_values.Text, "le nom du port") == false) { return; }

            BDD bDD = new BDD();
            if (!bDD.Open()) return; // Si la connexion à la bdd ne fonctionne pas, dans ce cas on stop le programme

            bDD.Send("INSERT INTO port(NOM) VALUES(@nom)", new Dictionary<string, string> {
                {"@nom", tbx_values.Text}
            });

            bDD.Close();
        }
    }
}

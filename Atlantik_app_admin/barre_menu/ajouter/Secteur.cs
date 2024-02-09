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
            try
            {
                bDD.Open();
            } catch(MySqlException ex)
            {
                gestion_erreur.Text = "Connection impossible : " + ex.Message;
                return;
            }

            try
            {
                string request = "INSERT INTO secteur(NOM) VALUES(@nom)";
                var maCde = new MySqlCommand(request, bDD.get());

                maCde.Parameters.AddWithValue("@nom", secteur_textbox.Text);
                maCde.ExecuteScalar();
                gestion_erreur.Text = "Ligne ajouté avec succès.";
            } catch (MySqlException ex)
            {
                gestion_erreur.Text += "Erreur durant insertion : " + ex.Message;
            } finally { bDD.Close(); }

        }
    }
}

using Atlantik_app_admin.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Atlantik_app_admin.utils
{
    internal class BDD
    {
        private static string HOST = "127.0.0.1";
        private static string PORT = "3306";
        private static string USERNAME = "root";
        private static string PASSWORD = "";
        private static string DBNAME = "atlantik";
        public static string CONNECTION_STRING = $"Server={HOST};Port={PORT};User Id={USERNAME};Password={PASSWORD};Database={DBNAME};";

        public static void REQUEST_SUCCESS(int nbLigneAffecte)
        {
            string pluriel = "";
            if (nbLigneAffecte > 1)
            {
                pluriel = "s";
            }

            MessageBox.Show($"Requête effectué avec succès. {nbLigneAffecte} ligne{pluriel} affecté.", "Requête effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void REQUEST_FAILURE(string ERROR_STRING)
        {
            MessageBox.Show(ERROR_STRING, "Erreur durant requête SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

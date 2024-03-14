﻿using Atlantik_app_admin.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Atlantik_app_admin.utils
{
    internal class BDD2
    {
        private static string HOST = "127.0.0.1";
        private static string PORT = "3306";
        private static string USERNAME = "root";
        private static string PASSWORD = "";
        private static string DBNAME = "atlantik";
        public static string CONNECTION_STRING = $"Server={HOST};Port={PORT};User Id={USERNAME};Password={PASSWORD};Database={DBNAME};";
        
        public static void CONNECTION_FAILURE(string ERROR_STRING)
        {
            MessageBox.Show(ERROR_STRING, "Erreur durant connexion Atlantik BDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

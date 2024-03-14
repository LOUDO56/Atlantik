﻿using Atlantik_app_admin.utils;
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

namespace Atlantik_app_admin.barre_menu.ajouter
{
    public partial class PortGui : Form
    {

        MySqlConnection conn = new MySqlConnection(BDD2.CONNECTION_STRING);

        public PortGui()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(ConfirmerAjout.confirmer() == false) { return; }
            if (ControleSaisie.value(tbx_port.Text, "le nom du port") == false) { return; }

            try
            {
                conn.Open();
                string req = "INSERT INTO port(NOM) VALUES(@NOM)";
                var cmd = new MySqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@NOM", tbx_port.Text);
                BDD2.REQUEST_SUCCESS(cmd.ExecuteNonQuery());
            }

            catch (MySqlException err)
            {
                BDD2.REQUEST_FAILURE(err.ToString());
            }

            finally
            {
                if (conn is object & conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
    }
}

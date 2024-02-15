using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.utils
{
    internal class ControleSaisie
    {
        public static bool value(string text, string type)
        {
            if (text == "")
            {
                MessageBox.Show($"Il manque {type}.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}

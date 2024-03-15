using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.utils
{
    internal class InformationManquante
    {
        public static void SHOW(string message)
        {
            MessageBox.Show("Il vous manque " + message, "Valeur manquante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

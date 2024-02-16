using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.utils
{
    internal class ConfirmerAjout
    {

        public static bool confirmer()
        {
            DialogResult res = MessageBox.Show("Êtes-vous sûr?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

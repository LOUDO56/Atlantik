using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.utils
{
    internal class confirmer_ajout
    {

        public static bool confirmer()
        {
            DialogResult res = MessageBox.Show("Voulez-vous continuer?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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

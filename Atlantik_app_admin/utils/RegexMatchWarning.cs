using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.utils
{
    internal class RegexMatchWarning
    {
        public static void ONLY_ALPHABETS(string target)
        {
            MessageBox.Show("Veuillez utiliser seulement des lettres " + target + " !", "Controle de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ONLY_NUMBERS(string target)
        {
            MessageBox.Show("Veuillez utiliser seulement des nombres " + target + " !", "Controle de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

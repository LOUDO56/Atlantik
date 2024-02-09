using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.classes
{
    internal class Secteur
    {

        private int id;
        private string nom;

        public Secteur(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return nom; }
            set { nom = value; }
        }
    }
}

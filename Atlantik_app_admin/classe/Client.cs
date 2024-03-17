using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.classes
{
    internal class Client
    {
        private int id;
        private string nom;
        private string prenom;

        public Client(int id, string nom, string prenom) 
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }
        public int Id
        {
            get { return id; }
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Prenom
        {
            get { return prenom; }
        }

        public override string ToString()
        {
            return nom + " " + prenom;
        }

    }
}

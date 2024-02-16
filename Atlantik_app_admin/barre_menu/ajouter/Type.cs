using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.barre_menu.ajouter
{
    internal class Type
    {

        private string lettre_categorie;
        private string type;
        private string libelle;

        public Type(string lettre_categorie, string type, string libelle) 
        {
            this.lettre_categorie = lettre_categorie;
            this.type = type;
            this.libelle = libelle;
        }

        public string LettreCategorie
        {
            get { return lettre_categorie; }
        }

        public string TypeNombre
        {
            get { return type; }
        }

        public string Libelle
        {
            get { return libelle; }
        }

    }
}

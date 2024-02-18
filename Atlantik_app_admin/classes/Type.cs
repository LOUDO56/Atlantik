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
        private int type;
        private string libelle;

        public Type(string lettre_categorie, int type, string libelle) 
        {
            this.lettre_categorie = lettre_categorie;
            this.type = type;
            this.libelle = libelle;
        }

        public string LettreCategorie
        {
            get { return lettre_categorie; }
        }

        public int TypeNombre
        {
            get { return type; }
        }

        public string Libelle
        {
            get { return libelle; }
        }

    }
}

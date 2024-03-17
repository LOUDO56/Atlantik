using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.classes
{
    internal class Port
    {
        private int id;
        private string nom;

        public Port(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return nom; }
        }

        public override string ToString()
        {
            return nom;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.classes
{
    internal class Periode
    {
        private int noPeriode;
        private string date_debut;
        private string date_fin;

        public Periode(int noPeriode, string date_debut, string date_fin)
        {
            this.noPeriode = noPeriode;
            this.date_debut = date_debut;
            this.date_fin = date_fin;
        }

        public int Id
        {
            get { return noPeriode; }
        }

        public string dateDebut
        {
            get { return date_debut; }
        }

        public string dateFin
        {
            get { return date_fin; }
        }


        public override string ToString()
        {
            return date_debut + "au " + date_fin;
        }

    }
}

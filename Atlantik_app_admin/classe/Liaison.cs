using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_app_admin.classes
{
    internal class Liaison
    {

        private int noLiaison;
        private Port port_depart;
        private Secteur secteur;
        private Port port_arrivee;
        private float distance;


        public Liaison(int noLiaison, Port port_depart, Secteur secteur, Port port_arrivee, float distance) 
        {
            this.noLiaison = noLiaison;
            this.port_depart = port_depart;
            this.secteur = secteur;
            this.port_arrivee = port_arrivee;
            this.distance = distance;
        }

        public int Id
        {
            get { return noLiaison; }
        }

        public Port PortDepart
        {
            get { return port_depart; }
        }

        public Secteur Secteur
        {
            get { return secteur; }
        }

        public Port PortArrivee
        {
            get { return port_arrivee; }
        }

        public float Distance
        {
            get { return distance; }
        }

        public override string ToString()
        {
            return port_depart.Name + "-" + port_arrivee.Name;
        }

    }
}

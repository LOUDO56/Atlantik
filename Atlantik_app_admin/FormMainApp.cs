using Atlantik_app_admin.barre_menu;
using Atlantik_app_admin.barre_menu.afficher;
using Atlantik_app_admin.barre_menu.ajouter;
using Atlantik_app_admin.barre_menu.modifier;

namespace Atlantik_app_admin
{
    public partial class FormMainApp : Form
    {
        public FormMainApp()
        {
            InitializeComponent();
        }

        private void unSecteurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormAjoutSecteur().ShowDialog();
        }

        private void unPortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormAjoutPort().ShowDialog();
        }

        private void uneLiaisonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormAjoutLiaison().ShowDialog();
        }

        private void lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormAjoutTarif().ShowDialog();
        }

        private void unBateauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormAjoutBateau().ShowDialog();
        }

        private void uneTraverséeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormAjoutTraversee().ShowDialog();
        }

        private void unBateauToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new FormModifBateau().ShowDialog();
        }

        private void lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAfficherTraverse().ShowDialog();
        }

        private void lesDétailsDuneRéservationPourUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAfficherDetailReservation().ShowDialog();
        }

        private void lesParamètresDuSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormModifParametreSite().ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormAPropos().ShowDialog();
        }
    }
}

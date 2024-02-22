using Atlantik_app_admin.barre_menu.ajouter;

namespace Atlantik_app_admin
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void unSecteurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new SecteurGui().ShowDialog();
        }

        private void unPortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new PortGui().ShowDialog();
        }

        private void uneLiaisonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new LiaisonGui().ShowDialog();
        }

        private void lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new TarifGui().ShowDialog();
        }

        private void unBateauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new BateauGui().ShowDialog();
        }

        private void uneTraverséeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new TraverseGui().ShowDialog();
        }
    }
}

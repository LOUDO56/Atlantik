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
    }
}

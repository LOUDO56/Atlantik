using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Atlantik_app_admin.barre_menu
{
    public partial class FormAPropos : Form
    {
        public FormAPropos()
        {
            InitializeComponent();
        }

        private void btn_voirProjet_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/LOUDO56?tab=repositories",
                UseShellExecute = true
            });
        }
    }
}

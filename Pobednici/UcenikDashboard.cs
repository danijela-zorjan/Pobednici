using System;
using System.Windows.Forms;

namespace Pobednici
{
    public partial class UcenikDashboard : Form
    {
        public UcenikDashboard()
        {
            InitializeComponent();
        }

        private void UcenikDashboard_Load(object sender, EventArgs e)
        {
            rtbChat.Text =
                "Profesor: Dobrodošli u grupu III-2 Opšte.\n\n" +
                "Jovana: Da li neko ima domaći iz matematike?\n\n" +
                "Marko: Poslaću sliku u grupu.\n\n" +
                "Profesor: Kontrolni je u petak.";
        }
    }
}
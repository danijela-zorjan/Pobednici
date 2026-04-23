using System;
using System.Windows.Forms;

namespace Pobednici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblPoruka.Text = "Unesite korisničko ime i lozinku.";
                return;
            }

            // 🔹 FAKE LOGIN (SIMULACIJA)
            string uloga = "";

            if (username == "ucenik" && password == "1234")
                uloga = "Ucenik";
            else if (username == "profesor" && password == "1234")
                uloga = "Profesor";
            else if (username == "admin" && password == "1234")
                uloga = "Admin";
            else if (username == "superadmin" && password == "1234")
                uloga = "SuperAdmin";
            else
            {
                lblPoruka.Text = "Pogrešno korisničko ime ili lozinka.";
                return;
            }

            lblPoruka.Text = "Uspešna prijava.";

            this.Hide();

            // 🔹 PREUSMERAVANJE NA FORME
            if (uloga == "Ucenik")
            {
                UcenikDashboard forma = new UcenikDashboard();
                forma.ShowDialog();
            }
            else if (uloga == "Profesor")
            {
                Profesor forma = new Profesor();
                forma.ShowDialog();
            }
            else if (uloga == "Admin")
            {
                AdminDashboard forma = new AdminDashboard();
                forma.ShowDialog();
            }
            else if (uloga == "SuperAdmin")
            {
                SuperAdmin forma = new SuperAdmin();
                forma.ShowDialog();
            }

            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registracija forma = new Registracija();
            forma.ShowDialog();
        }
    }
}
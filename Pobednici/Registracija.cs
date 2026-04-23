using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pobednici
{
    public partial class Registracija : Form
    {
        private string konekcioniString = "Server=localhost;Database=pobednicidb;Uid=root;Pwd=;";

        public Registracija()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text.Trim();
            string prezime = txtPrezime.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string uloga = cmbUloga.Text;

            if (string.IsNullOrWhiteSpace(ime) ||
                string.IsNullOrWhiteSpace(prezime) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(uloga))
            {
                lblPoruka.Text = "Popuni sva polja.";
                return;
            }

            try
            {
                using (MySqlConnection konekcija = new MySqlConnection(konekcioniString))
                {
                    konekcija.Open();

                    string proveraUpit = "SELECT COUNT(*) FROM korisnici WHERE Username = @username";
                    using (MySqlCommand proveraKomanda = new MySqlCommand(proveraUpit, konekcija))
                    {
                        proveraKomanda.Parameters.AddWithValue("@username", username);
                        int postoji = Convert.ToInt32(proveraKomanda.ExecuteScalar());

                        if (postoji > 0)
                        {
                            lblPoruka.Text = "Korisničko ime već postoji.";
                            return;
                        }
                    }

                    string insertUpit = "INSERT INTO korisnici (Ime, Prezime, KorisnickoIme, Email, Lozinka, Uloga, Status) VALUES (@ime, @prezime, @username, @password, @uloga)";

                    using (MySqlCommand komanda = new MySqlCommand(insertUpit, konekcija))
                    {
                        komanda.Parameters.AddWithValue("@ime", ime);
                        komanda.Parameters.AddWithValue("@prezime", prezime);
                        komanda.Parameters.AddWithValue("@username", username);
                        komanda.Parameters.AddWithValue("@password", password);
                        komanda.Parameters.AddWithValue("@uloga", uloga);

                        komanda.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registracija uspešna.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri registraciji: " + ex.Message);
            }
        }
    }
}
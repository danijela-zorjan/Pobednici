using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pobednici
{
    public partial class Ucenici : Form
    {
        private List<UcenikModel> ucenici = new List<UcenikModel>();
        private int sledeciId = 1;

        public Ucenici()
        {
            InitializeComponent();
        }

        private void Ucenici_Load(object sender, EventArgs e)
        {
            UcitajOdeljenja();
            UcitajDemoPodatke();
            PrikaziUcenike(ucenici);
            OcistiFormu();
        }

        private void UcitajOdeljenja()
        {
            cmbOdeljenje.Items.Clear();
            cmbOdeljenje.Items.Add("I-1");
            cmbOdeljenje.Items.Add("I-2");
            cmbOdeljenje.Items.Add("II-1");
            cmbOdeljenje.Items.Add("II-2");
            cmbOdeljenje.Items.Add("III-1");
            cmbOdeljenje.Items.Add("III-2");
            cmbOdeljenje.Items.Add("IV-1");
            cmbOdeljenje.Items.Add("IV-2");

            if (cmbOdeljenje.Items.Count > 0)
                cmbOdeljenje.SelectedIndex = 0;
        }

        private void UcitajDemoPodatke()
        {
            ucenici.Add(new UcenikModel
            {
                Id = sledeciId++,
                Ime = "Marko",
                Prezime = "Marković",
                KorisnickoIme = "marko.m",
                Email = "marko@gmail.com",
                Odeljenje = "III-2",
                DatumRodjenja = new DateTime(2007, 5, 14),
                Aktivan = true
            });

            ucenici.Add(new UcenikModel
            {
                Id = sledeciId++,
                Ime = "Jovana",
                Prezime = "Jovanović",
                KorisnickoIme = "jovana.j",
                Email = "jovana@gmail.com",
                Odeljenje = "III-1",
                DatumRodjenja = new DateTime(2007, 8, 21),
                Aktivan = true
            });

            ucenici.Add(new UcenikModel
            {
                Id = sledeciId++,
                Ime = "Petar",
                Prezime = "Petrović",
                KorisnickoIme = "petar.p",
                Email = "petar@gmail.com",
                Odeljenje = "IV-1",
                DatumRodjenja = new DateTime(2006, 11, 2),
                Aktivan = false
            });
        }

        private void PrikaziUcenike(List<UcenikModel> lista)
        {
            dgvUcenici.DataSource = null;
            dgvUcenici.DataSource = lista.Select(x => new
            {
                x.Id,
                x.Ime,
                x.Prezime,
                KorisnickoIme = x.KorisnickoIme,
                x.Email,
                x.Odeljenje,
                DatumRodjenja = x.DatumRodjenja.ToShortDateString(),
                Status = x.Aktivan ? "Aktivan" : "Neaktivan"
            }).ToList();
        }

        private bool ValidacijaUnosa()
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Unesite ime učenika.");
                txtIme.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Unesite prezime učenika.");
                txtPrezime.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                MessageBox.Show("Unesite korisničko ime.");
                txtKorisnickoIme.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Unesite email.");
                txtEmail.Focus();
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email nije u ispravnom formatu.");
                txtEmail.Focus();
                return false;
            }

            if (cmbOdeljenje.SelectedItem == null)
            {
                MessageBox.Show("Izaberite odeljenje.");
                cmbOdeljenje.Focus();
                return false;
            }

            return true;
        }

        private void OcistiFormu()
        {
            txtId.Clear();
            txtIme.Clear();
            txtPrezime.Clear();
            txtKorisnickoIme.Clear();
            txtEmail.Clear();
            txtPretraga.Clear();
            chkAktivan.Checked = true;
            dtpDatumRodjenja.Value = DateTime.Today;

            if (cmbOdeljenje.Items.Count > 0)
                cmbOdeljenje.SelectedIndex = 0;

            dgvUcenici.ClearSelection();
            txtIme.Focus();
        }

        private void PopuniPolja(UcenikModel ucenik)
        {
            txtId.Text = ucenik.Id.ToString();
            txtIme.Text = ucenik.Ime;
            txtPrezime.Text = ucenik.Prezime;
            txtKorisnickoIme.Text = ucenik.KorisnickoIme;
            txtEmail.Text = ucenik.Email;
            cmbOdeljenje.SelectedItem = ucenik.Odeljenje;
            dtpDatumRodjenja.Value = ucenik.DatumRodjenja;
            chkAktivan.Checked = ucenik.Aktivan;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidacijaUnosa())
                return;

            bool postojiKorisnickoIme = ucenici.Any(x =>
                x.KorisnickoIme.ToLower() == txtKorisnickoIme.Text.Trim().ToLower());

            if (postojiKorisnickoIme)
            {
                MessageBox.Show("Korisničko ime već postoji.");
                return;
            }

            UcenikModel novi = new UcenikModel
            {
                Id = sledeciId++,
                Ime = txtIme.Text.Trim(),
                Prezime = txtPrezime.Text.Trim(),
                KorisnickoIme = txtKorisnickoIme.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Odeljenje = cmbOdeljenje.SelectedItem.ToString(),
                DatumRodjenja = dtpDatumRodjenja.Value.Date,
                Aktivan = chkAktivan.Checked
            };

            ucenici.Add(novi);
            PrikaziUcenike(ucenici);
            OcistiFormu();

            MessageBox.Show("Učenik je uspešno dodat.");
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Izaberite učenika iz tabele.");
                return;
            }

            if (!ValidacijaUnosa())
                return;

            int id = int.Parse(txtId.Text);

            UcenikModel ucenik = ucenici.FirstOrDefault(x => x.Id == id);
            if (ucenik == null)
            {
                MessageBox.Show("Učenik nije pronađen.");
                return;
            }

            bool postojiDrugiSaIstimKorisnickim = ucenici.Any(x =>
                x.Id != id &&
                x.KorisnickoIme.ToLower() == txtKorisnickoIme.Text.Trim().ToLower());

            if (postojiDrugiSaIstimKorisnickim)
            {
                MessageBox.Show("Drugi učenik već koristi to korisničko ime.");
                return;
            }

            ucenik.Ime = txtIme.Text.Trim();
            ucenik.Prezime = txtPrezime.Text.Trim();
            ucenik.KorisnickoIme = txtKorisnickoIme.Text.Trim();
            ucenik.Email = txtEmail.Text.Trim();
            ucenik.Odeljenje = cmbOdeljenje.SelectedItem.ToString();
            ucenik.DatumRodjenja = dtpDatumRodjenja.Value.Date;
            ucenik.Aktivan = chkAktivan.Checked;

            PrikaziUcenike(ucenici);
            OcistiFormu();

            MessageBox.Show("Podaci o učeniku su izmenjeni.");
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Izaberite učenika za brisanje.");
                return;
            }

            DialogResult rezultat = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete učenika?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rezultat != DialogResult.Yes)
                return;

            int id = int.Parse(txtId.Text);
            UcenikModel ucenik = ucenici.FirstOrDefault(x => x.Id == id);

            if (ucenik != null)
            {
                ucenici.Remove(ucenik);
                PrikaziUcenike(ucenici);
                OcistiFormu();
                MessageBox.Show("Učenik je obrisan.");
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            OcistiFormu();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string kriterijum = txtPretraga.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(kriterijum))
            {
                MessageBox.Show("Unesite tekst za pretragu.");
                return;
            }

            var rezultat = ucenici.Where(x =>
                x.Ime.ToLower().Contains(kriterijum) ||
                x.Prezime.ToLower().Contains(kriterijum) ||
                x.KorisnickoIme.ToLower().Contains(kriterijum) ||
                x.Email.ToLower().Contains(kriterijum) ||
                x.Odeljenje.ToLower().Contains(kriterijum))
                .ToList();

            PrikaziUcenike(rezultat);
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            PrikaziUcenike(ucenici);
        }

        private void dgvUcenici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dgvUcenici.Rows[e.RowIndex].Cells["Id"].Value);
            UcenikModel ucenik = ucenici.FirstOrDefault(x => x.Id == id);

            if (ucenik != null)
                PopuniPolja(ucenik);
        }
    }

    public class UcenikModel
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string Odeljenje { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }
    }
}
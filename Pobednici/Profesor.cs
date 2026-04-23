using System;
using System.Data;
using System.Windows.Forms;

namespace Pobednici
{
    public partial class Profesor : Form
    {
        private bool diskusijaZakljucana = false;

        public Profesor()
        {
            InitializeComponent();
            UcitajPocetnePodatke();
            PoveziDogadjaje();
        }

        private void UcitajPocetnePodatke()
        {
            listBoxPoruke.Items.Add("Dobrodošli u predmetnu grupu IV-2 MAT.");
            listBoxPoruke.Items.Add("Učenik Marko: Profesore, kada je test?");
            listBoxPoruke.Items.Add("Ana je poslala domaći zadatak.");

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Učenik");
            tabela.Columns.Add("Aktivnost");
            tabela.Columns.Add("Status");

            tabela.Rows.Add("Marko Marković", "Predao zadatak 1", "Pregledano");
            tabela.Rows.Add("Ana Anićević", "Komentarisala objavu", "Aktivno");
            tabela.Rows.Add("Jovan Jovanović", "Prijavio sadržaj", "Na čekanju");

            dataGridInfo.DataSource = tabela;
        }

        private void PoveziDogadjaje()
        {
            btnPosaljiObjavu.Click += btnPosaljiObjavu_Click;
            btnKreirajGrupu.Click += btnKreirajGrupu_Click;
            btnDodajZadatak.Click += btnDodajZadatak_Click;
            btnObjaviObavestenje.Click += btnObjaviObavestenje_Click;
            btnPinuj.Click += btnPinuj_Click;
            btnZakljucaj.Click += btnZakljucaj_Click;
            btnObrisiSadrzaj.Click += btnObrisiSadrzaj_Click;
            btnMojeGrupe.Click += btnMojeGrupe_Click;
            btnObavestenja.Click += btnObavestenja_Click;
            btnZadaci.Click += btnZadaci_Click;
            btnDiskusije.Click += btnDiskusije_Click;
            btnStatistika.Click += btnStatistika_Click;
            btnPrijave.Click += btnPrijave_Click;
        }

        private void btnPosaljiObjavu_Click(object sender, EventArgs e)
        {
            if (diskusijaZakljucana)
            {
                MessageBox.Show("Diskusija je zaključana. Nije moguće slati poruke.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNovaObjava.Text))
            {
                MessageBox.Show("Unesite tekst objave.");
                return;
            }

            listBoxPoruke.Items.Add("Profesor: " + txtNovaObjava.Text);
            txtNovaObjava.Clear();
        }

        private void btnKreirajGrupu_Click(object sender, EventArgs e)
        {
            string nazivGrupe = Microsoft.VisualBasic.Interaction.InputBox(
                "Unesite naziv nove predmetne grupe:",
                "Kreiranje grupe",
                "Nova grupa");

            if (!string.IsNullOrWhiteSpace(nazivGrupe))
            {
                MessageBox.Show("Grupa \"" + nazivGrupe + "\" je uspešno kreirana.");
            }
        }

        private void btnDodajZadatak_Click(object sender, EventArgs e)
        {
            string zadatak = Microsoft.VisualBasic.Interaction.InputBox(
                "Unesite naziv zadatka:",
                "Dodavanje zadatka",
                "Domaći zadatak");

            if (!string.IsNullOrWhiteSpace(zadatak))
            {
                MessageBox.Show("Zadatak \"" + zadatak + "\" je dodat grupi.");
            }
        }

        private void btnObjaviObavestenje_Click(object sender, EventArgs e)
        {
            string obavestenje = Microsoft.VisualBasic.Interaction.InputBox(
                "Unesite obaveštenje:",
                "Novo obaveštenje",
                "Obaveštenje za učenike");

            if (!string.IsNullOrWhiteSpace(obavestenje))
            {
                listBoxPoruke.Items.Add("[OBAVEŠTENJE] Profesor: " + obavestenje);
                MessageBox.Show("Obaveštenje je objavljeno.");
            }
        }

        private void btnPinuj_Click(object sender, EventArgs e)
        {
            if (listBoxPoruke.SelectedItem == null)
            {
                MessageBox.Show("Izaberite poruku koju želite da pinujete.");
                return;
            }

            string poruka = listBoxPoruke.SelectedItem.ToString();
            MessageBox.Show("Pinovana poruka:\n" + poruka);
        }

        private void btnZakljucaj_Click(object sender, EventArgs e)
        {
            diskusijaZakljucana = !diskusijaZakljucana;

            if (diskusijaZakljucana)
            {
                MessageBox.Show("Diskusija je zaključana.");
                btnZakljucaj.Text = "Otključaj diskusiju";
            }
            else
            {
                MessageBox.Show("Diskusija je otključana.");
                btnZakljucaj.Text = "Zaključaj diskusiju";
            }
        }

        private void btnObrisiSadrzaj_Click(object sender, EventArgs e)
        {
            if (listBoxPoruke.SelectedItem == null)
            {
                MessageBox.Show("Izaberite sadržaj koji želite da obrišete.");
                return;
            }

            DialogResult rezultat = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete izabrani sadržaj?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rezultat == DialogResult.Yes)
            {
                listBoxPoruke.Items.Remove(listBoxPoruke.SelectedItem);
                MessageBox.Show("Sadržaj je obrisan.");
            }
        }

        private void btnMojeGrupe_Click(object sender, EventArgs e)
        {
            lblTrenutnaGrupa.Text = "Pregled: Moje grupe";
            PrikaziTabeluGrupa();
        }

        private void btnObavestenja_Click(object sender, EventArgs e)
        {
            lblTrenutnaGrupa.Text = "Pregled: Obaveštenja";
            PrikaziObavestenja();
        }

        private void btnZadaci_Click(object sender, EventArgs e)
        {
            lblTrenutnaGrupa.Text = "Pregled: Zadaci";
            PrikaziZadatke();
        }

        private void btnDiskusije_Click(object sender, EventArgs e)
        {
            lblTrenutnaGrupa.Text = "Pregled: Diskusije";
            MessageBox.Show("Ovde se prikazuju aktivne diskusije po grupama.");
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            lblTrenutnaGrupa.Text = "Pregled: Statistika";
            PrikaziStatistiku();
        }

        private void btnPrijave_Click(object sender, EventArgs e)
        {
            lblTrenutnaGrupa.Text = "Pregled: Prijavljen sadržaj";
            PrikaziPrijave();
        }

        private void PrikaziTabeluGrupa()
        {
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Naziv grupe");
            tabela.Columns.Add("Broj učenika");
            tabela.Columns.Add("Predmet");

            tabela.Rows.Add("IV-2 MAT", "28", "Matematika");
            tabela.Rows.Add("III-1 INF", "25", "Informatika");
            tabela.Rows.Add("II-3 PROG", "30", "Programiranje");

            dataGridInfo.DataSource = tabela;
        }

        private void PrikaziObavestenja()
        {
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Naslov");
            tabela.Columns.Add("Datum");
            tabela.Columns.Add("Grupa");

            tabela.Rows.Add("Kontrolni u petak", "10.05.2025", "IV-2 MAT");
            tabela.Rows.Add("Promena rasporeda", "11.05.2025", "III-1 INF");

            dataGridInfo.DataSource = tabela;
        }

        private void PrikaziZadatke()
        {
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Zadatak");
            tabela.Columns.Add("Rok");
            tabela.Columns.Add("Status");

            tabela.Rows.Add("Domaći 1", "15.05.2025", "Aktivan");
            tabela.Rows.Add("Seminarski rad", "20.05.2025", "Aktivan");

            dataGridInfo.DataSource = tabela;
        }

        private void PrikaziStatistiku()
        {
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Grupa");
            tabela.Columns.Add("Broj objava");
            tabela.Columns.Add("Broj zadataka");
            tabela.Columns.Add("Aktivnost");

            tabela.Rows.Add("IV-2 MAT", "34", "5", "Visoka");
            tabela.Rows.Add("III-1 INF", "22", "3", "Srednja");

            dataGridInfo.DataSource = tabela;
        }

        private void PrikaziPrijave()
        {
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Korisnik");
            tabela.Columns.Add("Razlog prijave");
            tabela.Columns.Add("Status");

            tabela.Rows.Add("Marko", "Neprimeren komentar", "Na čekanju");
            tabela.Rows.Add("Ana", "Spam sadržaj", "Obrađeno");

            dataGridInfo.DataSource = tabela;
        }
    }
}
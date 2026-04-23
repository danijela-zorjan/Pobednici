// SuperAdmin.cs
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pobednici
{
    public partial class SuperAdmin : Form
    {
        private string konekcioniString = "Server=localhost;Database=pobednicidb;Uid=root;Pwd=;";
        private bool sistemZakljucan = false;

        public SuperAdmin()
        {
            InitializeComponent();
            PoveziDogadjaje();
            UcitajDashboard();
        }

        private void PoveziDogadjaje()
        {
            btnDashboard.Click += btnDashboard_Click;
            btnAdministratori.Click += btnAdministratori_Click;
            btnKorisnici.Click += btnKorisnici_Click;
            btnPermisije.Click += btnPermisije_Click;
            btnPodesavanja.Click += btnPodesavanja_Click;
            btnAuditLog.Click += btnAuditLog_Click;
            btnBackup.Click += btnBackup_Click;
            btnMaintenance.Click += btnMaintenance_Click;

            btnDodajAdmina.Click += btnDodajAdmina_Click;
            btnObrisiAdmina.Click += btnObrisiAdmina_Click;
            btnSacuvajPodesavanja.Click += btnSacuvajPodesavanja_Click;
            btnZakljucajSistem.Click += btnZakljucajSistem_Click;
            btnBackupNow.Click += btnBackupNow_Click;
            btnRestore.Click += btnRestore_Click;
            btnOsvezi.Click += btnOsvezi_Click;
            btnPretrazi.Click += btnPretrazi_Click;
            btnLogout.Click += btnLogout_Click;
            btnProfil.Click += btnProfil_Click;
        }

        private MySqlConnection KreirajKonekciju()
        {
            return new MySqlConnection(konekcioniString);
        }

        private DataTable IzvrsiSelect(string upit)
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection konekcija = KreirajKonekciju())
                {
                    konekcija.Open();

                    using (MySqlCommand komanda = new MySqlCommand(upit, konekcija))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(komanda))
                        {
                            adapter.Fill(tabela);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju podataka: " + ex.Message);
            }

            return tabela;
        }

        private void IzvrsiKomandu(string upit)
        {
            try
            {
                using (MySqlConnection konekcija = KreirajKonekciju())
                {
                    konekcija.Open();

                    using (MySqlCommand komanda = new MySqlCommand(upit, konekcija))
                    {
                        komanda.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izvršavanju komande: " + ex.Message);
            }
        }

        private object VratiSkalarnuVrednost(string upit)
        {
            try
            {
                using (MySqlConnection konekcija = KreirajKonekciju())
                {
                    konekcija.Open();

                    using (MySqlCommand komanda = new MySqlCommand(upit, konekcija))
                    {
                        return komanda.ExecuteScalar();
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        private void UcitajDashboard()
        {
            lblSekcija.Text = "Sekcija: Super Dashboard";
            txtNaslov.Text = "Globalni pregled sistema";
            rtbDetalji.Text = "Ovde super admin vidi korisnike, administratore, podešavanja, logove i maintenance status.";

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Stavka");
            tabela.Columns.Add("Vrednost");

            object brojKorisnika = VratiSkalarnuVrednost("SELECT COUNT(*) FROM korisnici");
            object brojUcenika = VratiSkalarnuVrednost("SELECT COUNT(*) FROM ucenici");

            tabela.Rows.Add("Ukupno korisnika", brojKorisnika.ToString());
            tabela.Rows.Add("Ukupno učenika", brojUcenika.ToString());
            tabela.Rows.Add("Maintenance mode", sistemZakljucan ? "Uključen" : "Isključen");
            tabela.Rows.Add("Direktne poruke", chkDirektnePoruke.Checked ? "Omogućene" : "Onemogućene");
            tabela.Rows.Add("Upload slika", chkUploadSlika.Checked ? "Omogućen" : "Onemogućen");
            tabela.Rows.Add("Max upload size", numMaxUpload.Value + " MB");

            dataGridInfo.DataSource = tabela;
        }

        private void PrikaziSveKorisnike()
        {
            lblSekcija.Text = "Sekcija: Korisnici";
            txtNaslov.Text = "Pregled svih korisnika";
            rtbDetalji.Text = "Prikaz svih korisnika iz tabele korisnici.";
            dataGridInfo.DataSource = IzvrsiSelect("SELECT * FROM korisnici");
        }

        private void PrikaziAdministratore()
        {
            lblSekcija.Text = "Sekcija: Administratori";
            txtNaslov.Text = "Upravljanje administratorima";
            rtbDetalji.Text = "Prikaz administratora i super administratora.";

            DataTable tabela = IzvrsiSelect("SELECT * FROM korisnici WHERE uloga='Administrator' OR uloga='SuperAdmin'");

            if (tabela.Columns.Count == 0)
            {
                tabela = IzvrsiSelect("SELECT * FROM korisnici");
            }

            dataGridInfo.DataSource = tabela;
        }

        private void PrikaziPermisije()
        {
            lblSekcija.Text = "Sekcija: Permissions";
            txtNaslov.Text = "Permission matrix";
            rtbDetalji.Text = "Primer permission sistema po ulozi.";

            DataTable tabela = new DataTable();
            tabela.Columns.Add("PermissionCode");
            tabela.Columns.Add("Student");
            tabela.Columns.Add("Profesor");
            tabela.Columns.Add("Admin");
            tabela.Columns.Add("SuperAdmin");

            tabela.Rows.Add("MESSAGE_SEND", "Da", "Da", "Da", "Da");
            tabela.Rows.Add("TASK_CREATE", "Ne", "Da", "Da", "Da");
            tabela.Rows.Add("MANAGE_USERS", "Ne", "Ne", "Da", "Da");
            tabela.Rows.Add("MANAGE_ADMINS", "Ne", "Ne", "Ne", "Da");
            tabela.Rows.Add("SETTINGS_MANAGE", "Ne", "Ne", "Ne", "Da");
            tabela.Rows.Add("AUDIT_VIEW", "Ne", "Ne", "Da", "Da");
            tabela.Rows.Add("BACKUP_RESTORE", "Ne", "Ne", "Ne", "Da");

            dataGridInfo.DataSource = tabela;
        }

        private void PrikaziPodesavanja()
        {
            lblSekcija.Text = "Sekcija: Global Settings";
            txtNaslov.Text = "Globalna podešavanja sistema";
            rtbDetalji.Text = "Ovde super admin menja sistemska pravila, limite i opcije.";

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Podešavanje");
            tabela.Columns.Add("Vrednost");

            tabela.Rows.Add("Maintenance mode", chkMaintenance.Checked ? "ON" : "OFF");
            tabela.Rows.Add("Direktne poruke", chkDirektnePoruke.Checked ? "ON" : "OFF");
            tabela.Rows.Add("Upload slika", chkUploadSlika.Checked ? "ON" : "OFF");
            tabela.Rows.Add("Max upload size", numMaxUpload.Value + " MB");

            dataGridInfo.DataSource = tabela;
        }

        private void PrikaziAuditLog()
        {
            lblSekcija.Text = "Sekcija: Audit Log";
            txtNaslov.Text = "Pregled audit log zapisa";
            rtbDetalji.Text = "Primer audit log prikaza za kritične akcije.";

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Vreme");
            tabela.Columns.Add("Korisnik");
            tabela.Columns.Add("Akcija");
            tabela.Columns.Add("Detalji");

            tabela.Rows.Add(DateTime.Now.AddMinutes(-50).ToString("dd.MM.yyyy HH:mm"), "superadmin", "LOGIN", "Uspešna prijava");
            tabela.Rows.Add(DateTime.Now.AddMinutes(-35).ToString("dd.MM.yyyy HH:mm"), "superadmin", "SETTINGS_UPDATE", "Promenjen max upload size");
            tabela.Rows.Add(DateTime.Now.AddMinutes(-20).ToString("dd.MM.yyyy HH:mm"), "superadmin", "ADMIN_CREATE", "Dodat novi administrator");
            tabela.Rows.Add(DateTime.Now.AddMinutes(-5).ToString("dd.MM.yyyy HH:mm"), "superadmin", "BACKUP_CREATE", "Kreiran backup sistema");

            dataGridInfo.DataSource = tabela;
        }

        private void PrikaziBackupSekciju()
        {
            lblSekcija.Text = "Sekcija: Backup / Restore";
            txtNaslov.Text = "Upravljanje backup-om";
            rtbDetalji.Text = "Super admin može kreirati backup i restore sistema.";

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Naziv");
            tabela.Columns.Add("Datum");
            tabela.Columns.Add("Status");

            tabela.Rows.Add("backup_01.sql", DateTime.Now.AddDays(-5).ToString("dd.MM.yyyy HH:mm"), "Uspešan");
            tabela.Rows.Add("backup_02.sql", DateTime.Now.AddDays(-2).ToString("dd.MM.yyyy HH:mm"), "Uspešan");
            tabela.Rows.Add("backup_03.sql", DateTime.Now.ToString("dd.MM.yyyy HH:mm"), "Poslednji");

            dataGridInfo.DataSource = tabela;
        }

        private void PrikaziMaintenance()
        {
            lblSekcija.Text = "Sekcija: Maintenance";
            txtNaslov.Text = "Maintenance mode";
            rtbDetalji.Text = "Kada je maintenance aktivan, sistem može biti zaključan za obične korisnike.";

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Parametar");
            tabela.Columns.Add("Vrednost");

            tabela.Rows.Add("Maintenance status", sistemZakljucan ? "AKTIVAN" : "NEAKTIVAN");
            tabela.Rows.Add("Sistem zaključan", sistemZakljucan ? "DA" : "NE");
            tabela.Rows.Add("Direktne poruke", chkDirektnePoruke.Checked ? "DA" : "NE");
            tabela.Rows.Add("Upload slika", chkUploadSlika.Checked ? "DA" : "NE");

            dataGridInfo.DataSource = tabela;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UcitajDashboard();
        }

        private void btnAdministratori_Click(object sender, EventArgs e)
        {
            PrikaziAdministratore();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            PrikaziSveKorisnike();
        }

        private void btnPermisije_Click(object sender, EventArgs e)
        {
            PrikaziPermisije();
        }

        private void btnPodesavanja_Click(object sender, EventArgs e)
        {
            PrikaziPodesavanja();
        }

        private void btnAuditLog_Click(object sender, EventArgs e)
        {
            PrikaziAuditLog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            PrikaziBackupSekciju();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            PrikaziMaintenance();
        }

        private void btnDodajAdmina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text))
            {
                MessageBox.Show("Unesi korisničko ime ili naslov admin akcije u polje Naslov.");
                return;
            }

            try
            {
                string korisnickoIme = txtNaslov.Text.Trim();
                string upit = $"UPDATE korisnici SET uloga='Administrator' WHERE username='{korisnickoIme}'";
                IzvrsiKomandu(upit);
                MessageBox.Show("Korisnik je unapređen u administratora.");
                PrikaziAdministratore();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void btnObrisiAdmina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text))
            {
                MessageBox.Show("Unesi korisničko ime administratora u polje Naslov.");
                return;
            }

            try
            {
                string korisnickoIme = txtNaslov.Text.Trim();
                string upit = $"UPDATE korisnici SET uloga='Ucenik' WHERE username='{korisnickoIme}'";
                IzvrsiKomandu(upit);
                MessageBox.Show("Administratoru je uklonjena admin uloga.");
                PrikaziAdministratore();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void btnSacuvajPodesavanja_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Podešavanja sačuvana:\n" +
                "Maintenance: " + (chkMaintenance.Checked ? "ON" : "OFF") + "\n" +
                "Direktne poruke: " + (chkDirektnePoruke.Checked ? "ON" : "OFF") + "\n" +
                "Upload slika: " + (chkUploadSlika.Checked ? "ON" : "OFF") + "\n" +
                "Max upload: " + numMaxUpload.Value + " MB"
            );

            PrikaziPodesavanja();
        }

        private void btnZakljucajSistem_Click(object sender, EventArgs e)
        {
            sistemZakljucan = !sistemZakljucan;
            chkMaintenance.Checked = sistemZakljucan;

            if (sistemZakljucan)
            {
                MessageBox.Show("Sistem je prebačen u maintenance mode.");
            }
            else
            {
                MessageBox.Show("Maintenance mode je isključen.");
            }

            PrikaziMaintenance();
        }

        private void btnBackupNow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Backup je uspešno simuliran.");
            PrikaziBackupSekciju();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Restore je uspešno simuliran.");
            PrikaziBackupSekciju();
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            UcitajDashboard();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string unos = txtPretraga.Text.Trim();

            if (string.IsNullOrWhiteSpace(unos))
            {
                MessageBox.Show("Unesi tekst za pretragu.");
                return;
            }

            try
            {
                DataTable tabela = IzvrsiSelect(
                    $"SELECT * FROM korisnici WHERE " +
                    $"username LIKE '%{unos}%' OR " +
                    $"email LIKE '%{unos}%' OR " +
                    $"ime LIKE '%{unos}%' OR " +
                    $"prezime LIKE '%{unos}%'"
                );

                dataGridInfo.DataSource = tabela;
                lblSekcija.Text = "Sekcija: Rezultati pretrage";
            }
            catch
            {
                MessageBox.Show("Proveri da li tabela korisnici ima kolone: username, email, ime, prezime.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otvoren profil super administratora.");
        }
    }
}
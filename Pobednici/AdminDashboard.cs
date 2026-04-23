using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Pobednici
{
    public partial class AdminDashboard : Form
    {
        private string connectionString = "server=localhost;database=PobedniciDB;uid=root;pwd=;";

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            UcitajComboBoxove();
            UcitajKorisnike();
            OcistiPolja();

            dgvPodaci.CellClick += dgvPodaci_CellClick;

            btnDodaj.Click += btnDodaj_Click;
            btnIzmeni.Click += btnIzmeni_Click;
            btnDeaktiviraj.Click += btnDeaktiviraj_Click;
            btnResetLozinka.Click += btnResetLozinka_Click;
            btnSuspenduj.Click += btnSuspenduj_Click;
            btnDodeliGrupu.Click += btnDodeliGrupu_Click;
            btnSacuvaj.Click += btnSacuvaj_Click;
            btnOcisti.Click += btnOcisti_Click;
            btnPretrazi.Click += btnPretrazi_Click;

            btnKorisnici.Click += btnKorisnici_Click;
            btnGrupe.Click += btnGrupe_Click;
            btnOdeljenja.Click += btnOdeljenja_Click;
            btnPrijave.Click += btnPrijave_Click;
            btnAuditLog.Click += btnAuditLog_Click;
            btnUploadPravila.Click += btnUploadPravila_Click;
            btnSuspenzije.Click += btnSuspenzije_Click;
            btnOdjava.Click += btnOdjava_Click;

            ResetBojeMenija();
            btnKorisnici.BackColor = Color.RoyalBlue;
        }

        private void UcitajComboBoxove()
        {
            cmbUloga.Items.Clear();
            cmbUloga.Items.Add("Ucenik");
            cmbUloga.Items.Add("Profesor");
            cmbUloga.Items.Add("Admin");
            cmbUloga.Items.Add("SuperAdmin");

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Aktivan");
            cmbStatus.Items.Add("Neaktivan");
            cmbStatus.Items.Add("Suspendovan");

            cmbOdeljenje.Items.Clear();
            cmbOdeljenje.Items.Add("I-1");
            cmbOdeljenje.Items.Add("I-2");
            cmbOdeljenje.Items.Add("II-1");
            cmbOdeljenje.Items.Add("II-2");
            cmbOdeljenje.Items.Add("III-1");
            cmbOdeljenje.Items.Add("III-2");
            cmbOdeljenje.Items.Add("IV-1");
            cmbOdeljenje.Items.Add("IV-2");

            if (cmbUloga.Items.Count > 0) cmbUloga.SelectedIndex = 0;
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            if (cmbOdeljenje.Items.Count > 0) cmbOdeljenje.SelectedIndex = 0;
        }

        private void ResetBojeMenija()
        {
            Color osnovna = Color.FromArgb(54, 69, 90);

            btnKorisnici.BackColor = osnovna;
            btnGrupe.BackColor = osnovna;
            btnOdeljenja.BackColor = osnovna;
            btnPrijave.BackColor = osnovna;
            btnAuditLog.BackColor = osnovna;
            btnUploadPravila.BackColor = osnovna;
            btnSuspenzije.BackColor = osnovna;
        }

        private void OcistiPolja()
        {
            txtId.Clear();
            txtIme.Clear();
            txtPrezime.Clear();
            txtKorisnickoIme.Clear();
            txtEmail.Clear();

            if (cmbUloga.Items.Count > 0) cmbUloga.SelectedIndex = 0;
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            if (cmbOdeljenje.Items.Count > 0) cmbOdeljenje.SelectedIndex = 0;

            chkAktivan.Checked = true;
        }

        private bool Validacija()
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Unesite ime.");
                txtIme.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Unesite prezime.");
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
                MessageBox.Show("Email nije ispravan.");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void UcitajKorisnike()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                        Id,
                                        Ime,
                                        Prezime,
                                        KorisnickoIme,
                                        Email,
                                        Uloga,
                                        Status,
                                        IFNULL(Odeljenje, '-') AS Odeljenje,
                                        Aktivan
                                     FROM korisnici
                                     ORDER BY Id DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dgvPodaci.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju korisnika: " + ex.Message);
            }
        }

        private void UcitajGrupe()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Id, Naziv, Opis FROM grupe ORDER BY Id DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dgvPodaci.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju grupa: " + ex.Message);
            }
        }

        private void UcitajOdeljenja()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Id, Naziv FROM odeljenja ORDER BY Id DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dgvPodaci.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju odeljenja: " + ex.Message);
            }
        }

        private void UcitajPrijave()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                        Id,
                                        KorisnikId,
                                        Opis,
                                        Datum
                                     FROM prijave
                                     ORDER BY Datum DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dgvPodaci.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju prijava: " + ex.Message);
            }
        }

        private void UcitajAuditLog()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                        Id,
                                        Akcija,
                                        Opis,
                                        Datum
                                     FROM auditlog
                                     ORDER BY Datum DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dgvPodaci.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju audit log-a: " + ex.Message);
            }
        }

        private void UcitajUploadPravila()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                        Id,
                                        MaxVelicinaMB,
                                        DozvoljeniTipovi
                                     FROM uploadpravila
                                     ORDER BY Id DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dgvPodaci.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju upload pravila: " + ex.Message);
            }
        }

        private void UcitajSuspendovane()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                        Id,
                                        Ime,
                                        Prezime,
                                        KorisnickoIme,
                                        Email,
                                        Uloga,
                                        Status,
                                        IFNULL(Odeljenje, '-') AS Odeljenje,
                                        Aktivan
                                     FROM korisnici
                                     WHERE Status = 'Suspendovan'
                                     ORDER BY Id DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dgvPodaci.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju suspendovanih korisnika: " + ex.Message);
            }
        }

        private void UpisiAudit(string akcija, string opis)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO auditlog (Akcija, Opis) VALUES (@Akcija, @Opis)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Akcija", akcija);
                        cmd.Parameters.AddWithValue("@Opis", opis);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
            }
        }

        private void dgvPodaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvPodaci.Columns["Ime"] == null) return;

            txtId.Text = dgvPodaci.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtIme.Text = dgvPodaci.Rows[e.RowIndex].Cells["Ime"].Value.ToString();
            txtPrezime.Text = dgvPodaci.Rows[e.RowIndex].Cells["Prezime"].Value.ToString();
            txtKorisnickoIme.Text = dgvPodaci.Rows[e.RowIndex].Cells["KorisnickoIme"].Value.ToString();
            txtEmail.Text = dgvPodaci.Rows[e.RowIndex].Cells["Email"].Value.ToString();

            string uloga = dgvPodaci.Rows[e.RowIndex].Cells["Uloga"].Value.ToString();
            string status = dgvPodaci.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            string odeljenje = dgvPodaci.Rows[e.RowIndex].Cells["Odeljenje"].Value.ToString();
            string aktivan = dgvPodaci.Rows[e.RowIndex].Cells["Aktivan"].Value.ToString();

            cmbUloga.SelectedItem = uloga;
            cmbStatus.SelectedItem = status;

            if (odeljenje != "-")
                cmbOdeljenje.SelectedItem = odeljenje;
            else if (cmbOdeljenje.Items.Count > 0)
                cmbOdeljenje.SelectedIndex = 0;

            chkAktivan.Checked = aktivan == "True" || aktivan == "1";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!Validacija()) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO korisnici
                                    (Ime, Prezime, KorisnickoIme, Email, Lozinka, Uloga, Status, Odeljenje, Aktivan)
                                    VALUES
                                    (@Ime, @Prezime, @KorisnickoIme, @Email, @Lozinka, @Uloga, @Status, @Odeljenje, @Aktivan)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ime", txtIme.Text.Trim());
                        cmd.Parameters.AddWithValue("@Prezime", txtPrezime.Text.Trim());
                        cmd.Parameters.AddWithValue("@KorisnickoIme", txtKorisnickoIme.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Lozinka", "12345");
                        cmd.Parameters.AddWithValue("@Uloga", cmbUloga.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());

                        if (cmbUloga.SelectedItem.ToString() == "Ucenik")
                            cmd.Parameters.AddWithValue("@Odeljenje", cmbOdeljenje.SelectedItem?.ToString());
                        else
                            cmd.Parameters.AddWithValue("@Odeljenje", DBNull.Value);

                        cmd.Parameters.AddWithValue("@Aktivan", chkAktivan.Checked ? 1 : 0);
                        cmd.ExecuteNonQuery();
                    }
                }

                UpisiAudit("Dodavanje korisnika", "Dodat korisnik: " + txtKorisnickoIme.Text.Trim());
                MessageBox.Show("Korisnik je dodat.");
                UcitajKorisnike();
                OcistiPolja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju: " + ex.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Izaberite korisnika.");
                return;
            }

            if (!Validacija()) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE korisnici
                                     SET Ime=@Ime,
                                         Prezime=@Prezime,
                                         KorisnickoIme=@KorisnickoIme,
                                         Email=@Email,
                                         Uloga=@Uloga,
                                         Status=@Status,
                                         Odeljenje=@Odeljenje,
                                         Aktivan=@Aktivan
                                     WHERE Id=@Id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ime", txtIme.Text.Trim());
                        cmd.Parameters.AddWithValue("@Prezime", txtPrezime.Text.Trim());
                        cmd.Parameters.AddWithValue("@KorisnickoIme", txtKorisnickoIme.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Uloga", cmbUloga.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());

                        if (cmbUloga.SelectedItem.ToString() == "Ucenik")
                            cmd.Parameters.AddWithValue("@Odeljenje", cmbOdeljenje.SelectedItem?.ToString());
                        else
                            cmd.Parameters.AddWithValue("@Odeljenje", DBNull.Value);

                        cmd.Parameters.AddWithValue("@Aktivan", chkAktivan.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                UpisiAudit("Izmena korisnika", "Izmenjen korisnik ID: " + txtId.Text);
                MessageBox.Show("Korisnik je izmenjen.");
                UcitajKorisnike();
                OcistiPolja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni: " + ex.Message);
            }
        }

        private void btnDeaktiviraj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Izaberite korisnika.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE korisnici
                                     SET Aktivan = 0,
                                         Status = 'Neaktivan'
                                     WHERE Id = @Id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                UpisiAudit("Deaktivacija naloga", "Deaktiviran korisnik ID: " + txtId.Text);
                MessageBox.Show("Nalog je deaktiviran.");
                UcitajKorisnike();
                OcistiPolja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri deaktivaciji: " + ex.Message);
            }
        }

        private void btnResetLozinka_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Izaberite korisnika.");
                return;
            }

            string novaLozinka = "nova123";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE korisnici SET Lozinka=@Lozinka WHERE Id=@Id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Lozinka", novaLozinka);
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                UpisiAudit("Reset lozinke", "Resetovana lozinka za korisnika ID: " + txtId.Text);
                MessageBox.Show("Lozinka je resetovana na: " + novaLozinka);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri resetovanju lozinke: " + ex.Message);
            }
        }

        private void btnSuspenduj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Izaberite korisnika.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE korisnici
                                     SET Status = 'Suspendovan',
                                         Aktivan = 0
                                     WHERE Id = @Id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                UpisiAudit("Suspenzija", "Suspendovan korisnik ID: " + txtId.Text);
                MessageBox.Show("Korisnik je suspendovan.");
                UcitajKorisnike();
                OcistiPolja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri suspenziji: " + ex.Message);
            }
        }

        private void btnDodeliGrupu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Izaberite korisnika.");
                return;
            }

            if (dgvPodaci.Columns["Naziv"] != null && dgvPodaci.CurrentRow != null)
            {
                int grupaId = Convert.ToInt32(dgvPodaci.CurrentRow.Cells["Id"].Value);
                int korisnikId = Convert.ToInt32(txtId.Text);

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "INSERT INTO korisnikgrupe (KorisnikId, GrupaId) VALUES (@KorisnikId, @GrupaId)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@KorisnikId", korisnikId);
                            cmd.Parameters.AddWithValue("@GrupaId", grupaId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    UpisiAudit("Dodela grupe", "Korisnik ID " + korisnikId + " dodat u grupu ID " + grupaId);
                    MessageBox.Show("Korisnik je dodeljen grupi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri dodeli grupe: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Klikni prvo na 'Grupe', pa izaberi grupu iz tabele, a zatim klikni 'Dodeli u grupu'.");
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
                btnDodaj_Click(sender, e);
            else
                btnIzmeni_Click(sender, e);
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            OcistiPolja();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                        Id,
                                        Ime,
                                        Prezime,
                                        KorisnickoIme,
                                        Email,
                                        Uloga,
                                        Status,
                                        IFNULL(Odeljenje, '-') AS Odeljenje,
                                        Aktivan
                                     FROM korisnici
                                     WHERE Ime LIKE @tekst
                                        OR Prezime LIKE @tekst
                                        OR KorisnickoIme LIKE @tekst
                                        OR Email LIKE @tekst
                                        OR Uloga LIKE @tekst
                                        OR Status LIKE @tekst
                                        OR Odeljenje LIKE @tekst";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@tekst", "%" + txtPretraga.Text.Trim() + "%");

                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dgvPodaci.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri pretrazi: " + ex.Message);
            }
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            ResetBojeMenija();
            btnKorisnici.BackColor = Color.RoyalBlue;
            UcitajKorisnike();
        }

        private void btnGrupe_Click(object sender, EventArgs e)
        {
            ResetBojeMenija();
            btnGrupe.BackColor = Color.RoyalBlue;
            UcitajGrupe();
        }

        private void btnOdeljenja_Click(object sender, EventArgs e)
        {
            ResetBojeMenija();
            btnOdeljenja.BackColor = Color.RoyalBlue;
            UcitajOdeljenja();
        }

        private void btnPrijave_Click(object sender, EventArgs e)
        {
            ResetBojeMenija();
            btnPrijave.BackColor = Color.RoyalBlue;
            UcitajPrijave();
        }

        private void btnAuditLog_Click(object sender, EventArgs e)
        {
            ResetBojeMenija();
            btnAuditLog.BackColor = Color.RoyalBlue;
            UcitajAuditLog();
        }

        private void btnUploadPravila_Click(object sender, EventArgs e)
        {
            ResetBojeMenija();
            btnUploadPravila.BackColor = Color.RoyalBlue;
            UcitajUploadPravila();
        }

        private void btnSuspenzije_Click(object sender, EventArgs e)
        {
            ResetBojeMenija();
            btnSuspenzije.BackColor = Color.RoyalBlue;
            UcitajSuspendovane();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
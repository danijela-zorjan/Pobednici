using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Pobednici
{
    public partial class UcenikDashboard : Form
    {
        private string connectionString = "server=localhost;database=pobednicidb;uid=root;pwd=;";
        private int ulogovaniKorisnikId = 4;
        private int aktivnaGrupaId = -1;
        private string aktivniPrikaz = "Grupe";
        private bool inicijalizovano = false;

        public UcenikDashboard()
        {
            InitializeComponent();
            PoveziEvente();
            InicijalizujDashboard();
        }

        public UcenikDashboard(int korisnikId)
        {
            InitializeComponent();
            ulogovaniKorisnikId = korisnikId;
            PoveziEvente();
            InicijalizujDashboard();
        }

        private void PoveziEvente()
        {
            this.Load -= UcenikDashboard_Load;
            this.Load += UcenikDashboard_Load;

            lstGrupe.SelectedIndexChanged -= lstGrupe_SelectedIndexChanged;
            lstGrupe.SelectedIndexChanged += lstGrupe_SelectedIndexChanged;

            lstMaterijali.DoubleClick -= lstMaterijali_DoubleClick;
            lstMaterijali.DoubleClick += lstMaterijali_DoubleClick;

            btnPosalji.Click -= btnPosalji_Click;
            btnPosalji.Click += btnPosalji_Click;

            btnSlika.Click -= btnSlika_Click;
            btnSlika.Click += btnSlika_Click;

            btnFajl.Click -= btnFajl_Click;
            btnFajl.Click += btnFajl_Click;

            btnPitanje.Click -= btnPitanje_Click;
            btnPitanje.Click += btnPitanje_Click;

            btnMojeGrupe.Click -= btnMojeGrupe_Click;
            btnMojeGrupe.Click += btnMojeGrupe_Click;

            btnPrivatnePoruke.Click -= btnPrivatnePoruke_Click;
            btnPrivatnePoruke.Click += btnPrivatnePoruke_Click;

            btnMaterijali.Click -= btnMaterijali_Click;
            btnMaterijali.Click += btnMaterijali_Click;

            btnPitanja.Click -= btnPitanja_Click;
            btnPitanja.Click += btnPitanja_Click;

            btnObavestenja.Click -= btnObavestenja_Click;
            btnObavestenja.Click += btnObavestenja_Click;

            btnMojProfil.Click -= btnMojProfil_Click;
            btnMojProfil.Click += btnMojProfil_Click;

            btnOdjava.Click -= btnOdjava_Click;
            btnOdjava.Click += btnOdjava_Click;
        }

        private void UcenikDashboard_Load(object sender, EventArgs e)
        {
            InicijalizujDashboard();
        }

        private void InicijalizujDashboard()
        {
            if (inicijalizovano) return;
            inicijalizovano = true;

            try
            {
                ResetMeniBoje();
                btnMojeGrupe.BackColor = Color.RoyalBlue;

                TestKonekcija();
                UcitajProfil();
                UcitajGrupe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri inicijalizaciji dashboard-a: " + ex.Message);
            }
        }

        private void TestKonekcija()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
            }
        }

        private void ResetMeniBoje()
        {
            Color osnovna = Color.FromArgb(45, 62, 90);

            btnMojeGrupe.BackColor = osnovna;
            btnPrivatnePoruke.BackColor = osnovna;
            btnMaterijali.BackColor = osnovna;
            btnPitanja.BackColor = osnovna;
            btnObavestenja.BackColor = osnovna;
            btnMojProfil.BackColor = osnovna;
        }

        private void UcitajProfil()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT Ime, Prezime, IFNULL(Odeljenje, '-') AS Odeljenje, KorisnickoIme
                                 FROM korisnici
                                 WHERE Id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", ulogovaniKorisnikId);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            string punoIme = dr["Ime"].ToString() + " " + dr["Prezime"].ToString();
                            string odeljenje = dr["Odeljenje"].ToString();
                            string korisnickoIme = dr["KorisnickoIme"].ToString();

                            lblImePrezime.Text = punoIme;
                            lblOdeljenje.Text = odeljenje;
                            lblUlogovaniKorisnik.Text = "Ulogovan: " + korisnickoIme + " / " + odeljenje;
                        }
                        else
                        {
                            MessageBox.Show("Korisnik sa ID " + ulogovaniKorisnikId + " ne postoji u tabeli korisnici.");
                        }
                    }
                }
            }
        }

        private void UcitajGrupe()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT g.Id, g.Naziv
                                 FROM grupe g
                                 INNER JOIN korisnikgrupe kg ON g.Id = kg.GrupaId
                                 WHERE kg.KorisnikId = @KorisnikId
                                 ORDER BY g.Naziv";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@KorisnikId", ulogovaniKorisnikId);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    lstGrupe.DataSource = null;
                    lstGrupe.DisplayMember = "Naziv";
                    lstGrupe.ValueMember = "Id";
                    lstGrupe.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        lstGrupe.SelectedIndex = 0;
                        if (lstGrupe.SelectedValue != null && !(lstGrupe.SelectedValue is DataRowView))
                        {
                            aktivnaGrupaId = Convert.ToInt32(lstGrupe.SelectedValue);
                            lblAktivnaGrupa.Text = "Aktivna grupa: " + lstGrupe.Text;
                            UcitajChatGrupe();
                            UcitajClanoveGrupe();
                            UcitajMaterijaleGrupe();
                        }
                    }
                    else
                    {
                        rtbChat.Clear();
                        lstClanovi.DataSource = null;
                        lstMaterijali.DataSource = null;
                        lblAktivnaGrupa.Text = "Aktivna grupa: nema";
                        MessageBox.Show("Ovaj korisnik nema dodeljene grupe u tabeli korisnikgrupe.");
                    }
                }
            }
        }

        private void lstGrupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGrupe.SelectedValue == null) return;
            if (lstGrupe.SelectedValue is DataRowView) return;

            aktivnaGrupaId = Convert.ToInt32(lstGrupe.SelectedValue);
            lblAktivnaGrupa.Text = "Aktivna grupa: " + lstGrupe.Text;

            if (aktivniPrikaz == "Grupe")
                UcitajChatGrupe();

            UcitajClanoveGrupe();
            UcitajMaterijaleGrupe();
        }

        private void UcitajChatGrupe()
        {
            if (aktivnaGrupaId <= 0) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT 
                                    k.Ime,
                                    k.Prezime,
                                    gp.Sadrzaj,
                                    gp.Tip,
                                    gp.PutanjaFajla,
                                    gp.Datum
                                 FROM grupaporuke gp
                                 INNER JOIN korisnici k ON gp.KorisnikId = k.Id
                                 WHERE gp.GrupaId = @GrupaId
                                 ORDER BY gp.Datum ASC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GrupaId", aktivnaGrupaId);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        rtbChat.Clear();

                        while (dr.Read())
                        {
                            string ime = dr["Ime"].ToString();
                            string prezime = dr["Prezime"].ToString();
                            string tip = dr["Tip"].ToString();
                            string sadrzaj = dr["Sadrzaj"] == DBNull.Value ? "" : dr["Sadrzaj"].ToString();
                            string putanja = dr["PutanjaFajla"] == DBNull.Value ? "" : dr["PutanjaFajla"].ToString();
                            string datum = Convert.ToDateTime(dr["Datum"]).ToString("dd.MM.yyyy HH:mm");

                            StringBuilder poruka = new StringBuilder();
                            poruka.AppendLine($"[{datum}] {ime} {prezime}:");

                            if (tip == "Slika")
                                poruka.AppendLine("Poslata slika: " + putanja);
                            else if (tip == "Fajl")
                                poruka.AppendLine("Poslat fajl: " + putanja);
                            else if (tip == "Pitanje")
                                poruka.AppendLine("PITANJE: " + sadrzaj);
                            else
                                poruka.AppendLine(sadrzaj);

                            poruka.AppendLine();
                            rtbChat.AppendText(poruka.ToString());
                        }
                    }
                }
            }
        }

        private void UcitajClanoveGrupe()
        {
            if (aktivnaGrupaId <= 0) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT CONCAT(k.Ime, ' ', k.Prezime) AS PunoIme
                                 FROM korisnici k
                                 INNER JOIN korisnikgrupe kg ON k.Id = kg.KorisnikId
                                 WHERE kg.GrupaId = @GrupaId
                                 ORDER BY k.Ime, k.Prezime";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@GrupaId", aktivnaGrupaId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    lstClanovi.DataSource = null;
                    lstClanovi.DisplayMember = "PunoIme";
                    lstClanovi.ValueMember = "PunoIme";
                    lstClanovi.DataSource = dt;
                }
            }
        }

        private void UcitajMaterijaleGrupe()
        {
            if (aktivnaGrupaId <= 0) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT 
                                    Id,
                                    IFNULL(PutanjaFajla, '') AS PutanjaFajla
                                 FROM grupaporuke
                                 WHERE GrupaId = @GrupaId
                                   AND PutanjaFajla IS NOT NULL
                                   AND PutanjaFajla <> ''
                                 ORDER BY Datum DESC";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@GrupaId", aktivnaGrupaId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dt.Columns.Add("NazivFajla");

                    foreach (DataRow row in dt.Rows)
                    {
                        string putanja = row["PutanjaFajla"].ToString();
                        row["NazivFajla"] = Path.GetFileName(putanja);
                    }

                    lstMaterijali.DataSource = null;
                    lstMaterijali.DisplayMember = "NazivFajla";
                    lstMaterijali.ValueMember = "PutanjaFajla";
                    lstMaterijali.DataSource = dt;
                }
            }
        }

        private void UcitajPrivatnePoruke()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT 
                                    kp.Ime AS PosiljalacIme,
                                    kp.Prezime AS PosiljalacPrezime,
                                    kr.Ime AS PrimalacIme,
                                    kr.Prezime AS PrimalacPrezime,
                                    pp.Sadrzaj,
                                    pp.Datum
                                 FROM privatneporuke pp
                                 INNER JOIN korisnici kp ON pp.PosiljalacId = kp.Id
                                 INNER JOIN korisnici kr ON pp.PrimalacId = kr.Id
                                 WHERE pp.PosiljalacId = @Id OR pp.PrimalacId = @Id
                                 ORDER BY pp.Datum ASC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", ulogovaniKorisnikId);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        rtbChat.Clear();

                        while (dr.Read())
                        {
                            string pos = dr["PosiljalacIme"].ToString() + " " + dr["PosiljalacPrezime"].ToString();
                            string pri = dr["PrimalacIme"].ToString() + " " + dr["PrimalacPrezime"].ToString();
                            string sadrzaj = dr["Sadrzaj"].ToString();
                            string datum = Convert.ToDateTime(dr["Datum"]).ToString("dd.MM.yyyy HH:mm");

                            rtbChat.AppendText($"[{datum}] {pos} -> {pri}:{Environment.NewLine}{sadrzaj}{Environment.NewLine}{Environment.NewLine}");
                        }
                    }
                }
            }
        }

        private void UcitajPitanja()
        {
            if (aktivnaGrupaId <= 0) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT 
                                    k.Ime,
                                    k.Prezime,
                                    gp.Sadrzaj,
                                    gp.Datum
                                 FROM grupaporuke gp
                                 INNER JOIN korisnici k ON gp.KorisnikId = k.Id
                                 WHERE gp.GrupaId = @GrupaId
                                   AND gp.Tip = 'Pitanje'
                                 ORDER BY gp.Datum DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GrupaId", aktivnaGrupaId);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        rtbChat.Clear();

                        while (dr.Read())
                        {
                            string ime = dr["Ime"].ToString();
                            string prezime = dr["Prezime"].ToString();
                            string sadrzaj = dr["Sadrzaj"].ToString();
                            string datum = Convert.ToDateTime(dr["Datum"]).ToString("dd.MM.yyyy HH:mm");

                            rtbChat.AppendText($"[{datum}] {ime} {prezime}:{Environment.NewLine}PITANJE: {sadrzaj}{Environment.NewLine}{Environment.NewLine}");
                        }
                    }
                }
            }
        }

        private void UcitajObavestenja()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT Naslov, Sadrzaj, Datum
                                 FROM obavestenja
                                 ORDER BY Datum DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    rtbChat.Clear();

                    while (dr.Read())
                    {
                        string naslov = dr["Naslov"].ToString();
                        string sadrzaj = dr["Sadrzaj"].ToString();
                        string datum = Convert.ToDateTime(dr["Datum"]).ToString("dd.MM.yyyy HH:mm");

                        rtbChat.AppendText($"[{datum}] {naslov}{Environment.NewLine}{sadrzaj}{Environment.NewLine}{Environment.NewLine}");
                    }
                }
            }
        }

        private void UcitajMojProfil()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT Ime, Prezime, KorisnickoIme, Email, Uloga, IFNULL(Odeljenje, '-') AS Odeljenje, Status
                                 FROM korisnici
                                 WHERE Id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", ulogovaniKorisnikId);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        rtbChat.Clear();

                        if (dr.Read())
                        {
                            rtbChat.AppendText("MOJ PROFIL" + Environment.NewLine + Environment.NewLine);
                            rtbChat.AppendText("Ime: " + dr["Ime"] + Environment.NewLine);
                            rtbChat.AppendText("Prezime: " + dr["Prezime"] + Environment.NewLine);
                            rtbChat.AppendText("Korisničko ime: " + dr["KorisnickoIme"] + Environment.NewLine);
                            rtbChat.AppendText("Email: " + dr["Email"] + Environment.NewLine);
                            rtbChat.AppendText("Uloga: " + dr["Uloga"] + Environment.NewLine);
                            rtbChat.AppendText("Odeljenje: " + dr["Odeljenje"] + Environment.NewLine);
                            rtbChat.AppendText("Status: " + dr["Status"] + Environment.NewLine);
                        }
                    }
                }
            }
        }

        private void SacuvajGrupnuPoruku(string sadrzaj, string tip, string putanjaFajla = null)
        {
            if (aktivnaGrupaId <= 0)
            {
                MessageBox.Show("Izaberite grupu.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO grupaporuke
                                 (GrupaId, KorisnikId, Sadrzaj, Tip, PutanjaFajla)
                                 VALUES
                                 (@GrupaId, @KorisnikId, @Sadrzaj, @Tip, @PutanjaFajla)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GrupaId", aktivnaGrupaId);
                    cmd.Parameters.AddWithValue("@KorisnikId", ulogovaniKorisnikId);

                    if (string.IsNullOrWhiteSpace(sadrzaj))
                        cmd.Parameters.AddWithValue("@Sadrzaj", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Sadrzaj", sadrzaj);

                    cmd.Parameters.AddWithValue("@Tip", tip);

                    if (string.IsNullOrWhiteSpace(putanjaFajla))
                        cmd.Parameters.AddWithValue("@PutanjaFajla", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@PutanjaFajla", putanjaFajla);

                    cmd.ExecuteNonQuery();
                }
            }

            txtNovaPoruka.Clear();
            UcitajChatGrupe();
            UcitajMaterijaleGrupe();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            try
            {
                if (aktivniPrikaz != "Grupe")
                {
                    MessageBox.Show("Pređite na 'Moje grupe' da biste poslali poruku u grupu.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNovaPoruka.Text))
                {
                    MessageBox.Show("Unesite poruku.");
                    return;
                }

                SacuvajGrupnuPoruku(txtNovaPoruka.Text.Trim(), "Poruka");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška na dugmetu Pošalji: " + ex.Message);
            }
        }

        private void btnPitanje_Click(object sender, EventArgs e)
        {
            try
            {
                if (aktivniPrikaz != "Grupe")
                {
                    MessageBox.Show("Pređite na 'Moje grupe' da biste postavili pitanje.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNovaPoruka.Text))
                {
                    MessageBox.Show("Unesite pitanje.");
                    return;
                }

                SacuvajGrupnuPoruku(txtNovaPoruka.Text.Trim(), "Pitanje");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška na dugmetu Pitanje: " + ex.Message);
            }
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            try
            {
                if (aktivniPrikaz != "Grupe")
                {
                    MessageBox.Show("Pređite na 'Moje grupe' da biste poslali sliku.");
                    return;
                }

                openFileDialog1.Title = "Izaberite sliku";
                openFileDialog1.Filter = "Slike|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SacuvajGrupnuPoruku("Poslata slika", "Slika", openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška na dugmetu Slika: " + ex.Message);
            }
        }

        private void btnFajl_Click(object sender, EventArgs e)
        {
            try
            {
                if (aktivniPrikaz != "Grupe")
                {
                    MessageBox.Show("Pređite na 'Moje grupe' da biste poslali fajl.");
                    return;
                }

                openFileDialog1.Title = "Izaberite fajl";
                openFileDialog1.Filter = "Svi fajlovi|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SacuvajGrupnuPoruku("Poslat fajl", "Fajl", openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška na dugmetu Fajl: " + ex.Message);
            }
        }

        private void lstMaterijali_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lstMaterijali.SelectedValue == null) return;

                string putanja = lstMaterijali.SelectedValue.ToString();

                if (File.Exists(putanja))
                    Process.Start(new ProcessStartInfo(putanja) { UseShellExecute = true });
                else
                    MessageBox.Show("Fajl ne postoji na zadatoj lokaciji.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri otvaranju fajla: " + ex.Message);
            }
        }

        private void btnMojeGrupe_Click(object sender, EventArgs e)
        {
            try
            {
                aktivniPrikaz = "Grupe";
                ResetMeniBoje();
                btnMojeGrupe.BackColor = Color.RoyalBlue;
                UcitajGrupe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška na dugmetu Moje grupe: " + ex.Message);
            }
        }

        private void btnPrivatnePoruke_Click(object sender, EventArgs e)
        {
            try
            {
                aktivniPrikaz = "PrivatnePoruke";
                ResetMeniBoje();
                btnPrivatnePoruke.BackColor = Color.RoyalBlue;
                lblAktivnaGrupa.Text = "Aktivna sekcija: Privatne poruke";
                UcitajPrivatnePoruke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška na dugmetu Privatne poruke: " + ex.Message);
            }
        }

        private void btnMaterijali_Click(object sender, EventArgs e)
        {
            try
            {
                aktivniPrikaz = "Materijali";
                ResetMeniBoje();
                btnMaterijali.BackColor = Color.RoyalBlue;
                lblAktivnaGrupa.Text = "Aktivna sekcija: Materijali";
                UcitajMaterijaleGrupe();

                rtbChat.Clear();
                rtbChat.AppendText("Materijali za aktivnu grupu su prikazani desno.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška na dugmetu Materijali: " + ex.Message);
            }
        }

        private void btnPitanja_Click(object sender, EventArgs e)
        {
            try
            {
                aktivniPrikaz = "Pitanja";
                ResetMeniBoje();
                btnPitanja.BackColor = Color.RoyalBlue;
                lblAktivnaGrupa.Text = "Aktivna sekcija: Pitanja";
                UcitajPitanja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška na dugmetu Pitanja: " + ex.Message);
            }
        }

        private void btnObavestenja_Click(object sender, EventArgs e)
        {
            try
            {
                aktivniPrikaz = "Obavestenja";
                ResetMeniBoje();
                btnObavestenja.BackColor = Color.RoyalBlue;
                lblAktivnaGrupa.Text = "Aktivna sekcija: Obaveštenja";
                UcitajObavestenja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška na dugmetu Obaveštenja: " + ex.Message);
            }
        }

        private void btnMojProfil_Click(object sender, EventArgs e)
        {
            try
            {
                aktivniPrikaz = "MojProfil";
                ResetMeniBoje();
                btnMojProfil.BackColor = Color.RoyalBlue;
                lblAktivnaGrupa.Text = "Aktivna sekcija: Moj profil";
                UcitajMojProfil();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška na dugmetu Moj profil: " + ex.Message);
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
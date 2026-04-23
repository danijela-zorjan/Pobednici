using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pobednici
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            cmbUloga.Items.Clear();
            cmbUloga.Items.Add("Ucenik");
            cmbUloga.Items.Add("Profesor");
            cmbUloga.Items.Add("Admin");

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

            dgvPodaci.DataSource = new List<dynamic>
            {
                new { Id = 1, Ime = "Marko", Prezime = "Markovic", KorisnickoIme = "marko.m", Email = "marko@gmail.com", Uloga = "Ucenik", Status = "Aktivan", Odeljenje = "III-2" },
                new { Id = 2, Ime = "Jovana", Prezime = "Jovanovic", KorisnickoIme = "jovana.j", Email = "jovana@gmail.com", Uloga = "Ucenik", Status = "Aktivan", Odeljenje = "III-1" },
                new { Id = 3, Ime = "Petar", Prezime = "Petrovic", KorisnickoIme = "petar.p", Email = "petar@gmail.com", Uloga = "Ucenik", Status = "Suspendovan", Odeljenje = "IV-1" },
                new { Id = 4, Ime = "Ivan", Prezime = "Nikolic", KorisnickoIme = "prof.ivan", Email = "ivan@gmail.com", Uloga = "Profesor", Status = "Aktivan", Odeljenje = "-" }
            };
        }
    }
}
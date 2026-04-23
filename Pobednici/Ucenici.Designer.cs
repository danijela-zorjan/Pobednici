namespace Pobednici
{
    partial class Ucenici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnPrikaziSve;

        private System.Windows.Forms.DataGridView dgvUcenici;
        private System.Windows.Forms.GroupBox grpPodaci;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;

        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;

        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.TextBox txtKorisnickoIme;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblOdeljenje;
        private System.Windows.Forms.ComboBox cmbOdeljenje;

        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;

        private System.Windows.Forms.CheckBox chkAktivan;

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnZatvori;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.dgvUcenici = new System.Windows.Forms.DataGridView();
            this.grpPodaci = new System.Windows.Forms.GroupBox();
            this.chkAktivan = new System.Windows.Forms.CheckBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.cmbOdeljenje = new System.Windows.Forms.ComboBox();
            this.lblOdeljenje = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).BeginInit();
            this.grpPodaci.SuspendLayout();
            this.SuspendLayout();

            // lblNaslov
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNaslov.Location = new System.Drawing.Point(24, 18);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(116, 32);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Učenici";

            // lblPretraga
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPretraga.Location = new System.Drawing.Point(26, 69);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(66, 19);
            this.lblPretraga.TabIndex = 1;
            this.lblPretraga.Text = "Pretraga:";

            // txtPretraga
            this.txtPretraga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPretraga.Location = new System.Drawing.Point(98, 66);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(250, 25);
            this.txtPretraga.TabIndex = 2;

            // btnPretrazi
            this.btnPretrazi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPretrazi.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi.Location = new System.Drawing.Point(360, 63);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(110, 32);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);

            // btnPrikaziSve
            this.btnPrikaziSve.BackColor = System.Drawing.Color.Gray;
            this.btnPrikaziSve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziSve.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrikaziSve.ForeColor = System.Drawing.Color.White;
            this.btnPrikaziSve.Location = new System.Drawing.Point(480, 63);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(110, 32);
            this.btnPrikaziSve.TabIndex = 4;
            this.btnPrikaziSve.Text = "Prikaži sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = false;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);

            // dgvUcenici
            this.dgvUcenici.AllowUserToAddRows = false;
            this.dgvUcenici.AllowUserToDeleteRows = false;
            this.dgvUcenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUcenici.BackgroundColor = System.Drawing.Color.White;
            this.dgvUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcenici.Location = new System.Drawing.Point(30, 110);
            this.dgvUcenici.MultiSelect = false;
            this.dgvUcenici.Name = "dgvUcenici";
            this.dgvUcenici.ReadOnly = true;
            this.dgvUcenici.RowHeadersWidth = 51;
            this.dgvUcenici.RowTemplate.Height = 25;
            this.dgvUcenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcenici.Size = new System.Drawing.Size(560, 360);
            this.dgvUcenici.TabIndex = 5;
            this.dgvUcenici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUcenici_CellClick);

            // grpPodaci
            this.grpPodaci.Controls.Add(this.chkAktivan);
            this.grpPodaci.Controls.Add(this.dtpDatumRodjenja);
            this.grpPodaci.Controls.Add(this.lblDatumRodjenja);
            this.grpPodaci.Controls.Add(this.cmbOdeljenje);
            this.grpPodaci.Controls.Add(this.lblOdeljenje);
            this.grpPodaci.Controls.Add(this.txtEmail);
            this.grpPodaci.Controls.Add(this.lblEmail);
            this.grpPodaci.Controls.Add(this.txtKorisnickoIme);
            this.grpPodaci.Controls.Add(this.lblKorisnickoIme);
            this.grpPodaci.Controls.Add(this.txtPrezime);
            this.grpPodaci.Controls.Add(this.lblPrezime);
            this.grpPodaci.Controls.Add(this.txtIme);
            this.grpPodaci.Controls.Add(this.lblIme);
            this.grpPodaci.Controls.Add(this.txtId);
            this.grpPodaci.Controls.Add(this.lblId);
            this.grpPodaci.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPodaci.Location = new System.Drawing.Point(615, 110);
            this.grpPodaci.Name = "grpPodaci";
            this.grpPodaci.Size = new System.Drawing.Size(360, 360);
            this.grpPodaci.TabIndex = 6;
            this.grpPodaci.TabStop = false;
            this.grpPodaci.Text = "Podaci o učeniku";

            // lblId
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblId.Location = new System.Drawing.Point(20, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";

            // txtId
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId.Location = new System.Drawing.Point(140, 32);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(180, 25);
            this.txtId.TabIndex = 1;

            // lblIme
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIme.Location = new System.Drawing.Point(20, 75);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(35, 19);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime:";

            // txtIme
            this.txtIme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIme.Location = new System.Drawing.Point(140, 72);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(180, 25);
            this.txtIme.TabIndex = 3;

            // lblPrezime
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrezime.Location = new System.Drawing.Point(20, 115);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 19);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime:";

            // txtPrezime
            this.txtPrezime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrezime.Location = new System.Drawing.Point(140, 112);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(180, 25);
            this.txtPrezime.TabIndex = 5;

            // lblKorisnickoIme
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKorisnickoIme.Location = new System.Drawing.Point(20, 155);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(101, 19);
            this.lblKorisnickoIme.TabIndex = 6;
            this.lblKorisnickoIme.Text = "Korisničko ime:";

            // txtKorisnickoIme
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKorisnickoIme.Location = new System.Drawing.Point(140, 152);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(180, 25);
            this.txtKorisnickoIme.TabIndex = 7;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(20, 195);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 19);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(140, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 25);
            this.txtEmail.TabIndex = 9;

            // lblOdeljenje
            this.lblOdeljenje.AutoSize = true;
            this.lblOdeljenje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOdeljenje.Location = new System.Drawing.Point(20, 235);
            this.lblOdeljenje.Name = "lblOdeljenje";
            this.lblOdeljenje.Size = new System.Drawing.Size(72, 19);
            this.lblOdeljenje.TabIndex = 10;
            this.lblOdeljenje.Text = "Odeljenje:";

            // cmbOdeljenje
            this.cmbOdeljenje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdeljenje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOdeljenje.FormattingEnabled = true;
            this.cmbOdeljenje.Location = new System.Drawing.Point(140, 232);
            this.cmbOdeljenje.Name = "cmbOdeljenje";
            this.cmbOdeljenje.Size = new System.Drawing.Size(180, 25);
            this.cmbOdeljenje.TabIndex = 11;

            // lblDatumRodjenja
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDatumRodjenja.Location = new System.Drawing.Point(20, 275);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(114, 19);
            this.lblDatumRodjenja.TabIndex = 12;
            this.lblDatumRodjenja.Text = "Datum rođenja:";

            // dtpDatumRodjenja
            this.dtpDatumRodjenja.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(140, 272);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(180, 25);
            this.dtpDatumRodjenja.TabIndex = 13;

            // chkAktivan
            this.chkAktivan.AutoSize = true;
            this.chkAktivan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAktivan.Location = new System.Drawing.Point(140, 315);
            this.chkAktivan.Name = "chkAktivan";
            this.chkAktivan.Size = new System.Drawing.Size(76, 23);
            this.chkAktivan.TabIndex = 14;
            this.chkAktivan.Text = "Aktivan";
            this.chkAktivan.UseVisualStyleBackColor = true;

            // btnDodaj
            this.btnDodaj.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(615, 490);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(110, 40);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);

            // btnIzmeni
            this.btnIzmeni.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIzmeni.ForeColor = System.Drawing.Color.White;
            this.btnIzmeni.Location = new System.Drawing.Point(735, 490);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(110, 40);
            this.btnIzmeni.TabIndex = 8;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);

            // btnObrisi
            this.btnObrisi.BackColor = System.Drawing.Color.Firebrick;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(865, 490);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(110, 40);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);

            // btnOcisti
            this.btnOcisti.BackColor = System.Drawing.Color.SlateBlue;
            this.btnOcisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcisti.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOcisti.ForeColor = System.Drawing.Color.White;
            this.btnOcisti.Location = new System.Drawing.Point(615, 545);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(170, 40);
            this.btnOcisti.TabIndex = 10;
            this.btnOcisti.Text = "Očisti formu";
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);

            // btnZatvori
            this.btnZatvori.BackColor = System.Drawing.Color.DimGray;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnZatvori.ForeColor = System.Drawing.Color.White;
            this.btnZatvori.Location = new System.Drawing.Point(805, 545);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(170, 40);
            this.btnZatvori.TabIndex = 11;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);

            // Ucenici
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1000, 610);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.grpPodaci);
            this.Controls.Add(this.dgvUcenici);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.lblNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ucenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje učenicima";
            this.Load += new System.EventHandler(this.Ucenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).EndInit();
            this.grpPodaci.ResumeLayout(false);
            this.grpPodaci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
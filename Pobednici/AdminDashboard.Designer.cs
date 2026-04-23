namespace Pobednici
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelLevo;
        private System.Windows.Forms.Panel panelGore;
        private System.Windows.Forms.Panel panelGlavni;
        private System.Windows.Forms.Panel panelDesno;
        private System.Windows.Forms.Panel panelDole;

        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.Label lblAdminIme;
        private System.Windows.Forms.Label lblAdminUloga;

        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnGrupe;
        private System.Windows.Forms.Button btnOdeljenja;
        private System.Windows.Forms.Button btnPrijave;
        private System.Windows.Forms.Button btnAuditLog;
        private System.Windows.Forms.Button btnUploadPravila;
        private System.Windows.Forms.Button btnSuspenzije;
        private System.Windows.Forms.Button btnOdjava;

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblPodnaslov;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretrazi;

        private System.Windows.Forms.DataGridView dgvPodaci;

        private System.Windows.Forms.GroupBox grpDetalji;
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
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblOdeljenje;
        private System.Windows.Forms.ComboBox cmbOdeljenje;
        private System.Windows.Forms.CheckBox chkAktivan;

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDeaktiviraj;
        private System.Windows.Forms.Button btnResetLozinka;
        private System.Windows.Forms.Button btnSuspenduj;
        private System.Windows.Forms.Button btnDodeliGrupu;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOcisti;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLevo = new System.Windows.Forms.Panel();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnSuspenzije = new System.Windows.Forms.Button();
            this.btnUploadPravila = new System.Windows.Forms.Button();
            this.btnAuditLog = new System.Windows.Forms.Button();
            this.btnPrijave = new System.Windows.Forms.Button();
            this.btnOdeljenja = new System.Windows.Forms.Button();
            this.btnGrupe = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.lblAdminUloga = new System.Windows.Forms.Label();
            this.lblAdminIme = new System.Windows.Forms.Label();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.panelGore = new System.Windows.Forms.Panel();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPodnaslov = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panelGlavni = new System.Windows.Forms.Panel();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.panelDesno = new System.Windows.Forms.Panel();
            this.grpDetalji = new System.Windows.Forms.GroupBox();
            this.chkAktivan = new System.Windows.Forms.CheckBox();
            this.cmbOdeljenje = new System.Windows.Forms.ComboBox();
            this.lblOdeljenje = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.lblUloga = new System.Windows.Forms.Label();
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
            this.panelDole = new System.Windows.Forms.Panel();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnDodeliGrupu = new System.Windows.Forms.Button();
            this.btnSuspenduj = new System.Windows.Forms.Button();
            this.btnResetLozinka = new System.Windows.Forms.Button();
            this.btnDeaktiviraj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.panelLevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.panelGore.SuspendLayout();
            this.panelGlavni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.panelDesno.SuspendLayout();
            this.grpDetalji.SuspendLayout();
            this.panelDole.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLevo
            // 
            this.panelLevo.BackColor = System.Drawing.Color.FromArgb(32, 43, 59);
            this.panelLevo.Controls.Add(this.btnOdjava);
            this.panelLevo.Controls.Add(this.btnSuspenzije);
            this.panelLevo.Controls.Add(this.btnUploadPravila);
            this.panelLevo.Controls.Add(this.btnAuditLog);
            this.panelLevo.Controls.Add(this.btnPrijave);
            this.panelLevo.Controls.Add(this.btnOdeljenja);
            this.panelLevo.Controls.Add(this.btnGrupe);
            this.panelLevo.Controls.Add(this.btnKorisnici);
            this.panelLevo.Controls.Add(this.lblAdminUloga);
            this.panelLevo.Controls.Add(this.lblAdminIme);
            this.panelLevo.Controls.Add(this.picAdmin);
            this.panelLevo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLevo.Location = new System.Drawing.Point(0, 0);
            this.panelLevo.Name = "panelLevo";
            this.panelLevo.Size = new System.Drawing.Size(230, 740);
            this.panelLevo.TabIndex = 0;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.Firebrick;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.ForeColor = System.Drawing.Color.White;
            this.btnOdjava.Location = new System.Drawing.Point(25, 662);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(180, 38);
            this.btnOdjava.TabIndex = 10;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            // 
            // btnSuspenzije
            // 
            this.btnSuspenzije.BackColor = System.Drawing.Color.FromArgb(54, 69, 90);
            this.btnSuspenzije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuspenzije.ForeColor = System.Drawing.Color.White;
            this.btnSuspenzije.Location = new System.Drawing.Point(25, 512);
            this.btnSuspenzije.Name = "btnSuspenzije";
            this.btnSuspenzije.Size = new System.Drawing.Size(180, 38);
            this.btnSuspenzije.TabIndex = 9;
            this.btnSuspenzije.Text = "Suspenzije";
            this.btnSuspenzije.UseVisualStyleBackColor = false;
            // 
            // btnUploadPravila
            // 
            this.btnUploadPravila.BackColor = System.Drawing.Color.FromArgb(54, 69, 90);
            this.btnUploadPravila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPravila.ForeColor = System.Drawing.Color.White;
            this.btnUploadPravila.Location = new System.Drawing.Point(25, 468);
            this.btnUploadPravila.Name = "btnUploadPravila";
            this.btnUploadPravila.Size = new System.Drawing.Size(180, 38);
            this.btnUploadPravila.TabIndex = 8;
            this.btnUploadPravila.Text = "Upload pravila";
            this.btnUploadPravila.UseVisualStyleBackColor = false;
            // 
            // btnAuditLog
            // 
            this.btnAuditLog.BackColor = System.Drawing.Color.FromArgb(54, 69, 90);
            this.btnAuditLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditLog.ForeColor = System.Drawing.Color.White;
            this.btnAuditLog.Location = new System.Drawing.Point(25, 424);
            this.btnAuditLog.Name = "btnAuditLog";
            this.btnAuditLog.Size = new System.Drawing.Size(180, 38);
            this.btnAuditLog.TabIndex = 7;
            this.btnAuditLog.Text = "Audit log";
            this.btnAuditLog.UseVisualStyleBackColor = false;
            // 
            // btnPrijave
            // 
            this.btnPrijave.BackColor = System.Drawing.Color.FromArgb(54, 69, 90);
            this.btnPrijave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijave.ForeColor = System.Drawing.Color.White;
            this.btnPrijave.Location = new System.Drawing.Point(25, 380);
            this.btnPrijave.Name = "btnPrijave";
            this.btnPrijave.Size = new System.Drawing.Size(180, 38);
            this.btnPrijave.TabIndex = 6;
            this.btnPrijave.Text = "Prijave sadržaja";
            this.btnPrijave.UseVisualStyleBackColor = false;
            // 
            // btnOdeljenja
            // 
            this.btnOdeljenja.BackColor = System.Drawing.Color.FromArgb(54, 69, 90);
            this.btnOdeljenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdeljenja.ForeColor = System.Drawing.Color.White;
            this.btnOdeljenja.Location = new System.Drawing.Point(25, 336);
            this.btnOdeljenja.Name = "btnOdeljenja";
            this.btnOdeljenja.Size = new System.Drawing.Size(180, 38);
            this.btnOdeljenja.TabIndex = 5;
            this.btnOdeljenja.Text = "Odeljenja i kategorije";
            this.btnOdeljenja.UseVisualStyleBackColor = false;
            // 
            // btnGrupe
            // 
            this.btnGrupe.BackColor = System.Drawing.Color.FromArgb(54, 69, 90);
            this.btnGrupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrupe.ForeColor = System.Drawing.Color.White;
            this.btnGrupe.Location = new System.Drawing.Point(25, 292);
            this.btnGrupe.Name = "btnGrupe";
            this.btnGrupe.Size = new System.Drawing.Size(180, 38);
            this.btnGrupe.TabIndex = 4;
            this.btnGrupe.Text = "Grupe";
            this.btnGrupe.UseVisualStyleBackColor = false;
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.BackColor = System.Drawing.Color.FromArgb(79, 111, 255);
            this.btnKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorisnici.ForeColor = System.Drawing.Color.White;
            this.btnKorisnici.Location = new System.Drawing.Point(25, 248);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(180, 38);
            this.btnKorisnici.TabIndex = 3;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = false;
            // 
            // lblAdminUloga
            // 
            this.lblAdminUloga.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAdminUloga.Location = new System.Drawing.Point(12, 160);
            this.lblAdminUloga.Name = "lblAdminUloga";
            this.lblAdminUloga.Size = new System.Drawing.Size(205, 23);
            this.lblAdminUloga.TabIndex = 2;
            this.lblAdminUloga.Text = "Administrator";
            this.lblAdminUloga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminIme
            // 
            this.lblAdminIme.ForeColor = System.Drawing.Color.White;
            this.lblAdminIme.Location = new System.Drawing.Point(12, 132);
            this.lblAdminIme.Name = "lblAdminIme";
            this.lblAdminIme.Size = new System.Drawing.Size(205, 23);
            this.lblAdminIme.TabIndex = 1;
            this.lblAdminIme.Text = "admin1";
            this.lblAdminIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAdmin
            // 
            this.picAdmin.BackColor = System.Drawing.Color.White;
            this.picAdmin.Location = new System.Drawing.Point(65, 20);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(100, 100);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmin.TabIndex = 0;
            this.picAdmin.TabStop = false;
            // 
            // panelGore
            // 
            this.panelGore.BackColor = System.Drawing.Color.White;
            this.panelGore.Controls.Add(this.btnPretrazi);
            this.panelGore.Controls.Add(this.txtPretraga);
            this.panelGore.Controls.Add(this.lblPodnaslov);
            this.panelGore.Controls.Add(this.lblNaslov);
            this.panelGore.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGore.Location = new System.Drawing.Point(230, 0);
            this.panelGore.Name = "panelGore";
            this.panelGore.Size = new System.Drawing.Size(1220, 85);
            this.panelGore.TabIndex = 1;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi.Location = new System.Drawing.Point(1082, 26);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(100, 30);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPretraga.Location = new System.Drawing.Point(860, 28);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(205, 25);
            this.txtPretraga.TabIndex = 2;
            // 
            // lblPodnaslov
            // 
            this.lblPodnaslov.AutoSize = true;
            this.lblPodnaslov.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPodnaslov.ForeColor = System.Drawing.Color.DimGray;
            this.lblPodnaslov.Location = new System.Drawing.Point(24, 49);
            this.lblPodnaslov.Name = "lblPodnaslov";
            this.lblPodnaslov.Size = new System.Drawing.Size(334, 19);
            this.lblPodnaslov.TabIndex = 1;
            this.lblPodnaslov.Text = "Upravljanje korisnicima, grupama, prijavama i logovima";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNaslov.Location = new System.Drawing.Point(20, 12);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(226, 31);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Administrator panel";
            // 
            // panelGlavni
            // 
            this.panelGlavni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelGlavni.Controls.Add(this.dgvPodaci);
            this.panelGlavni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGlavni.Location = new System.Drawing.Point(230, 85);
            this.panelGlavni.Name = "panelGlavni";
            this.panelGlavni.Size = new System.Drawing.Size(760, 655);
            this.panelGlavni.TabIndex = 2;
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.AllowUserToAddRows = false;
            this.dgvPodaci.AllowUserToDeleteRows = false;
            this.dgvPodaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPodaci.BackgroundColor = System.Drawing.Color.White;
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPodaci.Location = new System.Drawing.Point(0, 0);
            this.dgvPodaci.MultiSelect = false;
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.ReadOnly = true;
            this.dgvPodaci.RowHeadersWidth = 51;
            this.dgvPodaci.RowTemplate.Height = 25;
            this.dgvPodaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPodaci.Size = new System.Drawing.Size(760, 655);
            this.dgvPodaci.TabIndex = 0;
            // 
            // panelDesno
            // 
            this.panelDesno.BackColor = System.Drawing.Color.AliceBlue;
            this.panelDesno.Controls.Add(this.grpDetalji);
            this.panelDesno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesno.Location = new System.Drawing.Point(990, 85);
            this.panelDesno.Name = "panelDesno";
            this.panelDesno.Size = new System.Drawing.Size(460, 655);
            this.panelDesno.TabIndex = 3;
            // 
            // grpDetalji
            // 
            this.grpDetalji.Controls.Add(this.chkAktivan);
            this.grpDetalji.Controls.Add(this.cmbOdeljenje);
            this.grpDetalji.Controls.Add(this.lblOdeljenje);
            this.grpDetalji.Controls.Add(this.cmbStatus);
            this.grpDetalji.Controls.Add(this.lblStatus);
            this.grpDetalji.Controls.Add(this.cmbUloga);
            this.grpDetalji.Controls.Add(this.lblUloga);
            this.grpDetalji.Controls.Add(this.txtEmail);
            this.grpDetalji.Controls.Add(this.lblEmail);
            this.grpDetalji.Controls.Add(this.txtKorisnickoIme);
            this.grpDetalji.Controls.Add(this.lblKorisnickoIme);
            this.grpDetalji.Controls.Add(this.txtPrezime);
            this.grpDetalji.Controls.Add(this.lblPrezime);
            this.grpDetalji.Controls.Add(this.txtIme);
            this.grpDetalji.Controls.Add(this.lblIme);
            this.grpDetalji.Controls.Add(this.txtId);
            this.grpDetalji.Controls.Add(this.lblId);
            this.grpDetalji.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDetalji.Location = new System.Drawing.Point(20, 20);
            this.grpDetalji.Name = "grpDetalji";
            this.grpDetalji.Size = new System.Drawing.Size(420, 420);
            this.grpDetalji.TabIndex = 0;
            this.grpDetalji.TabStop = false;
            this.grpDetalji.Text = "Detalji korisnika";
            // 
            // chkAktivan
            // 
            this.chkAktivan.AutoSize = true;
            this.chkAktivan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAktivan.Location = new System.Drawing.Point(145, 371);
            this.chkAktivan.Name = "chkAktivan";
            this.chkAktivan.Size = new System.Drawing.Size(76, 23);
            this.chkAktivan.TabIndex = 15;
            this.chkAktivan.Text = "Aktivan";
            this.chkAktivan.UseVisualStyleBackColor = true;
            // 
            // cmbOdeljenje
            // 
            this.cmbOdeljenje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdeljenje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOdeljenje.FormattingEnabled = true;
            this.cmbOdeljenje.Location = new System.Drawing.Point(145, 321);
            this.cmbOdeljenje.Name = "cmbOdeljenje";
            this.cmbOdeljenje.Size = new System.Drawing.Size(235, 25);
            this.cmbOdeljenje.TabIndex = 14;
            // 
            // lblOdeljenje
            // 
            this.lblOdeljenje.AutoSize = true;
            this.lblOdeljenje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOdeljenje.Location = new System.Drawing.Point(24, 324);
            this.lblOdeljenje.Name = "lblOdeljenje";
            this.lblOdeljenje.Size = new System.Drawing.Size(72, 19);
            this.lblOdeljenje.TabIndex = 13;
            this.lblOdeljenje.Text = "Odeljenje:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(145, 277);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(235, 25);
            this.cmbStatus.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(24, 280);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 19);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status:";
            // 
            // cmbUloga
            // 
            this.cmbUloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUloga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(145, 233);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(235, 25);
            this.cmbUloga.TabIndex = 10;
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUloga.Location = new System.Drawing.Point(24, 236);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(48, 19);
            this.lblUloga.TabIndex = 9;
            this.lblUloga.Text = "Uloga:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(145, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 25);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(24, 192);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 19);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKorisnickoIme.Location = new System.Drawing.Point(145, 145);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(235, 25);
            this.txtKorisnickoIme.TabIndex = 6;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKorisnickoIme.Location = new System.Drawing.Point(24, 148);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(101, 19);
            this.lblKorisnickoIme.TabIndex = 5;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrezime.Location = new System.Drawing.Point(145, 101);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(235, 25);
            this.txtPrezime.TabIndex = 4;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrezime.Location = new System.Drawing.Point(24, 104);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 19);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIme.Location = new System.Drawing.Point(145, 57);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(235, 25);
            this.txtIme.TabIndex = 2;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIme.Location = new System.Drawing.Point(24, 60);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(35, 19);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId.Location = new System.Drawing.Point(145, 18);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(235, 25);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblId.Location = new System.Drawing.Point(24, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // panelDole
            // 
            this.panelDole.BackColor = System.Drawing.Color.White;
            this.panelDole.Controls.Add(this.btnOcisti);
            this.panelDole.Controls.Add(this.btnSacuvaj);
            this.panelDole.Controls.Add(this.btnDodeliGrupu);
            this.panelDole.Controls.Add(this.btnSuspenduj);
            this.panelDole.Controls.Add(this.btnResetLozinka);
            this.panelDole.Controls.Add(this.btnDeaktiviraj);
            this.panelDole.Controls.Add(this.btnIzmeni);
            this.panelDole.Controls.Add(this.btnDodaj);
            this.panelDole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDole.Location = new System.Drawing.Point(990, 580);
            this.panelDole.Name = "panelDole";
            this.panelDole.Size = new System.Drawing.Size(460, 160);
            this.panelDole.TabIndex = 4;
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.Color.Gray;
            this.btnOcisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcisti.ForeColor = System.Drawing.Color.White;
            this.btnOcisti.Location = new System.Drawing.Point(236, 104);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(180, 38);
            this.btnOcisti.TabIndex = 7;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(26, 104);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(180, 38);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // btnDodeliGrupu
            // 
            this.btnDodeliGrupu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDodeliGrupu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodeliGrupu.ForeColor = System.Drawing.Color.White;
            this.btnDodeliGrupu.Location = new System.Drawing.Point(236, 60);
            this.btnDodeliGrupu.Name = "btnDodeliGrupu";
            this.btnDodeliGrupu.Size = new System.Drawing.Size(180, 38);
            this.btnDodeliGrupu.TabIndex = 5;
            this.btnDodeliGrupu.Text = "Dodeli u grupu";
            this.btnDodeliGrupu.UseVisualStyleBackColor = false;
            // 
            // btnSuspenduj
            // 
            this.btnSuspenduj.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSuspenduj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuspenduj.ForeColor = System.Drawing.Color.White;
            this.btnSuspenduj.Location = new System.Drawing.Point(26, 60);
            this.btnSuspenduj.Name = "btnSuspenduj";
            this.btnSuspenduj.Size = new System.Drawing.Size(180, 38);
            this.btnSuspenduj.TabIndex = 4;
            this.btnSuspenduj.Text = "Suspenduj";
            this.btnSuspenduj.UseVisualStyleBackColor = false;
            // 
            // btnResetLozinka
            // 
            this.btnResetLozinka.BackColor = System.Drawing.Color.MediumPurple;
            this.btnResetLozinka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetLozinka.ForeColor = System.Drawing.Color.White;
            this.btnResetLozinka.Location = new System.Drawing.Point(236, 16);
            this.btnResetLozinka.Name = "btnResetLozinka";
            this.btnResetLozinka.Size = new System.Drawing.Size(180, 38);
            this.btnResetLozinka.TabIndex = 3;
            this.btnResetLozinka.Text = "Reset lozinke";
            this.btnResetLozinka.UseVisualStyleBackColor = false;
            // 
            // btnDeaktiviraj
            // 
            this.btnDeaktiviraj.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeaktiviraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeaktiviraj.ForeColor = System.Drawing.Color.White;
            this.btnDeaktiviraj.Location = new System.Drawing.Point(26, 16);
            this.btnDeaktiviraj.Name = "btnDeaktiviraj";
            this.btnDeaktiviraj.Size = new System.Drawing.Size(180, 38);
            this.btnDeaktiviraj.TabIndex = 2;
            this.btnDeaktiviraj.Text = "Deaktiviraj nalog";
            this.btnDeaktiviraj.UseVisualStyleBackColor = false;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(0, 0);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 1;
            // 
            // btnDodaj
            this.btnDodaj.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(26, 16);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(180, 38);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj nalog";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1450, 740);
            this.Controls.Add(this.panelDole);
            this.Controls.Add(this.panelDesno);
            this.Controls.Add(this.panelGlavni);
            this.Controls.Add(this.panelGore);
            this.Controls.Add(this.panelLevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Panel";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelLevo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.panelGore.ResumeLayout(false);
            this.panelGore.PerformLayout();
            this.panelGlavni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.panelDesno.ResumeLayout(false);
            this.grpDetalji.ResumeLayout(false);
            this.grpDetalji.PerformLayout();
            this.panelDole.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
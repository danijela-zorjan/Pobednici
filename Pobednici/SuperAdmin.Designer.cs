// SuperAdmin.Designer.cs
using System.Windows.Forms;

namespace Pobednici
{
    partial class SuperAdmin
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelTop;
        private Panel panelMenu;
        private Panel panelMain;
        private Panel panelActions;

        private Label lblNaslov;
        private Label lblSuperAdmin;
        private Label lblSekcija;

        private Button btnProfil;
        private Button btnLogout;

        private Button btnDashboard;
        private Button btnAdministratori;
        private Button btnKorisnici;
        private Button btnPermisije;
        private Button btnPodesavanja;
        private Button btnAuditLog;
        private Button btnBackup;
        private Button btnMaintenance;

        private Button btnDodajAdmina;
        private Button btnObrisiAdmina;
        private Button btnSacuvajPodesavanja;
        private Button btnZakljucajSistem;
        private Button btnBackupNow;
        private Button btnRestore;
        private Button btnOsvezi;
        private Button btnPretrazi;

        private DataGridView dataGridInfo;
        private TextBox txtPretraga;
        private TextBox txtNaslov;
        private RichTextBox rtbDetalji;
        private CheckBox chkMaintenance;
        private CheckBox chkDirektnePoruke;
        private CheckBox chkUploadSlika;
        private NumericUpDown numMaxUpload;
        private Label lblPretraga;
        private Label lblNaslovPolje;
        private Label lblDetalji;
        private Label lblMaxUpload;

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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblSuperAdmin = new System.Windows.Forms.Label();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnAuditLog = new System.Windows.Forms.Button();
            this.btnPodesavanja = new System.Windows.Forms.Button();
            this.btnPermisije = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnAdministratori = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.chkUploadSlika = new System.Windows.Forms.CheckBox();
            this.chkDirektnePoruke = new System.Windows.Forms.CheckBox();
            this.chkMaintenance = new System.Windows.Forms.CheckBox();
            this.lblMaxUpload = new System.Windows.Forms.Label();
            this.numMaxUpload = new System.Windows.Forms.NumericUpDown();
            this.lblDetalji = new System.Windows.Forms.Label();
            this.rtbDetalji = new System.Windows.Forms.RichTextBox();
            this.lblNaslovPolje = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.dataGridInfo = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.lblSekcija = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackupNow = new System.Windows.Forms.Button();
            this.btnZakljucajSistem = new System.Windows.Forms.Button();
            this.btnSacuvajPodesavanja = new System.Windows.Forms.Button();
            this.btnObrisiAdmina = new System.Windows.Forms.Button();
            this.btnDodajAdmina = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panelTop.Controls.Add(this.lblNaslov);
            this.panelTop.Controls.Add(this.lblSuperAdmin);
            this.panelTop.Controls.Add(this.btnProfil);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1450, 75);
            this.panelTop.TabIndex = 0;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(20, 22);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(292, 37);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Super Admin Console";
            // 
            // lblSuperAdmin
            // 
            this.lblSuperAdmin.AutoSize = true;
            this.lblSuperAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSuperAdmin.ForeColor = System.Drawing.Color.White;
            this.lblSuperAdmin.Location = new System.Drawing.Point(946, 24);
            this.lblSuperAdmin.Name = "lblSuperAdmin";
            this.lblSuperAdmin.Size = new System.Drawing.Size(216, 23);
            this.lblSuperAdmin.TabIndex = 1;
            this.lblSuperAdmin.Text = "Prijavljen: superadmin/root";
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.ForeColor = System.Drawing.Color.White;
            this.btnProfil.Location = new System.Drawing.Point(1205, 20);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(90, 35);
            this.btnProfil.TabIndex = 2;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1310, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 35);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Odjava";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelMenu.Controls.Add(this.btnMaintenance);
            this.panelMenu.Controls.Add(this.btnBackup);
            this.panelMenu.Controls.Add(this.btnAuditLog);
            this.panelMenu.Controls.Add(this.btnPodesavanja);
            this.panelMenu.Controls.Add(this.btnPermisije);
            this.panelMenu.Controls.Add(this.btnKorisnici);
            this.panelMenu.Controls.Add(this.btnAdministratori);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 75);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 775);
            this.panelMenu.TabIndex = 1;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Location = new System.Drawing.Point(20, 468);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(180, 48);
            this.btnMaintenance.TabIndex = 7;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(20, 404);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(180, 48);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Text = "Backup / Restore";
            this.btnBackup.UseVisualStyleBackColor = false;
            // 
            // btnAuditLog
            // 
            this.btnAuditLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAuditLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditLog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAuditLog.ForeColor = System.Drawing.Color.White;
            this.btnAuditLog.Location = new System.Drawing.Point(20, 340);
            this.btnAuditLog.Name = "btnAuditLog";
            this.btnAuditLog.Size = new System.Drawing.Size(180, 48);
            this.btnAuditLog.TabIndex = 5;
            this.btnAuditLog.Text = "Audit Log";
            this.btnAuditLog.UseVisualStyleBackColor = false;
            // 
            // btnPodesavanja
            // 
            this.btnPodesavanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPodesavanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPodesavanja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPodesavanja.ForeColor = System.Drawing.Color.White;
            this.btnPodesavanja.Location = new System.Drawing.Point(20, 276);
            this.btnPodesavanja.Name = "btnPodesavanja";
            this.btnPodesavanja.Size = new System.Drawing.Size(180, 48);
            this.btnPodesavanja.TabIndex = 4;
            this.btnPodesavanja.Text = "Global Settings";
            this.btnPodesavanja.UseVisualStyleBackColor = false;
            // 
            // btnPermisije
            // 
            this.btnPermisije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPermisije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermisije.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPermisije.ForeColor = System.Drawing.Color.White;
            this.btnPermisije.Location = new System.Drawing.Point(20, 212);
            this.btnPermisije.Name = "btnPermisije";
            this.btnPermisije.Size = new System.Drawing.Size(180, 48);
            this.btnPermisije.TabIndex = 3;
            this.btnPermisije.Text = "Permissions";
            this.btnPermisije.UseVisualStyleBackColor = false;
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorisnici.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKorisnici.ForeColor = System.Drawing.Color.White;
            this.btnKorisnici.Location = new System.Drawing.Point(20, 148);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(180, 48);
            this.btnKorisnici.TabIndex = 2;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = false;
            // 
            // btnAdministratori
            // 
            this.btnAdministratori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAdministratori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministratori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdministratori.ForeColor = System.Drawing.Color.White;
            this.btnAdministratori.Location = new System.Drawing.Point(20, 84);
            this.btnAdministratori.Name = "btnAdministratori";
            this.btnAdministratori.Size = new System.Drawing.Size(180, 48);
            this.btnAdministratori.TabIndex = 1;
            this.btnAdministratori.Text = "Administratori";
            this.btnAdministratori.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(20, 20);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(180, 48);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.chkUploadSlika);
            this.panelMain.Controls.Add(this.chkDirektnePoruke);
            this.panelMain.Controls.Add(this.chkMaintenance);
            this.panelMain.Controls.Add(this.lblMaxUpload);
            this.panelMain.Controls.Add(this.numMaxUpload);
            this.panelMain.Controls.Add(this.lblDetalji);
            this.panelMain.Controls.Add(this.rtbDetalji);
            this.panelMain.Controls.Add(this.lblNaslovPolje);
            this.panelMain.Controls.Add(this.txtNaslov);
            this.panelMain.Controls.Add(this.dataGridInfo);
            this.panelMain.Controls.Add(this.btnPretrazi);
            this.panelMain.Controls.Add(this.txtPretraga);
            this.panelMain.Controls.Add(this.lblPretraga);
            this.panelMain.Controls.Add(this.lblSekcija);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 75);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(990, 775);
            this.panelMain.TabIndex = 2;
            // 
            // chkUploadSlika
            // 
            this.chkUploadSlika.AutoSize = true;
            this.chkUploadSlika.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkUploadSlika.Location = new System.Drawing.Point(574, 570);
            this.chkUploadSlika.Name = "chkUploadSlika";
            this.chkUploadSlika.Size = new System.Drawing.Size(124, 27);
            this.chkUploadSlika.TabIndex = 13;
            this.chkUploadSlika.Text = "Upload slika";
            this.chkUploadSlika.UseVisualStyleBackColor = true;
            // 
            // chkDirektnePoruke
            // 
            this.chkDirektnePoruke.AutoSize = true;
            this.chkDirektnePoruke.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkDirektnePoruke.Location = new System.Drawing.Point(574, 535);
            this.chkDirektnePoruke.Name = "chkDirektnePoruke";
            this.chkDirektnePoruke.Size = new System.Drawing.Size(154, 27);
            this.chkDirektnePoruke.TabIndex = 12;
            this.chkDirektnePoruke.Text = "Direktne poruke";
            this.chkDirektnePoruke.UseVisualStyleBackColor = true;
            // 
            // chkMaintenance
            // 
            this.chkMaintenance.AutoSize = true;
            this.chkMaintenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkMaintenance.Location = new System.Drawing.Point(574, 500);
            this.chkMaintenance.Name = "chkMaintenance";
            this.chkMaintenance.Size = new System.Drawing.Size(180, 27);
            this.chkMaintenance.TabIndex = 11;
            this.chkMaintenance.Text = "Maintenance mode";
            this.chkMaintenance.UseVisualStyleBackColor = true;
            // 
            // lblMaxUpload
            // 
            this.lblMaxUpload.AutoSize = true;
            this.lblMaxUpload.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaxUpload.Location = new System.Drawing.Point(570, 455);
            this.lblMaxUpload.Name = "lblMaxUpload";
            this.lblMaxUpload.Size = new System.Drawing.Size(177, 23);
            this.lblMaxUpload.TabIndex = 9;
            this.lblMaxUpload.Text = "Max upload size (MB):";
            // 
            // numMaxUpload
            // 
            this.numMaxUpload.Location = new System.Drawing.Point(730, 454);
            this.numMaxUpload.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numMaxUpload.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxUpload.Name = "numMaxUpload";
            this.numMaxUpload.Size = new System.Drawing.Size(90, 22);
            this.numMaxUpload.TabIndex = 10;
            this.numMaxUpload.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lblDetalji
            // 
            this.lblDetalji.AutoSize = true;
            this.lblDetalji.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetalji.Location = new System.Drawing.Point(26, 492);
            this.lblDetalji.Name = "lblDetalji";
            this.lblDetalji.Size = new System.Drawing.Size(62, 23);
            this.lblDetalji.TabIndex = 7;
            this.lblDetalji.Text = "Detalji:";
            // 
            // rtbDetalji
            // 
            this.rtbDetalji.Location = new System.Drawing.Point(94, 492);
            this.rtbDetalji.Name = "rtbDetalji";
            this.rtbDetalji.Size = new System.Drawing.Size(420, 150);
            this.rtbDetalji.TabIndex = 8;
            this.rtbDetalji.Text = "";
            // 
            // lblNaslovPolje
            // 
            this.lblNaslovPolje.AutoSize = true;
            this.lblNaslovPolje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNaslovPolje.Location = new System.Drawing.Point(26, 455);
            this.lblNaslovPolje.Name = "lblNaslovPolje";
            this.lblNaslovPolje.Size = new System.Drawing.Size(65, 23);
            this.lblNaslovPolje.TabIndex = 5;
            this.lblNaslovPolje.Text = "Naslov:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(94, 454);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(420, 22);
            this.txtNaslov.TabIndex = 6;
            // 
            // dataGridInfo
            // 
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.Location = new System.Drawing.Point(30, 110);
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.RowHeadersWidth = 51;
            this.dataGridInfo.RowTemplate.Height = 24;
            this.dataGridInfo.Size = new System.Drawing.Size(930, 320);
            this.dataGridInfo.TabIndex = 4;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi.Location = new System.Drawing.Point(360, 61);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(90, 32);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(94, 66);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(250, 22);
            this.txtPretraga.TabIndex = 2;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPretraga.Location = new System.Drawing.Point(26, 67);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(79, 23);
            this.lblPretraga.TabIndex = 1;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // lblSekcija
            // 
            this.lblSekcija.AutoSize = true;
            this.lblSekcija.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSekcija.Location = new System.Drawing.Point(25, 20);
            this.lblSekcija.Name = "lblSekcija";
            this.lblSekcija.Size = new System.Drawing.Size(303, 32);
            this.lblSekcija.TabIndex = 0;
            this.lblSekcija.Text = "Sekcija: Super Dashboard";
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.Gainsboro;
            this.panelActions.Controls.Add(this.btnOsvezi);
            this.panelActions.Controls.Add(this.btnRestore);
            this.panelActions.Controls.Add(this.btnBackupNow);
            this.panelActions.Controls.Add(this.btnZakljucajSistem);
            this.panelActions.Controls.Add(this.btnSacuvajPodesavanja);
            this.panelActions.Controls.Add(this.btnObrisiAdmina);
            this.panelActions.Controls.Add(this.btnDodajAdmina);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelActions.Location = new System.Drawing.Point(1210, 75);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(240, 775);
            this.panelActions.TabIndex = 3;
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.BackColor = System.Drawing.Color.Gray;
            this.btnOsvezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvezi.ForeColor = System.Drawing.Color.White;
            this.btnOsvezi.Location = new System.Drawing.Point(25, 385);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(190, 45);
            this.btnOsvezi.TabIndex = 6;
            this.btnOsvezi.Text = "Osveži prikaz";
            this.btnOsvezi.UseVisualStyleBackColor = false;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(25, 325);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(190, 45);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            // 
            // btnBackupNow
            // 
            this.btnBackupNow.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBackupNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupNow.ForeColor = System.Drawing.Color.White;
            this.btnBackupNow.Location = new System.Drawing.Point(25, 265);
            this.btnBackupNow.Name = "btnBackupNow";
            this.btnBackupNow.Size = new System.Drawing.Size(190, 45);
            this.btnBackupNow.TabIndex = 4;
            this.btnBackupNow.Text = "Kreiraj backup";
            this.btnBackupNow.UseVisualStyleBackColor = false;
            // 
            // btnZakljucajSistem
            // 
            this.btnZakljucajSistem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnZakljucajSistem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZakljucajSistem.ForeColor = System.Drawing.Color.White;
            this.btnZakljucajSistem.Location = new System.Drawing.Point(25, 205);
            this.btnZakljucajSistem.Name = "btnZakljucajSistem";
            this.btnZakljucajSistem.Size = new System.Drawing.Size(190, 45);
            this.btnZakljucajSistem.TabIndex = 3;
            this.btnZakljucajSistem.Text = "Toggle maintenance";
            this.btnZakljucajSistem.UseVisualStyleBackColor = false;
            // 
            // btnSacuvajPodesavanja
            // 
            this.btnSacuvajPodesavanja.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSacuvajPodesavanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajPodesavanja.ForeColor = System.Drawing.Color.White;
            this.btnSacuvajPodesavanja.Location = new System.Drawing.Point(25, 145);
            this.btnSacuvajPodesavanja.Name = "btnSacuvajPodesavanja";
            this.btnSacuvajPodesavanja.Size = new System.Drawing.Size(190, 45);
            this.btnSacuvajPodesavanja.TabIndex = 2;
            this.btnSacuvajPodesavanja.Text = "Sačuvaj podešavanja";
            this.btnSacuvajPodesavanja.UseVisualStyleBackColor = false;
            // 
            // btnObrisiAdmina
            // 
            this.btnObrisiAdmina.BackColor = System.Drawing.Color.SteelBlue;
            this.btnObrisiAdmina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiAdmina.ForeColor = System.Drawing.Color.White;
            this.btnObrisiAdmina.Location = new System.Drawing.Point(25, 85);
            this.btnObrisiAdmina.Name = "btnObrisiAdmina";
            this.btnObrisiAdmina.Size = new System.Drawing.Size(190, 45);
            this.btnObrisiAdmina.TabIndex = 1;
            this.btnObrisiAdmina.Text = "Ukloni admina";
            this.btnObrisiAdmina.UseVisualStyleBackColor = false;
            // 
            // btnDodajAdmina
            // 
            this.btnDodajAdmina.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDodajAdmina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajAdmina.ForeColor = System.Drawing.Color.White;
            this.btnDodajAdmina.Location = new System.Drawing.Point(25, 25);
            this.btnDodajAdmina.Name = "btnDodajAdmina";
            this.btnDodajAdmina.Size = new System.Drawing.Size(190, 45);
            this.btnDodajAdmina.TabIndex = 0;
            this.btnDodajAdmina.Text = "Dodaj admina";
            this.btnDodajAdmina.UseVisualStyleBackColor = false;
            // 
            // SuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 850);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.Name = "SuperAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Admin";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
namespace Pobednici
{
    partial class UcenikDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelLevo;
        private System.Windows.Forms.Panel panelGore;
        private System.Windows.Forms.Panel panelSredina;
        private System.Windows.Forms.Panel panelDesno;
        private System.Windows.Forms.Panel panelPoruka;

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblUlogovaniKorisnik;
        private System.Windows.Forms.TextBox txtPretraga;

        private System.Windows.Forms.PictureBox picProfil;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblOdeljenje;

        private System.Windows.Forms.Button btnMojeGrupe;
        private System.Windows.Forms.Button btnPrivatnePoruke;
        private System.Windows.Forms.Button btnMaterijali;
        private System.Windows.Forms.Button btnPitanja;
        private System.Windows.Forms.Button btnObavestenja;
        private System.Windows.Forms.Button btnMojProfil;
        private System.Windows.Forms.Button btnOdjava;

        private System.Windows.Forms.ListBox lstGrupe;
        private System.Windows.Forms.Label lblGrupe;

        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox txtNovaPoruka;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.Button btnFajl;
        private System.Windows.Forms.Button btnPitanje;

        private System.Windows.Forms.Label lblClanovi;
        private System.Windows.Forms.ListBox lstClanovi;

        private System.Windows.Forms.Label lblMaterijali;
        private System.Windows.Forms.ListBox lstMaterijali;

        private System.Windows.Forms.Label lblAktivnaGrupa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

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
            this.btnMojProfil = new System.Windows.Forms.Button();
            this.btnObavestenja = new System.Windows.Forms.Button();
            this.btnPitanja = new System.Windows.Forms.Button();
            this.btnMaterijali = new System.Windows.Forms.Button();
            this.btnPrivatnePoruke = new System.Windows.Forms.Button();
            this.btnMojeGrupe = new System.Windows.Forms.Button();
            this.lblOdeljenje = new System.Windows.Forms.Label();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.picProfil = new System.Windows.Forms.PictureBox();
            this.panelGore = new System.Windows.Forms.Panel();
            this.lblAktivnaGrupa = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblUlogovaniKorisnik = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panelSredina = new System.Windows.Forms.Panel();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.lblGrupe = new System.Windows.Forms.Label();
            this.lstGrupe = new System.Windows.Forms.ListBox();
            this.panelPoruka = new System.Windows.Forms.Panel();
            this.btnPitanje = new System.Windows.Forms.Button();
            this.btnFajl = new System.Windows.Forms.Button();
            this.btnSlika = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.txtNovaPoruka = new System.Windows.Forms.TextBox();
            this.panelDesno = new System.Windows.Forms.Panel();
            this.lstMaterijali = new System.Windows.Forms.ListBox();
            this.lblMaterijali = new System.Windows.Forms.Label();
            this.lstClanovi = new System.Windows.Forms.ListBox();
            this.lblClanovi = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelLevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfil)).BeginInit();
            this.panelGore.SuspendLayout();
            this.panelSredina.SuspendLayout();
            this.panelPoruka.SuspendLayout();
            this.panelDesno.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLevo
            // 
            this.panelLevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelLevo.Controls.Add(this.btnOdjava);
            this.panelLevo.Controls.Add(this.btnMojProfil);
            this.panelLevo.Controls.Add(this.btnObavestenja);
            this.panelLevo.Controls.Add(this.btnPitanja);
            this.panelLevo.Controls.Add(this.btnMaterijali);
            this.panelLevo.Controls.Add(this.btnPrivatnePoruke);
            this.panelLevo.Controls.Add(this.btnMojeGrupe);
            this.panelLevo.Controls.Add(this.lblOdeljenje);
            this.panelLevo.Controls.Add(this.lblImePrezime);
            this.panelLevo.Controls.Add(this.picProfil);
            this.panelLevo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLevo.Location = new System.Drawing.Point(0, 0);
            this.panelLevo.Name = "panelLevo";
            this.panelLevo.Size = new System.Drawing.Size(251, 768);
            this.panelLevo.TabIndex = 0;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.Firebrick;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.ForeColor = System.Drawing.Color.White;
            this.btnOdjava.Location = new System.Drawing.Point(23, 661);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(206, 43);
            this.btnOdjava.TabIndex = 9;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            // 
            // btnMojProfil
            // 
            this.btnMojProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnMojProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMojProfil.ForeColor = System.Drawing.Color.White;
            this.btnMojProfil.Location = new System.Drawing.Point(23, 501);
            this.btnMojProfil.Name = "btnMojProfil";
            this.btnMojProfil.Size = new System.Drawing.Size(206, 43);
            this.btnMojProfil.TabIndex = 8;
            this.btnMojProfil.Text = "Moj profil";
            this.btnMojProfil.UseVisualStyleBackColor = false;
            // 
            // btnObavestenja
            // 
            this.btnObavestenja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnObavestenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObavestenja.ForeColor = System.Drawing.Color.White;
            this.btnObavestenja.Location = new System.Drawing.Point(23, 448);
            this.btnObavestenja.Name = "btnObavestenja";
            this.btnObavestenja.Size = new System.Drawing.Size(206, 43);
            this.btnObavestenja.TabIndex = 7;
            this.btnObavestenja.Text = "Obaveštenja";
            this.btnObavestenja.UseVisualStyleBackColor = false;
            // 
            // btnPitanja
            // 
            this.btnPitanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnPitanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPitanja.ForeColor = System.Drawing.Color.White;
            this.btnPitanja.Location = new System.Drawing.Point(23, 395);
            this.btnPitanja.Name = "btnPitanja";
            this.btnPitanja.Size = new System.Drawing.Size(206, 43);
            this.btnPitanja.TabIndex = 6;
            this.btnPitanja.Text = "Pitanja";
            this.btnPitanja.UseVisualStyleBackColor = false;
            // 
            // btnMaterijali
            // 
            this.btnMaterijali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnMaterijali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterijali.ForeColor = System.Drawing.Color.White;
            this.btnMaterijali.Location = new System.Drawing.Point(23, 341);
            this.btnMaterijali.Name = "btnMaterijali";
            this.btnMaterijali.Size = new System.Drawing.Size(206, 43);
            this.btnMaterijali.TabIndex = 5;
            this.btnMaterijali.Text = "Materijali";
            this.btnMaterijali.UseVisualStyleBackColor = false;
            // 
            // btnPrivatnePoruke
            // 
            this.btnPrivatnePoruke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnPrivatnePoruke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivatnePoruke.ForeColor = System.Drawing.Color.White;
            this.btnPrivatnePoruke.Location = new System.Drawing.Point(23, 288);
            this.btnPrivatnePoruke.Name = "btnPrivatnePoruke";
            this.btnPrivatnePoruke.Size = new System.Drawing.Size(206, 43);
            this.btnPrivatnePoruke.TabIndex = 4;
            this.btnPrivatnePoruke.Text = "Privatne poruke";
            this.btnPrivatnePoruke.UseVisualStyleBackColor = false;
            // 
            // btnMojeGrupe
            // 
            this.btnMojeGrupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnMojeGrupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMojeGrupe.ForeColor = System.Drawing.Color.White;
            this.btnMojeGrupe.Location = new System.Drawing.Point(23, 235);
            this.btnMojeGrupe.Name = "btnMojeGrupe";
            this.btnMojeGrupe.Size = new System.Drawing.Size(206, 43);
            this.btnMojeGrupe.TabIndex = 3;
            this.btnMojeGrupe.Text = "Moje grupe";
            this.btnMojeGrupe.UseVisualStyleBackColor = false;
            // 
            // lblOdeljenje
            // 
            this.lblOdeljenje.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOdeljenje.Location = new System.Drawing.Point(14, 173);
            this.lblOdeljenje.Name = "lblOdeljenje";
            this.lblOdeljenje.Size = new System.Drawing.Size(224, 25);
            this.lblOdeljenje.TabIndex = 2;
            this.lblOdeljenje.Text = "III-2";
            this.lblOdeljenje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.ForeColor = System.Drawing.Color.White;
            this.lblImePrezime.Location = new System.Drawing.Point(14, 145);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(224, 25);
            this.lblImePrezime.TabIndex = 1;
            this.lblImePrezime.Text = "Marko Marković";
            this.lblImePrezime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picProfil
            // 
            this.picProfil.BackColor = System.Drawing.Color.White;
            this.picProfil.Location = new System.Drawing.Point(66, 23);
            this.picProfil.Name = "picProfil";
            this.picProfil.Size = new System.Drawing.Size(114, 107);
            this.picProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfil.TabIndex = 0;
            this.picProfil.TabStop = false;
            // 
            // panelGore
            // 
            this.panelGore.BackColor = System.Drawing.Color.White;
            this.panelGore.Controls.Add(this.lblAktivnaGrupa);
            this.panelGore.Controls.Add(this.txtPretraga);
            this.panelGore.Controls.Add(this.lblUlogovaniKorisnik);
            this.panelGore.Controls.Add(this.lblNaslov);
            this.panelGore.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGore.Location = new System.Drawing.Point(251, 0);
            this.panelGore.Name = "panelGore";
            this.panelGore.Size = new System.Drawing.Size(1235, 85);
            this.panelGore.TabIndex = 1;
            // 
            // lblAktivnaGrupa
            // 
            this.lblAktivnaGrupa.AutoSize = true;
            this.lblAktivnaGrupa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAktivnaGrupa.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblAktivnaGrupa.Location = new System.Drawing.Point(343, 30);
            this.lblAktivnaGrupa.Name = "lblAktivnaGrupa";
            this.lblAktivnaGrupa.Size = new System.Drawing.Size(242, 25);
            this.lblAktivnaGrupa.TabIndex = 3;
            this.lblAktivnaGrupa.Text = "Aktivna grupa: III-2 Opšte";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPretraga.Location = new System.Drawing.Point(834, 27);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(251, 30);
            this.txtPretraga.TabIndex = 2;
            // 
            // lblUlogovaniKorisnik
            // 
            this.lblUlogovaniKorisnik.AutoSize = true;
            this.lblUlogovaniKorisnik.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUlogovaniKorisnik.Location = new System.Drawing.Point(25, 51);
            this.lblUlogovaniKorisnik.Name = "lblUlogovaniKorisnik";
            this.lblUlogovaniKorisnik.Size = new System.Drawing.Size(207, 23);
            this.lblUlogovaniKorisnik.TabIndex = 1;
            this.lblUlogovaniKorisnik.Text = "Ulogovan: marko.m / III-2";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNaslov.Location = new System.Drawing.Point(23, 13);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(269, 37);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Učenički dashboard";
            // 
            // panelSredina
            // 
            this.panelSredina.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSredina.Controls.Add(this.rtbChat);
            this.panelSredina.Controls.Add(this.lblGrupe);
            this.panelSredina.Controls.Add(this.lstGrupe);
            this.panelSredina.Controls.Add(this.panelPoruka);
            this.panelSredina.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSredina.Location = new System.Drawing.Point(251, 85);
            this.panelSredina.Name = "panelSredina";
            this.panelSredina.Size = new System.Drawing.Size(869, 683);
            this.panelSredina.TabIndex = 2;
            // 
            // rtbChat
            // 
            this.rtbChat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbChat.Location = new System.Drawing.Point(251, 45);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.Size = new System.Drawing.Size(594, 584);
            this.rtbChat.TabIndex = 2;
            this.rtbChat.Text = "";
            // 
            // lblGrupe
            // 
            this.lblGrupe.AutoSize = true;
            this.lblGrupe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGrupe.Location = new System.Drawing.Point(21, 16);
            this.lblGrupe.Name = "lblGrupe";
            this.lblGrupe.Size = new System.Drawing.Size(103, 23);
            this.lblGrupe.TabIndex = 0;
            this.lblGrupe.Text = "Moje grupe";
            // 
            // lstGrupe
            // 
            this.lstGrupe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstGrupe.FormattingEnabled = true;
            this.lstGrupe.ItemHeight = 23;
            this.lstGrupe.Items.AddRange(new object[] {
            "III-2 Opšte",
            "Matematika",
            "Informatika",
            "Engleski jezik"});
            this.lstGrupe.Location = new System.Drawing.Point(25, 45);
            this.lstGrupe.Name = "lstGrupe";
            this.lstGrupe.Size = new System.Drawing.Size(205, 579);
            this.lstGrupe.TabIndex = 1;
            // 
            // panelPoruka
            // 
            this.panelPoruka.BackColor = System.Drawing.Color.White;
            this.panelPoruka.Controls.Add(this.btnPitanje);
            this.panelPoruka.Controls.Add(this.btnFajl);
            this.panelPoruka.Controls.Add(this.btnSlika);
            this.panelPoruka.Controls.Add(this.btnPosalji);
            this.panelPoruka.Controls.Add(this.txtNovaPoruka);
            this.panelPoruka.Location = new System.Drawing.Point(25, 636);
            this.panelPoruka.Name = "panelPoruka";
            this.panelPoruka.Size = new System.Drawing.Size(821, 43);
            this.panelPoruka.TabIndex = 3;
            // 
            // btnPitanje
            // 
            this.btnPitanje.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPitanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPitanje.ForeColor = System.Drawing.Color.White;
            this.btnPitanje.Location = new System.Drawing.Point(617, 6);
            this.btnPitanje.Name = "btnPitanje";
            this.btnPitanje.Size = new System.Drawing.Size(80, 30);
            this.btnPitanje.TabIndex = 4;
            this.btnPitanje.Text = "Pitanje";
            this.btnPitanje.UseVisualStyleBackColor = false;
            // 
            // btnFajl
            // 
            this.btnFajl.BackColor = System.Drawing.Color.SlateBlue;
            this.btnFajl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFajl.ForeColor = System.Drawing.Color.White;
            this.btnFajl.Location = new System.Drawing.Point(526, 6);
            this.btnFajl.Name = "btnFajl";
            this.btnFajl.Size = new System.Drawing.Size(80, 30);
            this.btnFajl.TabIndex = 3;
            this.btnFajl.Text = "Fajl";
            this.btnFajl.UseVisualStyleBackColor = false;
            // 
            // btnSlika
            // 
            this.btnSlika.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSlika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlika.ForeColor = System.Drawing.Color.White;
            this.btnSlika.Location = new System.Drawing.Point(434, 6);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(80, 30);
            this.btnSlika.TabIndex = 2;
            this.btnSlika.Text = "Slika";
            this.btnSlika.UseVisualStyleBackColor = false;
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPosalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosalji.ForeColor = System.Drawing.Color.White;
            this.btnPosalji.Location = new System.Drawing.Point(710, 6);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(96, 30);
            this.btnPosalji.TabIndex = 1;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            // 
            // txtNovaPoruka
            // 
            this.txtNovaPoruka.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNovaPoruka.Location = new System.Drawing.Point(11, 9);
            this.txtNovaPoruka.Name = "txtNovaPoruka";
            this.txtNovaPoruka.Size = new System.Drawing.Size(411, 30);
            this.txtNovaPoruka.TabIndex = 0;
            // 
            // panelDesno
            // 
            this.panelDesno.BackColor = System.Drawing.Color.AliceBlue;
            this.panelDesno.Controls.Add(this.lstMaterijali);
            this.panelDesno.Controls.Add(this.lblMaterijali);
            this.panelDesno.Controls.Add(this.lstClanovi);
            this.panelDesno.Controls.Add(this.lblClanovi);
            this.panelDesno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesno.Location = new System.Drawing.Point(1120, 85);
            this.panelDesno.Name = "panelDesno";
            this.panelDesno.Size = new System.Drawing.Size(366, 683);
            this.panelDesno.TabIndex = 3;
            // 
            // lstMaterijali
            // 
            this.lstMaterijali.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstMaterijali.FormattingEnabled = true;
            this.lstMaterijali.ItemHeight = 23;
            this.lstMaterijali.Items.AddRange(new object[] {
            "Matematika_zadaci.pdf",
            "Lekcija_3.docx",
            "Tabela.jpg",
            "Prezentacija.pptx"});
            this.lstMaterijali.Location = new System.Drawing.Point(27, 359);
            this.lstMaterijali.Name = "lstMaterijali";
            this.lstMaterijali.Size = new System.Drawing.Size(308, 257);
            this.lstMaterijali.TabIndex = 3;
            // 
            // lblMaterijali
            // 
            this.lblMaterijali.AutoSize = true;
            this.lblMaterijali.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaterijali.Location = new System.Drawing.Point(23, 331);
            this.lblMaterijali.Name = "lblMaterijali";
            this.lblMaterijali.Size = new System.Drawing.Size(155, 23);
            this.lblMaterijali.TabIndex = 2;
            this.lblMaterijali.Text = "Materijali / fajlovi";
            // 
            // lstClanovi
            // 
            this.lstClanovi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstClanovi.FormattingEnabled = true;
            this.lstClanovi.ItemHeight = 23;
            this.lstClanovi.Items.AddRange(new object[] {
            "Marko Marković",
            "Jovana Jovanović",
            "Petar Petrović",
            "Profesor Marko Nikolić"});
            this.lstClanovi.Location = new System.Drawing.Point(27, 45);
            this.lstClanovi.Name = "lstClanovi";
            this.lstClanovi.Size = new System.Drawing.Size(308, 257);
            this.lstClanovi.TabIndex = 1;
            // 
            // lblClanovi
            // 
            this.lblClanovi.AutoSize = true;
            this.lblClanovi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblClanovi.Location = new System.Drawing.Point(23, 16);
            this.lblClanovi.Name = "lblClanovi";
            this.lblClanovi.Size = new System.Drawing.Size(122, 23);
            this.lblClanovi.TabIndex = 0;
            this.lblClanovi.Text = "Članovi grupe";
            // 
            // UcenikDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1486, 768);
            this.Controls.Add(this.panelDesno);
            this.Controls.Add(this.panelSredina);
            this.Controls.Add(this.panelGore);
            this.Controls.Add(this.panelLevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UcenikDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Učenik Dashboard";
            this.panelLevo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfil)).EndInit();
            this.panelGore.ResumeLayout(false);
            this.panelGore.PerformLayout();
            this.panelSredina.ResumeLayout(false);
            this.panelSredina.PerformLayout();
            this.panelPoruka.ResumeLayout(false);
            this.panelPoruka.PerformLayout();
            this.panelDesno.ResumeLayout(false);
            this.panelDesno.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
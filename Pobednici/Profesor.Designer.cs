using System.Windows.Forms;

namespace Pobednici
{
    partial class Profesor
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelActions;

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblProfesorIme;
        private System.Windows.Forms.Label lblTrenutnaGrupa;

        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMojeGrupe;
        private System.Windows.Forms.Button btnObavestenja;
        private System.Windows.Forms.Button btnZadaci;
        private System.Windows.Forms.Button btnDiskusije;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnPrijave;

        private System.Windows.Forms.Button btnKreirajGrupu;
        private System.Windows.Forms.Button btnDodajZadatak;
        private System.Windows.Forms.Button btnObjaviObavestenje;
        private System.Windows.Forms.Button btnPinuj;
        private System.Windows.Forms.Button btnZakljucaj;
        private System.Windows.Forms.Button btnObrisiSadrzaj;
        private System.Windows.Forms.Button btnPosaljiObjavu;

        private System.Windows.Forms.ListBox listBoxPoruke;
        private System.Windows.Forms.TextBox txtNovaObjava;
        private System.Windows.Forms.DataGridView dataGridInfo;

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
            this.lblProfesorIme = new System.Windows.Forms.Label();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPrijave = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnDiskusije = new System.Windows.Forms.Button();
            this.btnZadaci = new System.Windows.Forms.Button();
            this.btnObavestenja = new System.Windows.Forms.Button();
            this.btnMojeGrupe = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dataGridInfo = new System.Windows.Forms.DataGridView();
            this.btnPosaljiObjavu = new System.Windows.Forms.Button();
            this.txtNovaObjava = new System.Windows.Forms.TextBox();
            this.listBoxPoruke = new System.Windows.Forms.ListBox();
            this.lblTrenutnaGrupa = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnObrisiSadrzaj = new System.Windows.Forms.Button();
            this.btnZakljucaj = new System.Windows.Forms.Button();
            this.btnPinuj = new System.Windows.Forms.Button();
            this.btnObjaviObavestenje = new System.Windows.Forms.Button();
            this.btnDodajZadatak = new System.Windows.Forms.Button();
            this.btnKreirajGrupu = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelTop.Controls.Add(this.lblNaslov);
            this.panelTop.Controls.Add(this.lblProfesorIme);
            this.panelTop.Controls.Add(this.btnProfil);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 70);
            this.panelTop.TabIndex = 0;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(20, 20);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(344, 37);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Profesor - Digitalna škola";
            // 
            // lblProfesorIme
            // 
            this.lblProfesorIme.AutoSize = true;
            this.lblProfesorIme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProfesorIme.ForeColor = System.Drawing.Color.White;
            this.lblProfesorIme.Location = new System.Drawing.Point(850, 25);
            this.lblProfesorIme.Name = "lblProfesorIme";
            this.lblProfesorIme.Size = new System.Drawing.Size(186, 23);
            this.lblProfesorIme.TabIndex = 1;
            this.lblProfesorIme.Text = "Profesor: Petar Petrović";
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.ForeColor = System.Drawing.Color.White;
            this.btnProfil.Location = new System.Drawing.Point(1015, 18);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(85, 35);
            this.btnProfil.TabIndex = 2;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1110, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 35);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Odjava";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelMenu.Controls.Add(this.btnPrijave);
            this.panelMenu.Controls.Add(this.btnStatistika);
            this.panelMenu.Controls.Add(this.btnDiskusije);
            this.panelMenu.Controls.Add(this.btnZadaci);
            this.panelMenu.Controls.Add(this.btnObavestenja);
            this.panelMenu.Controls.Add(this.btnMojeGrupe);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 70);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 680);
            this.panelMenu.TabIndex = 1;
            // 
            // btnPrijave
            // 
            this.btnPrijave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPrijave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrijave.ForeColor = System.Drawing.Color.White;
            this.btnPrijave.Location = new System.Drawing.Point(20, 370);
            this.btnPrijave.Name = "btnPrijave";
            this.btnPrijave.Size = new System.Drawing.Size(160, 50);
            this.btnPrijave.TabIndex = 5;
            this.btnPrijave.Text = "Prijave";
            this.btnPrijave.UseVisualStyleBackColor = false;
            // 
            // btnStatistika
            // 
            this.btnStatistika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistika.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStatistika.ForeColor = System.Drawing.Color.White;
            this.btnStatistika.Location = new System.Drawing.Point(20, 300);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(160, 50);
            this.btnStatistika.TabIndex = 4;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = false;
            // 
            // btnDiskusije
            // 
            this.btnDiskusije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnDiskusije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiskusije.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDiskusije.ForeColor = System.Drawing.Color.White;
            this.btnDiskusije.Location = new System.Drawing.Point(20, 230);
            this.btnDiskusije.Name = "btnDiskusije";
            this.btnDiskusije.Size = new System.Drawing.Size(160, 50);
            this.btnDiskusije.TabIndex = 3;
            this.btnDiskusije.Text = "Diskusije";
            this.btnDiskusije.UseVisualStyleBackColor = false;
            // 
            // btnZadaci
            // 
            this.btnZadaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnZadaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZadaci.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnZadaci.ForeColor = System.Drawing.Color.White;
            this.btnZadaci.Location = new System.Drawing.Point(20, 160);
            this.btnZadaci.Name = "btnZadaci";
            this.btnZadaci.Size = new System.Drawing.Size(160, 50);
            this.btnZadaci.TabIndex = 2;
            this.btnZadaci.Text = "Zadaci";
            this.btnZadaci.UseVisualStyleBackColor = false;
            // 
            // btnObavestenja
            // 
            this.btnObavestenja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnObavestenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObavestenja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnObavestenja.ForeColor = System.Drawing.Color.White;
            this.btnObavestenja.Location = new System.Drawing.Point(20, 90);
            this.btnObavestenja.Name = "btnObavestenja";
            this.btnObavestenja.Size = new System.Drawing.Size(160, 50);
            this.btnObavestenja.TabIndex = 1;
            this.btnObavestenja.Text = "Obaveštenja";
            this.btnObavestenja.UseVisualStyleBackColor = false;
            // 
            // btnMojeGrupe
            // 
            this.btnMojeGrupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnMojeGrupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMojeGrupe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMojeGrupe.ForeColor = System.Drawing.Color.White;
            this.btnMojeGrupe.Location = new System.Drawing.Point(20, 20);
            this.btnMojeGrupe.Name = "btnMojeGrupe";
            this.btnMojeGrupe.Size = new System.Drawing.Size(160, 50);
            this.btnMojeGrupe.TabIndex = 0;
            this.btnMojeGrupe.Text = "Moje grupe";
            this.btnMojeGrupe.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.dataGridInfo);
            this.panelMain.Controls.Add(this.btnPosaljiObjavu);
            this.panelMain.Controls.Add(this.txtNovaObjava);
            this.panelMain.Controls.Add(this.listBoxPoruke);
            this.panelMain.Controls.Add(this.lblTrenutnaGrupa);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(880, 680);
            this.panelMain.TabIndex = 3;
            // 
            // dataGridInfo
            // 
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.Location = new System.Drawing.Point(25, 470);
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.RowHeadersWidth = 51;
            this.dataGridInfo.Size = new System.Drawing.Size(820, 180);
            this.dataGridInfo.TabIndex = 4;
            // 
            // btnPosaljiObjavu
            // 
            this.btnPosaljiObjavu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPosaljiObjavu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosaljiObjavu.ForeColor = System.Drawing.Color.White;
            this.btnPosaljiObjavu.Location = new System.Drawing.Point(430, 410);
            this.btnPosaljiObjavu.Name = "btnPosaljiObjavu";
            this.btnPosaljiObjavu.Size = new System.Drawing.Size(115, 35);
            this.btnPosaljiObjavu.TabIndex = 3;
            this.btnPosaljiObjavu.Text = "Pošalji";
            this.btnPosaljiObjavu.UseVisualStyleBackColor = false;
            // 
            // txtNovaObjava
            // 
            this.txtNovaObjava.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNovaObjava.Location = new System.Drawing.Point(25, 320);
            this.txtNovaObjava.Multiline = true;
            this.txtNovaObjava.Name = "txtNovaObjava";
            this.txtNovaObjava.Size = new System.Drawing.Size(520, 80);
            this.txtNovaObjava.TabIndex = 2;
            // 
            // listBoxPoruke
            // 
            this.listBoxPoruke.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxPoruke.FormattingEnabled = true;
            this.listBoxPoruke.ItemHeight = 23;
            this.listBoxPoruke.Location = new System.Drawing.Point(25, 60);
            this.listBoxPoruke.Name = "listBoxPoruke";
            this.listBoxPoruke.Size = new System.Drawing.Size(520, 234);
            this.listBoxPoruke.TabIndex = 1;
            // 
            // lblTrenutnaGrupa
            // 
            this.lblTrenutnaGrupa.AutoSize = true;
            this.lblTrenutnaGrupa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTrenutnaGrupa.Location = new System.Drawing.Point(20, 20);
            this.lblTrenutnaGrupa.Name = "lblTrenutnaGrupa";
            this.lblTrenutnaGrupa.Size = new System.Drawing.Size(297, 32);
            this.lblTrenutnaGrupa.TabIndex = 0;
            this.lblTrenutnaGrupa.Text = "Aktivna grupa: IV-2 MAT";
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.Gainsboro;
            this.panelActions.Controls.Add(this.btnObrisiSadrzaj);
            this.panelActions.Controls.Add(this.btnZakljucaj);
            this.panelActions.Controls.Add(this.btnPinuj);
            this.panelActions.Controls.Add(this.btnObjaviObavestenje);
            this.panelActions.Controls.Add(this.btnDodajZadatak);
            this.panelActions.Controls.Add(this.btnKreirajGrupu);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelActions.Location = new System.Drawing.Point(1080, 70);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(220, 680);
            this.panelActions.TabIndex = 2;
            // 
            // btnObrisiSadrzaj
            // 
            this.btnObrisiSadrzaj.BackColor = System.Drawing.Color.SteelBlue;
            this.btnObrisiSadrzaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiSadrzaj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnObrisiSadrzaj.ForeColor = System.Drawing.Color.White;
            this.btnObrisiSadrzaj.Location = new System.Drawing.Point(20, 370);
            this.btnObrisiSadrzaj.Name = "btnObrisiSadrzaj";
            this.btnObrisiSadrzaj.Size = new System.Drawing.Size(180, 50);
            this.btnObrisiSadrzaj.TabIndex = 5;
            this.btnObrisiSadrzaj.Text = "Obriši sadržaj";
            this.btnObrisiSadrzaj.UseVisualStyleBackColor = false;
            // 
            // btnZakljucaj
            // 
            this.btnZakljucaj.BackColor = System.Drawing.Color.SteelBlue;
            this.btnZakljucaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZakljucaj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnZakljucaj.ForeColor = System.Drawing.Color.White;
            this.btnZakljucaj.Location = new System.Drawing.Point(20, 300);
            this.btnZakljucaj.Name = "btnZakljucaj";
            this.btnZakljucaj.Size = new System.Drawing.Size(180, 50);
            this.btnZakljucaj.TabIndex = 4;
            this.btnZakljucaj.Text = "Zaključaj diskusiju";
            this.btnZakljucaj.UseVisualStyleBackColor = false;
            // 
            // btnPinuj
            // 
            this.btnPinuj.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPinuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPinuj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPinuj.ForeColor = System.Drawing.Color.White;
            this.btnPinuj.Location = new System.Drawing.Point(20, 230);
            this.btnPinuj.Name = "btnPinuj";
            this.btnPinuj.Size = new System.Drawing.Size(180, 50);
            this.btnPinuj.TabIndex = 3;
            this.btnPinuj.Text = "Pinuj poruku";
            this.btnPinuj.UseVisualStyleBackColor = false;
            // 
            // btnObjaviObavestenje
            // 
            this.btnObjaviObavestenje.BackColor = System.Drawing.Color.SteelBlue;
            this.btnObjaviObavestenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObjaviObavestenje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnObjaviObavestenje.ForeColor = System.Drawing.Color.White;
            this.btnObjaviObavestenje.Location = new System.Drawing.Point(20, 160);
            this.btnObjaviObavestenje.Name = "btnObjaviObavestenje";
            this.btnObjaviObavestenje.Size = new System.Drawing.Size(180, 50);
            this.btnObjaviObavestenje.TabIndex = 2;
            this.btnObjaviObavestenje.Text = "Objavi obaveštenje";
            this.btnObjaviObavestenje.UseVisualStyleBackColor = false;
            // 
            // btnDodajZadatak
            // 
            this.btnDodajZadatak.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDodajZadatak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajZadatak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDodajZadatak.ForeColor = System.Drawing.Color.White;
            this.btnDodajZadatak.Location = new System.Drawing.Point(20, 90);
            this.btnDodajZadatak.Name = "btnDodajZadatak";
            this.btnDodajZadatak.Size = new System.Drawing.Size(180, 50);
            this.btnDodajZadatak.TabIndex = 1;
            this.btnDodajZadatak.Text = "Dodaj zadatak";
            this.btnDodajZadatak.UseVisualStyleBackColor = false;
            // 
            // btnKreirajGrupu
            // 
            this.btnKreirajGrupu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKreirajGrupu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajGrupu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKreirajGrupu.ForeColor = System.Drawing.Color.White;
            this.btnKreirajGrupu.Location = new System.Drawing.Point(20, 20);
            this.btnKreirajGrupu.Name = "btnKreirajGrupu";
            this.btnKreirajGrupu.Size = new System.Drawing.Size(180, 50);
            this.btnKreirajGrupu.TabIndex = 0;
            this.btnKreirajGrupu.Text = "Kreiraj grupu";
            this.btnKreirajGrupu.UseVisualStyleBackColor = false;
            // 
            // Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.Name = "Profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesor";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
namespace Pobednici
{
    partial class Registracija
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblPoruka;

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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUloga = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.lblPoruka);
            this.panelMain.Controls.Add(this.btnSacuvaj);
            this.panelMain.Controls.Add(this.cmbUloga);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Controls.Add(this.txtUsername);
            this.panelMain.Controls.Add(this.txtPrezime);
            this.panelMain.Controls.Add(this.txtIme);
            this.panelMain.Controls.Add(this.lblUloga);
            this.panelMain.Controls.Add(this.lblPassword);
            this.panelMain.Controls.Add(this.lblUsername);
            this.panelMain.Controls.Add(this.lblPrezime);
            this.panelMain.Controls.Add(this.lblIme);
            this.panelMain.Controls.Add(this.lblNaslov);
            this.panelMain.Location = new System.Drawing.Point(170, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(450, 390);
            this.panelMain.TabIndex = 0;

            // lblNaslov
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.Location = new System.Drawing.Point(127, 20);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(176, 32);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Registracija";

            // lblIme
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(43, 80);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(29, 16);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";

            // lblPrezime
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(43, 125);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(55, 16);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime";

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(43, 170);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 16);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Korisničko ime";

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(43, 215);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(50, 16);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Lozinka";

            // lblUloga
            this.lblUloga.AutoSize = true;
            this.lblUloga.Location = new System.Drawing.Point(43, 260);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(42, 16);
            this.lblUloga.TabIndex = 5;
            this.lblUloga.Text = "Uloga";

            // txtIme
            this.txtIme.Location = new System.Drawing.Point(160, 77);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(230, 22);
            this.txtIme.TabIndex = 6;

            // txtPrezime
            this.txtPrezime.Location = new System.Drawing.Point(160, 122);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(230, 22);
            this.txtPrezime.TabIndex = 7;

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(160, 167);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(230, 22);
            this.txtUsername.TabIndex = 8;

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(160, 212);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 22);
            this.txtPassword.TabIndex = 9;

            // cmbUloga
            this.cmbUloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Items.AddRange(new object[] {
            "Ucenik",
            "Profesor",
            "Admin",
            "SuperAdmin"});
            this.cmbUloga.Location = new System.Drawing.Point(160, 257);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(230, 24);
            this.cmbUloga.TabIndex = 10;

            // btnSacuvaj
            this.btnSacuvaj.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(160, 307);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(150, 36);
            this.btnSacuvaj.TabIndex = 11;
            this.btnSacuvaj.Text = "Registruj se";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);

            // lblPoruka
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPoruka.Location = new System.Drawing.Point(157, 355);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 16);
            this.lblPoruka.TabIndex = 12;

            // Registracija
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "Registracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
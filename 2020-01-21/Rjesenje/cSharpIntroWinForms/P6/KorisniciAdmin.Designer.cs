namespace cSharpIntroWinForms
{
    partial class KorisniciAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblProsjek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Spol,
            this.KorisnickoIme,
            this.Admin,
            this.Polozeni});
            this.dgvKorisnici.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvKorisnici.Location = new System.Drawing.Point(16, 50);
            this.dgvKorisnici.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(888, 304);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellContentClick);
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.MinimumWidth = 6;
            this.Spol.Name = "Spol";
            this.Spol.Width = 125;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.MinimumWidth = 6;
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Width = 125;
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Admin";
            this.Admin.HeaderText = "Admin";
            this.Admin.MinimumWidth = 6;
            this.Admin.Name = "Admin";
            this.Admin.Width = 125;
            // 
            // Polozeni
            // 
            this.Polozeni.HeaderText = "Polozeni";
            this.Polozeni.MinimumWidth = 6;
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.Text = "Polozeni";
            this.Polozeni.UseColumnTextForButtonValue = true;
            this.Polozeni.Width = 125;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(16, 18);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(887, 22);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(37, 363);
            this.lblProsjek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(46, 17);
            this.lblProsjek.TabIndex = 3;
            this.lblProsjek.Text = "label1";
            // 
            // KorisniciAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 394);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dgvKorisnici);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KorisniciAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KorisniciAdmin";
            this.Load += new System.EventHandler(this.KorisniciAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
        private System.Windows.Forms.DataGridViewButtonColumn Polozeni;
    }
}
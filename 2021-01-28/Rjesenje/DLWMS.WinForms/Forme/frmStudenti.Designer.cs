namespace DLWMS.WinForms.Forme
{
    partial class frmStudenti
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
            this.components = new System.ComponentModel.Container();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.Indeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblAktivnost = new System.Windows.Forms.Label();
            this.cmbGodine = new System.Windows.Forms.ComboBox();
            this.cmbAktivnost = new System.Windows.Forms.ComboBox();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.btnPotvrde = new System.Windows.Forms.Button();
            this.lblBrojStudenata = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indeks,
            this.Ime,
            this.Prezime,
            this.Spol,
            this.GodinaStudija,
            this.Aktivan,
            this.Polozeni});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 44);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(682, 269);
            this.dgvStudenti.TabIndex = 0;
            this.dgvStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellContentClick);
            // 
            // Indeks
            // 
            this.Indeks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Indeks.DataPropertyName = "Indeks";
            this.Indeks.HeaderText = "Indeks";
            this.Indeks.Name = "Indeks";
            this.Indeks.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.Name = "GodinaStudija";
            this.GodinaStudija.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            // 
            // Polozeni
            // 
            this.Polozeni.HeaderText = "Polozeni";
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.ReadOnly = true;
            this.Polozeni.Text = "Polozeni";
            this.Polozeni.UseColumnTextForButtonValue = true;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(91, 16);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(193, 20);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(12, 19);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(72, 13);
            this.lblImePrezime.TabIndex = 3;
            this.lblImePrezime.Text = "Ime ili prezime";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Location = new System.Drawing.Point(303, 19);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(41, 13);
            this.lblGodina.TabIndex = 4;
            this.lblGodina.Text = "Godina";
            // 
            // lblAktivnost
            // 
            this.lblAktivnost.AutoSize = true;
            this.lblAktivnost.Location = new System.Drawing.Point(500, 19);
            this.lblAktivnost.Name = "lblAktivnost";
            this.lblAktivnost.Size = new System.Drawing.Size(51, 13);
            this.lblAktivnost.TabIndex = 5;
            this.lblAktivnost.Text = "Aktivnost";
            // 
            // cmbGodine
            // 
            this.cmbGodine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodine.FormattingEnabled = true;
            this.cmbGodine.Location = new System.Drawing.Point(350, 15);
            this.cmbGodine.Name = "cmbGodine";
            this.cmbGodine.Size = new System.Drawing.Size(134, 21);
            this.cmbGodine.TabIndex = 6;
            this.cmbGodine.SelectedIndexChanged += new System.EventHandler(this.cmbGodine_SelectedIndexChanged);
            // 
            // cmbAktivnost
            // 
            this.cmbAktivnost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAktivnost.FormattingEnabled = true;
            this.cmbAktivnost.Location = new System.Drawing.Point(557, 15);
            this.cmbAktivnost.Name = "cmbAktivnost";
            this.cmbAktivnost.Size = new System.Drawing.Size(136, 21);
            this.cmbAktivnost.TabIndex = 7;
            this.cmbAktivnost.SelectedIndexChanged += new System.EventHandler(this.cmbAktivnost_SelectedIndexChanged);
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(12, 333);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(77, 13);
            this.lblProsjek.TabIndex = 8;
            this.lblProsjek.Text = "Prosjek ocjena";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(618, 323);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 9;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // btnPotvrde
            // 
            this.btnPotvrde.Location = new System.Drawing.Point(524, 323);
            this.btnPotvrde.Name = "btnPotvrde";
            this.btnPotvrde.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrde.TabIndex = 10;
            this.btnPotvrde.Text = "Potvrde";
            this.btnPotvrde.UseVisualStyleBackColor = true;
            this.btnPotvrde.Click += new System.EventHandler(this.btnPotvrde_Click);
            // 
            // lblBrojStudenata
            // 
            this.lblBrojStudenata.AutoSize = true;
            this.lblBrojStudenata.Location = new System.Drawing.Point(12, 316);
            this.lblBrojStudenata.Name = "lblBrojStudenata";
            this.lblBrojStudenata.Size = new System.Drawing.Size(75, 13);
            this.lblBrojStudenata.TabIndex = 11;
            this.lblBrojStudenata.Text = "Broj studenata";
            // 
            // frmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 357);
            this.Controls.Add(this.lblBrojStudenata);
            this.Controls.Add(this.btnPotvrde);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.cmbAktivnost);
            this.Controls.Add(this.cmbGodine);
            this.Controls.Add(this.lblAktivnost);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dgvStudenti);
            this.Name = "frmStudenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.frmStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaStudija;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewButtonColumn Polozeni;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblAktivnost;
        private System.Windows.Forms.ComboBox cmbGodine;
        private System.Windows.Forms.ComboBox cmbAktivnost;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPotvrde;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Label lblBrojStudenata;
    }
}
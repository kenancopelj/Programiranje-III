
namespace DLWMS.WinForms.IB200054
{
    partial class frmStudentiIB200054
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.cmbGodineStudija = new System.Windows.Forms.ComboBox();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.Indeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAktivnosti = new System.Windows.Forms.ComboBox();
            this.lblBrojStudenata = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPotvrde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ili prezime:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(119, 17);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(411, 22);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // cmbGodineStudija
            // 
            this.cmbGodineStudija.FormattingEnabled = true;
            this.cmbGodineStudija.Location = new System.Drawing.Point(645, 17);
            this.cmbGodineStudija.Name = "cmbGodineStudija";
            this.cmbGodineStudija.Size = new System.Drawing.Size(121, 24);
            this.cmbGodineStudija.TabIndex = 2;
            this.cmbGodineStudija.SelectedIndexChanged += new System.EventHandler(this.cmbGodineStudija_SelectedIndexChanged);
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
            this.dgvStudenti.Location = new System.Drawing.Point(15, 55);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.Size = new System.Drawing.Size(956, 370);
            this.dgvStudenti.TabIndex = 3;
            // 
            // Indeks
            // 
            this.Indeks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Indeks.DataPropertyName = "Indeks";
            this.Indeks.HeaderText = "Indeks";
            this.Indeks.MinimumWidth = 6;
            this.Indeks.Name = "Indeks";
            this.Indeks.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.MinimumWidth = 6;
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.MinimumWidth = 6;
            this.GodinaStudija.Name = "GodinaStudija";
            this.GodinaStudija.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.MinimumWidth = 6;
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aktivan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Polozeni
            // 
            this.Polozeni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Polozeni.HeaderText = "Polozeni";
            this.Polozeni.MinimumWidth = 6;
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.ReadOnly = true;
            this.Polozeni.Text = "Polozeni";
            this.Polozeni.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(888, 464);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(83, 29);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Godina studija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aktivnosti:";
            // 
            // cmbAktivnosti
            // 
            this.cmbAktivnosti.FormattingEnabled = true;
            this.cmbAktivnosti.Location = new System.Drawing.Point(850, 17);
            this.cmbAktivnosti.Name = "cmbAktivnosti";
            this.cmbAktivnosti.Size = new System.Drawing.Size(121, 24);
            this.cmbAktivnosti.TabIndex = 7;
            this.cmbAktivnosti.SelectedIndexChanged += new System.EventHandler(this.cmbAktivnosti_SelectedIndexChanged);
            // 
            // lblBrojStudenata
            // 
            this.lblBrojStudenata.AutoSize = true;
            this.lblBrojStudenata.Location = new System.Drawing.Point(12, 442);
            this.lblBrojStudenata.Name = "lblBrojStudenata";
            this.lblBrojStudenata.Size = new System.Drawing.Size(104, 17);
            this.lblBrojStudenata.TabIndex = 8;
            this.lblBrojStudenata.Text = "Broj studenata:";
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(12, 476);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(121, 17);
            this.lblProsjek.TabIndex = 9;
            this.lblProsjek.Text = "Prosjecna ocjena:";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnPotvrde
            // 
            this.btnPotvrde.Location = new System.Drawing.Point(476, 464);
            this.btnPotvrde.Name = "btnPotvrde";
            this.btnPotvrde.Size = new System.Drawing.Size(83, 29);
            this.btnPotvrde.TabIndex = 10;
            this.btnPotvrde.Text = "Potvrde";
            this.btnPotvrde.UseVisualStyleBackColor = true;
            this.btnPotvrde.Click += new System.EventHandler(this.btnPotvrde_Click);
            // 
            // frmStudentiIB200054
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 517);
            this.Controls.Add(this.btnPotvrde);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.lblBrojStudenata);
            this.Controls.Add(this.cmbAktivnosti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.cmbGodineStudija);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentiIB200054";
            this.Text = "frmStudentiIB200054";
            this.Load += new System.EventHandler(this.frmStudentiIB200054_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.ComboBox cmbGodineStudija;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAktivnosti;
        private System.Windows.Forms.Label lblBrojStudenata;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaStudija;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewButtonColumn Polozeni;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnPotvrde;
    }
}
namespace cSharpIntroWinForms.Ispit190073
{
    partial class frmPoruke190073
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.btnNovaPoruka = new System.Windows.Forms.Button();
            this.dgvPoruke = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Komunikacija sa:";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.lblKorisnik.Location = new System.Drawing.Point(164, 33);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(154, 25);
            this.lblKorisnik.TabIndex = 3;
            this.lblKorisnik.Text = "Ime Korisnika";
            // 
            // btnNovaPoruka
            // 
            this.btnNovaPoruka.Location = new System.Drawing.Point(539, 36);
            this.btnNovaPoruka.Name = "btnNovaPoruka";
            this.btnNovaPoruka.Size = new System.Drawing.Size(113, 25);
            this.btnNovaPoruka.TabIndex = 4;
            this.btnNovaPoruka.Text = "Nova poruka";
            this.btnNovaPoruka.UseVisualStyleBackColor = true;
            this.btnNovaPoruka.Click += new System.EventHandler(this.btnNovaPoruka_Click);
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Sadrzaj,
            this.Slika,
            this.Brisi});
            this.dgvPoruke.Location = new System.Drawing.Point(26, 67);
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.Size = new System.Drawing.Size(626, 267);
            this.dgvPoruke.TabIndex = 5;
            this.dgvPoruke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoruke_CellContentClick);
            this.dgvPoruke.DoubleClick += new System.EventHandler(this.dgvPoruke_DoubleClick);
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "DatumSlanja";
            this.Datum.FillWeight = 65.65144F;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sadrzaj.DataPropertyName = "Sadrzaj";
            this.Sadrzaj.FillWeight = 203.0457F;
            this.Sadrzaj.HeaderText = "Sadrzaj";
            this.Sadrzaj.Name = "Sadrzaj";
            // 
            // Slika
            // 
            this.Slika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Slika.DataPropertyName = "Slika";
            this.Slika.FillWeight = 65.65144F;
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Brisi
            // 
            this.Brisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brisi.FillWeight = 65.65144F;
            this.Brisi.HeaderText = "Brisi";
            this.Brisi.Name = "Brisi";
            this.Brisi.Text = "Brisi";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(536, 340);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(113, 25);
            this.btnPrintaj.TabIndex = 6;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmPoruke190073
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 372);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dgvPoruke);
            this.Controls.Add(this.btnNovaPoruka);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.label1);
            this.Name = "frmPoruke190073";
            this.Text = "frmPoruke190073";
            this.Load += new System.EventHandler(this.frmPoruke190073_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Button btnNovaPoruka;
        private System.Windows.Forms.DataGridView dgvPoruke;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}
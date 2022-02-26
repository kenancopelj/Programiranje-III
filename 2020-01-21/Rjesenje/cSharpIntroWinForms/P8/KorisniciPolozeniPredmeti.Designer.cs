namespace cSharpIntroWinForms.P8
{
    partial class KorisniciPolozeniPredmeti
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
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.dtpDatumPolaganja = new System.Windows.Forms.DateTimePicker();
            this.btnDodajPolozeni = new System.Windows.Forms.Button();
            this.dgvPolozeniPredmeti = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbOcjene = new System.Windows.Forms.ComboBox();
            this.cbUcitajNepolozene = new System.Windows.Forms.CheckBox();
            this.btnASYNC = new System.Windows.Forms.Button();
            this.btnPrintajUvjerenje = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(16, 11);
            this.cmbPredmeti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(292, 24);
            this.cmbPredmeti.TabIndex = 0;
            // 
            // dtpDatumPolaganja
            // 
            this.dtpDatumPolaganja.Location = new System.Drawing.Point(459, 12);
            this.dtpDatumPolaganja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            this.dtpDatumPolaganja.Size = new System.Drawing.Size(265, 22);
            this.dtpDatumPolaganja.TabIndex = 2;
            // 
            // btnDodajPolozeni
            // 
            this.btnDodajPolozeni.Location = new System.Drawing.Point(735, 11);
            this.btnDodajPolozeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajPolozeni.Name = "btnDodajPolozeni";
            this.btnDodajPolozeni.Size = new System.Drawing.Size(140, 28);
            this.btnDodajPolozeni.TabIndex = 3;
            this.btnDodajPolozeni.Text = "Dodaj";
            this.btnDodajPolozeni.UseVisualStyleBackColor = true;
            this.btnDodajPolozeni.Click += new System.EventHandler(this.btnDodajPolozeni_Click);
            // 
            // dgvPolozeniPredmeti
            // 
            this.dgvPolozeniPredmeti.AllowUserToAddRows = false;
            this.dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            this.dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Ocjena,
            this.Datum});
            this.dgvPolozeniPredmeti.Location = new System.Drawing.Point(16, 87);
            this.dgvPolozeniPredmeti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            this.dgvPolozeniPredmeti.ReadOnly = true;
            this.dgvPolozeniPredmeti.RowHeadersWidth = 51;
            this.dgvPolozeniPredmeti.Size = new System.Drawing.Size(859, 249);
            this.dgvPolozeniPredmeti.TabIndex = 4;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 125;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // cmbOcjene
            // 
            this.cmbOcjene.FormattingEnabled = true;
            this.cmbOcjene.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOcjene.Location = new System.Drawing.Point(317, 11);
            this.cmbOcjene.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOcjene.Name = "cmbOcjene";
            this.cmbOcjene.Size = new System.Drawing.Size(132, 24);
            this.cmbOcjene.TabIndex = 5;
            // 
            // cbUcitajNepolozene
            // 
            this.cbUcitajNepolozene.AutoSize = true;
            this.cbUcitajNepolozene.Location = new System.Drawing.Point(16, 44);
            this.cbUcitajNepolozene.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUcitajNepolozene.Name = "cbUcitajNepolozene";
            this.cbUcitajNepolozene.Size = new System.Drawing.Size(143, 21);
            this.cbUcitajNepolozene.TabIndex = 6;
            this.cbUcitajNepolozene.Text = "Učitaj nepoložene";
            this.cbUcitajNepolozene.UseVisualStyleBackColor = true;
            this.cbUcitajNepolozene.CheckedChanged += new System.EventHandler(this.cbUcitajNepolozene_CheckedChanged);
            // 
            // btnASYNC
            // 
            this.btnASYNC.Location = new System.Drawing.Point(16, 367);
            this.btnASYNC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnASYNC.Name = "btnASYNC";
            this.btnASYNC.Size = new System.Drawing.Size(100, 28);
            this.btnASYNC.TabIndex = 7;
            this.btnASYNC.Text = "Run ASYNC";
            this.btnASYNC.UseVisualStyleBackColor = true;
            this.btnASYNC.Click += new System.EventHandler(this.btnASYNC_Click);
            // 
            // btnPrintajUvjerenje
            // 
            this.btnPrintajUvjerenje.Location = new System.Drawing.Point(667, 367);
            this.btnPrintajUvjerenje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintajUvjerenje.Name = "btnPrintajUvjerenje";
            this.btnPrintajUvjerenje.Size = new System.Drawing.Size(199, 28);
            this.btnPrintajUvjerenje.TabIndex = 7;
            this.btnPrintajUvjerenje.Text = "Printaj uvjerenje";
            this.btnPrintajUvjerenje.UseVisualStyleBackColor = true;
            this.btnPrintajUvjerenje.Click += new System.EventHandler(this.btnPrintajUvjerenje_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(152, 369);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 28);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obrisi predmete";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // KorisniciPolozeniPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 410);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPrintajUvjerenje);
            this.Controls.Add(this.btnASYNC);
            this.Controls.Add(this.cbUcitajNepolozene);
            this.Controls.Add(this.cmbOcjene);
            this.Controls.Add(this.dgvPolozeniPredmeti);
            this.Controls.Add(this.btnDodajPolozeni);
            this.Controls.Add(this.dtpDatumPolaganja);
            this.Controls.Add(this.cmbPredmeti);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KorisniciPolozeniPredmeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Položeni predmeti korisnika";
            this.Load += new System.EventHandler(this.KorisniciPolozeniPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.DateTimePicker dtpDatumPolaganja;
        private System.Windows.Forms.Button btnDodajPolozeni;
        private System.Windows.Forms.DataGridView dgvPolozeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.ComboBox cmbOcjene;
        private System.Windows.Forms.CheckBox cbUcitajNepolozene;
        private System.Windows.Forms.Button btnASYNC;
        private System.Windows.Forms.Button btnPrintajUvjerenje;
        private System.Windows.Forms.Button btnObrisi;
    }
}
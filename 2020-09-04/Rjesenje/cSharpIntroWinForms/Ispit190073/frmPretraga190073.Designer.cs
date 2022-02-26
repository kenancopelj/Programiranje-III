namespace cSharpIntroWinForms.Ispit190073
{
    partial class frmPretraga190073
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPolozeniPredmeti = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poruke = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThreadInput = new System.Windows.Forms.TextBox();
            this.Sumiraj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.Location = new System.Drawing.Point(144, 25);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(543, 26);
            this.txtPretraga.TabIndex = 0;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv predmeta";
            // 
            // dgvPolozeniPredmeti
            // 
            this.dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Poruke});
            this.dgvPolozeniPredmeti.Location = new System.Drawing.Point(16, 57);
            this.dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            this.dgvPolozeniPredmeti.Size = new System.Drawing.Size(671, 270);
            this.dgvPolozeniPredmeti.TabIndex = 2;
            this.dgvPolozeniPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolozeniPredmeti_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "Korisnik";
            this.ImePrezime.HeaderText = "Ime Prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // Poruke
            // 
            this.Poruke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Poruke.HeaderText = "Poruke";
            this.Poruke.Name = "Poruke";
            this.Poruke.Text = "Poruke";
            this.Poruke.UseColumnTextForButtonValue = true;
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblProsjek.Location = new System.Drawing.Point(12, 342);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(210, 20);
            this.lblProsjek.TabIndex = 3;
            this.lblProsjek.Text = "Prosjek prikazanih ocjena: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(405, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Threading";
            // 
            // txtThreadInput
            // 
            this.txtThreadInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThreadInput.Location = new System.Drawing.Point(409, 365);
            this.txtThreadInput.Name = "txtThreadInput";
            this.txtThreadInput.Size = new System.Drawing.Size(164, 26);
            this.txtThreadInput.TabIndex = 5;
            // 
            // btnSumiraj
            // 
            this.Sumiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Sumiraj.Location = new System.Drawing.Point(579, 365);
            this.Sumiraj.Name = "btnSumiraj";
            this.Sumiraj.Size = new System.Drawing.Size(108, 26);
            this.Sumiraj.TabIndex = 6;
            this.Sumiraj.Text = "Sumiraj";
            this.Sumiraj.UseVisualStyleBackColor = true;
            this.Sumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(405, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Suma:";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSuma.Location = new System.Drawing.Point(405, 425);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(0, 20);
            this.lblSuma.TabIndex = 8;
            // 
            // frmPretraga190073
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 469);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sumiraj);
            this.Controls.Add(this.txtThreadInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.dgvPolozeniPredmeti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmPretraga190073";
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretraga190073_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPolozeniPredmeti;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThreadInput;
        private System.Windows.Forms.Button Sumiraj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Poruke;
    }
}
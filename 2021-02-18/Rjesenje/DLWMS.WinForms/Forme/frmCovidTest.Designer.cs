
namespace DLWMS.WinForms.Forme
{
    partial class frmCovidTest
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
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumTesta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRezultat = new System.Windows.Forms.ComboBox();
            this.cbDostavljen = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvTestovi = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NalazDostavljen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblBrojTestova = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojTestova = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestovi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.Location = new System.Drawing.Point(29, 44);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(175, 24);
            this.cmbStudenti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum testiranja:";
            // 
            // dtpDatumTesta
            // 
            this.dtpDatumTesta.Location = new System.Drawing.Point(245, 45);
            this.dtpDatumTesta.Name = "dtpDatumTesta";
            this.dtpDatumTesta.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumTesta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = " Rezultat testa:";
            // 
            // cmbRezultat
            // 
            this.cmbRezultat.FormattingEnabled = true;
            this.cmbRezultat.Location = new System.Drawing.Point(456, 44);
            this.cmbRezultat.Name = "cmbRezultat";
            this.cmbRezultat.Size = new System.Drawing.Size(136, 24);
            this.cmbRezultat.TabIndex = 5;
            // 
            // cbDostavljen
            // 
            this.cbDostavljen.AutoSize = true;
            this.cbDostavljen.Location = new System.Drawing.Point(611, 44);
            this.cbDostavljen.Name = "cbDostavljen";
            this.cbDostavljen.Size = new System.Drawing.Size(134, 21);
            this.cbDostavljen.TabIndex = 6;
            this.cbDostavljen.Text = "Nalaz dostavljen";
            this.cbDostavljen.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(751, 38);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(91, 30);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvTestovi
            // 
            this.dgvTestovi.AllowUserToAddRows = false;
            this.dgvTestovi.AllowUserToDeleteRows = false;
            this.dgvTestovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Rezultat,
            this.NalazDostavljen});
            this.dgvTestovi.Location = new System.Drawing.Point(29, 93);
            this.dgvTestovi.Name = "dgvTestovi";
            this.dgvTestovi.ReadOnly = true;
            this.dgvTestovi.RowHeadersWidth = 51;
            this.dgvTestovi.RowTemplate.Height = 24;
            this.dgvTestovi.Size = new System.Drawing.Size(813, 312);
            this.dgvTestovi.TabIndex = 8;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
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
            // Rezultat
            // 
            this.Rezultat.DataPropertyName = "Rezultat";
            this.Rezultat.HeaderText = "Rezultat";
            this.Rezultat.MinimumWidth = 6;
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.ReadOnly = true;
            this.Rezultat.Width = 125;
            // 
            // NalazDostavljen
            // 
            this.NalazDostavljen.DataPropertyName = "NalazDostavljen";
            this.NalazDostavljen.HeaderText = "Nalaz dostavljen";
            this.NalazDostavljen.MinimumWidth = 6;
            this.NalazDostavljen.Name = "NalazDostavljen";
            this.NalazDostavljen.ReadOnly = true;
            this.NalazDostavljen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NalazDostavljen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NalazDostavljen.Width = 125;
            // 
            // lblBrojTestova
            // 
            this.lblBrojTestova.AutoSize = true;
            this.lblBrojTestova.Location = new System.Drawing.Point(26, 425);
            this.lblBrojTestova.Name = "lblBrojTestova";
            this.lblBrojTestova.Size = new System.Drawing.Size(87, 17);
            this.lblBrojTestova.TabIndex = 9;
            this.lblBrojTestova.Text = "Broj testova:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBrojTestova);
            this.groupBox1.Controls.Add(this.btnGenerisi);
            this.groupBox1.Location = new System.Drawing.Point(195, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 70);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generisanje testova:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Broj testova:";
            // 
            // txtBrojTestova
            // 
            this.txtBrojTestova.Location = new System.Drawing.Point(128, 38);
            this.txtBrojTestova.Name = "txtBrojTestova";
            this.txtBrojTestova.Size = new System.Drawing.Size(112, 22);
            this.txtBrojTestova.TabIndex = 14;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(246, 34);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(81, 30);
            this.btnGenerisi.TabIndex = 13;
            this.btnGenerisi.Text = "Generisi";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Location = new System.Drawing.Point(548, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 70);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brisanje testova:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(6, 34);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(157, 30);
            this.btnObrisi.TabIndex = 12;
            this.btnObrisi.Text = "Obrisi testove";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(741, 459);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(101, 30);
            this.btnPrintaj.TabIndex = 13;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmCovidTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 507);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBrojTestova);
            this.Controls.Add(this.dgvTestovi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbDostavljen);
            this.Controls.Add(this.cmbRezultat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumTesta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStudenti);
            this.Name = "frmCovidTest";
            this.Text = "frmCovidTest";
            this.Load += new System.EventHandler(this.frmCovidTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestovi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumTesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRezultat;
        private System.Windows.Forms.CheckBox cbDostavljen;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvTestovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezultat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NalazDostavljen;
        private System.Windows.Forms.Label lblBrojTestova;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.TextBox txtBrojTestova;
        private System.Windows.Forms.Label label4;
    }
}
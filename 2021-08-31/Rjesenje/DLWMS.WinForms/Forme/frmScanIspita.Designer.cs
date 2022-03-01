
namespace DLWMS.WinForms.Forme
{
    partial class frmScanIspita
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
            this.lblTrenutniStudent = new System.Windows.Forms.Label();
            this.btnDodajScan = new System.Windows.Forms.Button();
            this.dgvStudentIspiti = new System.Windows.Forms.DataGridView();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ScanIspita = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentIspiti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled za studenta:";
            // 
            // lblTrenutniStudent
            // 
            this.lblTrenutniStudent.AutoSize = true;
            this.lblTrenutniStudent.Location = new System.Drawing.Point(177, 31);
            this.lblTrenutniStudent.Name = "lblTrenutniStudent";
            this.lblTrenutniStudent.Size = new System.Drawing.Size(0, 17);
            this.lblTrenutniStudent.TabIndex = 1;
            // 
            // btnDodajScan
            // 
            this.btnDodajScan.Location = new System.Drawing.Point(620, 31);
            this.btnDodajScan.Name = "btnDodajScan";
            this.btnDodajScan.Size = new System.Drawing.Size(158, 27);
            this.btnDodajScan.TabIndex = 2;
            this.btnDodajScan.Text = "Dodaj scan ispita";
            this.btnDodajScan.UseVisualStyleBackColor = true;
            this.btnDodajScan.Click += new System.EventHandler(this.btnDodajScan_Click);
            // 
            // dgvStudentIspiti
            // 
            this.dgvStudentIspiti.AllowUserToAddRows = false;
            this.dgvStudentIspiti.AllowUserToDeleteRows = false;
            this.dgvStudentIspiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentIspiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Napomena,
            this.Varanje,
            this.ScanIspita,
            this.Brisi});
            this.dgvStudentIspiti.Location = new System.Drawing.Point(12, 77);
            this.dgvStudentIspiti.Name = "dgvStudentIspiti";
            this.dgvStudentIspiti.ReadOnly = true;
            this.dgvStudentIspiti.RowHeadersWidth = 51;
            this.dgvStudentIspiti.RowTemplate.Height = 24;
            this.dgvStudentIspiti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentIspiti.Size = new System.Drawing.Size(766, 315);
            this.dgvStudentIspiti.TabIndex = 3;
            this.dgvStudentIspiti.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentIspiti_CellContentDoubleClick);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(620, 411);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(158, 27);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
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
            // Napomena
            // 
            this.Napomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // Varanje
            // 
            this.Varanje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Varanje.DataPropertyName = "Varanje";
            this.Varanje.HeaderText = "Varanje";
            this.Varanje.MinimumWidth = 6;
            this.Varanje.Name = "Varanje";
            this.Varanje.ReadOnly = true;
            this.Varanje.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Varanje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Varanje.Width = 86;
            // 
            // ScanIspita
            // 
            this.ScanIspita.DataPropertyName = "Sken";
            this.ScanIspita.HeaderText = "Scan ispita";
            this.ScanIspita.MinimumWidth = 6;
            this.ScanIspita.Name = "ScanIspita";
            this.ScanIspita.ReadOnly = true;
            this.ScanIspita.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScanIspita.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ScanIspita.Width = 125;
            // 
            // Brisi
            // 
            this.Brisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Brisi.HeaderText = "Brisi";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Brisi";
            this.Brisi.UseColumnTextForButtonValue = true;
            this.Brisi.Width = 41;
            // 
            // frmScanIspita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dgvStudentIspiti);
            this.Controls.Add(this.btnDodajScan);
            this.Controls.Add(this.lblTrenutniStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmScanIspita";
            this.Text = "frmScanIspita";
            this.Load += new System.EventHandler(this.frmScanIspita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentIspiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrenutniStudent;
        private System.Windows.Forms.Button btnDodajScan;
        private System.Windows.Forms.DataGridView dgvStudentIspiti;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Varanje;
        private System.Windows.Forms.DataGridViewImageColumn ScanIspita;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}
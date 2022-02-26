namespace DLWMS.WinForms.IBXXXXXX
{
    partial class frmPotvrde
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
            this.dgvPotvrde = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdata = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBrojPotvrda = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnFajl = new System.Windows.Forms.Button();
            this.lblBrojPotvrda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPotvrde
            // 
            this.dgvPotvrde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPotvrde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotvrde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Svrha,
            this.Datum,
            this.Izdata});
            this.dgvPotvrde.Location = new System.Drawing.Point(12, 63);
            this.dgvPotvrde.Name = "dgvPotvrde";
            this.dgvPotvrde.Size = new System.Drawing.Size(574, 150);
            this.dgvPotvrde.TabIndex = 0;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Student";
            this.Ime.HeaderText = "Student";
            this.Ime.Name = "Ime";
            // 
            // Svrha
            // 
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.Name = "Svrha";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Izdata
            // 
            this.Izdata.DataPropertyName = "Izdata";
            this.Izdata.HeaderText = "Izdata";
            this.Izdata.Name = "Izdata";
            // 
            // txtBrojPotvrda
            // 
            this.txtBrojPotvrda.Location = new System.Drawing.Point(13, 29);
            this.txtBrojPotvrda.Name = "txtBrojPotvrda";
            this.txtBrojPotvrda.Size = new System.Drawing.Size(145, 20);
            this.txtBrojPotvrda.TabIndex = 1;
            this.txtBrojPotvrda.TextChanged += new System.EventHandler(this.txtBrojPotvrda_TextChanged);
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(178, 27);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(110, 23);
            this.btnGenerisi.TabIndex = 2;
            this.btnGenerisi.Text = "Generisi potvrde";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(294, 27);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(107, 23);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Izbrisi potvrde";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnFajl
            // 
            this.btnFajl.Location = new System.Drawing.Point(471, 26);
            this.btnFajl.Name = "btnFajl";
            this.btnFajl.Size = new System.Drawing.Size(115, 23);
            this.btnFajl.TabIndex = 4;
            this.btnFajl.Text = "Upisi u fajl";
            this.btnFajl.UseVisualStyleBackColor = true;
            this.btnFajl.Click += new System.EventHandler(this.btnFajl_Click);
            // 
            // lblBrojPotvrda
            // 
            this.lblBrojPotvrda.AutoSize = true;
            this.lblBrojPotvrda.Location = new System.Drawing.Point(12, 227);
            this.lblBrojPotvrda.Name = "lblBrojPotvrda";
            this.lblBrojPotvrda.Size = new System.Drawing.Size(65, 13);
            this.lblBrojPotvrda.TabIndex = 5;
            this.lblBrojPotvrda.Text = "Broj Potvrda";
            // 
            // frmPotvrde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 255);
            this.Controls.Add(this.lblBrojPotvrda);
            this.Controls.Add(this.btnFajl);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.txtBrojPotvrda);
            this.Controls.Add(this.dgvPotvrde);
            this.Name = "frmPotvrde";
            this.Text = "frmPotvrde";
            this.Load += new System.EventHandler(this.frmPotvrde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPotvrde;
        private System.Windows.Forms.TextBox txtBrojPotvrda;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnFajl;
        private System.Windows.Forms.Label lblBrojPotvrda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Svrha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izdata;
    }
}
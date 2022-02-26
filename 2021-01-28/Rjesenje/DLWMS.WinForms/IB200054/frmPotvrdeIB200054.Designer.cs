
namespace DLWMS.WinForms.IB200054
{
    partial class frmPotvrdeIB200054
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
            this.txtBrojPotvrda = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.lblTrenutno = new System.Windows.Forms.Label();
            this.dgvPotvrde = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpasiUFajl = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdata = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrojPotvrda
            // 
            this.txtBrojPotvrda.Location = new System.Drawing.Point(12, 30);
            this.txtBrojPotvrda.Name = "txtBrojPotvrda";
            this.txtBrojPotvrda.Size = new System.Drawing.Size(173, 22);
            this.txtBrojPotvrda.TabIndex = 0;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(201, 28);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(146, 27);
            this.btnGenerisi.TabIndex = 1;
            this.btnGenerisi.Text = "Generisi potvrde";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // lblTrenutno
            // 
            this.lblTrenutno.AutoSize = true;
            this.lblTrenutno.Location = new System.Drawing.Point(12, 400);
            this.lblTrenutno.Name = "lblTrenutno";
            this.lblTrenutno.Size = new System.Drawing.Size(122, 17);
            this.lblTrenutno.TabIndex = 2;
            this.lblTrenutno.Text = "Trenutno potvrda:";
            // 
            // dgvPotvrde
            // 
            this.dgvPotvrde.AllowUserToAddRows = false;
            this.dgvPotvrde.AllowUserToDeleteRows = false;
            this.dgvPotvrde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotvrde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Svrha,
            this.Izdata});
            this.dgvPotvrde.Location = new System.Drawing.Point(12, 74);
            this.dgvPotvrde.Name = "dgvPotvrde";
            this.dgvPotvrde.ReadOnly = true;
            this.dgvPotvrde.RowHeadersWidth = 51;
            this.dgvPotvrde.RowTemplate.Height = 24;
            this.dgvPotvrde.Size = new System.Drawing.Size(854, 297);
            this.dgvPotvrde.TabIndex = 3;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(456, 28);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(146, 27);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi potvrde";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSpasiUFajl
            // 
            this.btnSpasiUFajl.Location = new System.Drawing.Point(720, 25);
            this.btnSpasiUFajl.Name = "btnSpasiUFajl";
            this.btnSpasiUFajl.Size = new System.Drawing.Size(146, 27);
            this.btnSpasiUFajl.TabIndex = 5;
            this.btnSpasiUFajl.Text = "Spasi u fajl";
            this.btnSpasiUFajl.UseVisualStyleBackColor = true;
            this.btnSpasiUFajl.Click += new System.EventHandler(this.btnSpasiUFajl_Click);
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
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 125;
            // 
            // Svrha
            // 
            this.Svrha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.MinimumWidth = 6;
            this.Svrha.Name = "Svrha";
            this.Svrha.ReadOnly = true;
            // 
            // Izdata
            // 
            this.Izdata.DataPropertyName = "Izdata";
            this.Izdata.HeaderText = "Izdata";
            this.Izdata.MinimumWidth = 6;
            this.Izdata.Name = "Izdata";
            this.Izdata.ReadOnly = true;
            this.Izdata.Width = 125;
            // 
            // frmPotvrdeIB200054
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 448);
            this.Controls.Add(this.btnSpasiUFajl);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvPotvrde);
            this.Controls.Add(this.lblTrenutno);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.txtBrojPotvrda);
            this.Name = "frmPotvrdeIB200054";
            this.Text = "frmPotvrdeIB200054";
            this.Load += new System.EventHandler(this.frmPotvrdeIB200054_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrojPotvrda;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Label lblTrenutno;
        private System.Windows.Forms.DataGridView dgvPotvrde;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpasiUFajl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Svrha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izdata;
    }
}
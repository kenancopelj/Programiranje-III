
namespace DLWMS.WinForms.Forme
{
    partial class frmNoviScanIspita
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
            this.pbScan = new System.Windows.Forms.PictureBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.cbVaranje = new System.Windows.Forms.CheckBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(13, 40);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(213, 24);
            this.cmbPredmeti.TabIndex = 0;
            // 
            // pbScan
            // 
            this.pbScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbScan.Location = new System.Drawing.Point(246, 40);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(187, 241);
            this.pbScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScan.TabIndex = 1;
            this.pbScan.TabStop = false;
            this.pbScan.Click += new System.EventHandler(this.pbScan_Click);
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(12, 82);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(213, 199);
            this.txtNapomena.TabIndex = 2;
            // 
            // cbVaranje
            // 
            this.cbVaranje.AutoSize = true;
            this.cbVaranje.Location = new System.Drawing.Point(13, 305);
            this.cbVaranje.Name = "cbVaranje";
            this.cbVaranje.Size = new System.Drawing.Size(79, 21);
            this.cbVaranje.TabIndex = 3;
            this.cbVaranje.Text = "Varanje";
            this.cbVaranje.UseVisualStyleBackColor = true;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(318, 305);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(115, 29);
            this.btnSpasi.TabIndex = 4;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Predmet";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNoviScanIspita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.cbVaranje);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.cmbPredmeti);
            this.Name = "frmNoviScanIspita";
            this.Text = "frmNoviScanIspita";
            this.Load += new System.EventHandler(this.frmNoviScanIspita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.PictureBox pbScan;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.CheckBox cbVaranje;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
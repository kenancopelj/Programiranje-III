namespace cSharpIntroWinForms.Ispit190073
{
    partial class frmNovaPoruka190073
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
            this.txtPrimalac = new System.Windows.Forms.TextBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdPutanjaDoSlike = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Primalac:";
            // 
            // txtPrimalac
            // 
            this.txtPrimalac.Enabled = false;
            this.txtPrimalac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPrimalac.Location = new System.Drawing.Point(16, 54);
            this.txtPrimalac.Name = "txtPrimalac";
            this.txtPrimalac.Size = new System.Drawing.Size(292, 26);
            this.txtPrimalac.TabIndex = 4;
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(314, 54);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(234, 282);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 5;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(310, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Slika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sadrzaj";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Enabled = false;
            this.txtSadrzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtSadrzaj.Location = new System.Drawing.Point(16, 129);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(292, 207);
            this.txtSadrzaj.TabIndex = 8;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSpasi.Location = new System.Drawing.Point(452, 342);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(96, 33);
            this.btnSpasi.TabIndex = 9;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // ofdPutanjaDoSlike
            // 
            this.ofdPutanjaDoSlike.FileName = "openFileDialog1";
            // 
            // frmNovaPoruka190073
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 382);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.txtPrimalac);
            this.Controls.Add(this.label1);
            this.Name = "frmNovaPoruka190073";
            this.Text = "frmNovaPoruka190073";
            this.Load += new System.EventHandler(this.frmNovaPoruka190073_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrimalac;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.OpenFileDialog ofdPutanjaDoSlike;
    }
}
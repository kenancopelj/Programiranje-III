namespace cSharpIntroWinForms.IB190073
{
    partial class frmKorisniciSlikePregled
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
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnNaprijed = new System.Windows.Forms.Button();
            this.ofdDodajSliku = new System.Windows.Forms.OpenFileDialog();
            this.pbTrenutnaSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrenutnaSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnNazad.Location = new System.Drawing.Point(36, 139);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(94, 138);
            this.btnNazad.TabIndex = 1;
            this.btnNazad.Text = "<";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnNaprijed.Location = new System.Drawing.Point(435, 139);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(94, 138);
            this.btnNaprijed.TabIndex = 2;
            this.btnNaprijed.Text = ">";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            this.btnNaprijed.Click += new System.EventHandler(this.btnNaprijed_Click);
            // 
            // ofdDodajSliku
            // 
            this.ofdDodajSliku.FileName = "openFileDialog1";
            // 
            // pbTrenutnaSlika
            // 
            this.pbTrenutnaSlika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbTrenutnaSlika.Location = new System.Drawing.Point(136, 49);
            this.pbTrenutnaSlika.Name = "pbTrenutnaSlika";
            this.pbTrenutnaSlika.Size = new System.Drawing.Size(293, 328);
            this.pbTrenutnaSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrenutnaSlika.TabIndex = 0;
            this.pbTrenutnaSlika.TabStop = false;
            this.pbTrenutnaSlika.Click += new System.EventHandler(this.pbTrenutnaSlika_Click);
            // 
            // frmKorisniciSlikePregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 427);
            this.Controls.Add(this.btnNaprijed);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.pbTrenutnaSlika);
            this.Name = "frmKorisniciSlikePregled";
            this.Text = "frmKorisniciSlikePregled";
            this.Load += new System.EventHandler(this.frmKorisniciSlikePregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrenutnaSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrenutnaSlika;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnNaprijed;
        private System.Windows.Forms.OpenFileDialog ofdDodajSliku;
    }
}
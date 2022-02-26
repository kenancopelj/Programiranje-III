
namespace cSharpIntroWinForms.IB200054
{
    partial class frmKorisnikSlikePregledIB200054
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
            this.btnLijevo = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.btnDesno = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLijevo
            // 
            this.btnLijevo.Location = new System.Drawing.Point(52, 137);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(118, 158);
            this.btnLijevo.TabIndex = 0;
            this.btnLijevo.Text = "<";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(205, 51);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(312, 315);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.Location = new System.Drawing.Point(551, 137);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(118, 158);
            this.btnDesno.TabIndex = 2;
            this.btnDesno.Text = ">";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmKorisnikSlikePregledIB200054
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 429);
            this.Controls.Add(this.btnDesno);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnLijevo);
            this.Name = "frmKorisnikSlikePregledIB200054";
            this.Text = "frmKorisnikSlikePregledIB200054";
            this.Load += new System.EventHandler(this.frmKorisnikSlikePregledIB200054_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
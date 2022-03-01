
namespace DLWMS.WinForms.IB200054
{
    partial class frmStudentiSlikeIB200054
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSljedeca = new System.Windows.Forms.Button();
            this.btnPrethodna = new System.Windows.Forms.Button();
            this.lblBrojSlike = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtOpisTrenutneSlike = new System.Windows.Forms.TextBox();
            this.pbTrenutnaSlika = new System.Windows.Forms.PictureBox();
            this.pbSlikaZaDodati = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrenutnaSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaZaDodati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slika:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(216, 55);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(362, 97);
            this.txtOpis.TabIndex = 3;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(464, 169);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(114, 30);
            this.btnDodajSliku.TabIndex = 4;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOpisTrenutneSlike);
            this.groupBox1.Controls.Add(this.lblDatum);
            this.groupBox1.Controls.Add(this.btnSljedeca);
            this.groupBox1.Controls.Add(this.btnPrethodna);
            this.groupBox1.Controls.Add(this.pbTrenutnaSlika);
            this.groupBox1.Controls.Add(this.lblBrojSlike);
            this.groupBox1.Location = new System.Drawing.Point(15, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 435);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled slika:";
            // 
            // btnSljedeca
            // 
            this.btnSljedeca.Location = new System.Drawing.Point(426, 150);
            this.btnSljedeca.Name = "btnSljedeca";
            this.btnSljedeca.Size = new System.Drawing.Size(114, 30);
            this.btnSljedeca.TabIndex = 7;
            this.btnSljedeca.Text = "=>";
            this.btnSljedeca.UseVisualStyleBackColor = true;
            this.btnSljedeca.Click += new System.EventHandler(this.btnSljedeca_Click);
            // 
            // btnPrethodna
            // 
            this.btnPrethodna.Location = new System.Drawing.Point(30, 150);
            this.btnPrethodna.Name = "btnPrethodna";
            this.btnPrethodna.Size = new System.Drawing.Size(114, 30);
            this.btnPrethodna.TabIndex = 6;
            this.btnPrethodna.Text = "<=";
            this.btnPrethodna.UseVisualStyleBackColor = true;
            this.btnPrethodna.Click += new System.EventHandler(this.btnPrethodna_Click);
            // 
            // lblBrojSlike
            // 
            this.lblBrojSlike.AutoSize = true;
            this.lblBrojSlike.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojSlike.Location = new System.Drawing.Point(278, 29);
            this.lblBrojSlike.Name = "lblBrojSlike";
            this.lblBrojSlike.Size = new System.Drawing.Size(21, 29);
            this.lblBrojSlike.TabIndex = 6;
            this.lblBrojSlike.Text = "/";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(198, 299);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(12, 17);
            this.lblDatum.TabIndex = 6;
            this.lblDatum.Text = "/";
            // 
            // txtOpisTrenutneSlike
            // 
            this.txtOpisTrenutneSlike.Location = new System.Drawing.Point(30, 332);
            this.txtOpisTrenutneSlike.Multiline = true;
            this.txtOpisTrenutneSlike.Name = "txtOpisTrenutneSlike";
            this.txtOpisTrenutneSlike.ReadOnly = true;
            this.txtOpisTrenutneSlike.Size = new System.Drawing.Size(510, 97);
            this.txtOpisTrenutneSlike.TabIndex = 6;
            this.txtOpisTrenutneSlike.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbTrenutnaSlika
            // 
            this.pbTrenutnaSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTrenutnaSlika.Location = new System.Drawing.Point(165, 61);
            this.pbTrenutnaSlika.Name = "pbTrenutnaSlika";
            this.pbTrenutnaSlika.Size = new System.Drawing.Size(236, 225);
            this.pbTrenutnaSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrenutnaSlika.TabIndex = 6;
            this.pbTrenutnaSlika.TabStop = false;
            // 
            // pbSlikaZaDodati
            // 
            this.pbSlikaZaDodati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlikaZaDodati.Location = new System.Drawing.Point(13, 55);
            this.pbSlikaZaDodati.Name = "pbSlikaZaDodati";
            this.pbSlikaZaDodati.Size = new System.Drawing.Size(167, 158);
            this.pbSlikaZaDodati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaZaDodati.TabIndex = 1;
            this.pbSlikaZaDodati.TabStop = false;
            this.pbSlikaZaDodati.Click += new System.EventHandler(this.pbSlikaZaDodati_Click);
            // 
            // frmStudentiSlikeIB200054
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 682);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSlikaZaDodati);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentiSlikeIB200054";
            this.Text = "frmStudentiSlikeIB200054";
            this.Load += new System.EventHandler(this.frmStudentiSlikeIB200054_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrenutnaSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaZaDodati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbSlikaZaDodati;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBrojSlike;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbTrenutnaSlika;
        private System.Windows.Forms.Button btnSljedeca;
        private System.Windows.Forms.Button btnPrethodna;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtOpisTrenutneSlike;
    }
}
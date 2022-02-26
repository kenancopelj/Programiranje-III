
namespace DLWMS.WinForms.IB200054
{
    partial class frmNovaPorukaIB200054
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
            this.txtPrimalac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrimalac
            // 
            this.txtPrimalac.Location = new System.Drawing.Point(12, 54);
            this.txtPrimalac.Name = "txtPrimalac";
            this.txtPrimalac.ReadOnly = true;
            this.txtPrimalac.Size = new System.Drawing.Size(285, 22);
            this.txtPrimalac.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primalac:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sadrzaj:";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(12, 120);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(285, 207);
            this.txtSadrzaj.TabIndex = 5;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(467, 343);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(97, 29);
            this.btnSpasi.TabIndex = 6;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(324, 54);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(240, 273);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 2;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmNovaPorukaIB200054
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 384);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrimalac);
            this.Name = "frmNovaPorukaIB200054";
            this.Text = "frmNovaPorukaIB200054";
            this.Load += new System.EventHandler(this.frmNovaPorukaIB200054_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimalac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.ErrorProvider err;
    }
}
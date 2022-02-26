
namespace cSharpIntroWinForms.IB200054
{
    partial class frmGlavnaIB200054
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
            this.btnGodineStudija = new System.Windows.Forms.Button();
            this.btnPolozeni = new System.Windows.Forms.Button();
            this.btnSumiraj = new System.Windows.Forms.Button();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGodineStudija
            // 
            this.btnGodineStudija.Location = new System.Drawing.Point(27, 54);
            this.btnGodineStudija.Name = "btnGodineStudija";
            this.btnGodineStudija.Size = new System.Drawing.Size(244, 194);
            this.btnGodineStudija.TabIndex = 0;
            this.btnGodineStudija.Text = "Godine studija";
            this.btnGodineStudija.UseVisualStyleBackColor = true;
            this.btnGodineStudija.Click += new System.EventHandler(this.btnGodineStudija_Click);
            // 
            // btnPolozeni
            // 
            this.btnPolozeni.Location = new System.Drawing.Point(303, 54);
            this.btnPolozeni.Name = "btnPolozeni";
            this.btnPolozeni.Size = new System.Drawing.Size(244, 194);
            this.btnPolozeni.TabIndex = 1;
            this.btnPolozeni.Text = "Polozeni predmeti";
            this.btnPolozeni.UseVisualStyleBackColor = true;
            this.btnPolozeni.Click += new System.EventHandler(this.btnPolozeni_Click);
            // 
            // btnSumiraj
            // 
            this.btnSumiraj.Location = new System.Drawing.Point(573, 94);
            this.btnSumiraj.Name = "btnSumiraj";
            this.btnSumiraj.Size = new System.Drawing.Size(244, 154);
            this.btnSumiraj.TabIndex = 2;
            this.btnSumiraj.Text = "Suma";
            this.btnSumiraj.UseVisualStyleBackColor = true;
            this.btnSumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(573, 54);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(244, 22);
            this.txtBroj.TabIndex = 3;
            // 
            // frmGlavnaIB200054
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.btnSumiraj);
            this.Controls.Add(this.btnPolozeni);
            this.Controls.Add(this.btnGodineStudija);
            this.Name = "frmGlavnaIB200054";
            this.Text = "frmGlavnaIB200054";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGodineStudija;
        private System.Windows.Forms.Button btnPolozeni;
        private System.Windows.Forms.Button btnSumiraj;
        private System.Windows.Forms.TextBox txtBroj;
    }
}
namespace cSharpIntroWinForms.IB190073
{
    partial class Glavna
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
            this.btnPolozeniPredmeti = new System.Windows.Forms.Button();
            this.btnIzracunajSumu = new System.Windows.Forms.Button();
            this.txtUnesenaSuma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGodineStudija
            // 
            this.btnGodineStudija.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGodineStudija.Location = new System.Drawing.Point(35, 66);
            this.btnGodineStudija.Name = "btnGodineStudija";
            this.btnGodineStudija.Size = new System.Drawing.Size(172, 106);
            this.btnGodineStudija.TabIndex = 0;
            this.btnGodineStudija.Text = "Godine studija";
            this.btnGodineStudija.UseVisualStyleBackColor = true;
            this.btnGodineStudija.Click += new System.EventHandler(this.btnGodineStudija_Click);
            // 
            // btnPolozeniPredmeti
            // 
            this.btnPolozeniPredmeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolozeniPredmeti.Location = new System.Drawing.Point(273, 66);
            this.btnPolozeniPredmeti.Name = "btnPolozeniPredmeti";
            this.btnPolozeniPredmeti.Size = new System.Drawing.Size(172, 106);
            this.btnPolozeniPredmeti.TabIndex = 1;
            this.btnPolozeniPredmeti.Text = "Polozeni Predmeti";
            this.btnPolozeniPredmeti.UseVisualStyleBackColor = true;
            this.btnPolozeniPredmeti.Click += new System.EventHandler(this.btnPolozeniPredmeti_Click);
            // 
            // btnIzracunajSumu
            // 
            this.btnIzracunajSumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnIzracunajSumu.Location = new System.Drawing.Point(513, 110);
            this.btnIzracunajSumu.Name = "btnIzracunajSumu";
            this.btnIzracunajSumu.Size = new System.Drawing.Size(172, 62);
            this.btnIzracunajSumu.TabIndex = 2;
            this.btnIzracunajSumu.Text = "Izracunaj sumu";
            this.btnIzracunajSumu.UseVisualStyleBackColor = true;
            this.btnIzracunajSumu.Click += new System.EventHandler(this.btnIzracunajSumu_Click);
            // 
            // txtUnesenaSuma
            // 
            this.txtUnesenaSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txtUnesenaSuma.Location = new System.Drawing.Point(513, 66);
            this.txtUnesenaSuma.Name = "txtUnesenaSuma";
            this.txtUnesenaSuma.Size = new System.Drawing.Size(172, 27);
            this.txtUnesenaSuma.TabIndex = 3;
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 225);
            this.Controls.Add(this.txtUnesenaSuma);
            this.Controls.Add(this.btnIzracunajSumu);
            this.Controls.Add(this.btnPolozeniPredmeti);
            this.Controls.Add(this.btnGodineStudija);
            this.Name = "Glavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGodineStudija;
        private System.Windows.Forms.Button btnPolozeniPredmeti;
        private System.Windows.Forms.Button btnIzracunajSumu;
        private System.Windows.Forms.TextBox txtUnesenaSuma;
    }
}
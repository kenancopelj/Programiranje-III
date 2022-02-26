namespace DLWMS.WinForms.IBXXXXXX
{
    partial class frmPotvrdiBrisanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Da li ste sigurni da zelite izbrisati sve potvrde?";
            // 
            // btnDa
            // 
            this.btnDa.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDa.Location = new System.Drawing.Point(349, 57);
            this.btnDa.Name = "btnDa";
            this.btnDa.Size = new System.Drawing.Size(75, 23);
            this.btnDa.TabIndex = 1;
            this.btnDa.Text = "Da";
            this.btnDa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(268, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ne";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmPotvrdiBrisanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 92);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDa);
            this.Controls.Add(this.label1);
            this.Name = "frmPotvrdiBrisanje";
            this.Text = "frmPotvrdiBrisanje";
            this.Load += new System.EventHandler(this.frmPotvrdiBrisanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDa;
        private System.Windows.Forms.Button button1;
    }
}
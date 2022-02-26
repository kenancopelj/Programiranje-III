namespace cSharpIntroWinForms.IB190073
{
    partial class frmIzvjestaj
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblKorisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKorisnici = new cSharpIntroWinForms.IB190073.dsKorisnici();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tblKorisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // tblKorisniciBindingSource
            // 
            this.tblKorisniciBindingSource.DataMember = "tblKorisnici";
            this.tblKorisniciBindingSource.DataSource = this.dsKorisnici;
            // 
            // dsKorisnici
            // 
            this.dsKorisnici.DataSetName = "dsKorisnici";
            this.dsKorisnici.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsKorisniciPolozeniPredmeti";
            reportDataSource1.Value = this.tblKorisniciBindingSource;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "cSharpIntroWinForms.IB190073.rptIzvjestajPolozenih.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(0, 0);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.Size = new System.Drawing.Size(800, 450);
            this.rptViewer.TabIndex = 0;
            // 
            // frmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptViewer);
            this.Name = "frmIzvjestaj";
            this.Load += new System.EventHandler(this.frmIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblKorisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.BindingSource tblKorisniciBindingSource;
        private dsKorisnici dsKorisnici;
    }
}
using DLWMS.WinForms.Entiteti;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<Student> studenti;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<Student> studenti) : this()
        {
            this.studenti = studenti;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            //var rpc = new ReportParameterCollection();

            var tblStudenti = new List<object>();

            for (int i = 0; i < studenti.Count; i++)
            {
                var aktivnost = studenti[i].Aktivan ? "Da" : "Ne";
                tblStudenti.Add(new
                {
                    Rb = i+1,
                    Indeks = studenti[i].Indeks,
                    Ime = studenti[i].Ime,
                    Prezime = studenti[i].Prezime,
                    Spol = studenti[i].Spol.Naziv,
                    Godina = studenti[i].GodinaStudija,
                    Aktivan = aktivnost
                });
            }

            var rds = new ReportDataSource();
            rds.Name = "dsStudenti";
            rds.Value = tblStudenti;

            reportViewer1.LocalReport.DataSources.Add(rds);
            //reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}

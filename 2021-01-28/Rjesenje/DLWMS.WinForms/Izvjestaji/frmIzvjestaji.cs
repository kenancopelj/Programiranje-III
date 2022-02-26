using DLWMS.WinForms.Entiteti;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        List<Student> studenti;
        public frmIzvjestaji()
        {
            InitializeComponent();
        }
        public frmIzvjestaji(List<Student> s):this()
        {
            this.studenti = s;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();
            var tblStudenti = new dsDLWMS.StudentiDataTable();
            int brojac = 1;
            foreach(var s in studenti)
            {
                var red = tblStudenti.NewStudentiRow();
                red.RB = brojac++.ToString();
                red.IB = s.Indeks;
                red.Ime = s.Ime;
                red.Prezime = s.Prezime;
                red.Spol = s.Spol.Naziv;
                red.Godina = s.GodinaStudija.ToString();
                red.Aktivan = s.Aktivan == true ? "Da" : "Ne";
                tblStudenti.AddStudentiRow(red);
            }
            rds.Name = "dsDLWMS";
            rds.Value = tblStudenti;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}

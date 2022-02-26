using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB200054
{
    public partial class frmIzvjestaj : Form
    {
        private Korisnik korisnik;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("Korisnik", $"{korisnik.Ime} {korisnik.Prezime}"));

            var tblPodaci = new List<object>();

            for (int i = 0; i < korisnik.Uspjeh.Count; i++)
            {
                tblPodaci.Add(new
                {
                    Rb = i +1,
                    Predmet = korisnik.Uspjeh[i].Predmet.Naziv,
                    GodinaStudija = korisnik.Uspjeh[i].GodinaStudija.Naziv,
                    Ocjena = korisnik.Uspjeh[i].Ocjena,
                    Datum = korisnik.Uspjeh[i].Datum
                });
            }

            var dataSource = new ReportDataSource();
            dataSource.Name = "dsPodaci";
            dataSource.Value = tblPodaci;

            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.LocalReport.SetParameters(parametri);
            this.reportViewer1.RefreshReport();
        }
    }
}

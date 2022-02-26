using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace cSharpIntroWinForms.IB190073
{
    public partial class frmIzvjestaj : Form
    {
        private dtoKorisnik _korisnici;
        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(dtoKorisnik objekat) : this()
        {
            _korisnici = objekat;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {

            //dsKorisnici.tblKorisniciDataTable tbl = new dsKorisnici.tblKorisniciDataTable();
            //foreach (var korisnik in _korisnici.ListaKorisnika)
            //{
            //    string sviPredmeti = "";
            //    dsKorisnici.tblKorisniciRow noviRed = tbl.NewtblKorisniciRow();
            //    noviRed.ImePrezime = korisnik.Ime + " " + korisnik.Prezime;
            //    foreach (var polozeni in korisnik.Uspjeh)
            //        sviPredmeti += polozeni.Predmet.Naziv + Environment.NewLine;
            //    noviRed.Predmet = sviPredmeti;
            //    tbl.Rows.Add(noviRed);
            //}


            //List<object> lista = new List<object>();
            //foreach (var korisnik in _korisnici.ListaKorisnika)
            //{
            //    string sviPredmeti = "";
            //    foreach (var predmet in korisnik.Uspjeh)
            //        sviPredmeti += predmet.Predmet.Naziv + Environment.NewLine;

            //    lista.Add(new
            //    {
            //        ImePrezime = korisnik.Ime + " " + korisnik.Prezime,
            //        Predmet = sviPredmeti
            //    });
            //}

            //ReportDataSource izvor = new ReportDataSource();
            //izvor.Name = "dsKorisniciPolozeniPredmeti";
            //izvor.Value = lista;

            //rptViewer.LocalReport.DataSources.Add(izvor);
            this.rptViewer.RefreshReport();
        }
    }
}

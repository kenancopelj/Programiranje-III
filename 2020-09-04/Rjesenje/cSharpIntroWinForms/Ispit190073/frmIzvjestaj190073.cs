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

namespace cSharpIntroWinForms.Ispit190073
{
    public partial class frmIzvjestaj190073 : Form
    {
        private dtoKorisnik _korisnik;
        public frmIzvjestaj190073()
        {
            InitializeComponent();
            _korisnik = new dtoKorisnik();
        }
        public frmIzvjestaj190073(dtoKorisnik objekat): this()
        {
            _korisnik = objekat;
        }
        private void frmIzvjestaj190073_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("ImePrezime", _korisnik.ImePrezime));
            rptViewer.LocalReport.SetParameters(rpc);


            dsPoruke.tblPorukeDataTable tbl = new dsPoruke.tblPorukeDataTable();
            foreach (var poruka in _korisnik.ListaPoruka)
            {
                dsPoruke.tblPorukeRow noviRed = tbl.NewtblPorukeRow();
                noviRed.Id = poruka.Id;
                noviRed.DatumSlanja = poruka.DatumSlanja;
                noviRed.Sadrzaj = poruka.Sadrzaj;
                noviRed.Slika = poruka.Slika;

                //nakon kreiranja reda i popunjavanja podacima OBAVEZNO ga dodati u tabelu
                tbl.Rows.Add(noviRed);
            }
           

            ReportDataSource izvorPodataka = new ReportDataSource();
            izvorPodataka.Name = "dsPrikazPoruka";
            izvorPodataka.Value = tbl;
            rptViewer.LocalReport.DataSources.Add(izvorPodataka);

            this.rptViewer.RefreshReport();
        }
    }
}

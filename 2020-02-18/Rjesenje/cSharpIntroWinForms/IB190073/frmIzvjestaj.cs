using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpIntroWinForms.P8;
using Microsoft.Reporting.WinForms;

namespace cSharpIntroWinForms.IB190073
{
    public partial class frmIzvjestaj : Form
    {
        private dtoKorisnikIzvjestaj objekat;
        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(dtoKorisnikIzvjestaj objekat) : this()
        {
            this.objekat = objekat;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Ime", objekat.Ime));
            rpc.Add(new ReportParameter("Prezime", objekat.Prezime));
            rptViewer.LocalReport.SetParameters(rpc);


            dsKorisnikIzvjestaja.tblPolozeniDataTable tbl = new dsKorisnikIzvjestaja.tblPolozeniDataTable();
            foreach (var predmet in objekat.Polozeni)
            {
                dsKorisnikIzvjestaja.tblPolozeniRow noviRed = tbl.NewtblPolozeniRow();
                noviRed.Rb = predmet.Id;
                noviRed.Predmet = predmet.Predmet.Naziv;
                noviRed.Ocjena = predmet.Ocjena;
                noviRed.GodinaStudija = predmet.GodineStudija.ToString();
                noviRed.DatumPolaganja = predmet.Datum;
                tbl.Rows.Add(noviRed);
            }

            ReportDataSource izvorPodataka = new ReportDataSource();
            izvorPodataka.Name = "dataSetPolozeniPredmeti";
            izvorPodataka.Value = tbl;

            rptViewer.LocalReport.DataSources.Add(izvorPodataka);
            this.rptViewer.RefreshReport();
        }
    }
}

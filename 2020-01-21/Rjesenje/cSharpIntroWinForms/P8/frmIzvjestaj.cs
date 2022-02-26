using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
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

namespace cSharpIntroWinForms.P8
{
    public partial class frmIzvjestaj : Form
    {
        private Korisnik korisnik;
        KonekcijaNaBazu baza = DLWMS.DB;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Student", $"{korisnik.Ime} {korisnik.Prezime}"));

            var tblPolozeni = new List<object>();

            var nepolozeni = NepolozeniPredmeti();

            for (int i = 0; i < korisnik.Uspjeh.Count; i++)
            {

                tblPolozeni.Add(new
                {
                    Rb = tblPolozeni.Count + 1,
                    Predmet = korisnik.Uspjeh[i].Predmet.Naziv,
                    Datum = korisnik.Uspjeh[i].Datum,
                    Ocjena = korisnik.Uspjeh[i].Ocjena
                });
            }

            for (int i = 0; i < nepolozeni.Count; i++)
            {
                tblPolozeni.Add(new
                {
                    Rb = tblPolozeni.Count + 1,
                    Predmet = nepolozeni[i].Naziv,
                    Datum = "NIJE POLOZENO",
                    Ocjena = 0
                });
            }

            var dataSource = new ReportDataSource();
            dataSource.Value = tblPolozeni;
            dataSource.Name = "dsPolozeni";

            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }

        private List<Predmeti> NepolozeniPredmeti()
        {
            var query = from p in baza.Predmeti.AsEnumerable()
                        where !(from u in korisnik.Uspjeh
                                select u.Predmet.Id)
                                .Contains(p.Id)
                        select p;
            return query.ToList();
            
        }
    }
}

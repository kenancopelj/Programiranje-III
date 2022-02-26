using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using Microsoft.Reporting.WinForms;
namespace cSharpIntroWinForms.P11
{
    public partial class Izvjestaji : Form
    {
        private Korisnik korisnik;
        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
        public Izvjestaji()
        {
            InitializeComponent();
        }

        public Izvjestaji(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void Izvjestaji_Load(object sender, EventArgs e)
        {
            try
            {
                if (korisnik == null) // Ako je korisnik null ne nastavljamo dalje
                    return;


                    // Prosljedjujemo parametre
                    ReportParameterCollection rpc = new ReportParameterCollection();
                    rpc.Add(new ReportParameter("ImePrezime", $"{korisnik.Ime} {korisnik.Prezime}"));
                    rpc.Add(new ReportParameter("Indeks", korisnik.KorisnickoIme));
                    // Dodaj parametre u report
                    reportViewer1.LocalReport.SetParameters(rpc);

                // Lista objekata
                List<object> list = new List<object>();
                    int i = 0; // pomocni brojac

                    // Listamo sve predmete
                    foreach (var polozeni in konekcijaNaBazu.Predmeti)
                    {

                        // Selektovanje ocjene i datuma u objekat
                        var podaci = konekcijaNaBazu.KorisniciPredmeti.ToList().Where(x => x.Predmet.Id == polozeni.Id && x.Korisnik.Id == korisnik.Id).Select(y => new { ocjena = y.Ocjena, datum = y.Datum }).FirstOrDefault();
                        /*
                         * .FirstOrDefault() sluzi da vrati prvi rezultat ako je niz
                         * ako bi koristili SingleOrDefault() onda bi bio exception za korisnike koji imaju duple ocjene koje
                         * smo dodali preko ASYNC 
                         * sa SingleOrDefault nekad nam error dobro dodje jer nam javi da imamo u bazi vise rezultata,
                         * ali u ovom slucaju ne smijemo koristiti Single radi gore navedenog razloga.
                         */

                        // Popunjavamo niz objekata u listu
                        list.Add(new
                        {
                            Rb = i++,
                            Naziv = polozeni.Naziv,
                            
                            // (.?) podaci?.ocjena skraceno provjerava da li su podaci null, isto je kao if(podaci!=null) podaci.ocjena
                            Ocjena = podaci?.ocjena.ToString() ?? "Nije polozeno", //  ?? ako nije null vrati lijevu stranu, ako je null vrati desnu stranu, tj. if else
                            Datum = podaci?.datum.ToString() ?? "Nije polozeno"
                        });

                    }


                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = list;

                    reportViewer1.LocalReport.DataSources.Add(rds);

                    this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }
    

    }
}

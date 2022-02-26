using cSharpIntroWinForms.IB200054;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
        private Korisnik korisnik;

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;     
            
        }
        public KorisniciPolozeniPredmeti(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }
        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            korisnik = konekcijaNaBazu.Korisnici.FirstOrDefault();
            UcitajPolozene();
            UcitajPredmete();
            UcitajGodineStudija();
        }

        private void UcitajGodineStudija()
        {
            cmbGodinaStudija.DataSource = konekcijaNaBazu.GodineStudija.ToList();
            cmbGodinaStudija.DisplayMember = "Naziv";
            cmbGodinaStudija.ValueMember = "Id";
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            if(Validiraj())
            {
                if(!VecPolozen())
                {
                    konekcijaNaBazu.KorisniciPredmeti.Add(new KorisniciPredmeti()
                    {
                        Korisnik = korisnik,
                        Predmet = cmbPredmeti.SelectedItem as Predmeti,
                        GodinaStudija = cmbGodinaStudija.SelectedItem as GodineStudijaIB200054,
                        Datum = dtpDatumPolaganja.Value.ToString(),
                        Ocjena = int.Parse(txtOcjena.Text)
                    });
                    konekcijaNaBazu.SaveChanges();
                    UcitajPolozene();
                }
                else
                    MessageBox.Show("Vec polozen");
            }
        }

        private void UcitajPolozene()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = korisnik.Uspjeh;
        }

        private bool VecPolozen()
        {
            var odabraniPredmet = cmbPredmeti.SelectedItem as Predmeti;
            var odabranaGodina = cmbGodinaStudija.SelectedItem as GodineStudijaIB200054;
            foreach (var polozeni in korisnik.Uspjeh)
            {
                if ((odabranaGodina.Id == polozeni.GodinaStudija.Id && odabraniPredmet.Id == polozeni.Predmet.Id)
                    || (odabranaGodina.Id != polozeni.GodinaStudija.Id && odabraniPredmet.Id == polozeni.Predmet.Id))
                    return true;
            }
            return false;
        }

        private bool Validiraj()
        {
            if(string.IsNullOrWhiteSpace(txtOcjena.Text))
            {
                err.SetError(txtOcjena, "Obavezno");
                return false;
            }
            err.Clear();
            return true;
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            new frmIzvjestaj(korisnik).ShowDialog();
        }
    }
}

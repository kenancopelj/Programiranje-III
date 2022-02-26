using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        public KorisniciPolozeniPredmeti(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajPolozene();
        }

        private void UcitajPredmete(List<Predmeti> lista = null)
        {
            cmbPredmeti.DataSource = null;
            cmbPredmeti.DataSource = lista ?? konekcijaNaBazu.Predmeti.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        private void UcitajPolozene()
        {
            try
            {
                dgvPolozeniPredmeti.DataSource = null;
                dgvPolozeniPredmeti.DataSource = korisnik.Uspjeh;
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void cbUcitajNepolozene_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUcitajNepolozene.Checked)
            {
                var query = from p in konekcijaNaBazu.Predmeti.AsEnumerable()
                            where !(from u in korisnik.Uspjeh
                                    select u.Predmet.Id)
                                    .Contains(p.Id)
                            select p;
                UcitajPredmete(query.ToList());
            }
            else
                UcitajPredmete();
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            if(!VecPolozen())
            {
                var noviPolozeni = new KorisniciPredmeti()
                {
                    Korisnik = korisnik,
                    Predmet = cmbPredmeti.SelectedItem as Predmeti,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    Datum = dtpDatumPolaganja.Value.ToString("MM/dd/yyy")
                };
                konekcijaNaBazu.KorisniciPredmeti.Add(noviPolozeni);
                konekcijaNaBazu.SaveChanges();
                UcitajPolozene();
            }
            else
            {
                MessageBox.Show("Vec polozen", "Info");
            }
        }

        private bool VecPolozen()
        {
            var odabraniPredmet = cmbPredmeti.SelectedItem as Predmeti;
            foreach (var polozeni in korisnik.Uspjeh)
                    if(odabraniPredmet.Id == polozeni.Predmet.Id)
                        return true;
            return false;
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            new frmIzvjestaj(korisnik).ShowDialog();
        }

        private async void btnASYNC_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem as Predmeti;
            Action action = () => UcitajPolozene();
            await Task.Run(() =>
            {
                for (int i = 0; i < 500; i++)
                {
                    konekcijaNaBazu.KorisniciPredmeti.Add(new KorisniciPredmeti()
                    {
                        Korisnik = korisnik,
                        Predmet = predmet,
                        Ocjena = 6,
                        Datum = dtpDatumPolaganja.Value.ToString("dd/MM/yyyy")
                    });
                }
                konekcijaNaBazu.SaveChanges();
                MessageBox.Show("Uspjesno dodano 500 predmeta");
                BeginInvoke(action);
            });
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            Action action = () => UcitajPolozene();
            await Task.Run(() =>
            {
                konekcijaNaBazu.KorisniciPredmeti.RemoveRange(konekcijaNaBazu.KorisniciPredmeti);
                konekcijaNaBazu.SaveChanges();
                BeginInvoke(action);
            });
        }
    }
}

using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.Ispit190073
{
    public partial class frmPretraga190073 : Form
    {
        KonekcijaNaBazu baza = DLWMS.DB;

        async void SumMethod()
        {
            await Task.Run(() =>
            {
                Izracun();
            });
        }

        private void Izracun()
        {
            int suma = 0;
            for (int i = 0; i <= int.Parse(txtThreadInput.Text); i++)
                suma += i;
            lblSuma.Text = suma.ToString();
        }

        public frmPretraga190073()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }
        private void frmPretraga190073_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPolozenePredmete();
                UcitajProsjek();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }
        private void UcitajProsjek(List<KorisniciPredmeti> podaci=null)
        {
            var lista = podaci ?? baza.KorisniciPredmeti.ToList();
            double prosjekSvih = 0;
            if (lista.Count() == 0)
            {
                lblProsjek.Text = "0";
                return;
            }
            foreach (var korisnik in lista)
                prosjekSvih += korisnik.Korisnik.IzracunajProsjek();
            lblProsjek.Text= (prosjekSvih / lista.Count()).ToString();
        }
        private void UcitajPolozenePredmete(List<KorisniciPredmeti> lista =null)
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = lista ?? baza.KorisniciPredmeti.ToList();
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPretraga.Text;
            var rezultat = baza.KorisniciPredmeti.Where(x => x.Predmet.Naziv.ToLower().Contains(filter.ToLower())).ToList();
            UcitajPolozenePredmete(rezultat);
            UcitajProsjek(rezultat);
        }
        private void dgvPolozeniPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kada kliknemo mi mozemo samo uzeti objekat tipa KorisniciPredmeti, nakon sto ga uzmemo on ima svog korisnika
            var Objekat = dgvPolozeniPredmeti.Rows[e.RowIndex].DataBoundItem as KorisniciPredmeti;
            //sad prodjemo kroz podatke o korisnicima u bazi i koji korisnik ima isti ID kao i ovaj odabrani uzimamo njega
            var korisnik = baza.Korisnici.Where(x => x.Id == Objekat.Korisnik.Id).FirstOrDefault();
            var grid = (DataGridView)sender;
            if(korisnik!=null)
            {
                if(grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex>=0)
                {
                    frmPoruke190073 forma = new frmPoruke190073(korisnik);
                    forma.ShowDialog();
                }
            }
        }

        private void btnSumiraj_Click(object sender, EventArgs e)
        {
            SumMethod();
        }
    }
}

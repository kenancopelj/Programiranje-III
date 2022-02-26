using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
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

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                List<Korisnik> rezultati = korisnici ?? konekcijaNaBazu.Korisnici.ToList();

                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = rezultati;
                RacunajProsjek(rezultati);

            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void RacunajProsjek(List<Korisnik> rezultati)
        {
            lblProsjek.Text = "";
            var korisniciSaOcjenama = rezultati.Where(x => x.Uspjeh.Count > 0).ToList();
            var prosjecnaOcjena = korisniciSaOcjenama.Average(x => (double?)x.Uspjeh.Average(k => k.Ocjena));

            lblProsjek.Text += $"Prosjek prikazanih korisnika: {prosjecnaOcjena.GetValueOrDefault()}";

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var rezultat = konekcijaNaBazu.Korisnici.Where(Filtriraj).ToList();
            LoadData(rezultat);
        }

        private bool Filtriraj(Korisnik k)
        {
            return k.Ime.ToLower().Contains(txtPretraga.Text)
                || k.Prezime.ToLower().Contains(txtPretraga.Text);
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            if(e.ColumnIndex==5)
            {
                new KorisniciPolozeniPredmeti(korisnik).ShowDialog();
            }
        }
    }
}

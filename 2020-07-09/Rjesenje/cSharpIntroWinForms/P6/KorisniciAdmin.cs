using cSharpIntroWinForms.IB200054;
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
using System.Text.RegularExpressions;
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
            //txtPretraga.Select();
            UcitajSpolove();
        }

        private void UcitajSpolove()
        {
            cmbSpolovi.DataSource = konekcijaNaBazu.Spolovi.ToList();
            cmbSpolovi.DisplayMember = "Naziv";
            cmbSpolovi.ValueMember = "Id";
        }

        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici ?? konekcijaNaBazu.Korisnici.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==5)
            {
                var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
                new frmKorisnikSlikePregledIB200054(korisnik).ShowDialog();
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Filtriraj();
        }

        private void Filtriraj()
        {
            var odabraniSpol = cmbSpolovi.SelectedItem as Spolovi;
            var rezultat = konekcijaNaBazu.Korisnici.ToList().Where(x =>
            (x.Ime.ToLower().Contains(txtPretraga.Text) || x.Prezime.ToLower().Contains(txtPretraga.Text) || txtPretraga.Text=="")
            && (x.Spol.Id == odabraniSpol.Id ||x.Spol.Id == 3)
            && (x.Admin == cbAdministrator.Checked)).ToList();
            LoadData(rezultat);
        }

        private void cbAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            Filtriraj();
        }

        private void cmbSpolovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtriraj();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var lista = dgvKorisnici.DataSource as List<Korisnik>;
            new frmIzvjestaj(lista).ShowDialog();
        }

        private async void btnSuma_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                int broj = int.Parse(txtBroj.Text);
                long suma = 0;
                Action action = () => MessageBox.Show($"Suma: {suma}");
                await Task.Run(() =>
                {
                    for (int i = 0; i < broj; i++)
                    {
                        suma += i;
                    }
                    BeginInvoke(action);
                });
            }
            else
                MessageBox.Show("Unesite validan broj");
        }

        private bool Validiraj()
        {
            return Regex.IsMatch(txtBroj.Text, @"^\d+$");
        }
    }
}

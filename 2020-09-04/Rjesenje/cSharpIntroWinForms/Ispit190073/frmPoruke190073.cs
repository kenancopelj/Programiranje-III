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
    public partial class frmPoruke190073 : Form
    {
        KonekcijaNaBazu baza = DLWMS.DB;
        private Korisnik _korisnik;
        public frmPoruke190073()
        {
            InitializeComponent();
            _korisnik = new Korisnik();
            dgvPoruke.AutoGenerateColumns = false;
        }

        public frmPoruke190073(Korisnik korisnik) :this()
        {
            _korisnik = korisnik;
        }
        private void frmPoruke190073_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPoruke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }
        private void UcitajPoruke(List<KorisniciPoruke190073> lista=null)
        {
            var podaci = lista ?? baza.KorisniciPoruke.Where(x => x.Korisnik.Id == _korisnik.Id).ToList();
            dgvPoruke.DataSource = null;
            dgvPoruke.DataSource = podaci;
        }
        private void dgvPoruke_DoubleClick(object sender, EventArgs e)
        {
            var odabranaPoruka = dgvPoruke.SelectedRows[0].DataBoundItem as KorisniciPoruke190073;
            if(odabranaPoruka!=null)
            {
                frmNovaPoruka190073 forma = new frmNovaPoruka190073(odabranaPoruka);
                forma.ShowDialog();
            }
        }
        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaPoruka = dgvPoruke.Rows[e.RowIndex].DataBoundItem as KorisniciPoruke190073;
            var grid = (DataGridView)sender;
            if(odabranaPoruka!=null)
            {
                if(grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex>=0)
                {
                    if(MessageBox.Show($"Jeste li sigurni da zelite obrisati ovu poruku?", "Message for user",MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        baza.KorisniciPoruke.Remove(odabranaPoruka);
                        baza.SaveChanges();
                        UcitajPoruke();
                    }
                }
            }
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            frmNovaPoruka190073 forma = new frmNovaPoruka190073(_korisnik);
            if (forma.ShowDialog() == DialogResult.OK)
                UcitajPoruke();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var porukeKorisnika = baza.KorisniciPoruke.Where(x => x.Korisnik.Id == _korisnik.Id).ToList();
            var dtoObjekat = new dtoKorisnik();
            dtoObjekat.ImePrezime = _korisnik.Ime + " " + _korisnik.Prezime;
            dtoObjekat.ListaPoruka = porukeKorisnika;
            frmIzvjestaj190073 izvjestaj = new frmIzvjestaj190073(dtoObjekat);
            izvjestaj.ShowDialog();
        }
    }
}

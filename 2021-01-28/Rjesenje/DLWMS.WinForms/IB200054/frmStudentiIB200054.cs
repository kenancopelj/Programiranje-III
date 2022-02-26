using DLWMS.WinForms.DB;
using DLWMS.WinForms.P5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200054
{
    public partial class frmStudentiIB200054 : Form
    {
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        List<string> GodineStudija = new List<string>() { "Sve", "1", "2", "3", "4" };
        List<string> Aktivnosti = new List<string>() { "Svi", "Aktivni", "Neaktivni" };
        bool aktivnostParsed;
        int godinaStudijaParsed;
        public frmStudentiIB200054()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudentiIB200054_Load(object sender, EventArgs e)
        {
            UcitajCombo();
            UcitajStudente();
        }

        private void UcitajCombo()
        {
            cmbAktivnosti.DataSource = Aktivnosti;
            cmbGodineStudija.DataSource = GodineStudija;
        }

        private void UcitajStudente(List<Student> studenti =null)
        {
            var rezultat = studenti ?? baza.Studenti.ToList();
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = rezultat;
            lblBrojStudenata.Text = $"Broj studenata: {dgvStudenti.Rows.Count}";
            if(dgvStudenti.Rows.Count!=0)
                RacunajProsjek(rezultat);
            else
                lblProsjek.Text = $"Prosjecna ocjena: 0";
        }

        private void RacunajProsjek(List<Student> rezultat)
        {
            var studentiSaOcjenama = rezultat.Where(x => x.StudentiPredmeti?.Count > 0);
            var prosjek = studentiSaOcjenama.Average(x => (double?)x.StudentiPredmeti?.Average(p => p.Ocjena));
            lblProsjek.Text = $"Prosjecna ocjena: {Math.Round(prosjek.GetValueOrDefault(),2)}";
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Filtriraj();
        }

        private void Filtriraj()
        {
            if(Validiraj())
            {
                var rezultat = baza.Studenti.ToList().Where(x =>
                (string.IsNullOrEmpty(txtPretraga.Text) || (x.Ime.ToLower().Contains(txtPretraga.Text) || x.Prezime.ToLower().Contains(txtPretraga.Text)))
                && (cmbAktivnosti.Text == "Svi" || aktivnostParsed == x.Aktivan)
                && (cmbGodineStudija.Text == "Sve" || godinaStudijaParsed == x.GodinaStudija)).ToList();
                UcitajStudente(rezultat);
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtPretraga, err, Poruke.ObaveznaVrijednost);
        }

        private void cmbGodineStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGodineStudija.Text!="Sve")
            {
                godinaStudijaParsed = int.Parse(cmbGodineStudija.Text);
            }
            Filtriraj();
        }

        private void cmbAktivnosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAktivnosti.Text != "Svi")
                aktivnostParsed = cmbAktivnosti.Text == "Aktivni" ? true : false;
            Filtriraj();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var podaci = dgvStudenti.DataSource as List<Student>;
            new frmUvjerenjeIB200054(podaci).ShowDialog();
        }

        private void btnPotvrde_Click(object sender, EventArgs e)
        {
            new frmPotvrdeIB200054().ShowDialog();
        }
    }
}

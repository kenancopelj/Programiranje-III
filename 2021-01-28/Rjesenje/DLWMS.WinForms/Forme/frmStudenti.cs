using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        List<string> GodineStudija = new List<string>() { "Sve", "1", "2", "3", "4" };
        List<string> Aktivnosti = new List<string>() { "Svi", "Aktivni", "Neaktivni"};
        bool aktivnostParsed;
        int godinaStudijaParsed;

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            try
            {
                cmbGodineStudija.DataSource = GodineStudija;
                cmbAktivnosti.DataSource = Aktivnosti;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {          
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            try
            {
                var rezultat = studenti ?? _baza.Studenti.ToList();
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = rezultat;
                if (rezultat != null)
                {
                    RacunajProsjek(rezultat);
                    lblBrojStudenata.Text = $"Broj studenata: {dgvStudenti.Rows.Count}";
                }
                else
                {
                    lblBrojStudenata.Text = "Broj studenata: 0";
                    lblProsjecnaOcjena.Text = "Prosjecna ocjena: 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void RacunajProsjek(List<Student> rezultat)
        {
            var studentiSaOcjenama = rezultat.Where(x => x.Uspjeh?.Count > 0);
            var prosjecnaOcjena = studentiSaOcjenama.Average(x => (double?)x.Uspjeh?.Average(p => p.Ocjena));

            lblProsjecnaOcjena.Text = $"Prosjecna ocjena: {prosjecnaOcjena.GetValueOrDefault()}";

        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form form = null;
            if (student != null)
            {
                if (e.ColumnIndex == 6) 
                    form = new frmStudentiPredmeti(student);
                else
                    form = new frmNoviStudent(student);
                PrikaziFormu(form);

                UcitajPodatkeOStudentima();
            }
        }
        private bool PretragaStudenata(Student s)
        {
            return s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
                    || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower());
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            //var filter = txtPretraga.Text.ToLower();

            //UcitajPodatkeOStudentima(_baza.Studenti
            //  .Where(s => s.Ime.ToLower().Contains(filter)
            //      || s.Prezime.ToLower().Contains(filter)).ToList());
                Filtriraj();
        }

        private void cmbGodineStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGodineStudija.Text != "Sve")
            {
                godinaStudijaParsed = int.Parse(cmbGodineStudija.Text);
            }
            Filtriraj();
        }

        private void Filtriraj()
        {
            if (Validiraj())
            {
                try
                {
                    var rezultat = _baza.Studenti.ToList().Where(x => ((x.Ime.ToLower().Contains(txtPretraga.Text) || x.Prezime.ToLower().Contains(txtPretraga.Text))
                    || txtPretraga.Text == "")
                    && (cmbGodineStudija.Text == "Sve" || godinaStudijaParsed == x.GodinaStudija)
                    && (cmbAktivnosti.Text == "Svi" || aktivnostParsed == x.Aktivan)).ToList();
                    UcitajPodatkeOStudentima(rezultat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
                }
            }
        }

        private bool Validiraj()
        {
            if(string.IsNullOrEmpty(txtPretraga.Text))
            {
                errorProvider1.SetError(txtPretraga, "Obavezan unos");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private void cmbAktivnosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAktivnosti.Text != "Svi")
            {
                aktivnostParsed = cmbAktivnosti.Text == "Aktivni" ? true : false;
            }
            Filtriraj();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var studenti = dgvStudenti.DataSource as List<Student>;
            new frmIzvjestaji(studenti).ShowDialog();
        }

        private void btnPotvrde_Click(object sender, EventArgs e)
        {
            new frmPotvrde().ShowDialog();
        }
    }
}

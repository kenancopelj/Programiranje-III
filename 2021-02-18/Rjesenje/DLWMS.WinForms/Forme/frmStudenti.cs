using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
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
        List<string> Operatori = new List<string>() { "<", ">", "=", "<=", ">=" };
        List<string> Ocjene = new List<string>() {" ","6","7","8","9","10" };

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
            cmbOcjena.DataSource = Ocjene;
            cmbOperator.DataSource = Operatori;
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
                if(rezultat!=null)
                {
                    RacunajProsjek(rezultat);
                    lblBrojStudenata.Text = $"Broj studenata: {dgvStudenti.Rows.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException?.Message);
            }
        }

        private void RacunajProsjek(List<Student> rezultat)
        {
            var studentiSaOcjenama = rezultat.Where(x => x.StudentiPredmeti?.Count > 0);
            var prosjek = studentiSaOcjenama.Average(x => (double?)x.StudentiPredmeti.Average(p => p.Ocjena));
            lblProsjek.Text = $"Prosjecna ocjena {prosjek.GetValueOrDefault()}";
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

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtriraj();
        }

        private void Filtriraj()
        {
            if (Validiraj())
            {
                var datumOD = dtpDatumOD.Value;
                var datumDO = dtpDatumDO.Value;

                string operat = cmbOperator.Text;
                int ocjena = int.Parse(cmbOcjena.Text);

                var filterPoDatumu = _baza.StudentiPredmeti.ToList().Where(x => datumOD <= x.Datum && datumDO >= x.Datum).ToList();
                var filterPoOcjeniIDatumu = FiltrirajPoOcjeniIDatumu(filterPoDatumu,operat,ocjena);
                var studenti = filterPoOcjeniIDatumu.Select(x => x.Student).Distinct().ToList();
                UcitajPodatkeOStudentima(studenti);
            }
        }

        private List<StudentiPredmeti> FiltrirajPoOcjeniIDatumu(List<StudentiPredmeti> filterPoDatumu, string operacijaParsed, int ocjenaParsed)
        {
            switch (operacijaParsed)
            {
                case "<":
                    filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena < ocjenaParsed).ToList();
                    break;
                case ">":
                    filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena > ocjenaParsed).ToList();
                    break;
                case "=":
                    filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena == ocjenaParsed).ToList();
                    break;
                case "<=":
                    filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena <= ocjenaParsed).ToList();
                    break;
                case ">=":
                    filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena >= ocjenaParsed).ToList();
                    break;
            }
               return filterPoDatumu;
        }

        private bool Validiraj()
        {
            if(string.IsNullOrWhiteSpace(cmbOcjena.Text))
            {
                err.SetError(cmbOcjena, "Obavezno");
                return false;
            }
            err.Clear();
            return true;
        }

        private void cmbOcjena_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtriraj();
        }

        private void btnCovid_Click(object sender, EventArgs e)
        {
            new frmCovidTest().ShowDialog();
        }
    }
}

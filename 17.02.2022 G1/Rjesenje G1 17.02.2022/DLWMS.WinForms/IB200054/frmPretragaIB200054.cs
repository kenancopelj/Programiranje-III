using DLWMS.WinForms.DB;
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
    public partial class frmPretragaIB200054 : Form
    {
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        List<string> GodineStudija = new List<string>() { "1","2","3","4" };
        public frmPretragaIB200054()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretragaIB200054_Load(object sender, EventArgs e)
        {
            UcitajCombo();
        }

        private void UcitajCombo()
        {
            cmbGodinaStudija.DataSource = GodineStudija;
        }

        private void UcitajStudente(List<StudentiPodaci> podaci = null)
        {
            try
            {
                var rezultat = podaci ?? Svi();
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = rezultat;
                Text = $"Broj prikazanih studenata: {dgvPodaci.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException?.Message + Environment.NewLine);
            }
        }

        private List<StudentiPodaci> Svi()
        {
            var rezultat = new List<StudentiPodaci>();
            var studenti = baza.Studenti.ToList();
            for (int i = 0; i < studenti.Count; i++)
            {
                var prosjecna = studenti[i].Polozeni.Count() > 0 ?
                    baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).ToList().Average(x => x.Ocjena) : 0;
                rezultat.Add(new StudentiPodaci()
                {
                    Student = studenti[i],
                    GodinaStudija = studenti[i].GodinaStudija,
                    Prosjek = prosjecna
                });
            }
            return rezultat;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
                Filtriraj();
        }

        private void Filtriraj()
        {
            var rezultat = new List<StudentiPodaci>();
            var odabranaGodina = int.Parse(cmbGodinaStudija.Text);
            var studenti = baza.Studenti.ToList()
                .Where(x => (txtPretraga.Text == "" ||
                (x.Ime.ToLower().Contains(txtPretraga.Text) || x.Prezime.ToLower().Contains(txtPretraga.Text)))
            && odabranaGodina == x.GodinaStudija).ToList();
            for (int i = 0; i < studenti.Count; i++)
            {
                var prosjecna = studenti[i].Polozeni.Count() > 0 ?
                    baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).ToList().Average(x => x.Ocjena) : 0;
                rezultat.Add(new StudentiPodaci()
                {
                    Student = studenti[i],
                    GodinaStudija = studenti[i].GodinaStudija,
                    Prosjek = prosjecna
                });
            }
            UcitajStudente(rezultat);
        }

        private void cmbGodinaStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtriraj();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3)
            {
                var student = (dgvPodaci.SelectedRows[0].DataBoundItem as StudentiPodaci).Student;
                if (student != null)
                    new frmKonsultacijeIB200054(student).ShowDialog();
            }
        }
    }
}

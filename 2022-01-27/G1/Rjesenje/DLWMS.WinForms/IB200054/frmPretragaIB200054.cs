using DLWMS.WinForms.DB;
using DLWMS.WinForms.Reports;
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

namespace DLWMS.WinForms.IB200054
{
    public partial class frmPretragaIB200054 : Form
    {
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        public frmPretragaIB200054()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretragaIB200054_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke(List<StudentiPredmeti> podaci = null)
        {
            try
            {
                var rezultat = podaci ?? baza.StudentiPredmeti.ToList();
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = rezultat;
                this.Text = $"Broj zapisa: {dgvPodaci.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ex.InnerException?.Message + Environment.NewLine);
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPretraga.Text))
                Filtriraj();
            else
                UcitajPodatke();
        }

        private void Filtriraj()
        {
            try
            {
                var podaci = baza.StudentiPredmeti.ToList().Where(x => x.Predmet.Naziv.ToLower().Contains(txtPretraga.Text)).ToList();
                UcitajPodatke(podaci);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException?.Message + Environment.NewLine);
            }
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==4)
            {
                if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var predmet = dgvPodaci.SelectedRows[0].DataBoundItem as StudentiPredmeti;
                    if (predmet != null)
                    {
                        baza.StudentiPredmeti.Remove(predmet);
                        baza.SaveChanges();
                        UcitajPodatke();
                    }
                }
            }
            else if(e.ColumnIndex==5)
            {
                var student = (dgvPodaci.SelectedRows[0].DataBoundItem as StudentiPredmeti).Student;
                if (student != null)
                    new frmStudentiSlikeIB200054(student).ShowDialog();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var rezultat = dgvPodaci.DataSource as List<StudentiPredmeti>;
            if(rezultat!=null)
                new frmIzvjestaj(rezultat).ShowDialog();
        }

        private async void btnSumiraj_Click(object sender, EventArgs e)
        {
            if (ValidirajBrojeve())
            {
                var brojOD = int.Parse(txtBrojOD.Text);
                var brojDO = int.Parse(txtBrojDO.Text);
                long suma = 0;
                Action action = () =>
                {
                    MessageBox.Show("Uspjesno sumirano");
                    txtSuma.Text = $"{suma}";
                };
                await Task.Run(() =>
                {
                    for (int i = brojOD; i < brojDO; i++)
                    {
                        suma += i;
                    }
                    BeginInvoke(action);
                });
            }
        }

        private bool ValidirajBrojeve()
        {
            return Regex.IsMatch(txtBrojOD.Text, @"^\d+$") && Regex.IsMatch(txtBrojDO.Text, @"^\d+$");
        }
    }
}

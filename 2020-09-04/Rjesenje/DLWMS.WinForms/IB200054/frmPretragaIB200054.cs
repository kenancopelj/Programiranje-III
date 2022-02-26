using DLWMS.WinForms.DB;
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

        private void UcitajPodatke(List<StudentiPredmetiIB200054> lista = null)
        {
            try
            {
                var rezultat = lista ?? baza.StudentiPredmeti.ToList();
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = rezultat;
                if (dgvPodaci.Rows.Count != 0)
                    RacunajProsjek(rezultat);
                else
                    lblProsjek.Text = "Prosjek prikazanih ocjena: 0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException?.Message);
            }
        }

        private void RacunajProsjek(List<StudentiPredmetiIB200054> rezultat)
        {
            lblProsjek.Text = $"Prosjek prikazanih ocjena: {rezultat.Average(x => x.Ocjena)}";
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Filtriraj();
        }

        private void Filtriraj()
        {
            var rezultat = baza.StudentiPredmeti.ToList().Where(x => x.Predmet.Naziv.ToLower().Contains(txtPretraga.Text)).ToList();
            UcitajPodatke(rezultat);
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                var lista = dgvPodaci.SelectedRows[0].DataBoundItem as StudentiPredmetiIB200054;
                var student = lista.Student;
                new frmPorukeIB200054(student).ShowDialog();
            }
        }

        private async void btnSumiraj_Click(object sender, EventArgs e)
        {
            if(Validiraj())
            {
                long broj = long.Parse(txtBroj.Text);
                long suma = 0;
                Action action = () => lblSuma.Text = $"Suma: {suma}";
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
                MessageBox.Show("Broj nije validan");
        }

        private bool Validiraj()
        {
            return Regex.IsMatch(txtBroj.Text, @"^\d+$");
        }
    }
}

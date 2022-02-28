using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
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

namespace DLWMS.WinForms.Forme
{
    public partial class frmCovidTest : Form
    {
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        List<string> Rezultati = new List<string>() { "Pozitivan", "Negativan" };
        int brojTestova;
        public frmCovidTest()
        {
            InitializeComponent();
            dgvTestovi.AutoGenerateColumns = false;
        }

        private void frmCovidTest_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajTestove();
        }

        private void UcitajTestove()
        {
            try
            {
                dgvTestovi.DataSource = null;
                dgvTestovi.DataSource = baza.StudentiCovidTestovi.ToList();
                lblBrojTestova.Text = $"Broj testova: {dgvTestovi.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException?.Message);
            }
        }

        private void UcitajPodatke()
        {
            cmbStudenti.DataSource = baza.Studenti.ToList();
            cmbRezultat.DataSource = Rezultati;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(VecTestiran())
            {
                var noviTest = new StudentiCovidTestovi()
                {
                    Student = cmbStudenti.SelectedItem as Student,
                    Datum = dtpDatumTesta.Value.ToString(),
                    Rezultat = cmbRezultat.Text,
                    NalazDostavljen = cbDostavljen.Checked
                };
                baza.StudentiCovidTestovi.Add(noviTest);
                baza.SaveChanges();
                UcitajTestove();
            }
            else
                MessageBox.Show("Vec testiran danas!");
        }

        private bool VecTestiran()
        {
            var datum = dtpDatumTesta.Value.ToString();
            var odabraniStudent = cmbStudenti.SelectedItem as Student;
            foreach (var test in baza.StudentiCovidTestovi)
            {
                if (test.Student.Id == odabraniStudent.Id && test.Datum == datum)
                    return false;
            }
            return true;
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if(ValidirajBroj())
            {
                brojTestova = int.Parse(txtBrojTestova.Text);
                Action akcija = () =>
                {
                    UcitajTestove();
                    MessageBox.Show($"Uspjesno ucitano {brojTestova} testova!");
                };
                await Task.Run(() =>
                {
                    var rand = new Random();
                    for (int i = 0; i < brojTestova; i++)
                    {
                        var rezultat = rand.NextDouble() > 0.5 ? "Pozitivan" : "Negativan";
                        baza.StudentiCovidTestovi.Add(new StudentiCovidTestovi()
                        {
                            Student = baza.Studenti.Find(rand.Next(1,baza.Studenti.Count()-1)),
                            Rezultat = rezultat,
                            NalazDostavljen = rand.NextDouble() > 0.5,
                            Datum = DateTime.Now.ToString()
                        });
                    }
                    baza.SaveChanges();
                    BeginInvoke(akcija);
                });
            }
            else
                MessageBox.Show("Broj testova nije validan");
        }

        private bool ValidirajBroj() => Regex.IsMatch(txtBrojTestova.Text, @"^\d+$");

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da zelite obrisati sve podatke o COVID testovima?", "Pitanje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int trenutnoTestova = dgvTestovi.Rows.Count;
                Action akcija = () => 
                {
                    UcitajTestove();
                    MessageBox.Show($"Uspjesno obrisano {trenutnoTestova} testova!");
                };
                await Task.Run(() =>
                {
                    baza.StudentiCovidTestovi.RemoveRange(baza.StudentiCovidTestovi);
                    baza.SaveChanges();
                    BeginInvoke(akcija);
                });
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var studentiTestovi = dgvTestovi.DataSource as List<StudentiCovidTestovi>;
            new frmIzvjestaji(studentiTestovi).ShowDialog();
        }
    }
}

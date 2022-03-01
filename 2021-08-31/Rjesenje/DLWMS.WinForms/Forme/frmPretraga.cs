using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmPretraga : Form
    {
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        List<string> znakovi = new List<string>() { "?", "!", "<", ">", "*" };
        List<string> samoglasnici = new List<string>() { "a", "e", "i", "o", "u" };
        public frmPretraga()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke(List<StudentiPodaci> studenti = null)
        {
            try
            {
                var rezultat = studenti ?? UcitajSve();
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = rezultat;
                if ((dgvPodaci.DataSource as List<StudentiPodaci>).Count>0)
                    RacunajProsjek(rezultat);
                else
                    {
                        lblProsjecnaOcjena.Text = "0";
                        lblStudentSaNajProsjekom.Text = "NOT SET";
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void RacunajProsjek(List<StudentiPodaci> rezultat)
        {
            var imeStudenta = "";
            double prosjek = 0.0f;
            for (int i = 0; i < rezultat.Count; i++)
            {
                if (rezultat[i].Prosjek > prosjek) 
                {
                    prosjek = rezultat[i].Prosjek;
                    imeStudenta = $"{rezultat[i].Student}";
                }
            }
            lblProsjecnaOcjena.Text = $"{Math.Round(rezultat.Average(x=>x.Prosjek),2)}";
            lblStudentSaNajProsjekom.Text = $"{imeStudenta}";
        }

        private List<StudentiPodaci> UcitajSve()
        {
            var rezultat = baza.StudentiPredmeti.ToList().Select(x => x.Student).Distinct().ToList();
            var lista = new List<StudentiPodaci>();

            for (int i = 0; i < rezultat.Count; i++)
            {
                lista.Add(new StudentiPodaci
                {
                    Student = rezultat[i],
                    PolozeniPredmeti = string.Join(";", baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == rezultat[i].Id).Select(x => x.Predmet.Naziv).ToList()),
                    BrojPolozenih = baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == rezultat[i].Id).Count(),
                    Prosjek = baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == rezultat[i].Id).Average(x => x.Ocjena)
                });
            }
            return lista;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPretraga.Text))
            {
                var rezultat = baza.StudentiPredmeti.Where(x => x.Student.Ime.ToLower().Contains(txtPretraga.Text)
                || x.Student.Prezime.ToLower().Contains(txtPretraga.Text)).ToList().Select(x => x.Student).Distinct().ToList();
                var lista = new List<StudentiPodaci>();

                for (int i = 0; i < rezultat.Count; i++)
                {
                    lista.Add(new StudentiPodaci
                    {
                        Student = rezultat[i],
                        PolozeniPredmeti = string.Join(";", baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == rezultat[i].Id).Select(x => x.Predmet.Naziv).ToList()),
                        BrojPolozenih = baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == rezultat[i].Id).Count(),
                        Prosjek = baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == rezultat[i].Id).Average(x => x.Ocjena)
                    });
                }
                UcitajPodatke(lista);
            }
            else
                UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rezultat = dgvPodaci.SelectedRows[0].DataBoundItem as StudentiPodaci;
            var student = rezultat.Student;
            if(e.ColumnIndex == 4)
            {
                new frmScanIspita(student).ShowDialog();
            }
        }

        private async void btnGenerisiInfo_Click(object sender, EventArgs e)
        {
            int brojacSamoglasnika = 0;
            int brojacZnakova = 0;
            int brojacSuglasnika = 0;

            Action action = () =>
            lblSadrzaj.Text = $"Samoglasnici: {brojacSamoglasnika}{Environment.NewLine}" +
            $"Suglasnici: {brojacSuglasnika}{Environment.NewLine}" +
            $"Znakovi: {brojacZnakova}{Environment.NewLine}";

            await Task.Run(() =>
            {
                brojacSamoglasnika = txtSadrzaj.Text.ToLower().Where(x => samoglasnici.Contains(x.ToString())).Count();
                brojacZnakova = txtSadrzaj.Text.ToLower().Where(x => znakovi.Contains(x.ToString())).Count();
                brojacSuglasnika = txtSadrzaj.Text.Length - brojacSamoglasnika - brojacZnakova;
            });
            BeginInvoke(action);
        }
    }
}

using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmPotvrde : Form
    {
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        int brojPotvrda;
        public frmPotvrde()
        {
            InitializeComponent();
            dgvPotvrde.AutoGenerateColumns = false;
        }

        private void frmPotvrde_Load(object sender, EventArgs e)
        {
            UcitajPotvrde();
        }

        private void UcitajPotvrde()
        {
            try
            {
                dgvPotvrde.DataSource = null;
                dgvPotvrde.DataSource = baza.StudentiPotvrde.ToList();
                lblTrenutno.Text = $"Trenutno potvrda: {dgvPotvrde.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if(brojPotvrda==0)
            {
                MessageBox.Show("Unesite broj potvrda");
                return;
            }
            Action action = () =>
            {
                UcitajPotvrde();
                MessageBox.Show($"Uspjesno ucitano {brojPotvrda} potvrda!");
            };
            await Task.Run(() =>
            {
                var rand = new Random();
                for (int i = 0; i < brojPotvrda; i++)
                {
                    baza.StudentiPotvrde.Add(new StudentiPotvrde()
                    {
                        Student = baza.Studenti.Find(rand.Next(1, baza.Studenti.Count() - 1)),
                        Datum = DateTime.Now.ToString(),
                        Svrha = $"Regulisanje statusa_{i}",
                        Izdata = rand.NextDouble()>0.5
                    });
                }
                baza.SaveChanges();
                BeginInvoke(action);
            });
        }

        private void txtBrojPotvrda_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBrojPotvrda.Text))
            {
                if (Regex.IsMatch(txtBrojPotvrda.Text, @"^\d+$"))
                {
                    brojPotvrda = int.Parse(txtBrojPotvrda.Text);
                }
                else
                {
                    MessageBox.Show("Samo brojevi");
                    txtBrojPotvrda.Text = "";
                    brojPotvrda = 0;
                }
            }
            else
                brojPotvrda = 0;
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Pitanje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Action action = () =>
                {
                  UcitajPotvrde();
                  MessageBox.Show("Potvrde uspjesno obrisane");
                };
                await Task.Run(() =>
                {
                    baza.StudentiPotvrde.RemoveRange(baza.StudentiPotvrde);
                    baza.SaveChanges();
                    BeginInvoke(action);
                });
            }
        }

        private void btnSpasiUFajl_Click(object sender, EventArgs e)
        {
            string imeFajla = "ib200054.csv";
            SaveCSV(imeFajla);
            MessageBox.Show($"Uspješno spašeno u fajl {imeFajla}");
        }
        public void SaveCSV(string putanja)
        {
            using (StreamWriter sw = File.AppendText(putanja))
            {
                foreach (var potvrda in baza.StudentiPotvrde)
                {
                    var izdata = potvrda.Izdata ? "Da" : "Ne";
                    sw.WriteLine(potvrda.Student + "," + potvrda.Datum + "," + potvrda.Svrha + "," + izdata);
                }

                sw.Close();
            }
        }
    }
}

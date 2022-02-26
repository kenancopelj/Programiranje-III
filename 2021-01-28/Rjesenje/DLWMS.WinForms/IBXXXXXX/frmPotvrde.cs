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
using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;

namespace DLWMS.WinForms.IBXXXXXX
{
    public partial class frmPotvrde : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        int brojPotvrda = 0;
        Student student;
        List<Potvrda> potvrde;
        public frmPotvrde()
        {
            InitializeComponent();
            this.CenterToScreen(); // Prikaze formu na sredinii ekrana
        }

        private void frmPotvrde_Load(object sender, EventArgs e)
        {
            dgvPotvrde.AutoGenerateColumns = false;
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            potvrde = _baza.Potvrde.ToList();
            lblBrojPotvrda.Text = $"Broj prikazanih potvrda: {potvrde.Count}";
            dgvPotvrde.DataSource = null;
            dgvPotvrde.DataSource = potvrde;
            
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if(brojPotvrda==0)
            {
                MessageBox.Show("Unesite koliko zelize potvrda generisati");
                return;
            }
            Action action = () => ucitajPodatke();
            await Task.Run(() =>
            {
                for (int i = 0; i < brojPotvrda; i++)
                {
                    Random rand = new Random();
                    int toSkip = rand.Next(1, _baza.Studenti.Count()-1);
                    var potvrda = new Potvrda()
                    {
                        Student = _baza.Studenti.ToList().ElementAt(toSkip),//uzima random studenta iz baze
                        Datum = DateTime.Now.ToString(),
                        Izdata = rand.NextDouble() > 0.5, //generise random bool vrijednost
                        Svrha = "Stipendija"
                    };
                    _baza.Potvrde.Add(potvrda);
                }
                _baza.SaveChanges();
                BeginInvoke(action);
            });
        }

        private void txtBrojPotvrda_TextChanged(object sender, EventArgs e)
        {
            if(txtBrojPotvrda.TextLength>0)
            {
                if(Regex.IsMatch(txtBrojPotvrda.Text, @"^\d+$"))// preovjerava da li je unos broj
                {
                    brojPotvrda = int.Parse(txtBrojPotvrda.Text);
                }
                else
                {
                    MessageBox.Show("Dozvoljeni su samo brojevi");
                    txtBrojPotvrda.Text = "";
                    brojPotvrda = 0;
                }
            }
            else
            {
                brojPotvrda = 0;
            }
        }

        private async void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if(potvrde.Count==0)
            {
                MessageBox.Show("Nema potvrda za izbrisat");
                return;
            }

            var frm = new frmPotvrdiBrisanje();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Action action = () => ucitajPodatke();
                await Task.Run(() =>
                {
                    _baza.Potvrde.RemoveRange(_baza.Potvrde);// RemoveRange brise sve elemente prosljedjenog DB seta
                    _baza.SaveChanges();
                    BeginInvoke(action);
                });
            }
            else
                return;
        }
        //Primjer funkcije postoji u FileStructures delimiterDemo
        public static void SaveCSV(string putanja) 
        {
            using (StreamWriter sw = File.AppendText(putanja))
            {
                foreach (var potvrda in DLWMSdb.Baza.Potvrde)
                {
                    sw.WriteLine(potvrda.Id + "," + potvrda.Student + "," + potvrda.Svrha + "," + potvrda.Datum + "," + potvrda.Izdata);
                }

                sw.Close();
            }
        }
        private void btnFajl_Click(object sender, EventArgs e)
        {
            SaveCSV(@"Potvrde.csv");
        }
    }
}

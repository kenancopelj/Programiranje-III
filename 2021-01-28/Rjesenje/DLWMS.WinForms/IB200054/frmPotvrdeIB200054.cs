using DLWMS.WinForms.DB;
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

namespace DLWMS.WinForms.IB200054
{
    public partial class frmPotvrdeIB200054 : Form
    {
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        public frmPotvrdeIB200054()
        {
            InitializeComponent();
            dgvPotvrde.AutoGenerateColumns = false;
        }

        private void frmPotvrdeIB200054_Load(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException?.Message);
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if(Validiraj())
            {
                long brojPotvrda = long.Parse(txtBrojPotvrda.Text);
                Action action = () => UcitajPotvrde();
                await Task.Run(() =>
                {
                    var rand = new Random();
                    for (int i = 0; i < brojPotvrda; i++)
                    {
                        baza.StudentiPotvrde.Add(new StudentiPotvrdeIB200054()
                        {
                            Student = baza.Studenti.ToList().ElementAt(rand.Next(0,baza.Studenti.Count()-1)),
                            Datum = DateTime.Now.ToString(),
                            Svrha = $"Regulisanje statusa_{i}",
                            Izdata = rand.NextDouble()>0.5
                        });
                    }
                    baza.SaveChanges();
                    BeginInvoke(action);
                });
            }
            else
                MessageBox.Show("Vrijednost nije validna");
        }

        private bool Validiraj()
        {
            return Regex.IsMatch(txtBrojPotvrda.Text, @"^\d+$");
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?","Pitanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Action action = () => UcitajPotvrde();
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
            SaveCSV("potvrdeIB200054.csv");
        }

        private void SaveCSV(string putanja)
        {
            using (StreamWriter sw = File.AppendText(putanja))
            {
                foreach (var potvrda in baza.StudentiPotvrde)
                {
                    var izdata = potvrda.Izdata ? "Da" : "Ne";
                    sw.WriteLine(potvrda.Student + "," + potvrda.Svrha + "," + potvrda.Datum + "," + izdata);
                }
                sw.Close();
            }
        }
    }
}

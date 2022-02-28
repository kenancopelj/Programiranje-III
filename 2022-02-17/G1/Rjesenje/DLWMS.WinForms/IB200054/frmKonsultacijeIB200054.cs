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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200054
{
    public partial class frmKonsultacijeIB200054 : Form
    {
        private Student student;
        KonekcijaNaBazu baza = DLWMSdb.Baza;

        public frmKonsultacijeIB200054()
        {
            InitializeComponent();
            dgvKonsultacije.AutoGenerateColumns = false;
        }

        public frmKonsultacijeIB200054(Student student):this()
        {
            this.student = student;
        }

        private void frmKonsultacijeIB200054_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajPredmete();
            lblStudent.Text = $"Lista zahtjeva za konsultacije studenta: {student}";
        }

        private void UcitajPredmete()
        {
            cmbPredmet.DataSource = baza.Predmeti.ToList();
            cmbPredmet.ValueMember = "Id";
            cmbPredmet.DisplayMember = "Naziv";
        }

        private void UcitajPodatke()
        {
            try
            {
                dgvKonsultacije.DataSource = null;
                dgvKonsultacije.DataSource = student.Konsultacije;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException?.Message + Environment.NewLine);
            }
        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            if (new frmNovaKonsultacijaIB200054(student).ShowDialog() == DialogResult.OK)
                UcitajPodatke();
        }

        private void dgvKonsultacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3)
            {
                var konsultacija = dgvKonsultacije.SelectedRows[0].DataBoundItem as StudentiKonsultacije;
                if (MessageBox.Show("Da li sigurni da zelite obrisati ovaj podatak?","Pitanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if (DateTime.Now < konsultacija.VrijemeOdrzavanja)
                    {
                        baza.StudentiKonsultacije.Remove(konsultacija);
                        baza.SaveChanges();
                        UcitajPodatke();
                    }
                    else
                        MessageBox.Show("Nije moguce obrisati konsultacije koje su već održane","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            new frmIzvjestaj(student).ShowDialog();
        }

        private async void btnDodajAsync_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                int broj = int.Parse(txtBrojZahtjeva.Text);
                var odabraniStudent = student;
                var odabraniPredmet = cmbPredmet.SelectedItem as Predmeti;
                Action akcija = () =>
                {
                    UcitajPodatke();
                    MessageBox.Show("Dodavanje završeno","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                };
                await Task.Run(() =>
                {
                    for (int i = 0; i < broj; i++)
                    {
                        Thread.Sleep(500);
                        var datum = DateTime.Now;
                        baza.StudentiKonsultacije.Add(new StudentiKonsultacije()
                        {
                            Student = odabraniStudent,
                            Predmeti = odabraniPredmet,
                            Napomena = $"Zahtjev za konsultacije {i + 1}",
                            VrijemeOdrzavanja = datum
                        });
                        Action action = () => PrikaziInfo($"Za {student} dodat zahtjev za konsultacijama -> {odabraniPredmet}({datum})");
                        BeginInvoke(action);
                    }
                    baza.SaveChanges();
                    BeginInvoke(akcija);
                });
            }
            else
                MessageBox.Show("Broj nije validan","Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private bool Validiraj()
        {
            return Regex.IsMatch(txtBrojZahtjeva.Text, @"^\d+$");
        }

        private void PrikaziInfo(string poruka)
        {
            txtInfo.Text += poruka + Environment.NewLine;
        }
    }
}

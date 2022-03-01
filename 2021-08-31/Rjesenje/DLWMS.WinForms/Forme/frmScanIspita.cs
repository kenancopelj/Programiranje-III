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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmScanIspita : Form
    {
        private Student student;
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        public frmScanIspita()
        {
            InitializeComponent();
            dgvStudentIspiti.AutoGenerateColumns = false;
        }

        public frmScanIspita(Student student) : this()
        {
            this.student = student;
        }

        private void frmScanIspita_Load(object sender, EventArgs e)
        {
            lblTrenutniStudent.Text = $"{student}";
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dgvStudentIspiti.DataSource = null;
            dgvStudentIspiti.DataSource = student.Ispiti;
        }

        private void dgvStudentIspiti_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ispit = dgvStudentIspiti.SelectedRows[0].DataBoundItem as KorisniciIspitScan;
            Form forma;
            if (e.ColumnIndex == 4)
            {
                baza.KorisniciIspitScan.Remove(ispit);
                baza.SaveChanges();
                UcitajPodatke();
            }
            else
            {
                forma = new frmNoviScanIspita(ispit);
                forma.ShowDialog();
            }
        }

        private void btnDodajScan_Click(object sender, EventArgs e)
        {
            if (new frmNoviScanIspita(student).ShowDialog() == DialogResult.OK)
                UcitajPodatke();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var rezultat = new dtoUvjerenje()
            {
                ImePrezime = student.ToString(),
                Ispiti = dgvStudentIspiti.DataSource as List<KorisniciIspitScan>
            };
            new frmIzvjestaji(rezultat).ShowDialog();
        }
    }
    public class dtoUvjerenje
    {
        public string ImePrezime { get; set; }
        public List<KorisniciIspitScan> Ispiti { get; set; }
    }
}

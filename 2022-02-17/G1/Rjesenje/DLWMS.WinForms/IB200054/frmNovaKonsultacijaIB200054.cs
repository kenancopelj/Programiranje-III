using DLWMS.WinForms.DB;
using DLWMS.WinForms.P5;
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
    public partial class frmNovaKonsultacijaIB200054 : Form
    {
        private Student student;
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        public frmNovaKonsultacijaIB200054()
        {
            InitializeComponent();
        }

        public frmNovaKonsultacijaIB200054(Student student):this()
        {
            this.student = student;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(Validiraj())
            {
                var noveKonsultacije = new StudentiKonsultacije()
                {
                    Student = student,
                    Predmeti = cmbPredmet.SelectedItem as Predmeti,
                    Napomena = txtNapomena.Text,
                    VrijemeOdrzavanja = dtpVrijeme.Value
                };
                baza.StudentiKonsultacije.Add(noveKonsultacije);
                baza.SaveChanges();
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(cmbPredmet,errorProvider1,Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtNapomena, errorProvider1, Poruke.ObaveznaVrijednost);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNovaKonsultacijaIB200054_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
        }
        private void UcitajPredmete()
        {
            cmbPredmet.DataSource = baza.Predmeti.ToList();
            cmbPredmet.ValueMember = "Id";
            cmbPredmet.DisplayMember = "Naziv";
        }
    }
}

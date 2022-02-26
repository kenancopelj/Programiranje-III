using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
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
    public partial class frmNovaPorukaIB200054 : Form
    {
        private KorisniciPorukeIB200054 poruka;
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        private bool Pregled = false;
        private Student student;

        public frmNovaPorukaIB200054()
        {
            InitializeComponent();
        }

        public frmNovaPorukaIB200054(KorisniciPorukeIB200054 poruka):this()
        {
            this.poruka = poruka;
            Pregled = true;
        }

        public frmNovaPorukaIB200054(Student student):this()
        {
            this.student = student;
            Pregled = false;
        }

        private void frmNovaPorukaIB200054_Load(object sender, EventArgs e)
        {
            if (Pregled)
            {
                ZakljucajKontrole();
                UcitajPoruku();
            }
            else
                txtPrimalac.Text = student.ToString();

        }

        private void UcitajPoruku()
        {
            txtPrimalac.Text = poruka.Student.ToString();
            txtSadrzaj.Text = poruka.Sadrzaj;
            if(poruka.Slika!=null)
                pbSlika.Image = ImageHelper.FromByteToImage(poruka.Slika);
        }

        private void ZakljucajKontrole()
        {
            pbSlika.Enabled = false;
            txtSadrzaj.Enabled = false;
            btnSpasi.Enabled = false;
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if(Validiraj())
            {
                var novaPoruka = new KorisniciPorukeIB200054();
                novaPoruka.Student = student;
                novaPoruka.Sadrzaj = txtSadrzaj.Text;
                novaPoruka.Slika = pbSlika.Image == null ? null : ImageHelper.FromImageToByte(pbSlika.Image);
                novaPoruka.DatumVrijeme = DateTime.Now.ToString();
                baza.KorisniciPoruke.Add(novaPoruka);
                baza.SaveChanges();
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtSadrzaj, err, Poruke.ObaveznaVrijednost);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}

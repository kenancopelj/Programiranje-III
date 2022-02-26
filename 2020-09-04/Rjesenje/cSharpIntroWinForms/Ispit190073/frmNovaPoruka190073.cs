using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.Ispit190073
{
    public partial class frmNovaPoruka190073 : Form
    {
        private KorisniciPoruke190073 _poruka;
        private Korisnik _korisnik;
        private bool DoubleClick = false;
        private bool NewMessage = false;
        private KonekcijaNaBazu baza = DLWMS.DB;
        public frmNovaPoruka190073()
        {
            InitializeComponent();
            _poruka = new KorisniciPoruke190073();
        }
        public frmNovaPoruka190073(Korisnik korisnik) : this()
        {
            _korisnik = korisnik;
            NewMessage = true;
        }
        public frmNovaPoruka190073(KorisniciPoruke190073 poruka) : this()
        {
            _poruka = poruka;
            DoubleClick = true;
        }


        private void frmNovaPoruka190073_Load(object sender, EventArgs e)
        {
            if (DoubleClick)
                LoadOnDoubleClick(_poruka);
            else
                LoadNewMessage();
        }



        private void LoadNewMessage()
        {
            txtPrimalac.Text = _korisnik.ToString();
            txtSadrzaj.Enabled = true;
            pbSlika.Image = null;
        }
        private void LoadOnDoubleClick(KorisniciPoruke190073 poruka)
        {
                txtPrimalac.Text = _poruka.Korisnik.ToString();
                txtSadrzaj.Text = _poruka.Sadrzaj;
                txtSadrzaj.Enabled = false;
                if (_poruka.Slika != null)
                    pbSlika.Image = ImageConventer190073.FromByteToImage(_poruka.Slika);
                else
                    pbSlika.Image = null;
        }
        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if(ValidacijaPolja())
            {
                byte[] slika = null;
                if (pbSlika.Image != null)
                    slika = ImageConventer190073.FromImageToByte(pbSlika.Image);
                _korisnik.ListaPoruka.Add(new KorisniciPoruke190073()
                {
                    DatumSlanja = DateTime.Now.ToString(),
                    Sadrzaj=txtSadrzaj.Text,
                    Slika = slika
                });
                baza.SaveChanges();
                MessageBox.Show($"Nova poruka uspjesno dodana!");
                DialogResult = DialogResult.OK;
            }
        }
        private void pbSlika_Click(object sender, EventArgs e)
        {
            if(ofdPutanjaDoSlike.ShowDialog() == DialogResult.OK)
            {
                string putanja = ofdPutanjaDoSlike.FileName;
                pbSlika.Image= Image.FromFile(putanja);
            }
        }
        private bool ValidacijaPolja()
        {
            return Validator190073.ValidirajPolje(txtSadrzaj, err, "This field is required!");
        }
    }
}

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

namespace cSharpIntroWinForms.IB200054
{
    public partial class frmKorisnikSlikePregledIB200054 : Form
    {
        private Korisnik korisnik;
        KonekcijaNaBazu baza = DLWMS.DB;
        private int indekserSlike = 0;

        public frmKorisnikSlikePregledIB200054()
        {
            InitializeComponent();
        }

        public frmKorisnikSlikePregledIB200054(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }

        private void frmKorisnikSlikePregledIB200054_Load(object sender, EventArgs e)
        {
            UcitajSlike();
        }

        private void UcitajSlike()
        {
            if(korisnik.SlikeKorisnika.Count!=0)
            {
                var prvaSlika = korisnik.SlikeKorisnika[indekserSlike];
                pbSlika.Image = ImageHelper.FromByteToImage(prvaSlika.Slika._Slika);
            }
            else
                MessageBox.Show("Korisnik nema ni jednu sliku, klikni pb da dodas");
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                var novaSlika = new Slika();
                novaSlika._Slika = ImageHelper.FromImageToByte(Image.FromFile(openFileDialog1.FileName));
                korisnik.SlikeKorisnika.Add(new KorisniciSlike()
                {
                    Slika = novaSlika
                });
                baza.SaveChanges();
                MessageBox.Show("Slika usjesno spasena");
                UcitajSlike();
            }
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            var provjeraIndeksa = indekserSlike + 1;
            if(provjeraIndeksa <=korisnik.SlikeKorisnika.Count()-1)
            {
                indekserSlike++;
                pbSlika.Image = ImageHelper.FromByteToImage(korisnik.SlikeKorisnika[indekserSlike].Slika._Slika);
            }
            else
                MessageBox.Show("Nema slike desno");
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            var provjeraIndeksa = indekserSlike - 1;
            if(provjeraIndeksa>=0)
            {
                indekserSlike--;
                pbSlika.Image = ImageHelper.FromByteToImage(korisnik.SlikeKorisnika[indekserSlike].Slika._Slika);
            }
            else
                MessageBox.Show("Nema slike lijevo");
        }
    }
}

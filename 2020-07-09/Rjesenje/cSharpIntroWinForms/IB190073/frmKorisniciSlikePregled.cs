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

namespace cSharpIntroWinForms.IB190073
{
    public partial class frmKorisniciSlikePregled : Form
    {
        private Korisnik korisnik;
        private KonekcijaNaBazu baza = DLWMS.DB;
        private int IndekserSlike = 0;
        public frmKorisniciSlikePregled()
        {
            InitializeComponent();
        }

        public frmKorisniciSlikePregled(Korisnik objekat) : this()
        {
            korisnik = objekat;
        }

        private void frmKorisniciSlikePregled_Load(object sender, EventArgs e)
        {
            UcitajSliku();
        }
        private void UcitajSliku()
        {
            if (korisnik.SlikeKorisnika.Count() != 0)
            {
                var prvaSlika = korisnik.SlikeKorisnika[IndekserSlike];
                pbTrenutnaSlika.Image = ImageHelper.FromByteToImage(prvaSlika.Slika.NizBajtovaSlike);
            }
            else
                MessageBox.Show($"Korisnik jos nema nijednu sliku,kliknite na picture box da dodate!");
        }
        private void pbTrenutnaSlika_Click(object sender, EventArgs e)
        {
            if(ofdDodajSliku.ShowDialog() == DialogResult.OK)
            {
                var novaSlika = new Slika();
                novaSlika.NizBajtovaSlike = ImageHelper.FromImageToByte(Image.FromFile(ofdDodajSliku.FileName));
                korisnik.SlikeKorisnika.Add(new KorisniciSlike()
                {
                    Slika = novaSlika
                });
                baza.SaveChanges();
                MessageBox.Show($"Slika uspjesno spasena!");
                UcitajSliku();
            }
        }
        private void btnNaprijed_Click(object sender, EventArgs e)
        {
            var provjeraIndeksera = IndekserSlike + 1;
            if (provjeraIndeksera<=korisnik.SlikeKorisnika.Count()-1)
            {
                IndekserSlike++;
                pbTrenutnaSlika.Image = ImageHelper.FromByteToImage(korisnik.SlikeKorisnika[IndekserSlike].Slika.NizBajtovaSlike);
            }else
                MessageBox.Show($"Pokusavate pristupiti slici koja ne postoji!");
        }
        private void btnNazad_Click(object sender, EventArgs e)
        {
            var provjeraIndeksera = IndekserSlike - 1;
            if (provjeraIndeksera>=0)
            {
                IndekserSlike--;
                pbTrenutnaSlika.Image = ImageHelper.FromByteToImage(korisnik.SlikeKorisnika[IndekserSlike].Slika.NizBajtovaSlike);
            }else
                MessageBox.Show($"Pokusavate pristupiti slici koja ne postoji!");
        }
    }
}

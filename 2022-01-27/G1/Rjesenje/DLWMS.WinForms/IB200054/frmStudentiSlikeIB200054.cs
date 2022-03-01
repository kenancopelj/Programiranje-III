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
    public partial class frmStudentiSlikeIB200054 : Form
    {
        private Student student;
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        private int BrojacSlike=0;
        public frmStudentiSlikeIB200054()
        {
            InitializeComponent();
        }

        public frmStudentiSlikeIB200054(Student student) :this()
        {
            this.student = student;
        }

        private void frmStudentiSlikeIB200054_Load(object sender, EventArgs e)
        {
            UcitajSlike();
        }

        private void UcitajSlike()
        {
            try
            {
                if (student.StudentiSlike.Count() != 0)
                {
                    UcitajSlikuSaIndeksom(0);
                }
                else
                {
                    MessageBox.Show("Student jos nema slika!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ex.InnerException?.Message+Environment.NewLine);
            }
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            if(Validiraj())
            {
                var novaSlika = new StudentiSlike()
                {
                    Slike = new Slike()
                    {
                        Slika = ImageHelper.FromImageToByte(pbSlikaZaDodati.Image)
                    },
                    Opis = txtOpis.Text,
                    Datum = DateTime.Now.ToString(),
                    Student = student
                };
                baza.StudentiSlike.Add(novaSlika);
                baza.SaveChanges();
                UcitajSlike();
                Reset();
            }
        }

        private void Reset()
        {
            pbSlikaZaDodati.Image = null;
            txtOpis.Clear();
            BrojacSlike = 0;
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtOpis, errorProvider1, Poruke.ObaveznaVrijednost);
        }

        private void pbSlikaZaDodati_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbSlikaZaDodati.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSljedeca_Click(object sender, EventArgs e)
        {
            if(BrojacSlike+1>=0 && BrojacSlike+1<student.StudentiSlike.Count())
            {
                BrojacSlike++;
                UcitajSlikuSaIndeksom(BrojacSlike);
            }
            else
                MessageBox.Show("Nema sljedece slike!");
        }

        private void UcitajSlikuSaIndeksom(int indeks)
        {
            var trenutnaSlika = student.StudentiSlike[indeks];
            pbTrenutnaSlika.Image = ImageHelper.FromByteToImage(trenutnaSlika.Slike.Slika);
            txtOpisTrenutneSlike.Text = trenutnaSlika.Opis;
            lblDatum.Text = trenutnaSlika.Datum;
            lblBrojSlike.Text = $"{indeks + 1}/{student.StudentiSlike.Count()}"; ;
        }

        private void btnPrethodna_Click(object sender, EventArgs e)
        {
            if (BrojacSlike -1 >= 0 && BrojacSlike - 1 < student.StudentiSlike.Count())
            {
                BrojacSlike--;
                UcitajSlikuSaIndeksom(BrojacSlike);
            }
            else
                MessageBox.Show("Nema prethodne slike!");
        }
    }
}

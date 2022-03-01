using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
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
    public partial class frmNoviScanIspita : Form
    {
        private KorisniciIspitScan ispit;
        private bool VecPostojeci=false;
        private Student student;
        KonekcijaNaBazu baza = DLWMSdb.Baza;

        public frmNoviScanIspita()
        {
            InitializeComponent();
        }

        public frmNoviScanIspita(KorisniciIspitScan ispit):this()
        {
            this.ispit = ispit;
            VecPostojeci = true;
            Zakljucaj();
        }

        public frmNoviScanIspita(Student student) : this()
        {
            this.student = student;
        }

        private void Zakljucaj()
        {
            cmbPredmeti.Enabled = false;
            txtNapomena.ReadOnly = true;
            cbVaranje.Enabled = false;
            pbScan.Enabled = false;
            btnSpasi.Enabled = false;
        }

        private void frmNoviScanIspita_Load(object sender, EventArgs e)
        {
            UcitajIspit();
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = baza.Predmet.ToList();
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DisplayMember = "Naziv";
        }

        private void UcitajIspit()
        {
            if(VecPostojeci)
            {
                cmbPredmeti.Text = ispit.Predmet.Naziv;
                if(ispit.Sken!=null)    
                    pbScan.Image = ImageHelper.FromByteToImage(ispit.Sken);
                txtNapomena.Text = ispit.Napomena;
                cbVaranje.Checked = ispit.Varanje;
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            var noviSken = new KorisniciIspitScan();
            if (pbScan.Image == null)
            {
                noviSken.Student = student;
                noviSken.Varanje = cbVaranje.Checked;
                noviSken.Napomena = txtNapomena.Text;
                noviSken.Sken = null;
                noviSken.Predmet = cmbPredmeti.SelectedItem as Predmet;
            }
            else
            {
                noviSken.Student = student;
                noviSken.Varanje = cbVaranje.Checked;
                noviSken.Napomena = txtNapomena.Text;
                noviSken.Sken = ImageHelper.FromImageToByte(pbScan.Image);
                noviSken.Predmet = cmbPredmeti.SelectedItem as Predmet;
            }
            baza.KorisniciIspitScan.Add(noviSken);
            baza.SaveChanges();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void pbScan_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                var putanja = openFileDialog1.FileName;
                pbScan.Image = Image.FromFile(putanja);
            }
        }
    }
}

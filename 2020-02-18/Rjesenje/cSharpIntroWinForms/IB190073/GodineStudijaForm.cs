using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB190073
{
    public partial class GodineStudijaForm : Form
    {
        private const string Warning = "This field is required!";
        private bool Edit;
        private GodineStudija Odabrana;
        KonekcijaNaBazu baza = DLWMS.DB;
        public GodineStudijaForm()
        {
            InitializeComponent();
            dgvGodineStudija.AutoGenerateColumns = false;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(ValidirajUnos())
            {
                if(!Edit)
                {
                    baza.GodineStudija.Add(new GodineStudija() { Naziv = txtNaziv.Text, Aktivna = cbAktivna.Checked });
                    MessageBox.Show($"Godina uspješno dodana!");
                }
                else
                {
                    //Obavezno uzeti nove vrijednosti ako zelimo modifikovati
                    Odabrana.Naziv = txtNaziv.Text;
                    Odabrana.Aktivna = cbAktivna.Checked;
                    baza.Entry(Odabrana).State = EntityState.Modified;
                    MessageBox.Show($"Godina uspješno editovana!");
                }
                baza.SaveChanges();
                UcitajGodineStudija();
                OcistiPolja();
            }
        }

        private void OcistiPolja()
        {
            txtNaziv.Text = "";
            cbAktivna.Checked = false;
        }

        private bool ValidirajUnos() =>Validator.ObaveznoPolje(txtNaziv, err, Warning);

        private void GodineStudijaForm_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajGodineStudija();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }
        private void UcitajGodineStudija()
        {
            dgvGodineStudija.DataSource = null;
            dgvGodineStudija.DataSource = baza.GodineStudija.ToList();
        }

        private void dgvGodineStudija_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var godinaStudija = dgvGodineStudija.Rows[e.RowIndex].DataBoundItem as GodineStudija;
            if(godinaStudija!=null)
            {
                txtNaziv.Text = godinaStudija.Naziv;
                cbAktivna.Checked = godinaStudija.Aktivna;
                //kad se odabere neka godina edit mode se postavi na true i godina se spasi u Odabranu
                Edit = true;
                Odabrana = godinaStudija;
            }
        }
    }
}

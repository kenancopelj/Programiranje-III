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

namespace cSharpIntroWinForms.IB200054
{
    public partial class frmGodineStudijaIB200054 : Form
    {
        KonekcijaNaBazu baza = DLWMS.DB;
        GodineStudijaIB200054 godinaStudija;
        private bool Edit = false;
        public frmGodineStudijaIB200054()
        {
            InitializeComponent();
            dgvGodineStudija.AutoGenerateColumns = false;
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                godinaStudija.Naziv = txtNaziv.Text;
                godinaStudija.Aktivna = cbAktivna.Checked;
                baza.Entry(godinaStudija).State = EntityState.Modified;
                baza.SaveChanges();
                txtNaziv.Text = "";
                cbAktivna.Checked = false;
                UcitajGodine();
            }
            else
                if (!VecDodana())
                {
                    if (Validiraj())
                    {
                        var nova = new GodineStudijaIB200054()
                        {
                            Naziv = txtNaziv.Text,
                            Aktivna = cbAktivna.Checked
                        };
                        baza.GodineStudija.Add(nova);
                        baza.SaveChanges();
                        txtNaziv.Text = "";
                        UcitajGodine();
                    }
                }
                else
                    MessageBox.Show("Vec dodana");

        }

        private bool VecDodana()
        {
            var odabranaGodina = txtNaziv.Text;
            foreach (var godina in baza.GodineStudija)
            {
                if (godina.Naziv == odabranaGodina)
                    return true;
            }
            return false;
        }

        private void UcitajGodine()
        {
            dgvGodineStudija.DataSource = null;
            dgvGodineStudija.DataSource = baza.GodineStudija.ToList();
        }

        private bool Validiraj()
        {
            if(string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                err.SetError(txtNaziv, "Obavezan unos");
                return false;
            }
            err.Clear();
            return true;
        }

        private void dgvGodineStudija_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaGodina = dgvGodineStudija.SelectedRows[0].DataBoundItem as GodineStudijaIB200054;
            if(odabranaGodina!=null)
            {
                txtNaziv.Text = odabranaGodina.Naziv;
                cbAktivna.Checked = odabranaGodina.Aktivna;
                godinaStudija = odabranaGodina;
                Edit = true;
            }
        }

        private void frmGodineStudijaIB200054_Load(object sender, EventArgs e)
        {
            UcitajGodine();
        }

    }
}

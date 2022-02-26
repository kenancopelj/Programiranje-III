using Microsoft.Reporting.WinForms;
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
    public partial class frmIzvjestaj : Form
    {
        private List<Korisnik> lista;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(List<Korisnik> lista):this()
        {
            this.lista = lista;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var tblPodaci = new List<object>();
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista[i].Uspjeh.Count; j++)
                {
                    tblPodaci.Add(new
                    {
                        Rb = tblPodaci.Count + 1,
                        Korisnik = lista[i].ToString(),
                        Predmet = lista[i].Uspjeh[j].Predmet.Naziv,
                        Ocjena = lista[i].Uspjeh[j].Ocjena,
                        Datum = lista[i].Uspjeh[j].Datum
                    });
                }
            }
            var dataSource = new ReportDataSource();
            dataSource.Name = "dsPodaci";
            dataSource.Value = tblPodaci;

            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}

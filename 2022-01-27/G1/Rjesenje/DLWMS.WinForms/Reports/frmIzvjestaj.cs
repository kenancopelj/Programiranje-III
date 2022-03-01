using DLWMS.WinForms.DB;
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

namespace DLWMS.WinForms.Reports
{
    public partial class frmIzvjestaj : Form
    {
        private List<StudentiPredmeti> rezultat;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(List<StudentiPredmeti> rezultat) : this()
        {
            this.rezultat = rezultat;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("Prosjek", $"{Math.Round(rezultat.Average(x=>x.Ocjena),2)}"));

            var tblPodaci = new List<object>();
            for (int i = 0; i < rezultat.Count; i++)
            {
                tblPodaci.Add(new
                {
                    ImePrezime = rezultat[i].Student.ToString(),
                    Predmet = rezultat[i].Predmet.ToString(),
                    Datum = rezultat[i].DatumPolaganja,
                    Ocjena = rezultat[i].Ocjena
                });
            }

            var dataSource = new ReportDataSource();
            dataSource.Name = "dsPodaci";
            dataSource.Value = tblPodaci;

            this.reportViewer1.LocalReport.SetParameters(parametri);
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}

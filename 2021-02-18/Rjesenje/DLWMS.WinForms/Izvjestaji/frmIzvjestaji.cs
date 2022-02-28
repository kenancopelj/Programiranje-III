using DLWMS.WinForms.Entiteti;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiCovidTestovi> studentiTestovi;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<StudentiCovidTestovi> studentiTestovi) : this()
        {
            this.studentiTestovi = studentiTestovi;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {
            //var rpc = new ReportParameterCollection();

            var tblRezultati = new List<object>();

            for (int i = 0; i < studentiTestovi.Count; i++)
            {
                var dostavljen = studentiTestovi[i].NalazDostavljen ? "Da" : "Ne";
                tblRezultati.Add(new
                {
                    Rb = i+1,
                    Student = studentiTestovi[i].Student.ToString(),
                    Datum = studentiTestovi[i].Datum,
                    Rezultat = studentiTestovi[i].Rezultat,
                    NalazDostavljen = dostavljen
                });
            }

            var rds = new ReportDataSource();
            rds.Name = "dsRezultati";
            rds.Value = tblRezultati;

            reportViewer1.LocalReport.DataSources.Add(rds);
            //reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}

using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Forme;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private dtoUvjerenje rezultat;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(dtoUvjerenje rezultat) : this()
        {
            this.rezultat = rezultat;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("ImePrezime", rezultat.ImePrezime));

            var tblPodaci = new List<object>();

            for (int i = 0; i < rezultat.Ispiti.Count; i++)
            {
                var varanje = rezultat.Ispiti[i].Varanje ? "Da" : "Ne";
                tblPodaci.Add(new
                {
                    Rb = i+1,
                    Predmet = rezultat.Ispiti[i].Predmet.Naziv,
                    Napomena = rezultat.Ispiti[i].Napomena,
                    Varanje = varanje
                });
            }


            var rds = new ReportDataSource();
            rds.Name = "dsPodaci";
            rds.Value = tblPodaci;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}

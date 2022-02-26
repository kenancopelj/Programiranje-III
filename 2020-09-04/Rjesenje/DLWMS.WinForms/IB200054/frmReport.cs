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

namespace DLWMS.WinForms.IB200054
{
    public partial class frmReport : Form
    {
        private dtoUvjerenje podaci;

        public frmReport()
        {
            InitializeComponent();
        }

        public frmReport(dtoUvjerenje podaci):this()
        {
            this.podaci = podaci;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("Student", podaci.Student));

            var tblPodaci = new List<object>();
            for (int i = 0; i < podaci.Poruke.Count; i++)
            {
                tblPodaci.Add(new
                {
                    Rb = i+1,
                    Datum = podaci.Poruke[i].DatumVrijeme,
                    Sadrzaj = podaci.Poruke[i].Sadrzaj
                });
            }
            var ds = new ReportDataSource();
            ds.Name = "dsPodaci";
            ds.Value = tblPodaci;


            this.reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.LocalReport.SetParameters(parametri);
            this.reportViewer1.RefreshReport();
        }
    }
}

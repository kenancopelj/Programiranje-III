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
    public partial class frmUvjerenjeIB200054 : Form
    {
        private List<Student> podaci;

        public frmUvjerenjeIB200054()
        {
            InitializeComponent();
        }

        public frmUvjerenjeIB200054(List<Student> podaci):this()
        {
            this.podaci = podaci;
        }

        private void frmUvjerenjeIB200054_Load(object sender, EventArgs e)
        {
            var tblPodaci = new List<object>();
            for (int i = 0; i < podaci.Count; i++)
            {
                tblPodaci.Add(new
                {
                    Rb = i+1,
                    Indeks = podaci[i].Indeks,
                    Ime=podaci[i].Ime,
                    Prezime = podaci[i].Prezime,
                    Spol = podaci[i].Spol.Naziv,
                    Godina = podaci[i].GodinaStudija,
                    Aktivan = podaci[i].Aktivan ? "Da":"Ne"
                });
            }

            var rds = new ReportDataSource();
            rds.Value = tblPodaci;
            rds.Name = "dsPodaci";


            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}

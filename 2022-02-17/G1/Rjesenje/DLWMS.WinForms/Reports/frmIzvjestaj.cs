using DLWMS.WinForms.IB200054;
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
        private Student student;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(Student student):this()
        {
            this.student = student;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("ImePrezime", student.ToString()));
            parametri.Add(new ReportParameter("Ukupno", $"{student.Konsultacije.Count()}"));

            var tblPodaci = new List<object>();
            for (int i = 0; i < student.Konsultacije.Count; i++)
            {
                tblPodaci.Add(new
                {
                    Rb = i+1,
                    Predmet = student.Konsultacije[i].Predmeti.Naziv,
                    Vrijeme = student.Konsultacije[i].VrijemeOdrzavanja.ToString(),
                    Napomena = student.Konsultacije[i].Napomena
                });
            }

            var dataSource = new ReportDataSource();
            dataSource.Name = "dsPodaci";
            dataSource.Value = tblPodaci;

            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.LocalReport.SetParameters(parametri);
            this.reportViewer1.RefreshReport();
        }
    }
}

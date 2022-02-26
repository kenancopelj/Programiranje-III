using DLWMS.WinForms.DB;
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
    public partial class frmPorukeIB200054 : Form
    {
        private Student student;
        KonekcijaNaBazu baza = DLWMSdb.Baza;

        public frmPorukeIB200054()
        {
            InitializeComponent();
            dgvPoruke.AutoGenerateColumns = false;
        }

        public frmPorukeIB200054(Student student):this()
        {
            this.student = student;
        }

        private void frmPorukeIB200054_Load(object sender, EventArgs e)
        {
            lblStudent.Text = $"Komunikacija sa: {student}";
            UcitajPoruke();
        }

        private void UcitajPoruke()
        {
            try
            {
                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = student.Poruke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException?.Message);
            }
        }

        private void dgvPoruke_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                var poruka = dgvPoruke.SelectedRows[0].DataBoundItem as KorisniciPorukeIB200054;
            if(poruka!=null)
                new frmNovaPorukaIB200054(poruka).ShowDialog();
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            if (new frmNovaPorukaIB200054(student).ShowDialog() == DialogResult.OK)
                UcitajPoruke();
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3)
            {
                if (MessageBox.Show("Jeste li sigurni", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var poruka = dgvPoruke.SelectedRows[0].DataBoundItem as KorisniciPorukeIB200054;
                    baza.KorisniciPoruke.Remove(poruka);
                    baza.SaveChanges();
                    UcitajPoruke();
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var podaci = new dtoUvjerenje()
            {
                Student = student.ToString(),
                Poruke = dgvPoruke.DataSource as List<KorisniciPorukeIB200054>
            };
            new frmReport(podaci).ShowDialog();
        }
    }

    public class dtoUvjerenje
    {
        public string Student { get; set; }
        public List<KorisniciPorukeIB200054> Poruke { get; set; }
    }
}

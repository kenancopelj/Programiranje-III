using cSharpIntroWinForms.P8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB200054
{
    public partial class frmGlavnaIB200054 : Form
    {
        public frmGlavnaIB200054()
        {
            InitializeComponent();
        }

        private void btnGodineStudija_Click(object sender, EventArgs e)
        {
            new frmGodineStudijaIB200054().ShowDialog();
        }

        private void btnPolozeni_Click(object sender, EventArgs e)
        {
            new KorisniciPolozeniPredmeti().ShowDialog();
        }

        private async void btnSumiraj_Click(object sender, EventArgs e)
        {
            if(ValidirajBroj())
            {
                int broj = int.Parse(txtBroj.Text);
                long suma = 0;
                Action action = () => { MessageBox.Show($"Suma: {suma}"); };
                await Task.Run(() =>
                {
                    for (int i = 0; i < broj; i++)
                    {
                        suma += broj;
                    }
                    BeginInvoke(action);
                });
            }
        }

        private bool ValidirajBroj()
        {
            return Regex.IsMatch(txtBroj.Text, @"^\d+$");
        }
    }
}

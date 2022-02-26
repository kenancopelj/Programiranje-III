using cSharpIntroWinForms.P8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace cSharpIntroWinForms.IB190073
{
    public partial class Glavna : Form
    {
        //kreiramo ASINHRONU metodu koja prima opseg do kojeg trebamo ici
        async void MetodaSumiranja(int opseg)
        {
            await Task.Run(() => {
                SaberiVrijednosti(opseg);
            });
        }

        private void SaberiVrijednosti(int opseg)
        {
            //dobijamo opseg i nakon izracunavanja upisemo u textbox rezultat
            try
            {
                Thread.Sleep(200);
                Action akcija = () =>
                {
                    var rez = 0;
                    for (int i = 0; i <= opseg; i++)
                        rez += i;
                    txtUnesenaSuma.Text = "Rezultat je -> " + rez.ToString() + Environment.NewLine;
                };
                BeginInvoke(akcija);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }

        public Glavna()
        {
            InitializeComponent();
        }

        private void btnGodineStudija_Click(object sender, EventArgs e)
        {
            new GodineStudijaForm().ShowDialog();
        }

        private void btnPolozeniPredmeti_Click(object sender, EventArgs e)
        {
            new KorisniciPolozeniPredmeti().ShowDialog();
        }

        private void btnIzracunajSumu_Click(object sender, EventArgs e)
        {
            //proslijedimo uneseni string ako je validan ide dalje ako nije validan ili je prazan textbox onda dobijamo poruku
            if(!string.IsNullOrEmpty(txtUnesenaSuma.Text) && ValidanInput(txtUnesenaSuma.Text))
                MetodaSumiranja(int.Parse(txtUnesenaSuma.Text));
            else
                MessageBox.Show($"Molimo unesite neku brojcanu vrijednost!");
        }
        private bool ValidanInput(string text)
        {
            int number;
            bool isConvertible = Int32.TryParse(text, out number);
            if (isConvertible)
                return true;
            return false;
        }
    }
}


using DLWMS.WinForms.IB200054;
using System;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form stratnaForma = new frmPretragaIB200054();
            Application.Run(stratnaForma);
        }
    }
}

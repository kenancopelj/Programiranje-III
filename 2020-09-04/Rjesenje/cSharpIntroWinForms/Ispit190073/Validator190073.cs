using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.Ispit190073
{
    public class Validator190073
    {
        public static bool ValidirajPolje(Control kontrola, ErrorProvider err,string poruka)
        {
            bool validno = true;
            if (kontrola is TextBox && string.IsNullOrEmpty((kontrola as TextBox).Text))
                validno = false;
            if(!validno)
            {
                err.SetError(kontrola, poruka);
                return false;
            }else
            {
                err.Clear();
                return true;
            }
        }
    }
}

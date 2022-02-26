using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB200054
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmetiIB200054
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual PredmetiIB200054 Predmet { get; set; }
        public int Ocjena { get; set; }
        public string DatumPolaganja { get; set; }
    }
}

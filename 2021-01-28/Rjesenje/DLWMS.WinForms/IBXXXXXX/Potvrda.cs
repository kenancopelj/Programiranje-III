using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS.WinForms.Entiteti;

namespace DLWMS.WinForms.IBXXXXXX
{
    [Table("Potvrde")]
    public class Potvrda
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public string Svrha { get; set; }
        public string Datum { get; set; }
        public bool Izdata { get; set; }
    }
}

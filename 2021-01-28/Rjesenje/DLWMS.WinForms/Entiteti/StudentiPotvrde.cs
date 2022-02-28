using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.Entiteti
{
    [Table("StudentiPotvrde")]
    public class StudentiPotvrde
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public string Datum { get; set; }
        public string Svrha { get; set; }
        public bool Izdata { get; set; }
    }
}

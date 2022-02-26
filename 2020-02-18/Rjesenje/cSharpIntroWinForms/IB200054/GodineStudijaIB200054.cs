using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB200054
{
    [Table("GodineStudija")]
    public class GodineStudijaIB200054
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Aktivna { get; set; }
    }
}

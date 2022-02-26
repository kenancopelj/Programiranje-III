using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB190073
{
    [Table("GodineStudija")]
    public class GodineStudija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Aktivna { get; set; }

        public override string ToString() => Naziv;
    }


}

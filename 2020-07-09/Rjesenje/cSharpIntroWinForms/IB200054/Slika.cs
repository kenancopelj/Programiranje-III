using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB200054
{
    [Table("Slika")]
    public class Slika
    {
        public int Id { get; set; }
        public byte[] _Slika { get; set; }
    }
}

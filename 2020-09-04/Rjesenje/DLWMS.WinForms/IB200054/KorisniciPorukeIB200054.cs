using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB200054
{
    [Table("KorisniciPoruke")]
    public class KorisniciPorukeIB200054
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public string DatumVrijeme { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }
    }
}

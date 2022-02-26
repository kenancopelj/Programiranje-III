using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.Ispit190073
{
    [Table("KorisniciPoruke")]
    public class KorisniciPoruke190073
    {
        public int Id { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public string DatumSlanja { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }
    }
}

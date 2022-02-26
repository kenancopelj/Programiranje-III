using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.Ispit190073
{
    public class dtoKorisnik
    {
        public string ImePrezime { get; set; }
        public List<KorisniciPoruke190073> ListaPoruka { get; set; } = new List<KorisniciPoruke190073>();
    }
}

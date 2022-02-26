
using DLWMS.WinForms.DB;
using DLWMS.WinForms.IB200054;
using System;
using System.Collections.Generic;

namespace DLWMS.WinForms
{
    public  class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public int GodinaStudija { get; set; }
        // public Image Slika { get; set; }
        public byte[] Slika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public virtual List<StudentiPredmetiIB200054> StudentiPredmeti { get; set; } = new List<StudentiPredmetiIB200054>();
        public virtual List<KorisniciPorukeIB200054> Poruke { get; set; } = new List<KorisniciPorukeIB200054>();
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
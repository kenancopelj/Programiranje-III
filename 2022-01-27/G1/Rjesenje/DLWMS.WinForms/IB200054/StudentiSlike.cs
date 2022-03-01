using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB200054
{
    [Table("StudentiSlike")]
    public class StudentiSlike
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Slike Slike { get; set; }
        public string Opis { get; set; }
        public string Datum { get; set; }
    }
}

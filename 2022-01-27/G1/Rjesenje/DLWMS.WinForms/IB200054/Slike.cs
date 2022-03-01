using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB200054
{
    [Table("Slike")]
    public class Slike
    {
        public int Id { get; set; }
        public byte[] Slika { get; set; }
    }
}

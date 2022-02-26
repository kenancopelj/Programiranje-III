using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB200054
{
    [Table("Spolovi")]
    public class SpoloviIB200054
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}

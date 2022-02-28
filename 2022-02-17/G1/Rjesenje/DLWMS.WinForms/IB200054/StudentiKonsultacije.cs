using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB200054
{
    [Table("StudentiKonsultacije")]
    public class StudentiKonsultacije
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Predmeti Predmeti { get; set; }
        public DateTime VrijemeOdrzavanja { get; set; }
        public string Napomena { get; set; }
    }
}


using DLWMS.WinForms.IB200054;
using System.Data.Entity;

namespace DLWMS.WinForms.DB
{

    //DLWMSContext
    public class KonekcijaNaBazu : DbContext
    {
        public KonekcijaNaBazu() : base("DLWMSPutanja")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Studenti");                      
        }       
        public DbSet<Student> Studenti { get; set; }
        public DbSet<StudentiPredmetiIB200054> StudentiPredmeti { get; set; }
        public DbSet<PredmetiIB200054> Predmeti { get; set; }
        public DbSet<KorisniciPorukeIB200054> KorisniciPoruke { get; set; }
       
    }
}
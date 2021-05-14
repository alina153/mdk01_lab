using System.Data.Entity;

namespace DBApp.Models
{
    public class CartoonContext : DbContext
    {
        public CartoonContext(): base("PhonesCon")
        {
        }

        public DbSet<Cartoon> Cartoones { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cartoon>();
        }
    }
}
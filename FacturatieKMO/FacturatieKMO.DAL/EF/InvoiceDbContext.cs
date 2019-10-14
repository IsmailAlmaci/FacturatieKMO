using FacturatieKMO.BL.Domain;
using System.Data.Entity;

namespace FacturatieKMO.DAL.EF
{
    [DbConfigurationType(typeof(InvoiceDbConfiguration))]
    internal class InvoiceDbContext : DbContext
    {
        public InvoiceDbContext() : base("InvoiceDB_EFCodeFirst")
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Admin");

            modelBuilder.Entity<User>().HasKey<int>(u => u.UserId);

            modelBuilder.Entity<User>().ToTable("UserInfo");
        }
    }
}

using FacturatieKMO.BL.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FacturatieKMO.DAL.EF
{
    [DbConfigurationType(typeof(InvoiceDbConfiguration))]
    internal class InvoiceDbContext : DbContext
    {
        public InvoiceDbContext() : base("InvoiceDB_EFCodeFirst")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Admin");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<User>().HasKey<int>(u => u.UserId);
            modelBuilder.Entity<Customer>().HasKey<int>(c => c.CustomerId);
            modelBuilder.Entity<Invoice>().HasKey<int>(i => i.InvoiceNr);
            modelBuilder.Entity<InvoiceDetail>().HasKey<int>(i => i.ItemId);
        }
    }
}

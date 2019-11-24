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

        public DbSet<UserDTO> Users { get; set; }
        public DbSet<CustomerDTO> Customers { get; set; }
        public DbSet<InvoiceDTO> Invoices { get; set; }
        public DbSet<InvoiceDetailDTO> InvoiceDetails { get; set; }
        public DbSet<RoleDTO> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Admin");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<UserDTO>().HasKey<int>(u => u.UserId);
            modelBuilder.Entity<CustomerDTO>().HasKey<int>(c => c.CustomerId);
            modelBuilder.Entity<InvoiceDTO>().HasKey<int>(i => i.InvoiceNr);
            modelBuilder.Entity<InvoiceDetailDTO>().HasKey<int>(i => i.ItemId);
            modelBuilder.Entity<RoleDTO>().HasKey<int>(i => i.RoleId);

            modelBuilder.Entity<UserDTO>()
                .HasMany(u => u.Role);
            }
    }
}

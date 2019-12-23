using FacturatieKMO.DAL.Configuration;
using FacturatieKMO.DAL.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace FacturatieKMO.DAL.EF
{
    internal class InvoiceDbContext : DbContext, IInvoiceDataSource
    {
        public InvoiceDbContext() : base("InvoiceDB_EFCodeFirst")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Role> Roles { get; set; }

        IQueryable<Customer> IInvoiceDataSource.Customers => Customers;

        IQueryable<Invoice> IInvoiceDataSource.Invoices => Invoices;

        IQueryable<Role> IInvoiceDataSource.Roles => Roles;

        IQueryable<User> IInvoiceDataSource.Users => Users;

        IQueryable<InvoiceDetail> IInvoiceDataSource.InvoiceDetails => InvoiceDetails;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new InvoiceConfiguration());
            modelBuilder.Configurations.Add(new InvoiceDetailConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}

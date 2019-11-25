using FacturatieKMO.DAL.Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace FacturatieKMO.DAL.EF
{
    internal class InvoiceDbInitializer
        :DropCreateDatabaseIfModelChanges<InvoiceDbContext>
    {
        protected override void Seed(InvoiceDbContext context)
        {
            SeedList<Customer>(DataHolder.GetCustomers(), context.Customers);
            SeedList<Invoice>(DataHolder.GetInvoices(), context.Invoices);
            SeedList<InvoiceDetail>(DataHolder.GetInvoiceDetails(), context.InvoiceDetails);
            SeedList<User>(DataHolder.GetUsers(), context.Users);
            SeedList<Role>(DataHolder.GetRoles(), context.Roles);

            context.SaveChanges();
        }

        private void SeedList<TEntity> (List<TEntity> items, DbSet<TEntity> dbSet) where TEntity : class
        {
            foreach (TEntity item in items)
            {
                dbSet.Add(item);
            }
        }
    }
}

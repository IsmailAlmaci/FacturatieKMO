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
            SeedList(DataHolder.GetInvoiceDetails(), context.InvoiceDetails);
            SeedList(DataHolder.GetInvoices(), context.Invoices);
            SeedList(DataHolder.GetRoles(), context.Roles);

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

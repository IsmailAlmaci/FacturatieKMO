using FacturatieKMO.DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<InvoiceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InvoiceDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            SeedList(DataHolder.GetInvoices(), context.Invoices);
        }

        private void SeedList<TEntity>(List<TEntity> items, DbSet<TEntity> dbSet) where TEntity : class
        {
            foreach (TEntity item in items)
            {
                dbSet.AddOrUpdate(item);
            }
        }
    }
}

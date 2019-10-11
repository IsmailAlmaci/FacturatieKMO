using System.Data.Entity;

namespace FacturatieKMO.DAL.EF
{
    internal class InvoiceDbConfiguration : DbConfiguration
    {
        public InvoiceDbConfiguration()
        {
            this.SetDefaultConnectionFactory(
                new System.Data.Entity.Infrastructure.SqlConnectionFactory());

            this.SetProviderServices("System.Data.SqlClient",
                System.Data.Entity.SqlServer.SqlProviderServices.Instance);

            this.SetDatabaseInitializer<InvoiceDbContext>(
                                              new InvoiceDbInitializer());
        }
    }
}

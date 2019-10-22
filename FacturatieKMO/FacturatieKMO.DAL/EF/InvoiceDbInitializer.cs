using FacturatieKMO.BL.Domain;
using System.Collections.Generic;
using System.Data.Entity;

namespace FacturatieKMO.DAL.EF
{
    internal class InvoiceDbInitializer
        :DropCreateDatabaseIfModelChanges<InvoiceDbContext>
    {
        protected override void Seed(InvoiceDbContext context)
        {
            List<string> roles = new List<string>();
            roles.Add("Admin");
            context.Users.Add(new User(1, "Almaci", "Ismail", "s104428@ap.be", "Sint-Gillis-Waas", roles));
            context.SaveChanges();
        }
    }
}

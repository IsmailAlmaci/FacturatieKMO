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
            List<Role> roles = new List<Role>();
            roles.Add(new Role(1, "Admin"));
            roles.Add(new Role(2, "User"));

            context.Users.Add(new User(1, "Almaci", "Ismail", "s104428@ap.be", "Sint-Gillis-Waas", roles));
            context.SaveChanges();
        }
    }
}

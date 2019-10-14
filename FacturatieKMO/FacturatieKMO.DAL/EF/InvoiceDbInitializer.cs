using FacturatieKMO.BL.Domain;
using System.Data.Entity;

namespace FacturatieKMO.DAL.EF
{
    internal class InvoiceDbInitializer
        :DropCreateDatabaseIfModelChanges<InvoiceDbContext>
    {
        protected override void Seed(InvoiceDbContext context)
        {
            context.Users.Add(new User(
                1,
                "Almaci",
                "Ismail",
                "ismail.almaci@student.ap.be",
                "Sint-Gillis-Waas",
                Role.User
                ));

            context.Users.Add(new User(
                2,
                "Newell",
                "Gabe",
                "gaben@student.ap.be",
                "LA",
                Role.Administrator
                ));
            context.SaveChanges();
        }
    }
}

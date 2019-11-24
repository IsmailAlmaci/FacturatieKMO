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
            List<RoleDTO> roles = new List<RoleDTO>();
            roles.Add(new RoleDTO(1, "Admin"));
            roles.Add(new RoleDTO(2, "User"));

            context.Users.Add(new UserDTO(1, "Almaci", "Ismail", "s104428@ap.be", "Sint-Gillis-Waas", roles));
            context.SaveChanges();
        }
    }
}

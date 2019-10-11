using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;

namespace FacturatieKMO.DAL.EF
{
    public class UserRepository : IUserRepository
    {
        private InvoiceDbContext ctx;

        public UserRepository()
        {
            ctx = new InvoiceDbContext();
            ctx.Database.Initialize(false);
        }

        public User CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ReadUsers()
        {
            IEnumerable<User> users = ctx.Users.AsEnumerable();
            return users;
        }
    }
}

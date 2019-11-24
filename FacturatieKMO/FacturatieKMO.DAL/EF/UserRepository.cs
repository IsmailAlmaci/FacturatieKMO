using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public UserDTO CreateUser(UserDTO user)
        {
            ctx.Users.Add(user);
            ctx.SaveChanges();

            return user;
        }

        public void DeleteUser(int userId)
        {
            UserDTO user = ctx.Users.Find(userId);
            ctx.Users.Remove(user);
            ctx.SaveChanges();
        }

        public UserDTO ReadUser(int UserId)
        {
            UserDTO user = ctx.Users.Find(UserId);
            return user;
        }

        public IEnumerable<UserDTO> ReadUsers()
        {
            IEnumerable<UserDTO> users = ctx.Users.AsEnumerable();
            return users;
        }

        public void UpdateUser(UserDTO user)
        {
            ctx.Entry(user).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}

using FacturatieKMO.DAL.Model;
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

        public User CreateUser(User user)
        {
            ctx.Users.Add(user);
            ctx.SaveChanges();

            return user;
        }

        public void DeleteUser(int userId)
        {
            User user = ctx.Users.Find(userId);
            ctx.Users.Remove(user);
            ctx.SaveChanges();
        }

        public User ReadUser(int UserId)
        {
            User user = ctx.Users.Find(UserId);
            return user;
        }

        public IEnumerable<User> ReadUsers()
        {
            IEnumerable<User> users = ctx.Users.AsEnumerable();
            return users;
        }

        public void UpdateUser(User user)
        {
            ctx.Entry(user).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}

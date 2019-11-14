using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;
using System;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public class UserManager : IUserManager
    {
        private IUserRepository repo;

        public UserManager()
        {
            repo = new UserRepository();
        }

        public User AddUsers(int id, string name, string firstName, string email, string address, List<Role> role)
        {
            User user = new User(id, name, firstName, email, address, role);
            return repo.CreateUser(user);
        }

        public void ChangeUser(User user)
        {
            repo.UpdateUser(user);
        }

        public User GetUser(int userId)
        {
            return repo.ReadUser(userId);
        }

        public IEnumerable<User> GetUsers()
        {
            return repo.ReadUsers();
        }

        public void RemoveUser(int userId)
        {
            repo.DeleteUser(userId);
        }
    }
}

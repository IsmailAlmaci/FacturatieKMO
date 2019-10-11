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

        public User AddUsers(string name, string firstName, string email, string address, Role role)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            return repo.ReadUsers();
        }
    }
}

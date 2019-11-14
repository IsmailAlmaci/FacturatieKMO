using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface IUserManager
    {
        IEnumerable<User> GetUsers();
        User AddUsers(int id, string name, string firstName, string email, string address, List<Role> role);
        User GetUser(int userId);
        void RemoveUser(int userId);
        void ChangeUser(User user);
    }
}
using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.DAL
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        IEnumerable<User> ReadUsers();
        User ReadUser(int userId);
        void DeleteUser(int userId);
        void UpdateUser(User user);
    }
}

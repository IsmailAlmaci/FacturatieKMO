using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.DAL
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        IEnumerable<User> ReadUsers();
    }
}

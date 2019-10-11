using System;
using System.Collections.Generic;
using System.Text;
using FacturatieKMO.BL.Domain;

namespace FacturatieKMO.DAL
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        IEnumerable<User> ReadUsers();
    }
}

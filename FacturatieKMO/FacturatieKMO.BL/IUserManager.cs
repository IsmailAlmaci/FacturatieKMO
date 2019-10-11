using System;
using System.Collections.Generic;
using System.Text;
using FacturatieKMO.BL.Domain;

namespace FacturatieKMO.BL
{
    public interface IUserManager
    {
        IEnumerable<User> GetUsers();
        User AddUsers(string name, string firstName, string email, string address, Role role);
    }
}
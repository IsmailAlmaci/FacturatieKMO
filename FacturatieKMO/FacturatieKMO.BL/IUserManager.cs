﻿using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface IUserManager
    {
        IEnumerable<User> GetUsers();
        User AddUsers(string name, string firstName, string email, string address, Role role);
    }
}
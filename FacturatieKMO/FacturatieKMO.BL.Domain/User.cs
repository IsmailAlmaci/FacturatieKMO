using System;
using System.Collections.Generic;
using System.Text;

namespace FacturatieKMO.BL.Domain
{
    public class User
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Role Role { get; set; }

        public User(string name, string firstName, string email, string address, Role role)
        {
            Name = name;
            FirstName = firstName;
            Email = email;
            Address = address;
            Role = role;
        }
    }
}
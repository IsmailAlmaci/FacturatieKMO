using System.Collections.Generic;

namespace FacturatieKMO.BL.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<string> Role { get; set; }

        public User()
        {

        }
        public User(int userId, string name, string firstName, string email, string address, List<string> role)
        {
            UserId = userId;
            Name = name;
            FirstName = firstName;
            Email = email;
            Address = address;
            Role = role;
        }
    }
}
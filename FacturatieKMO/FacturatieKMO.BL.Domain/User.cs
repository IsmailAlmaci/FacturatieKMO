using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturatieKMO.BL.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        [Required]
        public List<Role> Role { get; set; }

        public User()
        {

        }
        public User(int userId, string name, string firstName, string email, string address, List<Role> role)
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
using System.Collections.Generic;

namespace FacturatieKMO.DAL.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ICollection<Role> Role { get; set; }
        public ICollection<Invoice> Invoices { get; set; }

        public User()
        {

        }

        public User(int userId, string name, string firstName, string email, string address, ICollection<Role> role, ICollection<Invoice> invoices)
        {
            UserId = userId;
            Name = name;
            FirstName = firstName;
            Email = email;
            Address = address;
            Role = role;
            Invoices = invoices;
        }
    }
}
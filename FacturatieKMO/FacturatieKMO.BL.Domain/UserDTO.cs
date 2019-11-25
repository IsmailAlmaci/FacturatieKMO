using System.Collections.Generic;

namespace FacturatieKMO.BL.Domain
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ICollection<RoleDTO> Role { get; set; }
        public ICollection<InvoiceDTO> Invoices { get; set; }

        public UserDTO()
        {
        }

        public UserDTO(int userId, string name, string firstName, string email, string address, ICollection<RoleDTO> role, ICollection<InvoiceDTO> invoices)
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
using System.Collections.Generic;

namespace FacturatieKMO.BL.Domain
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<InvoiceDTO> Invoices { get; set; }

        public CustomerDTO()
        {
        }

        public CustomerDTO(string name, string firstName, string email, string address, ICollection<InvoiceDTO> invoices, bool isDeleted)
        {
            Name = name;
            FirstName = firstName;
            Email = email;
            Address = address;
            Invoices = invoices;
            IsDeleted = isDeleted;
        }
    }
}

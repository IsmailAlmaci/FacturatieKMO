using System.Collections.Generic;

namespace FacturatieKMO.BL.Domain
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ICollection<InvoiceDTO> Invoices { get; set; }

        public CustomerDTO()
        {
        }

        public CustomerDTO(int customerId, string name, string firstName, string email, string address, ICollection<InvoiceDTO> invoices)
        {
            CustomerId = customerId;
            Name = name;
            FirstName = firstName;
            Email = email;
            Address = address;
            Invoices = invoices;
        }
    }
}

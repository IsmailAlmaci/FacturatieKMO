using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface ICustomerManager
    {
        IEnumerable<CustomerDTO> GetCustomers();
        CustomerDTO AddCustomers(string name, string firstName, string email, string address, ICollection<InvoiceDTO> invoices);
        CustomerDTO GetCustomer(int customerId);
        void RemoveCustomer(int customerId);
        void ChangeCustomer(CustomerDTO customer);
    }
}

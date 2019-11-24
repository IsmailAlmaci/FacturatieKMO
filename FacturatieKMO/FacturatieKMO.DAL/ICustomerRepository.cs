using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.DAL
{
    public interface ICustomerRepository
    {
        CustomerDTO CreateCustomer(CustomerDTO customer);
        IEnumerable<CustomerDTO> ReadCustomers();
        CustomerDTO ReadCustomer(int customerId);
        void DeleteCustomer(int customerId);
        void UpdateCustomer(CustomerDTO customer);
    }
}

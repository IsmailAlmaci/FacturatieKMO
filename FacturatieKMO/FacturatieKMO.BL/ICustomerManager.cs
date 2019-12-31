using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface ICustomerManager
    {
        IEnumerable<CustomerDTO> GetCustomers();
        CustomerDTO AddCustomers(CustomerDTO customer);
        CustomerDTO GetCustomer(int customerId);
        void RemoveCustomer(int customerId);
        void ChangeCustomer(CustomerDTO customer);
    }
}

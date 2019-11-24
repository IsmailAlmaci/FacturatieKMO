using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface ICustomerManager
    {
        IEnumerable<CustomerDTO> GetCustomers();
        CustomerDTO AddCustomers(int id, string name, string firstName, string email, string address);
        CustomerDTO GetCustomer(int customerId);
        void RemoveCustomer(int customerId);
        void ChangeCustomer(CustomerDTO customer);
    }
}

using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface ICustomerManager
    {
        IEnumerable<Customer> GetCustomers();
        Customer AddCustomers(int id, string name, string firstName, string email, string address);
        Customer GetCustomer(int customerId);
        void RemoveCustomer(int customerId);
        void ChangeCustomer(Customer customer);
    }
}

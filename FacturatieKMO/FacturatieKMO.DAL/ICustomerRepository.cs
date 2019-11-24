using FacturatieKMO.DAL.Model;
using System.Collections.Generic;

namespace FacturatieKMO.DAL
{
    public interface ICustomerRepository
    {
        Customer CreateCustomer(Customer customer);
        IEnumerable<Customer> ReadCustomers();
        Customer ReadCustomer(int customerId);
        void DeleteCustomer(int customerId);
        void UpdateCustomer(Customer customer);
    }
}

using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.DAL
{
    public interface ICustomerRepository
    {
        User CreateCustomer(Customer customer);
        IEnumerable<Customer> ReadCustomers();
    }
}

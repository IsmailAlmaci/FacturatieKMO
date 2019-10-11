using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface ICustomerManager
    {
        IEnumerable<Customer> GetCustomers();
        Customer AddCustomers(string name, string firstName, string email, string address);
    }
}

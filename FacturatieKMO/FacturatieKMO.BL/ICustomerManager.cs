using System;
using System.Collections.Generic;
using System.Text;
using FacturatieKMO.BL.Domain;

namespace FacturatieKMO.BL
{
    public interface ICustomerManager
    {
        IEnumerable<Customer> GetCustomers();
        Customer AddCustomers(string name, string firstName, string email, string address);
    }
}

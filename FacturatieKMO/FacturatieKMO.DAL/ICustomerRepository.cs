using System;
using System.Collections.Generic;
using System.Text;
using FacturatieKMO.BL.Domain;

namespace FacturatieKMO.DAL
{
    public interface ICustomerRepository
    {
        User CreateCustomer(Customer customer);
        IEnumerable<Customer> ReadCustomers();
    }
}

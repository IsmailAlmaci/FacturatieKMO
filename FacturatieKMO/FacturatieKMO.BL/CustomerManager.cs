using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;
using System;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public class CustomerManager : ICustomerManager
    {
        private ICustomerRepository repo;

        public CustomerManager()
        {
            repo = new CustomerRepository();
        }

        public Customer AddCustomers(int id, string name, string firstName, string email, string address)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return repo.ReadCustomers();
        }
    }
}

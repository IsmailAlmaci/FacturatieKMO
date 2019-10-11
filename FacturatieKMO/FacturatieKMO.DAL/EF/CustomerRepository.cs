using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;

namespace FacturatieKMO.DAL.EF
{
    public class CustomerRepository : ICustomerRepository
    {
        private InvoiceDbContext ctx = null;

        public CustomerRepository()
        {
            ctx = new InvoiceDbContext();
        }

        private void Seed()
        {
            
        }

        public User CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> ReadCustomers()
        {
            throw new NotImplementedException();
        }
    }
}

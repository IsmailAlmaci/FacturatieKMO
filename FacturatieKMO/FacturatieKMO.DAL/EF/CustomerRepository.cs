using System;
using System.Collections.Generic;
using System.Text;
using FacturatieKMO.BL.Domain;

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

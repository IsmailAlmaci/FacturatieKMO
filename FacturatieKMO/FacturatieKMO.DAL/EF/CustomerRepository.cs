using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FacturatieKMO.DAL.EF
{
    public class CustomerRepository : ICustomerRepository
    {
        private InvoiceDbContext ctx;

        public CustomerRepository()
        {
            ctx = new InvoiceDbContext();
            ctx.Database.Initialize(false);
        }

        public CustomerDTO CreateCustomer(CustomerDTO customer)
        {
            ctx.Customers.Add(customer);
            ctx.SaveChanges();

            return customer;
        }

        public IEnumerable<CustomerDTO> ReadCustomers()
        {
            IEnumerable<CustomerDTO> customers = ctx.Customers.AsEnumerable();
            return customers;
        }

        public CustomerDTO ReadCustomer(int customerId)
        {
            CustomerDTO customer = ctx.Customers.Find(customerId);
            return customer;
        }

        public void DeleteCustomer(int customerId)
        {
            CustomerDTO customer = ctx.Customers.Find(customerId);
            ctx.Customers.Remove(customer);
            ctx.SaveChanges();
        }

        public void UpdateCustomer(CustomerDTO customer)
        {
            ctx.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}

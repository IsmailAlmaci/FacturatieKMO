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
            Customer customer = new Customer(id, name, firstName, email, address);
            return repo.CreateCustomer(customer);
        }

        public void ChangeCustomer(Customer customer)
        {
            repo.UpdateCustomer(customer);
        }

        public Customer GetCustomer(int customerId)
        {
            return repo.ReadCustomer(customerId);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return repo.ReadCustomers();
        }

        public void RemoveCustomer(int customerId)
        {
            repo.DeleteCustomer(customerId);
        }
    }
}

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

        public CustomerDTO AddCustomers(int id, string name, string firstName, string email, string address)
        {
            CustomerDTO customer = new CustomerDTO(id, name, firstName, email, address);
            return repo.CreateCustomer(customer);
        }

        public void ChangeCustomer(CustomerDTO customer)
        {
            repo.UpdateCustomer(customer);
        }

        public CustomerDTO GetCustomer(int customerId)
        {
            return repo.ReadCustomer(customerId);
        }

        public IEnumerable<CustomerDTO> GetCustomers()
        {
            return repo.ReadCustomers();
        }

        public void RemoveCustomer(int customerId)
        {
            repo.DeleteCustomer(customerId);
        }
    }
}

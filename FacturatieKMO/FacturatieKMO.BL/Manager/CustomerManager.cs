using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;
using FacturatieKMO.DAL.Model;
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

        public CustomerDTO AddCustomers(CustomerDTO customer)
        {
            repo.CreateCustomer(MapDTO.Map<Customer, CustomerDTO>(customer));
            return customer;
        }

        public void ChangeCustomer(CustomerDTO customer)
        {
            repo.UpdateCustomer(MapDTO.Map<Customer, CustomerDTO>(customer));
        }

        public CustomerDTO GetCustomer(int customerId)
        {
            return MapDTO.Map<CustomerDTO, Customer>(repo.ReadCustomer(customerId));
        }

        public IEnumerable<CustomerDTO> GetCustomers()
        {
            return MapDTO.MapList<CustomerDTO, Customer>(repo.ReadCustomers());
        }

        public void RemoveCustomer(int customerId)
        {
            repo.DeleteCustomer(customerId);
        }
    }
}

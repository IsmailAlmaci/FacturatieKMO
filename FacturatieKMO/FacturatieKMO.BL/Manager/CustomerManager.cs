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

        public CustomerDTO AddCustomers(int id, string name, string firstName, string email, string address, ICollection<InvoiceDTO> invoices)
        {
            ICollection<Invoice> invoiceList = new List<Invoice>();
            foreach (InvoiceDTO item in invoices)
            {
                invoiceList.Add(MapDTO.Map<Invoice, InvoiceDTO>(item));
            }
            Customer customer = new Customer(id, name, firstName, email, address, invoiceList);
            return MapDTO.Map<CustomerDTO, Customer>(repo.CreateCustomer(customer));
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

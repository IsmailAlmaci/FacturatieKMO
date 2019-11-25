﻿using System.Collections.Generic;

namespace FacturatieKMO.DAL.Model
{ 
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ICollection<Invoice> Invoices { get; set; }

        public Customer()
        {

        }

        public Customer(int customerId, string name, string firstName, string email, string address, ICollection<Invoice> invoices)
        {
            CustomerId = customerId;
            Name = name;
            FirstName = firstName;
            Email = email;
            Address = address;
            Invoices = invoices;
        }
    }
}
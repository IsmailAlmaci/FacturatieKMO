using FacturatieKMO.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.DAL
{
    static class DataHolder
    {
        static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, "Almaci", "Ismail", "ismail.almaci@student.ap.be", "SGW", GetInvoices()));
            customers.Add(new Customer(2, "Newell", "Gabe", "gabe.newell@student.ap.be", "LA", GetInvoices()));
            customers.Add(new Customer(3, "Wilder", "Deontay", "deontay.wilder@student.ap.be", "AL", GetInvoices()));
            customers.Add(new Customer(4, "Sapp", "Bob", "bob.sapp@student.ap.be", "JP", GetInvoices()));
            customers.Add(new Customer(5, "Hoost", "Ernesto", "ernesto.hoost@student.ap.be", "NL", GetInvoices()));

            return customers;
        }

        static List<Invoice> GetInvoices()
        {
            int counter = 0;
            List<Invoice> invoices = new List<Invoice>();
            invoices.Add(new Invoice(1, "Wood company", "Wood customer", DateTime.Now, GetInvoiceDetails(),
                Status.InProgress, GetCustomers().ElementAt(counter), GetUsers().ElementAt(counter++)));

            invoices.Add(new Invoice(2, "Iron company", "Iron customer", DateTime.Now, GetInvoiceDetails(),
                Status.Completed, GetCustomers().ElementAt(counter), GetUsers().ElementAt(counter++)));

            invoices.Add(new Invoice(3, "Electronics company", "Electronics customer", DateTime.Now, GetInvoiceDetails(),
                Status.Completed, GetCustomers().ElementAt(counter), GetUsers().ElementAt(counter++)));

            invoices.Add(new Invoice(4, "Food company", "Food customer", DateTime.Now, GetInvoiceDetails(),
                Status.InProgress, GetCustomers().ElementAt(counter), GetUsers().ElementAt(counter++)));

            invoices.Add(new Invoice(5, "Software company", "Software Customer", DateTime.Now, GetInvoiceDetails(),
                Status.InProgress, GetCustomers().ElementAt(counter), GetUsers().ElementAt(counter++)));

            return invoices;
        }

        static List<InvoiceDetail> GetInvoiceDetails()
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>();
            invoiceDetails.Add(new InvoiceDetail(1, "Plank", 5, 0, 20, 6));
            invoiceDetails.Add(new InvoiceDetail(2, "Bar", 50, 10, 200, 6));
            invoiceDetails.Add(new InvoiceDetail(3, "Laptop", 500, 0, 5, 21));
            invoiceDetails.Add(new InvoiceDetail(4, "Tomato", .50, 0, 8, 0));
            invoiceDetails.Add(new InvoiceDetail(5, "MS Office", 150, 0, 1, 21));

            return invoiceDetails;
        }

        static List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            roles.Add(new Role(1, "Medewerker"));
            roles.Add(new Role(2, "Admin"));

            return roles;
        }

        static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User(1, "Almaci", "Ismail", "ismail.almaci@student.ap.be", "SGW", GetRoles(), GetInvoices()));
            users.Add(new User(2, "Newell", "Gabe", "gabe.newell@student.ap.be", "LA", GetRoles(), GetInvoices()));
            users.Add(new User(3, "Wilder", "Deontay", "deontay.wilder@student.ap.be", "AL", GetRoles(), GetInvoices()));
            users.Add(new User(4, "Sapp", "Bob", "bob.sapp@student.ap.be", "JP", GetRoles(), GetInvoices()));
            users.Add(new User(5, "Hoost", "Ernesto", "ernesto.hoost@student.ap.be", "NL", GetRoles(), GetInvoices()));

            return users;
        }
    }
}

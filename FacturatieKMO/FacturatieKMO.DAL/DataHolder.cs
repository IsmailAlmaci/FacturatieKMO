using FacturatieKMO.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.DAL
{
    internal static class DataHolder
    {
        internal static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Almaci", "Ismail", "ismail.almaci@student.ap.be", "SGW", null, false));
            customers.Add(new Customer("Newell", "Gabe", "gabe.newell@student.ap.be", "LA", null, false));
            customers.Add(new Customer("Wilder", "Deontay", "deontay.wilder@student.ap.be", "AL", null, true));
            customers.Add(new Customer("Sapp", "Bob", "bob.sapp@student.ap.be", "JP", null, false));
            customers.Add(new Customer("Hoost", "Ernesto", "ernesto.hoost@student.ap.be", "NL", null, false));

            return customers;
        }

        internal static List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            invoices.Add(new Invoice("Wood company", "Wood customer", DateTime.Now, GetInvoiceDetails(),
                Status.InProgress, GetCustomers().ElementAt(0)));

            invoices.Add(new Invoice("Iron company", "Iron customer", DateTime.Now, GetInvoiceDetails(),
                Status.Completed, GetCustomers().ElementAt(1)));

            invoices.Add(new Invoice("Electronics company", "Electronics customer", DateTime.Now, GetInvoiceDetails(),
                Status.Completed, GetCustomers().ElementAt(2)));

            invoices.Add(new Invoice("Food company", "Food customer", DateTime.Now, GetInvoiceDetails(),
                Status.InProgress, GetCustomers().ElementAt(3)));

            invoices.Add(new Invoice("Software company", "Software Customer", DateTime.Now, GetInvoiceDetails(),
                Status.InProgress, GetCustomers().ElementAt(4)));

            return invoices;
        }

        internal static List<InvoiceDetail> GetInvoiceDetails()
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>();
            invoiceDetails.Add(new InvoiceDetail("Plank", 5, 0, 20, 6));
            invoiceDetails.Add(new InvoiceDetail("Bar", 50, 10, 200, 6));
            invoiceDetails.Add(new InvoiceDetail("Laptop", 500, 0, 5, 21));
            invoiceDetails.Add(new InvoiceDetail("Tomato", .50, 0, 8, 0));
            invoiceDetails.Add(new InvoiceDetail("MS Office", 150, 0, 1, 21));

            return invoiceDetails;
        }
    }
}

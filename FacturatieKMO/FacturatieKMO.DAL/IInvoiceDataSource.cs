using FacturatieKMO.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.DAL
{
    interface IInvoiceDataSource
    {
        IQueryable<Customer> Customers { get; }
        IQueryable<InvoiceDetail> InvoiceDetails { get; }
        IQueryable<Invoice> Invoices { get; }
        IQueryable<Role> Roles { get; }
        IQueryable<User> Users { get; }
    }
}

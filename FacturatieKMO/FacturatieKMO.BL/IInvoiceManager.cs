using System;
using System.Collections.Generic;
using System.Text;
using FacturatieKMO.BL.Domain;

namespace FacturatieKMO.BL
{
    public interface IInvoiceManager
    {
        IEnumerable<Invoice> GetInvoices();
        Invoice AddInvoice(int number, string companyInfo, string customerInfo, DateTime date, ICollection<InvoiceDetail> details, Status status);
    }
}

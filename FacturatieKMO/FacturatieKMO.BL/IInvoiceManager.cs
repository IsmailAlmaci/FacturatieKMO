using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface IInvoiceManager
    {
        IEnumerable<Invoice> GetInvoices();
        Invoice AddInvoice(int number, string companyInfo, string customerInfo, DateTime date, ICollection<InvoiceDetail> details, Status status);
        Invoice GetInvoice(int invoiceNr);
        void RemoveInvoice(int invoiceNr);
        void ChangeInvoice(Invoice invoice);
        IEnumerable<InvoiceDetail> GetInvoiceDetails(int invoiceNr);
    }
}

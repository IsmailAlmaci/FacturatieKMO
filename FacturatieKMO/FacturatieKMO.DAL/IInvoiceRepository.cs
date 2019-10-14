using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.DAL
{
    public interface IInvoiceRepository
    {
        Invoice CreateInvoice(Invoice invoice);
        IEnumerable<Invoice> ReadInvoices();
        Invoice ReadInvoice(int invoiceNr);
        void DeleteInvoice(int invoiceNr);
        void UpdateInvoice(Invoice invoice);
        IEnumerable<InvoiceDetail> ReadDetails(int invoiceNr);
    }
}

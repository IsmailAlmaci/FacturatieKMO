using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.DAL
{
    public interface IInvoiceRepository
    {
        InvoiceDTO CreateInvoice(InvoiceDTO invoice);
        IEnumerable<InvoiceDTO> ReadInvoices();
        InvoiceDTO ReadInvoice(int invoiceNr);
        void DeleteInvoice(int invoiceNr);
        void UpdateInvoice(InvoiceDTO invoice);
        IEnumerable<InvoiceDetailDTO> ReadDetails(int invoiceNr);
    }
}

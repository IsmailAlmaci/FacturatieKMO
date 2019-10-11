using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.DAL
{
    public interface IInvoiceRepository
    {
        Invoice CreateInvoice(Invoice invoice);
        IEnumerable<Invoice> ReadInvoices();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using FacturatieKMO.BL.Domain;

namespace FacturatieKMO.DAL
{
    public interface IInvoiceRepository
    {
        Invoice CreateInvoice(Invoice invoice);
        IEnumerable<Invoice> ReadInvoices();
    }
}

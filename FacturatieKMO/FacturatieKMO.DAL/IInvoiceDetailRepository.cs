using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.DAL
{
    public interface IInvoiceDetailRepository
    {
        InvoiceDetail CreateInvoiceDetail(InvoiceDetail invoiceDetail);
        IEnumerable<InvoiceDetail> ReadInvoiceDetails();
    }
}

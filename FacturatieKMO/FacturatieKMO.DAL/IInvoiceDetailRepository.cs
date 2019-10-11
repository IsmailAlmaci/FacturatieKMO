using System;
using System.Collections.Generic;
using System.Text;
using FacturatieKMO.BL.Domain;

namespace FacturatieKMO.DAL
{
    public interface IInvoiceDetailRepository
    {
        InvoiceDetail CreateInvoiceDetail(InvoiceDetail invoiceDetail);
        IEnumerable<InvoiceDetail> ReadInvoiceDetails();
    }
}

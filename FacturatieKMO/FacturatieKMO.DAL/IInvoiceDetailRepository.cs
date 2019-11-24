using FacturatieKMO.DAL.Model;
using System.Collections.Generic;

namespace FacturatieKMO.DAL
{
    public interface IInvoiceDetailRepository
    {
        InvoiceDetail CreateInvoiceDetail(InvoiceDetail invoiceDetail);
        IEnumerable<InvoiceDetail> ReadInvoiceDetails();
        InvoiceDetail ReadInvoiceDetail(int invoiceDetailId);
        void DeleteInvoiceDetail(int invoiceDetailId);
        void UpdateInvoiceDetail(InvoiceDetail invoiceDetail);
    }
}

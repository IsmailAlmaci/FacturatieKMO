using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.DAL
{
    public interface IInvoiceDetailRepository
    {
        InvoiceDetailDTO CreateInvoiceDetail(InvoiceDetailDTO invoiceDetail);
        IEnumerable<InvoiceDetailDTO> ReadInvoiceDetails();
        InvoiceDetailDTO ReadInvoiceDetail(int invoiceDetailId);
        void DeleteInvoiceDetail(int invoiceDetailId);
        void UpdateInvoiceDetail(InvoiceDetailDTO invoiceDetail);
    }
}

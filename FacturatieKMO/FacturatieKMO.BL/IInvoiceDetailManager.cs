using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface IInvoiceDetailManager
    {
        IEnumerable<InvoiceDetailDTO> GetInvoiceDetails();
        InvoiceDetailDTO AddInvoiceDetail(InvoiceDetailDTO invoiceDetail);
        InvoiceDetailDTO GetInvoiceDetail(int invoiceDetailId);
        void RemoveInvoiceDetail(int invoiceDetailId);
        void ChangeInvoiceDetail(InvoiceDetailDTO invoiceDetail);
    }
}

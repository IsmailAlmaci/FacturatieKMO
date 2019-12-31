using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface IInvoiceDetailManager
    {
        IEnumerable<InvoiceDetailDTO> GetInvoiceDetails();
        InvoiceDetailDTO AddInvoiceDetails(string item, double price, double discount, int amount, double vat);
        InvoiceDetailDTO GetInvoiceDetail(int invoiceDetailId);
        void RemoveInvoiceDetail(int invoiceDetailId);
        void ChangeInvoiceDetail(InvoiceDetailDTO invoiceDetail);
    }
}

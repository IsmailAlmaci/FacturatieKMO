using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface IInvoiceManager
    {
        IEnumerable<InvoiceDTO> GetInvoices();
        InvoiceDTO AddInvoice(InvoiceDTO invoice);
        InvoiceDTO GetInvoice(int invoiceNr);
        void RemoveInvoice(int invoiceNr);
        void ChangeInvoice(InvoiceDTO invoice);
        IEnumerable<InvoiceDetailDTO> GetInvoiceDetails(int invoiceNr);
    }
}

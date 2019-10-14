using FacturatieKMO.BL.Domain;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public interface IInvoiceDetailManager
    {
        IEnumerable<InvoiceDetail> GetInvoiceDetails();
        InvoiceDetail AddInvoiceDetails(int id, string item, double price, double discount, int amount, double vat);
    }
}

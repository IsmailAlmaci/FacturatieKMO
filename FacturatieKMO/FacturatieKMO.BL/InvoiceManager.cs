using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;
using System;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public class InvoiceManager : IInvoiceManager
    {
        private IInvoiceRepository repo;

        public InvoiceManager()
        {
            repo = new InvoiceRepository();
        }

        public Invoice AddInvoice(int nr, string companyInfo, string customerInfo, DateTime date, ICollection<InvoiceDetail> details, Status status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetInvoices()
        {
            return repo.ReadInvoices();
        }
    }
}

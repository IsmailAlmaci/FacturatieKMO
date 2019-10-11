using System;
using System.Collections.Generic;
using System.Text;
using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;

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

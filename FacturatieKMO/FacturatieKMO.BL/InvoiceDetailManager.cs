using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;
using System;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public class InvoiceDetailManager : IInvoiceDetailManager
    {
        private IInvoiceDetailRepository repo;

        public InvoiceDetailManager()
        {
            repo = new InvoiceDetailRepository();
        }

        public InvoiceDetail AddInvoiceDetails(int id, string item, double price, double discount, int amount, double vat)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceDetail> GetInvoiceDetails()
        {
            return repo.ReadInvoiceDetails();
        }
    }
}

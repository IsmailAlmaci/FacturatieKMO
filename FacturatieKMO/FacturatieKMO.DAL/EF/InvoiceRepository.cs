using System;
using System.Collections.Generic;
using System.Text;
using FacturatieKMO.BL.Domain;

namespace FacturatieKMO.DAL.EF
{
    public class InvoiceRepository : IInvoiceRepository
    {
        List<Invoice> invoices;

        public InvoiceRepository()
        {
            invoices = new List<Invoice>();
            Seed();
        }

        private void Seed()
        {
            invoices.Add(new Invoice(
                    1,
                    "Verkoop van Hout & Koper",
                    "Verwerker van hout",
                    DateTime.Now,
                    null,
                    Status.InProgress
                ));
            invoices.Add(new Invoice(
                    2,
                    "Verkoop van Hout & Koper",
                    "Verwerker van koper",
                    DateTime.Now,
                    null,
                    Status.Completed
                ));
        }

        public Invoice CreateInvoice(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> ReadInvoices()
        {
            return invoices;
        }
    }
}

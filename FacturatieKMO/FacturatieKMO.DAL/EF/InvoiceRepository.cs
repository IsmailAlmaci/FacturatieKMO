using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FacturatieKMO.DAL.EF
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private InvoiceDbContext ctx;

        public InvoiceRepository()
        {
            ctx = new InvoiceDbContext();
            ctx.Database.Initialize(false);
        }

        public InvoiceDTO CreateInvoice(InvoiceDTO invoice)
        {
            ctx.Invoices.Add(invoice);
            ctx.SaveChanges();

            return invoice;
        }

        public IEnumerable<InvoiceDTO> ReadInvoices()
        {
            IEnumerable<InvoiceDTO> invoices = ctx.Invoices.AsEnumerable();
            return invoices;
        }

        public InvoiceDTO ReadInvoice(int invoiceNr)
        {
            InvoiceDTO invoice = ctx.Invoices.Find(invoiceNr);
            return invoice;
        }

        public void DeleteInvoice(int invoiceNr)
        {
            InvoiceDTO invoice = ctx.Invoices.Find(invoiceNr);
            ctx.Invoices.Remove(invoice);
            ctx.SaveChanges();
        }

        public void UpdateInvoice(InvoiceDTO invoice)
        {
            ctx.Entry(invoice).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public IEnumerable<InvoiceDetailDTO> ReadDetails(int invoiceNr)
        {
            IEnumerable<InvoiceDetailDTO> details = ctx.Invoices.Find(invoiceNr).Details.AsEnumerable();
            return details;
        }
    }
}

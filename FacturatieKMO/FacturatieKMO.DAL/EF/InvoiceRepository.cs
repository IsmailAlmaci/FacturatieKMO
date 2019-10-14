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

        public Invoice CreateInvoice(Invoice invoice)
        {
            ctx.Invoices.Add(invoice);
            ctx.SaveChanges();

            return invoice;
        }

        public IEnumerable<Invoice> ReadInvoices()
        {
            IEnumerable<Invoice> invoices = ctx.Invoices.AsEnumerable();
            return invoices;
        }

        public Invoice ReadInvoice(int invoiceNr)
        {
            Invoice invoice = ctx.Invoices.Find(invoiceNr);
            return invoice;
        }

        public void DeleteInvoice(int invoiceNr)
        {
            Invoice invoice = ctx.Invoices.Find(invoiceNr);
            ctx.Invoices.Remove(invoice);
            ctx.SaveChanges();
        }

        public void UpdateInvoice(Invoice invoice)
        {
            ctx.Entry(invoice).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public IEnumerable<InvoiceDetail> ReadDetails(int invoiceNr)
        {
            IEnumerable<InvoiceDetail> details = ctx.Invoices.Find(invoiceNr).Responses.AsEnumerable();
            return details;
        }

        public InvoiceDetail CreateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            ctx.InvoiceDetails.Add(invoiceDetail);
            ctx.SaveChanges();

            return invoiceDetail;
        }
    }
}

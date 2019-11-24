using System;
using System.Collections.Generic;
using System.Linq;
using FacturatieKMO.DAL.Model

namespace FacturatieKMO.DAL.EF
{
    public class InvoiceDetailRepository : IInvoiceDetailRepository
    {
        private InvoiceDbContext ctx;

        public InvoiceDetailRepository()
        {
            ctx = new InvoiceDbContext();
            ctx.Database.Initialize(false);
        }

        public InvoiceDetail CreateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            ctx.InvoiceDetails.Add(invoiceDetail);
            ctx.SaveChanges();

            return invoiceDetail;
        }

        public IEnumerable<InvoiceDetail> ReadInvoiceDetails()
        {
            IEnumerable<InvoiceDetail> invoiceDetails = ctx.InvoiceDetails.AsEnumerable();
            return invoiceDetails;
        }

        public InvoiceDetail ReadInvoiceDetail(int invoiceDetailId)
        {
            InvoiceDetail invoiceDetail = ctx.InvoiceDetails.Find(invoiceDetailId);
            return invoiceDetail;
        }

        public void DeleteInvoiceDetail(int invoiceDetailId)
        {
            InvoiceDetail invoiceDetail = ctx.InvoiceDetails.Find(invoiceDetailId);
            ctx.InvoiceDetails.Remove(invoiceDetail);
            ctx.SaveChanges();
        }

        public void UpdateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            ctx.Entry(invoiceDetail).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}

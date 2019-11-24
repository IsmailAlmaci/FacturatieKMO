using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public InvoiceDetailDTO CreateInvoiceDetail(InvoiceDetailDTO invoiceDetail)
        {
            ctx.InvoiceDetails.Add(invoiceDetail);
            ctx.SaveChanges();

            return invoiceDetail;
        }

        public IEnumerable<InvoiceDetailDTO> ReadInvoiceDetails()
        {
            IEnumerable<InvoiceDetailDTO> invoiceDetails = ctx.InvoiceDetails.AsEnumerable();
            return invoiceDetails;
        }

        public InvoiceDetailDTO ReadInvoiceDetail(int invoiceDetailId)
        {
            InvoiceDetailDTO invoiceDetail = ctx.InvoiceDetails.Find(invoiceDetailId);
            return invoiceDetail;
        }

        public void DeleteInvoiceDetail(int invoiceDetailId)
        {
            InvoiceDetailDTO invoiceDetail = ctx.InvoiceDetails.Find(invoiceDetailId);
            ctx.InvoiceDetails.Remove(invoiceDetail);
            ctx.SaveChanges();
        }

        public void UpdateInvoiceDetail(InvoiceDetailDTO invoiceDetail)
        {
            ctx.Entry(invoiceDetail).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}

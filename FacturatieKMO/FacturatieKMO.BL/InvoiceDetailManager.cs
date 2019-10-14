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
            InvoiceDetail invoiceDetail = new InvoiceDetail(id, item, price, discount, amount, vat);
            return repo.CreateInvoiceDetail(invoiceDetail);
        }

        public void ChangeInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            repo.UpdateInvoiceDetail(invoiceDetail);
        }

        public InvoiceDetail GetInvoiceDetail(int invoiceDetailId)
        {
            return repo.ReadInvoiceDetail(invoiceDetailId);
        }

        public IEnumerable<InvoiceDetail> GetInvoiceDetails()
        {
            return repo.ReadInvoiceDetails();
        }

        public void RemoveInvoiceDetail(int invoiceDetailId)
        {
            repo.DeleteInvoiceDetail(invoiceDetailId);
        }
    }
}

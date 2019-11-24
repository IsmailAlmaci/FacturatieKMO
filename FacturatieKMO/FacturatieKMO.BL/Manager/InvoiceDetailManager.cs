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

        public InvoiceDetailDTO AddInvoiceDetails(int id, string item, double price, double discount, int amount, double vat)
        {
            InvoiceDetailDTO invoiceDetail = new InvoiceDetailDTO(id, item, price, discount, amount, vat);
            return repo.CreateInvoiceDetail(invoiceDetail);
        }

        public void ChangeInvoiceDetail(InvoiceDetailDTO invoiceDetail)
        {
            repo.UpdateInvoiceDetail(invoiceDetail);
        }

        public InvoiceDetailDTO GetInvoiceDetail(int invoiceDetailId)
        {
            return repo.ReadInvoiceDetail(invoiceDetailId);
        }

        public IEnumerable<InvoiceDetailDTO> GetInvoiceDetails()
        {
            return repo.ReadInvoiceDetails();
        }

        public void RemoveInvoiceDetail(int invoiceDetailId)
        {
            repo.DeleteInvoiceDetail(invoiceDetailId);
        }
    }
}

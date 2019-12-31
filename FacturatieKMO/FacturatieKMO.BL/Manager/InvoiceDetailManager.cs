using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;
using FacturatieKMO.DAL.Model;
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

        public InvoiceDetailDTO AddInvoiceDetails(string item, double price, double discount, int amount, double vat)
        {
            InvoiceDetail invoiceDetail = new InvoiceDetail(item, price, discount, amount, vat);
            return MapDTO.Map<InvoiceDetailDTO, InvoiceDetail>(repo.CreateInvoiceDetail(invoiceDetail));
        }

        public void ChangeInvoiceDetail(InvoiceDetailDTO invoiceDetail)
        {
            repo.UpdateInvoiceDetail(MapDTO.Map<InvoiceDetail, InvoiceDetailDTO>(invoiceDetail));
        }

        public InvoiceDetailDTO GetInvoiceDetail(int invoiceDetailId)
        {
            return MapDTO.Map<InvoiceDetailDTO, InvoiceDetail>(repo.ReadInvoiceDetail(invoiceDetailId));
        }

        public IEnumerable<InvoiceDetailDTO> GetInvoiceDetails()
        {
            return MapDTO.MapList<InvoiceDetailDTO, InvoiceDetail>(repo.ReadInvoiceDetails());
        }

        public void RemoveInvoiceDetail(int invoiceDetailId)
        {
            repo.DeleteInvoiceDetail(invoiceDetailId);
        }
    }
}

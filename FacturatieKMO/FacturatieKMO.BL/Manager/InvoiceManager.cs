using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;
using FacturatieKMO.DAL.Model;
using System.Collections.Generic;

namespace FacturatieKMO.BL
{
    public class InvoiceManager : IInvoiceManager
    {
        private IInvoiceRepository repo;

        public InvoiceManager()
        {
            repo = new InvoiceRepository();
        }

        public InvoiceDTO AddInvoice(InvoiceDTO invoice)
        {
            repo.CreateInvoice(MapDTO.Map<Invoice, InvoiceDTO>(invoice));
            return invoice;
        }

        public InvoiceDTO GetInvoice(int invoiceNr)
        {
            return MapDTO.Map<InvoiceDTO, Invoice>(repo.ReadInvoice(invoiceNr));
        }

        public IEnumerable<InvoiceDTO> GetInvoices()
        {
            return MapDTO.MapList<InvoiceDTO, Invoice>(repo.ReadInvoices());
        }

        public void RemoveInvoice(int invoiceNr)
        {
            repo.DeleteInvoice(invoiceNr);
        }

        public void ChangeInvoice(InvoiceDTO invoice)
        {
            repo.UpdateInvoice(MapDTO.Map<Invoice, InvoiceDTO>(invoice));
        }

        public IEnumerable<InvoiceDetailDTO> GetInvoiceDetails(int invoiceNr)
        {
            return MapDTO.MapList<InvoiceDetailDTO, InvoiceDetail>(repo.ReadDetails(invoiceNr));
        }
    }
}

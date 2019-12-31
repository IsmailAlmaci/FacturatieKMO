using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;
using FacturatieKMO.DAL.Model;
using System;
using System.Collections.Generic;
using Status = FacturatieKMO.DAL.Model.Status;

namespace FacturatieKMO.BL
{
    public class InvoiceManager : IInvoiceManager
    {
        private IInvoiceRepository repo;

        public InvoiceManager()
        {
            repo = new InvoiceRepository();
        }

        public InvoiceDTO AddInvoice(string companyInfo, string customerInfo, DateTime date, ICollection<InvoiceDetailDTO> details, StatusDTO status, CustomerDTO customer)
        {
            ICollection<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>();
            foreach (InvoiceDetailDTO item in details)
            {
                invoiceDetails.Add(MapDTO.Map<InvoiceDetail, InvoiceDetailDTO>(item));
            }

            Invoice invoice = new Invoice(companyInfo, customerInfo, date, invoiceDetails,
                MapDTO.Map<Status, StatusDTO>(status), MapDTO.Map<Customer, CustomerDTO>(customer));

            return MapDTO.Map<InvoiceDTO, Invoice>(repo.CreateInvoice(invoice));
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

using FacturatieKMO.BL.Domain;
using FacturatieKMO.DAL;
using FacturatieKMO.DAL.EF;
using System;
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

        public InvoiceDTO AddInvoice(int nr, string companyInfo, string customerInfo, DateTime date, ICollection<InvoiceDetailDTO> details, Status status)
        {
            InvoiceDTO invoice = new InvoiceDTO(nr, companyInfo, customerInfo, date, details, status);
            return repo.CreateInvoice(invoice);
        }

        public InvoiceDTO GetInvoice(int invoiceNr)
        {
            return repo.ReadInvoice(invoiceNr);
        }

        public IEnumerable<InvoiceDTO> GetInvoices()
        {
            return repo.ReadInvoices();
        }

        public void RemoveInvoice(int invoiceNr)
        {
            repo.DeleteInvoice(invoiceNr);
        }

        public void ChangeInvoice(InvoiceDTO invoice)
        {
            repo.UpdateInvoice(invoice);
        }

        public IEnumerable<InvoiceDetailDTO> GetInvoiceDetails(int invoiceNr)
        {
            return repo.ReadDetails(invoiceNr);
        }
    }
}

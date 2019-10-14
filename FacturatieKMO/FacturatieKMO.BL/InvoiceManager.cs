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

        public Invoice AddInvoice(int nr, string companyInfo, string customerInfo, DateTime date, ICollection<InvoiceDetail> details, Status status)
        {
            Invoice invoice = new Invoice(nr, companyInfo, customerInfo, date, details, status);
            return repo.CreateInvoice(invoice);
        }

        public Invoice GetInvoice(int invoiceNr)
        {
            return repo.ReadInvoice(invoiceNr);
        }

        public IEnumerable<Invoice> GetInvoices()
        {
            return repo.ReadInvoices();
        }

        public void RemoveInvoice(int invoiceNr)
        {
            repo.DeleteInvoice(invoiceNr);
        }

        public void ChangeInvoice(Invoice invoice)
        {
            repo.UpdateInvoice(invoice);
        }

        public IEnumerable<InvoiceDetail> GetInvoiceDetails(int invoiceNr)
        {
            return repo.ReadDetails(invoiceNr);
        }
    }
}

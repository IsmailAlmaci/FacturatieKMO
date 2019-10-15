using System;
using System.Collections.Generic;

namespace FacturatieKMO.BL.Domain
{
    public class Invoice
    {
        public int InvoiceNr { get; set; }
        public string CompanyInfo { get; set; }
        public string CustomerInfo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<InvoiceDetail> Details { get; set; }
        public Status InvoiceStatus { get; set; }

        public Invoice()
        {

        }
        public Invoice(int invoiceNr, string companyInfo, string customerInfo, DateTime invoiceDate, ICollection<InvoiceDetail> responses, Status invoiceStatus)
        {
            InvoiceNr = invoiceNr;
            CompanyInfo = companyInfo;
            CustomerInfo = customerInfo;
            InvoiceDate = invoiceDate;
            Details = responses;
            InvoiceStatus = invoiceStatus;
        }
    }
}

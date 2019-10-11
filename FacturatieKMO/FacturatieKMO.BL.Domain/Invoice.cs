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
        public ICollection<InvoiceDetail> Responses { get; set; }
        public Status InvoiceStatus { get; set; }

        public Invoice(int invoiceNr, string companyInfo, string customerInfo, DateTime invoiceDate, ICollection<InvoiceDetail> responses, Status invoiceStatus)
        {
            InvoiceNr = invoiceNr;
            CompanyInfo = companyInfo;
            CustomerInfo = customerInfo;
            InvoiceDate = invoiceDate;
            Responses = responses;
            InvoiceStatus = invoiceStatus;
        }
    }
}

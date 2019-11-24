using System;
using System.Collections.Generic;

namespace FacturatieKMO.BL.Domain
{
    public class InvoiceDTO
    {
        public int InvoiceNr { get; set; }
        public string CompanyInfo { get; set; }
        public string CustomerInfo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<InvoiceDetailDTO> Details { get; set; }
        public Status InvoiceStatus { get; set; }

        public InvoiceDTO()
        {

        }
        public InvoiceDTO(int invoiceNr, string companyInfo, string customerInfo, DateTime invoiceDate, ICollection<InvoiceDetailDTO> responses, Status invoiceStatus)
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

using System;
using System.Collections.Generic;

namespace FacturatieKMO.BL.Domain
{
    public class InvoiceDTO
    {
        public int Id { get; set; }
        public string CompanyInfo { get; set; }
        public string CustomerInfo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<InvoiceDetailDTO> Details { get; set; }
        public StatusDTO InvoiceStatus { get; set; }
        public CustomerDTO Customer { get; set; }

        public InvoiceDTO()
        {

        }

        public InvoiceDTO(string companyInfo, string customerInfo, DateTime invoiceDate, ICollection<InvoiceDetailDTO> details, StatusDTO invoiceStatus, CustomerDTO customer)
        {
            CompanyInfo = companyInfo;
            CustomerInfo = customerInfo;
            InvoiceDate = invoiceDate;
            Details = details;
            InvoiceStatus = invoiceStatus;
            Customer = customer;
       }
    }
}

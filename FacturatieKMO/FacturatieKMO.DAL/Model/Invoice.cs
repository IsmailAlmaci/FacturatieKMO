using System;
using System.Collections.Generic;

namespace FacturatieKMO.DAL.Model
{
    public class Invoice
    {
        public int Id { get; set; }
        public string CompanyInfo { get; set; }
        public string CustomerInfo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<InvoiceDetail> Details { get; set; }
        public Status InvoiceStatus { get; set; }
        public Customer Customer { get; set; }
        public string InvoiceCode { get; set; }
        public bool IsDeleted { get; set; }
        public string CustomerName { get; set; }
        public string Reason { get; set; }
        public Invoice()
        {

        }

        public Invoice(string companyInfo, string customerInfo, DateTime invoiceDate, ICollection<InvoiceDetail> details, Status invoiceStatus, Customer customer, string invoiceCode)
        {
            CompanyInfo = companyInfo;
            CustomerInfo = customerInfo;
            InvoiceDate = invoiceDate;
            Details = details;
            InvoiceStatus = invoiceStatus;
            Customer = customer;
            InvoiceCode = invoiceCode;
            IsDeleted = false;
        }
    }
}

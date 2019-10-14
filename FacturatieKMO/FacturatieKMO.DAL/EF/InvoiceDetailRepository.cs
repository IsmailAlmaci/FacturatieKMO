using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;

namespace FacturatieKMO.DAL.EF
{
    public class InvoiceDetailRepository : IInvoiceDetailRepository
    {
        private List<InvoiceDetail> invoiceDetails;

        public InvoiceDetailRepository()
        {
            invoiceDetails = new List<InvoiceDetail>();
            Seed();
        }

        private void Seed()
        {
            invoiceDetails.Add(new InvoiceDetail(
                    1,
                    "Hout",
                    2.65,
                    0,
                    5,
                    6
                ));

            invoiceDetails.Add(new InvoiceDetail(
                    2,
                    "Koper",
                    25.50,
                    10,
                    50,
                    21
                ));
        }
        public InvoiceDetail CreateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceDetail> ReadInvoiceDetails()
        {
            return invoiceDetails;
        }
    }
}

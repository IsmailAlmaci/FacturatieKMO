﻿namespace FacturatieKMO.DAL.Model
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public double PricePerUnit { get; set; }
        public double Discount { get; set; }
        public int Amount { get; set; }
        public double VAT { get; set; }
        public Invoice Invoice { get; set; }

        public InvoiceDetail()
        {

        }
        public InvoiceDetail(string item, double pricePerUnit, double discount, int amount, double vAT, Invoice invoice)
        {
            Item = item;
            PricePerUnit = pricePerUnit;
            Discount = discount;
            Amount = amount;
            VAT = vAT;
            Invoice = invoice;
        }
    }
}

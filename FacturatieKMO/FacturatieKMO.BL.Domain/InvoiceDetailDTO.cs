namespace FacturatieKMO.BL.Domain
{
    public class InvoiceDetailDTO
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public double PricePerUnit { get; set; }
        public double Discount { get; set; }
        public int Amount { get; set; }
        public double VAT { get; set; }

        public InvoiceDetailDTO()
        {

        }
        public InvoiceDetailDTO(string item, double pricePerUnit, double discount, int amount, double vAT)
        {
            Item = item;
            PricePerUnit = pricePerUnit;
            Discount = discount;
            Amount = amount;
            VAT = vAT;
        }
    }
}

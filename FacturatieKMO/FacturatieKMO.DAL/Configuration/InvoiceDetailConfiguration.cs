using FacturatieKMO.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.DAL.Configuration
{
    internal class InvoiceDetailConfiguration : EntityTypeConfiguration<InvoiceDetail>
    {
        public InvoiceDetailConfiguration()
        {
            ToTable("InvoiceDetail");

            Property(i => i.Item).HasColumnType("varchar").HasMaxLength(100);
            Property(i => i.Amount).HasColumnType("int");
            Property(i => i.Discount).HasColumnType("float");
            Property(i => i.PricePerUnit).HasColumnType("float");
            Property(i => i.VAT).HasColumnType("float");

            HasRequired(i => i.Invoice);
        }
    }
}

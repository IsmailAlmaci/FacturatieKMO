using FacturatieKMO.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.DAL.Configuration
{
    internal class InvoiceConfiguration : EntityTypeConfiguration<Invoice>
    {
        public InvoiceConfiguration()
        {
            ToTable("Invoice");

            Property(i => i.CompanyInfo).HasColumnType("varchar").HasMaxLength(100);
            Property(i => i.CustomerInfo).HasColumnType("varchar").HasMaxLength(100);
            Property(i => i.InvoiceDate).HasColumnType("Date");
        }
    }
}

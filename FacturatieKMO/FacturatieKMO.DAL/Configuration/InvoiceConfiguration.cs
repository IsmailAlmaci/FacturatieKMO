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

            //Create Stored Procedures for Insert, Update & Delete for table Invoice
            MapToStoredProcedures();
            Property(i => i.CompanyInfo).HasColumnType("varchar").HasMaxLength(100);
            Property(i => i.CustomerInfo).HasColumnType("varchar").HasMaxLength(100);
            Property(i => i.InvoiceDate).HasColumnType("Date");
            Property(i => i.InvoiceCode).HasColumnType("varchar").HasMaxLength(100);
            Property(i => i.IsDeleted).HasColumnType("Bit");
        }
    }
}

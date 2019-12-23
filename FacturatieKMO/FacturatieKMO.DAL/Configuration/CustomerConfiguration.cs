using FacturatieKMO.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.DAL.Configuration
{
    internal class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            ToTable("Customer");

            Property(c => c.CustomerId).HasColumnType("int");
            Property(c => c.Name).HasColumnType("varchar").HasMaxLength(100);
            Property(c => c.FirstName).HasColumnType("varchar").HasMaxLength(100);
            Property(c => c.Email).HasColumnType("varchar").HasMaxLength(100);
            Property(c => c.Address).HasColumnType("varchar").HasMaxLength(200);

            HasMany(c => c.Invoices)
                .WithRequired(i => i.Customer);
        }
    }
}

using FacturatieKMO.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturatieKMO.DAL.Configuration
{
    internal class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("User");

            Property(u => u.UserId).HasColumnType("int");
            Property(c => c.Name).HasColumnType("varchar").HasMaxLength(100);
            Property(c => c.FirstName).HasColumnType("varchar").HasMaxLength(100);
            Property(c => c.Email).HasColumnType("varchar").HasMaxLength(100);
            Property(c => c.Address).HasColumnType("varchar").HasMaxLength(200);

            HasKey<int>(u => u.UserId);

            HasMany(u => u.Invoices)
                .WithRequired(i => i.User);
        }
    }
}

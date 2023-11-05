using festivals.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class ConcertConfiguration : IEntityTypeConfiguration<Concert>
    {
        public void Configure(EntityTypeBuilder<Concert> builder)
        {
            foreach (var property in builder.Metadata.ClrType.GetProperties()
                .Where(p => p.PropertyType == typeof(string)))
            {
                builder.Property(property.Name)
                    .HasMaxLength(50);
            }
        }
    }
}

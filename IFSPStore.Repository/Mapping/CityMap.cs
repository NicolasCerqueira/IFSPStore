using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Mapping
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure (EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(p => p.State)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}

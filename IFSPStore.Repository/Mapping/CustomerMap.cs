using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.DocumentId)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.Address)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.District)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasOne(prop => prop.City)
                .WithMany()
                .HasForeignKey(prop => prop.CityId);
        }
    }
}

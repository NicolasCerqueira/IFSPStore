using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(50);
            //.HasColumnType("varchar(50)");
            builder.Property(prop => prop.Description)
            .IsRequired()
            .HasMaxLength(1000);
        }
    }
}

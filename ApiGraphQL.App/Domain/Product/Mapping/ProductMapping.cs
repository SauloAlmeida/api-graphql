using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiGraphQL.App.Domain.Product.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Model.Product>
    {
        public void Configure(EntityTypeBuilder<Model.Product> builder)
        {
            // builder.ToTable("Product");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Price).IsRequired();
            builder.HasOne(p => p.Category).WithMany(w => w.Products).HasForeignKey(fk => fk.CategoryId);
        }
    }
}

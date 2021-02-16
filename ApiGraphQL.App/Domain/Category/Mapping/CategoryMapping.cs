using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiGraphQL.App.Domain.Category.Mapping
{
    public class CategoryMapping : IEntityTypeConfiguration<Model.Category>
    {
        public void Configure(EntityTypeBuilder<Model.Category> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

            builder.HasMany(p => p.Products).WithOne(w => w.Category).HasForeignKey(fk => fk.CategoryId);
        }
    }
}

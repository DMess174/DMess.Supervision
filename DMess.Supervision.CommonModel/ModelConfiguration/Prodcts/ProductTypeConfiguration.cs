using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration.Products
{
    public class ProductTypeConfiguration : BaseAuditableEntityConfiguration<ProductType>
    {
        public override void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.ToTable("ProductTypes");

            base.Configure(builder);

            builder.Property(x => x.FullName).HasMaxLength(250);
            builder.Property(x => x.ShortName).HasMaxLength(20);

            builder.HasMany(x => x.Factories).WithMany(x => x.ProductTypes);
            builder.HasMany(x => x.PIDs).WithOne(x => x.ProductType);
        }
    }
}

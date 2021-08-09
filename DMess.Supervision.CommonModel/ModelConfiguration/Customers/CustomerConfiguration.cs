using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration.Customers
{
    public class CustomerConfiguration : BaseAuditableEntityConfiguration<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            base.Configure(builder);

            builder.Property(x => x.FullName).HasMaxLength(256).IsRequired();
            builder.Property(x => x.ShortName).HasMaxLength(128).IsRequired();

            builder.HasMany(x => x.Contracts).WithOne(x => x.Customer);
            builder.HasMany(x => x.Specifications).WithOne(x => x.Customer);
        }
    }
}

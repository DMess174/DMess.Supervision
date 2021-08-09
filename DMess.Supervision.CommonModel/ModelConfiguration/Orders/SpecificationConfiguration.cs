using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration.Orders
{
    public class SpecificationConfiguration : BaseAuditableEntityConfiguration<Specification>
    {
        public override void Configure(EntityTypeBuilder<Specification> builder)
        {
            builder.ToTable("Specifications");

            base.Configure(builder);

            builder.Property(x => x.Number);
            builder.Property(x => x.Facility);
            builder.Property(x => x.Programme);
            builder.Property(x => x.Status);

            builder.HasMany(x => x.PIDs).WithOne(x => x.Specification);
            builder.HasOne(x => x.Customer).WithMany(x => x.Specifications);

        }
    }
}

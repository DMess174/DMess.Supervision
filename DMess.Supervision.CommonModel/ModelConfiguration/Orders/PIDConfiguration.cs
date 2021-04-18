using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration.Orders
{
    public class PIDConfiguration : BaseOrderEntityConfiguration<PID>
    {
        public override void Configure(EntityTypeBuilder<PID> builder)
        {
            builder.ToTable("PIDs");

            base.Configure(builder);

            builder.HasOne(x => x.Specification).WithMany(x => x.PIDs);
            builder.HasOne(x => x.Factory).WithMany(x => x.PIDs);
            builder.HasOne(x => x.ProductType).WithMany(x => x.PIDs);
        }
    }
}

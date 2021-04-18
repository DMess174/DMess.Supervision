using DMess.Supervision.CommonModel.Models.Orders;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration.Base
{
    public abstract class BaseOrderEntityConfiguration<TOrder> : BaseAuditableEntityConfiguration<TOrder> where TOrder: PID
    {
        public override void Configure(EntityTypeBuilder<TOrder> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Number).HasMaxLength(128).IsRequired();
            builder.Property(x => x.ProductQuantity).IsRequired();
            builder.Property(x => x.Consignee).HasMaxLength(4000).IsRequired();
            builder.Property(x => x.ShipmentDate).IsRequired();
            builder.Property(x => x.Status);
        }
    }
}

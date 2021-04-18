using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration.Orders
{
    public class ValvePIDConfigration : BaseOrderEntityConfiguration<ValvePID>
    {
        public override void Configure(EntityTypeBuilder<ValvePID> builder)
        {
            builder.ToTable("ValvePIDs");

            builder.Property(x => x.Diameter);
            builder.Property(x => x.PressureLimit);
            builder.Property(x => x.PressureDifference);
            builder.Property(x => x.ConnectionType);
            builder.Property(x => x.DriveType);
            builder.Property(x => x.SeismicStability);
            builder.Property(x => x.ClimaticModification);
        }
    }
}

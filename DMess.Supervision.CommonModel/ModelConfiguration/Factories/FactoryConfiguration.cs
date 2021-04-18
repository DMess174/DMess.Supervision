using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models.Factories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration.Factories
{
    public class FactoryConfiguration : BaseAuditableEntityConfiguration<Factory>
    {
        public override void Configure(EntityTypeBuilder<Factory> builder)
        {
            builder.ToTable("Factories");

            base.Configure(builder);

            builder.Property(x => x.FullName).HasMaxLength(256).IsRequired();
            builder.Property(x => x.ShortName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.City);

            builder.HasOne(x => x.SubdivisionDepartment).WithMany(x => x.Factories);
            builder.HasMany(x => x.ProductTypes).WithMany(x => x.Factories);
            builder.HasMany(x => x.Employees).WithMany(x => x.Factories);
            builder.HasMany(x => x.PIDs).WithOne(x => x.Factory);
        }
    }
}

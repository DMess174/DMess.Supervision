using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration
{
    public class SubdivisionConfiguration : BaseAuditableEntityConfiguration<Subdivision>
    {
        public override void Configure(EntityTypeBuilder<Subdivision> builder)
        {
            builder.ToTable("Subdivisions");

            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasMaxLength(250)
                .IsRequired();
            builder.Property(x => x.City)
                .HasMaxLength(250)
                .IsRequired();

            builder.HasMany(x => x.Departments).WithOne(x => x.Subdivision);
        }
    }
}

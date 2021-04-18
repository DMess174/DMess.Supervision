using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration
{
    public class DepartmentConfiguration : BaseAuditableEntityConfiguration<Department>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");

            base.Configure(builder);

            builder.Property(x => x.FullName)
                .HasMaxLength(250)
                .IsRequired();
            builder.Property(x => x.ShortName)
                .HasMaxLength(32)
                .IsRequired();

            builder.HasMany(x => x.Subdivisions).WithOne(x => x.Department);
        }
    }
}

using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration
{
    public class SubdivisionDepartmentConfiguration : BaseAuditableEntityConfiguration<SubdivisionDepartment>
    {
        public override void Configure(EntityTypeBuilder<SubdivisionDepartment> builder)
        {
            builder.ToTable("SubdivisionDepartments");

            base.Configure(builder);

            builder.HasOne(x => x.Department).WithMany(x => x.Subdivisions);
            builder.HasOne(x => x.Subdivision).WithMany(x => x.Departments);
            builder.HasMany(x => x.Employees).WithOne(x => x.Department);
            builder.HasMany(x => x.Factories).WithOne(x => x.SubdivisionDepartment);
        }
    }
}

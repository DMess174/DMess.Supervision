using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration
{
    public class EmployeeConfiguration : BaseAuditableEntityConfiguration<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            base.Configure(builder);

            builder.Property(x => x.FirstName)
                .HasMaxLength(128)
                .IsRequired();
            builder.Property(x => x.LastName)
                .HasMaxLength(128)
                .IsRequired();
            builder.Property(x => x.Patronymic).HasMaxLength(128);
            builder.Property(x => x.Email).HasMaxLength(256);
            builder.Property(x => x.PhoneNumber).HasMaxLength(32);
            builder.Property(x => x.PhotoPath);
            builder.Property(x => x.BirthDate);

            builder.HasOne(x => x.Account).WithOne(x => x.Employee);
            builder.HasOne(x => x.Post).WithMany(x => x.Employees);
            builder.HasOne(x => x.Department).WithMany(x => x.Employees);
            builder.HasMany(x => x.Factories).WithMany(x => x.Employees);
        }
    }
}

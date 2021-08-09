using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration
{
    public class AccountConfiguration : BaseAuditableEntityConfiguration<Account>
    {
        public override void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");

            base.Configure(builder);

            builder.Property(x => x.UserName)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.PasswordHash)
                .IsRequired()
                .HasDefaultValue("AQAAAAEAACcQAAAAECT00KjvtAVyzKObssU/KA/V0LsXaAzUZPgS+1E9Rr4G/7kVr69RrN1T+wXeZZgUJA==");
            builder.Property(x => x.IsLoggedIn);

            builder.HasOne(x => x.Employee).WithOne(x => x.Account);
        }
    }
}

using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration.Contracts
{
    public class ContractConfiguration : BaseAuditableEntityConfiguration<Contract>
    {
        public override void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("Contracts");

            base.Configure(builder);

            builder.Property(x => x.Number).HasMaxLength(128).IsRequired();
            builder.Property(x => x.IsInForce);
            builder.Property(x => x.SignDate);

            builder.HasOne(x => x.Customer).WithMany(x => x.Contracts);
        }
    }
}

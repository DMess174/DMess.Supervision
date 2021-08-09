using DMess.Supervision.CommonModel.ModelConfiguration.Base;
using DMess.Supervision.CommonModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMess.Supervision.CommonModel.ModelConfiguration
{
    public class PostConfiguration : BaseAuditableEntityConfiguration<Post>
    {
        public override void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");

            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasMaxLength(250)
                .IsRequired();

            builder.HasMany(x => x.Employees).WithOne(x => x.Post);
        }
    }
}

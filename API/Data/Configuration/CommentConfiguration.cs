using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {

            builder.Property(c => c.Id).IsRequired();
            builder.Property(c => c.Description).IsRequired().HasMaxLength(1024);
            builder.Property(c => c.PostId).IsRequired();
            builder.Property(c => c.UserId).IsRequired();
            builder.Property(c => c.CreationTime).IsRequired();
            builder.HasOne(p => p.Post).WithMany().HasForeignKey(k => k.PostId);
            builder.HasOne(u => u.User).WithMany().HasForeignKey(k => k.UserId);

        }
    }
}

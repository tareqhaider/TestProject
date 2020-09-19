using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Description).IsRequired().HasMaxLength(1024);
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.CreationTime).IsRequired();
            builder.HasMany(p => p.Comments).WithOne(u=>u.Post).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

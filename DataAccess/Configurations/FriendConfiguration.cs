using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friends>
    {
        public void Configure(EntityTypeBuilder<Friends> builder)
        {
            builder.ToTable("Friends");
            builder.HasKey(x => x.friend_id);

            builder.Property(x => x.last_modified).IsRequired().HasDefaultValue(new DateTime());
            builder.HasOne(x => x.user).WithMany(x => x.friends).HasForeignKey(x => x.user_id);
            builder.HasOne(x => x.friend_user).WithMany(x => x.friends_user).HasForeignKey(x => x.friend_user_id);

        }
    }
}

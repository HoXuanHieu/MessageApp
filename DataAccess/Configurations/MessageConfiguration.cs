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
    public class MessageConfiguration : IEntityTypeConfiguration<Messages>
    {
        public void Configure(EntityTypeBuilder<Messages> builder)
        {
            builder.ToTable("Messages");

            builder.HasKey(x => x.message_id);
            builder.Property(x => x.message).IsRequired().HasMaxLength(200);
            builder.Property(x => x.date_send).IsRequired().HasDefaultValue(new DateTime());
            builder.Property(x => x.last_modified).IsRequired().HasDefaultValue(new DateTime());

            builder.HasOne(x => x.friend).WithMany(x => x.messages).HasForeignKey(x => x.friend_id);
        }
    }
}

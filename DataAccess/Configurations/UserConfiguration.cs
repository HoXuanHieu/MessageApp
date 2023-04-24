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
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.user_id);

            builder.Property(x => x.user_name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.first_name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.last_name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.email).IsRequired().HasMaxLength(100);

            builder.Property(x => x.last_modified).IsRequired().HasDefaultValue(new DateTime());

        }


    }

}
